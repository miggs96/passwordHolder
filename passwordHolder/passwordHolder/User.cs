using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace passwordHolder
{
    public class User : ObservableCollection<Password>
    {
        private ObservableCollection<Password> wachtwoord = new ObservableCollection<Password>();
        
        public User()
        {
                
        }

        public ObservableCollection<Password> getPasswordList()
        {
            return wachtwoord;
        }

        public Password getPassword(String naam)
        {

            foreach (Password password in wachtwoord)
            {
                if(password.Naam == naam)
                {
                    return password;
                }
            }
            return null;
            //return wachtwoord.Where(x => x.Naam == naam);     
        }

        public bool setPassword(Password password)
        {
            int count = wachtwoord.Count;
            if (count == 0)
            {
                this.wachtwoord.Add(password);
                return true;
            }
            else
            {
                foreach (Password item in wachtwoord)
                {
                    if (item.Naam == password.Naam)
                    {
                        return false;
                    }
                    else
                    {
                        this.wachtwoord.Add(password);
                        return true;
                    }
                }
            }
            return false;
        }

        public void editPassword(String naam, String password)
        {
            Password edit = (Password)wachtwoord.Where(x => x.Naam == naam);
            edit.Wachtwoord = password;
        }

        public void deletePassword(String naam)
        {
            Password del = (Password)wachtwoord.Where(x => x.Naam == naam);
            wachtwoord.Remove(del);
        }
    }
}
