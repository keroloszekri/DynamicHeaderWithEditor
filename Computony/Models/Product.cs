using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Computony.Models
{
    public class Product
    {
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        public int SubCatID { get; set; }
        [ForeignKey("SubCatID")]
        public virtual SubCat SubCat { get; set; }

        [AllowHtml]
        public string Content { get; set; }
    }
}