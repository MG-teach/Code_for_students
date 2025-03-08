using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2_for_training
{
    internal class DoublyLinkedList<T>
    {
        public DoublyLinkedList()
        {
            Head = null;
            Tail = null;
        }

        public DoublyNode<T>? Head { get; set; } // Начален (първи) възел в списъка
        public DoublyNode<T>? Tail { get; set; } // Краен (последен) възел в списъка


        // Добавяне на елемент в началото на списъка
        public void AddFirst(T data)
        {
            DoublyNode<T> newNode = new DoublyNode<T>(data);
            if (Head == null) // Ако списъкът е празен
            {
                Head = newNode;
                Tail = newNode;
            }
            else
            {
                newNode.Next = Head;
                Head.Previous = newNode;
                Head = newNode;
            }
        }

        // Премахване на елемент от началото на списъка
        public T RemoveFirst()
        {
            if (Head == null)
                throw new InvalidOperationException("Списъкът е празен");

            T removedData = Head.Data; // Запазване на премахнатите данни
            Head = Head.Next; // Пренасочване на главата към следващия възел

            if (Head != null)
                Head.Previous = null;
            else
                Tail = null; // Ако списъкът стане празен

            return removedData;
        }

        // Търсене на елемент по стойност
        public bool Contains(T value)
        {
            DoublyNode<T>? current = Head;
            while (current != null)
            {
                if (current.Data.Equals(value))
                    return true;
                current = current.Next;
            }
            return false;
        }

        // Проверка дали списъкът е празен
        public bool IsEmpty()
        {
            return Head == null;
        }

        // Добавяне на елемент в края на списъка
        public void AddLast(T data)
        {
            DoublyNode<T> newNode = new DoublyNode<T>(data);
            if (Tail == null) // Ако списъкът е празен
            {
                Head = newNode;
                Tail = newNode;
            }
            else
            {
                Tail.Next = newNode;
                newNode.Previous = Tail;
                Tail = newNode;
            }
        }

        // Премахване на елемент от края на списъка
        public T RemoveLast()
        {
            if (Tail == null)
                throw new InvalidOperationException("Списъкът е празен");

            T removedData = Tail.Data; // Запазване на премахнатите данни
            Tail = Tail.Previous; // Пренасочване на опашката към предходния възел

            if (Tail != null)
                Tail.Next = null;
            else
                Head = null; // Ако списъкът стане празен

            return removedData;
        }

    }
}

