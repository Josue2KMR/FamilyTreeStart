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
            var Person3 = new Person("Julie", 18);
            var Person4 = new Person("Juan", 12);
            var Person5 = new Person("Lorena", 82);
            var Person6 = new Person("Richard", 88);
            var Person7 = new Person("Lucas", 55);
            
            var PersonTree = new PersonNode(Person1);
            PersonTree.AddChildren(new PersonNode(Person3));
            PersonTree.AddChildren(new PersonNode(Person4));
            PersonTree.AddChildren(new PersonNode(Person2));

            var ChildNode1 = new PersonNode(Person3);
            ChildNode1.AddChildren(new PersonNode(Person5));
            ChildNode1.AddChildren(new PersonNode(Person6));

            var ChildNode2 = new PersonNode(Person4);
            ChildNode2.AddChildren(new PersonNode(Person7));

            PersonTree.AddChildren(ChildNode1);
            PersonTree.AddChildren(ChildNode2);
            

            // visitar el árbol aquí
        }
    }
}
