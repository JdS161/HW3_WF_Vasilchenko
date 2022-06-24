using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3_WF_Vasilchenko
{
    public class Goods
    {
        string name;
        string country;
        double price;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Country
        {
            get { return country; }
            set { country = value; }
        }
        public double Price
        {
            get { return price; }
            set
            {
                if (price < 0) throw new Exception("Price can't be negative!");
                else price = value;
            }
        }

        public Goods()
        {
            Name = null;
            Country = null;
            Price = 0;
        }
        public Goods(string _name, string _country, double _price)
        {
            Name = _name;
            Country = _country;
            Price = _price;
        }

        public override string ToString()
        {
            return $"{Name} Country : {Country}, Price : {Price}";
        }
    }
}
