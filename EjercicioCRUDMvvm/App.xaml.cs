﻿using EjercicioCRUDMvvm.Views;

namespace EjercicioCRUDMvvm
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new ProveedorPage());
        }
    }
}