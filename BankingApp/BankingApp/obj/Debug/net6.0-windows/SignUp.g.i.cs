﻿#pragma checksum "..\..\..\SignUp.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "896566734A9E04E179FFD763795C1C6DDC8144FC"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
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


namespace BankingApp {
    
    
    /// <summary>
    /// SignUp
    /// </summary>
    public partial class SignUp : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\..\SignUp.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame Main;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\SignUp.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label upLBL;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\SignUp.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label signTxtLBL;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\SignUp.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button logInBTN;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\SignUp.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label logLBL;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\SignUp.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox emailBOX;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\SignUp.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox passBOX;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\SignUp.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button signUpBTN;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\SignUp.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label passLBL;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.10.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/BankingApp;V1.0.0.0;component/signup.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\SignUp.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.10.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.Main = ((System.Windows.Controls.Frame)(target));
            return;
            case 2:
            this.upLBL = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.signTxtLBL = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.logInBTN = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\..\SignUp.xaml"
            this.logInBTN.Click += new System.Windows.RoutedEventHandler(this.logInBTN_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.logLBL = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.emailBOX = ((System.Windows.Controls.TextBox)(target));
            
            #line 45 "..\..\..\SignUp.xaml"
            this.emailBOX.GotFocus += new System.Windows.RoutedEventHandler(this.emailBOX_GotFocus);
            
            #line default
            #line hidden
            
            #line 46 "..\..\..\SignUp.xaml"
            this.emailBOX.LostFocus += new System.Windows.RoutedEventHandler(this.emailBOX_LostFocus);
            
            #line default
            #line hidden
            return;
            case 7:
            this.passBOX = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 51 "..\..\..\SignUp.xaml"
            this.passBOX.GotFocus += new System.Windows.RoutedEventHandler(this.passBOX_GotFocus);
            
            #line default
            #line hidden
            
            #line 52 "..\..\..\SignUp.xaml"
            this.passBOX.LostFocus += new System.Windows.RoutedEventHandler(this.passBOX_LostFocus);
            
            #line default
            #line hidden
            return;
            case 8:
            this.signUpBTN = ((System.Windows.Controls.Button)(target));
            return;
            case 9:
            this.passLBL = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

