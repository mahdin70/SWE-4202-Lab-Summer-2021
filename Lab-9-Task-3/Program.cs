using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_9_Task_3
{
    class Animal
    {
        private string Name;
        private string HabitatArea;
        private string Sound;
        private int Weight;
        private int Height;

        public string getName() { return Name; }
        public string getHabitatArea() { return HabitatArea; }
        public string getSound() { return Sound; }
        public int getHeight() { return Height; }
        public int getWeight() { return Weight; }
        public void setName(string Name) { this.Name = Name; }
        public void setHabitatArea(string Area) { this.HabitatArea = Area; }
        public void setSound(string Sound) { this.Sound = Sound; }
        public void setWeight(int Weight) { this.Weight = Weight; }
        public void setHeight(int Height) { this.Height = Height; }

        public Animal(string Name, string HabitatArea, string Sound, int Weight, int Height)
        {
            this.Name = Name;
            this.HabitatArea = HabitatArea;
            this.Sound = Sound;
            this.Weight = Weight;
            this.Height = Height;
        }


        public string getInfo()
        {
            return getName() + " " + getHabitatArea() + " " + getWeight() + " " + getHeight();
        }
        public void changeWeight(int pounds)
        {
            Weight = pounds;
        }
        public virtual void vocalize()
        {
            Console.WriteLine("");
            Console.ReadLine();
        }
    }
    class Cow : Animal
    {

        public Cow(string Name, string HabitatArea, string Sound, int Weight, int Height) : base(Name, HabitatArea, Sound, Weight, Height)
        {

        }
        public override void vocalize()
        {
            Console.WriteLine("Moo");
        }
    }
    class Cat : Animal
    {
        public Cat(string Name, string HabitatArea, string Sound, int Weight, int Height) : base(Name, HabitatArea, Sound, Weight, Height)
        {

        }
        public override void vocalize()
        {
            Console.WriteLine("Meow");
        }
    }
    class Chicken : Animal
    {


        public Chicken(string Name, string HabitatArea, string Sound, int Weight, int Height) : base(Name, HabitatArea, Sound, Weight, Height)
        {

        }
        public override void vocalize()
        {
            Console.WriteLine("Buck Buck");
        }
    }

    static void Main(string[] args)
    {
        Cat cat = new Cat();
        cat.vocalize();
        Cow cow = new Cow();
        cow.vocalize();
        Chicken chicken = new Chicken();
        chicken.vocalize();
    }

}
