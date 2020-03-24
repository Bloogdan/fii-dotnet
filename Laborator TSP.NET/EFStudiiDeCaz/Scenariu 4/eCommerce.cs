using System.ComponentModel.DataAnnotations.Schema;

namespace EFStudiiDeCaz
{
    [Table("eCommerce", Schema = "BazaDeDate")]
    public class eCommerce : Business
    {
        public string URL { get; set; }
    }
}
