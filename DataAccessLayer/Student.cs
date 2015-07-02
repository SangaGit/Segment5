using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime DOB { get; set; }
        public decimal GradePointAverage { get; set; }
        public bool IsActive { get; set; }
        public string DateOfBirth
        {
            get { return DOB.ToShortDateString(); }
        }
        public string StudentID
        {
            get { return ID == 0 ? "New" : ID.ToString(); }
        }
    }
}
