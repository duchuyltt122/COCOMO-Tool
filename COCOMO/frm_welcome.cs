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
    public partial class frm_welcome : Form
    {
        public frm_welcome()
        {
            InitializeComponent();
        }

        private void frm_welcome_Load(object sender, EventArgs e)
        {
            //Turn off form border
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }
    }
}
