using System;

namespace CSharpLearning
{
    public class AccessModifierDemo
    {
        public int PublicValue = 10;

        private int PrivateValue = 20;

        protected int ProtectedValue = 30;

        internal int InternalValue = 40;

        protected internal int ProtectedInternalValue = 50;

        private protected int PrivateProtectedValue = 60;

        public void ShowValues()
        {
            Console.WriteLine(PublicValue);
            Console.WriteLine(PrivateValue);
            Console.WriteLine(ProtectedValue);
            Console.WriteLine(InternalValue);
            Console.WriteLine(ProtectedInternalValue);
            Console.WriteLine(PrivateProtectedValue);
        }
    }
}