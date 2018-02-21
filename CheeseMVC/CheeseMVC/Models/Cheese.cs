using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CheeseMVC.Models
{
    public class Cheese
    {
        public string Name { get; set; }
        public string Description { get; set; }

        //blueprint for new Cheese obj w/a name and description
        public Cheese(string name, string description)
        {
            Name = name;
            Description = description;
        }

    }
}
