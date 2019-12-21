//using Lhg.DAL;
using Lhg.IBLL;
using Lhg.IDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lhg.BLL
{
    public class StudentService : IStudentService
    {
        //public void PalyPhone(AbstractPhone phone)
        //{
        //    throw new NotImplementedException();
        //}

        /// <summary>
        /// 该方法 是针对具体细节（普通类）
        /// </summary>
        /// <param name="phone"></param>
        //public void PalyPhone(iPhone phone)
        //{
        //    Console.WriteLine($"Use {phone.GetType().Name}");
        //    phone.Call();
        //    phone.Text();
        //}

        // 能不能简单点 一个方法搞定？

        /// <summary>
        /// 该方法 是针对抽象
        /// </summary>
        /// <param name="phone"></param>
        public void Play(AbstractPhone phone)
        {
            Console.WriteLine($"Use {phone.GetType().Name}");
            phone.Call();
            phone.Text();
        }


        /// <summary>
        /// 如下采用泛型方法实现
        /// </summary>
        /// <typeparam name="T">具体类型</typeparam>
        /// <param name="phone">参数</param>
        /// <permission cref="">where T : AbstractPhone 约束T 只能是AbstractPhone极其子类</permission>
        public void PlayT<T>(T phone) where T : AbstractPhone
        {
            Console.WriteLine($"Use {phone.GetType().Name}");
            phone.Call();
            phone.Text();
        }

        public void Study()
        {
            Console.WriteLine("Study IOC+DI");
        }
    }
}
