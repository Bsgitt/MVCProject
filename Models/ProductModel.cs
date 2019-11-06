using System;
using System.ComponentModel.DataAnnotations;

namespace BollMVC.Models

{
    public class ProductModel
    {
        public int id { get; set; }
        public string productID {get;set;}
        [Required]
        public string productName {get;set;}
        public string productDetail {get;set;}
        [Required]
        public int price {get;set;}
        public int stock {get;set;}
        [Required]
        public string catagory {get;set;}
        public DateTime? createDate {get;set;}
        public DateTime? modifyDate {get;set;}

        public string coverImg {get;set;}
        
        
        
    }
    }
