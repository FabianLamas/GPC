using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using MockGPC.Models;
using MockGPC.Views;
using MockGPC.ViewModels;

namespace MockGPC.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class ItemsPage : ContentPage
    {
        //ItemsViewModel viewModel;
        List<string> itemsList = new List<string>();
        public ItemsPage()
        {
            InitializeComponent();

            //BindingContext = viewModel = new ItemsViewModel();
            System.Diagnostics.Debug.WriteLine("entro en el items page");
        }

        //async void OnItemSelected(object sender, EventArgs args)
        //{
        //    var layout = (BindableObject)sender;
        //    var item = (Item)layout.BindingContext;
        //    await Navigation.PushAsync(new ItemDetailPage(new ItemDetailViewModel(item)));
        //}

        //async void AddItem_Clicked(object sender, EventArgs e)
        //{
        //    await Navigation.PushModalAsync(new NavigationPage(new NewItemPage()));
        //}

        //protected override void OnAppearing()
        //{
        //    base.OnAppearing();

        //    if (viewModel.Items.Count == 0)
        //        viewModel.IsBusy = true;
        //}

        
        void btn1_Clicked(System.Object sender, System.EventArgs e)
        {
            //itemsList.Clear();
            //itemsList.Add("Cliente1");
            //itemsList.Add("Cliente2");
            //itemsList.Add("Cliente3");
            //itemsList.Add("Cliente4");
            //itemsList.Add("Cliente5");
            //itemsList.Add("Cliente6");
            Navigation.PushAsync(new ListPage());
        }

        void btn2_Clicked(object sender, EventArgs e)
        {
            //itemsList.Clear();
            //itemsList.Add("Empleado1");
            //itemsList.Add("Empleado2");
            //itemsList.Add("Empleado3");
            //itemsList.Add("Empleado4");
            //itemsList.Add("Empleado5");
            //itemsList.Add("Empleado6");
            Navigation.PushAsync(new ListPage());
        }

        void btn3_Clicked(object sender, EventArgs e)
        {
            //Navigation.PushAsync(new ListPage("Section 3"));
        }

        void btn4_Clicked(object sender, EventArgs e)
        {
            //Navigation.PushAsync(new ListPage("Section 4"));
        }

        void btn5_Clicked(object sender, EventArgs e)
        {
            //Navigation.PushAsync(new ListPage("Section 5"));
        }

        void Button_Clicked(object sender, EventArgs e)
        {
            //Navigation.PushAsync(new ListPage("Section 6"));
        }
    }
}