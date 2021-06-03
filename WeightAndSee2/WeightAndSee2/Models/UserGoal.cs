using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace WeightAndSee2.Models
{
    public class UserGoal: BaseModel
    {
        [ForeignKey(typeof(User))]
        public Int32 User_ID { get; set; }
        public DateTime To { get; set; }
        public Single? TargetWeight { get; set; }
        public Single? TargetBodyFat { get; set; }
    }
}
