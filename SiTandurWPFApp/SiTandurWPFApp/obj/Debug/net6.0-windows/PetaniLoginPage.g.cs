﻿#pragma checksum "..\..\..\PetaniLoginPage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "B19726F737B9DF1EAB91AEDC6AEC966EA74D56F1"
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
    /// PetaniLoginPage
    /// </summary>
    public partial class PetaniLoginPage : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 38 "..\..\..\PetaniLoginPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock textName;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\PetaniLoginPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtName;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\PetaniLoginPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock textPassword;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\PetaniLoginPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox passwordBox;
        
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
            System.Uri resourceLocater = new System.Uri("/SiTandurWPFApp;component/petaniloginpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\PetaniLoginPage.xaml"
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
            
            #line 26 "..\..\..\PetaniLoginPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.AdminButton_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.textName = ((System.Windows.Controls.TextBlock)(target));
            
            #line 38 "..\..\..\PetaniLoginPage.xaml"
            this.textName.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.textName_MouseDown);
            
            #line default
            #line hidden
            return;
            case 3:
            this.txtName = ((System.Windows.Controls.TextBox)(target));
            
            #line 39 "..\..\..\PetaniLoginPage.xaml"
            this.txtName.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtName_TextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.textPassword = ((System.Windows.Controls.TextBlock)(target));
            
            #line 50 "..\..\..\PetaniLoginPage.xaml"
            this.textPassword.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.textPassword_MouseDown);
            
            #line default
            #line hidden
            return;
            case 5:
            this.passwordBox = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 51 "..\..\..\PetaniLoginPage.xaml"
            this.passwordBox.PasswordChanged += new System.Windows.RoutedEventHandler(this.PasswordBox_PasswordChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 55 "..\..\..\PetaniLoginPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.LoginButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

