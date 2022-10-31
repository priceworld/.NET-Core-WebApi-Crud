using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hai.Entities.Entities
{
    public class Product
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        [StringLength(50)]
        public string? value0 { get; set; }
        [StringLength(50)]
        public string? value10 { get; set; }
        [StringLength(50)]
        public string? value2 { get; set; }
        [StringLength(50)]
        public string? value3 { get; set; }
        [StringLength(50)]
        public string? value4 { get; set; }
        [StringLength(50)]
        public string? value5 { get; set; }
        [StringLength(50)]
        public string? value6 { get; set; }
        [StringLength(50)]
        public string? value7 { get; set; }
        [StringLength(50)]
        public string? value8 { get; set; }
        [StringLength(250)]
        public string? value9 { get; set; }
        public int? ProductType { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int Status { get; set; }
    }
}
