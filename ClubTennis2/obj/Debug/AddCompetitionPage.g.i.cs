﻿#pragma checksum "..\..\AddCompetitionPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "5F85FA2CCAA62AD8BF44BE0D4FC84E23F68A0CD1FC320F69169183D9B1D8147F"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ClubTennis2;
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


namespace ClubTennis2 {
    
    
    /// <summary>
    /// AddCompetitionPage
    /// </summary>
    public partial class AddCompetitionPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 37 "..\..\AddCompetitionPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox nomTextBox;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\AddCompetitionPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox prixTextBox;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\AddCompetitionPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label levelLabel;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\AddCompetitionPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox levelComboBox;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\AddCompetitionPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddTeamB;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\AddCompetitionPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button RemoveTeamB;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\AddCompetitionPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid teamMatches;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\AddCompetitionPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button valider;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\AddCompetitionPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AnnulerB;
        
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
            System.Uri resourceLocater = new System.Uri("/ClubTennis2;component/addcompetitionpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AddCompetitionPage.xaml"
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
            this.nomTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.prixTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 40 "..\..\AddCompetitionPage.xaml"
            this.prixTextBox.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.NumberValidationTextBox);
            
            #line default
            #line hidden
            return;
            case 3:
            this.levelLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.levelComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.AddTeamB = ((System.Windows.Controls.Button)(target));
            
            #line 45 "..\..\AddCompetitionPage.xaml"
            this.AddTeamB.Click += new System.Windows.RoutedEventHandler(this.GoAddTeam);
            
            #line default
            #line hidden
            return;
            case 6:
            this.RemoveTeamB = ((System.Windows.Controls.Button)(target));
            
            #line 46 "..\..\AddCompetitionPage.xaml"
            this.RemoveTeamB.Click += new System.Windows.RoutedEventHandler(this.SupprimerSelectionnes);
            
            #line default
            #line hidden
            return;
            case 7:
            this.teamMatches = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 8:
            this.valider = ((System.Windows.Controls.Button)(target));
            
            #line 80 "..\..\AddCompetitionPage.xaml"
            this.valider.Click += new System.Windows.RoutedEventHandler(this.AjouterModifier);
            
            #line default
            #line hidden
            return;
            case 9:
            this.AnnulerB = ((System.Windows.Controls.Button)(target));
            
            #line 81 "..\..\AddCompetitionPage.xaml"
            this.AnnulerB.Click += new System.Windows.RoutedEventHandler(this.Annuler);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
