using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW3_WF_Vasilchenko
{
    public partial class GoodsParent : Form
    {
        Goods good;
        //bool flag = false;
        public GoodsParent()
        {
            InitializeComponent();
        }

        private void btnClearList_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1) MessageBox.Show("Error");
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            good = new Goods();
            GoodsHeir addForm = new GoodsHeir(good, true);
            if (addForm.ShowDialog() == DialogResult.OK) listBox1.Items.Add(good);

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
                MessageBox.Show("Choose item for editing", "Warning");
            else
            {
                int idx = listBox1.SelectedIndex;
                Goods tmpGoods = (Goods)listBox1.SelectedItem;
                GoodsHeir tmpGoodsHeir = new GoodsHeir(tmpGoods, false);
                if(tmpGoodsHeir.ShowDialog() == DialogResult.OK)
                {
                    listBox1.Items.RemoveAt(idx);
                    listBox1.Items.Insert(idx, tmpGoods);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("GoodsList.txt");
            if(listBox1.Items.Count ==0)
            {
                MessageBox.Show("Goods list is empty");
            }
            else
            {
                foreach (var item in listBox1.Items)
                {
                    sw.WriteLine(item.ToString());
                }
                MessageBox.Show("Iterms are written to the file successfully!", "Write Complete");
            }
            sw.Close();
        }
    }
}
