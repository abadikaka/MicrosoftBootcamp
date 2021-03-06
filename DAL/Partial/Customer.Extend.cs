﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace DAL
{
    [MetadataType(typeof(CustomerMetadata))]

    public partial class Customer
    {

    }

    public class CustomerMetadata
    {

        
        [Display(Name ="Customer ID")]
        [Required(ErrorMessage ="Customer ID harus diisi")]
        [StringLength(5, ErrorMessage ="ID maks 5 karakter")]
        [Remote("CheckCustomerID","Customers",ErrorMessage ="Customer ID tersebut sudah ada. ")]
        public string CustomerID { get; set; }

        [Display(Name = "Company Name")]
        [Required(ErrorMessage = "Company Name harus diisi")]
        [StringLength(5, ErrorMessage = "Name maks 40 karakter")]
//        [Remote("CheckCompanyName", "Companies", ErrorMessage = "Company Name tersebut sudah ada. ")]
        public string CompanyName { get; set; }

    }
}
