using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusinessLayer
{
    public class StudentRegister
    {
        private DBAccess dbAccess = new DBAccess();
        public List<Student> GetAllStudents()
        {
            return dbAccess.GetAllStudents();
        }
        public void SaveStudents(List<Student> students)
        {
            foreach (Student student in students)
            {
                if (student.ID == 0)
                {
                    dbAccess.InsertStudent(student);
                }
            }
        }
    }
}
