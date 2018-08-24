using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{

    [Serializable]
    public class Book
    {


        //название, стоимость, автор, год.Создать коллекцию
        public Book(string name, double price, string author, int year)
        {
            Name = name;
            Price = price;
            Author = author;
            Year = year;
        }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }

    }
}
