using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodTypeZadatak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FoodType foodType = new FoodType("banana", 4, 93, 3);
            Food food = new Food(foodType, 110);
            Console.WriteLine("protein: " + food.getProtein() + "\ncarbs: " +
            food.getCarbs() + "\nfat: " + food.getFat());

            Console.ReadKey();
        }
    }

    public class FoodType
    {
        private string name;
        private int protein, carbs, fat;
        private static int counter = 0;

        public override string ToString()
        {
            return name + ": p - " + protein + "%, c - " + carbs + "%, f - " + fat + "%";
        }

        public FoodType(string name, int protein, int carbs, int fat)
        {
            FoodType.counter++;
            this.name = name;
            this.protein = protein;
            this.carbs = carbs;
            this.fat = fat;
        }

        public string Name { get => name; set => name = value; }
        public int Protein { get => protein; set => protein = value; }
        public int Carbs { get => carbs; set => carbs = value; }
        public int Fat { get => fat; set => fat = value; }

        public static int getNumberOfCreatedInstances()
        {
            return counter;
        }

    }

    public class Food
    {
        private FoodType type;
        private int weight;

        public Food(FoodType type, int weight)
        {
            this.Type = type;
            this.Weight = weight;
        }

        public FoodType Type { get => type; set => type = value; }
        public int Weight { get => weight; set => weight = value; }

        public override string ToString()
        {
            return type.ToString() + ", w - " + weight + "g";
        }

        public double getProtein()
        {
            return weight * (type.Protein/100.0);
        }

        public double getCarbs()
        {
            return weight * (type.Carbs/100.0);
        }

        public double getFat()
        {
            return weight * (type.Fat/100.0);
        }

        public string toStringInGrams()
        {
            return type.Name + ": p - " + getProtein() +"g, c - " + getCarbs() +"g, f - " + getFat() + "g, w - " + weight + "g";
        }
    }
}
