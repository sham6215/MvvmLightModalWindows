using MvvmModalWindows.View;
using MahApps.Metro.Controls;
using MahApps.Metro.SimpleChildWindow;
using Microsoft.Practices.ServiceLocation;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MvvmModalWindows
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //private void button_Click(object sender, RoutedEventArgs e)
        //{
        //    //Tag = this;
        //    var wnd = ServiceLocator.Current.GetInstance<IChildWindow2>();
        //    wnd.ShowDialog();

        //    //var wnd = new TestWindow() { Owner = this };
        //    //wnd.ShowDialog();

        //    //ChildWindow2 wnd2 = new ChildWindow2() { Owner = this };
        //    //wnd2.Owner = this;
        //    //wnd2.ShowDialog();
        //    //ChildWindow2 wnd2 = new ChildWindow2();

        //    //var result = this.ShowChildWindowAsync(new SimpleChildWindow() { IsModal = true });
        //}

        private void CurrentWindow_Loaded(object sender, RoutedEventArgs e)
        {
            /// Tag property is bound to ViewModel's Parent
            Tag = this;
        }
    }
}
