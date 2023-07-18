namespace Interfaces_lab7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Lion lion = new Lion("Mufasa");

        }

        // This is the abstract class: Animal
        public abstract class Animal
        {
            public string Name { get; set; }
            public abstract void Eat();
            public abstract void Sound();
        }

        //// Abstract class: Mammal
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

        //Inherited classes are from lines 37-126. 
       /* public abstract class Lion : Mammal
        {
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
        }*/


        public class Eagle : Bird
        {
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

        public class Snake : Reptile
        {
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

        public class Dolphin : Mammal
        {
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

        public class Elephant : Mammal
        {
            public override void Eat()
            {
                Console.WriteLine("Elephant is eating leaves.");
            }

            public override void Sound()
            {
                Console.WriteLine("Elephant is trumpeting.");
            }

            public override void GiveBirth()
            {
                Console.WriteLine("Elephant gives birth to calves.");
            }
        }


    }
}