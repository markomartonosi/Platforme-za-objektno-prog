﻿#pragma checksum "..\..\..\UI\RacunProzor.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "907B93808D0A78710889A24DF8FD87AAE6BC5F76"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using POP_SF_15_2016.UI;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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


namespace POP_SF_15_2016.UI {
    
    
    /// <summary>
    /// RacunProzor
    /// </summary>
    public partial class RacunProzor : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\UI\RacunProzor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgRacun;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\UI\RacunProzor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnDodaj;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\UI\RacunProzor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnDetaljnije;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\UI\RacunProzor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnObrisi;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\UI\RacunProzor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbKriterijumPretrage;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\UI\RacunProzor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbTekstPretrage;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\UI\RacunProzor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbNamestajZaPretragu;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/POP-SF-15-2016;component/ui/racunprozor.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\UI\RacunProzor.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.dgRacun = ((System.Windows.Controls.DataGrid)(target));
            
            #line 10 "..\..\..\UI\RacunProzor.xaml"
            this.dgRacun.AutoGeneratingColumn += new System.EventHandler<System.Windows.Controls.DataGridAutoGeneratingColumnEventArgs>(this.dgRacun_AutoGeneratingColumn);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnDodaj = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\..\UI\RacunProzor.xaml"
            this.btnDodaj.Click += new System.Windows.RoutedEventHandler(this.btnDodaj_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnDetaljnije = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\..\UI\RacunProzor.xaml"
            this.btnDetaljnije.Click += new System.Windows.RoutedEventHandler(this.btnDetaljnije_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnObrisi = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\..\UI\RacunProzor.xaml"
            this.btnObrisi.Click += new System.Windows.RoutedEventHandler(this.btnObrisi_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.cmbKriterijumPretrage = ((System.Windows.Controls.ComboBox)(target));
            
            #line 15 "..\..\..\UI\RacunProzor.xaml"
            this.cmbKriterijumPretrage.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cmbKriterijumPretrage_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.tbTekstPretrage = ((System.Windows.Controls.TextBox)(target));
            
            #line 17 "..\..\..\UI\RacunProzor.xaml"
            this.tbTekstPretrage.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.tbTekstPretrage_TextChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.cmbNamestajZaPretragu = ((System.Windows.Controls.ComboBox)(target));
            
            #line 18 "..\..\..\UI\RacunProzor.xaml"
            this.cmbNamestajZaPretragu.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cmbNamestajZaPretragu_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

