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
    public partial class frm_main : Form
    {
        private void cb_data_SelectedIndexChanged(object sender, EventArgs e)
        {
            //1
            int index = getRating(cb_data.SelectedItem.ToString());
            listCostDrivers[1] = tableCostDrivers[1, index];
        }

        private void cb_cplx_SelectedIndexChanged(object sender, EventArgs e)
        {
            //2
            int index = getRating(cb_cplx.SelectedItem.ToString());
            listCostDrivers[2] = tableCostDrivers[2, index];
        }

        private void cb_time_SelectedIndexChanged(object sender, EventArgs e)
        {
            //3
            int index = getRating(cb_time.SelectedItem.ToString());
            listCostDrivers[3] = tableCostDrivers[3, index];
        }

        private void cb_stor_SelectedIndexChanged(object sender, EventArgs e)
        {
            //4
            int index = getRating(cb_stor.SelectedItem.ToString());
            listCostDrivers[4] = tableCostDrivers[4, index];
        }

        private void cb_virt_SelectedIndexChanged(object sender, EventArgs e)
        {
            //5
            int index = getRating(cb_virt.SelectedItem.ToString());
            listCostDrivers[5] = tableCostDrivers[5, index];
        }

        private void cb_turn_SelectedIndexChanged(object sender, EventArgs e)
        {
            //6
            int index = getRating(cb_turn.SelectedItem.ToString());
            listCostDrivers[6] = tableCostDrivers[6, index];
        }

        private void cb_acap_SelectedIndexChanged(object sender, EventArgs e)
        {
            //7
            int index = getRating(cb_acap.SelectedItem.ToString());
            listCostDrivers[7] = tableCostDrivers[7, index];
        }

        private void cb_aexp_SelectedIndexChanged(object sender, EventArgs e)
        {
            //8
            int index = getRating(cb_aexp.SelectedItem.ToString());
            listCostDrivers[8] = tableCostDrivers[8, index];
        }

        private void cb_pcap_SelectedIndexChanged(object sender, EventArgs e)
        {
            //9
            int index = getRating(cb_pcap.SelectedItem.ToString());
            listCostDrivers[9] = tableCostDrivers[9, index];
        }

        private void cb_vexp_SelectedIndexChanged(object sender, EventArgs e)
        {
            //10
            int index = getRating(cb_vexp.SelectedItem.ToString());
            listCostDrivers[10] = tableCostDrivers[10, index];
        }

        private void cb_lexp_SelectedIndexChanged(object sender, EventArgs e)
        {
            //11
            int index = getRating(cb_lexp.SelectedItem.ToString());
            listCostDrivers[11] = tableCostDrivers[11, index];
        }

        private void cb_modp_SelectedIndexChanged(object sender, EventArgs e)
        {
            //12
            int index = getRating(cb_modp.SelectedItem.ToString());
            listCostDrivers[12] = tableCostDrivers[12, index];
        }

        private void cb_tool_SelectedIndexChanged(object sender, EventArgs e)
        {
            //13
            int index = getRating(cb_tool.SelectedItem.ToString());
            listCostDrivers[13] = tableCostDrivers[13, index];
        }

        private void cb_sced_SelectedIndexChanged(object sender, EventArgs e)
        {
            //14
            int index = getRating(cb_sced.SelectedItem.ToString());
            listCostDrivers[14] = tableCostDrivers[14, index];
        }

        private void cb_rely_SelectedIndexChanged(object sender, EventArgs e)
        {
            //0
            int index = getRating(cb_rely.SelectedItem.ToString());
            listCostDrivers[0]=tableCostDrivers[0,index];
        }

        double a =0, b=0, c=0, d=0;
        double Effort=0, Tdev=0, cost=0, EAF=0;
        double KLOC=0, costperPM=0;
        double[,] tableMode =
        {
            {2.4, 1.05, 2.5, 0.38 },
            {3.0, 1.12, 2.5, 0.35 },
            {3.6, 1.2, 2.5, 0.32 }
        };
        double[] listCostDrivers = {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1};
        string[] listRating = {"Very Low","Low","Nominal","High","Very High","Extra High"};
        double[,] tableCostDrivers =
        {
            { 0.75, 0.88, 1.00, 1.15, 1.4, 0 },
            { 0, 0.94, 1, 1.08, 1.16, 0 },
            { 0.7, 0.85, 1, 1.15, 1.3, 1.65 },
            { 0, 0, 1, 1.11, 1.3, 1.66 },
            { 0, 0, 1, 1.06, 1.21, 1.56 },
            { 0, 0.87, 1, 1.15, 1.3, 0 },
            { 0, 0.87, 1, 1.07, 1.15, 0 },
            { 1.46, 1.19, 1, 0.86, 0.71, 0 },
            { 1.29, 1.13, 1, 0.91, 0.82, 0 },
            { 1.42, 1.17, 1, 0.86, 0.7, 0 },
            { 1.21, 1.1, 1, 0.9, 0, 0 },
            { 1.14, 1.07, 1, 0.95, 0, 0 },
            { 1.24, 1.1, 1, 0.91, 0.82, 0 },
            { 1.24, 1.1, 1, 0.91, 0.83, 0 },
            { 1.23, 1.08, 1, 1.04, 1.1, 0 }
        };
        int getRating(string s)
        {
            int result=2;
            for(int i=0; i<listRating.Length; i++)
            {
                if(listRating[i] == s)
                {
                    result = i;
                    break;
                }
            }
            return result;
        }
        void checkMode()
        {
            if (radio_org.Checked == true)  //Organic Mode
            {
                a = tableMode[0, 0];
                b = tableMode[0, 1];
                c = tableMode[0, 2];
                d = tableMode[0, 3];
            }
            else if (radio_semi.Checked == true)    //Semi-detached Mode
            {
                a = tableMode[1, 0];
                b = tableMode[1, 1];
                c = tableMode[1, 2];
                d = tableMode[1, 3];
            }
            else    //Embedded Mode
            {
                a = tableMode[2, 0];
                b = tableMode[2, 1];
                c = (tableMode[2, 2]);
                d = (tableMode[2, 3]);
            }
        }
        void calEAF()
        {
            double result = 1;
            for (int i = 0; i <listCostDrivers.Length; i++)
            {
                result*=listCostDrivers[i];
            }
            EAF = result;
        }
        void calculate()
        {
            Effort = a * Math.Pow(KLOC, b) * EAF;
            Tdev = c * Math.Pow(a*Math.Pow(KLOC, b),d);
            cost = Effort * costperPM;
        }
        public frm_main()
        {
            InitializeComponent();
        }

        private void btn_cal_Click(object sender, EventArgs e)
        {
            try
            {
                KLOC = double.Parse(txt_size.Text);
                costperPM = double.Parse(txt_costperPM.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("All inputs must be filled out >= 0");
                return;
            }
            if(costperPM < 0 || KLOC < 0)
            {
                MessageBox.Show("All inputs must be filled out >= 0");
                return;
            }
            calEAF();
            checkMode();
            calculate();
            txt_effort.Text = Math.Round(Effort, 2).ToString();
            txt_schedule.Text=Math.Round(Tdev, 2).ToString();
            txt_cost.Text = "$"+Math.Round(cost, 2).ToString();
            txt_eaf.Text=Math.Round(EAF,2).ToString();
        }
    }
}
