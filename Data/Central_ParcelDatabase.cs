using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Central_Parcel.Models;

namespace Central_Parcel.Data
{
    public class Central_ParcelDatabase : DbContext
    {
        public Central_ParcelDatabase (DbContextOptions<Central_ParcelDatabase> options)
            : base(options)
        {
        }

        public DbSet<Central_Parcel.Models.Companies> Companies { get; set; }

        public DbSet<Central_Parcel.Models.Recievers> Recievers { get; set; }

        public DbSet<Central_Parcel.Models.Senders> Senders { get; set; }

        public DbSet<Central_Parcel.Models.Trackings> Trackings { get; set; }

        public DbSet<Central_Parcel.Models.Parcels> Parcels { get; set; }
    }
}
