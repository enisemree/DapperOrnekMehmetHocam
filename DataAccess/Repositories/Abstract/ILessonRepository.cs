using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories.Abstract
{
    public interface ILessonRepository
    {
        Task<List<Lesson>> GetAllAsync();

        Task<List<Lesson>> GetAsync(int id);
        Task<Lesson> GetByIdAsync(int id);
    }
}
