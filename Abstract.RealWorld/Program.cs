using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract.RealWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            AnimalWorld world1 = new AnimalWorld(new AfricaFactory());
            world1.RunFoodChain();

            AnimalWorld world2 = new AnimalWorld(new AsiaFactory());
            world2.RunFoodChain();

            Console.ReadLine();
        }
    }

    /// <summary>
    /// The AbstractFactory class
    /// </summary>
    abstract class ContinentFactory
    {
        public abstract Herbivore CreateHerbivore();
        public abstract Carnivore CreateCarnivore();
    }

    /// <summary>
    /// The ConcreateFactory1 class
    /// </summary>
    class AfricaFactory : ContinentFactory
    {
        public override Carnivore CreateCarnivore()
        {
            return new Lion();
        }

        public override Herbivore CreateHerbivore()
        {
            return new Wildebeest();
        }
    }

    /// <summary>
    /// The ConcreateFactory2 class
    /// </summary>
    class AsiaFactory : ContinentFactory
    {
        public override Carnivore CreateCarnivore()
        {
            return new Wolf();
        }

        public override Herbivore CreateHerbivore()
        {
            return new Bison();
        }
    }

    /// <summary>
    /// Abstract Product class A
    /// </summary>
    public abstract class Carnivore
    {
        public abstract void Eat(Herbivore herbivore);
    }

    /// <summary>
    /// Abstract Product class B
    /// </summary>
    public abstract class Herbivore
    {
    }

    /// <summary>
    /// The ProductA1
    /// </summary>
    public class Wildebeest : Herbivore
    {
    }

    /// <summary>
    /// The ProductB1
    /// </summary>
    public class Lion : Carnivore
    {
        public override void Eat(Herbivore herbivore)
        {
            Console.WriteLine(this.GetType().Name + " eats " + herbivore.GetType().Name);
        }
    }

    /// <summary>
    /// The ProductA2
    /// </summary>
    public class Bison: Herbivore
    {
    }

    /// <summary>
    /// The ProductB2
    /// </summary>
    public class Wolf : Carnivore
    {
        public override void Eat(Herbivore herbivore)
        {
            Console.WriteLine(this.GetType().Name + " eats " + herbivore.GetType().Name);
        }
    }

    class AnimalWorld
    {
        private Herbivore _herbivore;
        private Carnivore _carnivore;

        public AnimalWorld(ContinentFactory factory)
        {
            _herbivore = factory.CreateHerbivore();
            _carnivore = factory.CreateCarnivore();
        }

        public void RunFoodChain()
        {
            _carnivore.Eat(_herbivore);
        }
    }
}
