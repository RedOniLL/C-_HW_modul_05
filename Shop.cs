using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__HW_modul_05
{
    public class Shop
    {
        public string name;
        public int area;

        public Shop(int area_) { area = area_; }

        public static Shop operator +(Shop Shop, int numEmployees)
        {
            Shop.area += numEmployees;
            return Shop;
        }

        public static Shop operator -(Shop Shop, int numEmployees)
        {
            Shop.area = numEmployees;
            return Shop;
        }

        public static bool operator ==(Shop Shop1, Shop Shop2)
        {
            return Shop1.area == Shop2.area;
        }

        public static bool operator !=(Shop Shop1, Shop Shop2)
        {
            return !(Shop1 == Shop2);
        }

        public static bool operator <(Shop Shop1, Shop Shop2)
        {
            return Shop1.area < Shop2.area;
        }

        public static bool operator >(Shop Shop1, Shop Shop2)
        {
            return Shop1.area > Shop2.area;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            Shop other = (Shop)obj;
            return area == other.area;
        }
    }
}
