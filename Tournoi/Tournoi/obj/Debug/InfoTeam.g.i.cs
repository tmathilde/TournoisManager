﻿#pragma checksum "..\..\InfoTeam.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "F137507E20C347438833F1B1D9A3513F40C2EDAA"
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
using Tournoi;


namespace Tournoi {
    
    
    /// <summary>
    /// InfoTeam
    /// </summary>
    public partial class InfoTeam : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\InfoTeam.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button backInfoTeamButton;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\InfoTeam.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addInfoTeamButton;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\InfoTeam.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button editInfoTeamButton;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\InfoTeam.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button deleteInfoTeamButton;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\InfoTeam.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dataGridInfoTeam;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\InfoTeam.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox searchInfoTeamTextBox;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\InfoTeam.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button searchInfoTeamButton;
        
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
            System.Uri resourceLocater = new System.Uri("/Tournoi;component/infoteam.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\InfoTeam.xaml"
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
            this.backInfoTeamButton = ((System.Windows.Controls.Button)(target));
            
            #line 10 "..\..\InfoTeam.xaml"
            this.backInfoTeamButton.Click += new System.Windows.RoutedEventHandler(this.backInfoTeamButton_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.addInfoTeamButton = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\InfoTeam.xaml"
            this.addInfoTeamButton.Click += new System.Windows.RoutedEventHandler(this.addInfoTeamButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.editInfoTeamButton = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\InfoTeam.xaml"
            this.editInfoTeamButton.Click += new System.Windows.RoutedEventHandler(this.editInfoTeamButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.deleteInfoTeamButton = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\InfoTeam.xaml"
            this.deleteInfoTeamButton.Click += new System.Windows.RoutedEventHandler(this.deleteInfoTeamButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.dataGridInfoTeam = ((System.Windows.Controls.DataGrid)(target));
            
            #line 14 "..\..\InfoTeam.xaml"
            this.dataGridInfoTeam.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.dataGridInfoTeam_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.searchInfoTeamTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.searchInfoTeamButton = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\InfoTeam.xaml"
            this.searchInfoTeamButton.Click += new System.Windows.RoutedEventHandler(this.searchInfoTeamButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

