using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuledGear
{
    public class Rule
    {
        public string Name { get; protected set; } = string.Empty;

        public Rule()
        {
        }

        public Rule(string name)
        {
            if(name == null || name.Length == 0) 
            {
                throw new ArgumentException("name"); 
            }
            Name = name;
        }
    }
}
