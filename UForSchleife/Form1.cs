using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UForSchleife
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnSchleife1_Click(object sender, EventArgs e)
		{
			//lblAusgabe.Text = "";

			//for (double d = 35; d >= 20; d -= 2.5)
			//{
			//	lblAusgabe.Text += d.ToString() + "\n";
			//}

			lblAusgabe.Text = "";

			for (double i = 35; i >= 20; i -= 2.5)
			{
				lblAusgabe.Text += i.ToString() + "\n";
			}
		}
	}
}


