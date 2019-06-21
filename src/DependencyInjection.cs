namespace Learning_CSharp
{
    class CarBuilder
    {
        // do stuff
    }
    class Car
    {
        public Car(Tire tires)
        {

        }
        private Tire tires { get; set; }
        private Engine engine { get; set; }
    }

    public abstract class Tire
    {
        public int trim;
    }

    public class WhitewallTire : Tire
    {
        WhitewallTire()
        {
            this.trim = 5;
        }
    }

    public class MichellinTire : Tire
    {
        MichellinTire()
        {
            this.trim = 10;
        }
    }

    public abstract class Engine
    {
        public int horsepower;
    }

    public class WeakEngine : Engine
    {
        WeakEngine()
        {
            this.horsepower = 20;
        }
    }

    public class FastEngine : Engine
    {
        FastEngine()
        {
            this.horsepower = 200;
        }
    }

}