using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _6.EmptyModel.Models
{
    public class StudentBLL
    {
        public Student GetStudentDetails(int studentid)
        {
            Student student = new Student()
            {
                StudentId = studentid,
                Name = "MIR DA",
                Gender = "Male",
                Address = "KOLKATA",
                Class = "BTECH",
                Roll = "CS14528963",
                Dept = "CS"

            };
            return student;
        }
    }
}