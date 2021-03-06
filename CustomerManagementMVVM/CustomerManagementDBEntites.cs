﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManagementMVVM
{
	public class CustomerManagementDBEntites:DbContext
	{

			public CustomerManagementDBEntites() : base("CustomerManagementDBEntites")
			{
			}

			public DbSet<Contact> Contacts { get; set; }
			public DbSet<Customer> Customers { get; set; }

			protected override void OnModelCreating(DbModelBuilder modelBuilder)
			{
				modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
			}
		
	}
}
