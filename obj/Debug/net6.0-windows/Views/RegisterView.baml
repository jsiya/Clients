   M S B A M L   `   `   `  ����B  >Clients, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:Clients.ViewsClients.Views  5   	   ;"clr-namespace:Clients.UserControlsClients.UserControls  5   	        Clients.Views.RegisterView   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:Clients.Views     5   	   ;userControls"clr-namespace:Clients.UserControls     5   	     � Title$  AllClientsView��5	   	   $	��660��6!   $	��288��6.   $	��288��6:   $	��288��6I   $	��660��6X   $	��660��6h    � WindowStartupLocation$ CenterScreen=�5
   	   .��5      � ���#F4F8FB � RowDefinitions 5   
   �� 5      �� 5      $��2* �6   �� 5      $��2* �6   �� 5      $��2* �6   �� 5      $��2* �6   �� 5      $��2* �6   �� 5      $��2* �6   �� 5      $��2* �6   �� 5      $��2* �6   �� 5      .+�5   
   � $��0��6   .+�5      �� $-��'/StaticFiles/Images/LogoClientsLogo.png��6   $��43��6E   $
��16.2��6P   $��10q�6^   $	��Top=�6j   $
��Left=�6�   �� 5      $��35��6   $��15��6    $	��Top=�6,   $��Right=�6D   $��10q�6`   
������ $��0q�5      ��5      �� 5      $
��home��6!   $��13(�6-   $��Center=�6;   $��Center=�6X   5      5       � 5!   
   $��1��6   .+�5"      �� $
��Name��6   $	��Top=�6%   $
��Left=�6=   $��10, 1q�6X   $
��14.4(�5#      #   Clients.UserControls.TextBox1  5$      $��48��6$   $	��268��60   $��Bottom=�6<   $
��Left=�6W   $
��10,0q�6r    � DataContext 5%   %   �� *NameTextBox+ �� Mode$ TwoWay=�5&      � 5'   
   $��2��6   .+�5(      �� $��Surname��6   $	��Top=�6(   $
��Left=�6@   $��10, 1q�6[   $
��14.4(�5)        5*      $��48��6$   $	��268��60   $��Bottom=�6<   $
��Left=�6W   $
��10,0q�6r    5+   %   �� *SurnameTextBox+$ TwoWay=�5,      � 5-   
   $��3��6   .+�5.      �� $��Number��6   $	��Top=�6'   $
��Left=�6?   $��10, 1q�6Z   $
��14.4(�5/        50      $��48��6$   $	��268��60   $��Bottom=�6<   $
��Left=�6W   $
��10,0q�6r    51   %   �� *PhoneTextBox+$ TwoWay=�52      � 53   
   $��4��6   .+�54      �� $��Company��6   $	��Top=�6(   $
��Left=�6@   $��10, 1q�6[   $
��14.4(�55        56      $��48��6$   $	��268��60   $��Bottom=�6<   $
��Left=�6W   $
��10,0q�6r    57   %   �� *CompanyTextBox+$ TwoWay=�58      � 59   
   $��5��6   .+�5:      �� $��Place��6   $	��Top=�6&   $
��Left=�6>   $��10, 1q�6Y   $
��14.4(�5;        5<      $��48��6$   $	��268��60   $��Bottom=�6<   $
��Left=�6W   $
��10,0q�6r    5=   %   �� *PlaceTextBox+$ TwoWay=�5>      � 5?   
   $��6��6    5@      �� 5A      �� 5B      $
��2.5* �6    .+�5D      � $��0��6   .+�5E      �� $��Registration date��6   $	��Top=�66   $
��Left=�6N   $��10, 1q�6i   $
��14.4(�5F      5G      � 5H      $��1��6    � ColumnDefinitions 5I      �� 5J      �� 5K      �� 5L      .+�5N      � $��0��6   .+�5O        $��48��6,   $
��84.4��68   $��Bottom=�6E   $
��Left=�6`   $
��10,0q�6{    5P   ,   �� *
DayTextBox+$ TwoWay=�5Q      � 5R      $��1��6   .+�5S        $��48��6,   $
��84.4��68   $��Bottom=�6E   $
��Left=�6`   $
��10,0q�6{    5T   ,   �� *MonthTextBox+$ TwoWay=�5U      � 5V      $��2��6   .+�5W        $��48��6,   $
��84.4��68   $��Bottom=�6E   $
��Left=�6`   $
��10,0q�6{    5X   ,   �� *YearTextBox+$ TwoWay=�5Y      5Z      5[      � 5\   
   $��7��6   .+�5]      �� $��How do I know him/her��6   $	��Top=�66   $
��Left=�6N   $��10, 1q�6i   $
��14.4(�5^        5_      $��48��6$   $	��268��60   $��Bottom=�6<   $
��Left=�6W   $
��10,0q�6r    5`   $   �� *DescriptionTextBox+$ TwoWay=�5a      � 5b   
   $��8��6   .+�5c      ��    BtnStyle#���   6   $��Bottom=�68   $��Center=�6S   $��40��6p   $	��268��6|   ��6�   �� *RegisterCommand+��5d      �� 5e      $��register��6    
�������60   5g      5h      � 5i   
   $��9��6   .+�5j      �� $.��(Proudly created by Tunar Abuzar in 2021.��6   $	��9.6(�6H   $��Bottom=�6W   $��Center=�6r   $��10q�6�   ��5k      �� 5l       �� Color$ 	#FF01133D��6&    �� Opacity$
 0.22Q�68   5n      5o      5p      5q      