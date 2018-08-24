using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {

            #region
            List<Book> bookList = new List<Book>();
            bookList.Add(new Book("Harry Potter", 4850, "J.K.Rowling", 1996));
            bookList.Add(new Book("Pride and Prejudice", 2690, "J. Ostin", 1813));
            bookList.Add(new Book("100 years of solitude", 3590, "Gabriel García Márquez", 1967));
            bookList.Add(new Book("Anna Karenina", 4290, "L.N. Tolstoy", 1877));


            BinaryFormatter bf = new BinaryFormatter();

            using (System.IO.FileStream fs = new FileStream(@"\Users\Адиль\Documents\Visual Studio 2017\listSerial.txt", FileMode.OpenOrCreate))
            {
                bf.Serialize(fs, bookList);
                Console.WriteLine("объект сериализирован");
            }

            Thread.Sleep(1000);
            Console.WriteLine();


            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream(@"\Users\Адиль\Documents\Visual Studio 2017\listSerial.txt", FileMode.OpenOrCreate))
            {
                var result = (List<Book>)formatter.Deserialize(fs);
                Console.WriteLine("объект десериализирован");
                foreach (Book item in result)
                {
                    Console.WriteLine(item.Name + "\t" + item.Price + "\t" + item.Author + "\t" + item.Year);
                }
            }
            #endregion


            //string[] str = { "," };
            //using (StreamReader rd = new StreamReader(new FileStream("personList.csv", FileMode.Open)))
            //{
            //    str = rd.ReadToEnd().Split(str, StringSplitOptions.RemoveEmptyEntries);
            //}

            Console.WriteLine("остальное по ссылке https://github.com/DaenyK/Serialize-part-2");

        }
    }
}
