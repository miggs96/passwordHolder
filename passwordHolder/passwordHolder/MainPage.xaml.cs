using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace passwordHolder
{

    public partial class MainPage : ContentPage
	{
        
        User user = new User();

        public MainPage()
		{
			InitializeComponent();

            //test data
            Password Facebook = new Password("Facebook", "Test123");
            Password Instagram = new Password("Instagram", "welkom01");
            Password Snapchat = new Password("Snapchat", "Kechslayer9000");
            Password MijnDuo = new Password("MijnDuo", "DigiDApp");

            user.setPassword(Facebook);
            user.setPassword(Instagram);
            user.setPassword(Snapchat);
            user.setPassword(MijnDuo);
     
            
            //set the list of passwords in the Listview.
            passwordContent.ItemsSource = user.getPasswordList(); 
            
        }

        async public void NewPassword(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddPage(user));            
        }

        /**
         * Delete a item from passwordList and the listview.
         **/
        async public void ItemDelete(object sender, EventArgs e)
        {
            if(passwordContent.SelectedItem != null)
            {
                var awnser = await DisplayAlert("Warning", "Are you sure you want to delete this password?", "Yes", "No");

                if (awnser)
                {
                    //Get the selected password object.
                    var del = (Password)passwordContent.SelectedItem;
                    user.deletePassword(del.Naam);

                    
                    //Het deleten van het object moet hier nog...
                }
            }
        }

        /**
         * Edit a item from passwordList and the listview.
         **/
        public void ItemEdit(object sender, EventArgs e)
        {
            if (passwordContent.SelectedItem != null)
            {
                //code...
            }
        }
    }
}
