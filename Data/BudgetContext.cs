using StudentInformation.Models;
using Microsoft.EntityFrameworkCore;

namespace HomeRenoBudget.Models
{
    //Creates a new database context named BudgetContext
    public class BudgetContext : DbContext
    {
        public BudgetContext(DbContextOptions<BudgetContext> options) : base(options)
        {
        }

        //This is where we register our models as entities
        public DbSet<Budget> Budget { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Appliance> Appliances { get; set; }
        public DbSet<Material> MAterials { get; set; }
    }
}