//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Referrals.ReferralsServices
{
    using System;
    using System.Collections.Generic;
    
    public partial class Status
    {
        public Status()
        {
            this.Accounts = new HashSet<Account>();
            this.AccountContacts = new HashSet<AccountContact>();
            this.Communications = new HashSet<Communication>();
            this.Communications1 = new HashSet<Communication>();
            this.Jobs = new HashSet<Job>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public string Icon { get; set; }
        public string Color { get; set; }
    
        public virtual ICollection<Account> Accounts { get; set; }
        public virtual ICollection<AccountContact> AccountContacts { get; set; }
        public virtual ICollection<Communication> Communications { get; set; }
        public virtual ICollection<Communication> Communications1 { get; set; }
        public virtual ICollection<Job> Jobs { get; set; }
    }
}
