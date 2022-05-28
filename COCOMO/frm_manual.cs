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

namespace COCOMO
{
    public partial class frm_manual : Form
    {
        public frm_manual()
        {
            InitializeComponent();
        }

        private void frm_manual_Load(object sender, EventArgs e)
        {
            //Turn off form border
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

            string path = Directory.GetCurrentDirectory() + @"\cocomo_doc.pdf";
            axAcroPDF1.src = path;
        }
    }
}
