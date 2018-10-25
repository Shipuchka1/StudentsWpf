using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TestWork.Model
{
    public class ModelService
    {

        public static List<Group> GetAllGroups()
        {
            List<Group> groups = JsonConvert.DeserializeObject<List<Group>>(File.ReadAllText("Groups.json"));
            foreach (Group item in groups)
            {
                item.Students = item.GetStudentsForGroup();
            }
            return groups;
        }


        public static List<Student> GetAllStudents()
        {
            List<Student> students = JsonConvert.DeserializeObject<List<Student>>(File.ReadAllText("Students.json"));
            return students;
        }
    }
}
