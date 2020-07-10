using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessRulesEngine
{
    public class Membership:Product,IEmail
    {
        private string memberShipType;
        public string MembershipType { get; set; }

        public Membership(string memberShipType)
        {
            if (memberShipType == "new")
                payment = new ActivateMembership();
            else if (memberShipType == "upgrade")
                payment = new UpgradeMembership();
            this.SendEmail();          
        }
        public string SendEmail()
        {
            return "Email sent to Owner";
        }
    }
}
