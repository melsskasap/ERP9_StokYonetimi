using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations; //EnttitfFrameWorku Ekledikten sonra Yazdık

namespace Sy.Core.Abstracts
{
   public abstract class AuditBase
    {
        [StringLength(50)]
        public string CreatedUser { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        [StringLength(50)]
        public string UpdatedUser { get; set; }
        public DateTime? UpdatedDate { get; set; } //boş geçilebilr olduğu için ? koyduk
    }
}
