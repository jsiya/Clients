   M S B A M L   `   `   `  ����B  >Clients, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:Clients.ViewsClients.Views  5   	   ;"clr-namespace:Clients.UserControlsClients.UserControls  5   	   7 clr-namespace:Clients.ViewModelsClients.ViewModels  5   	       Clients.Views.LoginView   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:Clients.Views     5   	   ;userControls"clr-namespace:Clients.UserControls     5   	   7
viewModels clr-namespace:Clients.ViewModels     5   	   -   5          �Name$  	LoginPage��5   	    � Title$ 	LoginView��5
   	   $	��592��6   $	��288��6(   $	��288��64   $	��288��6C   $	��592��6R   $	��592��6b    � WindowStartupLocation$ CenterScreen=�5   	   .��5      � ���#F4F8FB � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      .+�5   
   � $��0��6   .+�5      �� $-��'/StaticFiles/Images/LogoClientsLogo.png��6   $
��94.2��6E   $
��36.4��6R   $��97, 45.6, 0, 0q�6`   $	��Top=�6x   $
��Left=�6�   5      � 5   
   $��1��6   .+�5      �� $��username��6   $
��19.2(�6(   $��101 ,19.4, 0, 0q�68   $	��Top=�6Q   $
��Left=�6i   #   Clients.UserControls.TextBox1  5      $
��48.2��6$   $	��268��62   $��10, 50q�6>   $
��Left=�6N    � DataContext 5      �� *TextBoxUsername+ �� Mode$ TwoWay=�5      � 5   
   $��2��6   .+�5      �� $��password��6   $
��19.2(�6(   $��101 ,19.4, 0, 0q�68   $	��Top=�6Q   $
��Left=�6i     5      $
��48.2��6$   $	��268��62   $��10, 50q�6>   $
��Left=�6N    5    %   �� *TextBoxPassword+$ TwoWay=�5!      � 5"   
   $��3��6    5#      �� 5$      $��3* �6    �� 5%      .+�5'      � $��0��6   .+�5(      ��    BtnStyle#���   6   $��Bottom=�6<   $��Center=�6W   $��40��6t   $	��268��6�   ��6�   �� *LoginCommand+��5)      �� 5*      $��log in��6$   
�������62   5,      5-      � 5.      $��1��6   .+�5/      �� $.��(Proudly created by Tunar Abuzar in 2021.��6   $	��9.6(�6L   $��Bottom=�6[   $��Center=�6v   $��10q�6�   ��50      �� 51       �� Color$ 	#FF01133D��6*    �� Opacity$
 0.22Q�6<   53      54      55      56      57      