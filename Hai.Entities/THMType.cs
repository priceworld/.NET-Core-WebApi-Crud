using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hai.Entities.Entities
{
    public class THMType
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [StringLength(5)]
        public string THMTypeCode { get; set; }
        [StringLength(50)]
        public string? Description { get; set; }
        public decimal? Height { get; set; }
        public decimal? Weight { get; set; }
        public decimal? Width { get; set; }
        public decimal? Length { get; set; }
        [StringLength(5)]
        public string? IlaThmType { get; set; }
        public int? Status { get; set; }
    }
}
