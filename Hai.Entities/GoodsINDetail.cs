using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Hai.Entities.Entities
{
    public class GoodsINDetail
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long id { get; set; }
        public long? GoodsINId { get; set; }
        public long ProductId { get; set; }
        [StringLength(36)]
        public string? THMCode { get; set; }
        public int Qty { get; set; }
        [StringLength(1)]
        public string IsActive { get; set; }
        [StringLength(50)]
        public string? value0 { get; set; }
        [StringLength(36)]
        public string? value1 { get; set; }
        [StringLength(1)]
        public string? is_complated { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedUserId { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? UpdatedUserId { get; set; }
    }
}
