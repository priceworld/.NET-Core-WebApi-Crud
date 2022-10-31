using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Hai.Entities.Entities
{
    public class GoodsIN
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long id { get; set; }
        [StringLength(50)]
        public string? OrderCode { get; set; }
        public DateTime? OrderDate { get; set; }
        [StringLength(50)]
        public string? OrderGroupNo { get; set; }
        [StringLength(50)]
        public string? OrderGroupValue { get; set; }
        public DateTime? CreatedDate { get; set; }
        [StringLength(1)]
        public string? IsActive { get; set; }
        [StringLength(1)]
        public string? IsComplated { get; set; }
        public DateTime? Eta { get; set; }
        public DateTime? Etd { get; set; }
        public int? CreatedUserId { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? UpdatedUserId { get; set; }
        public int? Status { get; set; }
    }
}
