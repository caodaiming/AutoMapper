using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMapper.Demo
{
    class Program
    {
        static Program() {
            AutoMapper.Mapper.CreateMap<Person,PersonDTO>();
            AutoMapper.Mapper.CreateMap<PersonDTO,Person>();
        }
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Birthday = DateTime.Now;
            person.Name = "cao";

            PersonDTO tsource = Mapper.Map<PersonDTO>(person);

            Console.WriteLine("姓名："+tsource.Name+"  "+"出生年月："+tsource.Birthday);
        }
    }
}
