using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace appsCLI
{
    internal class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        public Category(int id, string name)
        {
            CategoryId = id;
            CategoryName = name;
        }
    }
}
