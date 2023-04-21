//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MovieDatabaseSystem.Entities.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class MovieRecord
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MovieRecord()
        {
            this.MovieDescriptions = new HashSet<MovieDescription>();
        }
    
        public int Id { get; set; }
        public string Title { get; set; }
        public int Category { get; set; }
        public Nullable<System.TimeSpan> Runtime { get; set; }
        public Nullable<System.DateTime> ReleasedDate { get; set; }
        public string Director { get; set; }
        public Nullable<decimal> Rating { get; set; }
    
        public virtual MovieCategory MovieCategory { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MovieDescription> MovieDescriptions { get; set; }
    }
}
