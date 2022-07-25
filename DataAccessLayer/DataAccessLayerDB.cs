using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Team6_API.Model;

namespace Team6_API.DataAccessLayer
{
    public class DataAccessLayerDB:DbContext
    {
        public DataAccessLayerDB(DbContextOptions<DataAccessLayerDB> options) : base(options)
        {

        }
        //Employee Table
        public DbSet<EmployeeDB> employees { get; set; }
        
        //Manager able
        public DbSet<ManagerDB> managers { get; set; }
        
        //Leave Details Table
        public DbSet<LeaveDetailsDB> leaveDetails { get; set; }
     
    
    }
}
