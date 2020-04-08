using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace MvvmQuete
{
    public class ShopViewModel
    {
        public ObservableCollection<Shop> Shops { get; set; }

        public ShopViewModel()
        {
            Shops = new ObservableCollection<Shop>
            {
                new Shop{ShopId=1,ShopName="MC",Country="FRANCE"},
                new Shop{ShopId=2,ShopName="AL",Country="USA"},
                new Shop{ShopId=3,ShopName="GE",Country="GERMANY"},
                new Shop{ShopId=4,ShopName="MI",Country="SPAIN"},
                new Shop{ShopId=5,ShopName="LC",Country="ITALY"},
                new Shop{ShopId=6,ShopName="VB",Country="RUSSIA"},
                new Shop{ShopId=7,ShopName="WX",Country="AUSTRALIA"},
                new Shop{ShopId=8,ShopName="AR",Country="INDIA"}
            };
        }
        public void AddShop(int ShopId, string ShopName, string Country)
        {
            Shops.Add(new Shop() { ShopId = ShopId, ShopName = ShopName, Country = Country });
        }
    }
}