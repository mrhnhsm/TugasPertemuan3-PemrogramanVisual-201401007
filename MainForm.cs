/*
 * Created by SharpDevelop.
 * User: ACER
 * Date: 01/03/2022
 * Time: 15:32
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace TugasPV1Aplikasi
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void GenerateClick(object sender, EventArgs e)
		{
			string maskap=maskapai.Text;
			string perus=perusahaan.Text;
			string jen=jenis.Text;
			string batas= "  ||  ";
			
			listbox.Items.Add(maskap+batas+perus+batas+jen);
			
			maskapai.Clear();
			perusahaan.Clear();
			jenis.Clear();
			
		}
	}
}
