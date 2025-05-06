using SmartSolarERP.Applications.AdjustmentMinuss;
using SmartSolarERP.Applications.AdjustmentPluss;
using SmartSolarERP.Applications.ApplicationUsers;
using SmartSolarERP.Applications.Companies;
using SmartSolarERP.Applications.CustomerCategories;
using SmartSolarERP.Applications.CustomerContacts;
using SmartSolarERP.Applications.CustomerGroups;
using SmartSolarERP.Applications.Customers;
using SmartSolarERP.Applications.DeliveryOrders;
using SmartSolarERP.Applications.GoodsReceives;
using SmartSolarERP.Applications.InventoryTransactions;
using SmartSolarERP.Applications.LogAnalytics;
using SmartSolarERP.Applications.LogErrors;
using SmartSolarERP.Applications.LogSessions;
using SmartSolarERP.Applications.NumberSequences;
using SmartSolarERP.Applications.ProductGroups;
using SmartSolarERP.Applications.Products;
using SmartSolarERP.Applications.PurchaseOrderItems;
using SmartSolarERP.Applications.PurchaseOrders;
using SmartSolarERP.Applications.PurchaseReturns;
using SmartSolarERP.Applications.SalesOrderItems;
using SmartSolarERP.Applications.SalesOrders;
using SmartSolarERP.Applications.SalesReturns;
using SmartSolarERP.Applications.Scrappings;
using SmartSolarERP.Applications.StockCounts;
using SmartSolarERP.Applications.Taxes;
using SmartSolarERP.Applications.TransferIns;
using SmartSolarERP.Applications.TransferOuts;
using SmartSolarERP.Applications.UnitMeasures;
using SmartSolarERP.Applications.VendorCategories;
using SmartSolarERP.Applications.VendorContacts;
using SmartSolarERP.Applications.VendorGroups;
using SmartSolarERP.Applications.Vendors;
using SmartSolarERP.Applications.Warehouses;
using SmartSolarERP.Infrastructures.Countries;
using SmartSolarERP.Infrastructures.Currencies;
using SmartSolarERP.Infrastructures.Docs;
using SmartSolarERP.Infrastructures.Emails;
using SmartSolarERP.Infrastructures.Images;
using SmartSolarERP.Infrastructures.Repositories;
using SmartSolarERP.Infrastructures.TimeZones;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace SmartSolarERP
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddAllCustomServices(this IServiceCollection services)
        {
            services.AddTransient<IActionContextAccessor, ActionContextAccessor>();
            services.AddScoped<IEmailSender, SMTPEmailService>();
            services.AddScoped<IFileImageService, FileImageService>();
            services.AddScoped<IFileDocumentService, FileDocumentService>();
            services.AddScoped<ITimeZoneService, TimeZoneService>();
            services.AddScoped<ICountryService, CountryService>();
            services.AddScoped<ICurrencyService, CurrencyService>();
            services.AddScoped<IAuditColumnTransformer, AuditColumnTransformer>();
            services.AddScoped<CompanyService>();
            services.AddScoped<ApplicationUserService>();
            services.AddScoped<NumberSequenceService>();
            services.AddScoped<LogErrorService>();
            services.AddScoped<LogSessionService>();
            services.AddScoped<LogAnalyticService>();
            services.AddScoped<CustomerGroupService>();
            services.AddScoped<CustomerCategoryService>();
            services.AddScoped<VendorGroupService>();
            services.AddScoped<VendorCategoryService>();
            services.AddScoped<WarehouseService>();
            services.AddScoped<CustomerService>();
            services.AddScoped<VendorService>();
            services.AddScoped<UnitMeasureService>();
            services.AddScoped<ProductGroupService>();
            services.AddScoped<ProductService>();
            services.AddScoped<CustomerContactService>();
            services.AddScoped<VendorContactService>();
            services.AddScoped<TaxService>();
            services.AddScoped<SalesOrderService>();
            services.AddScoped<SalesOrderItemService>();
            services.AddScoped<PurchaseOrderService>();
            services.AddScoped<PurchaseOrderItemService>();
            services.AddScoped<InventoryTransactionService>();
            services.AddScoped<DeliveryOrderService>();
            services.AddScoped<GoodsReceiveService>();
            services.AddScoped<SalesReturnService>();
            services.AddScoped<PurchaseReturnService>();
            services.AddScoped<TransferInService>();
            services.AddScoped<TransferOutService>();
            services.AddScoped<StockCountService>();
            services.AddScoped<AdjustmentMinusService>();
            services.AddScoped<AdjustmentPlusService>();
            services.AddScoped<ScrappingService>();

            return services;
        }
    }
}
