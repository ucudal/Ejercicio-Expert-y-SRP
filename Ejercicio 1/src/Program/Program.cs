using System;

namespace SRP
{

    class Program
    {
        static void Main()
        {
            //Book book1 = new Book("Design Patterns","Erich Gamma & Others","001-034");
            //Book book2 = new Book("Pro C#","Troelsen","001-035");
            //book1.ShelveBook("A","7");
            //book2.ShelveBook("B","3");
            ShelveBook book1 = new ShelveBook("Design Patterns","Erich Gamma & Others","001-034","A","7");
            ShelveBook book2 = new ShelveBook("Pro C#","Troelsen","001-035","B","3");

        }
    }
}