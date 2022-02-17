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
            this.Pictures = new System.Windows.Forms.PictureBox();
            this.bt_add = new System.Windows.Forms.Button();
            this.bt_rem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Pictures)).BeginInit();
            this.SuspendLayout();
            // 
            // Pictures
            // 
            this.Pictures.Location = new System.Drawing.Point(1, 2);
            this.Pictures.Name = "Pictures";
            this.Pictures.Size = new System.Drawing.Size(621, 512);
            this.Pictures.TabIndex = 4;
            this.Pictures.TabStop = false;
            this.Pictures.Paint += new System.Windows.Forms.PaintEventHandler(this.Pictures_Paint);
            this.Pictures.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Pictures_MouseDown);
            this.Pictures.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Pictures_MouseMove);
            // 
            // bt_add
            // 
            this.bt_add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_add.Location = new System.Drawing.Point(628, 2);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(161, 32);
            this.bt_add.TabIndex = 6;
            this.bt_add.Text = "Add";
            this.bt_add.UseVisualStyleBackColor = true;
            this.bt_add.Click += new System.EventHandler(this.bt_add_Click);
            // 
            // bt_rem
            // 
            this.bt_rem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_rem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_rem.Location = new System.Drawing.Point(628, 40);
            this.bt_rem.Name = "bt_rem";
            this.bt_rem.Size = new System.Drawing.Size(161, 34);
            this.bt_rem.TabIndex = 5;
            this.bt_rem.Text = "Rem";
            this.bt_rem.UseVisualStyleBackColor = true;
            this.bt_rem.Click += new System.EventHandler(this.bt_rem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 521);
            this.Controls.Add(this.bt_add);
            this.Controls.Add(this.bt_rem);
            this.Controls.Add(this.Pictures);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.Pictures)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox Pictures;
        private System.Windows.Forms.Button bt_add;
        private System.Windows.Forms.Button bt_rem;
    }
}

