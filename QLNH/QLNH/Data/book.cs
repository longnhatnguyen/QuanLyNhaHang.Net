using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLNH.Data
{
    [Table ("book")]
    public class book
    {
        [Key]   
       public int id { get; set; }
       public String Title { get; set; }
        [MaxLength (100)]
       public String? Descriptions { get; set; }
        [Range (0, double.MaxValue)]
       public Double Price { get; set; }
        [Range (0, 1000)]
       public int Quantity { get; set; }
    }
}
