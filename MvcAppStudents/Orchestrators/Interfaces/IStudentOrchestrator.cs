using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvcAppStudents.Models;

namespace MvcAppStudents.Orchestrators.Interfaces
{
    interface IStudentOrchestrator
    {
        StudentModel GetStudentData();
    }
}
