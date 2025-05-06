using SmartSolarERP.Data;
using SmartSolarERP.Models.Contracts;

namespace SmartSolarERP.Infrastructures.Repositories
{
    public interface IAuditColumnTransformer
    {
        Task TransformAsync(IHasAudit entity, ApplicationDbContext context);
    }
}
