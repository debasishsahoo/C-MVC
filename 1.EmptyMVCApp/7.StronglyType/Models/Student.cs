using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _7.StronglyType.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public int AddressId { get; set; }
        public string Class { get; set; }
        public string Roll { get; set; }
        public string Dept { get; set; }
        public string Gender { get; set; }
    }
}