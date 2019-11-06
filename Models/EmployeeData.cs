using System;
using System.ComponentModel.DataAnnotations;

namespace BollMVC.Models
{
    public class EmployeeData
    {
        public int id { get; set; }
        [Required]
        public string firstname { get; set; } 
        public string lastname { get; set; } 
        public string coverImg { get; set; }
        [Required]
        public DateTime? releaseDate { get; set; }
        [Required]
        public string position { get; set; } 
        public string address { get; set; } 
        public string salary { get; set; } 
        public string age { get; set; } 
        
        public DateTime? createDate { get; set; }
        public DateTime? modifyDate { get; set; }
    }
}