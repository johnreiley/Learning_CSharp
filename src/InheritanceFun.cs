namespace Learning_CSharp
{
    public class BaseClass
    {
        public virtual void Method1()
        {
            System.Console.WriteLine("I did some stuff!");
        }
    }

    public abstract class AbstractClass
    {
        public abstract void Method1();
    }

    public class ChildClass : BaseClass
    {
        public override void Method1()
        {
            System.Console.WriteLine("Oopsie, I didn't do anything. Hehehe...");
        }
    }
}