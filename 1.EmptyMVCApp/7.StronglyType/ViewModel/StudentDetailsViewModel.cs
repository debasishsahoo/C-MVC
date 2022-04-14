using _7.StronglyType.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _7.StronglyType.ViewModel
{
    public class StudentDetailsViewModel
    {
        public Student Student { get; set; }
        public Address Address { get; set; }
        public string PageTilte { get; set; }
        public string PageHeader { get; set; }
    }
}