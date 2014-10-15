using System;
using System.Collections.Generic;
using Xamarin.Forms;
using System.ComponentModel;
using System.Linq;

namespace RestaurantPicker
{
    public class RestaurantPickerViewModel : INotifyPropertyChanged
    {
        private Random random;

        public RestaurantPickerViewModel()
        {
            random = new Random();
            Options = new List<Restaurant>()
            {
                    new Restaurant(){Name = "Huggys", ImagePath="Huggys.png"},
                    new Restaurant(){Name = "Pizza Hut", ImagePath="PizzaHut.png"},
                    new Restaurant(){Name = "Five Guys", ImagePath="5Guys.png"},
                    new Restaurant(){Name = "Qdoba", ImagePath="Qdoba.png"},
            };
                        RandomCommand = new Command(() => OnExecute());
        }

        private Restaurant selected;
        public Restaurant Selected 
        {
            get { return selected; }
            set 
            {
                if (selected == value)
                    return;
                selected = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Selected"));
            }
        }

        public IEnumerable<Restaurant> Options {get;set;}

        public Command RandomCommand {get;set;}

        private void OnExecute()
        {
            while (true)
            {
                var pick = Options.ElementAt(random.Next(0, Options.Count()));
                if (Selected != pick)
                {
                    Selected = pick;
                    break;
                }
            }
        }

        #region INotifyPropertyChanged implementation

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion
    }
}

