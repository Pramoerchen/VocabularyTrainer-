﻿#pragma checksum "..\..\..\abfrage_richtung_aussuchen.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "BDF4EB609ACF1B1209D692BC13F453EB8EF52985"
//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

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
using Vokabeltrainer;


namespace Vokabeltrainer {
    
    
    /// <summary>
    /// abfrage_richtung_aussuchen
    /// </summary>
    public partial class abfrage_richtung_aussuchen : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\..\abfrage_richtung_aussuchen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rdobtn_EngZuDeu;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\abfrage_richtung_aussuchen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rdobtn_DeuRndEng;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\abfrage_richtung_aussuchen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rdobtn_DeuZuEng;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\abfrage_richtung_aussuchen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Abrage;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\abfrage_richtung_aussuchen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView sprache_1_selector;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\abfrage_richtung_aussuchen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView sprache_2_selector;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Vokabeltrainer;component/abfrage_richtung_aussuchen.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\abfrage_richtung_aussuchen.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.rdobtn_EngZuDeu = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 2:
            this.rdobtn_DeuRndEng = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 3:
            this.rdobtn_DeuZuEng = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 4:
            this.btn_Abrage = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\..\abfrage_richtung_aussuchen.xaml"
            this.btn_Abrage.Click += new System.Windows.RoutedEventHandler(this.event_Abfrage);
            
            #line default
            #line hidden
            return;
            case 5:
            this.sprache_1_selector = ((System.Windows.Controls.ListView)(target));
            
            #line 22 "..\..\..\abfrage_richtung_aussuchen.xaml"
            this.sprache_1_selector.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.sprache_1_selector_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.sprache_2_selector = ((System.Windows.Controls.ListView)(target));
            
            #line 29 "..\..\..\abfrage_richtung_aussuchen.xaml"
            this.sprache_2_selector.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.sprache_2_selector_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

