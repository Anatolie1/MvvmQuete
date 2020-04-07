using System;
using System.Collections.Generic;

namespace MvvmQuete
{
    public class ShopViewModel
    {
        public List<Shop> Shops { get; set; } = new List<Shop>();

        public ShopViewModel()
        {
            IList<Shop> shopsList = new List<Shop>
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
            Shops.AddRange(shopsList);
        }        
    }
}