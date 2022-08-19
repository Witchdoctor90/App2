using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace App2
{
    public partial class MainPage : ContentPage
    {
        private int index = -1;
        private string[] labels = new string[]
        {
            "please i want eat",
            "why r u skipping that labels",
            "buy for just $0 now"
        };

        public MainPage()
        {
            InitializeComponent();
        }

        public async void Button_Clicked(object sender, EventArgs e)
        {
            if (index < labels.Length - 1)
            {
                index++;
                LabelDown.Text = labels[index];
            }
            else
            {
                index = -1;
                Subscribepanel.IsVisible = true;
                await Subscribepanel.FadeTo(1, 1250);
            }
        }
        
    }
}
