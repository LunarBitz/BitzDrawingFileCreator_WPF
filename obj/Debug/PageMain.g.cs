﻿#pragma checksum "..\..\PageMain.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "FFD0C8BD49CF8AE9F3D9F33EFA847F7851FF6C302F2264504B9C96393A7C1C6E"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using BitzDrawingFileCreator_WPF;
using Microsoft.Windows.Themes;
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


namespace BitzDrawingFileCreator_WPF {
    
    
    /// <summary>
    /// PageMain
    /// </summary>
    public partial class PageMain : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 23 "..\..\PageMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtCharacterName;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\PageMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAddCharacter_Copy;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\PageMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtCharacterSpecies;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\PageMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnDeleteCharacter;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\PageMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox listboxCharacters;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\PageMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox comboDrawingProduct;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\PageMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox comboDrawingType;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\PageMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox comboDrawingRender;
        
        #line default
        #line hidden
        
        
        #line 92 "..\..\PageMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox comboDrawingSize;
        
        #line default
        #line hidden
        
        
        #line 126 "..\..\PageMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtUserName;
        
        #line default
        #line hidden
        
        
        #line 132 "..\..\PageMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox comboTargetPlatform;
        
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
            System.Uri resourceLocater = new System.Uri("/BitzDrawingFileCreator_WPF;component/pagemain.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\PageMain.xaml"
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
            
            #line 13 "..\..\PageMain.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.txtCharacterName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.btnAddCharacter_Copy = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\PageMain.xaml"
            this.btnAddCharacter_Copy.Click += new System.Windows.RoutedEventHandler(this.btnAddCharacter_Copy_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.txtCharacterSpecies = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.btnDeleteCharacter = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\PageMain.xaml"
            this.btnDeleteCharacter.Click += new System.Windows.RoutedEventHandler(this.btnDeleteCharacter_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.listboxCharacters = ((System.Windows.Controls.ListBox)(target));
            return;
            case 7:
            this.comboDrawingProduct = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 8:
            this.comboDrawingType = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 9:
            this.comboDrawingRender = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 10:
            this.comboDrawingSize = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 11:
            this.txtUserName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 12:
            this.comboTargetPlatform = ((System.Windows.Controls.ComboBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

