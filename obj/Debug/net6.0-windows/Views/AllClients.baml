   M S B A M L   `   `   `  ����B  >Clients, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:Clients.ViewsClients.Views  5   	   ;"clr-namespace:Clients.UserControlsClients.UserControls  5   	       Clients.Views.AllClients   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:Clients.Views     5   	   Z VFontAwesome.WPF, Version=4.7.0.37774, Culture=neutral, PublicKeyToken=0758b07a11a4f466-fa$http://schemas.fontawesome.io/icons/  5   	   5userControls"clr-namespace:Clients.UserControls  5   	     � Title$  
AllClients��5
   	   $	��592��6   $	��288��6)   $	��288��65   $	��288��6D   $	��592��6S   $	��592��6c    � WindowStartupLocation$ CenterScreen=�5   	   .��5      � ���#F4F8FB � RowDefinitions 5   
   �� 5      $��39 �6   �� 5      .+�5   
   � $��0��6   
�������.+�5      �� $-��'/StaticFiles/Images/LogoClientsLogo.png��6   $��43��6E   $
��16.2��6P   $��10q�6^   $	��Top=�6j   $
��Left=�6�   �� 5      $��35��6   $��15��6    $	��Top=�6,   $��Right=�6D   $��10q�6`   
������ $��0q�5      ��5      �� 5      $
��home��6!   $��13(�6-   $��Center=�6;   $��Center=�6X   5      5      � 5   
   $��1��6   .+�5      �� $
��Auto=�6   .��5      �� $	��Top=�6F   $��Center=�6^   $��0, 15q�6{   ��6   �� *CurrentClients+��5      �� 5       .R�5!      )   #Clients.UserControls.ClientInfoCard     MoreCommand 6:   ��  �� RelativeSource ��  �� AncestorType" �� �� Path$&  DataContext.ClientProfileCommand�   Company 5"   1   �� *	Company+   Phone 6M   �� *Phone+	   UndeliveredOrderCount	 6e   �� *UndeliveredOrderCount+
   Fullname
 5#   "   `� 5$   &    �� StringFormat$  {0} {1}��63   .1�5%   *   �� $
 Name�62   �� 5&   *   $ Surname�62   5'   '   5)      5*      5,      5-      �� 5/         BtnStyle#���   6   $
��48.2��68   $��45��6F   $��Bottom=�6Q   $��Right=�6l   $��10,50q�6�   ��50      � 51      $��45��6   $��48��6&   .+�52      �� 
�������$��+��67   $
��14.4(�6@   $	��Top=�6P   $��Center=�6h   $��7q�6�   �� 53      
�������$	��new��67   $
��14.4(�6B   $��Bottom=�6R   $��Center=�6m   $��7q�6�   54      56      �� 57      $.��(Proudly created by Tunar Abuzar in 2021.��6   $	��9.6(�6I   $��Bottom=�6X   $��Center=�6s   $��10q�6�   ��58      �� 59       �� Color$ 	#FF01133D��6&    �� Opacity$
 0.22Q�68   5;      5<      5>      5?      