using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_ex6._1
{
    internal class Book
    {
        public int Id { get; set; }
        public string Title {  get; set; }
        public string Authur { get; set; }
        public string Publisher { get; set; }
        public int Year { get; set; }
        public double Price { get; set; }
        public string Author { get; internal set; }
    }
}
