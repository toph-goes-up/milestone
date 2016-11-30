using Milestone.Models;
using System.Data.Entity;

namespace Milestone.Models
{
    public class ScoreboardContext : DbContext
    {
        public ScoreboardContext() : base("ScoreboardContext")
        {

        }

    }
}