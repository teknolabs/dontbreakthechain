using System;
using System.Collections.Generic;
using TeknoLabs.DontBreakTheChain.Entities;

namespace TeknoLabs.DontBreakTheChain.Business
{
    public interface IHabitService
    {
        List<Habit> GetAll();
        List<Habit> GetByUserName(int userId);
        void Add(Habit habit);
        void Update(Habit habit);
        void Delete(Habit habitId);
    }
}
