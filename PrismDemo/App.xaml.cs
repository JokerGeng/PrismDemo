using Prism.DryIoc;
using Prism.Ioc;
using Prism.Modularity;
using PrismDemo.Module;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace PrismDemo
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App : PrismApplication
    {
        //4
        protected override Window CreateShell()
        {
            return Container.Resolve<ShellWindow>();
        }

        //2
        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            
        }

        //3
        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            //(代码方式)Code
            moduleCatalog.AddModule<ModuleA>();
            //moduleCatalog.AddModule<ModuleB>();
        }

        //(代码方式)Code
        //(配置文件)App.config
        //(磁盘目录)Disk / Directory
        //(XAML定义)XAML
        //(自定义)Custom
        //Register Catalog with PrismApplication
        //Register Modules with Catalog

        //1
        protected override IModuleCatalog CreateModuleCatalog()
        {
            //prism source code
            return new ModuleCatalog();
            //(配置文件)App.config
            //return new ConfigurationModuleCatalog();

            //(XAML定义)XAML
            //return new XamlModuleCatalog(new Uri("/ModuleA;componet/ModuleCatalog.xaml"));
        }

        /*
         * 
        public IContainerProvider Container => _containerExtension;
       
        protected virtual void Initialize()
        {
            ContainerLocator.SetContainerExtension(CreateContainerExtension);
            _containerExtension = ContainerLocator.Current;
            _moduleCatalog = CreateModuleCatalog();
            RegisterRequiredTypes(_containerExtension);
            RegisterTypes(_containerExtension);
            _containerExtension.FinalizeExtension();
            ConfigureModuleCatalog(_moduleCatalog);
            RegionAdapterMappings regionAdapterMappings = _containerExtension.Resolve<RegionAdapterMappings>();
            ConfigureRegionAdapterMappings(regionAdapterMappings);
            IRegionBehaviorFactory regionBehaviors = _containerExtension.Resolve<IRegionBehaviorFactory>();
            ConfigureDefaultRegionBehaviors(regionBehaviors);
            RegisterFrameworkExceptionTypes();
            Window window = CreateShell();
            if (window != null)
            {
                MvvmHelpers.AutowireViewModel(window);
                RegionManager.SetRegionManager(window, _containerExtension.Resolve<IRegionManager>());
                RegionManager.UpdateRegions();
                InitializeShell(window);
            }
            InitializeModules();
        }
    */
    }
}
