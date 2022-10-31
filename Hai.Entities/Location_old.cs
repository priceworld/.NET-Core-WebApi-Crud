using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hai.Entities.Entities
{
    public class Location_old
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long id { get; set; }
        [StringLength(20)]
        public string? LocAisle { get; set; }
        [StringLength(20)]
        public string? LocArea { get; set; }
        public int? LocZoneId { get; set; }
        public int? Loc_X { get; set; }
        public int? Loc_Y { get; set; }
        public int? Loc_Z { get; set; }
        [StringLength(1)]
        public string? Loc_R { get; set; }
        [StringLength(5)]
        public string? THMType { get; set; }
        public int? Blocked { get; set; }
        [StringLength(5)]
        public string? RezProductCategoryId { get; set; }
        [StringLength(5)]
        public string? RezTHMType { get; set; }
        public decimal? MinWeight { get; set; }
        public decimal? MaxWeight { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int Status { get; set; }
    }
}
