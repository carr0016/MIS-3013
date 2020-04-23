using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFStudent_Participation
{
    class Student
    {
        public int StudentID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FavoriteColor { get; set; }
        public Student ()
        {

        }
        public string toString()
        {
            return StudentID.ToString() + "," + FirstName.ToString() + "," + LastName.ToString() + "," + FavoriteColor.ToString();
        }
    }
}
