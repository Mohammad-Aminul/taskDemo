using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace TaskDemo.Models
{
    public class task
    {
        [Key]
        public int id { get; set; }
        [Display(Name = "Name")]
        public string name { get; set; }
        [StringLength(200)]
        [Display(Name ="Description")]
        public string description { get; set; }
        [Display(Name = "Create Date")]
        public DateTime?  dateCreated { get; set; }
        [Display(Name = "Update Date")]
        public DateTime? dateUpdated { get; set; }
    }
}