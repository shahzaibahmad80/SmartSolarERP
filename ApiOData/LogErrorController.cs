using SmartSolarERP.Applications.LogErrors;
using SmartSolarERP.DTOs;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;

namespace SmartSolarERP.ApiOData
{
    public class LogErrorController : ODataController
    {
        private readonly LogErrorService _logErrorService;

        public LogErrorController(LogErrorService logErrorService)
        {
            _logErrorService = logErrorService;
        }

        [EnableQuery]
        public IQueryable<LogErrorDto> Get()
        {
            return _logErrorService
                .GetAll()
                .Select(rec => new LogErrorDto
                {
                    Id = rec.Id,
                    ExceptionMessage = rec.ExceptionMessage,
                    StackTrace = rec.StackTrace,
                    AdditionalInfo = rec.AdditionalInfo,
                    CreatedAtUtc = rec.CreatedAtUtc
                });
        }

    }
}
