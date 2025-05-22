using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstStrike
{
    public class Person
    {
        protected string Name { get; set; }
        protected bool IsAlive { get; set; }

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

