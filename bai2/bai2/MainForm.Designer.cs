/*
 * Created by SharpDevelop.
 * User: HCM2
 * Date: 12/23/2018
 * Time: 2:51 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace bai2
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.tenho = new System.Windows.Forms.TextBox();
			this.diachi = new System.Windows.Forms.TextBox();
			this.namsinh = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rbnu = new System.Windows.Forms.RadioButton();
			this.rbnam = new System.Windows.Forms.RadioButton();
			this.show = new System.Windows.Forms.DataGrid();
			this.label5 = new System.Windows.Forms.Label();
			this.nganh = new System.Windows.Forms.TextBox();
			this.congviec = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.nhap = new System.Windows.Forms.Button();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.dulieu = new System.Windows.Forms.Button();
			this.bac = new System.Windows.Forms.TextBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.rbcongnhan = new System.Windows.Forms.RadioButton();
			this.rbkysu = new System.Windows.Forms.RadioButton();
			this.rbnhanvien = new System.Windows.Forms.RadioButton();
			this.tim = new System.Windows.Forms.Button();
			this.thoat = new System.Windows.Forms.Button();
			this.timkiem = new System.Windows.Forms.TextBox();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.show)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// tenho
			// 
			this.tenho.Location = new System.Drawing.Point(113, 12);
			this.tenho.Multiline = true;
			this.tenho.Name = "tenho";
			this.tenho.Size = new System.Drawing.Size(229, 29);
			this.tenho.TabIndex = 0;
			// 
			// diachi
			// 
			this.diachi.Location = new System.Drawing.Point(113, 140);
			this.diachi.Multiline = true;
			this.diachi.Name = "diachi";
			this.diachi.Size = new System.Drawing.Size(229, 25);
			this.diachi.TabIndex = 3;
			// 
			// namsinh
			// 
			this.namsinh.Location = new System.Drawing.Point(113, 56);
			this.namsinh.Multiline = true;
			this.namsinh.Name = "namsinh";
			this.namsinh.Size = new System.Drawing.Size(229, 25);
			this.namsinh.TabIndex = 4;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Lime;
			this.label1.ForeColor = System.Drawing.Color.Red;
			this.label1.Location = new System.Drawing.Point(7, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 29);
			this.label1.TabIndex = 5;
			this.label1.Text = "Name";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Lime;
			this.label2.ForeColor = System.Drawing.Color.Red;
			this.label2.Location = new System.Drawing.Point(7, 56);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 25);
			this.label2.TabIndex = 6;
			this.label2.Text = "YearOld";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Lime;
			this.label3.ForeColor = System.Drawing.Color.Red;
			this.label3.Location = new System.Drawing.Point(7, 98);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 24);
			this.label3.TabIndex = 7;
			this.label3.Text = "Sex";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Lime;
			this.label4.ForeColor = System.Drawing.Color.Red;
			this.label4.Location = new System.Drawing.Point(7, 140);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 25);
			this.label4.TabIndex = 8;
			this.label4.Text = "Adress";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.rbnu);
			this.groupBox1.Controls.Add(this.rbnam);
			this.groupBox1.Location = new System.Drawing.Point(113, 98);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(229, 29);
			this.groupBox1.TabIndex = 9;
			this.groupBox1.TabStop = false;
			// 
			// rbnu
			// 
			this.rbnu.Location = new System.Drawing.Point(111, 5);
			this.rbnu.Name = "rbnu";
			this.rbnu.Size = new System.Drawing.Size(118, 24);
			this.rbnu.TabIndex = 1;
			this.rbnu.TabStop = true;
			this.rbnu.Text = "girl";
			this.rbnu.UseVisualStyleBackColor = true;
			this.rbnu.CheckedChanged += new System.EventHandler(this.RbnuCheckedChanged);
			// 
			// rbnam
			// 
			this.rbnam.Location = new System.Drawing.Point(0, 5);
			this.rbnam.Name = "rbnam";
			this.rbnam.Size = new System.Drawing.Size(113, 24);
			this.rbnam.TabIndex = 0;
			this.rbnam.TabStop = true;
			this.rbnam.Text = "boy";
			this.rbnam.UseVisualStyleBackColor = true;
			this.rbnam.CheckedChanged += new System.EventHandler(this.RbnamCheckedChanged);
			// 
			// show
			// 
			this.show.DataMember = "";
			this.show.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.show.Location = new System.Drawing.Point(360, 75);
			this.show.Name = "show";
			this.show.Size = new System.Drawing.Size(320, 210);
			this.show.TabIndex = 10;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.Lime;
			this.label5.ForeColor = System.Drawing.Color.Red;
			this.label5.Location = new System.Drawing.Point(7, 273);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 12;
			this.label5.Text = "ranking";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// nganh
			// 
			this.nganh.Location = new System.Drawing.Point(113, 231);
			this.nganh.Multiline = true;
			this.nganh.Name = "nganh";
			this.nganh.Size = new System.Drawing.Size(124, 26);
			this.nganh.TabIndex = 13;
			// 
			// congviec
			// 
			this.congviec.Location = new System.Drawing.Point(113, 185);
			this.congviec.Multiline = true;
			this.congviec.Name = "congviec";
			this.congviec.Size = new System.Drawing.Size(124, 25);
			this.congviec.TabIndex = 14;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(0, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 23);
			this.label6.TabIndex = 0;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(0, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(100, 23);
			this.label7.TabIndex = 0;
			// 
			// nhap
			// 
			this.nhap.Location = new System.Drawing.Point(0, 0);
			this.nhap.Name = "nhap";
			this.nhap.Size = new System.Drawing.Size(75, 23);
			this.nhap.TabIndex = 0;
			// 
			// label8
			// 
			this.label8.BackColor = System.Drawing.Color.Lime;
			this.label8.ForeColor = System.Drawing.Color.Red;
			this.label8.Location = new System.Drawing.Point(7, 227);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(100, 26);
			this.label8.TabIndex = 15;
			this.label8.Text = "career";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label9
			// 
			this.label9.BackColor = System.Drawing.Color.Lime;
			this.label9.ForeColor = System.Drawing.Color.Red;
			this.label9.Location = new System.Drawing.Point(7, 185);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(100, 25);
			this.label9.TabIndex = 16;
			this.label9.Text = "job";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// dulieu
			// 
			this.dulieu.Location = new System.Drawing.Point(362, 40);
			this.dulieu.Name = "dulieu";
			this.dulieu.Size = new System.Drawing.Size(75, 29);
			this.dulieu.TabIndex = 17;
			this.dulieu.Text = "ADD";
			this.dulieu.UseVisualStyleBackColor = true;
			this.dulieu.Click += new System.EventHandler(this.DulieuClick);
			// 
			// bac
			// 
			this.bac.Location = new System.Drawing.Point(113, 275);
			this.bac.Multiline = true;
			this.bac.Name = "bac";
			this.bac.Size = new System.Drawing.Size(124, 25);
			this.bac.TabIndex = 18;
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.Color.Lime;
			this.groupBox2.Controls.Add(this.rbcongnhan);
			this.groupBox2.Controls.Add(this.rbkysu);
			this.groupBox2.Controls.Add(this.rbnhanvien);
			this.groupBox2.ForeColor = System.Drawing.Color.Yellow;
			this.groupBox2.Location = new System.Drawing.Point(243, 185);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(111, 115);
			this.groupBox2.TabIndex = 19;
			this.groupBox2.TabStop = false;
			// 
			// rbcongnhan
			// 
			this.rbcongnhan.ForeColor = System.Drawing.Color.Red;
			this.rbcongnhan.Location = new System.Drawing.Point(11, 74);
			this.rbcongnhan.Name = "rbcongnhan";
			this.rbcongnhan.Size = new System.Drawing.Size(66, 24);
			this.rbcongnhan.TabIndex = 2;
			this.rbcongnhan.TabStop = true;
			this.rbcongnhan.Text = "engineer";
			this.rbcongnhan.UseVisualStyleBackColor = true;
			this.rbcongnhan.CheckedChanged += new System.EventHandler(this.RbcongnhanCheckedChanged);
			// 
			// rbkysu
			// 
			this.rbkysu.ForeColor = System.Drawing.Color.Red;
			this.rbkysu.Location = new System.Drawing.Point(11, 44);
			this.rbkysu.Name = "rbkysu";
			this.rbkysu.Size = new System.Drawing.Size(81, 24);
			this.rbkysu.TabIndex = 1;
			this.rbkysu.TabStop = true;
			this.rbkysu.Text = "employees";
			this.rbkysu.UseVisualStyleBackColor = true;
			this.rbkysu.CheckedChanged += new System.EventHandler(this.RbkysuCheckedChanged);
			// 
			// rbnhanvien
			// 
			this.rbnhanvien.ForeColor = System.Drawing.Color.Red;
			this.rbnhanvien.Location = new System.Drawing.Point(11, 14);
			this.rbnhanvien.Name = "rbnhanvien";
			this.rbnhanvien.Size = new System.Drawing.Size(66, 24);
			this.rbnhanvien.TabIndex = 0;
			this.rbnhanvien.TabStop = true;
			this.rbnhanvien.Text = "worker";
			this.rbnhanvien.UseVisualStyleBackColor = true;
			this.rbnhanvien.CheckedChanged += new System.EventHandler(this.RadioButton1CheckedChanged);
			// 
			// tim
			// 
			this.tim.Location = new System.Drawing.Point(443, 40);
			this.tim.Name = "tim";
			this.tim.Size = new System.Drawing.Size(75, 29);
			this.tim.TabIndex = 21;
			this.tim.Text = "Find";
			this.tim.UseVisualStyleBackColor = true;
			this.tim.Click += new System.EventHandler(this.TimClick);
			// 
			// thoat
			// 
			this.thoat.Location = new System.Drawing.Point(605, 7);
			this.thoat.Name = "thoat";
			this.thoat.Size = new System.Drawing.Size(75, 29);
			this.thoat.TabIndex = 22;
			this.thoat.Text = "X";
			this.thoat.UseVisualStyleBackColor = true;
			this.thoat.Click += new System.EventHandler(this.ThoatClick);
			// 
			// timkiem
			// 
			this.timkiem.Location = new System.Drawing.Point(524, 40);
			this.timkiem.Multiline = true;
			this.timkiem.Name = "timkiem";
			this.timkiem.Size = new System.Drawing.Size(156, 29);
			this.timkiem.TabIndex = 23;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.ClientSize = new System.Drawing.Size(692, 323);
			this.Controls.Add(this.timkiem);
			this.Controls.Add(this.thoat);
			this.Controls.Add(this.tim);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.bac);
			this.Controls.Add(this.dulieu);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.congviec);
			this.Controls.Add(this.nganh);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.show);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.namsinh);
			this.Controls.Add(this.diachi);
			this.Controls.Add(this.tenho);
			this.Name = "MainForm";
			this.Text = "bai2";
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.show)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox timkiem;
		private System.Windows.Forms.Button thoat;
		private System.Windows.Forms.Button tim;
		private System.Windows.Forms.RadioButton rbnhanvien;
		private System.Windows.Forms.RadioButton rbkysu;
		private System.Windows.Forms.RadioButton rbcongnhan;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox bac;
		private System.Windows.Forms.Button dulieu;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button nhap;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox nganh;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.DataGrid show;
		private System.Windows.Forms.RadioButton rbnam;
		private System.Windows.Forms.RadioButton rbnu;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox namsinh;
		private System.Windows.Forms.TextBox diachi;
		private System.Windows.Forms.TextBox congviec;
		private System.Windows.Forms.TextBox tenho;
	}
}
