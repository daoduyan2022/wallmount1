   M S B A M L   `   `   `  ����  
WallMount1    WallMount1.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5      �  � RowDefinitions 5	   
   �� 5
      $
��1.5* �6   �� 5      $	��10* �6   .+�5   
   � $��0��6   $��0q�6   .+�5      �� .+�5      o� -   5         o�Name$ 	MenuStrip��5      $��12(�6*   $	��Top=�68   
�����w�.@�5      m� $��Model Maneger��6   
�������.@�5      m� -   5        $��
SetupModel��5   8   $��Setup Model��6#   6J   m� 5      -   5        $��HardwareConfig��5   C   $��Hardware Configuration��6#   6Y   5      m� 5      $
��Help��6   
�������.@�5      m� $��Manual��6#   m� 5      $��Version��6#   5      5      c� 5      
�����w�.@�5      �� $��Model:��6   $��12(�6-   $��0q�6;   $��Center=�6F   $��Center=�6c   �� 5      -   5        $��SelectModel��5      $	��100��62   $��20��6>   $��Center=�6z   
�������.@�5      �� $��Black��6'   �� 5      $��White��6'   5!      �� 5"      -   5        $��btn_play��5"       � Cursor$
 Hand��6-   $
��10,5q�6R   $��Center=�6`   .��5#      �� $`��ZF:\Vision Machine Learning\Foxconn\WallMount1\WallMount1\WallMount1\ImageItem\btn_play.jpg��6    $��20��6�   $��20��6�   5$      �� 5%      -   5        $��	btn_reset��5%      $
 Hand��6.   $	��5,5q�6T   $��Center=�6a   .��5&      �� $a��[F:\Vision Machine Learning\Foxconn\WallMount1\WallMount1\WallMount1\ImageItem\btn_reset.jpg��6    $��20��6�   $��20��6�   5'      5(      5)      5*      � 5+   
   $��1��6   $��0q�6    � ColumnDefinitions 5,      �� 5-      $��7* �6#   �� 5.      $��2* �6#   .+�50      � $��0��6   .+�51      �� $��Camera viewer��6   $��1,1,1,1q�62   $
��Bold"�6C   
���   �.��52      �� -   5        $��	imageView��52      54      55      56      � 57      $��1��6   .+�58      �� .+�59      ��  �� Orientation$ Vertical=�6!   $��5,5,5,5q�68   .+�5:      �� $��Total product:��6    $
��Bold"�69   �� 5;      -   5        $��totalOfProduct��5;   "   5<      �� 5=      $ Vertical=�6!   $��5,5,5,5q�68   .+�5>      �� $��Fail product:��6    $
��Bold"�68   �� 5?      -	   5        $��FailOfProduct��5?   "   5@      �� 5A      $ Vertical=�6!   $��5,5,5,5q�68   .+�5B      �� $��Current result��6    $
��Bold"�69   �� 5C      -
   5        $��LableResult��5C       $��READY��63   $	��150��6C   $��50��6O   ���	#FF009700$��30(�6r   $��Center=�6�   $��5q�6�   $
��Bold"�6�   5D      �� 5E      $ Vertical=�6!   $��5,5,5,5q�68   .+�5F      �� $��Calid coordinate��6    $
��Bold"�6;   5G      5H      5J      5K      5M      5N      