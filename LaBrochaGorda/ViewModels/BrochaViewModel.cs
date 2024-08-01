using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaBrochaGorda.ViewModels
{
    partial class BrochaViewModel : ObservableObject
    {
        [ObservableProperty]
        public string cobro;
        [ObservableProperty]
        public string m2;
        [ObservableProperty]
        public string resultado;

        [RelayCommand]
        private void Calcular()
        {
            if (double.TryParse(Cobro, out double cobro) && double.TryParse(M2, out double m2))
            {
          
               double  c = cobro * m2;
                double r = c;

                Resultado = $"Cobro: {r:F2}";
            }
            else
            {
                Resultado = "Digite los datos requeridos";
            }
        }
    }
}
