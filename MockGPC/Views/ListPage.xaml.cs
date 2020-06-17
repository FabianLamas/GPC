using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using MockGPC.Models;
using MockGPC.ViewModels;
using Xamarin.Forms;

namespace MockGPC.Views
{
    public partial class ListPage : ContentPage
    {
        ItemsViewModel viewModel;
        public ObservableCollection<ListItem> ListItems { get; set; }

        public ListPage()
        {
            ListItems = new ObservableCollection<ListItem>();
            ListItems.Add(new ListItem { Id = 1, Image = "imgLogo", Text = "Cliente 1", Details = null });
            ListItems.Add(new ListItem { Id = 1, Image = "imgLogo", Text = "Cliente 2", Details = null });
            ListItems.Add(new ListItem { Id = 1, Image = "imgLogo", Text = "Cliente 3", Details = null });
            ListItems.Add(new ListItem { Id = 1, Image = "imgLogo", Text = "Cliente 4", Details = null });
            ListItems.Add(new ListItem { Id = 1, Image = "imgLogo", Text = "Cliente 5", Details = null });
            ListItems.Add(new ListItem { Id = 1, Image = "imgLogo", Text = "Cliente 6", Details = null });
            ListItems.Add(new ListItem { Id = 1, Image = "imgLogo", Text = "Cliente 7", Details = null });
            InitializeComponent();

            
            BindingContext = viewModel = new ItemsViewModel();

            
        }

        async void OnItemSelected(object sender, EventArgs args)
        {
            var layout = (BindableObject)sender;
            var item = (Item)layout.BindingContext;
            await Navigation.PushAsync(new ItemDetailPage(new ItemDetailViewModel(item)));
        }

        async void AddItem_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new NewItemPage()));
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (viewModel.Items.Count == 0)
                viewModel.IsBusy = true;
        }

        
    }
}
