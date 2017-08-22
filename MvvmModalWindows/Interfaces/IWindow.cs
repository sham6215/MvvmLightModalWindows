using System.Windows;

namespace MvvmModalWindows
{
    public interface IWindow
    {
        bool? ShowDialog();
    }

    public interface IChildWindow2 : IWindow
    {
    }
}
