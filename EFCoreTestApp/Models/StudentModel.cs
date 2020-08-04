using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreTestApp.Models
{
    public class StudentModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ClassId { get; set; }

        [ForeignKey(nameof(ClassId))]
        public ClassroomModel ClassroomModel { get; set; }
    }
}
