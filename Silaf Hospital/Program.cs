using System;
using System.Collections.Generic;
using Silaf_Hospital.Models;

namespace Silaf_Hospital
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //List<Admin> admins = new List<Admin>();
            //Admin.AdminMenu(admins);

            //SuperAdmin superAdmin = new SuperAdmin("Yusuf", "super@hospital.com", "123");

            //superAdmin.doctormenu();
            SuperAdmin superAdmin = new SuperAdmin("Yusuf", "super@hospital.com", "123");
            superAdmin.Display(); 

            // Launch SuperAdmin menu


            //SuperAdmin.display();


        }
    }
}
