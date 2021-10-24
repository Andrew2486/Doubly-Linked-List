using System;

namespace Doble_linked_list
{
    class DLL
    {
        public Nodes head;
        public Nodes tail;
        public void addtotail(int data) //Adds adding to tail
        {
            Nodes p = new Nodes(data);
            if (head == null)
            {
                head = p;
                tail = p;
                Console.WriteLine("\nThe contents of the list: ");
            }
            else
            {
                tail.next = p;
                p.prev = tail;
                tail = p;
            }
        }
        public void PrintList() //Print out the list
        {
            Nodes temp = tail;
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.prev;
            }
        }
        public int midNode() // Find the middle node
        {
            int len = 0;
            Nodes p = tail;
            while (p != null)
            {
                len++;
                p = p.prev;
            }
            int temp = len / 2; // Count all Nodes then divides by 2 to find mid
            return temp;
        }
        public int returnNodevalue()
        {
            int value = midNode(); // recieves middle Node from method(midNode)
            Nodes cur = head;
            int count = 0;
            while (cur != null)
            {
                if (count == value)
                    return cur.data;
                count++;
                cur = cur.next;
            }
            return 0;
        }
        public void BasicPrimnums()
        {
            int count = 0;
            int f = 0;
            int m = 0;
            Nodes p = tail;
            Nodes temp = null;
            Console.WriteLine("Prime numbers are: ");
            while (p != null)
            {
                int j = 0; // spent 3 hours working out why my program wasnt working
                // didnt look at variables j was outside of loop so stuck on 1
                temp = p;
                p.next = p.prev;
                p = p.prev;
                if (temp == null) //Fixed (temp instead of p as temp is the current node p is upcomming node)
                {
                    break;
                }
                    f = Convert.ToInt32(temp.data);
                    if (f < 2)
                    {
                        f = 4; // Quick way to cancel anything below 2
                    }
                    m = f / 2;
                    for (int i = 2; i <= m; i++)
                    {
                        if (f % i == 0)
                        {
                            j = 1; // False                       
                            break;                        
                        }
                    }
                if (j == 0) // True
                {
                    count++;
                    Console.Write(f + ", ");
                    if (count == 5) // Splits lines for every 5 primes
                    {
                        count = 0;
                        Console.Write("\r\n");
                    }
                }
            }
        }
    }
}

// Remove list for primes