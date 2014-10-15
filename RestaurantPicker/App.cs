using System;
using Xamarin.Forms;

namespace RestaurantPicker
{
    public class App
    {
        public static Page GetMainPage()
        {	
            return new RestaurantPickerView(new RestaurantPickerViewModel());
                   }
    }
}

