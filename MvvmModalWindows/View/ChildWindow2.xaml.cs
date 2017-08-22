using MahApps.Metro.Controls;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace MvvmModalWindows.View
{
    /// <summary>
    /// Interaction logic for ChildWindow2.xaml
    /// </summary>
    public partial class ChildWindow2 : MetroWindow, IChildWindow2
    {
        public ChildWindow2()
        {
            Debug.WriteLine("ChildWindow2");
            InitializeComponent();
        }
    }
}
