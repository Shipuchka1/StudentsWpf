using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace TestWork.Model
{
    public class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Student> Students  { get; set; }
        public Group()
        {
            Students = GetStudentsForGroup();
        }
        public List<Student> GetStudentsForGroup()
        {
            return ModelService.GetAllStudents().Where(w => w.GroupId == Id).ToList();
        }
    }

}
