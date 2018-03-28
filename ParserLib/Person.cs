using System;

namespace ParserLib
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string Zip { get; set; }
        public DateTime Date { get; set; }


        public override string ToString()
        {
            return $"{nameof(Id)}: {Id}, {nameof(Name)}: {Name}, {nameof(Phone)}: {Phone}, {nameof(Email)}: {Email}, {nameof(Street)}: {Street}, {nameof(City)}: {City}, {nameof(Zip)}: {Zip}, {nameof(Date)}: {Date}";
        }
    }
}