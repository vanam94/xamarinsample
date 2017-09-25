using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace sample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();

        }

        private void interactionButton_Clicked(object sender, EventArgs e)
        {
            int result = Convert.ToInt32(firstNumberEntry.Text) + Convert.ToInt32(secondNumberEntry.Text);
            resultLabel.Text = result.ToString();

        }
    }
}