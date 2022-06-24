using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW3_WF_Vasilchenko
{
    public partial class GoodsHeir : Form
    {
        Goods good = new Goods();
        bool filledFlag = false;
        public GoodsHeir(Goods _good, bool _filledFlag)
        {
            InitializeComponent();

            filledFlag = _filledFlag;
            good = _good;

            if (filledFlag == false)
            {
                tbName.Text = _good.Name;
                tbCountry.Text = _good.Country;
                tbPrice.Text = _good.Price.ToString();
                Text = "Edit goods";
            }
            else
            {
                Text = "Add goods";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (tbName.Text == "" || tbCountry.Text == "" || tbPrice.Text == "")
            {
                btnOK.Enabled = false;
                MessageBox.Show("Fill all te fields");
            }
            if (good == null)
            {
                good = new Goods();
            }
            good.Name = tbName.Text;
            good.Country = tbCountry.Text;
            try
            {
                good.Price = Convert.ToDouble(tbPrice.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Error!");
            }

            DialogResult = DialogResult.OK;
        }
    }
}
