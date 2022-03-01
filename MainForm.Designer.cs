/*
 * Created by SharpDevelop.
 * User: ACER
 * Date: 01/03/2022
 * Time: 15:32
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace TugasPV1Aplikasi
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label mas;
		private System.Windows.Forms.TextBox maskapai;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox perusahaan;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button generate;
		private System.Windows.Forms.TextBox jenis;
		private System.Windows.Forms.ListBox listbox;
		
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
			this.mas = new System.Windows.Forms.Label();
			this.maskapai = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.perusahaan = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.generate = new System.Windows.Forms.Button();
			this.jenis = new System.Windows.Forms.TextBox();
			this.listbox = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// mas
			// 
			this.mas.Location = new System.Drawing.Point(67, 47);
			this.mas.Name = "mas";
			this.mas.Size = new System.Drawing.Size(94, 19);
			this.mas.TabIndex = 0;
			this.mas.Text = "Maskapai :";
			// 
			// maskapai
			// 
			this.maskapai.Location = new System.Drawing.Point(189, 47);
			this.maskapai.Name = "maskapai";
			this.maskapai.Size = new System.Drawing.Size(230, 26);
			this.maskapai.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(41, 100);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(120, 25);
			this.label1.TabIndex = 2;
			this.label1.Text = "Perusahaan   :";
			// 
			// perusahaan
			// 
			this.perusahaan.Location = new System.Drawing.Point(189, 100);
			this.perusahaan.Name = "perusahaan";
			this.perusahaan.Size = new System.Drawing.Size(230, 26);
			this.perusahaan.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(27, 148);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(134, 23);
			this.label2.TabIndex = 4;
			this.label2.Text = "Jenis Pesawat  :";
			// 
			// generate
			// 
			this.generate.Location = new System.Drawing.Point(205, 195);
			this.generate.Name = "generate";
			this.generate.Size = new System.Drawing.Size(103, 45);
			this.generate.TabIndex = 6;
			this.generate.Text = "Generate";
			this.generate.UseVisualStyleBackColor = true;
			this.generate.Click += new System.EventHandler(this.GenerateClick);
			// 
			// jenis
			// 
			this.jenis.Location = new System.Drawing.Point(189, 148);
			this.jenis.Name = "jenis";
			this.jenis.Size = new System.Drawing.Size(230, 26);
			this.jenis.TabIndex = 7;
			// 
			// listbox
			// 
			this.listbox.FormattingEnabled = true;
			this.listbox.ItemHeight = 20;
			this.listbox.Location = new System.Drawing.Point(27, 303);
			this.listbox.Name = "listbox";
			this.listbox.Size = new System.Drawing.Size(688, 244);
			this.listbox.TabIndex = 8;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(739, 565);
			this.Controls.Add(this.listbox);
			this.Controls.Add(this.jenis);
			this.Controls.Add(this.generate);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.perusahaan);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.maskapai);
			this.Controls.Add(this.mas);
			this.Name = "MainForm";
			this.Text = "TugasPV1Aplikasi";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
