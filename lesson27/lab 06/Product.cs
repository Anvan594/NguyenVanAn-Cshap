using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_06
{
    internal class Product
    {
        string name;
        double cost;
        int onhand;
        //constructor
        public Product(String n, double c, int h) 
        { 
            name = n; 
            cost = c; 
            onhand = h; 
        }
        //ghi de phuong thuc
        public override string ToString()
        {
            return String.Format("{0,-10}Cost: {1,6:C} On hand:{2}", name, cost, onhand);
        }
    }
}
