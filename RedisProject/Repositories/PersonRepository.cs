using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedisProject.Repositories
{
    public class PersonRepository
    {
        private readonly List<Person> _persons;
        public PersonRepository()
        {
            _persons = new List<Person>() { 
            new Person{ 
            Id="100",
            FullName="Farhad Esmaeili"
            },
             new Person{
            Id="101",
            FullName="Elahe MalekNejad"
            },
              new Person{
            Id="102",
            FullName="Maya"
            }
            };
        }

        public Person GetPersonById(string id)
        {
            return _persons.Where(q => q.Id == id).FirstOrDefault();
        }
    }
    public class Person {
        public string Id { get; set; }
        public string FullName { get; set; }
    }
}
