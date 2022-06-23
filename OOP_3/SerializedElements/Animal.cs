using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3.SerializedElements
{
    [SerializedAttribute]
    public abstract class Animal: ISerializable
    {
       
        private string name;
        private string color;
        private int age;
        public string Color { get => color; set => color = value; }
        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public abstract string Sound();

         public void GetObjectData(SerializationInfo info, StreamingContext context)
         {
            info.AddValue("name", name, typeof(string));
            info.AddValue("color", color, typeof(string));
            info.AddValue("age", age, typeof(int));

        }


    }
}
