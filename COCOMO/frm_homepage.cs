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
    public partial class frm_homepage : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;

        public frm_homepage()
        {
            InitializeComponent();
            random = new Random();
        }

        private void frm_homepage_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private Color SelectedThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            
            while(tempIndex==index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }

            tempIndex = index;
            string color = ThemeColor.ColorList[index];

            return ColorTranslator.FromHtml(color);
        }
        
        private void ActivateButton(object btnSender)
        {
            if(btnSender != null)
            {
                if(currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectedThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Times New Roman", 15.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void DisableButton()
        {
            foreach(Control previousBtn in pnl_menu.Controls)
            {
                if(previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void btn_cocomo1_Click(object sender, EventArgs e)
        {
            //frm_cocomo1 cocomo1 = new frm_cocomo1();

            //cocomo1.TopLevel = false;
            //cocomo1.Dock = DockStyle.Fill;
            //pnl_main.Controls.Add(cocomo1);
            //cocomo1.Show();

            ActivateButton(sender);
        }

        private void btn_cocomo2_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btn_manual_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }
    }
}
