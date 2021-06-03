using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace WeightAndSee2.Models
{
    public class UserDataPoint: BaseModel
    {
        [ForeignKey(typeof(User))]
        public Int32 User_ID { get; set; }
        public Single? Weight { get; set; }
        public Single? BodyFatPercentage { get; set; }
    }
}
