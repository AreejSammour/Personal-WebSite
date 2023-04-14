using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using SammourProfile.Models;

namespace SammourProfile.Data
{
	public class ApplicationDbContext : DbContext
	{
		public DbSet<Skill> Skills { get; set; }
		public DbSet<Contact> Contacts { get; set; }
		public DbSet<Expertise> Expertises { get; set; }
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
		{
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			Skill Skill1 = new Skill() { Id = 1, Name = "C-Sharp", 
				Description = "C# is a simple & powerful object-oriented programming language developed by Microsoft. C# can be used to create various types of applications, such as web, windows, console applications, or other types of applications using Visual studio.", ImageURL = "/images/C-Sharp.png" };
			Skill Skill2 = new Skill() { Id = 2, Name = "SQL", 
				Description = "Structured Query Language (SQL) is a standardized programming language that is used to manage relational databases and perform various operations on the data in them.", ImageURL = "/images/SQL.png"};
			Skill Skill3 = new Skill() { Id = 3, Name = "HTML", 
				Description = "HTML (HyperText Markup Language) is the most basic building block of the Web. It defines the meaning and structure of web content.", ImageURL = "/images/HTML.png" };
			
			modelBuilder.Entity<Skill>().HasData(Skill1, Skill2, Skill3);


			Expertise Exp1 = new Expertise() { Id =1, Date= "Sep 2022", Field= "Web developer", 
				Description= "I started studying Web developer at TUC Yrkeshögskola and is expected to finish in Jun 2024:  (Design & UX)-(HTML & CSS)-(C#)-(ASP Net Core)-(JavaScript)-(DataBase)"
            };
			
			Expertise Exp2 = new Expertise() { Id =2, Date = "Jun 2022", Field = "Web development", 
				Description = "I finished studying General course - IT / Web (Web development) at Mullsjö Folkhögskola."
            };
			
			Expertise Exp3 = new Expertise() { Id =3, Date ="Sep 2020", Field = "Move to Sweden", 
				Description = "I moved to live in Sweden (New culture - New Challenges)" };

			modelBuilder.Entity<Expertise>().HasData(Exp1, Exp2, Exp3);
			
		}
	}
}
