using System;
using System.Collections.Generic;
using System.Text;

namespace passwordHolder
{
    public class Password
    {
        private int count = 1;
        private int Id;
        public String Naam { set; get; }
        public String Wachtwoord { set; get; }

        public Password(String naam, String wachtwoord)
        {
            this.Naam = naam;
            this.Wachtwoord = wachtwoord;
            this.Id = count;
            count++;
        }
    }
}
