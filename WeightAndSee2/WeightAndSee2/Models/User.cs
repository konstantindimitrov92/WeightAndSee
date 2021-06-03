using System;
using System.Collections.Generic;
using System.Text;

namespace WeightAndSee2.Models
{
    public class User
    {
        public Int32 Users_ID { get; set; }

        public String Username { get; set; }
        public String Password { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime? ModifiedAt { get; set; }
    }
}
