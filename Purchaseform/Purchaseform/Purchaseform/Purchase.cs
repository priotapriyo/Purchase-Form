using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Purchaseform
{
    public partial class Purchase : Form
    {
        public Purchase(string user, string id)
        {
            InitializeComponent();
            cusname.Text = user;
            cusid.Text = id;
            cusname.ReadOnly = true;
            cusid.ReadOnly = true;
            

        }

        


        private void button1_Click(object sender, EventArgs e)
        {

            //String.IsNullOrEmpty(textBox1.Text)
            double u1, u2, u3, u4, u5;
            int am1, am2, am3, am4, am5;
            if (String.IsNullOrEmpty(up1.Text) || String.IsNullOrEmpty(up2.Text) || String.IsNullOrEmpty(up3.Text) || String.IsNullOrEmpty(up4.Text) || String.IsNullOrEmpty(up5.Text) || String.IsNullOrEmpty(a1.Text) || String.IsNullOrEmpty(a2.Text) || String.IsNullOrEmpty(a3.Text) || String.IsNullOrEmpty(a4.Text) || String.IsNullOrEmpty(a5.Text) )
            {
                MessageBox.Show("Fill up The Information First");

            }
            else
            {
                u1 = Convert.ToDouble(up1.Text);
                u2 = Convert.ToDouble(up2.Text);
                u3 = Convert.ToDouble(up3.Text);
                u4 = Convert.ToDouble(up4.Text);
                u5 = Convert.ToDouble(up5.Text);

                

                am1 = Convert.ToInt32(a1.Text);
                am2 = Convert.ToInt32(a2.Text);
                am3 = Convert.ToInt32(a3.Text);
                am4 = Convert.ToInt32(a4.Text);
                am5 = Convert.ToInt32(a5.Text);



                var price = new double[] { u1, u2, u3, u4, u5 };
                var amount = new int[] { am1, am2, am3, am4, am5 };

                int priceex = 0, amountex = 0;


                double final = 0;

                for (int i = 0; i < price.Length; i++)
                {
                    final = final + price[i] * amount[i];
                }
                double finaltax;
                if (final <= 1000)
                {
                    finaltax = final;
                }
                else if (final > 1000 && final < 2000)
                {
                    finaltax = final + ((final * 5) / 100);
                }
                else if (final > 2000 && final < 3500)
                {
                    finaltax = final + ((final * 10) / 100);
                }
                else
                {
                    finaltax = final + ((final * 15) / 100);
                }

                foreach (var one in amount)
                {
                    if (!(one <= 10 && one >= 1))
                    {
                        MessageBox.Show("amount shouldn't be more than 10");
                        amountex++;
                        break;
                    }
                }
                foreach (var one in price)
                {
                    if (!(one <= 100 && one >= 1))
                    {
                        MessageBox.Show("price shouldn't be more than 100");
                        priceex++;
                        break;
                    }
                }


                if (!(amountex == 1 || priceex == 1))
                {
                    string totaltex = Convert.ToString(finaltax);

                    total.Text = totaltex;
                }
            }


            

            



        }
    }
}
