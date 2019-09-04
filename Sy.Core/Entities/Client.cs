using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Sy.Core.Abstracts;
using System.ComponentModel.DataAnnotations.Schema;
using Sy.Core.Enums;

namespace Sy.Core.Entities
{
    [Table(name: "Clients")]
    public class Client: BaseEntity<int>
    {
        [Required, StringLength(50)]                 //boş geçilmemesi için
        public string Name { get; set; }
        [Required, StringLength(50)]
        public string Surname { get; set; }
        [Required, StringLength(50)]
        public string Password { get; set; }
        [Required, StringLength(50)]
        public string Email { get; set; }

        public ApplicationRole ApplicationRole { get; set; }

    }
}
