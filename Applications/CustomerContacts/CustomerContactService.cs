using SmartSolarERP.Data;
using SmartSolarERP.Infrastructures.Repositories;
using SmartSolarERP.Models.Entities;

namespace SmartSolarERP.Applications.CustomerContacts
{
    public class CustomerContactService : Repository<CustomerContact>
    {
        public CustomerContactService(
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
