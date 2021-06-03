using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace WeightAndSee2.Models
{
    public class BaseModel
    {
        [PrimaryKey, AutoIncrement, Unique]
        public Int64 ID { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime? ModifiedAt { get; set; }
    }
}
