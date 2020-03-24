using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFStudiiDeCaz
{
    public abstract class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmployeeId { get; protected set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
