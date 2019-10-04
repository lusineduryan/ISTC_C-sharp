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
    
    public partial class GithubRepository
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GithubRepository()
        {
            this.GithubLanguages = new HashSet<GithubLanguage>();
        }
    
        public int Id { get; set; }
        public string Url { get; set; }
        public string Name { get; set; }
        public int CommitCount { get; set; }
        public int BranchCount { get; set; }
        public string Readme { get; set; }
        public int ProfileId { get; set; }
        public Nullable<int> StarsCount { get; set; }
        public Nullable<int> ContributorsCount { get; set; }
        public Nullable<int> ForksCount { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GithubLanguage> GithubLanguages { get; set; }
        public virtual GithubProfile GithubProfile { get; set; }
    }
}
