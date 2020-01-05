using System;
using System.Collections.Generic;
using System.Text;
using TeknoLabs.DontBreakTheChain.DataAccess;
using TeknoLabs.DontBreakTheChain.Entities;

namespace TeknoLabs.DontBreakTheChain.Business
{
    public class HabitManager : IHabitService
    {
        IHabitDal _habitDal;
        public HabitManager(IHabitDal habitDal)
        {
            _habitDal = habitDal;
        }
        public void Add(Habit habit)
        {
            _habitDal.Add(habit);
        }

        public void Delete(Habit habit)
        {
            _habitDal.Delete(habit);
        }

        public List<Habit> GetAll()
        {
            return _habitDal.GetAll();
        }

        public List<Habit> GetByUserName(int userId)
        {
            return _habitDal.GetAll(k => k.UserId == userId);
        }

        public void Update(Habit habit)
        {
            _habitDal.Update(habit);
        }
    }
}
