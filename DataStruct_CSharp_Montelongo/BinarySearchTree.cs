using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStruct_CSharp_Montelongo {
    class BinarySearchTree {

        public class Node {
            public int Data;
            public Node Left;
            public Node Right;
            public void DisplayNode() {
                Console.Write(Data + " ");
            }
        }

        public Node root;
        public BinarySearchTree() {
            root = null;
        }

        public void Insert (int i) {
            Node newNode = new Node();
            newNode.Data = i;
            
            if (root == null) {
                root = newNode;
                Console.Write($"{root.Data} ");
            } else {
                Node current = root;
                Node parent;

                while (true) {
                    parent = current;
                    if (i < current.Data) {
                        current = current.Left;
                        if (current == null) {
                            parent.Left = newNode;
                            parent.Left.DisplayNode();
                            break;
                        } else {
                            current = current.Right;

                            if (current == null) {
                                parent.Right = newNode;
                                parent.Right.DisplayNode();
                                break;
                            }
                        }
                    }
                }
            }
        }

        public void Search (int i) {
            Node current = root;
            Node parent;
            Node search = new Node();
            search.Data = i;
            parent = current;

            while (true) {
                if (current.Data == search.Data) {
                    current.DisplayNode();
                    break;
                } else if (current.Data < search.Data){
                    current = current.Right;
                } else {
                    current = current.Left;
                }
            }
        }
    }
}
