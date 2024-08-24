using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Masjid_Management.moque_manage
{
    public class member : Person
    {
        public member( int id , string name ) : base(  id, name)
        {

        }

        public override void ShowName()
        {
            Console.WriteLine($"Member name is : {PersonName}");
            Console.WriteLine($"Member ID is : {PersonId}");

        }
    }
}
