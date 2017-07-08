using System;
using System.Data.Entity;
using System.Diagnostics;

namespace Eventador
{
    public partial class EventadorContext : DbContext
    {
        public EventadorContext()
        {
            Database.Log = s => Console.Out.WriteLine(s);
        }

        public DbSet<Event> Events { get; set; }
        public DbSet<Attendee> Attendees { get; set; }
        public DbSet<Session> Sessions { get; set; }
        public DbSet<Accommodation> Accommodations { get; set; }
        public DbSet<Travel> Travels { get; set; }
    }
}