using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb6
{
    struct MyDoubleType
    {
        private double doubleValue;


        public double DoubleValue
        {
            get { return doubleValue; }
            private set { doubleValue = value; }
        }

        public MyDoubleType(double doubleValue)
        {
            this.doubleValue = doubleValue;
        }

        public override string ToString() => this.doubleValue.ToString();

        public static MyDoubleType operator +(MyDoubleType myDouble, MyDoubleType mySecoundDouble)
        {
            return new MyDoubleType() { DoubleValue = myDouble.doubleValue + mySecoundDouble.doubleValue };
        }

        public static MyDoubleType operator +(MyDoubleType myDouble, double d)
        {
            return new MyDoubleType() { DoubleValue = myDouble.doubleValue + d };
        }

        public static double operator +(double value, MyDoubleType myDouble)
        {
            return  myDouble.doubleValue + value;
        }

        public static MyDoubleType operator -(MyDoubleType myDouble, double d)
        {
            return new MyDoubleType() { DoubleValue = myDouble.doubleValue - d };
        }

        public static MyDoubleType operator /(MyDoubleType myDouble, double d)
        {
            return new MyDoubleType() { DoubleValue = myDouble.doubleValue / d };
        }

        public static MyDoubleType operator *(MyDoubleType myDouble, double d)
        {
            return new MyDoubleType() { DoubleValue = myDouble.doubleValue * d };
        }

        public static bool operator ==(MyDoubleType myDouble, MyDoubleType mySecoundDouble)
        {
            return (myDouble.doubleValue == mySecoundDouble.doubleValue);
        }

        public static bool operator !=(MyDoubleType myDouble, MyDoubleType mySecoundDouble)
        {
            return !(myDouble.doubleValue == mySecoundDouble.doubleValue);
        }

        public static bool operator <(MyDoubleType myDouble, MyDoubleType mySecoundDouble)
        {
            return (myDouble.doubleValue < mySecoundDouble.doubleValue);
        }

        public static bool operator >(MyDoubleType myDouble, MyDoubleType mySecoundDouble)
        {
            return (myDouble.doubleValue > mySecoundDouble.doubleValue);
        }

        public static bool operator <=(MyDoubleType myDouble, MyDoubleType mySecoundDouble)
        {
            return (myDouble.doubleValue <= mySecoundDouble.doubleValue);
        }

        public static bool operator >=(MyDoubleType myDouble, MyDoubleType mySecoundDouble)
        {
            return (myDouble.doubleValue >= mySecoundDouble.doubleValue);
        }
    }
}
