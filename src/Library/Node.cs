using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public abstract class Node<T>
    {
        private T dato;

        private List<Node<T>> children = new List<Node<T>>();

        public T Dato
        {
            get { return this.dato; }
        }

        public ReadOnlyCollection<Node<T>> Children {
            get
            {
                return this.children.AsReadOnly();
            }
        }

        public Node(T dato)
        {
            this.dato = dato;
        }

        public void AddChildren(Node<T> n)
        {
            this.children.Add(n);
        }
    }
    
    public class IntNode : Node<int>
    {
        public IntNode(int data) : base(data) { }
    }

    public class PersonNode : Node<Person>
    {
        public PersonNode(Person data) : base(data) { }
    }
}
