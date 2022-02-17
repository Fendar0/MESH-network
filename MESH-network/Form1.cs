﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
        int value;

        private void bt_add_Click(object sender, EventArgs e)
        {
            Circle fig = new Circle();
            if (fig == null) return;
            fig.pos_x = 100.0f;
            fig.pos_y = 100.0f;
            lst.Add(fig);
            Pictures.Invalidate();
            Program.circle.Sizearray(lst.Count);
        }        

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
                        break;
                    }
                }
            }                        

            Pictures.Invalidate();
        }

        private void Pictures_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 10)
            {
                value += 2;
                btmu = "wheelup";
            }
            else if (e.Delta < 0)
            {
                if(value != 0)
                value -= 2;
                btmu = "wheeldown";
            }
            Pictures.Invalidate();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            w = ClientRectangle.Width - 200;
            h = ClientRectangle.Height - Pictures.Top - 10;

            Pictures.Width = w;
            Pictures.Height = h;
        }

        private void bt_rem_Click(object sender, EventArgs e)
        {            
            int i = 0;
            while (i < lst.Count)
            {
                if (lst[i].selected == true)
                {
                    lst.RemoveAt(i);
                }
                i++;
            }
            Pictures.Invalidate();
        }

        private void Pictures_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(br, 0, 0, Pictures.Width, Pictures.Height);
            foreach (Circle fig in lst)
            {
                fig.draw(e.Graphics, btmu);
                fig.drawTrans(e.Graphics, btmu, value);
            }            
        }

        public Form1()
        {            
            InitializeComponent();            
        }               

    }
}
