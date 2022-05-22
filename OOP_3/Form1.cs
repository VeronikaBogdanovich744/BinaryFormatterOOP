using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OOP_3.SerializedElements;
using System.Reflection;
using System.IO;
using System.Runtime.Serialization;
using OOP_3.Serializer;
//using System.Runtime.Serialization.Formatters.Binary;

namespace OOP_3
{
    public partial class Form1 : Form
    {
        List<Animal> animalList = new List<Animal>();
        IEnumerable<Type> animalTypes;
        public Form1()
        {
            InitializeComponent();
            animalTypes = typeof(Animal).Assembly.ExportedTypes.Where(t => typeof(Animal).IsAssignableFrom(t) && t != typeof(Animal));

           
            animalTypes.ToList().ForEach(t => chooseAnimal.Items.Add(t.Name));
        }

        private void Create_Click(object sender, EventArgs e)
        {
            if (AnimalList.Items.Contains(txtbName.Text))
            {
                return;
            }

            string fullNameOfType = "OOP_3.SerializedElements." + chooseAnimal.SelectedItem;
            Type AnimalType = Type.GetType(fullNameOfType, false, true);

            System.Reflection.ConstructorInfo ci = AnimalType.GetConstructor(new Type[] { });
            Animal animal = (Animal)ci.Invoke(new object[] { });

            animal.Name = txtbName.Text;
            animal.Age = Int32.Parse(txtbAge.Text); 
            animal.Color = txtbColor.Text;

            animalList.Add(animal);
            AnimalList.Items.Add(animal.Name);

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            foreach (var item in animalList)
            {
                if (AnimalList.SelectedItem.ToString() == item.Name)
                {
                    animalList.Remove(item);
                    AnimalList.Items.RemoveAt(AnimalList.Items.IndexOf(item.Name));
                    return;
                }
            }
        }

        private void ShowInformation(object sender, EventArgs e)
        {
            foreach (var item in animalList)
            {
                if (AnimalList.SelectedItem.ToString() == item.Name)
                {
                    chooseAnimal.SelectedItem = item.GetType().Name;
                    txtbName.Text = item.Name;
                    txtbAge.Text=item.Age.ToString();
                    txtbColor.Text = item.Color;
                    return;
                }
            }
        }

        protected byte[] m_Buffer;
        private void Serialize_Click(object sender, EventArgs e)
        {
            using (FileStream fileStream = new FileStream("data.bin", FileMode.Create))
            {
                m_Buffer = BinaryFormatter.Serialize(animalList);
                fileStream.Write(m_Buffer,0,m_Buffer.Length);
                animalList.Clear();
                AnimalList.Items.Clear();

            }
        }

        private void Deserialize_Click(object sender, EventArgs e)
        {
            using (FileStream fileStream = new FileStream("data.bin", FileMode.OpenOrCreate))
            {
                byte[] bytes = new byte[fileStream.Length];
                fileStream.Read(bytes, 0, bytes.Length);
                animalList = BinaryFormatter.Deserialize(bytes);
                 
                foreach (var item in animalList)
                 {
                     AnimalList.Items.Add(item.Name);
                 }

            }
        }
    }
}
