using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public interface IApplicationDbContext
    {
        DbSet<Building> Buildings { get; set; }
        DbSet<Apartment> Apartments { get; set; }
        DbSet<Entrance> Entrances  { get; set; }
        DbSet<Customer> Customers { get; set; }
        DbSet<Deal> Deals { get; set; }
        DbSet<Document> Documents { get; set; }
        DbSet<Employee> Employees { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
