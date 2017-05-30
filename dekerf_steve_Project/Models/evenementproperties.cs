using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace dekerf_steve_Project.Models
{
    public class evenementproperties
    {
        [Display(Name = "start datum")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString ="{0:dd-MM-yyyy")]
        public DateTime datum { get; set; }
    }
}