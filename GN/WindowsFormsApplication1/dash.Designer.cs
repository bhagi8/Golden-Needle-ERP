﻿namespace WindowsFormsApplication1
{
    partial class dash
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pay = new System.Windows.Forms.Button();
            this.sam = new System.Windows.Forms.Button();
            this.cl = new System.Windows.Forms.Button();
            this.ord = new System.Windows.Forms.Button();
            this.da = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.title = new System.Windows.Forms.Label();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.log_pnl = new System.Windows.Forms.Panel();
            this.grt_lbl = new System.Windows.Forms.Label();
            this.nm_lbl = new System.Windows.Forms.Label();
            this.profPic_pnl = new System.Windows.Forms.Panel();
            this.prof_pb = new System.Windows.Forms.PictureBox();
            this.time = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Button();
            this.sub_d = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            this.panel2.SuspendLayout();
            this.log_pnl.SuspendLayout();
            this.profPic_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prof_pb)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(51)))));
            this.panel1.Controls.Add(this.pay);
            this.panel1.Controls.Add(this.sam);
            this.panel1.Controls.Add(this.cl);
            this.panel1.Controls.Add(this.ord);
            this.panel1.Controls.Add(this.da);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(239, 510);
            this.panel1.TabIndex = 0;
            // 
            // pay
            // 
            this.pay.FlatAppearance.BorderSize = 0;
            this.pay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pay.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pay.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.pay.Image = global::WindowsFormsApplication1.Properties.Resources.cc;
            this.pay.Location = new System.Drawing.Point(0, 413);
            this.pay.Name = "pay";
            this.pay.Size = new System.Drawing.Size(239, 68);
            this.pay.TabIndex = 2;
            this.pay.Text = "Payments";
            this.pay.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.pay.UseVisualStyleBackColor = true;
            this.pay.Click += new System.EventHandler(this.pay_Click);
            this.pay.MouseLeave += new System.EventHandler(this.pay_MouseLeave);
            this.pay.MouseHover += new System.EventHandler(this.pay_MouseHover);
            // 
            // sam
            // 
            this.sam.FlatAppearance.BorderSize = 0;
            this.sam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sam.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sam.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.sam.Image = global::WindowsFormsApplication1.Properties.Resources.jacket;
            this.sam.Location = new System.Drawing.Point(0, 328);
            this.sam.Name = "sam";
            this.sam.Size = new System.Drawing.Size(239, 68);
            this.sam.TabIndex = 1;
            this.sam.Text = "Samples";
            this.sam.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.sam.UseVisualStyleBackColor = true;
            this.sam.MouseLeave += new System.EventHandler(this.sam_MouseLeave);
            this.sam.MouseHover += new System.EventHandler(this.sam_MouseHover);
            // 
            // cl
            // 
            this.cl.FlatAppearance.BorderSize = 0;
            this.cl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cl.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cl.Image = global::WindowsFormsApplication1.Properties.Resources.cp;
            this.cl.Location = new System.Drawing.Point(0, 254);
            this.cl.Name = "cl";
            this.cl.Size = new System.Drawing.Size(239, 68);
            this.cl.TabIndex = 1;
            this.cl.Text = "Clients";
            this.cl.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cl.UseVisualStyleBackColor = true;
            this.cl.Click += new System.EventHandler(this.cl_Click);
            this.cl.MouseLeave += new System.EventHandler(this.cl_MouseLeave);
            this.cl.MouseHover += new System.EventHandler(this.cl_MouseHover);
            // 
            // ord
            // 
            this.ord.FlatAppearance.BorderSize = 0;
            this.ord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ord.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ord.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ord.Image = global::WindowsFormsApplication1.Properties.Resources.list;
            this.ord.Location = new System.Drawing.Point(0, 180);
            this.ord.Name = "ord";
            this.ord.Size = new System.Drawing.Size(239, 68);
            this.ord.TabIndex = 1;
            this.ord.Text = "Orders";
            this.ord.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ord.UseVisualStyleBackColor = true;
            this.ord.Click += new System.EventHandler(this.ord_Click);
            this.ord.MouseLeave += new System.EventHandler(this.ord_MouseLeave);
            this.ord.MouseHover += new System.EventHandler(this.ord_MouseHover);
            // 
            // da
            // 
            this.da.FlatAppearance.BorderSize = 0;
            this.da.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.da.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.da.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.da.Image = global::WindowsFormsApplication1.Properties.Resources.db;
            this.da.Location = new System.Drawing.Point(0, 117);
            this.da.Name = "da";
            this.da.Size = new System.Drawing.Size(239, 57);
            this.da.TabIndex = 1;
            this.da.Text = "Dash Board";
            this.da.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.da.UseVisualStyleBackColor = true;
            this.da.Click += new System.EventHandler(this.da_Click);
            this.da.MouseLeave += new System.EventHandler(this.da_MouseLeave);
            this.da.MouseHover += new System.EventHandler(this.da_MouseHover);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(126)))), ((int)(((byte)(4)))));
            this.panel3.Controls.Add(this.title);
            this.panel3.Controls.Add(this.pb1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(239, 111);
            this.panel3.TabIndex = 0;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.title.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.title.Location = new System.Drawing.Point(65, 21);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(171, 56);
            this.title.TabIndex = 1;
            this.title.Text = " Golden Needle\r\nApparels (Pvt) Ltd.";
            // 
            // pb1
            // 
            this.pb1.Image = global::WindowsFormsApplication1.Properties.Resources.need;
            this.pb1.InitialImage = global::WindowsFormsApplication1.Properties.Resources.need;
            this.pb1.Location = new System.Drawing.Point(3, 21);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(60, 65);
            this.pb1.TabIndex = 0;
            this.pb1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.log_pnl);
            this.panel2.Controls.Add(this.sub_d);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(239, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(660, 111);
            this.panel2.TabIndex = 1;
            // 
            // log_pnl
            // 
            this.log_pnl.Controls.Add(this.grt_lbl);
            this.log_pnl.Controls.Add(this.nm_lbl);
            this.log_pnl.Controls.Add(this.profPic_pnl);
            this.log_pnl.Controls.Add(this.time);
            this.log_pnl.Controls.Add(this.close);
            this.log_pnl.Dock = System.Windows.Forms.DockStyle.Right;
            this.log_pnl.Location = new System.Drawing.Point(478, 0);
            this.log_pnl.Name = "log_pnl";
            this.log_pnl.Size = new System.Drawing.Size(182, 111);
            this.log_pnl.TabIndex = 2;
            // 
            // grt_lbl
            // 
            this.grt_lbl.Font = new System.Drawing.Font("Segoe UI Semilight", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grt_lbl.Location = new System.Drawing.Point(32, 17);
            this.grt_lbl.Name = "grt_lbl";
            this.grt_lbl.Size = new System.Drawing.Size(53, 44);
            this.grt_lbl.TabIndex = 4;
            this.grt_lbl.Text = "Hi";
            this.grt_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nm_lbl
            // 
            this.nm_lbl.AutoSize = true;
            this.nm_lbl.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nm_lbl.Location = new System.Drawing.Point(30, 61);
            this.nm_lbl.Name = "nm_lbl";
            this.nm_lbl.Size = new System.Drawing.Size(57, 25);
            this.nm_lbl.TabIndex = 3;
            this.nm_lbl.Text = "name";
            this.nm_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nm_lbl.DoubleClick += new System.EventHandler(this.nm_lbl_DoubleClick);
            // 
            // profPic_pnl
            // 
            this.profPic_pnl.BackColor = System.Drawing.Color.White;
            this.profPic_pnl.Controls.Add(this.prof_pb);
            this.profPic_pnl.Location = new System.Drawing.Point(93, 25);
            this.profPic_pnl.Name = "profPic_pnl";
            this.profPic_pnl.Size = new System.Drawing.Size(77, 67);
            this.profPic_pnl.TabIndex = 2;
            // 
            // prof_pb
            // 
            this.prof_pb.BackColor = System.Drawing.Color.Black;
            this.prof_pb.Location = new System.Drawing.Point(3, 0);
            this.prof_pb.Name = "prof_pb";
            this.prof_pb.Size = new System.Drawing.Size(74, 67);
            this.prof_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.prof_pb.TabIndex = 3;
            this.prof_pb.TabStop = false;
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.time.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.Location = new System.Drawing.Point(53, 95);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(29, 13);
            this.time.TabIndex = 2;
            this.time.Text = "time";
            // 
            // close
            // 
            this.close.FlatAppearance.BorderSize = 0;
            this.close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.Location = new System.Drawing.Point(153, 1);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(32, 23);
            this.close.TabIndex = 0;
            this.close.Text = "X";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            this.close.MouseLeave += new System.EventHandler(this.close_MouseLeave);
            this.close.MouseHover += new System.EventHandler(this.close_MouseHover);
            // 
            // sub_d
            // 
            this.sub_d.AutoSize = true;
            this.sub_d.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sub_d.Location = new System.Drawing.Point(4, 87);
            this.sub_d.Name = "sub_d";
            this.sub_d.Size = new System.Drawing.Size(89, 21);
            this.sub_d.TabIndex = 1;
            this.sub_d.Text = "Dash Board";
            this.sub_d.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // cartesianChart1
            // 
            this.cartesianChart1.Location = new System.Drawing.Point(290, 153);
            this.cartesianChart1.Name = "cartesianChart1";
            this.cartesianChart1.Size = new System.Drawing.Size(456, 251);
            this.cartesianChart1.TabIndex = 2;
            this.cartesianChart1.Text = "Monthly Orders";
            this.cartesianChart1.ChildChanged += new System.EventHandler<System.Windows.Forms.Integration.ChildChangedEventArgs>(this.cartesianChart1_ChildChanged);
            // 
            // dash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(899, 510);
            this.Controls.Add(this.cartesianChart1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "dash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.viewo_frm_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.log_pnl.ResumeLayout(false);
            this.log_pnl.PerformLayout();
            this.profPic_pnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.prof_pb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button da;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button sam;
        private System.Windows.Forms.Button cl;
        private System.Windows.Forms.Button ord;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.Label sub_d;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel log_pnl;
        private System.Windows.Forms.PictureBox prof_pb;
        private System.Windows.Forms.Panel profPic_pnl;
        private System.Windows.Forms.Label grt_lbl;
        private System.Windows.Forms.Label nm_lbl;
        private System.Windows.Forms.Button pay;
        private LiveCharts.WinForms.CartesianChart cartesianChart1;
    }
}
