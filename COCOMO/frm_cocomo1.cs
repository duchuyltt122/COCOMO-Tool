using GemBox.Spreadsheet;
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
    public partial class frm_cocomo1 : Form
    {
        bool checkClickCalculate = false;
        string mode = "Organic Mode";
        double a = 0, b = 0, c = 0, d = 0;
        double Effort = 0, Tdev = 0, cost = 0, EAF = 0;
        double KLOC = 0, costperPM = 0;
        double[,] tableMode =
        {
            {3.2, 1.05, 2.5, 0.38 },
            {3.0, 1.12, 2.5, 0.35 },
            {2.8, 1.2, 2.5, 0.32 }
        };

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
        double[] listCostDrivers = { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
        string[] listRating = { "Very Low", "Low", "Nominal", "High", "Very High", "Extra High" };
        string[] listNameRating = new string[15];
        private void cb_data_SelectedIndexChanged(object sender, EventArgs e)
        {
            //1
            int index = getRating(cb_data.SelectedItem.ToString());
            listCostDrivers[1] = tableCostDrivers[1, index];
            listNameRating[1] = cb_data.SelectedItem.ToString();
        }

        private void cb_cplx_SelectedIndexChanged(object sender, EventArgs e)
        {
            //2
            int index = getRating(cb_cplx.SelectedItem.ToString());
            listCostDrivers[2] = tableCostDrivers[2, index];
            listNameRating[2] = cb_cplx.SelectedItem.ToString();
        }

        private void cb_time_SelectedIndexChanged(object sender, EventArgs e)
        {
            //3
            int index = getRating(cb_time.SelectedItem.ToString());
            listCostDrivers[3] = tableCostDrivers[3, index];
            listNameRating[3] = cb_time.SelectedItem.ToString();
        }

        private void cb_stor_SelectedIndexChanged(object sender, EventArgs e)
        {
            //4
            int index = getRating(cb_stor.SelectedItem.ToString());
            listCostDrivers[4] = tableCostDrivers[4, index];
            listNameRating[4] = cb_stor.SelectedItem.ToString();
        }

        private void cb_virt_SelectedIndexChanged(object sender, EventArgs e)
        {
            //5
            int index = getRating(cb_virt.SelectedItem.ToString());
            listCostDrivers[5] = tableCostDrivers[5, index];
            listNameRating[5] = cb_virt.SelectedItem.ToString();
        }

        private void cb_turn_SelectedIndexChanged(object sender, EventArgs e)
        {
            //6
            int index = getRating(cb_turn.SelectedItem.ToString());
            listCostDrivers[6] = tableCostDrivers[6, index];
            listNameRating[6] = cb_turn.SelectedItem.ToString();
        }

        private void cb_acap_SelectedIndexChanged(object sender, EventArgs e)
        {
            //7
            int index = getRating(cb_acap.SelectedItem.ToString());
            listCostDrivers[7] = tableCostDrivers[7, index];
            listNameRating[7] = cb_acap.SelectedItem.ToString();
        }

        private void cb_aexp_SelectedIndexChanged(object sender, EventArgs e)
        {
            //8
            int index = getRating(cb_aexp.SelectedItem.ToString());
            listCostDrivers[8] = tableCostDrivers[8, index];
            listNameRating[8] = cb_aexp.SelectedItem.ToString();
        }

        private void cb_pcap_SelectedIndexChanged(object sender, EventArgs e)
        {
            //9
            int index = getRating(cb_pcap.SelectedItem.ToString());
            listCostDrivers[9] = tableCostDrivers[9, index];
            listNameRating[9] = cb_pcap.SelectedItem.ToString();
        }

        private void cb_vexp_SelectedIndexChanged(object sender, EventArgs e)
        {
            //10
            int index = getRating(cb_vexp.SelectedItem.ToString());
            listCostDrivers[10] = tableCostDrivers[10, index];
            listNameRating[10] = cb_vexp.SelectedItem.ToString();
        }

        private void cb_lexp_SelectedIndexChanged(object sender, EventArgs e)
        {
            //11
            int index = getRating(cb_lexp.SelectedItem.ToString());
            listCostDrivers[11] = tableCostDrivers[11, index];
            listNameRating[11] = cb_lexp.SelectedItem.ToString();
        }

        private void cb_modp_SelectedIndexChanged(object sender, EventArgs e)
        {
            //12
            int index = getRating(cb_modp.SelectedItem.ToString());
            listCostDrivers[12] = tableCostDrivers[12, index];
            listNameRating[12] = cb_modp.SelectedItem.ToString();
        }

        private void cb_tool_SelectedIndexChanged(object sender, EventArgs e)
        {
            //13
            int index = getRating(cb_tool.SelectedItem.ToString());
            listCostDrivers[13] = tableCostDrivers[13, index];
            listNameRating[13] = cb_tool.SelectedItem.ToString();
        }

        private void cb_sced_SelectedIndexChanged(object sender, EventArgs e)
        {
            //14
            int index = getRating(cb_sced.SelectedItem.ToString());
            listCostDrivers[14] = tableCostDrivers[14, index];
            listNameRating[14] = cb_sced.SelectedItem.ToString();
        }

        private void cb_rely_SelectedIndexChanged(object sender, EventArgs e)
        {
            //0
            int index = getRating(cb_rely.SelectedItem.ToString());
            listCostDrivers[0]=tableCostDrivers[0,index];
            listNameRating[0] = cb_rely.SelectedItem.ToString();
        }
        
        private void btn_export_Click(object sender, EventArgs e)
        {
            if (checkClickCalculate == true)
            {
                var saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter =
                    "XLS (*.xls)|*.xls|" +
                    "XLT (*.xlt)|*.xlt|" +
                    "XLSX (*.xlsx)|*.xlsx|" +
                    "XLSM (*.xlsm)|*.xlsm|" +
                    "XLTX (*.xltx)|*.xltx|" +
                    "XLTM (*.xltm)|*.xltm|" +
                    "ODS (*.ods)|*.ods|" +
                    "OTS (*.ots)|*.ots|" +
                    "CSV (*.csv)|*.csv|" +
                    "TSV (*.tsv)|*.tsv|" +
                    "HTML (*.html)|*.html|" +
                    "MHTML (.mhtml)|*.mhtml|" +
                    "PDF (*.pdf)|*.pdf|" +
                    "XPS (*.xps)|*.xps|" +
                    "BMP (*.bmp)|*.bmp|" +
                    "GIF (*.gif)|*.gif|" +
                    "JPEG (*.jpg)|*.jpg|" +
                    "PNG (*.png)|*.png|" +
                    "TIFF (*.tif)|*.tif|" +
                    "WMP (*.wdp)|*.wdp";

                saveFileDialog.FilterIndex = 3;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var workbook = new ExcelFile();
                    var worksheet = workbook.Worksheets.Add("COCOMO I");

                    var dataTable = new DataTable();
                    dataTable.Columns.Add(" ", typeof(string));
                    dataTable.Columns.Add("  ", typeof(string));
                    dataTable.Rows.Add(new object[] { "Software Size (KLOC):", KLOC+"" });
                    dataTable.Rows.Add(new object[] { "Mode:", mode+"" });
                    dataTable.Rows.Add(new object[] { "Cost per Person-Month (Dollars):", "$ "+costperPM });
                    // Insert DataTable to an Excel worksheet.
                    worksheet.InsertDataTable(dataTable,
                        new InsertDataTableOptions()
                        {
                            ColumnHeaders = true,
                            StartRow = 1
                        });

                    dataTable = new DataTable();
                    dataTable.Columns.Add("   ", typeof(string));
                    dataTable.Columns.Add("Cost Driver", typeof(string));
                    dataTable.Columns.Add("Rating", typeof(string));
                    dataTable.Columns.Add("Value(EMi)", typeof(double));

                    dataTable.Rows.Add(new object[] { "Product Factors" });
                    dataTable.Rows.Add(new object[] { "", "Required software reliability", listNameRating[0], listCostDrivers[0] });
                    dataTable.Rows.Add(new object[] { "", "Database size", listNameRating[1], listCostDrivers[1] });
                    dataTable.Rows.Add(new object[] { "", "Product complexity", listNameRating[2], listCostDrivers[2] });

                    dataTable.Rows.Add(new object[] { "Platform Factors" });
                    dataTable.Rows.Add(new object[] { "", "Execution time constraint", listNameRating[3], listCostDrivers[3] });
                    dataTable.Rows.Add(new object[] { "", "Main storage constraint", listNameRating[4], listCostDrivers[4] });
                    dataTable.Rows.Add(new object[] { "", "Virtual machine volatility", listNameRating[5], listCostDrivers[5] });
                    dataTable.Rows.Add(new object[] { "", "Computer turnaround time", listNameRating[6], listCostDrivers[6] });

                    dataTable.Rows.Add(new object[] { "Personnel Factors" });
                    dataTable.Rows.Add(new object[] { "", "Analyst capability", listNameRating[7], listCostDrivers[7] });
                    dataTable.Rows.Add(new object[] { "", "Applications experience", listNameRating[8], listCostDrivers[8] });
                    dataTable.Rows.Add(new object[] { "", "Programmer capability", listNameRating[9], listCostDrivers[9] });
                    dataTable.Rows.Add(new object[] { "", "Virtual machine experience", listNameRating[10], listCostDrivers[10] });
                    dataTable.Rows.Add(new object[] { "", "Language experience", listNameRating[11], listCostDrivers[11] });

                    dataTable.Rows.Add(new object[] { "Project Factors" });
                    dataTable.Rows.Add(new object[] { "", "Modern programming practices", listNameRating[12], listCostDrivers[12] });
                    dataTable.Rows.Add(new object[] { "", "Software tools", listNameRating[13], listCostDrivers[13] });
                    dataTable.Rows.Add(new object[] { "", "Development schedule", listNameRating[14], listCostDrivers[14] });


                    worksheet.Cells[0, 0].Value = "Input:";
                    worksheet.Cells[0, 7].Value = "Output:";
                    // Insert DataTable to an Excel worksheet.
                    worksheet.InsertDataTable(dataTable,
                        new InsertDataTableOptions()
                        {
                            ColumnHeaders = true,
                            StartRow = 6
                        });

                    dataTable = new DataTable();
                    dataTable.Columns.Add("   ", typeof(string));
                    dataTable.Columns.Add("     ", typeof(string));
                    dataTable.Columns.Add("      ", typeof(string));
                    dataTable.Rows.Add(new object[] { "Effort:"," ", Math.Round(Effort,2) + " Persons-months" });
                    dataTable.Rows.Add(new object[] { "Schedule:"," ", Math.Round(Tdev,2) + " Months" });
                    dataTable.Rows.Add(new object[] { "Cost:"," ", "$ " + Math.Round(cost,2) });
                    dataTable.Rows.Add(new object[] { "Effort Adjustment Factor (EAF):"," ", "" + Math.Round(EAF,2) });
                    // Insert DataTable to an Excel worksheet.
                    worksheet.InsertDataTable(dataTable,
                        new InsertDataTableOptions()
                        {
                            ColumnHeaders = true,
                            StartRow = 1,
                            StartColumn = 7
                        });
                    string[] listCell = new string[] { "A1", "A3", "A4", "A5", "A8", "A12", "A17", "A23","B7","C7","D7", "H1", "H3", "H4", "H5", "H6" };
                    
                    foreach(string i in listCell)
                    {
                        var cell = worksheet.Cells[i];
                        cell.Style.Font.Weight = ExcelFont.BoldWeight;
                    }
                    var htmlOptions = new HtmlLoadOptions();
                    var html = @"<div style='font:11pt Calibri'><p>E = a(KLOC)<sup>b</sup> x EAF =</p></div>";
                    worksheet.Cells["I3"].SetValue(html, htmlOptions);

                    html = @"<div style='font:11pt Calibri'><p>T<sub>dev</sub> = c(a(KLOC)<sup>b</sup> x EAF)<sup>d</sup> =</p></div>";
                    worksheet.Cells["I4"].SetValue(html, htmlOptions);

                    html = @"<div style='font:11pt Calibri'><p>Cost = E x Cost per Person-Month =</p></div>";
                    worksheet.Cells["I5"].SetValue(html, htmlOptions);

                    html = @"<div style='font:11pt Calibri'><p>EAF = &prod;EM<sub>i</sub> =</p></div>";
                    worksheet.Cells["I6"].SetValue(html, htmlOptions);

                    worksheet.Cells["C4"].SetValue("a="+a);
                    worksheet.Cells["D4"].SetValue("b=" + b);
                    worksheet.Cells["E4"].SetValue("c=" + c);
                    worksheet.Cells["F4"].SetValue("d=" + d);
                    worksheet.Columns[0].AutoFit();
                    worksheet.Columns[1].AutoFit();
                    worksheet.Columns[2].AutoFit();
                    worksheet.Columns[7].AutoFit();
                    worksheet.Columns[8].AutoFit();
                    worksheet.Columns[9].AutoFit();
                    workbook.Save(saveFileDialog.FileName);
                }
            }
        }

        private void frm_cocomo1_FormClosing(object sender, FormClosingEventArgs e)
        {
            frm_mainn main=new frm_mainn();
            main.Show();
            
        }

        private void frm_main_Load(object sender, EventArgs e)
        {
            //Turn off form border
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

            SpreadsheetInfo.SetLicense("FREE-LIMITED-KEY");
            for(int i = 0; i < listNameRating.Length; i++)
            {
                listNameRating[i] = "Nominal";
            }
        }
        

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
                mode = "Organic Mode";
            }
            else if (radio_semi.Checked == true)    //Semi-detached Mode
            {
                a = tableMode[1, 0];
                b = tableMode[1, 1];
                c = tableMode[1, 2];
                d = tableMode[1, 3];
                mode = "Semi-detached Mode";
            }
            else    //Embedded Mode
            {
                a = tableMode[2, 0];
                b = tableMode[2, 1];
                c = (tableMode[2, 2]);
                d = (tableMode[2, 3]);
                mode = "Embedded Mode";
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
        public frm_cocomo1()
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
            checkClickCalculate=true;
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
