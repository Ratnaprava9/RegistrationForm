using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RegistrationForm.Data
{
    public class RegistrationFormContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public RegistrationFormContext() : base("name=RegistrationFormContext")
        {
        }

        public System.Data.Entity.DbSet<RegistrationForm.Models.Registration> Registrations { get; set; }
    }
}
