﻿using SQLite;
using CommunityToolkit.Mvvm.ComponentModel;

namespace EjercicioCRUDMvvm.Models
{
    public class Proveedor
    public partial class Proveedor : ObservableObject
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Producto { get; set; }

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
    }
}


