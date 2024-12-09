using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            lstBandau.Items.Add(txtHoten.Text);
            txtHoten.Text = "";
            txtHoten.Focus();
        }

        private void btnTraisangphai_Click(object sender, EventArgs e)
        {
            int n = lstBandau.SelectedItems.Count; //Tong so muc duoc chon
            for (int i = 0; i <= n - 1; i++)
                lstKetqua.Items.Add(lstBandau.SelectedItems[i].ToString());
            for (int j = n - 1; j >= 0; j--)
                lstBandau.Items.RemoveAt(j);

        }

        private void btnTatcatraisangphai_Click(object sender, EventArgs e)
        {
            int n = lstBandau.Items.Count;
            for (int i = 0; i <= n - 1; i++)
                lstKetqua.Items.Add(lstBandau.Items[i].ToString());
            for (int j = n - 1; j >= 0; j--)
                lstBandau.Items.Clear();

        }

        private void btnPhaisangtrai_Click(object sender, EventArgs e)
        {
            int n = lstKetqua.SelectedItems.Count; //Tong so muc duoc chon
            for (int i = 0; i <= n - 1; i++)
                lstBandau.Items.Add(lstKetqua.SelectedItems[i].ToString());
            for (int j = n - 1; j >= 0; j--)
                lstKetqua.Items.RemoveAt(j);
        }

        private void btnTatcaphaisangtrai_Click(object sender, EventArgs e)
        {
            int n = lstKetqua.Items.Count;
            for (int i = 0; i <= n - 1; i++)
                lstBandau.Items.Add(lstKetqua.Items[i].ToString());
            for (int j = n - 1; j >= 0; j--)
                lstKetqua.Items.Clear();

        }

        private void btnKetqua_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            lstBandau.Items.Clear();
            lstKetqua.Items.Clear();
            txtHoten.Focus();
        }
        
        private void txtHoten_TextChanged(object sender, EventArgs e)
        {
            string text;
            text = ((TextBox)sender).Text;
            ((TextBox)sender).Text = text.ToUpper();
            txtHoten.Text = txtHoten.Text.ToUpper();
        }
        
    }
}
