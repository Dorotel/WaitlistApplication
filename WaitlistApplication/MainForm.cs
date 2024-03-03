using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WaitlistApplication.MVVM.ViewModel;

namespace WaitlistApplication
{
    public partial class MainForm : Form
    {
        public MainForm()
        {            
            InitializeComponent();
            MainForm_ElementHost.Child = new MainForm_UserControl();
        }

        private void MainForm_MenuStrip_Bottom_NewRequest_Click(object sender, EventArgs e)
        {
    

        
        }
    }
}
