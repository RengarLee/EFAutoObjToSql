using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFSqlLogging.Model
{
    [Table("Customers1")]
    public class Customer
    {
        [Column("CustomerID")]
        [Key]
        [Required]
        public int CustomerID { get; set; }

        [Column("CustomerName")]
        [Required]
        [StringLength(100)]
        public string FirstName { get; set; }
    }
}