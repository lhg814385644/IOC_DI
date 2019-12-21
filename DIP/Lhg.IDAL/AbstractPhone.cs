using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lhg.IDAL
{
    /// <summary>
    /// Phone抽象类
    /// </summary>
    public abstract class AbstractPhone
    {

        /// <summary>
        /// 打电话
        /// </summary>
        public virtual void Call()
        {
        }

        /// <summary>
        /// 发短信
        /// </summary>
        public virtual void Text()
        {

        }
    }
}
