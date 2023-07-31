namespace Interfaces_lab7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Lion lion = new Lion("Mufasa");
            lion.Eat();
            lion.Sound();
            lion.GiveBirth();
            lion.Sleep();
            lion.Color = "Yellow";
            lion.Move();
            Console.WriteLine($"Lion's color: {lion.Color}");
            Console.WriteLine($"Lion's Habitat: {lion.Habitat}");


            Eagle eagle = new Eagle("Baldy");
            eagle.Eat();
            eagle.Sound();
            eagle.Fly();
            /*eagle.Color = "Brown";
            Console.WriteLine($"Eagle's color: {eagle.Color}");*/



            Snake snake = new Snake("Slimy");
            snake.Eat();
            snake.Sound();
            snake.ShedSkin();
            snake.Color = "red";
            Console.WriteLine($"Snake's color: {snake.Color}");


            Dolphin dolphin = new Dolphin("Finny");
            dolphin.Eat();
            dolphin.Sound();
            dolphin.GiveBirth();
           dolphin.Color = "Gray";
            Console.WriteLine($"Dolphin's color: {dolphin.Color}");


            Elephant elephant = new Elephant("Trump");
            elephant.Eat();
            elephant.Sound();
            elephant.GiveBirth();
            elephant.Color="Blue";
             Console.WriteLine($"Elephant's color: {elephant.Color}");

            Bat bat = new Bat("Bruce");
            bat.Eat();
            bat.Sound();
            bat.GiveBirth();
            bat.Color = "brown-greyish";
            Console.WriteLine($"Bat's color: {bat.Color}");


        }


    }

    // This is the abstract class: Animal
    public abstract class Animal
    {
        public string Name { get; set; }
        public abstract void Eat();
        public abstract void Sound();

        public virtual void Sleep()
        {
            Console.WriteLine("Animal is sleeping.");
        }

        public virtual void Move()
        {
            Console.WriteLine("Animal is moving!");
        }

        public virtual string Color { get; set; }

        public virtual string Habitat
        {
            get { return "Unknown"; }
            set { Console.WriteLine("Setting habitat of Animal"); }
        }
    }

    // Abstract class: Mammal
    public abstract class Mammal : Animal
    {
        public abstract void GiveBirth();
    }

    // Abstract class: Reptile
    public abstract class Reptile : Animal
    {
        public abstract void ShedSkin();
    }

    // Abstract class: Reptile
    public abstract class Bird : Animal
    {
        public abstract void Fly();
    }

    //concrete classes lion and its derived from mammal
    public class Lion : Mammal
    {
        //constructor 
        public Lion(string name)
        {
            Name = name;
        }

        public override void Eat()
        {
            Console.WriteLine("Lion is eating meat.");

        }

        public override void Sound()
        {
            Console.WriteLine("Lion is roaring.");
        }

        public override void GiveBirth()
        {
            Console.WriteLine("Lion gives birth to cubs.");
        }

        public override void Sleep()
        {
            Console.WriteLine("Lion is sleeping.");
        }

        public override void Move()
        {
            Console.WriteLine("Lion is moving!");
        }


        public override string Color
        {
            get { return "Yellow"; }
            set { Console.WriteLine("Setting color of Lion"); }
        }

        public override string Habitat
        {
            get { return "Grassland"; }
            set { Console.WriteLine("Setting habitat of Lion"); }
        }

    }
    //interface class for eagle and bat 
    public interface IFlys
    {
        public int Wingspan { get; set; }
        public void Fly()
        {

        }
    }
    //concrete class eagle derived from Bird
    public class Eagle : Bird, IFlys
    {
        public int Wingspan { get; set; }
        public Eagle(string name)
        {
            Name = name;
        }
        public override void Eat()
        {
            Console.WriteLine("Eagle is eating fish.");
        }

        public override void Sound()
        {
            Console.WriteLine("Eagle is screeching.");
        }

        public override void Fly()
        {
            Console.WriteLine("Eagle is soaring in the sky.");
        }
    }

    //Snake is concrete and derived from Reptile
    public class Snake : Reptile
    {
        public Snake(string name)
        {
            Name = name;
        }
        public override void Eat()
        {
            Console.WriteLine("Snake is eating prey.");
        }

        public override void Sound()
        {
            Console.WriteLine("Snake hisses.");
        }

        public override void ShedSkin()
        {
            Console.WriteLine("Snake is shedding its skin.");
        }

    }

    //Dolphin is concrete and its derived from mammal
    public class Dolphin : Mammal
    {
        public Dolphin(string name)
        {
            Name = name;
        }
        public override void Eat()
        {
            Console.WriteLine("Dolphin is eating fish.");
        }

        public override void Sound()
        {
            Console.WriteLine("Dolphin is making clicking sounds.");
        }

        public override void GiveBirth()
        {
            Console.WriteLine("Dolphin gives birth to calves.");
        }
    }


    public class Bat : Mammal, IFlys
    {
        public int Wingspan { get; set; }

        public Bat(string name)
        {
            Name = name;
        }
        public override void Eat()
        {
            Console.WriteLine("Bat is eating leaves.");
        }

        public override void Sound()
        {
            Console.WriteLine("Bat is trumpeting.");
        }

        public override void GiveBirth()
        {
            Console.WriteLine("Bat gives birth to calves.");
        }


    }

    //Elephant is concrete and is derived from Mammal
    public class Elephant : Mammal
    {
        public Elephant(string name)
        {
            Name = name;
        }
        public override void Eat()
        {
            Console.WriteLine("Bat is eating bugs.");
        }

        public override void Sound()
        {
            Console.WriteLine("Bat is using echoloaction");
        }

        public override void GiveBirth()
        {
            Console.WriteLine("Bat gave birth to pups.");
        }
    }

}