using System;

namespace Adapter
{
    interface IDrive
    {
        string Move();
    }
    class Auto : IDrive
    {
        public string Move()
        {
            return "Путешественник сначало ехал по дороге на машине";
        }
    }

    interface IMovement
    {
        string Move();
    }

    class Camel : IMovement
    {
        public string Move()
        {
            return "Путешественник пересел на верблюда потому что дорога закончилась и началась пустыня";
        }
    }

    class Transport : IDrive
    {
        IMovement camel = new Camel();
        public string Move()
        {
            return camel.Move();
        }
    }
    class Traveler
    {
        IDrive drive = new Auto();
        public void Travel()
        {
            Console.WriteLine(drive.Move());
            drive = new Transport();
            Console.WriteLine(drive.Move());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Traveler traveler = new Traveler();
            traveler.Travel();
        }
    }
}
