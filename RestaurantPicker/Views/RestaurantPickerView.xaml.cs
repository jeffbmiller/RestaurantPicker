using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace RestaurantPicker
{	
	public partial class RestaurantPickerView : ContentPage
	{	
        public RestaurantPickerView (RestaurantPickerViewModel viewModel)
		{
			InitializeComponent ();
            BindingContext = viewModel;
		}
	}
}

