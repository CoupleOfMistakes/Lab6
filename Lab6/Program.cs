﻿using System;
using System.Collections;
using System.Collections.Generic;
using Task1;
using Task3;

namespace Task3
{
    class VectorShort
    {
        short[] ShortArray;
        static uint n;
        uint codeError;
        static uint num_v;
        public int index;
        public uint N
        {
            get => n;
        }

        public uint Code
        {
            get => codeError;
            set => codeError = value;
        }
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < N; i++)
            {
                if (i == n) yield break;
                yield return this.ShortArray[i];
            }
        }

        public IEnumerable FromTo(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                yield return this.ShortArray[i];
            }
        }

        public short[] ShortArray_get
        {
            get => ShortArray;
        }
        public uint Arr1(int k)
        {
            uint y = 0;
            for (int i = 0; i < ShortArray.Length; i++)
            {
                if (i == k)
                    y = (uint)ShortArray[i];
            }
            return y;
        }

        public VectorShort()
        {
            n = 1;
            ShortArray = new short[n];
            ShortArray[0] = 0;
        }

        public VectorShort(uint k)
        {
            n = k;
            ShortArray = new short[k];
            for (int i = 0; i < ShortArray.Length; i++)
            {
                ShortArray[i] = 0;
            }
        }
        public VectorShort(uint k, short y)
        {
            n = k;
            ShortArray = new short[n];
            for (int i = 0; i < ShortArray.Length; i++)
            {
                ShortArray[i] = y;
            }
        }
        ~VectorShort()
        {
            Console.WriteLine("Destructor");
        }

        public void Output()
        {
            for (int i = 0; i < this.ShortArray.Length; i++)
            {
                Console.Write("[{0}] = {1}\t", (i + 1), ShortArray[i]);
            }
        }

        public short[] Inn()
        {
            Console.Write("Enter the numbers of vector columns: ");
            n = uint.Parse(Console.ReadLine());
            ShortArray = new short[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("[{0}] = ", i + 1);
                ShortArray[i] = (short)(Convert.ToInt32(Console.ReadLine()));
                Console.WriteLine("\t");
            }
            return ShortArray;
        }
        public void Assign_value_par(short k)
        {
            for (int i = 0; i < this.ShortArray.Length; i++)
            {
                ShortArray[i] = k;
            }
        }
        public void Assign_value(VectorShort o)
        {

            for (int col = 0; col < n; col++)
            {

                ShortArray[col] = o.ShortArray[col];

            }
        }
        public short this[int index]
        {
            set
            {
                if (index > ShortArray.Length) codeError = 10;
                else codeError = 0;
                ShortArray[index] = value;
            }
            get
            {
                return ShortArray[index];
            }
        }
        public static VectorShort operator ++(VectorShort o)
        {
            for (int i = 0; i < o.ShortArray.Length; i++)
            {
                ++o.ShortArray[i];
                Console.Write("[{0}] = {1}\t", (i + 1), o.ShortArray[i]);
            }
            return o;
        }
        public static VectorShort operator --(VectorShort o)
        {
            for (int i = 0; i < o.ShortArray.Length; i++)
            {
                --o.ShortArray[i];
                Console.Write("[{0}] = {1}\t", (i + 1), o.ShortArray[i]);
            }
            return o;
        }
        public static bool operator true(VectorShort f1)
        {
            return f1.N != 0;
        }
        public static bool operator false(VectorShort f1)
        {
            return f1.N == 0;
        }
        public static bool operator !(VectorShort f1)
        {
            return f1.N != 0;
        }
        public static bool operator !=(VectorShort f1, int k)
        {
            k = 0;
            return f1.N != k;
        }
        public static bool operator ==(VectorShort f1, int k)
        {
            k = 0;
            return f1.N == k;
        }
        public static VectorShort operator +(VectorShort f1, VectorShort c2)
        {
            Console.WriteLine();
            for (int i = 0; i < f1.ShortArray.Length; i++)
            {
                f1.ShortArray[i] += c2.ShortArray[i];
                Console.Write("[{0}] = {1}\t", (i + 1), f1.ShortArray[i]);
            }
            return f1;
        }
        public static VectorShort operator -(VectorShort f1, VectorShort c2)
        {
            Console.WriteLine();
            for (int i = 0; i < f1.ShortArray.Length; i++)
            {
                f1.ShortArray[i] -= c2.ShortArray[i];
                Console.Write("[{0}] = {1}\t", (i + 1), f1.ShortArray[i]);
            }
            return f1;
        }
        public static VectorShort operator +(VectorShort f1, short c2)
        {
            Console.WriteLine();
            for (int i = 0; i < f1.ShortArray.Length; i++)
            {
                f1.ShortArray[i] += c2;
                Console.Write("[{0}] = {1}\t", (i + 1), f1.ShortArray[i]);
            }
            return f1;
        }
        public static VectorShort operator -(VectorShort f1, short c2)
        {
            Console.WriteLine();
            for (int i = 0; i < f1.ShortArray.Length; i++)
            {
                f1.ShortArray[i] -= c2;
                Console.Write("[{0}] = {1}\t", (i + 1), f1.ShortArray[i]);
            }

            return f1;
        }

        public static VectorShort operator *(VectorShort f1, VectorShort c2)
        {
            Console.WriteLine();
            for (int i = 0; i < f1.ShortArray.Length; i++)
            {
                f1.ShortArray[i] *= c2.ShortArray[i];
                Console.Write("[{0}] = {1}\t", (i + 1), f1.ShortArray[i]);
            }
            return f1;
        }
        public static VectorShort operator /(VectorShort f1, VectorShort c2)
        {
            Console.WriteLine();
            for (int i = 0; i < f1.ShortArray.Length; i++)
            {
                f1.ShortArray[i] /= c2.ShortArray[i];
                Console.Write("[{0}] = {1}\t", (i + 1), f1.ShortArray[i]);
            }
            return f1;
        }
        public static VectorShort operator *(VectorShort f1, short c2)
        {
            Console.WriteLine();
            for (int i = 0; i < f1.ShortArray.Length; i++)
            {
                f1.ShortArray[i] *= c2;
                Console.Write("[{0}] = {1}\t", (i + 1), f1.ShortArray[i]);
            }
            return f1;
        }
        public static VectorShort operator /(VectorShort f1, short c2)
        {
            Console.WriteLine();
            for (int i = 0; i < f1.ShortArray.Length; i++)
            {
                f1.ShortArray[i] /= c2;
                Console.Write("[{0}] = {1}\t", (i + 1), f1.ShortArray[i]);
            }

            return f1;
        }
        public static VectorShort operator <<(VectorShort f1, int c2)
        {
            Console.WriteLine();
            for (int i = 0; i < f1.ShortArray.Length; i++)
            {
                f1.ShortArray[i] = (byte)(c2 << 1); ;// *2
                Console.Write("[{0}] = {1}\t", (i + 1), f1.ShortArray[i]);
            }

            return f1;

        }
        public static VectorShort operator >>(VectorShort f1, int c2)
        {
            Console.WriteLine();
            for (int i = 0; i < f1.ShortArray.Length; i++)
            {
                f1.ShortArray[i] = (byte)(c2 >> 1); // /2
                Console.Write("[{0}] = {1}\t", (i + 1), f1.ShortArray[i]);
            }

            return f1;

        }
        public static bool operator >(VectorShort f1, VectorShort c2)
        {
            bool result = false;
            int index = f1.index;
            for (int i = 0; i < f1.ShortArray.Length; i++)
            {
                if (i == index)
                {
                    if (f1.ShortArray[i] > c2.ShortArray[i])
                        result = true;
                }
            }
            return result;
        }
        public static bool operator <(VectorShort f1, VectorShort c2)
        {
            bool result = false;
            int index = f1.index;
            for (int i = 0; i < f1.ShortArray.Length; i++)
            {

                if (i == index)
                {
                    if (f1.ShortArray[i] < c2.ShortArray[i])
                        result = true;
                }

            }
            return result;
        }
    }

}

namespace Task1
{
    interface Icountry { void Show(); }
    class Country : Icountry
    {
        protected string name;
        protected string ruller;
        protected string description;
        public Country(string name, string ruller, string description)
        {
            this.name = name;
            this.ruller = ruller;
            this.description = description;
        }
        public void Show()
        {
            Console.WriteLine("Name = " + name + "\nRuller = " + ruller + "\nDescription = " + description);
        }
    }
    class Republic : Country, Icountry
    {
        private bool democratic_core = true;
        private bool power_inheritance = false;
        public Republic(string name, string ruller, string description, bool power_inheritance) : base(name, ruller, description)
        {
            this.power_inheritance = power_inheritance;
        }
        public new void Show()
        {
            base.Show();
            Console.WriteLine("This country is a Republic!");
            if (democratic_core == true && power_inheritance == false)
            {
                Console.Write(" Because it is based on democratic core and has no power inheritance");
            }
            else
            {
                Console.Write(" The Republic with inheritance of Power? Nice try! :^)");
            }
        }
    }
    class Kingdom : Country, Icountry
    {
        private bool power_inheritance = true;
        public Kingdom(string name, string ruller, string description, bool power_inheritance) : base(name, ruller, description)
        {
            this.power_inheritance = power_inheritance;
        }
        public new void Show()
        {
            base.Show();
            Console.WriteLine("This country is a Kingdom!");
            if (power_inheritance != true)
            {
                Console.Write("...Without a King or a Queen? Strange indeed!");
            }
        }
    }
    class Monarchy : Kingdom, Icountry
    {
        private int type;
        public Monarchy(string name, string ruller, string description, int type) : base(name, ruller, description, true)
        {
            this.type = type;
        }

        public new void Show()
        {
            Console.WriteLine("Name = " + name + "\nRuller = " + ruller + "\nDescription = " + description);
            Console.WriteLine("Your country automatically become a Kingdom, because You are a Monarch!");
            if (type == 1)
            {
                Console.WriteLine("And Monarchy is constitutional :^c");
            }
            else
            {
                Console.WriteLine("And Monarchy is absolute! >:^)");
            }
        }
    }
}

namespace Task2
{
    interface IPublication
    {
        string name { get; set; }
        string author_lastname { get; set; }
        void Show();
    }
    abstract class Publication
    {
        string name;
        string author_lastname;
        public Publication(string name, string author_lastname)
        {
            this.name = name;
            this.author_lastname = author_lastname;
        }
        abstract public void Show();
        public string GetName()
        {
            return name;
        }
        public string GetAuthorLastname()
        {
            return author_lastname;
        }

    }

    class Book : Publication
    {
        uint publication_year;
        string publisher;
        public Book(string name, string author_lastname, uint publish_year, string publisher) : base(name, author_lastname)
        {
            this.publication_year = publish_year;
            this.publisher = publisher;
        }
        public override void Show()
        {
            Console.WriteLine("\n\tInformation about the book:\nIts name = " + base.GetName() + "\nAuthor Lastname = " + base.GetAuthorLastname() +
               "\nYear = " + publication_year + "\nPublisher = " + publisher);
        }
    }

    class Article : Publication
    {
        string magazine_name;
        string magazine_number;
        uint publication_year;
        public Article(string name, string author_lastname, string magazine_name, string magazine_number, uint publication_year) : base(name, author_lastname)
        {
            this.publication_year = publication_year;
            this.magazine_name = magazine_name;
            this.magazine_number = magazine_number;
        }
        public override void Show()
        {
            Console.WriteLine("\n\tInformation about the Article:\nIts name = " + base.GetName() + "\nAuthor Lastname = " + base.GetAuthorLastname() + "\nMagazine name = " + magazine_name +
               "\nMagazine number = " + magazine_number + "\nYear = " + publication_year);
        }
    }

    class Blog : Publication
    {
        string link, annotation;
        public Blog(string name, string author_lastname, string link, string annotation) : base(name, author_lastname)
        {
            this.link = link;
            this.annotation = annotation;
        }
        public override void Show()
        {
            Console.WriteLine("\n\tInformation about the Blog:\nIts name = " + base.GetName() + "\nAuthor Lastname = " + base.GetAuthorLastname() +
                "\nLink = " + link + "\nAnnotation = " + annotation);
        }
    }

    class Catalogue
    {
        List<Publication> catalog = new List<Publication>();
        public void AddPublication(Publication n)
        {
            catalog.Add(n);
        }
        public void ShowAll()
        {
            foreach (var c in catalog) c.Show();
        }
        public bool FindAuthor(string lastname)
        {
            bool success = false;
            foreach (var c in catalog.FindAll(c => c.GetAuthorLastname() == lastname))
            {
                c.Show();
                success = true;
            }
            return success;
        }
    }

}

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("\t\tLab 2\nThere are tasks with numbers 1.13, 2.13, 3.3\nChoose the one you want to start:");
                String task_number = Console.ReadLine();
                switch (task_number)
                {
                    case "1.13":
                        Console.WriteLine("Input the name of your country, its ruller and the descriprion!");
                        string name = Console.ReadLine(), ruller = Console.ReadLine(), description = Console.ReadLine();
                        Console.WriteLine("What country you want to create? a Republic = Key '1', a Kingdom = Key '2', a Monarchy = Key '3'\nKey'4' = Stop asking me! Just a country!");
                        string input = Console.ReadLine();
                        if (input == "1")
                        {
                            Console.WriteLine("A Republic cannot have an inheritance of Power, yes ._.?   (Y/N) ");
                            string choice = Console.ReadLine();
                            if (choice == "Y" || choice == "Yes" || choice == "y" || choice == "yes")
                            {
                                Republic republic = new Republic(name, ruller, description, false); republic.Show();
                            }
                            else { Republic republic = new Republic(name, ruller, description, true); republic.Show(); }
                        }
                        else if (input == "2")
                        {
                            Console.WriteLine("Your Kingdom have an inheritance of Power, yes? (Y/N) ");
                            string choice = Console.ReadLine();
                            if (choice == "Y" || choice == "Yes" || choice == "y" || choice == "yes")
                            {
                                Kingdom kingdom = new Kingdom(name, ruller, description, true); kingdom.Show();
                            }
                            else { Kingdom kingdom = new Kingdom(name, ruller, description, false); kingdom.Show(); }

                        }
                        else if (input == "3")
                        {
                            Console.WriteLine("Input the type of your monarchy. Constitutional = Key '1', for Absolute Monarchy... it's your choice, You're the ruller!");
                            string choice = Console.ReadLine();
                            if (choice == "1")
                            {
                                Monarchy monarchy = new Monarchy(name, ruller, description, 1); monarchy.Show();
                            }
                            else { Monarchy monarchy = new Monarchy(name, ruller, description, 0); monarchy.Show(); }

                        }
                        else if (input == "4")
                        {
                            Country country = new Country(name, ruller, description); country.Show();
                        }
                        else
                        {
                            Console.WriteLine("Incorrect input");
                        }
                        break;
                    case "2.13":
                        Task2.Catalogue catalog = new Task2.Catalogue();
                        do
                        {
                            Console.WriteLine("What item do you wanna add into the catalogue? 1 - Book, 2 - Article, 3 - Blog\n4 - To show all items, 5 - to find a publication by author lastname ");
                            input = Console.ReadLine();
                            if (input == "1")
                            {
                                catalog.AddPublication(new Task2.Book("BookName", "Author", 2000, "Publisher"));
                            }
                            else if (input == "2")
                            {
                                catalog.AddPublication(new Task2.Article("ArticleName", "Author", "Mag_name", "1223", 2000));
                            }
                            else if (input == "3")
                            {
                                catalog.AddPublication(new Task2.Blog("BlogName", "Aur", "link", "Publisher"));
                            }
                            else if (input == "4") catalog.ShowAll();
                            else if (input == "5")
                            {
                                Console.WriteLine("Publications with the author lastname 'Author': ");
                                if (catalog.FindAuthor("Author") == false) Console.WriteLine("Sorry, can't find it ;c");
                            }
                            else Console.WriteLine("You've chosen a wrong number");
                            Console.WriteLine("\nDo you want to continue? (Y/N)");
                            input = Console.ReadLine();
                        } while (input == "Y" || input == "Yes" || input == "y" || input == "yes");
                        break;
                    case "3.3":
                        Console.WriteLine("Input the number of elements: ");
                        uint n = uint.Parse(Console.ReadLine());
                        Console.WriteLine("Input the value of elements: ");
                        short val = short.Parse(Console.ReadLine());
                        VectorShort vector = new VectorShort(n, val);
                        Console.WriteLine("Output using foreach: ");
                        foreach (short temp in vector)
                            Console.WriteLine(temp + "");
                        Console.WriteLine("Func. FromTo:");
                        foreach (short temp in vector.FromTo(1, (int)n - 1))
                            Console.WriteLine(temp + "");
                        break;
                    default: Console.WriteLine("You've chosen a wrong number. There is no such a task"); Console.ReadLine(); break;

                }
                Console.ReadLine();
            }
        }
    }
}