namespace Game_Kursak.view
{
    partial class FormStatistics
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStatistics));
            this.button_Refresh = new System.Windows.Forms.Button();
            this.dataGridView_local_results = new System.Windows.Forms.DataGridView();
            this.label_Your_results = new System.Windows.Forms.Label();
            this.label_Rating_results = new System.Windows.Forms.Label();
            this.button_Back_to_Menu = new System.Windows.Forms.Button();
            this.dataGridView_network_results = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_local_results)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_network_results)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Refresh
            // 
            this.button_Refresh.BackgroundImage = global::Game_Kursak.Properties.Resources.kamuflyag;
            this.button_Refresh.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Refresh.Font = new System.Drawing.Font("Chiller", 26.25F, System.Drawing.FontStyle.Bold);
            this.button_Refresh.ForeColor = System.Drawing.Color.DarkRed;
            this.button_Refresh.Location = new System.Drawing.Point(682, 350);
            this.button_Refresh.Name = "button_Refresh";
            this.button_Refresh.Size = new System.Drawing.Size(144, 72);
            this.button_Refresh.TabIndex = 0;
            this.button_Refresh.Text = "Refresh";
            this.button_Refresh.UseVisualStyleBackColor = true;
            this.button_Refresh.Click += new System.EventHandler(this.buttonRefrash_Click);
            // 
            // dataGridView_local_results
            // 
            this.dataGridView_local_results.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Red;
            this.dataGridView_local_results.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_local_results.BackgroundColor = System.Drawing.Color.DimGray;
            this.dataGridView_local_results.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView_local_results.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dataGridView_local_results.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_local_results.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_local_results.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_local_results.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_local_results.GridColor = System.Drawing.Color.Gray;
            this.dataGridView_local_results.Location = new System.Drawing.Point(12, 67);
            this.dataGridView_local_results.Name = "dataGridView_local_results";
            this.dataGridView_local_results.ReadOnly = true;
            this.dataGridView_local_results.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_local_results.Size = new System.Drawing.Size(468, 278);
            this.dataGridView_local_results.TabIndex = 1;
            // 
            // label_Your_results
            // 
            this.label_Your_results.AutoSize = true;
            this.label_Your_results.BackColor = System.Drawing.Color.Transparent;
            this.label_Your_results.Font = new System.Drawing.Font("Chiller", 28.25F, System.Drawing.FontStyle.Bold);
            this.label_Your_results.ForeColor = System.Drawing.Color.Snow;
            this.label_Your_results.Location = new System.Drawing.Point(154, 17);
            this.label_Your_results.Name = "label_Your_results";
            this.label_Your_results.Size = new System.Drawing.Size(173, 44);
            this.label_Your_results.TabIndex = 3;
            this.label_Your_results.Text = "Your results:";
            // 
            // label_Rating_results
            // 
            this.label_Rating_results.AutoSize = true;
            this.label_Rating_results.BackColor = System.Drawing.Color.Transparent;
            this.label_Rating_results.Font = new System.Drawing.Font("Chiller", 28.25F, System.Drawing.FontStyle.Bold);
            this.label_Rating_results.ForeColor = System.Drawing.Color.Snow;
            this.label_Rating_results.Location = new System.Drawing.Point(649, 17);
            this.label_Rating_results.Name = "label_Rating_results";
            this.label_Rating_results.Size = new System.Drawing.Size(195, 44);
            this.label_Rating_results.TabIndex = 4;
            this.label_Rating_results.Text = "Rating results:";
            // 
            // button_Back_to_Menu
            // 
            this.button_Back_to_Menu.BackColor = System.Drawing.SystemColors.Desktop;
            this.button_Back_to_Menu.BackgroundImage = global::Game_Kursak.Properties.Resources.kamuflyag;
            this.button_Back_to_Menu.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button_Back_to_Menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Back_to_Menu.Font = new System.Drawing.Font("Chiller", 26.25F, System.Drawing.FontStyle.Bold);
            this.button_Back_to_Menu.ForeColor = System.Drawing.Color.DarkRed;
            this.button_Back_to_Menu.Location = new System.Drawing.Point(153, 351);
            this.button_Back_to_Menu.Name = "button_Back_to_Menu";
            this.button_Back_to_Menu.Size = new System.Drawing.Size(194, 72);
            this.button_Back_to_Menu.TabIndex = 5;
            this.button_Back_to_Menu.Text = "Back to Menu";
            this.button_Back_to_Menu.UseVisualStyleBackColor = false;
            this.button_Back_to_Menu.Click += new System.EventHandler(this.button_Back_to_Menu_Click);
            // 
            // dataGridView_network_results
            // 
            this.dataGridView_network_results.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Red;
            this.dataGridView_network_results.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView_network_results.BackgroundColor = System.Drawing.Color.DimGray;
            this.dataGridView_network_results.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView_network_results.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dataGridView_network_results.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_network_results.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView_network_results.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_network_results.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView_network_results.GridColor = System.Drawing.Color.Gray;
            this.dataGridView_network_results.Location = new System.Drawing.Point(504, 67);
            this.dataGridView_network_results.Name = "dataGridView_network_results";
            this.dataGridView_network_results.ReadOnly = true;
            this.dataGridView_network_results.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_network_results.Size = new System.Drawing.Size(468, 278);
            this.dataGridView_network_results.TabIndex = 6;
            // 
            // FormStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackgroundImage = global::Game_Kursak.Properties.Resources.kamuflyag;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 428);
            this.Controls.Add(this.dataGridView_network_results);
            this.Controls.Add(this.button_Back_to_Menu);
            this.Controls.Add(this.label_Rating_results);
            this.Controls.Add(this.label_Your_results);
            this.Controls.Add(this.dataGridView_local_results);
            this.Controls.Add(this.button_Refresh);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormStatistics";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Defender of Ukraine";
            this.Load += new System.EventHandler(this.FormStatistics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_local_results)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_network_results)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Refresh;
        private System.Windows.Forms.Label label_Your_results;
        private System.Windows.Forms.Label label_Rating_results;
        private System.Windows.Forms.Button button_Back_to_Menu;
        private System.Windows.Forms.DataGridView dataGridView_local_results;
        private System.Windows.Forms.DataGridView dataGridView_network_results;
    }
}