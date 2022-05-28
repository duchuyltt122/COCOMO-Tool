namespace COCOMO
{
    partial class frm_mainn
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_cocomo2 = new System.Windows.Forms.Button();
            this.btn_cocomo1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btn_cocomo2);
            this.panel1.Controls.Add(this.btn_cocomo1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(572, 189);
            this.panel1.TabIndex = 0;
            // 
            // btn_cocomo2
            // 
            this.btn_cocomo2.Location = new System.Drawing.Point(343, 83);
            this.btn_cocomo2.Name = "btn_cocomo2";
            this.btn_cocomo2.Size = new System.Drawing.Size(125, 50);
            this.btn_cocomo2.TabIndex = 2;
            this.btn_cocomo2.Text = "COCOMO II";
            this.btn_cocomo2.UseVisualStyleBackColor = true;
            this.btn_cocomo2.Click += new System.EventHandler(this.btn_cocomo2_Click);
            // 
            // btn_cocomo1
            // 
            this.btn_cocomo1.Location = new System.Drawing.Point(84, 83);
            this.btn_cocomo1.Name = "btn_cocomo1";
            this.btn_cocomo1.Size = new System.Drawing.Size(127, 50);
            this.btn_cocomo1.TabIndex = 1;
            this.btn_cocomo1.Text = "COCOMO I";
            this.btn_cocomo1.UseVisualStyleBackColor = true;
            this.btn_cocomo1.Click += new System.EventHandler(this.btn_cocomo1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumBlue;
            this.label1.Location = new System.Drawing.Point(97, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "COCOMO CALCULATOR";
            // 
            // frm_mainn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(572, 189);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "frm_mainn";
            this.Text = "COCOMO Calculator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_mainn_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_cocomo2;
        private System.Windows.Forms.Button btn_cocomo1;
        private System.Windows.Forms.Label label1;
    }
}