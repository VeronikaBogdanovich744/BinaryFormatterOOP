using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using OOP_3.SerializedElements;


namespace OOP_3.Serializer
{
    class BinaryFormatter
    {

		public static byte[] Serialize(List<Animal> objects)
        {
			string result = "";
			foreach (var obj in objects)
            {
				result+=SerializeObject(obj);
				result += "/";
			}
			result = result.Remove(result.Length - 1, 1);
			var bytes = Encoding.UTF8.GetBytes(result);
			return bytes;
		}

		public static string SerializeObject(object obj)
        {
			string result="";
			Type objectType = obj.GetType();
			result += $"{objectType.FullName}";

			var fields = getFields(objectType);
			foreach (var field in fields)
            {
				result += $":{field.Name}:{field.GetValue(obj)}";
            }
			return result;
        }

		public static List<Animal> Deserialize(byte[] objects)
        {
			var binString = System.Text.Encoding.Default.GetString(objects);
			string[] elements = binString.Split('/');
			var animals = new List<Animal>();
			foreach(var element in elements)
            {
				
				string[] stringFields = element.Split(':');
				Type elementType = Type.GetType(stringFields[0], false, true);
				Animal animal = (Animal)Activator.CreateInstance(elementType);

				Dictionary<string, string> tokens = new Dictionary<string, string>();
				for (int i = 1; i < stringFields.Length; i+=2)
                {
					tokens.Add(stringFields[i], stringFields[i + 1]);
				}
				var fields = getFields(elementType);
				foreach (var f in fields)
				{
					if (f.FieldType.Equals(typeof(string)))
					{
						f.SetValue(animal, tokens[f.Name]);
					}
					else
					{
						f.SetValue(animal, int.Parse(tokens[f.Name]));
					}
				}
				animals.Add(animal);

			}
			return animals;
		}

		private static FieldInfo[] getFields(Type type)
        {
			List<FieldInfo> listOfFields = new List<FieldInfo>();
			do
			{
				FieldInfo[] infos = type.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
				listOfFields.AddRange(infos);
				type = type.BaseType;

			} while (type != null);
			FieldInfo[] fields = listOfFields.ToArray();
			return fields;
		}



	}


}
