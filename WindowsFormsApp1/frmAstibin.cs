﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmAstibin : Form
    {
        public frmAstibin()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            MessageBox.Show("تم ارسال الاستبيان بنجاح شكرا لكم ");
        }

        private void chbAddComment_CheckedChanged(object sender, EventArgs e)
        {
            txtAddComment.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmManagerProduct f = new frmManagerProduct();
            f.Show();

        }
    }
}
