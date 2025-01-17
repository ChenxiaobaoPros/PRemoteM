﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using PRM.Core.Model;
using PRM.Core.Protocol;
using PRM.Model;
using Shawn.Utils;

namespace PRM.Controls
{
    /// <summary>
    /// Interaction logic for ServerListItem.xaml
    /// </summary>
    public partial class ServerListItem : UserControl
    {
        public static readonly DependencyProperty VmProtocolServerProperty =
            DependencyProperty.Register("VmProtocolServer", typeof(VmProtocolServer), typeof(ServerListItem),
                new PropertyMetadata(null, new PropertyChangedCallback(OnDataChanged)));

        private static void OnDataChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var value = (VmProtocolServer)e.NewValue;
            ((ServerListItem)d).DataContext = value;
        }

        public VmProtocolServer VmProtocolServer
        {
            get => (VmProtocolServer)GetValue(VmProtocolServerProperty);
            set => SetValue(VmProtocolServerProperty, value);
        }

        public ServerListItem()
        {
            InitializeComponent();
        }

        private void BtnSettingMenu_OnClick(object sender, RoutedEventArgs e)
        {
            VmProtocolServer.Actions = VmProtocolServer.Server.GetActions(App.Context, RemoteWindowPool.Instance.TabWindowCount);
            PopupCardSettingMenu.IsOpen = true;
        }

        private void ServerMenuButton_OnClick(object sender, RoutedEventArgs e)
        {
            PopupCardSettingMenu.IsOpen = false;
            if (sender is Button { CommandParameter: ActionForServer afs })
            {
                afs.Run();
            }
        }

        private void ButtonDuplicateServer_OnClick(object sender, RoutedEventArgs e)
        {
            PopupCardSettingMenu.IsOpen = false;
            if (VmProtocolServer != null && VmProtocolServer.CmdDuplicateServer.CanExecute())
            {
                VmProtocolServer.CmdDuplicateServer.Execute();
            }
        }
    }
}
