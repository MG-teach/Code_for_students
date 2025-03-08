namespace zad2_for_training
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DoublyLinkedList<int> list = new DoublyLinkedList<int>();
            for (int i = 2; i <= 50; i++)
            {
                if (IsPrime(i))
                {
                    list.AddLast(i);
                }
            }

            Console.WriteLine();
            PrintList<int>(list.Head);
            Console.WriteLine();
            ReversePrintList<int>(list.Tail);
        }

        static void PrintList<T>(DoublyNode<T>? head)
        {
            
        }

        static void ReversePrintList<T>(DoublyNode<T>? tail)
        {
            
        }

        static bool IsPrime(int number)
        {
            
        }
    }
}
