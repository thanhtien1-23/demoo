﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtSonguyen_TextChanged(object sender, EventArgs e)
        {
            Control ctrSonguyen = (Control)sender;
            if (ctrSonguyen.Text.Length > 0)
                if (!char.IsDigit(ctrSonguyen.Text[ctrSonguyen.Text.Length - 1]))
                    this.errSonguyen.SetError(ctrSonguyen, "Vui lòng nhập số nguyên");
                else
                    this.errSonguyen.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            lstKetqua.Items.Add(txtSonguyen.Text);
            txtSonguyen.Text = "";
            txtSonguyen.Focus();

        }

        private void btnTang2_Click(object sender, EventArgs e)
        {
            int n = lstKetqua.Items.Count; //Số mục trong lst
            for (int i = 0; i < n; i++)
            {
                int tam = int.Parse(lstKetqua.Items[i].ToString()) + 2;
                lstKetqua.Items.RemoveAt(i);
                lstKetqua.Items.Insert(i, tam.ToString());
            }

        }

        private void btnChonchandau_Click(object sender, EventArgs e)
        {
            int n = lstKetqua.Items.Count; //Số mục trong lst
            for (int i = 0; i < n - 1; i++)
            {
                if (int.Parse(lstKetqua.Items[i].ToString()) % 2 == 0)
                {
                    string s = lstKetqua.Items[i].ToString();//Lay gia tri muc gia tri chan
                    lstKetqua.SelectedItem = s;//Chon muc co gia tri chan
                    break; //Thuc hien duoc so chn dau thi ket thuc vong lap
                }

            }
        }

        private void btnLecuoi_Click(object sender, EventArgs e)
        {
            int n = lstKetqua.Items.Count; //Số mục trong lst
            for (int i = n - 1; i >= 0; i--)
            {
                if (int.Parse(lstKetqua.Items[i].ToString()) % 2 == 1)
                {
                    string s = lstKetqua.Items[i].ToString();//Lay gia tri muc gia tri lẻ
                    lstKetqua.SelectedItem = s;//Chon muc co gia tri le
                    break; //Thuc hien duoc so le dau (tu duoi len) thi ket thuc vong lap
                }

            }
        }

        private void btnXoaphantudangchon_Click(object sender, EventArgs e)
        {
            int n = lstKetqua.SelectedItems.Count; //Số mục dang duoc chon trong lstKetqua
            for (int i = n - 1; i >= 0; i--)
                lstKetqua.Items.Remove(lstKetqua.SelectedItems[i].ToString());

        }

        private void btnXoaphantudau_Click(object sender, EventArgs e)
        {
            lstKetqua.Items.Remove(lstKetqua.Items[0].ToString());
        }

        private void btnXoaphantucuoi_Click(object sender, EventArgs e)
        {
            int n = lstKetqua.Items.Count;
            lstKetqua.Items.Remove(lstKetqua.Items[n - 1].ToString());

        }

        private void lstKetqua_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) e.Cancel = true;
        }

        private void txtSonguyen_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
    }
}
