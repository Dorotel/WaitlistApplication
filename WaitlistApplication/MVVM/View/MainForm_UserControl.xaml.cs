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
using WaitlistApplication.MVVM.ViewModel;

namespace WaitlistApplication
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class MainForm_UserControl : UserControl
    {
        public MainForm_UserControl()
        {
            InitializeComponent();
            DataContext = new MainForm_UserControl_ViewModel();
        }
    }
}
