using System;
using System.Collections.Generic;
using System.Text;

using SQLite;
namespace WeightAndSee2.Models
{
    public class User : BaseModel
    {
        [MaxLength(255)]
        public String       Username { get; set; }
        [MaxLength(255)]
        public String       Password { get; set; }
    }
}
