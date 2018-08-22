using PMS.Utilities.BLL.POS;
using PMS.Utilities.Model.POS;
using System;
using System.Drawing;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace POS
{
    public partial class frmTable : MetroForm
    {
        public frmTable()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Helper.Main main = new Helper.Main(this);
        }

        private void OnButtonClick(object sender, EventArgs e)
        {
            Button temp = (Button)sender;
            MessageBox.Show("You have clicked on  : " + temp.Name);
        }
    }
}
