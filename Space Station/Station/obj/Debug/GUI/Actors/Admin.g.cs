﻿#pragma checksum "..\..\..\..\GUI\Actors\Admin.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "39885CF2B6CC65D42DC491DAB11EE6F1"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Station.GUI.Actors;
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


namespace Station.GUI.Actors {
    
    
    /// <summary>
    /// Admin
    /// </summary>
    public partial class Admin : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 22 "..\..\..\..\GUI\Actors\Admin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Ellipse Ellipse_Image;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\..\GUI\Actors\Admin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Media.ImageBrush Photo;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\..\GUI\Actors\Admin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView Options;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\..\GUI\Actors\Admin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListViewItem EditInfo;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\..\GUI\Actors\Admin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListViewItem Logout;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\..\GUI\Actors\Admin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListViewItem Cancel;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\..\GUI\Actors\Admin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txt_Name;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\..\GUI\Actors\Admin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Search;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\..\GUI\Actors\Admin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Hint;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\..\GUI\Actors\Admin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView LV_Actors;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\..\..\GUI\Actors\Admin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmb_Add;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\..\..\GUI\Actors\Admin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_Code;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\..\..\GUI\Actors\Admin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Add;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\..\..\GUI\Actors\Admin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Delete;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\..\..\GUI\Actors\Admin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Restart;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\..\..\GUI\Actors\Admin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_ShutDown;
        
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
            System.Uri resourceLocater = new System.Uri("/Station;component/gui/actors/admin.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\GUI\Actors\Admin.xaml"
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
            this.Ellipse_Image = ((System.Windows.Shapes.Ellipse)(target));
            
            #line 22 "..\..\..\..\GUI\Actors\Admin.xaml"
            this.Ellipse_Image.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Ellipse_Image_MouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Photo = ((System.Windows.Media.ImageBrush)(target));
            return;
            case 3:
            this.Options = ((System.Windows.Controls.ListView)(target));
            return;
            case 4:
            this.EditInfo = ((System.Windows.Controls.ListViewItem)(target));
            
            #line 28 "..\..\..\..\GUI\Actors\Admin.xaml"
            this.EditInfo.PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.EditInfo_PreviewMouseDown);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Logout = ((System.Windows.Controls.ListViewItem)(target));
            
            #line 29 "..\..\..\..\GUI\Actors\Admin.xaml"
            this.Logout.PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Logout_PreviewMouseDown);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Cancel = ((System.Windows.Controls.ListViewItem)(target));
            
            #line 30 "..\..\..\..\GUI\Actors\Admin.xaml"
            this.Cancel.PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Ellipse_Image_MouseDown);
            
            #line default
            #line hidden
            return;
            case 7:
            this.txt_Name = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            this.Search = ((System.Windows.Controls.TextBox)(target));
            
            #line 40 "..\..\..\..\GUI\Actors\Admin.xaml"
            this.Search.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Search_TextChanged);
            
            #line default
            #line hidden
            return;
            case 9:
            this.Hint = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 10:
            this.LV_Actors = ((System.Windows.Controls.ListView)(target));
            
            #line 42 "..\..\..\..\GUI\Actors\Admin.xaml"
            this.LV_Actors.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.LV_Actors_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 11:
            this.cmb_Add = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 12:
            this.txt_Code = ((System.Windows.Controls.TextBox)(target));
            return;
            case 13:
            this.btn_Add = ((System.Windows.Controls.Button)(target));
            
            #line 74 "..\..\..\..\GUI\Actors\Admin.xaml"
            this.btn_Add.Click += new System.Windows.RoutedEventHandler(this.btn_Add_Click);
            
            #line default
            #line hidden
            return;
            case 14:
            this.btn_Delete = ((System.Windows.Controls.Button)(target));
            
            #line 75 "..\..\..\..\GUI\Actors\Admin.xaml"
            this.btn_Delete.Click += new System.Windows.RoutedEventHandler(this.btn_Delete_Click);
            
            #line default
            #line hidden
            return;
            case 15:
            this.btn_Restart = ((System.Windows.Controls.Button)(target));
            
            #line 76 "..\..\..\..\GUI\Actors\Admin.xaml"
            this.btn_Restart.Click += new System.Windows.RoutedEventHandler(this.btn_Restart_Click);
            
            #line default
            #line hidden
            return;
            case 16:
            this.btn_ShutDown = ((System.Windows.Controls.Button)(target));
            
            #line 77 "..\..\..\..\GUI\Actors\Admin.xaml"
            this.btn_ShutDown.Click += new System.Windows.RoutedEventHandler(this.btn_ShutDown_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
