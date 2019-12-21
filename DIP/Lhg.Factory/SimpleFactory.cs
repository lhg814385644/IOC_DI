using Lhg.IBLL;
using Lhg.IDAL;
using System;
using System.Reflection;

namespace Lhg.Factory
{
    /// <summary>
    /// 简单工厂
    /// 既不想依赖细节，又想创建实例（可以采用反射来创建）
    /// </summary>
    public class SimpleFactory<T> //where T : AbstractPhone, IStudentService
    {
        //读取配置文件
        private static string IStudentServiceAssembly = System.Configuration.ConfigurationManager.AppSettings["IStudentServiceAssembly"];
        private static string AbstractPhoneAssembly = System.Configuration.ConfigurationManager.AppSettings["AbstractPhoneAssembly"];

        //根据T读取对应的配置文件
        private static string DllType = System.Configuration.ConfigurationManager.AppSettings[$"{typeof(T).Name}Assembly"];

        /// <summary>
        /// 泛型方式创建实例
        /// </summary>
        /// <returns></returns>
        public static T CreateInstance()
        {
            Assembly assembly = Assembly.Load(DllType.Split(',')[1]);
            Type type = assembly.GetType(DllType.Split(',')[0]);
            return (T)Activator.CreateInstance(type); //创建实例
        }

        /// <summary>
        /// 创建IStudentService实例
        /// </summary>
        /// <returns></returns>
        public static IStudentService CreateStudentService()
        {
            Assembly assembly = Assembly.Load(IStudentServiceAssembly.Split(',')[1]); //加载程序集
            Type type = assembly.GetType(IStudentServiceAssembly.Split(',')[0]); //加载类型
            return (IStudentService)Activator.CreateInstance(type); //创建实例
        }

        /// <summary>
        /// 创建AbstractPhone子类的实例
        /// </summary>
        /// <returns></returns>
        public static AbstractPhone CreatePhone()
        {
            Assembly assembly = Assembly.Load(AbstractPhoneAssembly.Split(',')[1]);
            Type type = assembly.GetType(AbstractPhoneAssembly.Split(',')[0]);
            return (AbstractPhone)Activator.CreateInstance(type);
        }


    }
}
