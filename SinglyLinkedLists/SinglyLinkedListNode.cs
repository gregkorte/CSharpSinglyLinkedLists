﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// Stretch Goals: Using Generics, which would include implementing GetType() http://msdn.microsoft.com/en-us/library/system.object.gettype(v=vs.110).aspx
namespace SinglyLinkedLists
{
    public class SinglyLinkedListNode : IComparable
    {
        // Used by the visualizer.  Do not change.
        public static List<SinglyLinkedListNode> allNodes = new List<SinglyLinkedListNode>();

        // READ: http://msdn.microsoft.com/en-us/library/aa287786(v=vs.71).aspx
        private SinglyLinkedListNode next;
        public SinglyLinkedListNode Next
        {
            get { return this.next; }
            set { 
                if (this == value)
                {
                    throw new ArgumentException("Can't set next to this.");
                }
                this.next = value;
            }
        }

        private string value;
        public string Value 
        {
            get { return this.value; }
        }

        public static bool operator <(SinglyLinkedListNode node1, SinglyLinkedListNode node2)
        {
            // This implementation is provided for your convenience.
            return node1.CompareTo(node2) < 0;
        }

        public static bool operator >(SinglyLinkedListNode node1, SinglyLinkedListNode node2)
        {
            // This implementation is provided for your convenience.
            return node1.CompareTo(node2) > 0;
        }

        public SinglyLinkedListNode(string value)
        {
            this.value = value;
            // Used by the visualizer:
            allNodes.Add(this);
        }

        // READ: http://msdn.microsoft.com/en-us/library/system.icomparable.compareto.aspx
        public int CompareTo(Object obj)
        {
            return this.value.CompareTo(obj.ToString());
        }

        public bool IsLast()
        {
            if (this.Next == null) //Only need (this.Next == null)
            {
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return Value;
        }

        public override bool Equals(object obj)
        {
            //Also: SinglyLinkedListNode other = obj as SinglyLinkedListNode
            //      return other != null && this.Value.Equals(other.Value);
            //Or: 
            if (this.GetType() == obj.GetType()){

                if (this.Value == obj.ToString())
                {
                    return true;
                }
            }
            return false;
            }
    }
}
