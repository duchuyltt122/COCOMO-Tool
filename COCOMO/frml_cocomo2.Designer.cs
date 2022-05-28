namespace COCOMO
{
    partial class frm_cocomo2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_size = new System.Windows.Forms.TextBox();
            this.txt_costperPM = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_export = new RJCodeAdvance.RJControls.RJButton();
            this.txt_cost = new System.Windows.Forms.TextBox();
            this.txt_schedule = new System.Windows.Forms.TextBox();
            this.txt_eaf = new System.Windows.Forms.TextBox();
            this.txt_effort = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.cb_pcap = new System.Windows.Forms.ComboBox();
            this.cb_site = new System.Windows.Forms.ComboBox();
            this.cb_pvol = new System.Windows.Forms.ComboBox();
            this.cb_cplx = new System.Windows.Forms.ComboBox();
            this.cb_ltexp = new System.Windows.Forms.ComboBox();
            this.cb_aexp = new System.Windows.Forms.ComboBox();
            this.cb_sced = new System.Windows.Forms.ComboBox();
            this.cb_stor = new System.Windows.Forms.ComboBox();
            this.cb_data = new System.Windows.Forms.ComboBox();
            this.cb_pexp = new System.Windows.Forms.ComboBox();
            this.cb_acap = new System.Windows.Forms.ComboBox();
            this.cb_tool = new System.Windows.Forms.ComboBox();
            this.cb_time = new System.Windows.Forms.ComboBox();
            this.cb_rely = new System.Windows.Forms.ComboBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_cal = new RJCodeAdvance.RJControls.RJButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gb_platformFactors = new System.Windows.Forms.GroupBox();
            this.gb_productFactors = new System.Windows.Forms.GroupBox();
            this.label37 = new System.Windows.Forms.Label();
            this.cb_ruse = new System.Windows.Forms.ComboBox();
            this.label38 = new System.Windows.Forms.Label();
            this.cb_docu = new System.Windows.Forms.ComboBox();
            this.cb_softwareScaleFactors = new System.Windows.Forms.GroupBox();
            this.label31 = new System.Windows.Forms.Label();
            this.cb_prec = new System.Windows.Forms.ComboBox();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.cb_flex = new System.Windows.Forms.ComboBox();
            this.cb_resl = new System.Windows.Forms.ComboBox();
            this.label35 = new System.Windows.Forms.Label();
            this.cb_team = new System.Windows.Forms.ComboBox();
            this.label36 = new System.Windows.Forms.Label();
            this.cb_pmat = new System.Windows.Forms.ComboBox();
            this.cb_pcon = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cb_softwareLaborRates = new System.Windows.Forms.GroupBox();
            this.gb_personnelFactors = new System.Windows.Forms.GroupBox();
            this.gb_projectFactors = new System.Windows.Forms.GroupBox();
            this.btn_back = new RJCodeAdvance.RJControls.RJButton();
            this.btn_reset = new RJCodeAdvance.RJControls.RJButton();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gb_platformFactors.SuspendLayout();
            this.gb_productFactors.SuspendLayout();
            this.cb_softwareScaleFactors.SuspendLayout();
            this.cb_softwareLaborRates.SuspendLayout();
            this.gb_personnelFactors.SuspendLayout();
            this.gb_projectFactors.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_size
            // 
            this.txt_size.Location = new System.Drawing.Point(276, 19);
            this.txt_size.Margin = new System.Windows.Forms.Padding(2);
            this.txt_size.Name = "txt_size";
            this.txt_size.Size = new System.Drawing.Size(117, 20);
            this.txt_size.TabIndex = 0;
            this.txt_size.Text = "0";
            // 
            // txt_costperPM
            // 
            this.txt_costperPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_costperPM.Location = new System.Drawing.Point(178, 21);
            this.txt_costperPM.Margin = new System.Windows.Forms.Padding(2);
            this.txt_costperPM.Name = "txt_costperPM";
            this.txt_costperPM.Size = new System.Drawing.Size(117, 20);
            this.txt_costperPM.TabIndex = 11;
            this.txt_costperPM.Text = "0";
            this.txt_costperPM.TextChanged += new System.EventHandler(this.txt_costperPM_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.btn_back);
            this.panel2.Controls.Add(this.btn_export);
            this.panel2.Controls.Add(this.txt_cost);
            this.panel2.Controls.Add(this.txt_schedule);
            this.panel2.Controls.Add(this.txt_eaf);
            this.panel2.Controls.Add(this.txt_effort);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label27);
            this.panel2.Controls.Add(this.label26);
            this.panel2.Controls.Add(this.label28);
            this.panel2.Controls.Add(this.label30);
            this.panel2.Controls.Add(this.label29);
            this.panel2.Controls.Add(this.label25);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 541);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(810, 142);
            this.panel2.TabIndex = 43;
            // 
            // btn_export
            // 
            this.btn_export.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_export.BackgroundColor = System.Drawing.Color.SeaGreen;
            this.btn_export.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_export.BorderRadius = 1;
            this.btn_export.BorderSize = 1;
            this.btn_export.FlatAppearance.BorderSize = 0;
            this.btn_export.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_export.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_export.ForeColor = System.Drawing.Color.White;
            this.btn_export.Location = new System.Drawing.Point(433, 84);
            this.btn_export.Margin = new System.Windows.Forms.Padding(2);
            this.btn_export.Name = "btn_export";
            this.btn_export.Size = new System.Drawing.Size(112, 32);
            this.btn_export.TabIndex = 30;
            this.btn_export.Text = "Export Excel File";
            this.btn_export.TextColor = System.Drawing.Color.White;
            this.btn_export.UseVisualStyleBackColor = false;
            this.btn_export.Click += new System.EventHandler(this.btn_export_Click);
            // 
            // txt_cost
            // 
            this.txt_cost.Location = new System.Drawing.Point(179, 96);
            this.txt_cost.Margin = new System.Windows.Forms.Padding(2);
            this.txt_cost.Name = "txt_cost";
            this.txt_cost.ReadOnly = true;
            this.txt_cost.Size = new System.Drawing.Size(132, 20);
            this.txt_cost.TabIndex = 28;
            // 
            // txt_schedule
            // 
            this.txt_schedule.Location = new System.Drawing.Point(179, 69);
            this.txt_schedule.Margin = new System.Windows.Forms.Padding(2);
            this.txt_schedule.Name = "txt_schedule";
            this.txt_schedule.ReadOnly = true;
            this.txt_schedule.Size = new System.Drawing.Size(132, 20);
            this.txt_schedule.TabIndex = 27;
            // 
            // txt_eaf
            // 
            this.txt_eaf.Location = new System.Drawing.Point(592, 40);
            this.txt_eaf.Margin = new System.Windows.Forms.Padding(2);
            this.txt_eaf.Name = "txt_eaf";
            this.txt_eaf.ReadOnly = true;
            this.txt_eaf.Size = new System.Drawing.Size(116, 20);
            this.txt_eaf.TabIndex = 29;
            // 
            // txt_effort
            // 
            this.txt_effort.Location = new System.Drawing.Point(179, 40);
            this.txt_effort.Margin = new System.Windows.Forms.Padding(2);
            this.txt_effort.Name = "txt_effort";
            this.txt_effort.ReadOnly = true;
            this.txt_effort.Size = new System.Drawing.Size(132, 20);
            this.txt_effort.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(105, 16);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Results";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(114, 99);
            this.label27.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(28, 13);
            this.label27.TabIndex = 8;
            this.label27.Text = "Cost";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(114, 72);
            this.label26.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(52, 13);
            this.label26.TabIndex = 8;
            this.label26.Text = "Schedule";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(430, 43);
            this.label28.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(149, 13);
            this.label28.TabIndex = 8;
            this.label28.Text = "Effort Adjustment Factor (EAF)";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(315, 69);
            this.label30.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(42, 13);
            this.label30.TabIndex = 8;
            this.label30.Text = "Months";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(315, 43);
            this.label29.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(77, 13);
            this.label29.TabIndex = 8;
            this.label29.Text = "Person-months";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(114, 43);
            this.label25.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(32, 13);
            this.label25.TabIndex = 8;
            this.label25.Text = "Effort";
            // 
            // cb_pcap
            // 
            this.cb_pcap.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_pcap.FormattingEnabled = true;
            this.cb_pcap.Items.AddRange(new object[] {
            "Very Low",
            "Low",
            "Nominal",
            "High",
            "Very High"});
            this.cb_pcap.Location = new System.Drawing.Point(178, 82);
            this.cb_pcap.Margin = new System.Windows.Forms.Padding(2);
            this.cb_pcap.Name = "cb_pcap";
            this.cb_pcap.Size = new System.Drawing.Size(116, 21);
            this.cb_pcap.TabIndex = 17;
            this.cb_pcap.Text = "Nominal";
            this.cb_pcap.SelectedIndexChanged += new System.EventHandler(this.cb_pcap_SelectedIndexChanged);
            // 
            // cb_site
            // 
            this.cb_site.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_site.FormattingEnabled = true;
            this.cb_site.Items.AddRange(new object[] {
            "Very Low",
            "Low",
            "Nominal",
            "High",
            "Very High",
            "Extra High"});
            this.cb_site.Location = new System.Drawing.Point(178, 86);
            this.cb_site.Margin = new System.Windows.Forms.Padding(2);
            this.cb_site.Name = "cb_site";
            this.cb_site.Size = new System.Drawing.Size(116, 21);
            this.cb_site.TabIndex = 23;
            this.cb_site.Text = "Nominal";
            this.cb_site.SelectedIndexChanged += new System.EventHandler(this.cb_site_SelectedIndexChanged);
            // 
            // cb_pvol
            // 
            this.cb_pvol.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_pvol.FormattingEnabled = true;
            this.cb_pvol.Items.AddRange(new object[] {
            "Low",
            "Nominal",
            "High",
            "Very High"});
            this.cb_pvol.Location = new System.Drawing.Point(178, 87);
            this.cb_pvol.Margin = new System.Windows.Forms.Padding(2);
            this.cb_pvol.Name = "cb_pvol";
            this.cb_pvol.Size = new System.Drawing.Size(116, 21);
            this.cb_pvol.TabIndex = 14;
            this.cb_pvol.Text = "Nominal";
            this.cb_pvol.SelectedIndexChanged += new System.EventHandler(this.cb_pvol_SelectedIndexChanged);
            // 
            // cb_cplx
            // 
            this.cb_cplx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_cplx.FormattingEnabled = true;
            this.cb_cplx.Items.AddRange(new object[] {
            "Very Low",
            "Low",
            "Nominal",
            "High",
            "Very High",
            "Extra High"});
            this.cb_cplx.Location = new System.Drawing.Point(179, 81);
            this.cb_cplx.Margin = new System.Windows.Forms.Padding(2);
            this.cb_cplx.Name = "cb_cplx";
            this.cb_cplx.Size = new System.Drawing.Size(116, 21);
            this.cb_cplx.TabIndex = 8;
            this.cb_cplx.Text = "Nominal";
            this.cb_cplx.SelectedIndexChanged += new System.EventHandler(this.cb_cplx_SelectedIndexChanged);
            // 
            // cb_ltexp
            // 
            this.cb_ltexp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_ltexp.FormattingEnabled = true;
            this.cb_ltexp.Items.AddRange(new object[] {
            "Very Low",
            "Low",
            "Nominal",
            "High",
            "Very High"});
            this.cb_ltexp.Location = new System.Drawing.Point(178, 147);
            this.cb_ltexp.Margin = new System.Windows.Forms.Padding(2);
            this.cb_ltexp.Name = "cb_ltexp";
            this.cb_ltexp.Size = new System.Drawing.Size(116, 21);
            this.cb_ltexp.TabIndex = 19;
            this.cb_ltexp.Text = "Nominal";
            this.cb_ltexp.SelectedIndexChanged += new System.EventHandler(this.cb_ltexp_SelectedIndexChanged);
            // 
            // cb_aexp
            // 
            this.cb_aexp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_aexp.FormattingEnabled = true;
            this.cb_aexp.Items.AddRange(new object[] {
            "Very Low",
            "Low",
            "Nominal",
            "High",
            "Very High"});
            this.cb_aexp.Location = new System.Drawing.Point(178, 51);
            this.cb_aexp.Margin = new System.Windows.Forms.Padding(2);
            this.cb_aexp.Name = "cb_aexp";
            this.cb_aexp.Size = new System.Drawing.Size(116, 21);
            this.cb_aexp.TabIndex = 16;
            this.cb_aexp.Text = "Nominal";
            this.cb_aexp.SelectedIndexChanged += new System.EventHandler(this.cb_aexp_SelectedIndexChanged);
            // 
            // cb_sced
            // 
            this.cb_sced.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_sced.FormattingEnabled = true;
            this.cb_sced.Items.AddRange(new object[] {
            "Very Low",
            "Low",
            "Nominal",
            "High",
            "Very High"});
            this.cb_sced.Location = new System.Drawing.Point(178, 51);
            this.cb_sced.Margin = new System.Windows.Forms.Padding(2);
            this.cb_sced.Name = "cb_sced";
            this.cb_sced.Size = new System.Drawing.Size(116, 21);
            this.cb_sced.TabIndex = 22;
            this.cb_sced.Text = "Nominal";
            this.cb_sced.SelectedIndexChanged += new System.EventHandler(this.cb_sced_SelectedIndexChanged);
            // 
            // cb_stor
            // 
            this.cb_stor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_stor.FormattingEnabled = true;
            this.cb_stor.Items.AddRange(new object[] {
            "Nominal",
            "High",
            "Very High",
            "Extra High"});
            this.cb_stor.Location = new System.Drawing.Point(178, 57);
            this.cb_stor.Margin = new System.Windows.Forms.Padding(2);
            this.cb_stor.Name = "cb_stor";
            this.cb_stor.Size = new System.Drawing.Size(116, 21);
            this.cb_stor.TabIndex = 13;
            this.cb_stor.Text = "Nominal";
            this.cb_stor.SelectedIndexChanged += new System.EventHandler(this.cb_stor_SelectedIndexChanged);
            // 
            // cb_data
            // 
            this.cb_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_data.FormattingEnabled = true;
            this.cb_data.Items.AddRange(new object[] {
            "Low",
            "Nominal",
            "High",
            "Very High"});
            this.cb_data.Location = new System.Drawing.Point(179, 49);
            this.cb_data.Margin = new System.Windows.Forms.Padding(2);
            this.cb_data.Name = "cb_data";
            this.cb_data.Size = new System.Drawing.Size(116, 21);
            this.cb_data.TabIndex = 7;
            this.cb_data.Text = "Nominal";
            this.cb_data.SelectedIndexChanged += new System.EventHandler(this.cb_data_SelectedIndexChanged);
            // 
            // cb_pexp
            // 
            this.cb_pexp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_pexp.FormattingEnabled = true;
            this.cb_pexp.Items.AddRange(new object[] {
            "Very Low",
            "Low",
            "Nominal",
            "High",
            "Very High"});
            this.cb_pexp.Location = new System.Drawing.Point(178, 115);
            this.cb_pexp.Margin = new System.Windows.Forms.Padding(2);
            this.cb_pexp.Name = "cb_pexp";
            this.cb_pexp.Size = new System.Drawing.Size(116, 21);
            this.cb_pexp.TabIndex = 18;
            this.cb_pexp.Text = "Nominal";
            this.cb_pexp.SelectedIndexChanged += new System.EventHandler(this.cb_pexp_SelectedIndexChanged);
            // 
            // cb_acap
            // 
            this.cb_acap.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_acap.FormattingEnabled = true;
            this.cb_acap.Items.AddRange(new object[] {
            "Very Low",
            "Low",
            "Nominal",
            "High",
            "Very High"});
            this.cb_acap.Location = new System.Drawing.Point(178, 18);
            this.cb_acap.Margin = new System.Windows.Forms.Padding(2);
            this.cb_acap.Name = "cb_acap";
            this.cb_acap.Size = new System.Drawing.Size(116, 21);
            this.cb_acap.TabIndex = 15;
            this.cb_acap.Text = "Nominal";
            this.cb_acap.SelectedIndexChanged += new System.EventHandler(this.cb_acap_SelectedIndexChanged);
            // 
            // cb_tool
            // 
            this.cb_tool.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_tool.FormattingEnabled = true;
            this.cb_tool.Items.AddRange(new object[] {
            "Very Low",
            "Low",
            "Nominal",
            "High",
            "Very High"});
            this.cb_tool.Location = new System.Drawing.Point(178, 16);
            this.cb_tool.Margin = new System.Windows.Forms.Padding(2);
            this.cb_tool.Name = "cb_tool";
            this.cb_tool.Size = new System.Drawing.Size(116, 21);
            this.cb_tool.TabIndex = 21;
            this.cb_tool.Text = "Nominal";
            this.cb_tool.SelectedIndexChanged += new System.EventHandler(this.cb_tool_SelectedIndexChanged);
            // 
            // cb_time
            // 
            this.cb_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_time.FormattingEnabled = true;
            this.cb_time.Items.AddRange(new object[] {
            "Nominal",
            "High",
            "Very High",
            "Extra High"});
            this.cb_time.Location = new System.Drawing.Point(178, 26);
            this.cb_time.Margin = new System.Windows.Forms.Padding(2);
            this.cb_time.Name = "cb_time";
            this.cb_time.Size = new System.Drawing.Size(116, 21);
            this.cb_time.TabIndex = 12;
            this.cb_time.Text = "Nominal";
            this.cb_time.SelectedIndexChanged += new System.EventHandler(this.cb_time_SelectedIndexChanged);
            // 
            // cb_rely
            // 
            this.cb_rely.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_rely.FormattingEnabled = true;
            this.cb_rely.Items.AddRange(new object[] {
            "Very Low",
            "Low",
            "Nominal",
            "High",
            "Very High"});
            this.cb_rely.Location = new System.Drawing.Point(179, 17);
            this.cb_rely.Margin = new System.Windows.Forms.Padding(2);
            this.cb_rely.Name = "cb_rely";
            this.cb_rely.Size = new System.Drawing.Size(116, 21);
            this.cb_rely.TabIndex = 6;
            this.cb_rely.Text = "Nominal";
            this.cb_rely.SelectedIndexChanged += new System.EventHandler(this.cb_rely_SelectedIndexChanged);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(16, 24);
            this.label24.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(156, 13);
            this.label24.TabIndex = 25;
            this.label24.Text = "Cost per Person-Month (Dollars)";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(16, 89);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(111, 13);
            this.label18.TabIndex = 25;
            this.label18.Text = "Multisite Development";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(16, 54);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(118, 13);
            this.label14.TabIndex = 24;
            this.label14.Text = "Development Schedule";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(16, 19);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(78, 13);
            this.label17.TabIndex = 23;
            this.label17.Text = "Software Tools";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(16, 90);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(86, 13);
            this.label21.TabIndex = 6;
            this.label21.Text = "Platform Volatility";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(16, 60);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(120, 13);
            this.label20.TabIndex = 7;
            this.label20.Text = "Main Storage Constraint";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(16, 29);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(130, 13);
            this.label19.TabIndex = 8;
            this.label19.Text = "Execution Time Constraint";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(16, 150);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(156, 13);
            this.label15.TabIndex = 10;
            this.label15.Text = "Language and Tool Experience";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(16, 118);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(101, 13);
            this.label13.TabIndex = 11;
            this.label13.Text = "Platform Experience";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(105, 19);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(145, 15);
            this.label8.TabIndex = 12;
            this.label8.Text = "Software Size (KLOC)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(16, 85);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(111, 13);
            this.label12.TabIndex = 13;
            this.label12.Text = "Programmer Capability";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(16, 54);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(120, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "Applications Experience";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(16, 21);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Analyst Capability";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(16, 84);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Product Complexity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 52);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Database Size";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 20);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Required Software Reliability";
            // 
            // btn_cal
            // 
            this.btn_cal.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_cal.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.btn_cal.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btn_cal.BorderRadius = 1;
            this.btn_cal.BorderSize = 1;
            this.btn_cal.FlatAppearance.BorderSize = 0;
            this.btn_cal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cal.ForeColor = System.Drawing.Color.White;
            this.btn_cal.Location = new System.Drawing.Point(592, 495);
            this.btn_cal.Margin = new System.Windows.Forms.Padding(2);
            this.btn_cal.Name = "btn_cal";
            this.btn_cal.Size = new System.Drawing.Size(116, 32);
            this.btn_cal.TabIndex = 24;
            this.btn_cal.Text = "Calculate";
            this.btn_cal.TextColor = System.Drawing.Color.White;
            this.btn_cal.UseVisualStyleBackColor = false;
            this.btn_cal.Click += new System.EventHandler(this.btn_cal_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.btn_reset);
            this.panel1.Controls.Add(this.gb_projectFactors);
            this.panel1.Controls.Add(this.gb_personnelFactors);
            this.panel1.Controls.Add(this.cb_softwareLaborRates);
            this.panel1.Controls.Add(this.gb_platformFactors);
            this.panel1.Controls.Add(this.gb_productFactors);
            this.panel1.Controls.Add(this.cb_softwareScaleFactors);
            this.panel1.Controls.Add(this.txt_size);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.btn_cal);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(810, 683);
            this.panel1.TabIndex = 1;
            // 
            // gb_platformFactors
            // 
            this.gb_platformFactors.Controls.Add(this.label19);
            this.gb_platformFactors.Controls.Add(this.cb_time);
            this.gb_platformFactors.Controls.Add(this.label20);
            this.gb_platformFactors.Controls.Add(this.cb_stor);
            this.gb_platformFactors.Controls.Add(this.label21);
            this.gb_platformFactors.Controls.Add(this.cb_pvol);
            this.gb_platformFactors.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_platformFactors.Location = new System.Drawing.Point(424, 19);
            this.gb_platformFactors.Name = "gb_platformFactors";
            this.gb_platformFactors.Size = new System.Drawing.Size(310, 121);
            this.gb_platformFactors.TabIndex = 48;
            this.gb_platformFactors.TabStop = false;
            this.gb_platformFactors.Text = "Platform Factors";
            // 
            // gb_productFactors
            // 
            this.gb_productFactors.Controls.Add(this.label4);
            this.gb_productFactors.Controls.Add(this.cb_rely);
            this.gb_productFactors.Controls.Add(this.label6);
            this.gb_productFactors.Controls.Add(this.cb_data);
            this.gb_productFactors.Controls.Add(this.label9);
            this.gb_productFactors.Controls.Add(this.cb_cplx);
            this.gb_productFactors.Controls.Add(this.label37);
            this.gb_productFactors.Controls.Add(this.cb_ruse);
            this.gb_productFactors.Controls.Add(this.label38);
            this.gb_productFactors.Controls.Add(this.cb_docu);
            this.gb_productFactors.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_productFactors.Location = new System.Drawing.Point(98, 228);
            this.gb_productFactors.Name = "gb_productFactors";
            this.gb_productFactors.Size = new System.Drawing.Size(310, 177);
            this.gb_productFactors.TabIndex = 47;
            this.gb_productFactors.TabStop = false;
            this.gb_productFactors.Text = "Product Factors";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.Location = new System.Drawing.Point(16, 115);
            this.label37.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(128, 13);
            this.label37.TabIndex = 18;
            this.label37.Text = "Developed for Reusability";
            // 
            // cb_ruse
            // 
            this.cb_ruse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_ruse.FormattingEnabled = true;
            this.cb_ruse.Items.AddRange(new object[] {
            "Low",
            "Nominal",
            "High",
            "Very High",
            "Extra High"});
            this.cb_ruse.Location = new System.Drawing.Point(178, 112);
            this.cb_ruse.Margin = new System.Windows.Forms.Padding(2);
            this.cb_ruse.Name = "cb_ruse";
            this.cb_ruse.Size = new System.Drawing.Size(116, 21);
            this.cb_ruse.TabIndex = 9;
            this.cb_ruse.Text = "Nominal";
            this.cb_ruse.SelectedIndexChanged += new System.EventHandler(this.cb_ruse_SelectedIndexChanged);
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label38.Location = new System.Drawing.Point(16, 145);
            this.label38.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(79, 13);
            this.label38.TabIndex = 17;
            this.label38.Text = "Documentation";
            // 
            // cb_docu
            // 
            this.cb_docu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_docu.FormattingEnabled = true;
            this.cb_docu.Items.AddRange(new object[] {
            "Very Low",
            "Low",
            "Nominal",
            "High",
            "Very High"});
            this.cb_docu.Location = new System.Drawing.Point(178, 142);
            this.cb_docu.Margin = new System.Windows.Forms.Padding(2);
            this.cb_docu.Name = "cb_docu";
            this.cb_docu.Size = new System.Drawing.Size(116, 21);
            this.cb_docu.TabIndex = 10;
            this.cb_docu.Text = "Nominal";
            this.cb_docu.SelectedIndexChanged += new System.EventHandler(this.cb_docu_SelectedIndexChanged);
            // 
            // cb_softwareScaleFactors
            // 
            this.cb_softwareScaleFactors.Controls.Add(this.label31);
            this.cb_softwareScaleFactors.Controls.Add(this.cb_prec);
            this.cb_softwareScaleFactors.Controls.Add(this.label32);
            this.cb_softwareScaleFactors.Controls.Add(this.label33);
            this.cb_softwareScaleFactors.Controls.Add(this.cb_flex);
            this.cb_softwareScaleFactors.Controls.Add(this.cb_resl);
            this.cb_softwareScaleFactors.Controls.Add(this.label35);
            this.cb_softwareScaleFactors.Controls.Add(this.cb_team);
            this.cb_softwareScaleFactors.Controls.Add(this.label36);
            this.cb_softwareScaleFactors.Controls.Add(this.cb_pmat);
            this.cb_softwareScaleFactors.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_softwareScaleFactors.Location = new System.Drawing.Point(98, 52);
            this.cb_softwareScaleFactors.Name = "cb_softwareScaleFactors";
            this.cb_softwareScaleFactors.Size = new System.Drawing.Size(310, 170);
            this.cb_softwareScaleFactors.TabIndex = 46;
            this.cb_softwareScaleFactors.TabStop = false;
            this.cb_softwareScaleFactors.Text = "Software Scale Factors";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(16, 20);
            this.label31.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(90, 13);
            this.label31.TabIndex = 19;
            this.label31.Text = "Precedentedness";
            // 
            // cb_prec
            // 
            this.cb_prec.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_prec.FormattingEnabled = true;
            this.cb_prec.Items.AddRange(new object[] {
            "Very Low",
            "Low",
            "Nominal",
            "High",
            "Very High"});
            this.cb_prec.Location = new System.Drawing.Point(178, 17);
            this.cb_prec.Margin = new System.Windows.Forms.Padding(2);
            this.cb_prec.Name = "cb_prec";
            this.cb_prec.Size = new System.Drawing.Size(116, 21);
            this.cb_prec.TabIndex = 1;
            this.cb_prec.Text = "Nominal";
            this.cb_prec.SelectedIndexChanged += new System.EventHandler(this.cb_prec_SelectedIndexChanged);
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(16, 51);
            this.label32.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(114, 13);
            this.label32.TabIndex = 18;
            this.label32.Text = "Development Flexibility";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(16, 81);
            this.label33.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(149, 13);
            this.label33.TabIndex = 17;
            this.label33.Text = "Architecture / Risk Resolution";
            // 
            // cb_flex
            // 
            this.cb_flex.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_flex.FormattingEnabled = true;
            this.cb_flex.Items.AddRange(new object[] {
            "Very Low",
            "Low",
            "Nominal",
            "High",
            "Very High"});
            this.cb_flex.Location = new System.Drawing.Point(178, 48);
            this.cb_flex.Margin = new System.Windows.Forms.Padding(2);
            this.cb_flex.Name = "cb_flex";
            this.cb_flex.Size = new System.Drawing.Size(116, 21);
            this.cb_flex.TabIndex = 2;
            this.cb_flex.Text = "Nominal";
            this.cb_flex.SelectedIndexChanged += new System.EventHandler(this.cb_flex_SelectedIndexChanged);
            // 
            // cb_resl
            // 
            this.cb_resl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_resl.FormattingEnabled = true;
            this.cb_resl.Items.AddRange(new object[] {
            "Very Low",
            "Low",
            "Nominal",
            "High",
            "Very High"});
            this.cb_resl.Location = new System.Drawing.Point(178, 78);
            this.cb_resl.Margin = new System.Windows.Forms.Padding(2);
            this.cb_resl.Name = "cb_resl";
            this.cb_resl.Size = new System.Drawing.Size(116, 21);
            this.cb_resl.TabIndex = 3;
            this.cb_resl.Text = "Nominal";
            this.cb_resl.SelectedIndexChanged += new System.EventHandler(this.cb_resl_SelectedIndexChanged);
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.Location = new System.Drawing.Point(16, 110);
            this.label35.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(81, 13);
            this.label35.TabIndex = 18;
            this.label35.Text = "Team Cohesion";
            // 
            // cb_team
            // 
            this.cb_team.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_team.FormattingEnabled = true;
            this.cb_team.Items.AddRange(new object[] {
            "Very Low",
            "Low",
            "Nominal",
            "High",
            "Very High"});
            this.cb_team.Location = new System.Drawing.Point(178, 107);
            this.cb_team.Margin = new System.Windows.Forms.Padding(2);
            this.cb_team.Name = "cb_team";
            this.cb_team.Size = new System.Drawing.Size(116, 21);
            this.cb_team.TabIndex = 4;
            this.cb_team.Text = "Nominal";
            this.cb_team.SelectedIndexChanged += new System.EventHandler(this.cb_team_SelectedIndexChanged);
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.Location = new System.Drawing.Point(16, 139);
            this.label36.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(85, 13);
            this.label36.TabIndex = 17;
            this.label36.Text = "Process Maturity";
            // 
            // cb_pmat
            // 
            this.cb_pmat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_pmat.FormattingEnabled = true;
            this.cb_pmat.Items.AddRange(new object[] {
            "Very Low",
            "Low",
            "Nominal",
            "High",
            "Very High"});
            this.cb_pmat.Location = new System.Drawing.Point(178, 136);
            this.cb_pmat.Margin = new System.Windows.Forms.Padding(2);
            this.cb_pmat.Name = "cb_pmat";
            this.cb_pmat.Size = new System.Drawing.Size(116, 21);
            this.cb_pmat.TabIndex = 5;
            this.cb_pmat.Text = "Nominal";
            this.cb_pmat.SelectedIndexChanged += new System.EventHandler(this.cb_pmat_SelectedIndexChanged);
            // 
            // cb_pcon
            // 
            this.cb_pcon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_pcon.FormattingEnabled = true;
            this.cb_pcon.Items.AddRange(new object[] {
            "Very Low",
            "Low",
            "Nominal",
            "High",
            "Very High"});
            this.cb_pcon.Location = new System.Drawing.Point(178, 178);
            this.cb_pcon.Margin = new System.Windows.Forms.Padding(2);
            this.cb_pcon.Name = "cb_pcon";
            this.cb_pcon.Size = new System.Drawing.Size(116, 21);
            this.cb_pcon.TabIndex = 20;
            this.cb_pcon.Text = "Nominal";
            this.cb_pcon.SelectedIndexChanged += new System.EventHandler(this.cb_pcon_SelectedIndexChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(16, 181);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(103, 13);
            this.label16.TabIndex = 10;
            this.label16.Text = "Personnel Continuity";
            // 
            // cb_softwareLaborRates
            // 
            this.cb_softwareLaborRates.Controls.Add(this.label24);
            this.cb_softwareLaborRates.Controls.Add(this.txt_costperPM);
            this.cb_softwareLaborRates.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_softwareLaborRates.Location = new System.Drawing.Point(98, 411);
            this.cb_softwareLaborRates.Name = "cb_softwareLaborRates";
            this.cb_softwareLaborRates.Size = new System.Drawing.Size(310, 68);
            this.cb_softwareLaborRates.TabIndex = 49;
            this.cb_softwareLaborRates.TabStop = false;
            this.cb_softwareLaborRates.Text = "Software Labor Rates";
            // 
            // gb_personnelFactors
            // 
            this.gb_personnelFactors.Controls.Add(this.label10);
            this.gb_personnelFactors.Controls.Add(this.cb_acap);
            this.gb_personnelFactors.Controls.Add(this.label13);
            this.gb_personnelFactors.Controls.Add(this.label11);
            this.gb_personnelFactors.Controls.Add(this.label12);
            this.gb_personnelFactors.Controls.Add(this.label15);
            this.gb_personnelFactors.Controls.Add(this.label16);
            this.gb_personnelFactors.Controls.Add(this.cb_pcap);
            this.gb_personnelFactors.Controls.Add(this.cb_pexp);
            this.gb_personnelFactors.Controls.Add(this.cb_aexp);
            this.gb_personnelFactors.Controls.Add(this.cb_pcon);
            this.gb_personnelFactors.Controls.Add(this.cb_ltexp);
            this.gb_personnelFactors.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_personnelFactors.Location = new System.Drawing.Point(424, 146);
            this.gb_personnelFactors.Name = "gb_personnelFactors";
            this.gb_personnelFactors.Size = new System.Drawing.Size(310, 210);
            this.gb_personnelFactors.TabIndex = 50;
            this.gb_personnelFactors.TabStop = false;
            this.gb_personnelFactors.Text = "Personnel Factors";
            // 
            // gb_projectFactors
            // 
            this.gb_projectFactors.Controls.Add(this.label17);
            this.gb_projectFactors.Controls.Add(this.label14);
            this.gb_projectFactors.Controls.Add(this.label18);
            this.gb_projectFactors.Controls.Add(this.cb_tool);
            this.gb_projectFactors.Controls.Add(this.cb_sced);
            this.gb_projectFactors.Controls.Add(this.cb_site);
            this.gb_projectFactors.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_projectFactors.Location = new System.Drawing.Point(424, 362);
            this.gb_projectFactors.Name = "gb_projectFactors";
            this.gb_projectFactors.Size = new System.Drawing.Size(310, 117);
            this.gb_projectFactors.TabIndex = 51;
            this.gb_projectFactors.TabStop = false;
            this.gb_projectFactors.Text = "Project Factors";
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_back.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.btn_back.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btn_back.BorderRadius = 1;
            this.btn_back.BorderSize = 1;
            this.btn_back.FlatAppearance.BorderSize = 0;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.Color.White;
            this.btn_back.Location = new System.Drawing.Point(592, 84);
            this.btn_back.Margin = new System.Windows.Forms.Padding(2);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(116, 32);
            this.btn_back.TabIndex = 31;
            this.btn_back.Text = "Back";
            this.btn_back.TextColor = System.Drawing.Color.White;
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.Color.Peru;
            this.btn_reset.BackgroundColor = System.Drawing.Color.Peru;
            this.btn_reset.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.btn_reset.BorderRadius = 1;
            this.btn_reset.BorderSize = 1;
            this.btn_reset.FlatAppearance.BorderSize = 0;
            this.btn_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reset.ForeColor = System.Drawing.Color.White;
            this.btn_reset.Location = new System.Drawing.Point(433, 495);
            this.btn_reset.Margin = new System.Windows.Forms.Padding(2);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(112, 32);
            this.btn_reset.TabIndex = 25;
            this.btn_reset.Text = "Reset";
            this.btn_reset.TextColor = System.Drawing.Color.White;
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // frm_cocomo2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(810, 683);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "frm_cocomo2";
            this.Text = "COCOMO II";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_cocomo2_FormClosing);
            this.Load += new System.EventHandler(this.frm_cocomo2_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gb_platformFactors.ResumeLayout(false);
            this.gb_platformFactors.PerformLayout();
            this.gb_productFactors.ResumeLayout(false);
            this.gb_productFactors.PerformLayout();
            this.cb_softwareScaleFactors.ResumeLayout(false);
            this.cb_softwareScaleFactors.PerformLayout();
            this.cb_softwareLaborRates.ResumeLayout(false);
            this.cb_softwareLaborRates.PerformLayout();
            this.gb_personnelFactors.ResumeLayout(false);
            this.gb_personnelFactors.PerformLayout();
            this.gb_projectFactors.ResumeLayout(false);
            this.gb_projectFactors.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txt_size;
        private System.Windows.Forms.TextBox txt_costperPM;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_cost;
        private System.Windows.Forms.TextBox txt_schedule;
        private System.Windows.Forms.TextBox txt_eaf;
        private System.Windows.Forms.TextBox txt_effort;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.ComboBox cb_pcap;
        private System.Windows.Forms.ComboBox cb_site;
        private System.Windows.Forms.ComboBox cb_pvol;
        private System.Windows.Forms.ComboBox cb_cplx;
        private System.Windows.Forms.ComboBox cb_ltexp;
        private System.Windows.Forms.ComboBox cb_aexp;
        private System.Windows.Forms.ComboBox cb_sced;
        private System.Windows.Forms.ComboBox cb_stor;
        private System.Windows.Forms.ComboBox cb_data;
        private System.Windows.Forms.ComboBox cb_pexp;
        private System.Windows.Forms.ComboBox cb_acap;
        private System.Windows.Forms.ComboBox cb_tool;
        private System.Windows.Forms.ComboBox cb_time;
        private System.Windows.Forms.ComboBox cb_rely;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private RJCodeAdvance.RJControls.RJButton btn_cal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cb_resl;
        private System.Windows.Forms.ComboBox cb_flex;
        private System.Windows.Forms.ComboBox cb_prec;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.ComboBox cb_pmat;
        private System.Windows.Forms.ComboBox cb_team;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label35;
        private RJCodeAdvance.RJControls.RJButton btn_export;
        private System.Windows.Forms.ComboBox cb_docu;
        private System.Windows.Forms.ComboBox cb_pcon;
        private System.Windows.Forms.ComboBox cb_ruse;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.GroupBox cb_softwareScaleFactors;
        private System.Windows.Forms.GroupBox gb_platformFactors;
        private System.Windows.Forms.GroupBox gb_productFactors;
        private System.Windows.Forms.GroupBox cb_softwareLaborRates;
        private System.Windows.Forms.GroupBox gb_personnelFactors;
        private System.Windows.Forms.GroupBox gb_projectFactors;
        private RJCodeAdvance.RJControls.RJButton btn_back;
        private RJCodeAdvance.RJControls.RJButton btn_reset;
    }
}