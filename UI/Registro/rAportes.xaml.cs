using P1_AP1_Kelvin_20180193.BLL;
using P1_AP1_Kelvin_20180193.Entidades;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace P1_AP1_Kelvin_20180193.UI.Registro
{
    /// <summary>
    /// Interaction logic for rAportes.xaml
    /// </summary>
    public partial class rAportes : Window
    {
        private Aporte aporte = new Aporte();
        public class DateFormat : System.Windows.Data.IValueConverter
        {
            public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
            {
                if (value == null) return null;

                return ((DateTime)value).ToString("dd/MM/yyyy");
            }

            public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
            {
                throw new NotImplementedException();
            }
        }
        public rAportes()
        {
            InitializeComponent();
            this.DataContext = aporte;

        }

        private void Limpiar()
        {
            this.aporte = new Aporte();
            this.DataContext = aporte;
        }
        private bool Validar()
        {
            bool esValido = true;

            if (AporteIdTextBox.Text.Length == 0)
            {
                esValido = false;
                MessageBox.Show("No puede dejar campos vacios. Ingrese Id.", "Error",
                    MessageBoxButton.OK, MessageBoxImage.Warning);

            }
            if (FechaDatePicker.Text.Length == 0)
            {
                esValido = false;
                MessageBox.Show("No puede dejar campos vacios. Selecione una fecha.", "Error",
                    MessageBoxButton.OK, MessageBoxImage.Warning);

            }
            if (PersonaTextBox.Text.Length == 0)
            {
                esValido = false;
                MessageBox.Show("No puede dejar campos vacios. Ingrese una Persona.", "Error",
                    MessageBoxButton.OK, MessageBoxImage.Warning);

            }
            if (ConceptoTextBox.Text.Length == 0)
            {
                esValido = false;
                MessageBox.Show("No puede dejar campos vacios. Ingrese un concepto.", "Error",
                    MessageBoxButton.OK, MessageBoxImage.Warning);

            }
            if (MontoTextBox.Text.Length == 0)
            {
                esValido = false;
                MessageBox.Show("No puede dejar campos vacios. Ingrese un monto.", "Error",
                    MessageBoxButton.OK, MessageBoxImage.Warning);

            }

            MontoTextBox.Text = aporte.Monto.ToString("N2");
            return esValido;
        }
        private void BuscarIdButton_Click(object sender, RoutedEventArgs e)
        {
            var aporte = AporteBLL.Buscar(UtilidadesBLL.ToInt(AporteIdTextBox.Text));
            if (aporte != null)
            {
                this.aporte = aporte;
            }
            else
            {
                this.aporte = new Aporte();
                MessageBox.Show("No se ha Encontrado", "Error",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            this.DataContext = this.aporte;
        }

        private void NuevoButton_Click(object sender, RoutedEventArgs e)
        {
            Limpiar();
        }

        private void GuardarButton_Click(object sender, RoutedEventArgs e)
        {
            if (!Validar())
                return;
            var paso = AporteBLL.Guardar(aporte);
            if (paso)
            {
                Limpiar();
                MessageBox.Show("Transaccion exitosa!", "Exito",
                   MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Transaccion Fallida", "Fallo",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }


        private void EliminarButton_Click(object sender, RoutedEventArgs e)
        {
            if (AporteBLL.Eliminar(UtilidadesBLL.ToInt(AporteIdTextBox.Text)))
            {
                Limpiar();
                MessageBox.Show("Registro eliminado!", "Exito",
                MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
                MessageBox.Show("No fue posible eliminar", "Fallo",
                MessageBoxButton.OK, MessageBoxImage.Error);
        }


    }
}
