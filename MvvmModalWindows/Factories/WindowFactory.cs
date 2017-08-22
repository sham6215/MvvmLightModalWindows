using MvvmModalWindows.Interfaces;
using System.Windows;

namespace MvvmModalWindows
{
    public class WindowFactory<TWindow>: IWindowFactory where TWindow: Window, IWindow, new()
    {
        public IWindow CreateWindow(Window owner)
        {
            TWindow wnd = new TWindow();
            if (owner != null)
            {
                wnd.Owner = Window.GetWindow(owner);
            }
            return wnd;
        }

        public IWindow CreateWindow()
        {
            return new TWindow();
        }
    }
}
