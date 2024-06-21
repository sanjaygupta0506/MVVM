using Keysight.Ccl.Wsl.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace MainApplication.WPF_MVVM._4._Design_Pattern.Abstract
{
    /// <summary>
    /// Interaction logic for AbstractFactory.xaml
    /// </summary>
    public partial class AbstractFactory : WslDialog
    {
        public AbstractFactory()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Animal animal = null;
            AnimalFactory animalFactory = null;
            string speakSound = null;

            // Create the Sea Factory object by passing the factory type as Sea
            animalFactory = AnimalFactory.CreateAnimalFactory("Sea");
            textBox1.Text = ("Animal Factory type : " + animalFactory.GetType().Name);
            //Console.WriteLine();

            // Get Octopus Animal object by passing the animal type as Octopus
            animal = animalFactory.GetAnimal("Octopus");
            textBox2.Text = ("Animal Type : " + animal.GetType().Name);

            speakSound = animal.speak();
            textBox3.Text = (animal.GetType().Name + " Speak : " + speakSound);
            //Console.WriteLine();
            //Console.WriteLine("--------------------------");

            // Create Land Factory object by passing the factory type as Land
            animalFactory = AnimalFactory.CreateAnimalFactory("Land");
            textBox4.Text = ("Animal Factory type : " + animalFactory.GetType().Name);
            //Console.WriteLine();

            // Get Lion Animal object by passing the animal type as Lion
            animal = animalFactory.GetAnimal("Lion");
            textBox5.Text = ("Animal Type : " + animal.GetType().Name);
            speakSound = animal.speak();
            textBox6.Text = (animal.GetType().Name + " Speak : " + speakSound);
            //Console.WriteLine();

            // Get Cat Animal object by passing the animal type as Cat
            animal = animalFactory.GetAnimal("Cat");
            textBox7.Text = ("Animal Type : " + animal.GetType().Name);
            speakSound = animal.speak();
            textBox8.Text = (animal.GetType().Name + " Speak : " + speakSound);
            //Console.Read();
        
    }
    }
}
