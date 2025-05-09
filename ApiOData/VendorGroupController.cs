﻿using SmartSolarERP.Applications.VendorGroups;
using SmartSolarERP.DTOs;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;

namespace SmartSolarERP.ApiOData
{
    public class VendorGroupController : ODataController
    {
        private readonly VendorGroupService _vendorGroupService;

        public VendorGroupController(VendorGroupService vendorGroupService)
        {
            _vendorGroupService = vendorGroupService;
        }

        [EnableQuery]
        public IQueryable<VendorGroupDto> Get()
        {
            return _vendorGroupService
                .GetAll()
                .Select(rec => new VendorGroupDto
                {
                    Id = rec.Id,
                    RowGuid = rec.RowGuid,
                    Name = rec.Name,
                    Description = rec.Description,
                    CreatedAtUtc = rec.CreatedAtUtc
                });
        }


    }
}
