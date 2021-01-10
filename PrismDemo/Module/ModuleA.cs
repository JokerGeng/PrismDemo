using Prism.Ioc;
using Prism.Modularity;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismDemo.Module
{
    public class ModuleA : IModule
    {

        private readonly IRegionManager _regionManager;

        public ModuleA(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        /// <summary>
        /// 通知模块已被初始化
        /// </summary>
        /// <param name="containerProvider"></param>
        public void OnInitialized(IContainerProvider containerProvider)
        {
            //注册区域
            _regionManager.RegisterViewWithRegion("ContentRegion", typeof(Content));
        }

        /// <summary>
        /// 用于在应用程序将使用的容器中注册类型
        /// </summary>
        /// <param name="containerRegistry"></param>
        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            //注册ViewModel
            ViewModelLocationProvider.Register<Content, ContentViewModel>();

            //指定ViewModel
            containerRegistry.RegisterForNavigation<NavigationView, NavigationViewModel>();
            //指定ViewModel,添加别名
            //containerRegistry.RegisterForNavigation<NavigationView, NavigationViewModel>("Navigation");
        }


    }
}
