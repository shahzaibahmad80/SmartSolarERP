using SmartSolarERP.Data;
using SmartSolarERP.Infrastructures.Repositories;
using SmartSolarERP.Models.Entities;

namespace SmartSolarERP.Applications.VendorCategories
{
    public class VendorCategoryService : Repository<VendorCategory>
    {
        public VendorCategoryService(
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
