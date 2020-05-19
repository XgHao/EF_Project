using Microsoft.Practices.Unity.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace CodeFirst.Factories
{
    public class ContainerFactory
    {
        private static IUnityContainer unityContainer = null;
        static ContainerFactory()
        {
            ExeConfigurationFileMap fileMap = new ExeConfigurationFileMap
            {
                //配置文件路径
                ExeConfigFilename = Path.Combine(AppDomain.CurrentDomain.BaseDirectory + @"ConfigFiles\Unity.Config")
            };
            Configuration configuration = ConfigurationManager.OpenMappedExeConfiguration(fileMap, ConfigurationUserLevel.None);
            UnityConfigurationSection section = configuration.GetSection(UnityConfigurationSection.SectionName) as UnityConfigurationSection;
            unityContainer = new UnityContainer();
            section.Configure(unityContainer, "DBContainer");
        }


        public static IUnityContainer GetUnityContainer()
        {
            return unityContainer;
        }
    }
}
