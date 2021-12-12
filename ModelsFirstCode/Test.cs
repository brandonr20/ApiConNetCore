using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiConNetCore.ModelsFirstCode
{
    public class Test
    {
        [Key]
        public int Id { get; set; }

        public string Description { get; set; }

        public bool Active { get; set; }

    }
}
