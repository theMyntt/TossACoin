using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TossaCoin
{
    public partial class MainPage : ContentPage
    {
        public String index;
        public MainPage()
        {
            InitializeComponent();
            picker.SelectedIndex = 0;
        }
        private void tossACoin(Object sender, EventArgs e)
        {
            Random rand = new Random();

            if (rand.Next(0, 3) == 1)
            {
                result.Text = ((String)picker.SelectedItem == "Cara") ? "Você venceu!" : "Você perdeu!";
                coin.Source = ImageSource.FromUri(new Uri("https://images.tcdn.com.br/img/img_prod/1083822/1_real_2a_familia_fc_1673_1_30e390b3f0e4d72f51dea93dd4b52002.png"));
            }
            else
            { 
                result.Text = ((String)picker.SelectedItem == "Coroa") ? "Você venceu!" : "Você perdeu!";
                coin.Source = ImageSource.FromUri(new Uri("https://numismaticacoan.com/wp-content/uploads/2017/07/2014-3.jpg"));
            }
        }
    }
}
