using System.ComponentModel.DataAnnotations;
using System.Data;
using System.ComponentModel.DataAnnotations.Schema;
namespace ABC.Models
{
    [Table("HeThongPhanPhoi")]
     public class HeThongPhanPhoi
     {
        [Key]
        public string MaHTPP {get;set;}
        public string TenHTPP { get; set; }
   
     }
}
