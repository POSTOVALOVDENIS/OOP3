using System;

namespace OOP3._0_
{
    class Kniga
    {
        private string Avtor;
        private string Nazvanie;
        private int Kolvo;
        private bool Izdanie;
        public Kniga(string Avtor, string Nazvanie, int Kolvo, bool Izdanie)
        {
            this.Avtor = Avtor;
            this.Nazvanie = Nazvanie;
            this.Kolvo = Kolvo;
            this.Izdanie = Izdanie;
        }
        public void clas()
        {
            Console.WriteLine("Автор: " + Avtor);
            Console.WriteLine("Название книги: " + Nazvanie);
            Console.WriteLine("Кол-во страниц: " + Kolvo);
            Console.WriteLine("Коллекционное издание: " + Izdanie);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("0 - Заполнить только есть ли коллекционное издание");
            Console.WriteLine("1 - Заполнить только автора");
            Console.WriteLine("2 - Заполнить только автора и название");
            Console.WriteLine("3 - Заполнить только автора, название и кол-во страниц");
            Console.WriteLine("4 - Заполнить всё");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num == 0)
            {
                Kniga newBook0 = new Kniga("0", "0", 0, true);
                newBook0.clas();
            }
            if (num == 1)
            {
                Kniga newBook1 = new Kniga("Лев Толстой", "0", 0, false);
                newBook1.clas();
            }
            if (num == 2)
            {
                Kniga newBook2 = new Kniga("Лев Толстой", "Анна Каренина", 0, false);
                newBook2.clas();
            }
            if (num == 3)
            {
                Kniga newBook3 = new Kniga("Лев Толстой", "Анна Каренина", 1124, false);
                newBook3.clas();
            }
            if (num == 4)
            {
                Kniga newBook4 = new Kniga("Лев Толстой", "Анна Каренина", 1124, true);
                newBook4.clas();
            }
            Console.ReadLine();
        }
    }
}
