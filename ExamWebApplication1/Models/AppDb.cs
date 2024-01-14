using System;
using System.Collections.Generic;
<<<<<<< HEAD
using System.Configuration;
=======
>>>>>>> master
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ExamWebApplication1.Models
{
	public class AppDb:DbContext
	{
        public DbSet<Designation> Designations { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Experience> Experiences { get; set; }


        public DbSet<UserInfo> Users { get; set; }
<<<<<<< HEAD
		public AppDb():base("dbConn")
=======
		public AppDb():base("myexamappdb")
>>>>>>> master
        {
            
        }

    }
}