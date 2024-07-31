using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sueldo10195594.ViewModel
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        private int sueldoTrabajador;

        [ObservableProperty]
        private int totalSueldo;

        [RelayCommand]
        private void AumentoSueldo()
        {
            if (SueldoTrabajador >= 1000)
            {
                TotalSueldo = Convert.ToInt32(SueldoTrabajador * 1.15);
            }
            else
            {
                TotalSueldo = Convert.ToInt32(SueldoTrabajador * 1.12);
            }
            
        }
    }
}
