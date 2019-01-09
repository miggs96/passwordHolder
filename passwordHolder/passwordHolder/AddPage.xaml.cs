using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace passwordHolder
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AddPage : ContentPage
	{
        private User myUser;

		public AddPage (User user)
		{
            myUser = user;
			InitializeComponent ();
		}

        async void AddPassword(object sender, EventArgs e)
        {
            String Naam = FilledInName.Text;
            String NewPassword = FilledInPassword.Text;

            if (Naam != null && NewPassword != null)
            {
                Password add = new Password(Naam, NewPassword);

                if (myUser.setPassword(add))
                {
                    await DisplayAlert("Succes", "Your password has been added.", "OK");
                    await Navigation.PopAsync();
                }
                //Error if already exists.
                else
                {
                    await DisplayAlert("Alert", "This name is already in use. Try another one.", "OK");
                }
            }
            //Error if fields are empty.
            else
            {
                await DisplayAlert("Alert", "One of both fields are empty. Try again.", "OK");
            }
        }
    }
}