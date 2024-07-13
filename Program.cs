using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Intrinsics.X86;
/*task3*/
namespace book_store
{
    class book
    {
        int id;
        string name;
        string type;
        DateTime createdon;
        bool isdeleted;
        string price;
        static int selled_books = 0;



        public book()
        {
            id = 0;
            name = "unknown";
            type = "unknown";
            createdon = DateTime.MinValue;
            isdeleted = false;
            price = "unknown";
            Count();
        }
        public book(int id, string name, string type)
        {
            this.id = id;
            this.name = name;
            this.type = type;
            createdon = DateTime.MinValue;
            isdeleted = false;
            price = "unknown";
            Count();
        }


        public book(int id, string name, string type, DateTime createdon, bool isdeleted)
        {
            this.id = id;
            this.name = name;
            this.type = type;
            this.createdon = createdon;
            this.isdeleted = isdeleted;
            price = "unknown";
            Count();
        }

        public book(int Id, string Name, string Type, DateTime Createdon, bool Isdeleted, string Price)
        {
            this.id = (Id);
            this.name = (Name);
            this.type = (Type);
            this.createdon = (DateTime.MinValue);
            this.isdeleted = (Isdeleted);
            this.price = (Price);
            Count();
        }
        private static void Count()
        {
            selled_books++;
        }

        public static void printcounter()
        {
            Console.WriteLine(selled_books);
        }


        public void getdata_book()
        {
            Console.WriteLine($"Name: {name} - ID: {id} - Type: {type} - Createdon {createdon} - {isdeleted} - Price{price}");
        }

        public bool Deleted()
        {
            if (isdeleted != true) return false;
            return true;
        }



    }
    internal class Program
    {
        static void Main(string[] args)
        {
            book b1 = new book(1, "the dark tower", "action");
            book b2 = new book(2, "animals farm", "drama");
            book b3 = new book(3, "fevre dream", "action");



            book.printcounter();
            b1.getdata_book();
            b3.getdata_book();
            Console.WriteLine(b1.Deleted());

        }

    }
}
/*task1,2*/
/*namespace c__day_3
{
    class student
    {
        int id;
        string name;
        int age;

        public void getdata(int Id, string Name, int Age)
        {
            id = Id;
            name = Name;
            age = Age;

        }

        public student(int Id , string Name , int Age)
        {
            id = Id;
            name = Name;
            age = Age;

        }

        static student()
        {
            Console.WriteLine("hello ");
        }
        public void printdata()
        {
            Console.WriteLine($"{id}  -  {name}  -  {age}");
        }
        public string isroasted()
        {
            if (age > 24)
                return "graduated";

            return "still on business";
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            student s1 = new student(11,"mohamed",22 );
            student s2 = new student( );
            s1.printdata();
            Console.WriteLine(s1.isroasted());
        }
    }
}
*/