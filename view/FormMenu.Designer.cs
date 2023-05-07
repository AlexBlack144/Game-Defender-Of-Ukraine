namespace Game_Kursak.view
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.label1 = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.statistics = new System.Windows.Forms.Button();
            this.survival = new System.Windows.Forms.Button();
            this.company = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Maroon;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Chiller", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 56);
            this.label1.TabIndex = 4;
            this.label1.Text = "Defender of Ukraine";
            // 
            // exit
            // 
            this.exit.BackgroundImage = global::Game_Kursak.Properties.Resources.kamuflyag;
            this.exit.FlatAppearance.BorderSize = 2;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.Font = new System.Drawing.Font("Chiller", 26.25F, System.Drawing.FontStyle.Bold);
            this.exit.ForeColor = System.Drawing.Color.DarkRed;
            this.exit.Location = new System.Drawing.Point(94, 246);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(163, 48);
            this.exit.TabIndex = 3;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // statistics
            // 
            this.statistics.BackgroundImage = global::Game_Kursak.Properties.Resources.kamuflyag;
            this.statistics.FlatAppearance.BorderSize = 2;
            this.statistics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.statistics.Font = new System.Drawing.Font("Chiller", 26.25F, System.Drawing.FontStyle.Bold);
            this.statistics.ForeColor = System.Drawing.Color.DarkRed;
            this.statistics.Location = new System.Drawing.Point(94, 192);
            this.statistics.Name = "statistics";
            this.statistics.Size = new System.Drawing.Size(163, 48);
            this.statistics.TabIndex = 2;
            this.statistics.Text = "Statistics";
            this.statistics.UseVisualStyleBackColor = true;
            this.statistics.Click += new System.EventHandler(this.statistics_Click);
            // 
            // survival
            // 
            this.survival.BackgroundImage = global::Game_Kursak.Properties.Resources.kamuflyag;
            this.survival.FlatAppearance.BorderSize = 2;
            this.survival.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.survival.Font = new System.Drawing.Font("Chiller", 26.25F, System.Drawing.FontStyle.Bold);
            this.survival.ForeColor = System.Drawing.Color.DarkRed;
            this.survival.Location = new System.Drawing.Point(94, 132);
            this.survival.Name = "survival";
            this.survival.Size = new System.Drawing.Size(163, 54);
            this.survival.TabIndex = 1;
            this.survival.Text = "Survival";
            this.survival.UseVisualStyleBackColor = true;
            this.survival.Click += new System.EventHandler(this.button_Survival_Click);
            // 
            // company
            // 
            this.company.BackColor = System.Drawing.SystemColors.Desktop;
            this.company.BackgroundImage = global::Game_Kursak.Properties.Resources.kamuflyag;
            this.company.Cursor = System.Windows.Forms.Cursors.Default;
            this.company.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.company.FlatAppearance.BorderSize = 2;
            this.company.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.company.Font = new System.Drawing.Font("Chiller", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.company.ForeColor = System.Drawing.Color.DarkRed;
            this.company.Location = new System.Drawing.Point(94, 73);
            this.company.Name = "company";
            this.company.Size = new System.Drawing.Size(163, 54);
            this.company.TabIndex = 0;
            this.company.Text = "Company";
            this.company.UseVisualStyleBackColor = false;
            this.company.Click += new System.EventHandler(this.button_company_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImage = global::Game_Kursak.Properties.Resources.bagraund_menu;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(344, 306);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.statistics);
            this.Controls.Add(this.survival);
            this.Controls.Add(this.company);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Defender of Ukraine";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button company;
        private System.Windows.Forms.Button survival;
        private System.Windows.Forms.Button statistics;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button exit;
    }
}