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
    
    public partial class AccountProfession
    {
        public int Id { get; set; }
        public Nullable<int> AccountId { get; set; }
        public Nullable<int> ProfessionId { get; set; }
    
        public virtual Account Account { get; set; }
        public virtual Profession Profession { get; set; }
    }
}