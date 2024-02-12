using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    delegate void SecondMessage();

    internal class DelegateClass
    {
        delegate void Message();
        delegate int Operation(int x, int y);
        public DelegateClass() 
        {
            Message mes;
            mes = Hello;
            mes();

            SecondMessage sMes;
            sMes = Second;
            sMes();

            Operation op = Add;
            Console.WriteLine("This is delegate to sum numbers 4 and 5 =>" + op(4, 5));

            op = Multiply;
            Console.WriteLine("This is delegate to multuply numbers 4 and 5 =>" + op(4, 5));

            op = new Operation(Add);
            Console.WriteLine("This is delegate to multuply numbers 4 and 5, created via constructor =>" + op(4, 5));

            sMes += AddMethod;
            sMes();

            sMes -= AddMethod;
            sMes -= Second;
            if (sMes != null)
                sMes();
            else
                Console.WriteLine("Delegate contains no methods!");

            sMes += InvokeMethod;
            sMes.Invoke();

        }


        void Hello() => Console.WriteLine("Hello! This delagate in class body.");
        void Second() => Console.WriteLine("And this one is outside.");

        void AddMethod() => Console.WriteLine("This method added to delegate");

        void InvokeMethod() => Console.WriteLine("This is delegate.Invoke()");

        int Add(int x, int y) => x + y;
        int Multiply(int x, int y) => x * y;
    }
}
