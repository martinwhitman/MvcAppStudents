using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MvcAppStudents.Enums;
using MvcAppStudents.Models;
using MvcAppStudents.Orchestrators.Interfaces;

namespace MvcAppStudents.Orchestrators
{
    public class StudentOrchestrator : IStudentOrchestrator
    {
        public StudentModel GetStudentData()
        {
            var student = new StudentModel
            {
                Age = 99,
                FirstName = "Gary",
                LastName = "Smith",
                Gender = GenderEnum.Male,
                Major = "Spanish"
            };

            return student;
        }

    }
}