   M S B A M L   `   `   `  ����M  INavigationInWpfApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:NavigationInWpfApp.ViewsNavigationInWpfApp.Views  5      M+clr-namespace:NavigationInWpfApp.ViewModelsNavigationInWpfApp.ViewModels  5
      E'clr-namespace:NavigationInWpfApp.ModelsNavigationInWpfApp.Models  5      +    %NavigationInWpfApp.Views.CustomerView   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      8local&clr-namespace:NavigationInWpfApp.Views     5      B
viewmodels+clr-namespace:NavigationInWpfApp.ViewModels     5
      :models'clr-namespace:NavigationInWpfApp.Models     5      .��5      � .+�5   
   �� .+�5      �� $��New Product��6   �� 5      $��Navigate To Product List��6   ��68   �� *NavigateToListCommand+5      �� 5      $
��0,80q�6   $��1��6%   $��Stretch=�6W   ��62   �� *CustomerList+��5      �� 5      .R�5      � $
��2, 5q�6     � ColumnDefinitions  5      �� 5   "   $��* �63   �� 5   "   $
��auto �63   .+�5      �� $��0��6)   .+�5    "   �� $��14(�6,   $
��Bold"�6:   �� 5!       �6$   �� *	Firstname+ �� 5"       �6$   �� *
Lastname+5#   #   �� 5$   "   $��12(�6,   
��������� 5%      $	�Tel��6#    �� 5&      �6#   �� *Phonenumber+ �� 5'      $�Email��6#    �� 5(      �6#   �� *Email+5)   #   �� 5*   "   $��12(�6,   
��������� 5+       $�
Homeadress��6$    �� 5,       �6$   �� *
Homeadress+5-   #   5.      �� 50      $��1��6�   $��X��6�   $��20��6�   $��20��6�   ��6%   �� *.+��6D   �� *+)DataContext.RemoveCustomerFromListCommand+ �� RelativeSource ��  �� AncestorType" >�6�   51      52      54      56      57      