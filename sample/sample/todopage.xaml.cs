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
	public partial class todopage : ContentPage
	{
        public List<string> todoItems { get; set; }
        public todopage()
        {
            InitializeComponent();
            this.todoItems = new List<string>();


        }
        private void addItemButton_Clicked(object sender,EventArgs e)
         {
            if (string.IsNullOrEmpty(newtodoItemEntry.Text))
            {
                DisplayAlert("Error", "please enter a value", "ok");
             }
            else
            {
                this.todoItems.Add(newtodoItemEntry.Text);
                todoList.ItemsSource = this.todoItems;
                newtodoItemEntry.Text = "";
            }
         }

       
        private void clearButton_Clicked(object sender, EventArgs e)
        {
            this.todoItems.Clear();
            todoList.ItemsSource = new List<string>();
        }

        private void returnButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }

}