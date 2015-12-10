using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Csharp
{
      class Person
    {
        string name, lagName;
        Team team;
        public void SetTeam(Team team)
        {
            this.team = team;
        }
        public Team GetTeam()
        {
            return team;
        }
        
        public void SetName(string name)
        {
            this.name = name;
        }
        public string GetName()
        {
            return name;
        }
        public object GetLag()
        {
            return team;
        }
        public void SetLag(object lagName)
        {
            this.lagName = lagName.ToString();
        }
    }
}
