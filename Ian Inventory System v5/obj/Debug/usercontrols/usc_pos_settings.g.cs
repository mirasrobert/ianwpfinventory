﻿#pragma checksum "..\..\..\usercontrols\usc_pos_settings.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "C55B324D376E38A8B49C08901EB5876377ACC59E"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using NavigationDrawerPopUpMenu2.usercontrols;
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


namespace NavigationDrawerPopUpMenu2.usercontrols {
    
    
    /// <summary>
    /// usc_pos_settings
    /// </summary>
    public partial class usc_pos_settings : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 40 "..\..\..\usercontrols\usc_pos_settings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView listViewDiscount;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\..\usercontrols\usc_pos_settings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button editButton;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\usercontrols\usc_pos_settings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button removeButton;
        
        #line default
        #line hidden
        
        
        #line 91 "..\..\..\usercontrols\usc_pos_settings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbDiscountName;
        
        #line default
        #line hidden
        
        
        #line 94 "..\..\..\usercontrols\usc_pos_settings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid mainGrid;
        
        #line default
        #line hidden
        
        
        #line 101 "..\..\..\usercontrols\usc_pos_settings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox discountName;
        
        #line default
        #line hidden
        
        
        #line 107 "..\..\..\usercontrols\usc_pos_settings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox discountValue;
        
        #line default
        #line hidden
        
        
        #line 112 "..\..\..\usercontrols\usc_pos_settings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addItem;
        
        #line default
        #line hidden
        
        
        #line 118 "..\..\..\usercontrols\usc_pos_settings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addIem;
        
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
            System.Uri resourceLocater = new System.Uri("/NavigationDrawerPopUpMenu2;component/usercontrols/usc_pos_settings.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\usercontrols\usc_pos_settings.xaml"
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
            this.listViewDiscount = ((System.Windows.Controls.ListView)(target));
            
            #line 40 "..\..\..\usercontrols\usc_pos_settings.xaml"
            this.listViewDiscount.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.listViewDiscount_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.editButton = ((System.Windows.Controls.Button)(target));
            
            #line 59 "..\..\..\usercontrols\usc_pos_settings.xaml"
            this.editButton.Click += new System.Windows.RoutedEventHandler(this.editButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.removeButton = ((System.Windows.Controls.Button)(target));
            
            #line 65 "..\..\..\usercontrols\usc_pos_settings.xaml"
            this.removeButton.Click += new System.Windows.RoutedEventHandler(this.removeButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.tbDiscountName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.mainGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 6:
            this.discountName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.discountValue = ((System.Windows.Controls.TextBox)(target));
            
            #line 107 "..\..\..\usercontrols\usc_pos_settings.xaml"
            this.discountValue.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.TextBox_OnPreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 8:
            this.addItem = ((System.Windows.Controls.Button)(target));
            
            #line 112 "..\..\..\usercontrols\usc_pos_settings.xaml"
            this.addItem.Click += new System.Windows.RoutedEventHandler(this.addDiscount_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.addIem = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

