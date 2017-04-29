using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityValidation
{
    public abstract class Validator
    {
        public IList<string> Errors { get; set; }

        public Validator()
        {
                this.Errors=new List<string>();
        }

       public abstract IList<string> Validate();
    }
}
