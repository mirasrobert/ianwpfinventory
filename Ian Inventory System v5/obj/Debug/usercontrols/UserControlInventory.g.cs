﻿#pragma checksum "..\..\..\usercontrols\UserControlInventory.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6C4F13A3EF019741E5C5FB567D3099AA8D69C495"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Transitions;
using NavigationDrawerPopUpMenu2;
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


namespace NavigationDrawerPopUpMenu2 {
    
    
    /// <summary>
    /// UserControlInventory
    /// </summary>
    public partial class UserControlInventory : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 23 "..\..\..\usercontrols\UserControlInventory.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid isHeader;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\usercontrols\UserControlInventory.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbSearch;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\usercontrols\UserControlInventory.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbPrdId;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\..\usercontrols\UserControlInventory.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView listViewInventory;
        
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
            System.Uri resourceLocater = new System.Uri("/NavigationDrawerPopUpMenu2;component/usercontrols/usercontrolinventory.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\usercontrols\UserControlInventory.xaml"
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
            
            #line 9 "..\..\..\usercontrols\UserControlInventory.xaml"
            ((NavigationDrawerPopUpMenu2.UserControlInventory)(target)).Loaded += new System.Windows.RoutedEventHandler(this.UserControlInventory_Loaded_1);
            
            #line default
            #line hidden
            return;
            case 2:
            this.isHeader = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            
            #line 38 "..\..\..\usercontrols\UserControlInventory.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_4);
            
            #line default
            #line hidden
            return;
            case 4:
            this.tbSearch = ((System.Windows.Controls.TextBox)(target));
            
            #line 41 "..\..\..\usercontrols\UserControlInventory.xaml"
            this.tbSearch.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.tbSearch_TextChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.tbPrdId = ((System.Windows.Controls.TextBox)(target));
            
            #line 46 "..\..\..\usercontrols\UserControlInventory.xaml"
            this.tbPrdId.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.tbSearch_TextChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 51 "..\..\..\usercontrols\UserControlInventory.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 52 "..\..\..\usercontrols\UserControlInventory.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 53 "..\..\..\usercontrols\UserControlInventory.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_5);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 54 "..\..\..\usercontrols\UserControlInventory.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_2);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 55 "..\..\..\usercontrols\UserControlInventory.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_3);
            
            #line default
            #line hidden
            return;
            case 11:
            this.listViewInventory = ((System.Windows.Controls.ListView)(target));
            
            #line 80 "..\..\..\usercontrols\UserControlInventory.xaml"
            this.listViewInventory.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.listViewInventory_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

