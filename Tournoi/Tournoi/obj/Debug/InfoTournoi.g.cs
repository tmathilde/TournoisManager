﻿#pragma checksum "..\..\InfoTournoi.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4A2C7E53CE15C365D65FF9B70A0A4FB1F0E131C9"
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
    /// InfoTournoi
    /// </summary>
    public partial class InfoTournoi : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\InfoTournoi.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button searchTeamButton;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\InfoTournoi.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox searchTeamTextBox;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\InfoTournoi.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid searchTeamDataGrid;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\InfoTournoi.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addTeamButton;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\InfoTournoi.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button editTeamButton;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\InfoTournoi.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button deleteTeamButton;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\InfoTournoi.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button backTournoiButton;
        
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
            System.Uri resourceLocater = new System.Uri("/Tournoi;component/infotournoi.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\InfoTournoi.xaml"
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
            this.searchTeamButton = ((System.Windows.Controls.Button)(target));
            
            #line 10 "..\..\InfoTournoi.xaml"
            this.searchTeamButton.Click += new System.Windows.RoutedEventHandler(this.searchTeamButton_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.searchTeamTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.searchTeamDataGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 4:
            this.addTeamButton = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\InfoTournoi.xaml"
            this.addTeamButton.Click += new System.Windows.RoutedEventHandler(this.addTeamButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.editTeamButton = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\InfoTournoi.xaml"
            this.editTeamButton.Click += new System.Windows.RoutedEventHandler(this.editTeamButton_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.deleteTeamButton = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\InfoTournoi.xaml"
            this.deleteTeamButton.Click += new System.Windows.RoutedEventHandler(this.deleteTeamButton_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.backTournoiButton = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\InfoTournoi.xaml"
            this.backTournoiButton.Click += new System.Windows.RoutedEventHandler(this.backTournoiButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

