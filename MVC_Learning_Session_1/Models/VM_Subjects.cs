using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace MVC_Learning_Session_1.Models
{
    public class VM_Subjects
    {
        public int ErollmentNo { get; set; }
        public string SubjectType { get; set; }
        public string SubjectCode { get; set; }
        public string SubjectName { get; set; }

        public static List<VM_Subjects> GetSubjects()
        {
            List<VM_Subjects> list = new List<VM_Subjects>()
            {
                new VM_Subjects{ErollmentNo=101, SubjectType="C", SubjectCode="101", SubjectName="Math"},
                new VM_Subjects{ErollmentNo=101, SubjectType="C", SubjectCode="102", SubjectName="Accounts"},
                new VM_Subjects{ErollmentNo=101, SubjectType="C", SubjectCode="103", SubjectName="Stat"},
                new VM_Subjects{ErollmentNo=101, SubjectType="E1", SubjectCode="104", SubjectName="English"},
                new VM_Subjects{ErollmentNo=101, SubjectType="E1", SubjectCode="105", SubjectName="French"},
                new VM_Subjects{ErollmentNo=101, SubjectType="E2", SubjectCode="106", SubjectName="Sports"},
                new VM_Subjects{ErollmentNo=101, SubjectType="E2", SubjectCode="107", SubjectName="Communication"}
            };
            return list;
        }

    }
    public class VM_Subjects_Group
    {
        public int ErollmentNo { get; set; }
        public string SubjectType { get; set; }
        public List<SelectListItem> SubjectName { get; set; }
        public string SelectedItemName { get; set; }
        public static List<VM_Subjects_Group> GetVM_Subjects_Group()
        {
            List<VM_Subjects_Group> objSubjectGroupList = new List<VM_Subjects_Group>();
            

            List<VM_Subjects> lstSubject = VM_Subjects.GetSubjects();
            //For Compulsory Subjects
            var distinctSubjects = lstSubject.Where(m=>m.SubjectType=="C").ToList();
            foreach(var item in distinctSubjects)
            {
                List<string> objsubjist = new List<string>();
                VM_Subjects_Group obj = new VM_Subjects_Group();
                obj.ErollmentNo = 101;
                obj.SubjectType = item.SubjectType ;
                // objsubjist.Add(item.SubjectName);
                obj.SubjectName = new List<SelectListItem>();
                SelectListItem lsitem = new SelectListItem()
                {
                    Value = item.SubjectName,
                    Text = item.SubjectName
                };
                obj.SubjectName.Add(lsitem);
                objSubjectGroupList.Add(obj);
            }

            var distinctSubjectType = lstSubject.Where(m => m.SubjectType != "C").GroupBy(m => m.SubjectType).ToList();
            foreach (var item in distinctSubjectType)
            {
                var subjectNames = (from t in lstSubject where t.SubjectType == item.Key && t.SubjectType !="C" select t.SubjectName).ToList();
                VM_Subjects_Group obj = new VM_Subjects_Group();
                obj.ErollmentNo = 101;
                obj.SubjectType = item.Key;
                obj.SubjectName = new List<SelectListItem>();

                foreach (var sub in subjectNames)
                {
                    SelectListItem lsitem = new SelectListItem()
                    {
                        Value = sub,
                        Text = sub
                    };
                    obj.SubjectName.Add(lsitem);
                }
                //obj.SubjectName = subjectName.ToList();
                
                objSubjectGroupList.Add(obj);
            }

            return objSubjectGroupList;
        }
    }
    
    
}