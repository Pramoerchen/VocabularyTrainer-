﻿#pragma checksum "..\..\..\sprache_fuer_eingabe_aendern.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "B32B1A93E5C854A5790BA2C504F9655CB52ED062"
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
    /// sprache_fuer_eingabe_aendern
    /// </summary>
    public partial class sprache_fuer_eingabe_aendern : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\sprache_fuer_eingabe_aendern.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView sprache_1_selector;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\sprache_fuer_eingabe_aendern.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView sprache_2_selector;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\sprache_fuer_eingabe_aendern.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button abfrage_starten_btn;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\sprache_fuer_eingabe_aendern.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button zurück_abfrage;
        
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
            System.Uri resourceLocater = new System.Uri("/Vokabeltrainer;component/sprache_fuer_eingabe_aendern.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\sprache_fuer_eingabe_aendern.xaml"
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
            this.sprache_1_selector = ((System.Windows.Controls.ListView)(target));
            
            #line 11 "..\..\..\sprache_fuer_eingabe_aendern.xaml"
            this.sprache_1_selector.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.sprache_1_selector_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.sprache_2_selector = ((System.Windows.Controls.ListView)(target));
            
            #line 18 "..\..\..\sprache_fuer_eingabe_aendern.xaml"
            this.sprache_2_selector.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.sprache_2_selector_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.abfrage_starten_btn = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\..\sprache_fuer_eingabe_aendern.xaml"
            this.abfrage_starten_btn.Click += new System.Windows.RoutedEventHandler(this.abfrage_starten_btn_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.zurück_abfrage = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\..\sprache_fuer_eingabe_aendern.xaml"
            this.zurück_abfrage.Click += new System.Windows.RoutedEventHandler(this.zurück_abfrage_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

