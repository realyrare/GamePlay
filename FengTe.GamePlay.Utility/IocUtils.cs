using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using System.Reflection;
using System.IO;

namespace FengTe.GamePlay.Utility
{

    /// <summary>
    /// 全局IoC管理器。
    /// </summary>
    public static class IocUtils
    {
        #region 变量

        /// <summary>
        /// 对象注册容器。
        /// </summary>
        private static IContainer container = null;

        #endregion

        #region IoC管理器初始化

        /// <summary>
        /// IoC管理器初始化。
        /// </summary>
        public static void Init()
        {
            //防止重复初始化。
            if (null != container)
                return;

            //创建容器对象。
            var builder = new ContainerBuilder();

            #region 程序集
            // ============ 基础程序集 ============ //           
            //服务层接口所在程序集。
            var assemblyIService = LoadAssembly("FengTe.GamePlay.IService", true);
            //服务层实现所在程序集
            var assemblyService = LoadAssembly("FengTe.GamePlay.Service", true);
            //仓储接口所在程序集。
            var assemblyIRepository = LoadAssembly("FengTe.GamePlay.IRepository", true);
            //仓储实现所在程序集。
            var assemblyRepository = LoadAssembly("FengTe.GamePlay.Repository", true);
            #endregion

            #region 注册仓储              
            builder.RegisterAssemblyTypes(assemblyIRepository, assemblyRepository).Where(t => t.Name.EndsWith("Repository")).AsImplementedInterfaces();
            #endregion
            #region 注册服务
            builder.RegisterAssemblyTypes(assemblyIService,assemblyService).Where(t => t.Name.EndsWith("Service")).AsImplementedInterfaces();

            //根据名称约定实现服务接口和服务实现的依赖。
            //  builder.RegisterAssemblyTypes(assemblyService).Where(t => t.Name.EndsWith("Service")).AsImplementedInterfaces();
            #endregion
            #region 全局对象

            ////注册缓存服务。           
            //builder.RegisterType(CoreUtils.CreateType("Differ.FrameworkDemo.PlugIns.Common.Caches.HttpRuntimeCacher", assemblyCommon)).As(typeof(ICache));
            ////注册日志服务。           
            //builder.RegisterType(CoreUtils.CreateType("Differ.FrameworkDemo.PlugIns.Common.Logs.DBLog", assemblyCommon)).As(typeof(ILog));
            ////注册配置参数服务。           
            //builder.RegisterType(CoreUtils.CreateType("Differ.FrameworkDemo.PlugIns.Common.Config.DBConfig", assemblyCommon)).As(typeof(IConfig));
            ////注册笛佛软件短信服务
            //builder.RegisterType(CoreUtils.CreateType("Differ.FrameworkDemo.PlugIns.Common.SMS.WDGJSMS", assemblyCommon)).As(typeof(ISMS));

            #endregion
            container = builder.Build();
        }

        #endregion
        #region 从容器中获取对象
        /// <summary>
        /// 从容器中获取对象。
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public static T Resolve<T>()
        {
            return (T)container.Resolve(typeof(T));
        }

        /// <summary>
        /// 从容器中获取对象。
        /// </summary>
        /// <typeparam name="T">对象类型</typeparam>
        /// <param name="serviceName">服务名称</param>
        /// <returns></returns>
        public static T ResolveNamed<T>(string serviceName)
        {
            return container.ResolveNamed<T>(serviceName);
        }

        /// <summary>
        /// 判断指定名称的服务是否已经注册。
        /// </summary>
        /// <typeparam name="T">对象类型</typeparam>
        /// <param name="serviceName">服务名称</param>
        /// <returns></returns>
        public static bool IsRegisteredWithServiceName<T>(string serviceName)
        {
            return container.IsRegisteredWithName<T>(serviceName);
        }
        #endregion
        #region 加载程序集
        /// <summary>
        /// 加载程序集。
        /// </summary>
        /// <param name="assemblyString">通过给定程序集的长格式名称加载程序集</param>
        /// <param name="isRequire">是否必须存在</param>
     
        private static Assembly LoadAssembly(string assemblyString, bool isRequire = false)
        {
            //获取当前应用程序基础目录，主要是为了判断是b/s or c/s程序。
            var baseDir = AppDomain.CurrentDomain.BaseDirectory;
            if (Directory.Exists(baseDir + @"\bin"))
                baseDir += @"\bin\";

            //如果能找到指定的dll则加载。
            if (System.IO.File.Exists(baseDir + @"\" + assemblyString + ".dll"))
                return Assembly.Load(assemblyString);
            else if (isRequire)
                throw new Exception("未找到程序集“" + assemblyString + ".dll”！");
            //  AppException.ThrowWaringException("未找到程序集“" + assemblyString + ".dll”！");

            //找不到则返回null。
            return null;
        }
        #endregion
    }
}


