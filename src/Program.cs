using System;

namespace Learning_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // DuckInterfacing();
            // DoSomeInheritanceStuff();
            System.Console.WriteLine(MyMath.Power(2, 5));
        }




        static void DuckInterfacing()
        {
            IDuck mDuck = new MallordDuck();
            System.Console.WriteLine("The mallord duck says");
            mDuck.Quack();
            IDuck wDuck = new WoodenDuck();
            System.Console.WriteLine("The wooden duck says");
            wDuck.Quack();
        }

        static void DoSomeInheritanceStuff()
        {
            BaseClass Bob = new BaseClass();
            ChildClass Robert = new ChildClass();

            Bob.Method1();
            Robert.Method1();
        }
    }
}