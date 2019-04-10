using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStruct_CSharp_Montelongo {
    class Program {
        static void Main(string[] args) {
            int inputChoice = 0;
            LinkedList<int> numList = new LinkedList<int>();
            numList.AddLast(1);
            numList.AddLast(3);
            numList.AddLast(15);
            numList.AddLast(54);
            numList.AddLast(48);
            numList.AddLast(5);

            do {
                Console.WriteLine("Welcome to The Data Structure Console Application");
                Console.Write(" 1) Linked List \n" +
                              " 2) Find Node\n" +
                              " 3) Binary Search Tree\n" +
                              "-1) Exit");
                Console.Write("\nEnter the number for the data structure you want to create: ");
                int.TryParse(Console.ReadLine(), out inputChoice);

                switch (inputChoice) {
                    case 1:
                        ReverseLinkedList(numList);
                        break;
                    case 2:
                        FindNode();
                        break;
                }

                Console.Clear();
            } while (inputChoice != -1);

        }

        static void ReverseLinkedList (LinkedList<int> linkedList) {
            LinkedList<int> copyList = new LinkedList<int>();

            LinkedListNode<int> start = linkedList.Last;

            while (start != null) {
                copyList.AddLast(start.Value);
                start = start.Previous;
            }

            Console.Clear();
            Console.WriteLine("\nThe linked list currently has the values:");
            for (int i = 0; i < copyList.Count; i++) {
                Console.WriteLine($"Index {i}: {linkedList.ElementAt(i)}");
            }

            Console.WriteLine("\nThe linked list reversed has the values:");
            for (int i = 0; i < copyList.Count; i++) {
                Console.WriteLine($"Index {i}: {copyList.ElementAt(i)}");
            }

            Console.Write("Press any key to continue...");
            Console.ReadKey();
        }

        static void FindNode() {
            LinkedList<string> linked = new LinkedList<string>();
            
            linked.AddLast("A");
            linked.AddLast("B");
            linked.AddLast("C");

            Console.Clear();
            Console.WriteLine("\nCurrent linked list values");
            foreach (var value in linked) {
                Console.WriteLine(value);
            }

            Console.WriteLine("\nInsert a value after element 'A': ");
            LinkedListNode<string> node = linked.Find("A");
            linked.AddAfter(node, "inserted");

            foreach (var value in linked) {
                Console.WriteLine(value);
            }

            Console.Write("Press any key to continue...");
            Console.ReadKey();
        }



    }
}
