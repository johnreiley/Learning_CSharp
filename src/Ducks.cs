namespace Learning_CSharp
{
    interface IDuck
    {
        void Quack();
    }

    class MallordDuck : IDuck
    {
        void IDuck.Quack()
        {
            System.Console.WriteLine("Quack!");
        }
    }

    class WoodenDuck : IDuck
    {
        void IDuck.Quack()
        {
            System.Console.WriteLine("*silence*");
        }
    }
}