using Game_Kursak.model;
using Game_Kursak.controller;
using SuperSimpleTcp;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Game_Kursak.view
{
    public partial class FormStatistics : Form
    {
        bool flag = true;
        Controller controller = new Controller();
        public List<SaveResult> list_result_statistics = new List<SaveResult>();

        public FormStatistics()
        {
            InitializeComponent();
        }

        private void buttonRefrash_Click(object sender, EventArgs e)
        {
            try
            {
                controller.client.Connect();
            }
            catch(Exception ex)
            { 
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_Back_to_Menu_Click(object sender, EventArgs e)
        {
            controller.client.Disconnect();
            FormMenu formMenu = new FormMenu();
            formMenu.Show();
            this.Close();
        }

        private void FormStatistics_Load(object sender, EventArgs e)
        {
            controller.client = new SimpleTcpClient(controller.client_parametrs.HOST_PORT);
            controller.client.Events.Connected += Events_Connected;
            controller.client.Events.DataReceived += Events_DataReceived;
            controller.client.Events.Disconnected += Events_Disconnected;

            controller.OpenFromTxtLocalResults(list_result_statistics, dataGridView_local_results);

        }



        private void Events_Disconnected(object sender, ConnectionEventArgs e)
        {
            //MessageBox.Show("Server disconnected");
        }

        private void Events_DataReceived(object sender, DataReceivedEventArgs e)
        {
            
            this.Invoke((MethodInvoker)delegate
            {
                dataGridView_network_results.Rows.Clear();
                string json = null;
                json = Encoding.UTF8.GetString(e.Data.Array);
                controller.ConverJsonToResults(json, dataGridView_network_results);
            });
            

        }

        private void Events_Connected(object sender, ConnectionEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                if (flag == true)
                {
                    controller.client.Send(controller.client_parametrs.ToString());
                   

                    if (!string.IsNullOrEmpty(controller.ConverResultsToJson(list_result_statistics)))
                    {
                        controller.client.Send(controller.ConverResultsToJson(list_result_statistics));
                        
                    }
                    flag = false;
                }
                else 
                {
                    if (!string.IsNullOrEmpty(controller.ConverResultsToJson(list_result_statistics)))
                    {
                        controller.client.Send(controller.ConverResultsToJson(list_result_statistics));
                       
                    }
                }
                
            });
           
            

        }
    }
}
