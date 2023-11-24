using DỰ_ÁN_11.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DỰ_ÁN_11
{
    public partial class GIAO_DIỆN_CHỨC_NĂNG : Form
    {
        public GIAO_DIỆN_CHỨC_NĂNG()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GIAO_DIEN_SAN_PHAM SP = new GIAO_DIEN_SAN_PHAM();
            SP.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GIAO_DIEN_HOA_DON HD = new GIAO_DIEN_HOA_DON();
            HD.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GIAO_DIEN_THANH_TOAN TT = new GIAO_DIEN_THANH_TOAN();
            TT.Show();
        }

        private void btnKH_Click(object sender, EventArgs e)
        {
            GIAO_DIEN_KHO_HANG KH = new GIAO_DIEN_KHO_HANG();
            KH.Show();
        }

        private void btnKM_Click(object sender, EventArgs e)
        {
            GIAO_DIEN_KHUYEN_MAI KM = new GIAO_DIEN_KHUYEN_MAI();
            KM.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
