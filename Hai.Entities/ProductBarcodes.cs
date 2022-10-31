using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hai.Entities.Entities
{
    public class ProductBarcodes
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int? ProductId { get; set; }
        [StringLength(50)]
        public string? Barcode { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}
