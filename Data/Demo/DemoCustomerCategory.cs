﻿using SmartSolarERP.Applications.CustomerCategories;
using SmartSolarERP.Models.Entities;

namespace SmartSolarERP.Data.Demo
{
    public static class DemoCustomerCategory
    {
        public static async Task GenerateAsync(IServiceProvider services)
        {
            var service = services.GetRequiredService<CustomerCategoryService>();

            await service.AddAsync(new CustomerCategory { Name = "Enterprise" });
            await service.AddAsync(new CustomerCategory { Name = "Medium" });
            await service.AddAsync(new CustomerCategory { Name = "Small" });
            await service.AddAsync(new CustomerCategory { Name = "Startup" });
            await service.AddAsync(new CustomerCategory { Name = "Micro" });
        }
    }
}
