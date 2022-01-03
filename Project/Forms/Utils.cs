using ProjectOop.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.Forms
{
    public static class KnownRoles
    {
        public static readonly string DIRECTOR = "director";
    }

    static class Utils
    {
        public static bool HasRole(this Employee employee, string RoleName)
        {
            return (from role in employee.post.Roles where role.Name == RoleName select role).Count() > 0;
        }
    }
}
