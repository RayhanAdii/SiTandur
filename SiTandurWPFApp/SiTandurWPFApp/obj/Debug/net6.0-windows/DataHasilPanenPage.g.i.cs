﻿#pragma checksum "..\..\..\DataHasilPanenPage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "E13947B7235A8F07EB727B7441C53158147E8FC3"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using SiTandurWPFApp;
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


namespace SiTandurWPFApp {
    
    
    /// <summary>
    /// DataHasilPanenPage
    /// </summary>
    public partial class DataHasilPanenPage : System.Windows.Window, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 43 "..\..\..\DataHasilPanenPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton radioBtnLogOut;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\..\DataHasilPanenPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid hasilPanenDataGrid;
        
        #line default
        #line hidden
        
        
        #line 112 "..\..\..\DataHasilPanenPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnTambahHasilPanen;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.11.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/SiTandurWPFApp;component/datahasilpanenpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\DataHasilPanenPage.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.11.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 37 "..\..\..\DataHasilPanenPage.xaml"
            ((System.Windows.Controls.RadioButton)(target)).Checked += new System.Windows.RoutedEventHandler(this.DasborBtn_Checked);
            
            #line default
            #line hidden
            return;
            case 2:
            this.radioBtnLogOut = ((System.Windows.Controls.RadioButton)(target));
            
            #line 47 "..\..\..\DataHasilPanenPage.xaml"
            this.radioBtnLogOut.Checked += new System.Windows.RoutedEventHandler(this.radioBtnLogOut_Checked);
            
            #line default
            #line hidden
            return;
            case 3:
            this.hasilPanenDataGrid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 67 "..\..\..\DataHasilPanenPage.xaml"
            this.hasilPanenDataGrid.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.petaniDataGrid_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnTambahHasilPanen = ((System.Windows.Controls.Button)(target));
            
            #line 112 "..\..\..\DataHasilPanenPage.xaml"
            this.btnTambahHasilPanen.Click += new System.Windows.RoutedEventHandler(this.BtnTambahHasilPanen_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.11.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 4:
            
            #line 82 "..\..\..\DataHasilPanenPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BtnTabelUbahHasilPanen_Click);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

