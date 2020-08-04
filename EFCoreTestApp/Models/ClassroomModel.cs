using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreTestApp.Models
{
    public class ClassroomModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<StudentModel> Students { get; set; }
    }
}
