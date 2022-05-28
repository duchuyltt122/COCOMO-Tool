using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COCOMO
{
    public partial class frm_mainn : Form
    {
        public frm_mainn()
        {
            InitializeComponent();
        }

        private void btn_cocomo1_Click(object sender, EventArgs e)
        {
            frm_cocomo1 cocomo1 = new frm_cocomo1();
            this.Hide();
            cocomo1.Show();
            
        }

        private void btn_cocomo2_Click(object sender, EventArgs e)
        {
            frm_cocomo2 cocomo2 = new frm_cocomo2();
            this.Hide();
            cocomo2.Show();
        }

        private void frm_mainn_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
