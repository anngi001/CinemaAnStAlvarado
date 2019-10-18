using product.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CinemaAStAlvarado.views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CinemaDetailxaml : ContentPage
    {
        public CinemaDetailxaml(Product product)
        {
            InitializeComponent();
            LoadData(product);
        }

        private void LoadData(Product contact)
        {
            Datos.BindingContext = contact;
        }
    }
}