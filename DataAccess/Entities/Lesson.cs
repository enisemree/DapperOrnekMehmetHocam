using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class Lesson : BaseEntity 
    {
        public int Name { get; set; }
        public int Degree { get; set; }
    }
}
