﻿#pragma checksum "..\..\DeletePlayer.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "EABA25D7090A263A8279509FFDBFC0D33EA3066C"
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
    /// DeletePlayer
    /// </summary>
    public partial class DeletePlayer : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\DeletePlayer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox searchDeletePlayerTextBox;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\DeletePlayer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button backDeletePlayerButton;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\DeletePlayer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button deletePlayerButton;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\DeletePlayer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button seachDeletePlayerButton;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\DeletePlayer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dataGridDeleteTeam;
        
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
            System.Uri resourceLocater = new System.Uri("/Tournoi;component/deleteplayer.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\DeletePlayer.xaml"
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
            this.searchDeletePlayerTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.backDeletePlayerButton = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\DeletePlayer.xaml"
            this.backDeletePlayerButton.Click += new System.Windows.RoutedEventHandler(this.backDeleteTeamButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.deletePlayerButton = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\DeletePlayer.xaml"
            this.deletePlayerButton.Click += new System.Windows.RoutedEventHandler(this.deleteTeamButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.seachDeletePlayerButton = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\DeletePlayer.xaml"
            this.seachDeletePlayerButton.Click += new System.Windows.RoutedEventHandler(this.seachDeleteTeamButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.dataGridDeleteTeam = ((System.Windows.Controls.DataGrid)(target));
            
            #line 15 "..\..\DeletePlayer.xaml"
            this.dataGridDeleteTeam.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.dataGridDeleteTeam_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

