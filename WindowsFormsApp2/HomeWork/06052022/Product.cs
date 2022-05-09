using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.HomeWork._06052022
{
    [Serializable]
    public class Product
    {
        public int Id{ get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string  CategoryName { get; set; }

    }
}
