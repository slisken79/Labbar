using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Labb4;

namespace Labb6
{
    class SUV
    {

        private string _type;

        internal string Color { get; set; }
        internal int NumberOfGears { get; set; }
        internal string Type
        {
            get
            {
                return this._type;
            }
            set
            {
                if (value.ToLower() == "SUV")
                    this._type = value;
            }
        }

        internal string OrginalType { get; private set; }

        internal SUV(string color, int numberOfGears, string type = "SUV")
        {
            this.Color = color;
            this.NumberOfGears = numberOfGears;
            this.Type = type;
        }

        public override string ToString()
        {
            return $"Color: {Color}, Gears: {NumberOfGears}, Type {Type}, Org Type if casted form car: {OrginalType}";
        }

        public static explicit operator SUV(Car car)
        {
            return new SUV(car.Color, car.NumberOfGears, "SUV") { OrginalType = car.Type };
        }
    }
}
