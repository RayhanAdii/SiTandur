﻿#pragma checksum "..\..\..\AddHasilPanen.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3B42DCC09A704301C83F1CFF1F5BDBC4F6211937"
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
    /// AddHasilPanen
    /// </summary>
    public partial class AddHasilPanen : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 24 "..\..\..\AddHasilPanen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox UserAddDate;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\AddHasilPanen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox UserAddTanaman;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\AddHasilPanen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox UserAddLocation;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\..\AddHasilPanen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox UserAddPetani;
        
        #line default
        #line hidden
        
        
        #line 83 "..\..\..\AddHasilPanen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox UserAddWeight;
        
        #line default
        #line hidden
        
        
        #line 91 "..\..\..\AddHasilPanen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnSimpanRecord;
        
        #line default
        #line hidden
        
        
        #line 101 "..\..\..\AddHasilPanen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnBatalRecord;
        
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
            System.Uri resourceLocater = new System.Uri("/SiTandurWPFApp;V1.0.0.0;component/addhasilpanen.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\AddHasilPanen.xaml"
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
            this.UserAddDate = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.UserAddTanaman = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.UserAddLocation = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.UserAddPetani = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.UserAddWeight = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.BtnSimpanRecord = ((System.Windows.Controls.Button)(target));
            
            #line 91 "..\..\..\AddHasilPanen.xaml"
            this.BtnSimpanRecord.Click += new System.Windows.RoutedEventHandler(this.BtnSimpanRecord_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.BtnBatalRecord = ((System.Windows.Controls.Button)(target));
            
            #line 101 "..\..\..\AddHasilPanen.xaml"
            this.BtnBatalRecord.Click += new System.Windows.RoutedEventHandler(this.BtnBatalRecord_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

