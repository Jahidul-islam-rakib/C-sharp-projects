using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Masjid_Management.moque_manage
{
    public abstract class Person
    {
        public int PersonId { get; set; }
        public string PersonName { get; set; }
        public Person(int personId, string personName)
        {
            PersonId = personId;
            PersonName = personName;
        }

        public abstract void ShowName();
    }
}
