using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace OOP_3.SerializedElements
{
    [Serializable]
    public class Cat: Animal
    {
        public Cat()
        {

        }
        public Cat(SerializationInfo info, StreamingContext context)
        {
            Name = (string)info.GetValue("name", typeof(string));
            Age = (int)info.GetValue("age", typeof(int));
            Color = (string)info.GetValue("color", typeof(string));
        }
        public override string Sound()
        {
            return "Meow";
        }
    }
}
