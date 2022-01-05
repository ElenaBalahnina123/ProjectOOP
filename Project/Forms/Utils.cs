using ProjectOop.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.Forms
{
    /*public static class KnownRoles
    {
        public static readonly string DIRECTOR = "director";
        public static readonly string SEAMSTRESS = "seamstress";
        public static readonly string CUTTER = "cutter";
        public static readonly string DESIGNER = "designer";
        public static readonly string TECHNOLOGIST = "technologist";
    }*/

    static class Utils
    {
        /*private static string getStringValueOfRole(Role role)
        {
            switch(role)
            {
                case Role.DIRECTOR: return "director";
                case Role.CUTTER: return "cutter";
                case Role.DESIGNER: return "designer";
                case Role.SEAMSTRESS: return "seamstress";
                case Role.TECHNOLOGIST: return "technologist";
                default: throw new Exception("unknown role: " + role);
            }
        }*/

        public static bool HasRole(this Employee employee, Role chekingRole)
        {
            return employee.Role == chekingRole;
        }
    }
}
