﻿#pragma checksum "..\..\..\windows\win_refund.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "80856FB8DD3ABD2669F2281B8ABBEBB24CB1087B"
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
    /// win_refund
    /// </summary>
    public partial class win_refund : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 37 "..\..\..\windows\win_refund.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox searchTrans;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\windows\win_refund.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button itemRefund;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\windows\win_refund.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button itemQuantity;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\windows\win_refund.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock slcNo;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\windows\win_refund.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock slcQty;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\windows\win_refund.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox curQty;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\windows\win_refund.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox refNo;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\windows\win_refund.xaml"
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
            System.Uri resourceLocater = new System.Uri("/NavigationDrawerPopUpMenu2;component/windows/win_refund.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\windows\win_refund.xaml"
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
            this.searchTrans = ((System.Windows.Controls.TextBox)(target));
            
            #line 37 "..\..\..\windows\win_refund.xaml"
            this.searchTrans.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.searchTrans_TextChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.itemRefund = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\..\windows\win_refund.xaml"
            this.itemRefund.Click += new System.Windows.RoutedEventHandler(this.itemRefund_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.itemQuantity = ((System.Windows.Controls.Button)(target));
            
            #line 45 "..\..\..\windows\win_refund.xaml"
            this.itemQuantity.Click += new System.Windows.RoutedEventHandler(this.itemQuantity_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.slcNo = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.slcQty = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.curQty = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.refNo = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.lv_browse = ((System.Windows.Controls.ListView)(target));
            
            #line 60 "..\..\..\windows\win_refund.xaml"
            this.lv_browse.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.lv_browse_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

