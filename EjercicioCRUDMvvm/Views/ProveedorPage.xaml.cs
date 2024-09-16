using EjercicioCRUDMvvm.Services;
using EjercicioCRUDMvvm.ViewModels;


namespace EjercicioCRUDMvvm.Views
{
    public partial class ProveedorPage : ContentPage
    {
        public ProveedorPage()
        {
            InitializeComponent();
            BindingContext = new ProveedorViewModel(new ProveedorService());
        }
    }
}