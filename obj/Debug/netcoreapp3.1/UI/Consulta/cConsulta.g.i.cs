// Updated by XamlIntelliSenseFileGenerator 05/10/2021 23:18:26
#pragma checksum "..\..\..\..\..\UI\Consulta\cConsulta.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "58DD37D869372154CE829DF3315ACAEAF41A1673"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using P1_AP1_Kelvin_20180193.UI.Consulta;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace P1_AP1_Kelvin_20180193.UI.Consulta
{


    /// <summary>
    /// cConsulta
    /// </summary>
    public partial class cConsulta : System.Windows.Window, System.Windows.Markup.IComponentConnector
    {

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.2.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/P1-AP1-Kelvin-20180193;V1.0.0.0;component/ui/consulta/cconsulta.xaml", System.UriKind.Relative);

#line 1 "..\..\..\..\..\UI\Consulta\cConsulta.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);

#line default
#line hidden
        }

        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.2.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            this._contentLoaded = true;
        }

        internal System.Windows.Controls.DatePicker FechaDesdeDatePicker;
        internal System.Windows.Controls.DatePicker FechaHastaDatePicker;
        internal System.Windows.Controls.Label FiltroLabel;
        internal System.Windows.Controls.ComboBox FiltroComboBox;
        internal System.Windows.Controls.ComboBoxItem PersonaComboBoxItem;
        internal System.Windows.Controls.ComboBoxItem ConceptoComboBoxItem;
        internal System.Windows.Controls.TextBox BusquedaTextBox;
        internal System.Windows.Controls.Button BuscarButton;
        internal System.Windows.Controls.DataGrid DatosDataGrid;
        internal System.Windows.Controls.TextBlock MontoTextBlock;
        internal System.Windows.Controls.TextBlock TotalTextBlock;
    }
}
