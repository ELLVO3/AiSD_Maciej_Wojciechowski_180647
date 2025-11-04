using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linkedList
{
    public class Lista
    {
        public Element head { get; set; }
        public Element tail { get; set; }
        public int ilośćElementów { get; private set; }
        public override string ToString()
        {
            if(head == null)
            {
                return "Lista jest pusta";
            }

            string wynik = "";

            Element current = head;

            while(current != null)
            {
                wynik += current.ToString();

                if(current.next != null)
                {
                    wynik += ", ";
                }
                current = current.next;
            }
            return wynik;
        }

        public void dodajPo(Element e, int number)
        {
            Element nowy = new Element(number);

            

        } 
    }
}
