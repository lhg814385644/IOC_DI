using Lhg.IDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lhg.DAL
{
    /// <summary>
    /// Oppo手机
    /// </summary>
    public class Oppo : AbstractPhone
    {
        public override void Call()
        {
            Console.WriteLine($"Use {this.GetType().Name} Call");

        }

        public override void Text()
        {
            Console.WriteLine($"Use {this.GetType().Name} Text");
        }
    }
}
