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
    
    public partial class Account
    {
        public Account()
        {
            this.AccountContacts = new HashSet<AccountContact>();
            this.AccountContacts1 = new HashSet<AccountContact>();
            this.AccountLocations = new HashSet<AccountLocation>();
            this.AccountProfessions = new HashSet<AccountProfession>();
            this.Communications = new HashSet<Communication>();
            this.Communications1 = new HashSet<Communication>();
            this.Communications2 = new HashSet<Communication>();
            this.Jobs = new HashSet<Job>();
        }
    
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Firstname { get; set; }
        public string Middlename { get; set; }
        public string Lastname { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public Nullable<int> StateId { get; set; }
        public string Zipcode { get; set; }
        public Nullable<int> CountryId { get; set; }
        public string Phone { get; set; }
        public string ProfilePic { get; set; }
        public string ProfileUrl { get; set; }
        public string SendHubId { get; set; }
        public string Paypal { get; set; }
        public Nullable<int> Rating { get; set; }
        public int StatusId { get; set; }
        public bool IGetReferralSendMeTxtMsg { get; set; }
        public bool IGetReferralSendMeEmail { get; set; }
        public bool IAmReferralSendMeTxtMsg { get; set; }
        public bool IAmReferralSendMeEmail { get; set; }
        public bool IGetRolodexInviteSendMeTxtMsg { get; set; }
        public bool IGetRolodexInviteSendMeEmail { get; set; }
        public bool IGetRewardSendMeTxtMsg { get; set; }
        public bool IGetRewardSendMeEmail { get; set; }
        public bool IGetNudgeSendMeTxtMsg { get; set; }
        public bool IGetNudgeSendMeEmail { get; set; }
        public bool IGetMessageSendMeTxtMsg { get; set; }
        public bool IGetMessageSendMeEmail { get; set; }
        public bool IGetJobQuestionSendMeTxtMsg { get; set; }
        public bool IGetJobQuestionSendMeEmail { get; set; }
        public bool HidePhoneNumber { get; set; }
        public bool HideEmailAddress { get; set; }
        public System.DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime LastUpdated { get; set; }
        public string LastUpdatedBy { get; set; }
    
        public virtual Country Country { get; set; }
        public virtual State State { get; set; }
        public virtual Status Status { get; set; }
        public virtual ICollection<AccountContact> AccountContacts { get; set; }
        public virtual ICollection<AccountContact> AccountContacts1 { get; set; }
        public virtual ICollection<AccountLocation> AccountLocations { get; set; }
        public virtual ICollection<AccountProfession> AccountProfessions { get; set; }
        public virtual ICollection<Communication> Communications { get; set; }
        public virtual ICollection<Communication> Communications1 { get; set; }
        public virtual ICollection<Communication> Communications2 { get; set; }
        public virtual ICollection<Job> Jobs { get; set; }
    }
}
