using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DataAccessLayer;


namespace BusinessAccessLayer
{
    public class clsUser
    {

        public int userID { set; get; }
        public string firstName { set; get; }
        public string lastName { set; get; }
        public string username { set; get; }
        public string password { set; get; }
        public string email { set; get; }
        public bool isActive { set; get; }

        public clsUser()
        {
            this.userID = -1;
            this.firstName = "";
            this.lastName = "";
            this.username = "";
            this.password = "";
            this.email = "";
            this.isActive = false;

        }

        private clsUser(int userID, string firstName, string lastName, string username, string password, string email , bool isActive)
        {
            this.userID = userID;
            this.firstName = firstName;
            this.lastName = lastName;
            this.username = username;
            this.password = password;
            this.email = email;
            this.isActive = isActive;
        }


        static public clsUser login(string username, string password)
        {
            int userID = -1;
            string firstName = "", lastName = "", email = "";
            bool isActive = false;

            if(clsUserDataAccess.doesUserExist(ref userID,ref firstName, ref lastName, ref username, ref password, ref email, ref isActive))
            {
                return new clsUser(userID, firstName, lastName, username, password, email, isActive);
            }            


            return null;
        }


        static public bool recordSuccessfullLogin(int userID , DateTime loginDate)
        {
            return clsUserDataAccess.recordSuccessfullLogin(userID, loginDate);
        }


    }
}
