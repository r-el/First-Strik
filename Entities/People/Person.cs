using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstStrike
{
    public class Person
    {
        public string Name { get; set; }
        public bool IsAlive { get; set; }

            public Person(string name, bool isAlive = true)
            {
                Name = name;
                IsAlive = isAlive;
            }
        public override string ToString()
        {
            return $"Name: {Name}, IsAlive: {IsAlive}";
        }
    }
}

