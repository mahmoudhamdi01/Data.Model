using Company.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Data.Context
{
	public class CompanyDBContext : DbContext
	{
		public CompanyDBContext()
		{
		}

		public CompanyDBContext(DbContextOptions<CompanyDBContext> options) : base(options)
		{
		}
		
		public DbSet<Employee> employees { get; set; }	
		public DbSet<Department> departments { get; set; }	

		
	}
}
