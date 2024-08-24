using Masjid_Management.moque_manage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Masjid_Management
{
    public class Program
    {
        static void Main(string[] args)
        {
            Mosque masjid = new Mosque();

            int option;
            string inputNum;
            bool parseValue;
            int counter;
            do
            {

                int NoOfMember;

                Console.WriteLine("Choose your options\n1 for add member\n2 for see member list\n3 for add donar\n4 for see track donation list\n" +
                    "5 for add event\n6 for see event list\n7 for exit\n\n");
                inputNum = Console.ReadLine();
                //option = int.TryParse(inputNum, out int option);
                parseValue = int.TryParse(inputNum , out option);

                if (option == 1)
                {
                    Console.WriteLine("how many members do you want to add :");

                    int IdNo;
                    string MemberErName; 

                    inputNum = Console.ReadLine();
                    parseValue = int.TryParse(inputNum, out NoOfMember);


                    counter = 0;
                    Console.WriteLine("enter member ID and name sequentially :");

                    while (counter < NoOfMember)
                    {

                        inputNum = Console.ReadLine();
                        parseValue = int.TryParse(inputNum, out IdNo);
                        MemberErName = Console.ReadLine();
                        
                        member m1 = new member(IdNo, MemberErName);
                        masjid.AddMember(m1);

                        counter++;

                    }

                    Console.WriteLine("All members inserted successfully");
                    Console.WriteLine("----------------------***------------------\n\n");

                }

                else if(option == 2)
                {
                    masjid.MemberOfMosque();
                    Console.WriteLine("here is all member list\n\n");
                }

                else if( option ==3)
                {
                    Console.WriteLine("how many donars do you want to add :");

                    inputNum = Console.ReadLine();
                    parseValue = int.TryParse(inputNum, out NoOfMember);
                    int donarIdNo;
                    string donarErName;
                    int danErPoriman;
                    string danErDate;

                    counter = 0;
                    Console.WriteLine("enter donar ID, name, amount and date sequentially :");

                    while (counter < NoOfMember)
                    {
                        inputNum = Console.ReadLine();
                        parseValue = int.TryParse(inputNum, out donarIdNo);

                        donarErName = Console.ReadLine();

                        inputNum = Console.ReadLine();
                        parseValue = int.TryParse(inputNum, out danErPoriman);

                        danErDate = Console.ReadLine();

                        donation d1 = new donation(donarIdNo, donarErName, danErPoriman, danErDate);
                        masjid.AddDonar(d1);

                        counter++;

                    }

                    Console.WriteLine("All DONAR details inserted successfully");
                    Console.WriteLine("----------------------***------------------\n\n");
                }

                else if(option ==4)
                {
                    masjid.TrackDonation();
                    Console.WriteLine("------------------  donar list-----------------\n\n");
                }

                else if(option ==5)
                {
                    Console.WriteLine("how many events do you want to add :");

                    int noOfEvent;

                    inputNum = Console.ReadLine();
                    parseValue = int.TryParse(inputNum, out noOfEvent);

                    int eventIdNo;
                    string eventErName;
                    string eventErPlace;
                    string eventErDate;

                    counter = 0;
                    Console.WriteLine("enter event ID , name,place and date sequentially :");

                    while (counter < noOfEvent)
                    {
                        inputNum = Console.ReadLine();
                        parseValue = int.TryParse(inputNum, out eventIdNo);

                        eventErName = Console.ReadLine();
                        eventErPlace = Console.ReadLine();
                        eventErDate = Console.ReadLine();

                        Event e1 = new Event(eventIdNo, eventErName, eventErPlace, eventErDate);
                        masjid.AddEvent(e1);

                        counter++;

                    }

                    Console.WriteLine("EVENT details inserted successfully");
                    Console.WriteLine("----------------------***------------------\n\n");
                }

                else if (option == 6)
                {
                    masjid.AllEventDetails();
                    Console.WriteLine("------------------  event details end-----------------\n\n");
                }

                else
                {
                    break;
                }

            } while (option != 7);


        }
    }
}
