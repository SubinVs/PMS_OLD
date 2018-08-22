using System;
using System.Drawing;
using System.Windows.Forms;
using MetroFramework;
using PMS.Utilities.BLL.POS;
using PMS.Utilities.Model.POS;

namespace POS.Helper
{
    public class Main
    {
        private tableBll tableBll;

        public Main(frmTable frm)
        {
            tableBll = new tableBll();
            GenerateTable(frm);
        }

        public void GenerateTable(frmTable frm)
        {
            tableModel[] tableList = tableBll.TableList().ToArray();

            int rowTableLimit = 21, btnWidth = 50, btnHeight = 50;
            int xAxis = 60, yAxis = 60, defaultYAxis = 60;
            int count = 0, rowcount = 2;

            for (int i = 0; i < tableList.Length; i++)
            {
                //Button btn = new Button();
                MetroFramework.Controls.MetroButton btn = new MetroFramework.Controls.MetroButton();
                btn.Name = tableList[i].id.ToString();
                btn.Text = tableList[i].tableNo.ToString();
                btn.Size = new Size(btnWidth, btnHeight);
                btn.Font = new Font("Tahoma", 9.25F, FontStyle.Bold);
                btn.UseCustomBackColor = true;
                btn.BackColor = tableList[i].occupied ? Color.Red : Color.Green;
                btn.UseCustomForeColor = true;
                btn.ForeColor = Color.White;
                btn.Location = new Point(xAxis + (60 * count), yAxis);//please adjust location as per your need
                btn.Tag = tableList;
                btn.Click += new EventHandler(OnTableClick);
                frm.Controls.Add(btn);//this will add the control to form if you have panel or some other container then you have to specify the name of that container like...
                                      //this.panel1.Controls.Add(temp);


                count++;
                if (count == rowTableLimit)
                {
                    yAxis = defaultYAxis * rowcount;
                    //xAxis *= 3;
                    count = 0;
                    rowcount++;
                }
            }
        }

        private void OnTableClick(object sender, EventArgs e)
        {
            Button temp = (Button)sender;
            MessageBox.Show("You have clicked on  : " + temp.Name);
        }
    }
}
