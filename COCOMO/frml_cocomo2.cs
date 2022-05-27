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
    public partial class frm_cocomo2 : Form
    {
        bool checkClickCalculate = false;
        double A = 2.94, B = 0, C = 3.67;
        double Effort = 0, Tdev = 0, cost = 0, EAF = 0;
        double KLOC = 0, costperPM = 0;
        double SCED = 1;
        double[,] tableScaleFactors =
        {
            {6.2, 4.96, 3.72, 2.48, 1.24, 0},
            {5.07, 4.05, 3.04, 2.03, 1.01, 0},
            {7.07, 5.65, 4.24, 2.83, 1.41, 0},
            {5.48, 4.38, 3.29, 2.19, 1.1, 0},
            {7.8, 6.24, 4.68, 3.12, 1.56, 0}
        };
        double[,] tableCostDrivers =
        {
            { 0.82, 0.92, 1.00, 1.1, 1.26, 0 },
            { 0, 0.9, 1, 1.14, 1.28, 0 },
            { 0.73, 0.87, 1, 1.17, 1.34, 1.74 },
            { 0, 0.95, 1, 1.07, 1.15, 1.24 },
            { 0.81, 0.91, 1, 1.11, 1.23, 0 },
            { 0, 0, 1, 1.11, 1.29, 1.63 },
            { 0, 0, 1, 1.05, 1.17, 1.46 },
            { 0, 0.87, 1, 1.15, 1.3, 0 },
            { 1.42, 1.19, 1, 0.85, 0.71, 0 },
            { 1.22, 1.1, 1, 0.88, 0.81, 0 },
            { 1.34, 1.15, 1, 0.88, 0.76, 0 },
            { 1.19, 1.09, 1, 0.92, 0.85, 0 },
            { 1.2, 1.09, 1, 0.91, 0.84, 0 },
            { 1.29, 1.12, 1, 0.9, 0.81, 0 },
            { 1.17, 1.09, 1, 0.9, 0.78, 0 },
            { 1.43, 1.14, 1, 1, 1, 0 },
            { 1.22, 1.09, 1, 0.93, 0.86, 0.8 }
        };
        double[] listSCED = { 0.75, 0.85, 1, 1.3, 1.6, 0};
        double[] listScaleFactors = { 3.72, 3.04, 4.24, 3.29, 4.68 };
        double[] listCostDrivers = { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
        string[] listRating = { "Very Low", "Low", "Nominal", "High", "Very High", "Extra High" };
        string[] listNameRating = new string[22];

        int getRating(string s)
        {
            int result = 2;
            for (int i = 0; i < listRating.Length; i++)
            {
                if (listRating[i] == s)
                {
                    result = i;
                    break;
                }
            }
            return result;
        }
        private void cb_prec_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Scale Factor 1
            int index = getRating(cb_prec.SelectedItem.ToString());
            listScaleFactors[0] = tableScaleFactors[0, index];
            listNameRating[0] = cb_prec.SelectedItem.ToString();
        }

        private void cb_flex_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Scale Factor 2
            int index = getRating(cb_flex.SelectedItem.ToString());
            listScaleFactors[1] = tableScaleFactors[1, index];
            listNameRating[1] = cb_flex.SelectedItem.ToString();
        }

        private void cb_resl_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Scale Factor 3
            int index = getRating(cb_resl.SelectedItem.ToString());
            listScaleFactors[2] = tableScaleFactors[2, index];
            listNameRating[2] = cb_resl.SelectedItem.ToString();
        }

        private void cb_team_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Scale Factor 4
            int index = getRating(cb_team.SelectedItem.ToString());
            listScaleFactors[3] = tableScaleFactors[3, index];
            listNameRating[3] = cb_team.SelectedItem.ToString();
        }

        private void cb_pmat_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Scale Factor 5
            int index = getRating(cb_pmat.SelectedItem.ToString());
            listScaleFactors[4] = tableScaleFactors[4, index];
            listNameRating[4] = cb_pmat.SelectedItem.ToString();
        }

        private void cb_rely_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Cost Driver 1
            int index = getRating(cb_rely.SelectedItem.ToString());
            listCostDrivers[0] = tableCostDrivers[0, index];
            listNameRating[5] = cb_rely.SelectedItem.ToString();
        }

        private void cb_data_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Cost Driver 2
            int index = getRating(cb_data.SelectedItem.ToString());
            listCostDrivers[1] = tableCostDrivers[1, index];
            listNameRating[6] = cb_data.SelectedItem.ToString();
        }

        private void cb_cplx_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Cost Driver 3
            int index = getRating(cb_cplx.SelectedItem.ToString());
            listCostDrivers[2] = tableCostDrivers[2, index];
            listNameRating[7] = cb_cplx.SelectedItem.ToString();
        }

        private void cb_ruse_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Cost Driver 4
            int index = getRating(cb_ruse.SelectedItem.ToString());
            listCostDrivers[3] = tableCostDrivers[3, index];
            listNameRating[8] = cb_ruse.SelectedItem.ToString();
        }

        private void cb_docu_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Cost Driver 5
            int index = getRating(cb_docu.SelectedItem.ToString());
            listCostDrivers[4] = tableCostDrivers[4, index];
            listNameRating[9] = cb_docu.SelectedItem.ToString();
        }

        private void cb_time_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Cost Driver 6
            int index = getRating(cb_time.SelectedItem.ToString());
            listCostDrivers[5] = tableCostDrivers[5, index];
            listNameRating[10] = cb_time.SelectedItem.ToString();
        }

        private void cb_stor_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Cost Driver 7
            int index = getRating(cb_stor.SelectedItem.ToString());
            listCostDrivers[6] = tableCostDrivers[6, index];
            listNameRating[11] = cb_stor.SelectedItem.ToString();
        }

        private void cb_pvol_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Cost Driver 8
            int index = getRating(cb_pvol.SelectedItem.ToString());
            listCostDrivers[7] = tableCostDrivers[7, index];
            listNameRating[12] = cb_pvol.SelectedItem.ToString();
        }

        private void cb_acap_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Cost Driver 9
            int index = getRating(cb_acap.SelectedItem.ToString());
            listCostDrivers[8] = tableCostDrivers[8, index];
            listNameRating[13] = cb_acap.SelectedItem.ToString();
        }

        private void cb_aexp_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Cost Driver 10
            int index = getRating(cb_aexp.SelectedItem.ToString());
            listCostDrivers[9] = tableCostDrivers[9, index];
            listNameRating[14] = cb_aexp.SelectedItem.ToString();
        }

        private void cb_pcap_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Cost Driver 11
            int index = getRating(cb_pcap.SelectedItem.ToString());
            listCostDrivers[10] = tableCostDrivers[10, index];
            listNameRating[15] = cb_pcap.SelectedItem.ToString();
        }

        private void cb_pexp_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Cost Driver 12
            int index = getRating(cb_pexp.SelectedItem.ToString());
            listCostDrivers[11] = tableCostDrivers[11, index];
            listNameRating[16] = cb_pexp.SelectedItem.ToString();
        }

        private void cb_ltexp_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Cost Driver 13
            int index = getRating(cb_ltexp.SelectedItem.ToString());
            listCostDrivers[12] = tableCostDrivers[12, index];
            listNameRating[17] = cb_ltexp.SelectedItem.ToString();
        }

        private void cb_pcon_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Cost Driver 14
            int index = getRating(cb_pcon.SelectedItem.ToString());
            listCostDrivers[13] = tableCostDrivers[13, index];
            listNameRating[18] = cb_pcon.SelectedItem.ToString();
        }

        private void cb_tool_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Cost Driver 15
            int index = getRating(cb_tool.SelectedItem.ToString());
            listCostDrivers[14] = tableCostDrivers[14, index];
            listNameRating[19] = cb_tool.SelectedItem.ToString();
        }

        private void cb_sced_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Cost Driver 16
            int index = getRating(cb_sced.SelectedItem.ToString());
            listCostDrivers[15] = tableCostDrivers[15, index];
            listNameRating[20] = cb_sced.SelectedItem.ToString();
            SCED = listSCED[index];
        }

        private void cb_site_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Cost Driver 17
            int index = getRating(cb_site.SelectedItem.ToString());
            listCostDrivers[16] = tableCostDrivers[16, index];
            listNameRating[21] = cb_site.SelectedItem.ToString();
        }

        private void frm_cocomo2_FormClosing(object sender, FormClosingEventArgs e)
        {
            frm_mainn main = new frm_mainn();
            main.Show();
            
        }

        private void frm_cocomo2_Load(object sender, EventArgs e)
        {
            //Turn off form border
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }

        void calScaleExponent()
        {
            double result = 0;
            for(int i = 0; i < listScaleFactors.Length; i++)
            {
                result+=listScaleFactors[i];
            }
            B = 0.91 + 0.01 * result;
        }
        void calEAF()
        {
            double result = 1;
            for (int i = 0; i < listCostDrivers.Length; i++)
            {
                result *= listCostDrivers[i];
            }
            EAF = result;
        }
        void calculate()
        {
            
            //calculate Tdev
            double tmp = listCostDrivers[15];
            listCostDrivers[15] = 1;
            calEAF();
            Effort = A * Math.Pow(KLOC, B) * EAF;
            Tdev = C * Math.Pow(Effort, 0.28+0.2*(B-0.91))*SCED;
            listCostDrivers[15] = tmp;

            //calculate Effort
            calEAF();
            Effort = A * Math.Pow(KLOC, B) * EAF;

            //calculate cost
            cost = Effort * costperPM;
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
                    var worksheet = workbook.Worksheets.Add("COCOMO II");

                    var dataTable = new DataTable();
                    dataTable.Columns.Add(" ", typeof(string));
                    dataTable.Columns.Add("  ", typeof(string));
                    dataTable.Rows.Add(new object[] { "Software Size (KLOC):", KLOC + "" });
                    dataTable.Rows.Add(new object[] { "Cost per Person-Month (Dollars):", "$ " + costperPM });
                    // Insert DataTable to an Excel worksheet.
                    worksheet.InsertDataTable(dataTable,
                        new InsertDataTableOptions()
                        {
                            ColumnHeaders = true,
                            StartRow = 1
                        });

                    dataTable = new DataTable();
                    dataTable.Columns.Add("   ", typeof(string));
                    dataTable.Columns.Add("Scale Factor", typeof(string));
                    dataTable.Columns.Add("Rating", typeof(string));
                    dataTable.Columns.Add("Value(SFi)", typeof(double));

                    dataTable.Rows.Add(new object[] { "Software Scale Factors" });
                    dataTable.Rows.Add(new object[] { "", "Precedentedness", listNameRating[0], listScaleFactors[0] });
                    dataTable.Rows.Add(new object[] { "", "Development Flexibility", listNameRating[1], listScaleFactors[1] });
                    dataTable.Rows.Add(new object[] { "", "Architecture / Risk Resolution", listNameRating[2], listScaleFactors[2] });
                    dataTable.Rows.Add(new object[] { "", "Team Cohesion", listNameRating[3], listScaleFactors[3] });
                    dataTable.Rows.Add(new object[] { "", "Process Maturity", listNameRating[4], listScaleFactors[4] });
                    // Insert DataTable to an Excel worksheet.
                    worksheet.InsertDataTable(dataTable,
                        new InsertDataTableOptions()
                        {
                            ColumnHeaders = true,
                            StartRow = 5
                        });

                    dataTable = new DataTable();
                    dataTable.Columns.Add("   ", typeof(string));
                    dataTable.Columns.Add("Cost Driver", typeof(string));
                    dataTable.Columns.Add("Rating", typeof(string));
                    dataTable.Columns.Add("Value(EMi)", typeof(double));

                    dataTable.Rows.Add(new object[] { "Product Factors" });
                    dataTable.Rows.Add(new object[] { "", "Required Software Reliability", listNameRating[5], listCostDrivers[0] });
                    dataTable.Rows.Add(new object[] { "", "Database Size", listNameRating[6], listCostDrivers[1] });
                    dataTable.Rows.Add(new object[] { "", "Product Complexity", listNameRating[7], listCostDrivers[2] });
                    dataTable.Rows.Add(new object[] { "", "Developed for Reusability", listNameRating[8], listCostDrivers[3] });
                    dataTable.Rows.Add(new object[] { "", "Documentation", listNameRating[9], listCostDrivers[4] });

                    dataTable.Rows.Add(new object[] { "Platform Factors" });
                    dataTable.Rows.Add(new object[] { "", "Execution Time Constraint", listNameRating[10], listCostDrivers[5] });
                    dataTable.Rows.Add(new object[] { "", "Main Storage Constraint", listNameRating[11], listCostDrivers[6] });
                    dataTable.Rows.Add(new object[] { "", "Platform Volatility", listNameRating[12], listCostDrivers[7] });

                    dataTable.Rows.Add(new object[] { "Personnel Factors" });
                    dataTable.Rows.Add(new object[] { "", "Analyst Capability", listNameRating[13], listCostDrivers[8] });
                    dataTable.Rows.Add(new object[] { "", "Applications Experience", listNameRating[14], listCostDrivers[9] });
                    dataTable.Rows.Add(new object[] { "", "Programmer Capability", listNameRating[15], listCostDrivers[10] });
                    dataTable.Rows.Add(new object[] { "", "Platform Experience", listNameRating[16], listCostDrivers[11] });
                    dataTable.Rows.Add(new object[] { "", "Language and Tool Experience", listNameRating[17], listCostDrivers[12] });
                    dataTable.Rows.Add(new object[] { "", "Personnel Continuity", listNameRating[18], listCostDrivers[13] });

                    dataTable.Rows.Add(new object[] { "Project Factors" });
                    dataTable.Rows.Add(new object[] { "", "Software Tools", listNameRating[19], listCostDrivers[14] });
                    dataTable.Rows.Add(new object[] { "", "Development Schedule", listNameRating[20], listCostDrivers[15] });
                    dataTable.Rows.Add(new object[] { "", "Multisite Development", listNameRating[21], listCostDrivers[16] });


                    worksheet.Cells[0, 0].Value = "Input:";
                    worksheet.Cells[0, 7].Value = "Output:";
                    // Insert DataTable to an Excel worksheet.
                    worksheet.InsertDataTable(dataTable,
                        new InsertDataTableOptions()
                        {
                            ColumnHeaders = true,
                            StartRow = 13
                        });

                    dataTable = new DataTable();
                    dataTable.Columns.Add("   ", typeof(string));
                    dataTable.Columns.Add("     ", typeof(string));
                    dataTable.Columns.Add("      ", typeof(string));
                    dataTable.Rows.Add(new object[] { "Effort:", " ", Math.Round(Effort, 2) + " Persons-months" });
                    dataTable.Rows.Add(new object[] { "Schedule:", " ", Math.Round(Tdev, 2) + " Months" });
                    dataTable.Rows.Add(new object[] { "Cost:", " ", "$ " + Math.Round(cost, 2) });
                    dataTable.Rows.Add(new object[] { "Effort Adjustment Factor (EAF):", " ", "" + Math.Round(EAF, 2) });
                    // Insert DataTable to an Excel worksheet.
                    worksheet.InsertDataTable(dataTable,
                        new InsertDataTableOptions()
                        {
                            ColumnHeaders = true,
                            StartRow = 1,
                            StartColumn = 7
                        });
                    string[] listCell = new string[] { "A1", "A3", "A4", "A7", "A15", "A21", "A25", "A32", "B6", "C6", "D6", "B14", "C14", "D14","H1", "H3", "H4", "H5", "H6" };

                    foreach (string i in listCell)
                    {
                        var cell = worksheet.Cells[i];
                        cell.Style.Font.Weight = ExcelFont.BoldWeight;
                    }
                    var htmlOptions = new HtmlLoadOptions();
                    var html = @"<div style='font:11pt Calibri'><p>Effort = 2.94(KLOC)<sup>0.91 + 0.01&sum;SFi</sup> x EAF =</p></div>";
                    worksheet.Cells["I3"].SetValue(html, htmlOptions);

                    html = @"<div style='font:11pt Calibri'><p>T<sub>dev</sub> = 3.67(Effort)<sup>(0.28 + 0.2(0.01&sum;SFi))</sup> x SCED =</p></div>";
                    worksheet.Cells["I4"].SetValue(html, htmlOptions);

                    html = @"<div style='font:11pt Calibri'><p>Cost = Effort x Cost per Person-Month =</p></div>";
                    worksheet.Cells["I5"].SetValue(html, htmlOptions);

                    html = @"<div style='font:11pt Calibri'><p>EAF = &prod;EM<sub>i</sub> =</p></div>";
                    worksheet.Cells["I6"].SetValue(html, htmlOptions);

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

        

        public frm_cocomo2()
        {
            InitializeComponent();
            SpreadsheetInfo.SetLicense("FREE-LIMITED-KEY");
            for (int i = 0; i < listNameRating.Length; i++)
            {
                listNameRating[i] = "Nominal";
            }
            

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
            if (costperPM < 0 || KLOC < 0)
            {
                MessageBox.Show("All inputs must be filled out >= 0");
                return;
            }
            checkClickCalculate = true;
            calScaleExponent();
            calculate();
            txt_effort.Text = Math.Round(Effort, 2).ToString();
            txt_schedule.Text = Math.Round(Tdev, 2).ToString();
            txt_cost.Text = "$" + Math.Round(cost, 2).ToString();
            txt_eaf.Text = Math.Round(EAF, 2).ToString();
        }
    }
}
