﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace employable.Models
{
    public class Address
    {
        [Key]
        public int Address_id { get; set; }
        public int HouseNumber { get; set; }
        public string AptNumber { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }
    }
}