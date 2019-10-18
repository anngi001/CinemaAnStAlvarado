
using CinemaAStAlvarado.Services;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CinemaAStAlvarado.views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Cinema : ContentPage
    {
        public Cinema()
        {
            InitializeComponent();

            lsContact.ItemsSource = ProductoService.GetProducts();

        }

        private void LsContact_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

        }
    }
}