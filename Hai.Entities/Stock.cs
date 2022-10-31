using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hai.Entities.Entities
{
    public class Stock
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long StockId { get; set; }
        [StringLength(50)]
        public string? THMCode { get; set; }
        [StringLength(50)]
        public string? ProductId { get; set; }
        public int? Quantity { get; set; }
        [StringLength(10)]
        public string? QuantityType { get; set; }
        [StringLength(10)]
        public string? Lot { get; set; }
        public DateTime? ProductEndDate { get; set; }
        [StringLength(10)]
        public string? PoNumber { get; set; }
        [StringLength(10)]
        public string? BolNumber { get; set; }
        [StringLength(10)]
        public string? AsnNumber { get; set; }
        public int? Status { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedUserId { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? UpdatedUserId { get; set; }
    }
}
