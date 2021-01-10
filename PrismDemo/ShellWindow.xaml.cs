using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace PrismDemo
{
    /// <summary>
    /// ShellWindow.xaml 的交互逻辑
    /// </summary>
    public partial class ShellWindow : Window
    {
        public ShellWindow(IRegionManager regionManager)
        {
            InitializeComponent();

            //为界面的元素注册区域

            //使用xaml创建Region
            //RegionManager.SetRegionName(Header, "HeaderRegion");
            //使用代码创建Region
            RegionManager.SetRegionName(Menu, "MenuRegion");
            RegionManager.SetRegionName(Content, "ContentRegion");

            //为指定区域指定页面
            regionManager.RegisterViewWithRegion("HeaderRegion", typeof(Header));
            regionManager.RegisterViewWithRegion("MenuRegion", typeof(Menu));
            //regionManager.RegisterViewWithRegion("ContentRegion", typeof(Content));
        }
    }
}
