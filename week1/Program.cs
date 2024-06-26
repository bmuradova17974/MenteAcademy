using MenteAcademy.DAL;
using MenteAcademy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenteAcademy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AddBook();

            bool delete = DeleteBook(3);
        }

        static void AddBook()
        {
            AppDbContext db = new AppDbContext();

            db.Books.Add(new Book { Name = "Chess", Genre = "Psychological Fiction", PageNumber = 101, Price = 3.40 });
            db.Books.Add(new Book { Name = "Pride and Predijuce", Genre = "Fiction, Romance Novel", PageNumber = 255, Price = 5.1 });

            db.SaveChanges();
        }

        static bool DeleteBook(int id)
        {
            AppDbContext ctx = new AppDbContext();

            Book books = ctx.Books.Find(id);
            ctx.Books.Remove(books);

            var result = ctx.SaveChanges() > 0;
            return result;

        }
    }
}
