using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C5Form.InternalClasses
{
    class Person
    {
        public int PersonId { get; set; }
        public string PersonCode { get; set; }
        public string PersonFirstName { get; set; }
        public string PersonLasttName { get; set; }
        public DateTime PersonBirthDay { get; set; }
    }
    class AutoPerson
    {
        public int PersonId { get; set; }
        public int AutoId { get; set; }

    }
    class Auto
    {
        public int AutoId { get; set; }
        public string AutoNumber { get; set; }
        public string AutoType { get; set; }
        public string AutoModel { get; set; }
        public DateTime DateOfMade { get; set; }

    }
    class MainClasses
    {

    }
}
