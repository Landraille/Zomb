﻿#pragma checksum "..\..\..\..\Business\Option\OptionView.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "CDFF12FC81277715C75CC06277A32A01"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
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
using Zombicide.Assets;
using Zombicide.Business.Option;


namespace Zombicide.Business.Option {
    
    
    /// <summary>
    /// OptionView
    /// </summary>
    public partial class OptionView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 26 "..\..\..\..\Business\Option\OptionView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabControl Items;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\..\Business\Option\OptionView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button GoButton;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\..\Business\Option\OptionView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock ModeStatusBar;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\..\Business\Option\OptionView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock DifficultyStatusBarTitle;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\..\Business\Option\OptionView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock DifficultyStatusBar;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\..\..\Business\Option\OptionView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock PlayerStatusBarTitle;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\..\Business\Option\OptionView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock PlayerStatusBar;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\..\..\Business\Option\OptionView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock CharacterStatusBarTitle;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\..\..\Business\Option\OptionView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock CharacterStatusBar;
        
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
            System.Uri resourceLocater = new System.Uri("/Zombicide;component/business/option/optionview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Business\Option\OptionView.xaml"
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
            this.Items = ((System.Windows.Controls.TabControl)(target));
            return;
            case 2:
            this.GoButton = ((System.Windows.Controls.Button)(target));
            return;
            case 3:
            this.ModeStatusBar = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.DifficultyStatusBarTitle = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.DifficultyStatusBar = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.PlayerStatusBarTitle = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.PlayerStatusBar = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            this.CharacterStatusBarTitle = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 9:
            this.CharacterStatusBar = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

