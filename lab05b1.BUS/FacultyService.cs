using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab05b1.DAL;

namespace lab05b1.BUS
{
    public class FacultyService
    {
        public List<Faculty> GetAll()
        {
            ModelStudentDB context = new ModelStudentDB();
            return context.Faculties.ToList();
        }
    }
}
