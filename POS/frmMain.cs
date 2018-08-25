using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using PMS.Utilities.Model.POS;
using PMS.Utilities.BLL.POS;
using PMS.Utilities;

namespace POS
{
    public partial class frmMain : MetroForm
    {
        private MainHelper _mainHelper;

        public frmMain()
        {
            InitializeComponent();
            _mainHelper = new MainHelper();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            PopulateDetails();
        }

        private void PopulateDetails()
        {
            BindArea();
            if (Globals.Valid)
            {
                BindTable();
                BindCaptain();
                BindWaiter();
            }
        }

        private void BindArea()
        {
            if (_mainHelper.PopulateAreaDetails().Count > 0)
            {
                cbArea.DataSource = new BindingSource(_mainHelper.PopulateAreaDetails(), null);
                cbArea.DisplayMember = "Value";
                cbArea.ValueMember = "Key";

                Globals.Valid = true;
            }
            else
            {
                Globals.Valid = false;
                Globals.AreaId = 0;
                MessageBox.Show("No Area Found");
            }
        }

        private void BindTable()
        {
            if (_mainHelper.PopulateTableDetails().Count > 0 && Globals.Valid)
            {
                cbTable.Enabled = true;
                cbTable.DataSource = new BindingSource(_mainHelper.PopulateTableDetails(), null);
                cbTable.DisplayMember = "Value";
                cbTable.ValueMember = "Key";
            }
            else
            {
                Globals.TableId = 0;
                cbTable.Enabled = false;
            }
        }

        private void BindCaptain()
        {
            if (_mainHelper.PopulateCaptainDetails().Count > 0 && Globals.Valid)
            {
                cbCaptain.Enabled = true;
                cbCaptain.DataSource = new BindingSource(_mainHelper.PopulateCaptainDetails(), null);
                cbCaptain.DisplayMember = "Value";
                cbCaptain.ValueMember = "Key";
            }
            else
            {
                Globals.CaptainId = 0;
                cbCaptain.Enabled = false;
            }
        }

        private void BindWaiter()
        {
            if (_mainHelper.PopulateWaiterDetails().Count > 0 && Globals.Valid)
            {
                cbWaiter.Enabled = true;
                cbWaiter.DataSource = new BindingSource(_mainHelper.PopulateWaiterDetails(), null);
                cbWaiter.DisplayMember = "Value";
                cbWaiter.ValueMember = "Key";
            }
            else
            {
                Globals.WaiterId = 0;
                cbWaiter.Enabled = false;
            }
        }

        private void cbArea_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Globals.AreaId = ((KeyValuePair<int, string>)cbArea.SelectedItem).Key;
            cbTable.DataSource = null;
            cbCaptain.DataSource = null;
            cbWaiter.DataSource = null;

            BindTable();
            BindCaptain();
            BindWaiter();
        }

        private void cbTable_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Globals.TableId = ((KeyValuePair<int, string>)cbTable.SelectedItem).Key;
        }

        private void cbCaptain_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Globals.CaptainId = ((KeyValuePair<int, string>)cbCaptain.SelectedItem).Key;
        }

        private void cbWaiter_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Globals.WaiterId = ((KeyValuePair<int, string>)cbWaiter.SelectedItem).Key;
        }
    }
}
