using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pet pet = new Pet();
            Animal[] variant = { new Dog(), new Cat() };
            foreach (var i in variant)
            {
                pet.Show(i);
                pet.Say(i);
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
    abstract class Animal
    {
        public abstract string Type { get; }
        public abstract void Say();

        public void ShowInfo()
        {
            Console.Write("Животное: {0} издает звук: ", Type);
        }
    }
    class Pet
    {
        public void Say (Animal animal)
        {
            animal.Say();
        }
        public void Show (Animal animal)
        {
            animal.ShowInfo();
        }
    }
    class Dog: Animal
    {
       public override string Type { get { return "'Собачка'"; } }
        public override void Say()
        {
            Console.WriteLine("Гав-Гав, рррр");
        }
    }
    class Cat : Animal
    {
        public override string Type { get { return "'Кошечка'"; } }
        public override void Say()
        {
            Console.WriteLine("Мяу-мяу, муррр");
        }
    }





}

//// Разработать абстрактный класс Animal, который описывает животное. Класс содержит следующие элементы:

//абстрактное свойство - название животного.
//В классе Animal нужно определить следующие методы:

//конструктор, устанавливающий значение по умолчанию для названия;
//абстрактный метод Say(), который выводит звук, который издает животное;
//неабстрактный метод ShowInfo(), который выводит на консоль последовательно название, а затем звук (вызывая метод Say()).
//Разработать классы Cat и Dog, которые реализуют абстрактный класс Animal. В классах реализовать следующие элементы:

//свойство – название животного;
//метод Say(), выводящий на экран «Мяу» либо «Гав» соответственно.
//Создайте экземпляры классов Cat и Dog и проверьте их работоспособность.


