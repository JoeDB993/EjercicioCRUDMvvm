using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using EjercicioCRUDMvvm.Models;
using EjercicioCRUDMvvm.Services;
using System.Collections.ObjectModel;

namespace EjercicioCRUDMvvm.ViewModels
{
    public partial class ProveedorViewModel : ObservableObject
    {
        private readonly ProveedorService _proveedorService;

        public ObservableCollection<Proveedor> Proveedores { get; set; } = new ObservableCollection<Proveedor>();

        [ObservableProperty]
        private string nombre;

        [ObservableProperty]
        private string producto;

        [ObservableProperty]
        private string descripcion;

        [ObservableProperty]
        private decimal precio;

        [ObservableProperty]
        private string telefono;

        public ProveedorViewModel(ProveedorService proveedorService)
        {
            _proveedorService = proveedorService;
        }

        [RelayCommand]
        public async Task AddProveedor()
        {
            var proveedor = new Proveedor
            {
                Nombre = Nombre,
                Producto = Producto,
                Descripcion = Descripcion,
                Precio = Precio,
                Telefono = Telefono
            };

            await _proveedorService.AddProveedor(proveedor);
            Proveedores.Add(proveedor);

            LimpiarCampos();
        }

        [RelayCommand]
        public async Task LoadProveedores()
        {
            var proveedores = await _proveedorService.GetProveedores();
            Proveedores.Clear();
            foreach (var proveedor in proveedores)
            {
                Proveedores.Add(proveedor);
            }
        }

        private void LimpiarCampos()
        {
            Nombre = string.Empty;
            Producto = string.Empty;
            Descripcion = string.Empty;
            Precio = 0;
            Telefono = string.Empty;
        }
    }
}

