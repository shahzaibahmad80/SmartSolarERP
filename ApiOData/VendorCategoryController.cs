﻿using SmartSolarERP.Applications.VendorCategories;
using SmartSolarERP.DTOs;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;

namespace SmartSolarERP.ApiOData
{
    public class VendorCategoryController : ODataController
    {
        private readonly VendorCategoryService _vendorCategoryService;

        public VendorCategoryController(VendorCategoryService vendorCategoryService)
        {
            _vendorCategoryService = vendorCategoryService;
        }

        [EnableQuery]
        public IQueryable<VendorCategoryDto> Get()
        {
            return _vendorCategoryService
                .GetAll()
                .Select(rec => new VendorCategoryDto
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
