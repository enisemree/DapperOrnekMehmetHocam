using Business.Abstract;
using Business.Dtos;
using DataAccess.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class LessonService : ILessonService
    {
        private readonly ILessonRepository _lessonrepository;
        public LessonService(ILessonRepository lessonrepository)
        {
            _lessonrepository = lessonrepository;
        }
        public async Task<List<LessonDto>> GettAllAsync()
        {
            var data = await _lessonrepository.GetAllAsync();
            return data.Select(x=> new LessonDto
            {
                Id = x.Id,
                Name = x.Name,
                Degree = x.Degree
            }).ToList();
        }
    }
}
