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
    
    public partial class Comment
    {
        public int CommentID { get; set; }
        public Nullable<int> PostID { get; set; }
        public string Comment1 { get; set; }
        public Nullable<int> InstructorID { get; set; }
        public Nullable<int> UserID { get; set; }
    
        public virtual Instructor Instructor { get; set; }
        public virtual Post Post { get; set; }
        public virtual UserInfo UserInfo { get; set; }
    }
}
