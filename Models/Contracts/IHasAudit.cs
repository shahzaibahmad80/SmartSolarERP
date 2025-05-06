using System.ComponentModel.DataAnnotations.Schema;

namespace SmartSolarERP.Models.Contracts
{
    public interface IHasAudit
    {
        //Shadow Properties. concept>  Shadow Properties – “Chhupi hui properties jo model mein nahi hoti”
        /*Shadow properties wo properties hoti hain:
         * 
         * Jo C# class mein nahi likhi hoti
         * Lekin EF Core unhein database mein track karta hai
         * Use Case: Agar tum kisi entity ka audit karna chahte ho (like CreatedOn, ModifiedBy) 
         * lekin C# model mein wo fields nahi dikhani chahte, tu ye kaam Shadow Properties se ho sakta hai.
         * modelBuilder.Entity<Student>()
            .Property<DateTime>("CreatedOn");
         * Ab EF Core internally CreatedOn property ko track karega, lekin Student class mein ye field nahi milegi.
         
         */
        string? CreatedByUserId { get; set; }
        DateTime? CreatedAtUtc { get; set; }
        string? UpdatedByUserId { get; set; }
        DateTime? UpdatedAtUtc { get; set; }



        //not mapped



        [NotMapped]
        string? CreatedByUserName { get; set; }
        [NotMapped]
        string? UpdatedByUserName { get; set; }
        [NotMapped]
        string? CreatedAtString { get; set; }
        [NotMapped]
        string? UpdatedAtString { get; set; }
    }
}
