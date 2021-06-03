using System;
using System.Collections.Generic;
using System.Text;

using SQLite;
using SQLiteNetExtensions.Attributes;

namespace WeightAndSee2.Models
{
    public enum Sex 
    { 
        Male    = 0, 
        Female  = 1
    };

    public enum Division
    {
        Raw         = 0,
        Wraps       = 1,
        Equipped    = 2
    }

    public class UserProfile : BaseModel
    {
        [ForeignKey(typeof(User))]
        public Int32        User_ID     { get; set; }
       
        public Int32        Height      { get; set; }
        public Sex          Sex         { get; set; }
        public Division     Division    { get; set; }
        public DateTime?    BirthDay    { get; set; }
    }
}
