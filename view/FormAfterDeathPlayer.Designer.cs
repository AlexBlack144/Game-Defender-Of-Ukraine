namespace Game_Kursak.view
{
    partial class FormAfterDeathPlayer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.save = new System.Windows.Forms.Button();
            this.restart = new System.Windows.Forms.Button();
            this.menu = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.textBox_nickName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.SystemColors.Desktop;
            this.save.BackgroundImage = global::Game_Kursak.Properties.Resources.kamuflyag;
            this.save.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.save.FlatAppearance.BorderSize = 2;
            this.save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save.Font = new System.Drawing.Font("Chiller", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save.ForeColor = System.Drawing.Color.DarkRed;
            this.save.Location = new System.Drawing.Point(89, 97);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(171, 52);
            this.save.TabIndex = 5;
            this.save.Text = "Save Result";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // restart
            // 
            this.restart.BackColor = System.Drawing.SystemColors.Desktop;
            this.restart.BackgroundImage = global::Game_Kursak.Properties.Resources.kamuflyag;
            this.restart.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.restart.FlatAppearance.BorderSize = 2;
            this.restart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.restart.Font = new System.Drawing.Font("Chiller", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restart.ForeColor = System.Drawing.Color.DarkRed;
            this.restart.Location = new System.Drawing.Point(89, 155);
            this.restart.Name = "restart";
            this.restart.Size = new System.Drawing.Size(171, 52);
            this.restart.TabIndex = 6;
            this.restart.Text = "Restart";
            this.restart.UseVisualStyleBackColor = false;
            this.restart.Click += new System.EventHandler(this.restart_Click);
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.SystemColors.Desktop;
            this.menu.BackgroundImage = global::Game_Kursak.Properties.Resources.kamuflyag;
            this.menu.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.menu.FlatAppearance.BorderSize = 2;
            this.menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu.Font = new System.Drawing.Font("Chiller", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu.ForeColor = System.Drawing.Color.DarkRed;
            this.menu.Location = new System.Drawing.Point(89, 213);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(171, 52);
            this.menu.TabIndex = 7;
            this.menu.Text = "Menu";
            this.menu.UseVisualStyleBackColor = false;
            this.menu.Click += new System.EventHandler(this.menu_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.SystemColors.Desktop;
            this.exit.BackgroundImage = global::Game_Kursak.Properties.Resources.kamuflyag;
            this.exit.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.exit.FlatAppearance.BorderSize = 2;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.Font = new System.Drawing.Font("Chiller", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.Color.DarkRed;
            this.exit.Location = new System.Drawing.Point(89, 271);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(171, 52);
            this.exit.TabIndex = 8;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // textBox_nickName
            // 
            this.textBox_nickName.BackColor = System.Drawing.Color.DarkRed;
            this.textBox_nickName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_nickName.Font = new System.Drawing.Font("Chiller", 26.25F, System.Drawing.FontStyle.Bold);
            this.textBox_nickName.Location = new System.Drawing.Point(45, 44);
            this.textBox_nickName.Multiline = true;
            this.textBox_nickName.Name = "textBox_nickName";
            this.textBox_nickName.Size = new System.Drawing.Size(268, 47);
            this.textBox_nickName.TabIndex = 9;
            this.textBox_nickName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_nickName.TextChanged += new System.EventHandler(this.textBox_nickName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Chiller", 28.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(81, -3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 44);
            this.label1.TabIndex = 10;
            this.label1.Text = "Your Nickname";
            // 
            // FormAfterDeathPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::Game_Kursak.Properties.Resources.bagraund_menu;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(356, 342);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_nickName);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.restart);
            this.Controls.Add(this.save);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAfterDeathPlayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAfterDeathPlayer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button restart;
        private System.Windows.Forms.Button menu;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.TextBox textBox_nickName;
        private System.Windows.Forms.Label label1;
    }
}