using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uni2
{
    internal class clmaster
    {
        public string FName { get; set; }
        public string LName { get; set; }
        public string FatherName { get; set; }
        public Int64 Meli { get; set; }
        public string Grade { get; set; }
        public bool Gender { get; set; }
        public bool IsMarrid { get; set; }
        public Int64 pers { get; set; }
        public int date { get; set; }
        public string FullName
        {
            get
            {
                return FName + " " + LName;
            }
        }

        public string GenderName
        {
            get
            {
                if (Gender == true)
                    return "مرد";
                else
                    return "زن";
            }
        }

        public string IsMarridName
        {
            get
            {
                if (IsMarrid == true)
                    return "متأهل";
                else
                    return "مجرد";
            }
        }

       
    }
}
