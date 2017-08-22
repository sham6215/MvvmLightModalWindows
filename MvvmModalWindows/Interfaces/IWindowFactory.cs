using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MvvmModalWindows.Interfaces
{
    public interface IWindowFactory
    {
        IWindow CreateWindow();
        IWindow CreateWindow(Window owner);
    }
}
