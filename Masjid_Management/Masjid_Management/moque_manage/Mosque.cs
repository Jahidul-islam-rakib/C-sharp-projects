using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Masjid_Management.moque_manage
{
    public class Mosque
    {
        public List<Person> personList = new List<Person>();
        public List<Event> eventList = new List<Event>();
        public List<donation>donarList = new List<donation>();

        public void AddMember(Person manush)
        {
            personList.Add(manush);
            Console.WriteLine($"Manusher nam has been added ");
        }

        public void AddEvent(Event onusthan)
        {
            eventList.Add(onusthan);
            Console.WriteLine($"Onusthan er nam add hoise");
        }

        public void AddDonar(donation donar)
        {
            donarList.Add(donar);
            Console.WriteLine($"Donor er nam add hoise");
        }

        public void MemberOfMosque()
        {
            Console.WriteLine("\n\nmembers are: ------------>>>");
            Console.WriteLine("Person Name      Person Id");
            foreach (Person monu in personList)
            {
                Console.WriteLine($"{monu.PersonName}      {monu.PersonId}");

            }

            Console.WriteLine("----------------------***------------------");
        }

        public void TrackDonation()
        {
            Console.WriteLine("\n\ndonars are:---------------->>>>>");
            Console.WriteLine("Donor Name       ID      Amount      Date");
            foreach (donation bekti in donarList)
            {
                Console.WriteLine($"{bekti.donarName}   {bekti.donarId}     {bekti.donationAmount}      {bekti.donationDate}");

            }

            Console.WriteLine("----------------------***------------------");
        }

        public void AllEventDetails()
        {
            Console.WriteLine("\n\nEvents are:----------->>>>>");
            Console.WriteLine("Event Name       ID      Date        Place");
            foreach (Event ayojon in eventList)
            {
                Console.WriteLine($"ayojon name : {ayojon.eventName}        {ayojon.eventId}        {ayojon.eventDate}      {ayojon.eventPlace}");

            }

            Console.WriteLine("----------------------***------------------");
        }
    }
}
