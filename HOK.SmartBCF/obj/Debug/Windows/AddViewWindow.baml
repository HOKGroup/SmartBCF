   M S B A M L   `   `   `  ����J  FHOK.SmartBCF, Version=2016.0.1.5, Culture=neutral, PublicKeyToken=null7 clr-namespace:HOK.SmartBCF.UtilsHOK.SmartBCF.Utils  5      (    "HOK.SmartBCF.Windows.AddViewWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /ut clr-namespace:HOK.SmartBCF.Utils     5        � Title$  Add View��5      $	��500��5      $	��400��6   $	��500��6'   $	��400��67    � WindowStartupLocation$ CenterScreen=�6F    � Icon$ Images/hoklogo.ico��6k    � 	Resources 5	         colorButtonStyle �� 
TargetType �� Property �� Value �� 
TargetType J� SnapsToDevicePixels	 �� Triggers
 P� Property P� Value �� 
TargetName-   'HOK.SmartBCF.Utils.ImageSourceConverter  imageConverter1   +HOK.SmartBCF.Utils.ComponentOptionConverter  OptionConverter��%�  &	        &	 �    &	 �    �� 5
   
   " ��6)   .�5      ��  �@�FocusVisualStyle 61   Z� �� 5       � �� �	#FFE6E6E66+   �� 5       � �� �#cccccc6,   �� 5       � ��$ 1q�60   �� 5       � �� �#3333336+   �� 5       � ��$ Center=�6;   �� 5       � ��$ Center=�69   �� 5       � �� 5      �� 5      " ��6&   .R�5      �� $��Chrome��6!   #��z��5   !   #��z��5   !   #��z��5   !    . ._�5      �� $��	Presenter��6/   #��z��6@   #��z��5   %   #��z��5   %   ��. # z 5   %   5      	 5       P� 5!      
 � {� .  . �5"   "   ��  � �� �#3333336?   5#      P� 5$      
 �@J�IsMouseOver . . �5%   "   ��  � �� �#1ba1e26?   �� 5&   "    � �� �#1ba1e26@   �� 5'   "    � �� �#ffffff6?   5(      P� 5)      
 � �� . . �5*   "   ��  � �� �	#FF6BC3EE6?   �� 5+   "    � �� �	#FF6BC3EE6@   �� 5,   "    � �� �#ffffff6?   5-      P� 5.      
 �@J�	IsFocused . . �5/   "   �� $ Chrome��6)    � �� �#1ba1e26T   50      52      54      55        56   
   6"     57   
   6&   58      .��59      �  � RowDefinitions 5:   
   �� 5;      $	��200 �6   �� 5<      �� 5=      $��40 �6   .+�5?   
   �� $��View Source��6   $��Stretch=�6(   $��7q�6F   $��Stretch=�6Q   .��5@      �  5A      �� 5B      $��70 �6$   �� 5C      .+�5E      	� -   5         	�Name$ radioButtonLocal��5E       d� 	IsChecked$
 TrueY�68   {�. $��
From Local��6Z   $
��Left=�6o   $��	10,10,0,0q�6�   $	��Top=�6�    	� 	GroupName$ 
ViewSource��6�   �� 5F      $��Right=�6   $��0,5,10,0q�65   $	��Top=�6G   $��80��6_   $��25��6j   #��[  5G      ��6C   �� *BrowseCommand+.��5H      ��  �� Orientation$ 
Horizontal=�6!   .+�5I      �� $��Images/browse.png��6    $��16��6;   $��16��6G   �� 5J      $��5,0,0,0q�6$   Browse6=   5K      5L      �� 5M      -   5         ��Name$ textBlockFilePath��5M      $
��Left=�68   $��	28,37,0,0q�6S   $
��Wrap=�5N      $	��Top=�60   $	��328��6H   $��33��6T   ��5O      �� *UserViewPoint.Snapshot+	� 5Q      -   5        $ radioButtonRevit��5Q      $#��From Revit - Elements Options��6Z   $
��Left=�6�   $��	10,10,0,0q�5R      $��1��61   $	��Top=�6>   $ 
ViewSource��6V   {�5Q   8   �� *IsAddInMode+5R   V   �� 5S      -   5         ��Name$ buttonCamera��5S      $��Right=�6/   $��1��6K   $��0,5,10,0q�6X   $	��Top=�6j   $	��120��6�   $��25��6�   #��[  5T      ��6C   �� *SnapshotCommand+.��5U      �� $ 
Horizontal=�6!   {�6:   ��  �� ElementName$ radioButtonRevit�� �� Path$ 	IsEnabled�.+�5V      �� $��Images/camera.png��6    $��16��6;   $��16��6G   �� 5W      $��5,0,0,0q�6$   Take Snapshot6D   5X      5Y      	� 5Z      -   5        $ radioButtonVisible��5Z      $��Only Visible��5[      $
��Left=�65   $��	45,30,0,0q�6P   $��1��6c   $	��Top=�6p   $ ElementOption��6�   {�5Z   :   �� $ radioButtonRevit��$ 	IsEnabled� 5\      �� $ SelectedOption� �� 	Converter# [  �� ConverterParameter$ OnlyVisible��	� 5]      -   5        $ radioButtonSelected��5]      $��Selected Elements��5^      $
��Left=�6:   $��	45,50,0,0q�6U   $��1��6h   $	��Top=�6u   $ ElementOption��6�   {�5]   ;   �� $ radioButtonRevit��$ 	IsEnabled� 5_      �� $ SelectedOption�# [ $ SelectedElements��	� 5`      -   5        $ radioButtonNone��5`      $
��None��5a      $
��Left=�6-   $��	45,70,0,0q�6H   $��1��6[   $	��Top=�6h   $ ElementOption��6�   {�5`   7   �� $ radioButtonRevit��$ 	IsEnabled� 5b      �� $ SelectedOption�# [ $
 None��5c      5d      �� 5e   
   -   5         ��Name$ 	imageView��5e   b   $��1��6   $��7q�6   $��Stretch=�6(   $��Stretch=�6D   $��Uniform=�5f   j   ��6   �� *UserViewPoint.SnapshotImage+# [ 6j   �� 5g   
   -	   5        $ buttonCancel��5g      #��[  6'   $��Cancel��6Q   $��Right=�6b   $��
10,5,10,10q�6~   $��2��6�   $	��Top=�6�   $��75��6�   $��25��6�   6�   �� 5h   
   -
   5        $ 	buttonAdd��5h      #��[  6$   $	��Add��6N   $��Right=�6\   $��0,5,90,0q�6x   $��2��6�   $	��Top=�5i      $��75��6)   $��25��64   ��6X   �� *
AddCommand+5j      5k      