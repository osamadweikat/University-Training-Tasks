using BrandsShops.Api.Data;
using BrandsShops.Api.Interfaces;
using BrandsShops.Api.Models;

namespace BrandsShops.Api.Repositories
{
    public class StudentRepository : Repository<Student>, IStudentRepository
    {
        public StudentRepository(ApplicationDbContext context) : base(context)
        {
        }

    }
}
