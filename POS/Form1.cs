using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PMS.Utilities;
using PMS.Utilities.BLL.POS;
using PMS.Utilities.Model.POS;

namespace POS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tableBll tableBll = new tableBll();
            tableModel[] tableList = tableBll.TableList().ToArray();

            int rowTableLimit = 21, btnWidth = 50, btnHeight = 50;
            int xAxis = 60, yAxis = 50, defaultYAxis = 50;
            int count = 0, rowcount = 2;

            for (int i = 0; i < tableList.Length; i++)
            {
                Button btn = new Button();
                btn.Name = tableList[i].id.ToString();
                btn.Text = tableList[i].tableNo.ToString();
                btn.Size = new Size(btnWidth, btnHeight);
                btn.Font= new Font("Tahoma",9.25F,FontStyle.Bold);
                btn.BackColor = tableList[i].occupied ? Color.Red : Color.Green;
                btn.ForeColor = Color.White;
                btn.Location = new Point(xAxis + (60 * count), yAxis);//please adjust location as per your need
                btn.Tag = tableList;
                btn.Click += new EventHandler(OnButtonClick);
                this.Controls.Add(btn);//this will add the control to form if you have panel or some other container then you have to specify the name of that container like...
                                       //this.panel1.Controls.Add(temp);



                count++;
                if (count == rowTableLimit)
                {
                    yAxis = defaultYAxis * rowcount;
                    //xAxis *= 3;
                    count = 0;
                    rowcount ++;
                }
            }
        }

        private void OnButtonClick(object sender, EventArgs e)
        {
            Button temp = (Button)sender;
            MessageBox.Show("You have clicked on  : " + temp.Name);
        }
    }
}
