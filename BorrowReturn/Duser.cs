using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.DirectoryServices.AccountManagement;
using System.Security.Principal;




namespace BorrowReturn
{
    public class Duser
    {
        public string UserName;
        public string FirstName;
        public string LastName;
        public string userDomainName;
        public string domainAndName;

        
        public bool RecognizeUser()
        {
            domainAndName = HttpContext.Current.User.Identity.Name.ToString();     
            string[] infoes = domainAndName.Split(new char[1] { '\\' }, StringSplitOptions.RemoveEmptyEntries);
            userDomainName = "";
            UserName = "";
            FirstName = "";
            LastName = "";
             


            if (infoes.Length > 1)
            {
                userDomainName = infoes[0];
                UserName = infoes[1];
                

                // set up domain context
                PrincipalContext ctx = new PrincipalContext(ContextType.Domain);
                // find a user
                UserPrincipal user = UserPrincipal.FindByIdentity(ctx, UserName);

                if (user != null)
                {
                    LastName = user.GivenName;
                    FirstName = user.Surname;
                    return true;
                }
                else
                {
                    FirstName = "Guest";
                    UserName = "Guest";
                    return false;
                }
            }
            else
            {
                FirstName = "Guest";
                UserName = "Guest";
                return false;
            }

        }

        public bool isAdmin()
        {
            string[] admin = { "yanwadmin", "yanw" };           //add admin here
            int length = admin.Length;
            int i;
            for (i = 0; i < length; i++)
            {
                if (UserName == admin[i])
                {
                    return true;
                   
                }
            }
            return false;
        }
    }
}