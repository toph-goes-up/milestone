using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Milestone.Models
{
    public class Score : IComparable
    {
        int score;
        string name;
        public int CompareTo(object obj)
        {
            return score.CompareTo((obj as Score).score);
        }
    }
}