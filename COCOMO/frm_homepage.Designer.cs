
namespace COCOMO
{
    partial class frm_homepage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_homepage));
            this.pnl_menu = new System.Windows.Forms.Panel();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_manual = new System.Windows.Forms.Button();
            this.btn_cocomo2 = new System.Windows.Forms.Button();
            this.btn_cocomo1 = new System.Windows.Forms.Button();
            this.pnl_logo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_main = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnl_menu.SuspendLayout();
            this.pnl_logo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_menu
            // 
            this.pnl_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.pnl_menu.Controls.Add(this.btn_exit);
            this.pnl_menu.Controls.Add(this.btn_manual);
            this.pnl_menu.Controls.Add(this.btn_cocomo2);
            this.pnl_menu.Controls.Add(this.btn_cocomo1);
            this.pnl_menu.Controls.Add(this.pnl_logo);
            this.pnl_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_menu.Location = new System.Drawing.Point(0, 0);
            this.pnl_menu.Name = "pnl_menu";
            this.pnl_menu.Size = new System.Drawing.Size(226, 715);
            this.pnl_menu.TabIndex = 0;
            // 
            // btn_exit
            // 
            this.btn_exit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_exit.FlatAppearance.BorderSize = 0;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_exit.Image = ((System.Drawing.Image)(resources.GetObject("btn_exit.Image")));
            this.btn_exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_exit.Location = new System.Drawing.Point(0, 655);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btn_exit.Size = new System.Drawing.Size(226, 60);
            this.btn_exit.TabIndex = 5;
            this.btn_exit.Text = "    Exit";
            this.btn_exit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_exit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_manual
            // 
            this.btn_manual.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_manual.FlatAppearance.BorderSize = 0;
            this.btn_manual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_manual.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_manual.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_manual.Image = global::COCOMO.Properties.Resources.manual;
            this.btn_manual.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_manual.Location = new System.Drawing.Point(0, 200);
            this.btn_manual.Name = "btn_manual";
            this.btn_manual.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btn_manual.Size = new System.Drawing.Size(226, 60);
            this.btn_manual.TabIndex = 4;
            this.btn_manual.Text = "  Manual";
            this.btn_manual.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_manual.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_manual.UseVisualStyleBackColor = true;
            this.btn_manual.Click += new System.EventHandler(this.btn_manual_Click);
            // 
            // btn_cocomo2
            // 
            this.btn_cocomo2.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_cocomo2.FlatAppearance.BorderSize = 0;
            this.btn_cocomo2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cocomo2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cocomo2.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_cocomo2.Image = global::COCOMO.Properties.Resources.pi;
            this.btn_cocomo2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cocomo2.Location = new System.Drawing.Point(0, 140);
            this.btn_cocomo2.Name = "btn_cocomo2";
            this.btn_cocomo2.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btn_cocomo2.Size = new System.Drawing.Size(226, 60);
            this.btn_cocomo2.TabIndex = 3;
            this.btn_cocomo2.Text = "   Cocomo II";
            this.btn_cocomo2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cocomo2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_cocomo2.UseVisualStyleBackColor = true;
            this.btn_cocomo2.Click += new System.EventHandler(this.btn_cocomo2_Click);
            // 
            // btn_cocomo1
            // 
            this.btn_cocomo1.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_cocomo1.FlatAppearance.BorderSize = 0;
            this.btn_cocomo1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cocomo1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cocomo1.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_cocomo1.Image = ((System.Drawing.Image)(resources.GetObject("btn_cocomo1.Image")));
            this.btn_cocomo1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cocomo1.Location = new System.Drawing.Point(0, 80);
            this.btn_cocomo1.Name = "btn_cocomo1";
            this.btn_cocomo1.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btn_cocomo1.Size = new System.Drawing.Size(226, 60);
            this.btn_cocomo1.TabIndex = 2;
            this.btn_cocomo1.Text = "    Cocomo I";
            this.btn_cocomo1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cocomo1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_cocomo1.UseVisualStyleBackColor = true;
            this.btn_cocomo1.Click += new System.EventHandler(this.btn_cocomo1_Click);
            // 
            // pnl_logo
            // 
            this.pnl_logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.pnl_logo.Controls.Add(this.label1);
            this.pnl_logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_logo.Location = new System.Drawing.Point(0, 0);
            this.pnl_logo.Name = "pnl_logo";
            this.pnl_logo.Size = new System.Drawing.Size(226, 80);
            this.pnl_logo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "COCOMO";
            // 
            // pnl_main
            // 
            this.pnl_main.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnl_main.Location = new System.Drawing.Point(226, 80);
            this.pnl_main.Name = "pnl_main";
            this.pnl_main.Size = new System.Drawing.Size(784, 635);
            this.pnl_main.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel1.Location = new System.Drawing.Point(226, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 80);
            this.panel1.TabIndex = 2;
            // 
            // frm_homepage
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1010, 715);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_main);
            this.Controls.Add(this.pnl_menu);
            this.MaximizeBox = false;
            this.Name = "frm_homepage";
            this.Text = "COCOMO Tool";
            this.Load += new System.EventHandler(this.frm_homepage_Load);
            this.pnl_menu.ResumeLayout(false);
            this.pnl_logo.ResumeLayout(false);
            this.pnl_logo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_menu;
        private System.Windows.Forms.Button btn_cocomo1;
        private System.Windows.Forms.Panel pnl_logo;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_manual;
        private System.Windows.Forms.Button btn_cocomo2;
        private System.Windows.Forms.Panel pnl_main;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}