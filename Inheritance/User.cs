using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class User/* Base Class */
    {

        public User(string firstName, string lastName, string email)
        {
            /*Constructor Method --> Instance Alınırken İlk Çalışan Metotdur. */

            FirstName = firstName;
            LastName = lastName;
            Email = email;

        }

        

        /*Bu Sınıf Kullnılırken Ad Soyad Zorunlu*/
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

       public string GetFullName()
        {
            return FirstName+" "+LastName;
        }
       
       public string GetDetail()
        {
            return FirstName + " "+LastName+ " "+ Email;
        }

    }
}
