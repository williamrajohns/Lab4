using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab4.Models;
using Microsoft.EntityFrameworkCore;

namespace Lab4.Data
{
    public class SchoolCommunityContext : DbContext
    {
        //a.	Use lecture slides to create your data context. Remember, you need the constructor, and pay attention to inheritance.
        int StudentId;
        string CommunityId;

        public SchoolCommunityContext(int studentId, string communityId)
        {
            StudentId = studentId;
            CommunityId = communityId;

        }

        public SchoolCommunityContext(DbContextOptions<SchoolCommunityContext> options)
            : base(options)
        {

        }


        //b.	Make sure in your context you include the Constructor and the DBSet to hold your entity objects. The DBSet variables should have a plural name of entities. Like for Student model:
        //i.  public DbSet<Student> Students { get; set; }

        public DbSet<Student> Students { get; set; }
        public DbSet<Community> Communities { get; set; }
        public DbSet<CommunityMembership> CommunityMemberships { get; set; }

        //public object CommunityMemberships { get; internal set; } //unsure about this one

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //c.	Make sure the table names are not plural. You can do that by setting the proper names in OnModelCreating method. Like, for the Student model:
            //i.modelBuilder.Entity<Student>().ToTable("Student");

            modelBuilder.Entity<Student>().ToTable("Student");
            modelBuilder.Entity<Community>().ToTable("Community");
            modelBuilder.Entity<CommunityMembership>().ToTable("CommunityMembership");
            //d.	CommunityMembership should have a composite key of StudentId and CommunityId, and we need to set that using Fluent API:
            modelBuilder.Entity<CommunityMembership>()
                .HasKey(c => new { c.StudentId, c.CommunityId });

        }

        
        //public async virtual Task<List<T>> GetAllAsync()
        //{
            //return await Students.ToListAsync<T>();
        //}
        

    }
}
