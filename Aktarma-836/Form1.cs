using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aktarma_836
{
	public partial class Form1 : Form
	{
        double miktar = 200.0;
        public Form1()
		{
			InitializeComponent();
            lblMiktar.Text = miktar.ToString();
        }

		private void btnOde_Click(object sender, EventArgs e)
		{


			if (cbOgrenci.Checked == true)
			{
				if (rb1.Checked)
				{
                    miktar -= 8;
                }
				else if (rb2.Checked)
				{
                    miktar -= 6.20;
                }
				else if (rb3.Checked)
				{
                    miktar -= 4;
                }

				else if (rb4.Checked)
				{
                    miktar -= 7.50;
                }
            }


			else
			{
                if (rb1.Checked)
                {
                    miktar -= 15;
                }
                else if (rb2.Checked)
                {
                    miktar -= 12.20;
                }
                else if (rb3.Checked)
                {
                    miktar -= 8;
                }

                else if (rb4.Checked)
                {
                    miktar -= 9.60;
                }
            }
            lblMiktar.Text = miktar.ToString();

        }

        private void btnYukle_Click(object sender, EventArgs e)
        {
            if (rb50.Checked)
            {
                miktar += 50;
            }
            else if (rb100.Checked)
            {
                miktar += 100;
            }
            else if (rb150.Checked)
            {
                miktar += 150;
            }
            else if (rb200.Checked)
            {
                miktar += 200;
            }
            lblMiktar.Text = miktar.ToString();
        }
    }
}
