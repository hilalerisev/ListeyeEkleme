using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2VY15253022
{
    class ListeyeEkleme <T> where T:IComparable
    {
        Node<T> head;
        private int count;

        public int Count
        {
            get => count;
        }

        public void addOrdered(T value)
        {
            Node<T> newNode = new Node<T>(value);
            if (bos())
                head = newNode;
            else
            {
                Node<T> iterator = head;
                if (head.value.CompareTo(newNode.value)==+1)
                {
                    newNode.next = head;
                    head.prev = newNode;
                    head = newNode;
                }
                else
                {

                    while (iterator.next != null && iterator.next.value.CompareTo(newNode.value)==-1)
                    {
                        iterator = iterator.next;

                    }
                    newNode.next = iterator.next;
                    iterator.next = newNode;
                    newNode.prev = iterator;
                    if (newNode.next != null)
                        newNode.next.prev = newNode;
                }
            }
        }
        public bool bos()
        {
            if (head == null)
                return true;
            return false;
        }

        public void remove(T value)
        {
            Node<T> newNode = new Node<T>(value);
            if (!bos())
            {
                if (head.value.CompareTo(value) == 0)
                {
                    head= head.next;
                    head.prev = null;

                }
                else
                {
                    Node<T> iterator = head;
                    while (iterator.next != null && iterator.value.CompareTo(value) != 0)
                    {
                        iterator = iterator.next;
                    }
                    if (iterator.value.CompareTo(value) == 0)
                        iterator.prev.next = iterator.next;
                    else
                        Console.WriteLine("silmek istediğiniz sayı listede yok");
                }
            }

        }
        public int find(T sayi)
        {
           
            Node<T> newNode = new Node<T>(sayi);
            int sayac = 0;
            if (!bos())
            {
                Node<T> ite = head;
               
                while (ite != null)
                {
                    if (ite.value.CompareTo(sayi)==0)
                    {
                        sayac++;
                    }
                    //if(ite.next!=null)
                    ite = ite.next;
                }    
            }
            return sayac;
        }
        public void display()
        {
            
            Node<T> iterator = head;
            count = 0;
            while (iterator!= null)
            {
                Console.Write(iterator.value + " - ");
                iterator = iterator.next;
                count++;
            }
           
            Console.WriteLine("\neleman sayısı: "+count);
            Console.WriteLine();
            
            
        }
        public void clear()
        {
            head = null;
        } 
    }
}
