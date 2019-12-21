//using Lhg.BLL;
//using Lhg.DAL;
using Lhg.IBLL;
using Lhg.IDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP
{
    class Program
    {
        static void Main(string[] args)
        {
            /// 依赖倒置

            // 非依赖倒置的调用流程
            //{
            //    StudentService service = new StudentService();
            //    service.Study();
            //    {
            //        iPhone phone = new iPhone();
            //        service.PalyPhone(phone);
            //        service.Play(phone);
            //    }
            //}

            ////依赖倒置调用流程
            //{
            //    //1、按照要求：依赖抽象，不依赖细节。注意哈 下面不能 new IStudentService() 因为接口不能被实例化
            //    IStudentService service = new StudentService();
            //    service.Study();
            //    {
            //        iPhone phone = new iPhone();
            //        //service.PalyPhone(phone);

            //    }
            //}
            //问题来了：
            //1.查看实现不方便。2.方法必须在接口声明（否则编译器不允许调用）


            /*
             * 1、将UI层BLL、DAL之间调用具体细节的东西全部去掉
             * 2、
             */
            Console.WriteLine("_______________彻底的依赖倒置___________");
            {
                //注意：这次通过工厂创建StudentService实例有个前提是需要将Lhg.BLL目录中的dll手动拷贝到DIP目录的bin中，这样工厂才能通过dll创建出实例
                //IStudentService service = Lhg.Factory.SimpleFactory.CreateStudentService();
                //AbstractPhone phone = Lhg.Factory.SimpleFactory.CreatePhone();
                IStudentService service = Lhg.Factory.SimpleFactory<IStudentService>.CreateInstance();
                AbstractPhone phone = Lhg.Factory.SimpleFactory<AbstractPhone>.CreatePhone();
                service.Play(phone);
            }
            Console.ReadKey();
        }
    }
}
