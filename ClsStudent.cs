using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uni2
{
    internal class ClsStudent
    {
        public string FName { get; set; } //automatc property
        public string LName { get; set; }
        public string FatherName { get; set; }
        public Int64 ID { get; set; }
        public string Grade { get; set; }
        public bool Gender { get; set; }
        public bool IsMarrid { get; set; }
        public int year { get; set; }
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





        //private string fName;
        //private string LName;

        //public string FName //property
        //{
        //    get
        //    {
        //        return fName;
        //    }
        //    set
        //    {
        //        fName = value;
        //    }
        //}

        //public void SetFName(string s)
        //{
        //    this.FName = s;
        //}

        //public void SetLName(string s)
        //{
        //    LName = s;
        //}
    }
}
