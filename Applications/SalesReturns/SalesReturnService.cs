using SmartSolarERP.Data;
using SmartSolarERP.Infrastructures.Repositories;
using SmartSolarERP.Models.Entities;

namespace SmartSolarERP.Applications.SalesReturns
{
    public class SalesReturnService : Repository<SalesReturn>
    {
        public SalesReturnService(
            ApplicationDbContext context,
            IHttpContextAccessor httpContextAccessor,
            IAuditColumnTransformer auditColumnTransformer) :
                base(
                    context,
                    httpContextAccessor,
                    auditColumnTransformer)
        {
        }


    }
}
