using System;
using System.Collections;
using System.Collections.Generic;

namespace AnimalManagement
{
    public class Test
    {
        public int count = 0;
        Hashtable AnimalList = new Hashtable();
        public void AddCat()
        {
            Cat myCat = new Cat();
            myCat.ID = count;
            Console.Write("Entre name Cat: ");
            myCat.Name = Console.ReadLine();
            Console.Write("Enter age Cat: ");
            myCat.Age = int.Parse(Console.ReadLine());
            AnimalList.Add(count, myCat);
            count++;
        }

        public void AddFish()
        {
            Fish myFish = new Fish();
            myFish.ID = count;
            Console.Write("Enter name Fish: ");
            myFish.Name = Console.ReadLine();
            Console.Write("Enter age Fish: ");
            myFish.Age = int.Parse(Console.ReadLine());
            AnimalList.Add(count, myFish);
            count++;
        }

        public void AddCrocodile()
        {
            Crocodile myCrocodile = new Crocodile();
            myCrocodile.ID = count;
            Console.Write("Enter name Crocodile: ");
            myCrocodile.Name = Console.ReadLine();
            Console.Write("Enter age Crocodile: ");
            myCrocodile.Age = int.Parse(Console.ReadLine());
            AnimalList.Add(count, myCrocodile);
            count++;
        }

        public void ViewTerrestrialAnimal()
        {
            Cat cat = new Cat();
            for (int i = 0; i < AnimalList.Count; i++)
            {
                if (AnimalList[i].GetType() == cat.GetType())
                {
                    AnimalList[i].ToString();
                    cat.Move();
                }
            }
        }

        public void ViewMarineAnimal()
        {
            Fish fish = new Fish();
            for (int i = 0; i < AnimalList.Count; i++)
            {
                if (AnimalList[i].GetType() == fish.GetType())
                {
                    AnimalList[i].ToString();
                    fish.Move();
                }
            }
        }

        public void ViewAllAnimal()
        {
            foreach (DictionaryEntry de in AnimalList)
            {
                Console.WriteLine(de.Value);
            }
        }

        public void DeletaAnimal()
        {
            Console.WriteLine("Enter select a Key: ");
            int n = int.Parse(Console.ReadLine());
            foreach (DictionaryEntry de in AnimalList)
            {
                if (de.Key.Equals(n))
                {
                    AnimalList.Remove(n);
                    break;
                }
            }
            Console.WriteLine(AnimalList.Count);
        }
    }
}