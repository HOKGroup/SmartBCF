﻿#pragma checksum "..\..\..\Windows\AddViewWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "9412A3525164090471888DE6570D8DF9"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using HOK.SmartBCF.Utils;
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


namespace HOK.SmartBCF.Windows {
    
    
    /// <summary>
    /// AddViewWindow
    /// </summary>
    public partial class AddViewWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 69 "..\..\..\Windows\AddViewWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton radioButtonLocal;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\..\Windows\AddViewWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock textBlockFilePath;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\..\Windows\AddViewWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton radioButtonRevit;
        
        #line default
        #line hidden
        
        
        #line 83 "..\..\..\Windows\AddViewWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonCamera;
        
        #line default
        #line hidden
        
        
        #line 90 "..\..\..\Windows\AddViewWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton radioButtonVisible;
        
        #line default
        #line hidden
        
        
        #line 93 "..\..\..\Windows\AddViewWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton radioButtonSelected;
        
        #line default
        #line hidden
        
        
        #line 96 "..\..\..\Windows\AddViewWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton radioButtonNone;
        
        #line default
        #line hidden
        
        
        #line 101 "..\..\..\Windows\AddViewWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imageView;
        
        #line default
        #line hidden
        
        
        #line 103 "..\..\..\Windows\AddViewWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonCancel;
        
        #line default
        #line hidden
        
        
        #line 104 "..\..\..\Windows\AddViewWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonAdd;
        
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
            System.Uri resourceLocater = new System.Uri("/HOK.SmartBCF;component/windows/addviewwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Windows\AddViewWindow.xaml"
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
            this.radioButtonLocal = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 2:
            this.textBlockFilePath = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.radioButtonRevit = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 4:
            this.buttonCamera = ((System.Windows.Controls.Button)(target));
            return;
            case 5:
            this.radioButtonVisible = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 6:
            this.radioButtonSelected = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 7:
            this.radioButtonNone = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 8:
            this.imageView = ((System.Windows.Controls.Image)(target));
            return;
            case 9:
            this.buttonCancel = ((System.Windows.Controls.Button)(target));
            
            #line 103 "..\..\..\Windows\AddViewWindow.xaml"
            this.buttonCancel.Click += new System.Windows.RoutedEventHandler(this.buttonCancel_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.buttonAdd = ((System.Windows.Controls.Button)(target));
            
            #line 105 "..\..\..\Windows\AddViewWindow.xaml"
            this.buttonAdd.Click += new System.Windows.RoutedEventHandler(this.buttonAdd_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

