//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntityFramework_LinkedinProfiles
{
    using System;
    using System.Collections.Generic;
    
    public partial class LinkedinInterest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Nullable<int> FollowersCount { get; set; }
        public int LinkedinProfileId { get; set; }
    
        public virtual LinkedinProfile LinkedinProfile { get; set; }
    }
}
