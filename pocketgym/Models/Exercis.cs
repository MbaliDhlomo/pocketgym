//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace pocketgym.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Exercis
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Exercis()
        {
            this.UserWorkouts = new HashSet<UserWorkout>();
        }
    
        public int ExerciseID { get; set; }
        public string ExerciseDescription { get; set; }
        public int ExerciseDuration { get; set; }
        public int Reps { get; set; }
        public Nullable<int> InstructorID { get; set; }
        public string ExerciseType { get; set; }
    
        public virtual Instructor Instructor { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserWorkout> UserWorkouts { get; set; }
    }
}
