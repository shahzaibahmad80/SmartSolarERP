using SmartSolarERP.Data;
using SmartSolarERP.Infrastructures.Repositories;
using SmartSolarERP.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace SmartSolarERP.Applications.Companies
{
    public class CompanyService : Repository<Company>
    {
        public CompanyService(
            ApplicationDbContext context,
            IHttpContextAccessor httpContextAccessor,
            IAuditColumnTransformer auditColumnTransformer) :
                base(
                    context,
                    httpContextAccessor,
                    auditColumnTransformer)
        {
        }

        public async Task<Company?> GetDefaultCompanyAsync()
        {
            return await _context.Company.FirstOrDefaultAsync();
        }

    }
}
