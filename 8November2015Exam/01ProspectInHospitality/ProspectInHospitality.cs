using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01ProspectInHospitality
{
    class ProspectInHospitality
    {
        static void Main(string[] args)
        {
            decimal buildersSalary = 1500.04m;
            decimal receptionistsSalary = 2102.10m;
            decimal chambermaidsSalary = 1465.46m;
            decimal techniciansSalary = 2053.33m;
            decimal otherStaffSalary = 3010.98m;

            uint builders = uint.Parse(Console.ReadLine());           
            uint receptionists = uint.Parse(Console.ReadLine());
            uint chambermaids = uint.Parse(Console.ReadLine());
            uint technicians = uint.Parse(Console.ReadLine());
            uint otherStaffMembers = uint.Parse(Console.ReadLine());
            decimal nikkiSalary = decimal.Parse(Console.ReadLine());
            decimal currencyRate = decimal.Parse(Console.ReadLine());
            decimal mySalary = decimal.Parse(Console.ReadLine());
            decimal budget = decimal.Parse(Console.ReadLine());

            buildersSalary *= builders;
            receptionistsSalary *= receptionists;
            chambermaidsSalary *= chambermaids;
            techniciansSalary *= technicians;
            otherStaffSalary *= otherStaffMembers;
            decimal nikkiSalaryLeva = nikkiSalary * currencyRate;

            decimal moneyNeeded = buildersSalary + receptionistsSalary +
                                  chambermaidsSalary + techniciansSalary +
                                  otherStaffSalary + 
                                  nikkiSalaryLeva + mySalary;

            string answer = moneyNeeded <= budget ? "YES \\ Left" : "NO \\ Need more";
            moneyNeeded = Math.Round(moneyNeeded, 2);

            Console.WriteLine("The amount is: {0} lv.", moneyNeeded);
            Console.WriteLine("{0}: {1:F2} lv.", answer, Math.Abs(moneyNeeded - budget));
        }
    }
}
