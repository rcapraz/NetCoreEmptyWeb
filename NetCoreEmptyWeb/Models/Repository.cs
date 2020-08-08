using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreEmptyWeb.Models
{
    public class Repository
    {
        private static List<StudentResponse> _students = new List<StudentResponse>(); //bir liste oluşturup ismine _students verdik
        public static List<StudentResponse> Students //başka bir liste oluşturup ismine Students verdik
        {
            get
            {
                return _students; //bu listenin _students listesini göndermesini istedik
            }
        }
        public static void AddStudent(StudentResponse student) //yeni öğrenci ekleme
        {
            _students.Add(student);
        }
    }
}
