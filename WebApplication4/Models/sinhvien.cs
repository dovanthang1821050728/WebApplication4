using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication4.Models
{
    [Table("sinhviens")]
    public class sinhvien
    {
        [Key]
        public int Id { get; set; }
        public string tensinhvien { get; set; }
        public string khoa { get; set; }
    }
}