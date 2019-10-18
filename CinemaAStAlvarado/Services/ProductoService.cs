
using CinemaAStAlvarado.helpers;
using product.Domain;
using System.Collections.Generic;

using Xamarin.Forms;

namespace CinemaAStAlvarado.Services
{
    public static class ProductoService
    {
        public static List<Product> GetProducts()
        {
            var products = ApiHelper.Get<ResponseProducts>("/api/Cartelera");
            return products.products;
        }
    }
}