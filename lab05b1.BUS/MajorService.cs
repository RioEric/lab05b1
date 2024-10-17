using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab05b1.DAL;

namespace lab05b1.BUS
{
    public class MajorService
    {
        public List<Major> GetAllByFaculty(int facultyID)
        {
            ModelStudentDB context = new ModelStudentDB();
            return context.Majors.Where(p => p.FacultyID == facultyID).ToList();
        }
    }
}
