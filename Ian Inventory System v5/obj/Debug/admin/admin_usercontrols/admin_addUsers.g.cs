﻿#pragma checksum "..\..\..\..\admin\admin_usercontrols\admin_addUsers.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "CB8C8E16FCD550548103ADDD4A5D9CFAFCC79113"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using NavigationDrawerPopUpMenu2.admin.admin_usercontrols;
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


namespace NavigationDrawerPopUpMenu2.admin.admin_usercontrols {
    
    
    /// <summary>
    /// admin_addUsers
    /// </summary>
    public partial class admin_addUsers : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 22 "..\..\..\..\admin\admin_usercontrols\admin_addUsers.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView listViewProgress;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\..\admin\admin_usercontrols\admin_addUsers.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListViewItem personalInfo;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\..\admin\admin_usercontrols\admin_addUsers.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListViewItem businessInfo;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\..\admin\admin_usercontrols\admin_addUsers.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock bisInfo;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\..\admin\admin_usercontrols\admin_addUsers.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListViewItem confirmInfo;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\..\..\admin\admin_usercontrols\admin_addUsers.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid mainGrid;
        
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
            System.Uri resourceLocater = new System.Uri("/NavigationDrawerPopUpMenu2;component/admin/admin_usercontrols/admin_addusers.xam" +
                    "l", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\admin\admin_usercontrols\admin_addUsers.xaml"
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
            this.listViewProgress = ((System.Windows.Controls.ListView)(target));
            
            #line 22 "..\..\..\..\admin\admin_usercontrols\admin_addUsers.xaml"
            this.listViewProgress.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.listViewProgress_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.personalInfo = ((System.Windows.Controls.ListViewItem)(target));
            return;
            case 3:
            this.businessInfo = ((System.Windows.Controls.ListViewItem)(target));
            return;
            case 4:
            this.bisInfo = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.confirmInfo = ((System.Windows.Controls.ListViewItem)(target));
            return;
            case 6:
            this.mainGrid = ((System.Windows.Controls.Grid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

