using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            var IntTree = new IntNode(5);
            IntTree.AddChildren(new IntNode(3));
            IntTree.AddChildren(new IntNode(8));
            
            var Person1 = new Person("John", 39);
            var Person2 = new Person("Jane", 39);
            var PersonTree = new PersonNode(Person1);
            PersonTree.AddChildren(new PersonNode(Person2));

            // visitar el árbol aquí
        }
    }
}
