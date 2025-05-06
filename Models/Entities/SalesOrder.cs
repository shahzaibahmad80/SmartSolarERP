using SmartSolarERP.Models.Contracts;
using SmartSolarERP.Models.Enums;

namespace SmartSolarERP.Models.Entities
{
    public class SalesOrder : _Base
    {

        /*
        Use Case: Agar tum kisi entity ka audit karna chahte ho (like CreatedOn, ModifiedBy) lekin C# model mein wo fields nahi dikhani chahte, 
        tu ye kaam Shadow Properties se ho sakta hai.
        
        Ab EF Core internally CreatedOn property ko track karega, lekin Student class mein ye field nahi milegi.
        jysy k yahan py b SalesOrder class mein CreatedByUserId,UpdatedByUserId,create/updateAtUTC property nahi hain 
        and  RowGuidID column nahi ha ,,and IsNotDeleted column nahi ha
         
         */

        public SalesOrder() { }
        public string? Number { get; set; }
        public DateTime? OrderDate { get; set; }
        public SalesOrderStatus? OrderStatus { get; set; }
        public string? Description { get; set; }
        public required int CustomerId { get; set; }
        public Customer? Customer { get; set; }
        public required int TaxId { get; set; }
        public Tax? Tax { get; set; }
        public double? BeforeTaxAmount { get; set; }
        public double? TaxAmount { get; set; }
        public double? AfterTaxAmount { get; set; }
    }
}
