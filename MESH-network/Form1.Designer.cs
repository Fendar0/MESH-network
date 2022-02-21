namespace MESH_network
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Pictures = new System.Windows.Forms.PictureBox();
            this.bt_add = new System.Windows.Forms.Button();
            this.bt_rem = new System.Windows.Forms.Button();
            this.bt_save = new System.Windows.Forms.Button();
            this.bt_load = new System.Windows.Forms.Button();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_desc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_loc = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.bt_connect = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_login = new System.Windows.Forms.TextBox();
            this.tb_pass = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.bt_rem_map = new System.Windows.Forms.Button();
            this.bt_create = new System.Windows.Forms.Button();
            this.bt_rename = new System.Windows.Forms.Button();
            this.listBoxMap = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_upload = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_name_map = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bt_edit_node = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Pictures)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pictures
            // 
            this.Pictures.Location = new System.Drawing.Point(1, 2);
            this.Pictures.Name = "Pictures";
            this.Pictures.Size = new System.Drawing.Size(614, 554);
            this.Pictures.TabIndex = 4;
            this.Pictures.TabStop = false;
            this.Pictures.Paint += new System.Windows.Forms.PaintEventHandler(this.Pictures_Paint);
            this.Pictures.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Pictures_MouseDown);
            this.Pictures.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Pictures_MouseMove);
            this.Pictures.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Pictures_MouseUp);
            // 
            // bt_add
            // 
            this.bt_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_add.Location = new System.Drawing.Point(15, 292);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(161, 32);
            this.bt_add.TabIndex = 6;
            this.bt_add.Text = "Add";
            this.bt_add.UseVisualStyleBackColor = true;
            this.bt_add.Click += new System.EventHandler(this.bt_add_Click);
            // 
            // bt_rem
            // 
            this.bt_rem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_rem.Location = new System.Drawing.Point(15, 328);
            this.bt_rem.Name = "bt_rem";
            this.bt_rem.Size = new System.Drawing.Size(161, 34);
            this.bt_rem.TabIndex = 5;
            this.bt_rem.Text = "Remove";
            this.bt_rem.UseVisualStyleBackColor = true;
            this.bt_rem.Click += new System.EventHandler(this.bt_rem_Click);
            // 
            // bt_save
            // 
            this.bt_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_save.Location = new System.Drawing.Point(185, 291);
            this.bt_save.Name = "bt_save";
            this.bt_save.Size = new System.Drawing.Size(161, 34);
            this.bt_save.TabIndex = 7;
            this.bt_save.Text = "Local save map";
            this.bt_save.UseVisualStyleBackColor = true;
            this.bt_save.Click += new System.EventHandler(this.bt_save_Click);
            // 
            // bt_load
            // 
            this.bt_load.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_load.Location = new System.Drawing.Point(185, 329);
            this.bt_load.Name = "bt_load";
            this.bt_load.Size = new System.Drawing.Size(161, 34);
            this.bt_load.TabIndex = 8;
            this.bt_load.Text = "Local load map";
            this.bt_load.UseVisualStyleBackColor = true;
            this.bt_load.Click += new System.EventHandler(this.bt_load_Click);
            // 
            // tb_name
            // 
            this.tb_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_name.Location = new System.Drawing.Point(13, 43);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(240, 29);
            this.tb_name.TabIndex = 9;
            // 
            // tb_desc
            // 
            this.tb_desc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_desc.Location = new System.Drawing.Point(13, 102);
            this.tb_desc.Multiline = true;
            this.tb_desc.Name = "tb_desc";
            this.tb_desc.Size = new System.Drawing.Size(330, 91);
            this.tb_desc.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(14, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "Описание";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(14, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 24);
            this.label3.TabIndex = 13;
            this.label3.Text = "Расположение";
            // 
            // tb_loc
            // 
            this.tb_loc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_loc.Location = new System.Drawing.Point(15, 223);
            this.tb_loc.Multiline = true;
            this.tb_loc.Name = "tb_loc";
            this.tb_loc.Size = new System.Drawing.Size(330, 63);
            this.tb_loc.TabIndex = 14;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // bt_connect
            // 
            this.bt_connect.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_connect.Location = new System.Drawing.Point(180, 480);
            this.bt_connect.Name = "bt_connect";
            this.bt_connect.Size = new System.Drawing.Size(163, 56);
            this.bt_connect.TabIndex = 15;
            this.bt_connect.Text = "Подключиться";
            this.bt_connect.UseVisualStyleBackColor = true;
            this.bt_connect.Click += new System.EventHandler(this.bt_connect_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(14, 409);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 24);
            this.label4.TabIndex = 16;
            this.label4.Text = "Логин";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(14, 440);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 24);
            this.label5.TabIndex = 17;
            this.label5.Text = "Пароль";
            // 
            // tb_login
            // 
            this.tb_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_login.Location = new System.Drawing.Point(103, 406);
            this.tb_login.Name = "tb_login";
            this.tb_login.Size = new System.Drawing.Size(240, 29);
            this.tb_login.TabIndex = 18;
            this.tb_login.Text = "g483-nikonov";
            // 
            // tb_pass
            // 
            this.tb_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_pass.Location = new System.Drawing.Point(103, 440);
            this.tb_pass.Name = "tb_pass";
            this.tb_pass.Size = new System.Drawing.Size(240, 29);
            this.tb_pass.TabIndex = 19;
            this.tb_pass.Text = "kFUdzN";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox1.Location = new System.Drawing.Point(25, 479);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(127, 52);
            this.checkBox1.TabIndex = 20;
            this.checkBox1.Text = "Сохранить\r\nпароль";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // bt_rem_map
            // 
            this.bt_rem_map.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_rem_map.Location = new System.Drawing.Point(49, 160);
            this.bt_rem_map.Name = "bt_rem_map";
            this.bt_rem_map.Size = new System.Drawing.Size(241, 34);
            this.bt_rem_map.TabIndex = 21;
            this.bt_rem_map.Text = "Remove map";
            this.bt_rem_map.UseVisualStyleBackColor = true;
            this.bt_rem_map.Click += new System.EventHandler(this.bt_rem_map_Click);
            // 
            // bt_create
            // 
            this.bt_create.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_create.Location = new System.Drawing.Point(49, 81);
            this.bt_create.Name = "bt_create";
            this.bt_create.Size = new System.Drawing.Size(241, 34);
            this.bt_create.TabIndex = 22;
            this.bt_create.Text = "Create map";
            this.bt_create.UseVisualStyleBackColor = true;
            this.bt_create.Click += new System.EventHandler(this.bt_create_Click);
            // 
            // bt_rename
            // 
            this.bt_rename.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_rename.Location = new System.Drawing.Point(49, 121);
            this.bt_rename.Name = "bt_rename";
            this.bt_rename.Size = new System.Drawing.Size(241, 34);
            this.bt_rename.TabIndex = 23;
            this.bt_rename.Text = "Rename map";
            this.bt_rename.UseVisualStyleBackColor = true;
            this.bt_rename.Click += new System.EventHandler(this.bt_rename_Click);
            // 
            // listBoxMap
            // 
            this.listBoxMap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxMap.FormattingEnabled = true;
            this.listBoxMap.ItemHeight = 20;
            this.listBoxMap.Location = new System.Drawing.Point(6, 204);
            this.listBoxMap.Name = "listBoxMap";
            this.listBoxMap.Size = new System.Drawing.Size(317, 164);
            this.listBoxMap.TabIndex = 24;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.bt_upload);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tb_name_map);
            this.groupBox1.Controls.Add(this.bt_rename);
            this.groupBox1.Controls.Add(this.listBoxMap);
            this.groupBox1.Controls.Add(this.bt_rem_map);
            this.groupBox1.Controls.Add(this.bt_create);
            this.groupBox1.Location = new System.Drawing.Point(621, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(329, 418);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Карта";
            // 
            // bt_upload
            // 
            this.bt_upload.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_upload.Location = new System.Drawing.Point(36, 374);
            this.bt_upload.Name = "bt_upload";
            this.bt_upload.Size = new System.Drawing.Size(241, 34);
            this.bt_upload.TabIndex = 25;
            this.bt_upload.Text = "Upload map";
            this.bt_upload.UseVisualStyleBackColor = true;
            this.bt_upload.Click += new System.EventHandler(this.bt_upload_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(96, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 24);
            this.label6.TabIndex = 21;
            this.label6.Text = "Имя карты";
            // 
            // tb_name_map
            // 
            this.tb_name_map.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_name_map.Location = new System.Drawing.Point(10, 46);
            this.tb_name_map.Name = "tb_name_map";
            this.tb_name_map.Size = new System.Drawing.Size(295, 29);
            this.tb_name_map.TabIndex = 21;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.bt_edit_node);
            this.groupBox2.Controls.Add(this.tb_desc);
            this.groupBox2.Controls.Add(this.bt_rem);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Controls.Add(this.bt_add);
            this.groupBox2.Controls.Add(this.tb_pass);
            this.groupBox2.Controls.Add(this.bt_save);
            this.groupBox2.Controls.Add(this.tb_login);
            this.groupBox2.Controls.Add(this.bt_load);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.tb_name);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.bt_connect);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tb_loc);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(956, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(352, 544);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Узлы";
            // 
            // bt_edit_node
            // 
            this.bt_edit_node.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_edit_node.Location = new System.Drawing.Point(15, 367);
            this.bt_edit_node.Name = "bt_edit_node";
            this.bt_edit_node.Size = new System.Drawing.Size(161, 34);
            this.bt_edit_node.TabIndex = 21;
            this.bt_edit_node.Text = "Edit";
            this.bt_edit_node.UseVisualStyleBackColor = true;
            this.bt_edit_node.Click += new System.EventHandler(this.bt_edit_node_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1314, 568);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Pictures);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.Pictures)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox Pictures;
        private System.Windows.Forms.Button bt_add;
        private System.Windows.Forms.Button bt_rem;
        private System.Windows.Forms.Button bt_save;
        private System.Windows.Forms.Button bt_load;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox tb_name;
        public System.Windows.Forms.TextBox tb_desc;
        public System.Windows.Forms.TextBox tb_loc;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button bt_connect;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox tb_login;
        public System.Windows.Forms.TextBox tb_pass;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button bt_rem_map;
        private System.Windows.Forms.Button bt_create;
        private System.Windows.Forms.Button bt_rename;
        private System.Windows.Forms.ListBox listBoxMap;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox tb_name_map;
        private System.Windows.Forms.Button bt_upload;
        private System.Windows.Forms.Button bt_edit_node;
    }
}

