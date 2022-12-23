using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 找零程式設計
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            int[] m = new int[6] { 500, 100, 50, 10, 5, 1 };
            int[] r = new int[6];

            int purchase = Convert.ToInt16( txtPurchase.Text );
            int payment = Convert.ToInt16( txtPayment.Text );

            payment = payment - purchase;

            for( int i=0; i<m.Length; i++ )
            {
                r[i] = payment / m[i];
                payment = payment % m[i];
            }

            labelResult.Text = "";

            for (int i = 0; i < m.Length; i++)
            {
                labelResult.Text += m[i] + " 元 x " + r[ i ] + "    ";
            }
        }
    }
}
