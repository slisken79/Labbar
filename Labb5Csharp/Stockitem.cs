using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb5
{
    public class Stockitem
    {
        internal int id;
        internal string name;
        public static int stockCount = 0;

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                if (value >= 0)
                    id = value;
                else
                    throw new Exception("Must be a positive number");
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                if (value != null)
                    name = value;
                else
                    throw new ArgumentNullException();
            }
        }

        public static int StockCount
        {
            get
            {
                return stockCount;
            }

        }
        public Stockitem(int id, string name)
        {
            Id = id;
            Name = name;
            stockCount++;
        }
        public override string ToString()
        {
            return $"Name: {Name}, ID: {Id}, StockCount: {StockCount}";
        }
    }
}
