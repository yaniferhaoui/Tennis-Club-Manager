﻿#pragma checksum "..\..\AjouterMembre.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "FB5F737F4ADE27F9CC87995D230FF9E567BD54655A6546C4F5635FAFE960FA5F"
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
    /// AjouterMembre
    /// </summary>
    public partial class AjouterMembre : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 25 "..\..\AjouterMembre.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Membres;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\AjouterMembre.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AjouterMembre;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\AjouterMembre.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Competition;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\AjouterMembre.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Stage;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\AjouterMembre.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Tournoi;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\AjouterMembre.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Reservation;
        
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
            System.Uri resourceLocater = new System.Uri("/ClubTennis2;component/ajoutermembre.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AjouterMembre.xaml"
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
            this.Membres = ((System.Windows.Controls.Button)(target));
            return;
            case 2:
            this.AjouterMembre = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\AjouterMembre.xaml"
            this.AjouterMembre.Click += new System.Windows.RoutedEventHandler(this.GoAjouterMembre);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Competition = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\AjouterMembre.xaml"
            this.Competition.Click += new System.Windows.RoutedEventHandler(this.GoCompetition);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Stage = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\AjouterMembre.xaml"
            this.Stage.Click += new System.Windows.RoutedEventHandler(this.GoStage);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Tournoi = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\AjouterMembre.xaml"
            this.Tournoi.Click += new System.Windows.RoutedEventHandler(this.GoTournoi);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Reservation = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\AjouterMembre.xaml"
            this.Reservation.Click += new System.Windows.RoutedEventHandler(this.GoReservation);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
