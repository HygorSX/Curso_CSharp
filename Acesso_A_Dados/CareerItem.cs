using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcessoAosDados
{
    public class CareerItem
    {
        public Guid Id { get; set; }
        public String Title { get; set; }
        public Course Course{ get; set; }
    }
}
