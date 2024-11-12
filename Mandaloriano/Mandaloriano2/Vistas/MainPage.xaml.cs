using Mandaloriano2.Models;

namespace Mandaloriano2.Vistas;


public partial class MainPage : ContentPage
{
    

    public MainPage()
    {
        InitializeComponent();
        BindingContext = new MisionesVM();
    }

}
