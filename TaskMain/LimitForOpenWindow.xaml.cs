using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace TaskMain
{
    /// <summary>
    /// Interaction logic for LimitForOpenWindow.xaml
    /// </summary>
    public partial class LimitForOpenWindow : Window
    {
        static int countWindow = 0;

        private LimitForOpenWindow()
        {
            InitializeComponent();

            // We hang a handler on the event before closing the window. 
            Closing += new CancelEventHandler(Window_Closing);

            // Restoring the position on the screen.
            Left = Properties.Settings.Default.WindowPosition.Left;
            Top = Properties.Settings.Default.WindowPosition.Top;

            // Restoring the size of the window.
            Width = Properties.Settings.Default.WindowPosition.Width;
            Height = Properties.Settings.Default.WindowPosition.Height;

            // Restoring the window title.
            Title = Properties.Settings.Default.Title;
        }

        public static LimitForOpenWindow CreateWindow() 
        {
            if (countWindow < 5)
            {
                countWindow++;
                return new LimitForOpenWindow();
            }
            else 
            {
                return null;
            }
        }

        private void Window_Closing(object sender, CancelEventArgs e)
        {
            // RestoreBounds - Returns the size and position of the window before it was minimized or maximized. 
            Properties.Settings.Default.WindowPosition = this.RestoreBounds;

            // Save settings.
            Properties.Settings.Default.Save();
        }
    }
}
