using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Learning_Session_1.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Subject> Subjects { get; set; }

        public static Student GetStudent()
        {
            Student obj = new Student {
                 Id=101,Name="Tapan" , Subjects= new List<Subject>{
                 new Subject{ IsSelected=true, SubjectId=1,SubjectName="Math", Status=true},
                 new Subject{ IsSelected=true,SubjectId=2,SubjectName="Science", Status=true},
                new Subject{ IsSelected=false, SubjectId=3,SubjectName="English", Status=false}
            }
        };
            return obj;
        }
    }
    public class Subject
    {
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public bool Status { get; set; }
        public bool IsSelected { get; set; }
    }

   

}