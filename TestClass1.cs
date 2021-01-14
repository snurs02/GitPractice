using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpGit
{
    class TestClass1
    { 



        static void Main(string[] args)
    {

            TestClass1 testclass = new TestClass1();
            int sum = testclass.Sum(5, 5);
            Console.WriteLine(sum);


    }
    


         public int Sum(int a, int b)
        {
            return a + b;
        }

    }

    
    
}
