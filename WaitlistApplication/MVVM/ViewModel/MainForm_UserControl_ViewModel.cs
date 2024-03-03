using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaitlistApplication.MVVM.ViewModel
{
    internal class MainForm_UserControl_ViewModel
    {
        private readonly ObservableCollection<MainForm_UserControl_ItemViewModel> _waitlistView = new ObservableCollection<MainForm_UserControl_ItemViewModel>()
    {
        new MainForm_UserControl_ItemViewModel("100-14", "Coil", new DateTime(2023, 12, 5, 11, 50, 0), 30, "John Koll",
            "MMC0001000", "PickUp - Old Coil", "PickUp", "Remove - Dunnage", "Return - Coil"),
        new MainForm_UserControl_ItemViewModel("100-15", "Coil", new DateTime(2023, 12, 5, 11, 50, 0), 30, "Doyle Hammons",
            "MMC0001000", "PickUp - Old Coil", "PickUp", "Remove - Dunnage", "Return - Coil"),
        new MainForm_UserControl_ItemViewModel("100-16", "Coil", new DateTime(2023, 12, 5, 11, 50, 0), 30, "McKenna Vogel",
            "MMC0001000", "PickUp - Old Coil", "PickUp", "Remove - Dunnage", "Return - Coil")
    };

        public IEnumerable<MainForm_UserControl_ItemViewModel> WaitlistView => _waitlistView;
    }
}
