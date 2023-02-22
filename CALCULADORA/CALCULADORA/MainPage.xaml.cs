using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CALCULADORA
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            pkOper.Items.Add("SUMA");
            pkOper.Items.Add("RESTA");
            pkOper.Items.Add("MULTIPLICACION");
            pkOper.Items.Add("DIVISION");
        }

        private void pkOper_SelectedIndexChanged(object sender, EventArgs e)
        {
            String op = pkOper.SelectedItem.ToString();
            int n1 = Int32.Parse(Txtnumero1.Text);
            int n2 = Int32.Parse(Txtnumero2.Text);
            double res = 0;

            if (op == "SUMA")
                res = n1 + n2;
            else if (op == "RESTA")
                res = n1 - n2;
            else if (op == "MULTIPLICACION")
                res = n1 * n2;
            else if (op == "DIVISION")
                res = n1 / n2;

            Lblres.Text = res + "";

        }
    }
}
