using P1_AP1_Kelvin_20180193.BLL;
using P1_AP1_Kelvin_20180193.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace P1_AP1_Kelvin_20180193.UI.Consulta
{
    /// <summary>
    /// Interaction logic for cConsulta.xaml
    /// </summary>
    public partial class cConsulta : Window
    {
        public cConsulta()
        {
            InitializeComponent();
        }
        private void BuscarButton_Click(object sender, RoutedEventArgs e)
        {
            var listado = new List<Aporte>();
            if (BusquedaTextBox.Text.Trim().Length > 0)
            {
                switch (FiltroComboBox.SelectedIndex)
                {
                    case 0:
                        listado = AporteBLL.GetList(e => e.Persona.ToLower().Contains(BusquedaTextBox.Text.ToLower()));
                        break;
                    case 1:
                        listado = AporteBLL.GetList(e => e.Concepto.ToLower().Contains(BusquedaTextBox.Text.ToLower()));
                        break;

                }
            }
            else
            {
                listado = AporteBLL.GetList(c => true);
            }

            if (FechaDesdeDatePicker.SelectedDate != null)
                listado = AporteBLL.GetList(c => c.Fecha.Date >= FechaDesdeDatePicker.SelectedDate);

            if (FechaHastaDatePicker.SelectedDate != null)
                listado = AporteBLL.GetList(c => c.Fecha.Date <= FechaHastaDatePicker.SelectedDate);

            var monto = listado.Sum(x => x.Monto);

            var conteo = listado.Count();

            TotalTextBlock.Text = monto.ToString("N2");

            MontoTextBlock.Text = conteo.ToString();

            DatosDataGrid.ItemsSource = null;
            DatosDataGrid.ItemsSource = listado;
        }
    }
}
