using System;

namespace Learning_CSharp
{
    public static class MyMath
    {
        public static float Add(float a, float b)
        {
            return (a + b);
        }

        public static float Subtract(float a, float b)
        {
            return (a - b);
        }

        public static float Power(int a, int b)
        {
            int total = 1;
            int count = 0;
            while (count < b)
            {
                total *= a;
                count++;
            }

            return total;
        }


    }
}