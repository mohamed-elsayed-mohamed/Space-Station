﻿#pragma checksum "..\..\..\GUI\Main.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "469D71C9E0E7B1CF02DEB1771C3275E0"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Station.GUI;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
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


namespace Station.GUI {
    
    
    /// <summary>
    /// Main
    /// </summary>
    public partial class Main : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\..\GUI\Main.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_userName;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\GUI\Main.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox txt_password;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\GUI\Main.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtUserName;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\GUI\Main.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtPassword;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\GUI\Main.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock UN_Hint;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\GUI\Main.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Pass_Hint;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\GUI\Main.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_login;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\GUI\Main.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_register;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\GUI\Main.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Slider;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\GUI\Main.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtb_News;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\GUI\Main.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtb_News2;
        
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
            System.Uri resourceLocater = new System.Uri("/Station;component/gui/main.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\GUI\Main.xaml"
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
            this.txt_userName = ((System.Windows.Controls.TextBox)(target));
            
            #line 13 "..\..\..\GUI\Main.xaml"
            this.txt_userName.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txt_TextChanged);
            
            #line default
            #line hidden
            
            #line 13 "..\..\..\GUI\Main.xaml"
            this.txt_userName.PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.txt_userName_PreviewKeyDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.txt_password = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 14 "..\..\..\GUI\Main.xaml"
            this.txt_password.PasswordChanged += new System.Windows.RoutedEventHandler(this.txt_password_PasswordChanged);
            
            #line default
            #line hidden
            
            #line 14 "..\..\..\GUI\Main.xaml"
            this.txt_password.PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.txt_userName_PreviewKeyDown);
            
            #line default
            #line hidden
            return;
            case 3:
            this.txtUserName = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.txtPassword = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.UN_Hint = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.Pass_Hint = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.btn_login = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\..\GUI\Main.xaml"
            this.btn_login.Click += new System.Windows.RoutedEventHandler(this.btn_login_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btn_register = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\..\GUI\Main.xaml"
            this.btn_register.Click += new System.Windows.RoutedEventHandler(this.btn_register_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.Slider = ((System.Windows.Controls.Grid)(target));
            return;
            case 10:
            this.txtb_News = ((System.Windows.Controls.TextBox)(target));
            return;
            case 11:
            this.txtb_News2 = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
