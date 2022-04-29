using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3.SerializedElements
{
    [Serializable]
    public abstract class Animal
    {
        private string name;
        private string color;
        private int age;
        public string Color { get => color; set => color = value; }
        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public abstract string Sound();

    }
}
