using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Milestone.Models
{
    public class Scoreboard
    {
        public virtual ICollection<Score> scores { get; set; }
    }
}