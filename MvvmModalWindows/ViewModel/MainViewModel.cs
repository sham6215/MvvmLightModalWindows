using MvvmModalWindows.Interfaces;
using MvvmModalWindows.View;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Diagnostics;
using System.Windows;

namespace MvvmModalWindows.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        IWindowFactory _childWindowFactory;
        
        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel(IWindowFactory childWindowFactory)
        {
            //Tmp = 333;
            _childWindowFactory = childWindowFactory;
            ////if (IsInDesignMode)
            ////{
            ////    // Code runs in Blend --> create design time data.
            ////}
            ////else
            ////{
            ////    // Code runs "for real"
            ////}
        }

        private RelayCommand _testButtonCommand;

        /// <summary>
        /// Gets the TestButtonCommand.
        /// </summary>
        public RelayCommand TestButtonCommand
        {
            get
            {
                return _testButtonCommand
                    ?? (_testButtonCommand = new RelayCommand(
                    () =>
                    {
                        var obj = Parent;
                        var wnd = _childWindowFactory.CreateWindow(obj);
                        wnd.ShowDialog();
                    }));
            }
        }

        private Window _Parent;

        public Window Parent
        {
            get {
                return _Parent;
            }
            set {
                _Parent = value;
            }
        }
    }
}