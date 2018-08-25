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
            Globals.Pax = 1;
            tbPax.Text = Globals.Pax.ToString();

            BindArea();
            if (Globals.Valid)
            {
                BindTable();
                BindCaptain();
                BindWaiter();
                BindItem();
                BindItemRate();
            }
            tbRate.Enabled = false;
            ConfigDataGrid();
        }

        private void ConfigDataGrid()
        {
            DataGridViewTextBoxColumn ItemId = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn ItemName = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn Quantity = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn Rate = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn Total = new DataGridViewTextBoxColumn();

            ItemName.HeaderText = "Item Name";
            Quantity.HeaderText = "Quantity";
            Rate.HeaderText = "Rate";
            Total.HeaderText = "Total";

            dgvItems.Columns.AddRange(ItemId, ItemName, Quantity, Rate, Total);
        }

        private void BindArea()
        {
            if (_mainHelper.PopulateAreaDetails().Count > 0)
            {
                cbArea.DataSource = new BindingSource(_mainHelper.PopulateAreaDetails(), null);
                cbArea.DisplayMember = "Value";
                cbArea.ValueMember = "Key";

                Globals.AreaId = ((KeyValuePair<int, string>)cbArea.SelectedItem).Key;
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

                Globals.TableId = ((KeyValuePair<int, string>)cbTable.SelectedItem).Key;
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

                Globals.CaptainId = ((KeyValuePair<int, string>)cbCaptain.SelectedItem).Key;
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

                Globals.WaiterId = ((KeyValuePair<int, string>)cbWaiter.SelectedItem).Key;
            }
            else
            {
                Globals.WaiterId = 0;
                cbWaiter.Enabled = false;
            }
        }

        private void BindItem()
        {
            if (_mainHelper.PopulateItemDetails().Count > 0 && Globals.Valid)
            {
                cbItems.Enabled = true;
                cbItems.DataSource = new BindingSource(_mainHelper.PopulateItemDetails(), null);
                cbItems.DisplayMember = "Value";
                cbItems.ValueMember = "Key";

                Globals.ItemId = ((KeyValuePair<int, string>)cbItems.SelectedItem).Key;
            }
            else
            {
                Globals.ItemId = 0;
                cbWaiter.Enabled = false;
            }
        }

        private void BindItemRate()
        {
            _mainHelper.GetItemRate();
            Globals.ItemId = ((KeyValuePair<int, string>)cbItems.SelectedItem).Key;
            if (_mainHelper.PopulateItemRate() > 0)
                tbRate.Text = _mainHelper.PopulateItemRate().ToString();
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
            BindItem();
            BindItemRate();
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

        private void cbItems_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Globals.ItemId = ((KeyValuePair<int, string>)cbItems.SelectedItem).Key;
            if (_mainHelper.PopulateItemRate() > 0)
            {
                tbRate.Text = _mainHelper.PopulateItemRate().ToString();
            }
            else
            {
                MessageBox.Show("Rate not set for this item");
            }

        }

        private void tbPax_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))// && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void tbQty_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                MessageBox.Show("Ftftftft");
            }
        }
        
        private void PushDataToGrid()
        {
            //dgvItems.Columns[0].HeaderText = "Item Name";
        }
    }
}
