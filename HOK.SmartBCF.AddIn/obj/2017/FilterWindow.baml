   M S B A M L   `   `   `  ����   HOK.SmartBCF.AddIn%    HOK.SmartBCF.AddIn.FilterWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008       � Title$  Component Filters�� � Icon$ Resources/hoklogo.ico��$	��500��$	��300��$	��500��$	��300�� � WindowStartupLocation$ CenterOwner=� � 	Resources    buttonStyle �� 
TargetType �� Property �� Value �� 
TargetType J� SnapsToDevicePixels	 �� Triggers
 P� Property P� Value �� 
TargetName��%�  &	        �� " ��.���  �@�FocusVisualStyle Z� ��  � �� �	#FFE6E6E6��  � �� �#cccccc��  � ��$ 1q���  � �� �#333333��  � ��$ Center=���  � ��$ Center=���  � ��$ 	16,3,16,3q���  � �� �� " ��.R��� $��Chrome��#��z��#��z��#��z�� . ._��� $��	Presenter��#��z��#��z��#��z����. # z 	 P� 
 � {� .  . ���  � �� �#333333P� 
 �@J�IsMouseOver . . ���  � �� �#1ba1e2��  � �� �#1ba1e2��  � �� �#ffffffP� 
 � �� . . ���  � �� �	#FF6BC3EE��  � �� �	#FF6BC3EE��  � �� �#ffffffP� 
 �@J�	IsFocused . . ��� $ Chrome�� � �� �#1ba1e2.���  � RowDefinitions �� �� $��40 �.+��� $��
Categories��$��Stretch=�$��7q�$��Stretch=�.���  �� �� $��30 �.+��� -    ��Name$ listboxCategory��$��Stretch=�$��Stretch=�$��5q����	#FFCFD0D1���� .R��� .+��� ���� *CategoryName+ d� 	IsChecked �� *
Selected+�� -    ��Name$ 	buttonAll��$��5,0,0,0q�$��1��$
��Left=�$	��Top=�$��22��$��22�����#cccccc.����  �� Orientation$ 
Horizontal=�.+��� $��16��$��16��$ ��Resources/checkbox_yes.png���� -   $ 
buttonNone��$��32,0,0,0q�$��1��$
��Left=�$	��Top=�$��22��$��22�����#cccccc.���� $ 
Horizontal=�.+��� $��16��$��16��$��Resources/checkbox_no.png���� -   $ buttonApply��$��Apply��#��[  $��Right=�$��	0,10,10,0q�$	��Top=�$��75��$��1���� -   $ buttonCancel��$��Cancel��#��[  $��Right=�$��	0,10,90,0q�$	��Top=�$��75��$��1��