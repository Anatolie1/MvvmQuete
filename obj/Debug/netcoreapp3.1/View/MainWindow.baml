   M S B A M L   `   `   `  ����D  @MvvmQuete, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:MvvmQuete	MvvmQuete  5   	       MvvmQuete.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:MvvmQuete     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � $��0,0,0,20q�6    � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   �� -   5        $��ShopGrid��5      $��1��6#   $��10,100,10,10q�60   ��6G   �� *Shops+ �� View 5      �� 5      -   5        grdTest��.P�5      �� $��ShopId��6%    �� Width$	 150��6]    �� DisplayMemberBinding 65   �� *ShopId+6]   �� 5      $��ShopName��6%   $	 150��6b    67   �� *
ShopName+6b   �� 5      $��Country��6%   $	 150��6_    66   �� *	Country+6_   5      5      �� 5   
   -   5        $��	txtShopId��5   Y   $��1��6   $��23��6   $
��Left=�6+   $��	80,10,0,0q�6F   $	��Top=�6j   $	��178��6�   ��6�   ��  �� ElementName$ ShopGrid�� �� Path$ SelectedItem.ShopId��� 5   
   -   5        $��txtShopName��5   Y   $��1��6   $��23��6   $
��Left=�6+   $��	80,40,0,0q�6F   $	��Top=�6l   $	��178��6�   ��6�   �� $ ShopGrid��$ SelectedItem.ShopName��� 5   
   -   5        $��
txtCountry��5   Y   $��1��6   $��23��6   $
��Left=�6+   $��	80,70,0,0q�6F   $	��Top=�6k   $	��178��6�   ��6�   �� $ ShopGrid��$ SelectedItem.Country��� 5   
   -   5        $��label1��5   ^   $��ShopId��6   $��1��6!   $
��Left=�6.   $��12,12,0,274q�6I   6^   �� 5   
   -   5        $��label2��5   j   $��ShopName��6   $��1��6#   $��28��60   $
��Left=�6<   $��	12,35,0,0q�6W   $	��Top=�6x   �� 5   
   -   5        $��label3��5   i   $��Country��6   $��1��6"   $��28��6/   $
��Left=�6;   $��	12,60,0,0q�6V   $	��Top=�6w   �� 5   
   -	   5        $��
btnAddShop��5   k   $��AddShop��6   $��1��6#   $��23��60   $
��Left=�6<   $��
310,40,0,0q�6W   $	��Top=�5      $	��141��6)   ��5       �� $ UpdateCommad�69   5!      5"      