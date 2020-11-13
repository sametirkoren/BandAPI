using BandAPI.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BandAPI.DbContexts
{
    public class BandAlbumContext  : DbContext
    {
        public BandAlbumContext(DbContextOptions<BandAlbumContext>  options) : base(options)
        {

        }

        public DbSet<Band> Bands { get; set; }

        public DbSet<Album> Albums { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Seed Data Create
            modelBuilder.Entity<Band>().HasData(new Band()
            {
                Id = Guid.Parse("9433d064-bb01-46bf-a2af-b57fe93f5da1"),
                Name = "Metallica",
                Founded = new DateTime(1980, 1, 1),
                MainGenre = "Heavy Metal",
            },
            new Band
            {
                Id = Guid.Parse("56b8cbac-c3a4-4717-9dba-3724e8d0543b"),
                Name = "Guns N Roses",
                Founded = new DateTime(1985, 2, 1),
                MainGenre = "Rock"
            },
            new Band
            {
                Id = Guid.Parse("9e7bece4-765d-48b6-a56c-6fb237b07a1f"),
                Name = "TalKing Gunz",
                Founded = new DateTime(1997, 3, 1),
                MainGenre = "Rap"
            });


            modelBuilder.Entity<Album>().HasData(new Album() 
            { 
                Id= Guid.Parse("b1256790-99f3-461c-8601-c9326e1b026f"),
                Title="Master Of Puppets",
                Description = "One of the best heavy metal albums ever",
                BandId = Guid.Parse("9433d064-bb01-46bf-a2af-b57fe93f5da1")

            },
            new Album
            {
                Id = Guid.Parse("1b515fc1-2b9b-4256-959f-76ea6fa07e94"),
                Title = "Appetite for Destruction",
                Description = "Amazing Rock album with raw sound",
                BandId = Guid.Parse("56b8cbac-c3a4-4717-9dba-3724e8d0543b")
            },
            new Album
            {
                Id = Guid.Parse("68bba4bc-d02c-4cde-a513-993073495b04"),
                Title = "Nows Da Time",
                Description = "Amazing Rap album with raw sound",
                BandId = Guid.Parse("9e7bece4-765d-48b6-a56c-6fb237b07a1f")
            }

            );
       }
    }
}
