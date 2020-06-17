using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;

using Xamarin.Forms;

using MockGPC.Models;
using MockGPC.Views;

namespace MockGPC.ViewModels
{
    public class ItemsViewModel : BaseViewModel
    {
        public ObservableCollection<Item> Items { get; set; }
        public ObservableCollection<Item> Empleados { get; set; }
        public ObservableCollection<Item> Clientes { get; set; }
        public ObservableCollection<Item> Proyectos { get; set; }
        public Command LoadItemsCommand { get; set; }

        public ItemsViewModel()
        {
           // Title = "Home";
            Items = new ObservableCollection<Item>();
            Empleados = new ObservableCollection<Item>();
            Clientes = new ObservableCollection<Item>();
            Proyectos = new ObservableCollection<Item>();
            LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());

            MessagingCenter.Subscribe<NewItemPage, Item>(this, "AddItem", async (obj, item) =>
            {
                var newItem = item as Item;
                Items.Add(newItem);
                await DataStore.AddItemAsync(newItem);
            });
        }

        async Task ExecuteLoadItemsCommand()
        {
            IsBusy = true;

            try
            {
                Items.Clear();
                var items = await DataStore.GetItemsAsync(true);
                foreach (var item in items)
                {
                    Items.Add(item);
                }

                Empleados.Clear();
                var empleados = await DataStore.GetEmpleadosAsync(true);
                foreach (var item in empleados)
                {
                    Empleados.Add(item);
                }

                Proyectos.Clear();
                var proyectos = await DataStore.GetPoyectosAsync(true);
                foreach (var item in proyectos)
                {
                    Proyectos.Add(item);
                }

                Clientes.Clear();
                var clientes = await DataStore.GetClientesAsync(true);
                foreach (var item in clientes)
                {
                    Clientes.Add(item);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}