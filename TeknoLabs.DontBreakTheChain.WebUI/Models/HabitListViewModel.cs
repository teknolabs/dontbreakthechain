using System.Collections.Generic;
using TeknoLabs.DontBreakTheChain.Entities;

namespace TeknoLabs.DontBreakTheChain.WebUI.Models
{
    public class HabitListViewModel
    {
        public List<Habit> Habits { get; internal set; }
    }
}