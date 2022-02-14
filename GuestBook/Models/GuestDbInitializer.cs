using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GuestBook.Models
{
    public class GuestDbInitializer : DropCreateDatabaseAlways<GuestContext>
    {
        protected override void Seed(GuestContext db)
        {
            db.Guests.Add(new Guest { Name = "Гость", Email = "guest@gmail.com", Homepage = "google.com", IP ="192.168.8.8", Browser = "Opera", Text = "Текст."});

            base.Seed(db);
        }
    }    
}