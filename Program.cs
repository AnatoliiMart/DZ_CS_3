using System.Data.Common;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Channels;

namespace DZ_CS_3
{
    internal class Program
    {
        static void Main()
        {
            Ex1();
            if (Ex2(1221))
            Console.WriteLine("String is palindrome!");
            else
            Console.WriteLine("String isn't palindrome!");
            Ex4();
            Ex5();
            Ex6();
            // третью задачку не осилил уж простите)))

        }
        static void Ex1()
        {
            char symbol;
            char empt = ' ';
            int size;
            // вводим количество символов для заполнения
            Console.WriteLine("Enter size:\t");
            size = int.Parse(Console.ReadLine());
            //вводим символ которым будем рисовать квадрат 
            Console.WriteLine("Enter the fill symbol:\t");
            symbol = (char)Console.Read();
            // рисуем квадрат из введенного символа по введенному размеру
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (i == 0 || j == 0 || i == size - 1 || j == size - 1) Console.Write(symbol);
                    else Console.Write(empt);
                }
                Console.WriteLine();
            }
        }
        static bool Ex2(int number)
        {
            // создаем пустую строку 
            string str1 = string.Empty;
            // конвертируем чисо из параметров в строку 
            string str = number.ToString();
            // используя цикл заполняем пустую строку
            // строкой которую ввел пользователь перевернув ее наоборот 
            for (int i = str.Length - 1; i >= 0; i--)
                str1 += str[i];
            //сравнивая две строки определяем является ли введенная строка палиндромом
            return str.Equals(str1);
        }
        //static int[] Ex3(int[] data, int[] filtr)
        //{
        //    int[] res = new int[data.Length];
        //    for (int i = 0; i < filtr.Length; i++)
        //    {
        //        for (int j = 0; j < data.Length; j++)
        //        {
        //            if (data[j] != filtr[i])
        //            {
        //                res[j] = data[j];
        //            }
        //        }

        //    }
        //    return res;
        //}
        static void Ex4()
        {
            //создаем екземпляр класса используя кон-тор по умолчанию
            Website website = new();
            // вводим данные при помощи пользовательского метода
            website.InputData();
            Console.WriteLine();
            // вывод осуществляем переопределенным методом ToString()
            Console.WriteLine(website.ToString());
            Console.WriteLine();
            // изменяем значения полей при помощи одноименных свойств
            website.Description = "My First Website";
            website.Ip = "192.168.0.1";
            // и снова выводим
            Console.WriteLine(website.ToString());
            Console.WriteLine();
            // создаем новый объект но уже используя конструктор с параметрами 
            Website website1 = new("ItStep", "Site 2", "www.ItStep.org", "192.125.15.11");
            // выводим его
            Console.WriteLine(website1.ToString());

        }
        static void Ex5()
        {
            //создаем екземпляр класса используя кон-тор по умолчанию
            Magazine magazine = new();
            // вводим данные при помощи пользовательского метода
            magazine.InputData();
            Console.WriteLine();
            // вывод осуществляем переопределенным методом ToString()
            Console.WriteLine(magazine.ToString());
            Console.WriteLine();
            // изменяем значения полей при помощи одноименных свойств
            magazine.Name = "Forbs";
            magazine.PhoneNumber = "+111111111111";
            magazine.EMail1 = "blaBlabla@post.com";
            // и снова выводим
            Console.WriteLine(magazine.ToString());
            Console.WriteLine();
            // создаем новый объект но уже используя конструктор с параметрами 
            Magazine magazine1 = new("Igo", "+380123456789", "About i go", 2022, "iGo2022@gmail.com");
            // выводим его
            Console.WriteLine(magazine1.ToString());
        }
        static void Ex6()
        {
            //создаем екземпляр класса используя кон-тор по умолчанию
            Shop shop = new();
            // вводим данные при помощи пользовательского метода
            shop.InputData();
            Console.WriteLine();
            // вывод осуществляем переопределенным методом ToString()
            Console.WriteLine(shop.ToString());
            Console.WriteLine();
            // изменяем значения полей при помощи одноименных свойств
            shop.Name = "Silpo";
            shop.PhoneNumber = "+111111111111";
            shop.EMail1 = "blaBlabla@post.com";
            // и снова выводим
            Console.WriteLine(shop.ToString());
            Console.WriteLine();
            // создаем новый объект но уже используя конструктор с параметрами 
            Shop shop1 = new("Igo", "+380123456789", "Product shop", "Odeska 123/1", "iGo2022@gmail.com");
            // выводим его
            Console.WriteLine(shop1.ToString());
        }
        class Website
        {
            private string name;
            private string description;
            private string way;
            private string ip;

            public  string Description { get => description; set => description = value; }
            public  string Ip          { get => ip; set => ip = value; }

            public Website()
            {
                name        = "noName";
                description = "noDescription";
                way         = "noWay";
                ip          = "noIP";
            }

            public Website(string Name, string Description, string Way, string IP)
            {
                this.name        = Name;
                this.description = Description;
                this.way         = Way;
                this.ip          = IP;
            }

            public void InputData()
            {
                Console.Write("Enter website name:\t");
                this.name = Console.ReadLine();
                Console.Write("Enter website description:\t");
                this.Description = Console.ReadLine();
                Console.Write("Enter way to the website:\t");
                this.way = Console.ReadLine();
                Console.Write("Enter website IP:\t");
                this.ip = Console.ReadLine();
            }

            public override string ToString()
            {

                return "Website name:\t" + name + "\nDescription:\t" + Description +
                       "\nWay to website:\t" + way + "\nIp adress:\t" + ip;
            }
        }
        class Magazine
        {
            private string name;
            private string phoneNumber;
            private int    yearOfFoundation;
            private string description;
            private string EMail;

            public  string Name        { get => name; set => name = value; }
            public  string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
            public  string EMail1      { get => EMail; set => EMail = value; }

            public Magazine()
            {
                this.name             = "noName";
                this.phoneNumber      = "+000000000000";
                this.description      = "noDescription";
                this.yearOfFoundation = 0;
                this.EMail            = "noEmail";
            }

            public Magazine(string Name, string PhoneNumber, string Description, int YearOfFoundation, string Email )
            {
                this.name             = Name;
                this.phoneNumber      = PhoneNumber;
                this.description      = Description;
                this.yearOfFoundation = YearOfFoundation;
                this.EMail            = Email;
            }

            public void InputData()
            {
                Console.Write("Enter name of magazine:\t");
                this.name = Console.ReadLine();

                Console.Write("Enter the year of magazine foundation:\t");
                this.yearOfFoundation = int.Parse(Console.ReadLine());

                Console.Write("Enter description of magazine:\t");
                this.description = Console.ReadLine();

                Console.Write("Enter phone number of magazine:\t");
                this.phoneNumber = Console.ReadLine();

                Console.Write("Enter the Email of magazine:\t");
                this.EMail = Console.ReadLine();
            }

            public override string ToString()
            {
                return "Name:\t\t\t" + name + "\nYear of foundation:\t" + yearOfFoundation +
                       "\nDescription:\t\t" + description + "\nPhone number:\t\t" + phoneNumber +
                       "\nEmail:\t\t\t" + EMail;
            }
        }
        class Shop
        {
            private string name;
            private string phoneNumber;
            private string EMail;
            private string description;
            private string adress;

            public  string  Name        { get => name; set => name = value; }
            public  string  PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
            public  string  EMail1      { get => EMail; set => EMail = value; }

            public Shop()
            {
                this.name        = "noName";
                this.phoneNumber = "+000000000000";
                this.description = "noDescription";
                this.adress      = "noAdress";
                this.EMail       = "noEmail";
            }

            public Shop(string Name, string PhoneNumber, string Description, string Adress, string Email)
            {
                this.name        = Name;
                this.phoneNumber = PhoneNumber;
                this.description = Description;
                this.adress      = Adress;
                this.EMail       = Email;
            }

            public void InputData()
            {
                Console.Write("Enter name of shop:\t");
                this.name = Console.ReadLine();

                Console.Write("Enter the adress of shop:\t");
                this.adress = Console.ReadLine();

                Console.Write("Enter description of shop:\t");
                this.description = Console.ReadLine();

                Console.Write("Enter phone number of shop:\t");
                this.phoneNumber = Console.ReadLine();

                Console.Write("Enter the Email of shop:\t");
                this.EMail = Console.ReadLine();
            }

            public override string ToString()
            {
                return "Name:\t\t" + name + "\nAdress:\t" + adress +
                       "\nDescription:\t" + description + "\nPhone number:\t" + phoneNumber +
                       "\nEmail:\t\t" + EMail;
            }
        }
    }
}