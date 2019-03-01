using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Textando
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void Soma(object sender, System.EventArgs e)
        {
            int resultado = 0;

            resultado = Int32.Parse(campo1.Text) + Int32.Parse(campo2.Text);
            campo3.Text = resultado.ToString();

        }
    }
}
