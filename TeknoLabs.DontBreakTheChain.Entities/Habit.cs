using System;
using TeknoLabs.Core;

namespace TeknoLabs.DontBreakTheChain.Entities
{
    public class Habit : IEntity
    {
        public int HabitId { get; set; }
        public string Name { get; set; }
        public int? UserId{ get; set; }
    }
}
