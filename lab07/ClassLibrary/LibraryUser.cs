using System;

namespace ClassLibrary
{
    public class LibraryUser : Person
    {
        public int Number {  get; set; }
        public DateTime DateIssue { get; set; }
        public int Price { get; set; }

        public LibraryUser()
        {

        }

        public LibraryUser(string FirstName, string LastName, DateTime dateOfBirth, int number, DateTime dateissue, int price) 
            : base(FirstName, LastName, dateOfBirth)
        {
            Number = number;
            DateIssue = dateissue;
            Price = price;
        }

        public LibraryUser(LibraryUser other) : base(other)
        {
            Number = other.Number;
            DateIssue = other.DateIssue;
            Price = other.Price;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Номер читацького квитка: {Number}");
            Console.WriteLine($"Дата видачі: {DateIssue}");
            Console.WriteLine($"Розмір щомісячного читацького внесення: {Price:C}");
        }
    }
}
