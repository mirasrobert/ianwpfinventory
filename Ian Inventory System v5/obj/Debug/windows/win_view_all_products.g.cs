﻿#pragma checksum "..\..\..\windows\win_view_all_products.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "480878AEE90E3DD92D434BEFCAC5732B3C67C70F"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using NavigationDrawerPopUpMenu2.windows;
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


namespace NavigationDrawerPopUpMenu2.windows {
    
    
    /// <summary>
    /// win_view_all_products
    /// </summary>
    public partial class win_view_all_products : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 37 "..\..\..\windows\win_view_all_products.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox searchPrd;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\windows\win_view_all_products.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button refreshBtn;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\windows\win_view_all_products.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock slcNo;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\windows\win_view_all_products.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock slcQty;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\windows\win_view_all_products.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox curQty;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\windows\win_view_all_products.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox refNo;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\windows\win_view_all_products.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView lv_browse;
        
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
            System.Uri resourceLocater = new System.Uri("/NavigationDrawerPopUpMenu2;component/windows/win_view_all_products.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\windows\win_view_all_products.xaml"
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
            this.searchPrd = ((System.Windows.Controls.TextBox)(target));
            
            #line 37 "..\..\..\windows\win_view_all_products.xaml"
            this.searchPrd.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.searchTrans_TextChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.refreshBtn = ((System.Windows.Controls.Button)(target));
            
            #line 40 "..\..\..\windows\win_view_all_products.xaml"
            this.refreshBtn.Click += new System.Windows.RoutedEventHandler(this.refreshBtn_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.slcNo = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.slcQty = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.curQty = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.refNo = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.lv_browse = ((System.Windows.Controls.ListView)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
