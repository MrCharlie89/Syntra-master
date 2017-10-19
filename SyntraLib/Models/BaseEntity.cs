using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntra.Models
{
    public class BaseEntity
    {
        public int Id { get; set; }

        public int CreatedAt { get; set; }

        public int ModifiedAt { get; set; }

        public int DeletedAt { get; set; }

        public BaseEntity()
        {
            CreatedAt = ModifiedAt = DateTime.Now;

        }

    }

}
