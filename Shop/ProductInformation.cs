using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    public struct Product
    {
        public int ID;
        public string Name;
        public int Price;
        public Image Image;
        public string Type;
        public string Brand;
    }

    class ProductInformation
    {
        public static string[] Brands = { "Roshen", "Milka", "Shokopack", "Ferrero", "Gullon" };
        public static string[] TypeOfProducts = { "Цукерки", "Печиво", "Шоколад", "Батончики"};

        public static Product[] Products;
    }
}
