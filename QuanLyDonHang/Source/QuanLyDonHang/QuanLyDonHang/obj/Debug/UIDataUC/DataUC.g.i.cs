﻿#pragma checksum "..\..\..\UIDataUC\DataUC.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "D17AE02B894B590F076F4B5ACB464B02"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
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


namespace QuanLyDonHang {
    
    
    /// <summary>
    /// DataUC
    /// </summary>
    public partial class DataUC : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 7 "..\..\..\UIDataUC\DataUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal QuanLyDonHang.DataUC dataUC;
        
        #line default
        #line hidden
        
        
        #line 9 "..\..\..\UIDataUC\DataUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabControl tabData;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\..\UIDataUC\DataUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabItem tabUser;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\UIDataUC\DataUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabItem tabNhaThuoc;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\UIDataUC\DataUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabItem tabCatalogue;
        
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
            System.Uri resourceLocater = new System.Uri("/QuanLyDonHang;component/uidatauc/datauc.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\UIDataUC\DataUC.xaml"
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
            this.dataUC = ((QuanLyDonHang.DataUC)(target));
            
            #line 7 "..\..\..\UIDataUC\DataUC.xaml"
            this.dataUC.Loaded += new System.Windows.RoutedEventHandler(this.dataUC_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.tabData = ((System.Windows.Controls.TabControl)(target));
            
            #line 9 "..\..\..\UIDataUC\DataUC.xaml"
            this.tabData.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.tabData_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.tabUser = ((System.Windows.Controls.TabItem)(target));
            return;
            case 4:
            this.tabNhaThuoc = ((System.Windows.Controls.TabItem)(target));
            return;
            case 5:
            this.tabCatalogue = ((System.Windows.Controls.TabItem)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

