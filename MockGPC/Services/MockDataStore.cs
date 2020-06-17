using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MockGPC.Models;

namespace MockGPC.Services
{
    public class MockDataStore : IDataStore<Item>
    {
        readonly List<Item> items;
        readonly List<Item> empleados;
        readonly List<Item> proyectos;
        readonly List<Item> clientes;

        public MockDataStore()
        {
            items = new List<Item>()
            {
                new Item { Id = Guid.NewGuid().ToString(), Text = "First item", Description="This is an item description." },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Second item", Description="This is an item description." },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Third item", Description="This is an item description." },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Fourth item", Description="This is an item description." },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Fifth item", Description="This is an item description." },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Sixth item", Description="This is an item description." }
            };

            empleados = new List<Item>()
            {
                new Item { Id = Guid.NewGuid().ToString(), Text = "empleado1", Description="This is an item description.", Image = "imagLogo"  },
                new Item { Id = Guid.NewGuid().ToString(), Text = "empleado2", Description="This is an item description.", Image = "imagLogo"  },
                new Item { Id = Guid.NewGuid().ToString(), Text = "empleado3", Description="This is an item description.", Image = "imagLogo"  },
                new Item { Id = Guid.NewGuid().ToString(), Text = "empleado4", Description="This is an item description.", Image = "imagLogo"  },
            };

            proyectos = new List<Item>()
            {
                new Item { Id = Guid.NewGuid().ToString(), Text = "empleado1", Description="This is an item description.", Image = "imagLogo"  },
                new Item { Id = Guid.NewGuid().ToString(), Text = "proyecto2", Description="This is an item description.", Image = "imagLogo"  },
                new Item { Id = Guid.NewGuid().ToString(), Text = "proyecto3", Description="This is an item description.", Image = "imagLogo"  },
                new Item { Id = Guid.NewGuid().ToString(), Text = "proyecto4", Description="This is an item description.", Image = "imagLogo"  },
            };

            clientes = new List<Item>()
            {
                new Item { Id = Guid.NewGuid().ToString(), Text = "cliente1", Description="This is an item description.", Image = "imagLogo"  },
                new Item { Id = Guid.NewGuid().ToString(), Text = "cliente2", Description="This is an item description.", Image = "imagLogo"  },
                new Item { Id = Guid.NewGuid().ToString(), Text = "cliente3", Description="This is an item description.", Image = "imagLogo"  },
                new Item { Id = Guid.NewGuid().ToString(), Text = "cliente4", Description="This is an item description.", Image = "imagLogo"  },
            };


        }

        public async Task<bool> AddItemAsync(Item item)
        {
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(Item item)
        {
            var oldItem = items.Where((Item arg) => arg.Id == item.Id).FirstOrDefault();
            items.Remove(oldItem);
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var oldItem = items.Where((Item arg) => arg.Id == id).FirstOrDefault();
            items.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<Item> GetItemAsync(string id)
        {
            return await Task.FromResult(items.FirstOrDefault(s => s.Id == id));
        }

        public async Task<Item> GetEmpleadoAsync(string id)
        {
            return await Task.FromResult(empleados.FirstOrDefault(s => s.Id == id));
        }

        public async Task<Item> GetProyectoAsync(string id)
        {
            return await Task.FromResult(proyectos.FirstOrDefault(s => s.Id == id));
        }

        public async Task<Item> GetClienteAsync(string id)
        {
            return await Task.FromResult(clientes.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<Item>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(items);
        }

        public async Task<IEnumerable<Item>> GetClientesAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(clientes);
        }

        public async Task<IEnumerable<Item>> GetEmpleadosAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(empleados);
        }

        public async Task<IEnumerable<Item>> GetPoyectosAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(proyectos);
        }
    }
}