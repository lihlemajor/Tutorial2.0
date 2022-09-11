using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Tutorial2._0
{
    public class StudentRepo
    {


        public string SaveStudent(int Id, string name, string lastname, int age) { 
       
            
            Student st1 = new Student();
              int _Id = st1.Id = Id;

            string _Name = st1.Name = name;
            string _lastname = st1.lastname = lastname;
            int _age = st1.age = age;

            return _Id + " " + _Name + " " + _lastname + " " + _age;




        }
    }
}
