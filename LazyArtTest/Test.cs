using LazyArtCore.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyArtTest
{
    [Table("A_SHOP_TEST")]
    public class A_SHOP_TEST
    {
        [Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //[Column(TypeName = "RAW(16)")]
        public Guid ID { get; set; }
        [Required]
        public required string NAME { get; set; }
    }


}
