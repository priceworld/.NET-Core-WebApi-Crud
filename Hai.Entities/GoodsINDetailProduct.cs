using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Hai.Entities
{
    public class GoodsINDetailProduct
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; } //GoodsINDetail
        public long? GoodsINId { get; set; } //GoodsINDetail
        [StringLength(36)]
        public string? THMCode { get; set; } //GoodsINDetail
        [StringLength(250)]
        public string? value9 { get; set; } //Product
        public int Qty { get; set; } //GoodsINDetail
        [StringLength(1)]
        public string IsActive { get; set; } //GoodsINDetail
        [StringLength(1)]
        public string? is_complated { get; set; } //GoodsINDetail
    }
}
