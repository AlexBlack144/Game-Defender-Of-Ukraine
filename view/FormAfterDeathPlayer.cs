using System;
using System.Windows.Forms;

namespace Game_Kursak.view
{
    public partial class FormAfterDeathPlayer : Form
    {
        public string Btn = "";
        public string NickNameOfPlayer = "";

        public FormAfterDeathPlayer()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menu_Click(object sender, EventArgs e)
        {
            Btn = "menu";
            this.Close();
        }

        private void restart_Click(object sender, EventArgs e)
        {
            Btn = "restart";
            this.Close();
        }

        private void save_Click(object sender, EventArgs e)
        {
            Btn = "save";
            NickNameOfPlayer = textBox_nickName.Text;
            this.Close();

        }

        private void textBox_nickName_TextChanged(object sender, EventArgs e)
        {
            
            if (textBox_nickName.Text.Length > 16 
                || textBox_nickName.Text.ToLower()=="drop" 
                || textBox_nickName.Text.ToUpper() == "drop" 
                || textBox_nickName.Text.ToLower() == "delete"
                || textBox_nickName.Text.ToUpper() == "delete")
            {
                textBox_nickName.Text = "";
            }
        }
    }
}
