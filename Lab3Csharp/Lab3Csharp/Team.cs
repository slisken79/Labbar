using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Csharp
{
   public class Team
    {
        string name, country, sport;
        int numberOfFans;

        public string GetSport()
        {
            return sport;
        }
        public void SetSport(string sport)
        {
            this.sport = sport;
        }

        public string GetName()
      {
            return name;
      }
        public void SetName(string name)
        {
            this.name = name;
        }
        public string GetCountry()
        {
            return country;
        }
        public void SetCountry(string country)
        {
            this.country = country;
        }
        public int GetNumberOfFans()
        {
            return numberOfFans;
        }
        public void SetNumberOfFans(int numberOfFans)
        {
            this.numberOfFans = numberOfFans;
        }
    }
    
}
