using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace lab13mvm
{
    public class ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private Modelo _modelo;
        private string _resultado;

        public ViewModel()
        {
            _modelo = new Modelo();
            SumarCommand = new Command(OnSumar);
            MultiplicarCommand = new Command(OnMultiplicar);
        }

        public double Valor1
        {
            get { return _modelo.Valor1; }
            set
            {
                if (_modelo.Valor1 != value)
                {
                    _modelo.Valor1 = value;
                    OnPropertyChanged(nameof(Valor1));
                }
            }
        }

        public double Valor2
        {
            get { return _modelo.Valor2; }
            set
            {
                if (_modelo.Valor2 != value)
                {
                    _modelo.Valor2 = value;
                    OnPropertyChanged(nameof(Valor2));
                }
            }
        }

        public double Valor3
        {
            get { return _modelo.Valor3; }
            set
            {
                if (_modelo.Valor3 != value)
                {
                    _modelo.Valor3 = value;
                    OnPropertyChanged(nameof(Valor3));
                }
            }
        }

        public string Resultado
        {
            get { return _resultado; }
            set
            {
                if (_resultado != value)
                {
                    _resultado = value;
                    OnPropertyChanged(nameof(Resultado));
                }
            }
        }

        public ICommand SumarCommand { get; }
        public ICommand MultiplicarCommand { get; }

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void OnSumar()
        {
            double resultado = Sumar();
            Resultado = $"Resultado Suma: {resultado}";
        }

        private void OnMultiplicar()
        {
            double resultado = Multiplicar();
            Resultado = $"Resultado Multiplicación: {resultado}";
        }

        public double Sumar()
        {
            return Valor1 + Valor2 + Valor3;
        }

        public double Multiplicar()
        {
            return Valor1 * Valor2 * Valor3;
        }
    }
}

