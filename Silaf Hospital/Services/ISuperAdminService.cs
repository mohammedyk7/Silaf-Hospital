using Silaf_Hospital.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silaf_Hospital.Services
{
    public interface ISuperAdminService
    {
        Admin CreateAdmin();  // Calls Admin.CreateFromInput()
        Branch CreateBranch(); // You can make Branch.CreateFromInput() later
    }
}
