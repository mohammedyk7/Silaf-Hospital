using Silaf_Hospital.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silaf_Hospital.Services
{
    public interface IAdminService
    {
        void AddAdmin(Admin admin);
        Admin GetAdminByEmail(string email);
        List<Admin> GetAllAdmins();
    }
}
