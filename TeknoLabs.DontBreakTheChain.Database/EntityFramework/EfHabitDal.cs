using TeknoLabs.Core.DataAccess;
using TeknoLabs.DontBreakTheChain.Entities;

namespace TeknoLabs.DontBreakTheChain.DataAccess.EntityFramework
{
    public class EfHabitDal : EfEntityRepositoryBase<Habit, ChainContext>, IHabitDal
    {
    }
}
