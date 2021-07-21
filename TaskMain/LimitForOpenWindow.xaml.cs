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
    }
}
