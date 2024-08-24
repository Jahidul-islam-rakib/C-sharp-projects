using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Masjid_Management.moque_manage
{
    public class donation 
    {
        public int donarId;
        public string donarName;
        public string donationDate;
        public int donationAmount;

        //public donation(int donarId, string donarName, string DonationDate) : base(donarId, donarName)
        //{
        //    donationDate = DonationDate;
        //}
        public donation(int danshilId, string danshilName, int danAmount, string danErDate)
        {
            donarId = danshilId;
            donarName = danshilName;
            donationAmount = danAmount;
            donationDate = danErDate;
        }

        public  void donarDetails()
        {
            //console.writeline($"member name is : {personname}");
            //console.writeline($"member id is : {personid}");
            //console.writeline($"member id is : {donationdate}");
            Console.WriteLine($"Donar name is : {donarName}");
            Console.WriteLine($"Donar id is : {donarId}");
            Console.WriteLine($"Donation Amount is : {donationAmount}");
            Console.WriteLine($"Donation Date is : {donationDate}");
        }


    }
}
