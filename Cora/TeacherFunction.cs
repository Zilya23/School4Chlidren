using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cora.DataBase;

namespace Cora
{
    public class TeacherFunction
    {
        public static List<Teacher> GetTeacher()
        {
            return new List<Teacher>(bd_connection.connection.Teacher.ToList());
        }
    }
}
