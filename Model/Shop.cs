using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Input;

namespace MvvmQuete
{
    public class Shop : INotifyPropertyChanged
    {
        private int shopId;
        private string name;
        private string country;

        public int ShopId
        {
            get
            {
                return shopId;
            }
            set
            {
                shopId = value;
                OnPropertyChanged("ShopId");
            }
        }
        public string ShopName
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
                OnPropertyChanged("ShopName");
            }
        }
       
        public string Country
        {
            get
            {
                return country;
            }
            set
            {
                country = value;
                OnPropertyChanged("Country");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
