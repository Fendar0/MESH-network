using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MESH_network
{
    public partial class Form1 : Form
    {
        int w = 50, h = 50;
        int old_x, old_y;
        List<Circle> lst = new List<Circle>();
        SolidBrush br = new SolidBrush(Color.FromArgb(255, 255, 255));
        string btmu;
        int indexRecip, indexTruns;
        int nextID;
        Socket socket;
        List<string> cmd = new List<string>(); //list commands
        List<string> lstnamemap = new List<string>();


        /// <summary>
        /// Метод кнопки создания узла
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_add_Click(object sender, EventArgs e)
        {
            Circle fig = new Circle();

            int id = listBoxMap.SelectedIndex;
            string s = lstnamemap[id];

            fig.name = tb_name.Text;
            fig.description = tb_desc.Text;
            fig.location = tb_loc.Text;
            if (fig == null) return;
            fig.pos_x = 100.0f;
            fig.pos_y = 100.0f;
            lst.Add(fig);

            send($"add-node {s} {fig.pos_x} {fig.pos_y} {fig.diametr_trunsmitter} {tb_name.Text}");
                        
            Pictures.Invalidate();
            Program.circle.Sizearray(lst.ToList());
            tb_desc.Clear();
            tb_loc.Clear();
            tb_name.Clear();
        }           

        /// <summary>
        /// Метод перемещения узла по карте
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Pictures_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int dx = e.X - old_x;
                int dy = e.Y - old_y;

                foreach (Circle fig in lst)
                {
                    if (fig.selected == false) continue;
                    fig.pos_x += dx;
                    fig.pos_y += dy;
                }
                Pictures.Invalidate();
            }
            old_x = e.X;
            old_y = e.Y;              
        }

        /// <summary>
        /// Метод выбора(select) узла
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Pictures_MouseDown(object sender, MouseEventArgs e)
        {
            Pictures.MouseWheel += new MouseEventHandler(Pictures_MouseWheel);
            if (e.Button == MouseButtons.Left)
            {
                btmu = "left";
                foreach (Circle fig in lst)
                    fig.selected = false;

                for (int i = lst.Count - 1; i >= 0; i--)
                {
                    Circle fig = lst[i];
                    fig.selected |= fig.test(e.X, e.Y);
                    if (fig.selected == true)
                    {
                        tb_name.Text = fig.name;
                        tb_desc.Text = fig.description;
                        tb_loc.Text = fig.location;
                        indexTruns = i;
                        break;
                    }
                }
            }
            else if(e.Button == MouseButtons.Right)
            {
                btmu = "right";
                foreach (Circle fig in lst)
                    fig.selected = false;

                for (int i = lst.Count - 1; i >= 0; i--)
                {
                    Circle fig = lst[i];
                    fig.selected |= fig.test(e.X, e.Y);
                    if (fig.selected == true)
                    {
                        indexRecip = i;
                        break;
                    }
                }
            }            
            Pictures.Invalidate();
        }

        /// <summary>
        /// Метод изменения размеров круга маршрутизации
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Pictures_MouseWheel(object sender, MouseEventArgs e)
        {
            foreach (Circle fig in lst)
                fig.selected = false;

            for (int i = lst.Count - 1; i >= 0; i--)
            {
                Circle fig = lst[i];
                fig.selected |= fig.test(e.X, e.Y);
                if (fig.selected == true)
                {
                    if (e.Delta > 10)
                    {
                        if(fig.diametr_trunsmitter > 100)
                        fig.diametr_trunsmitter -= 4;
                        btmu = "wheelup";
                    }
                    else if (e.Delta < 0)
                    {                               
                        fig.diametr_trunsmitter += 4;
                        btmu = "wheeldown";
                    }
                    break;
                }
            }
            Pictures.Invalidate();
        }

        /// <summary>
        /// Метод изменения размеров окна
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Resize(object sender, EventArgs e)
        {
            w = ClientRectangle.Width - 700;
            h = ClientRectangle.Height - Pictures.Top - 10;

            Pictures.Width = w;
            Pictures.Height = h;
        }

        private void bt_save_Click(object sender, EventArgs e)
        {
            nextID = lst.Count + 1;
            Program.circle.RecordInArr(indexRecip, indexTruns, nextID);
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            using (StreamWriter sw = new StreamWriter(saveFileDialog1.FileName))
            {
                foreach (string s in Program.circle.circles2)
                    sw.WriteLine(s);
                sw.Close();
            }

        }

        private void bt_load_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "txt files (*.txt)|*.txt";
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;


            using (StreamReader sr = new StreamReader(openFileDialog1.FileName))
            {               
                foreach (string line in File.ReadAllLines(openFileDialog1.FileName).Skip(2))
                {       
                    Circle fig = new Circle();
                    string[] s = new string[8];                    
                    for (int i = 0; i < s.Length; i++)
                    {
                        s = line.Split(' ');                        
                    }
                    fig.SetLoadMap(s[0], s[1], s[2], s[3], s[4], s[5], s[6], s[7]);
                    lst.Add(fig);
                }

                foreach (string line3 in File.ReadAllLines(openFileDialog1.FileName).Take(1))
                {
                    Circle fig = new Circle();
                    fig.nextID = Convert.ToInt32(line3);
                }

                string[] s2 = new string[2];
                foreach (string line4 in File.ReadAllLines(openFileDialog1.FileName).Skip(1).Take(1))
                {
                    s2 = line4.Split(' ');
                    Circle fig = new Circle();
                    fig.IDTrunsmitter = Convert.ToInt32(s2[0]);
                    fig.IDRecipient = Convert.ToInt32(s2[1]);
                }                
                sr.Close();                
            }                       

            Pictures.Invalidate();
        }

        void idle()
        {
            string acc = ""; //буфер для комманды

            byte[] buf = new byte[512];
            while (true)
            {

                int len = socket.Receive(buf);

                if (len == 0) break; //closed conn

                string part = Encoding.ASCII.GetString(buf, 0, len);
                acc += part;

                while (true) //find CR+LF
                {
                    int pos = acc.IndexOf(Environment.NewLine);
                    if (pos < 0) break;
                    string str = acc.Substring(0, pos); //отделяем команду 
                    acc = acc.Substring(pos + 2);
                    cmd.Add(str); // добавляем отделеную команду в лист
                }
            }
        }
                
        private void bt_connect_Click(object sender, EventArgs e)
        {
            //новый сокет
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socket.Connect("v1.fxnode.ru", 7510);

            ThreadStart st = new ThreadStart(idle); //функция включения потока
            Thread th = new Thread(st);
            th.Start();

            //посылаем команду авторизации
            send($"auth {tb_login.Text} {tb_pass.Text}");
            send("list-nets");
            timer2.Interval = 15000;
            timer2.Start();
            timer1.Start();
        }
        
        void send(string msg) //отправка на сервер
        {
            string txt = msg + Environment.NewLine;
            byte[] buf = Encoding.ASCII.GetBytes(txt);
            socket.Send(buf);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            while (cmd.Count > 0)
            {
                string res = cmd[0];
                cmd.RemoveAt(0);
                if (res == "auth-ok")
                    MessageBox.Show("good");
                if (res == "auth-fail")
                {
                    MessageBox.Show("down");
                    timer2.Stop();
                }
                else if (res == "net-begin")
                {
                    listBoxMap.Items.Clear();
                    foreach (var item in cmd)
                    {
                        string s2 = item.ToString();
                        if (s2 == "net-end")
                            break;
                        string[] r = new string[5];
                        r = s2.Split(' ');
                        lstnamemap.Add(r[1]);
                        listBoxMap.Items.Add(r[1] + " " + r[2] + " " + r[3] + " " + r[4]);
                    }
                }
                else if (res.Contains("create-net-ok"))
                    MessageBox.Show("map created");
                else if (res.Contains("create-net-fail"))
                    MessageBox.Show("Map with tha same name already exists");
                else if (res.Contains("remove-net-ok"))
                    MessageBox.Show("removal was successful");
                else if (res.Contains("remove-net-fail"))
                    MessageBox.Show("you are not the owner of the card or the card does not exist");
                else if (res.Contains("rename-net-ok"))
                    MessageBox.Show("rename was successful");
                else if (res.Contains("rename-net-fail"))
                    MessageBox.Show("The schema does not exist, does not belong to the user, a schema with a new name" +
                        " already exists, or the old and new names are the same");
                else if (res.Contains("add-node-ok"))
                {
                    MessageBox.Show("create was successful");
                    Circle fig = new Circle();
                    foreach (var item in cmd)
                    {
                        string s2 = item.ToString();
                        string[] r = new string[5];
                        r = s2.Split(' ');
                        fig.id = r[0];
                    }
                }
                else if (res.Contains("add-node-fail"))
                    MessageBox.Show("Schema does not exist or cannot be accessed");
                else if (res.Contains("remove-node-ok"))
                    MessageBox.Show("remove node was ok");
                else if (res.Contains("remove-node-fail"))
                    MessageBox.Show("Schema does not exist, schema cannot be accessed, or node with given ID does not exist");
                else if (res.Contains("node-begin"))
                {
                    foreach (var item in cmd)
                    {
                        Circle fig = new Circle();
                        string s2 = item.ToString();
                        if (s2.Contains("node-end"))
                            break;
                        string[] r = new string[5];
                        r = s2.Split(' ');
                        fig.id = r[1];
                        fig.pos_x = Convert.ToInt32(r[2]);
                        fig.pos_y = Convert.ToInt32(r[3]);
                        fig.diametr_trunsmitter = Convert.ToInt32(r[4]);
                        fig.name = r[5];
                        lst.Add(fig);
                        Pictures.Invalidate();
                    }
                }
                else if (res.Contains("list-node-fail"))
                    MessageBox.Show("Schema does not exist, does not belong to you, or is not shared with you");
                else if(res.Contains("alter-node-ok"))
                {
                    foreach (var item in cmd)
                    {
                        Circle fig = new Circle();
                        string s2 = item.ToString();
                        if (s2.Contains("node-end"))
                            break;
                        string[] r = new string[5];
                        r = s2.Split(' ');
                        fig.id = r[1];
                        fig.pos_x = Convert.ToInt32(r[2]);
                        fig.pos_y = Convert.ToInt32(r[3]);
                        fig.diametr_trunsmitter = Convert.ToInt32(r[4]);
                        fig.name = r[5];
                        lst.Add(fig);                        
                        Pictures.Invalidate();
                    }
                }
                else if(res.Contains("alter-node-fail"))
                    MessageBox.Show("Schema does not exist, there is no access to the schema, or there is no node with the specified ID");
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            send("ping");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
                      
        }

        private void bt_create_Click(object sender, EventArgs e)
        {            
            send($"create-net {tb_name_map.Text}");
            send("list-nets");
            tb_name_map.Clear();
        }

        private void bt_rename_Click(object sender, EventArgs e)
        {
            int id = listBoxMap.SelectedIndex;
            string s = lstnamemap[id];
            send($"rename-net {s} {tb_name_map.Text}");
            send("list-nets");
            tb_name_map.Clear();
        }

        private void bt_rem_map_Click(object sender, EventArgs e)
        {
            int id = listBoxMap.SelectedIndex;
            string s = lstnamemap[id];
            send($"remove-net {s}");
            send("list-nets");
        }

        private void bt_upload_Click(object sender, EventArgs e)
        {
            int id = listBoxMap.SelectedIndex;
            string s = lstnamemap[id];
            send($"list-nodes {s}");
        }

        private void bt_edit_node_Click(object sender, EventArgs e)
        {
            int id = listBoxMap.SelectedIndex;
            string s = lstnamemap[id];

            foreach (Circle fig in lst)
            {
                if (fig.selected == false) continue;             

                send($"alter-node {s} {fig.id} {fig.pos_x} {fig.pos_y} {fig.diametr_trunsmitter} {fig.name}");
            }
        }

        private void Pictures_MouseUp(object sender, MouseEventArgs e)
        {
            int dx = e.X - old_x;
            int dy = e.Y - old_y;

            foreach (Circle fig in lst)
            {
                if (fig.selected == false) continue;
                fig.pos_x += dx;
                fig.pos_y += dy;

                int id = listBoxMap.SelectedIndex;
                string s = lstnamemap[id];

                send($"alter-node {s} {fig.id} {fig.pos_x} {fig.pos_y} {fig.diametr_trunsmitter} {fig.name}");
            }
            Pictures.Invalidate();
        }

        /// <summary>
        /// Метод кнопки удаления выбранного узла
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_rem_Click(object sender, EventArgs e)
        {
            Circle fig = new Circle();

            int id = listBoxMap.SelectedIndex;
            string s = lstnamemap[id];

            int i = 0;
            while (i < lst.Count)
            {
                if (lst[i].selected == true)
                {
                    lst.RemoveAt(i);
                    send($"remov-node {s} {i}");
                }
                i++;
            }                       

            Pictures.Invalidate();
        }

        /// <summary>
        /// Метод перерисовки карты при изменениях
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Pictures_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(br, 0, 0, Pictures.Width, Pictures.Height);
            foreach (Circle fig in lst)
            {
                fig.draw(e.Graphics, btmu);
                fig.drawTrans(e.Graphics, btmu, fig.pos_x, fig.pos_y, fig.diametr_trunsmitter);
            }
        }

        public Form1()
        {            
            InitializeComponent();            
        }               

    }
}
