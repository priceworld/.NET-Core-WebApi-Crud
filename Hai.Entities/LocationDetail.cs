using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hai.Entities.Entities
{
    public class LocationDetail
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long id { get; set; }
        public long LocationId { get; set; }
        [StringLength(5)]
        public string THMType { get; set; }
        [StringLength(50)]
        public string? THMCode { get; set; }
        public int? SeparteId { get; set; }
        public int? LocStatus { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        [StringLength(1)]
        public string Status { get; set; }
    }
}
