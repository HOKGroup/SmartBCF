   M S B A M L   `   `   `  ���� c  _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35qPclr-namespace:System.Windows.Interactivity;assembly=System.Windows.InteractivitySystem.Windows.Interactivity  J FHOK.SmartBCF, Version=2016.0.1.5, Culture=neutral, PublicKeyToken=nullM6clr-namespace:HOK.SmartBCF.Utils;assembly=HOK.SmartBCFHOK.SmartBCF.Utils P LHOK.SmartBCF.AddIn, Version=2016.0.1.6, Culture=neutral, PublicKeyToken=nullA%clr-namespace:HOK.SmartBCF.AddIn.UtilHOK.SmartBCF.AddIn.Util O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem (   "HOK.SmartBCF.AddIn.ComponentWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     ^iPclr-namespace:System.Windows.Interactivity;assembly=System.Windows.Interactivity     Eut6clr-namespace:HOK.SmartBCF.Utils;assembly=HOK.SmartBCF     5aut%clr-namespace:HOK.SmartBCF.AddIn.Util     6sys&clr-namespace:System;assembly=mscorlib     $	��700��$	��450��$	��700��$	��450��$	��700��$	��450��  � Title$  Revit Elements�� � Icon$ Resources/hoklogo.ico�� � WindowStartupLocation$ CenterScreen=� � UseLayoutRounding .  � 	Resources '  !HOK.SmartBCF.Utils.ColorConverter   colorConverter1  +HOK.SmartBCF.Utils.ExtensionFilterConverter  extensionConverter(  "HOK.SmartBCF.Utils.BitmapConverter  bitmapConverter0  *HOK.SmartBCF.AddIn.Util.ComponentConverter  componentConverter 
 action  responsibility  extensionTemplate � ColumnDefinitions �� Path �� 	Converter  buttonStyle �� 
TargetType	 �� Property
 �� Value �� 
TargetType J� SnapsToDevicePixels �� Triggers P� Property P� Value �� 
TargetName��%-  &	        &	      &	 
     &	      &	      &	 (     &	 D     7   &	 �             ��
BCF_Action����BCF_Responsibility���� .R��  �� $��30 ��� .+��� $��Stretch=�$��Stretch=�$��2q����� $ Color�8   �� $��1��$��Stretch=�$��Stretch=�$��2q����� *ParameterValue+�� " ��.��� 	 �@�FocusVisualStyle
 Z� �� 	 � ��
 �	#FFE6E6E6�� 	 � ��
 �#cccccc�� 	 � ��$
 1q��� 	 � ��
 �#333333�� 	 � ��$
 Center=��� 	 � ��$
 Center=��� 	 � ��$
 	16,3,16,3q��� 	 � ��
 �� " ��.R��� $��Chrome��#��z��#��z��#��z�� . ._��� $��	Presenter��#��z��#��z��#��z����. # z  P�  � {� .  . ��� 	 � ��
 �#333333P�  �@J�IsMouseOver . . ��� 	 � ��
 �#1ba1e2�� 	 � ��
 �#1ba1e2�� 	 � ��
 �#ffffffP�  � �� . . ��� 	 � ��
 �	#FF6BC3EE�� 	 � ��
 �	#FF6BC3EE�� 	 � ��
 �#ffffffP�  �@J�	IsFocused . . ��� $ Chrome��	 � ��
 �#1ba1e2.���  � RowDefinitions �� $	��100 ��� �� $��80 ��� $��50 ��� $��25 �.+��� -    ��Name$ comboBoxComponent��$��Center=�$��Center=�$��60��$	��200��
������ $
��Left=�$��Center=����� *FilteredComponents+ �� SelectedIndex �� *SelectedComponentIndex+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=����� .R��  �� $��60 ��� .+��� $��Stretch=�$��Stretch=�$��2q����� *PreviewImage+# [ �� $��1��$��Stretch=�$��Center=�$��5,2,2,2q����� *ElementName+.   (System.Windows.Interactivity.Interaction   Triggers /   )System.Windows.Interactivity.EventTrigger     	EventName$ SelectionChanged��.   (System.Windows.Interactivity.TriggerBase   Actions. 6   0System.Windows.Interactivity.InvokeCommandAction     Command �� *ApplyViewCommand+�� -    ��Name$ 
buttonNext��$��	260,0,0,0q�$��Center=�$��Center=�$��54��$��54��
������ 
������ $��forward������ *MoveComponentCommand+���� " ��.R���  ��Name$ nextImg��$��Resources/next.png��$��48��$��48�� P�  �@J�IsMouseOver . . ��� 	 � ��

 ���� �� 	 � ��

 ���� �� $ nextImg��	 � ��$
 Resources/next_blue.png��P�  � �� . . ��� 	 �@J�Opacity$	
 0.6Q��� -   $ 
buttonBack��$��
-260,0,0,0q�$��Center=�$��Center=�$��54��$��54��
������ 
������ $��backward������ *MoveComponentCommand+���� " ��.R��� $ backImg��$��Resources/back.png��$��48��$��48�� P�  �@J�IsMouseOver . . ��� 	 � ��

 ���� �� 	 � ��

 ���� �� $ backImg��	 � ��$
 Resources/back_blue.png��P�  � �� . . ��� 	 �@J�Opacity$	
 0.6Q�� $��1��$��3�����	#FFF9F9F9�� $��BCF Information��$��1��$��Stretch=�$��5q�$��Stretch=�.���  �� �� $
��Auto ��� �� �� �� $��20 ��� �� �� �� $��20 ��� ��  �� $	��120 ��� .+��� $��
BCF Name: ��$��Right=�$��Center=�$��0,0,10,0q��� $��Topic: ��$��1��$��Right=�$��Center=�$��0,0,10,0q��� $��Topic Type: ��$��2��$��Right=�$��Center=�$��0,0,10,0q��� $��Topic Status: ��$��3��$��Right=�$��Center=�$��0,0,10,0q��� $��Assigned To: ��$��4��$��Right=�$��Center=�$��0,0,10,0q��� $��	Comment: ��$��6��$��Right=�$��Center=�$��0,0,10,0q��� $��Author: ��$��7��$��Right=�$��Center=�$��0,0,10,0q��� $��Date: ��$��8��$��Right=�$��Center=�$��0,0,10,0q��� $��Action: ��$��10��$��Right=�$��Center=�$��0,0,10,0q��� $��Responsibility: ��$��11��$��Right=�$��Center=�$��0,0,10,0q��� -    ��Name$ textBlockBCFName��$��5,0,15,0q�$��1��$��Stretch=�$��Center=�$
��Wrap=����� *SelectedBCF.ZipFileName+�� $��1��$��1��$
��Auto=�$��Stretch=�$��5q�$
��Left=�$��Center=�$��80��.���� -   $ textBlockTopic��$��1��$��1��$��Stretch=�$��Stretch=�$
��Wrap=�$
��Bold"����� *SelectedMarkup.Topic.Title+�� -   $ textBlockTopicType��$��5,0,15,0q�$��1��$��2��$��Stretch=�$��Center=�$
��Wrap=����� * SelectedMarkup.Topic.TopicType+�� -   $ textBlockTopicStatus��$��5,0,15,0q�$��1��$��3��$��Stretch=�$��Center=�$
��Wrap=����� *" SelectedMarkup.Topic.TopicStatus+�� -   $ textBlockAssignedTo��$��5,0,15,0q�$��1��$��4��$��Stretch=�$��Center=�$
��Wrap=����� *!SelectedMarkup.Topic.AssignedTo+�� -	   $ comboBoxComment��$��5,0,15,0q�$��1��$��6��$��Stretch=�$��Center=�
������ $��27�� �� DisplayMemberPath$ Comment1������ *
Comments+ �� SelectedItem �� *SelectedComment+�� -
   $ textBlockAuthor��$��5,0,15,0q�$��1��$��7��$��Stretch=�$��Center=�$
��Wrap=�����  �� ElementName$ comboBoxComment��$! SelectedItem.ModifiedAuthor��� -   $ textBlockDate��$��5,0,15,0q�$��1��$��8��$��Stretch=�$��Center=�$
��Wrap=����� $ comboBoxComment��$ SelectedItem.ModifiedDate��� -   $ comboBoxAction��$��5,0,15,0q�$��1��$��10��$��Stretch=�$��Center=�
������ $��27��#��[ ���� *'%SelectedBCF.ExtensionColor.Extensions+# [   �� ConverterParameter#  [  �� $ comboBoxComponent��$ SelectedItem.Action�   $ SelectionChanged��.    �� *ComponentChangedCommand+�� -   $ comboBoxResponsibility��$��5,0,15,0q�$��1��$��11��$��Stretch=�$��Center=�
������ $��27��#��[ ���� *'%SelectedBCF.ExtensionColor.Extensions+# [ #  [  �� $ comboBoxComponent��$! SelectedItem.Responsibility�   $ SelectionChanged��.    �� *ComponentChangedCommand+�� $��View Options��$��2��$��Stretch=�$��Stretch=�$��5,0,5,5q�.���  �� �� �� .+��� -   ! ��Name$! checkBoxHighlight��$��Highlight Element��$��Center=�$��Center=�" d� 	IsChecked" �� *IsHighlightChecked+$ TwoWay=����� *HighlightCommand+���� " ��# �� Triggers# �� $ �� Binding$ �� *SelectedItem.IsLinked+$ comboBoxComponent��% �� Value% True.a��� 	 �@d�	IsChecked$
 FalseY��� 	 � {�
 .  �� -   $! checkBoxIsolate��$��1��$��Isolate Element��$��Center=�$��Center=�" �� *IsIsolateChecked+$ TwoWay=����� *IsolateCommand+���� " ��# �� $ �� *SelectedItem.IsLinked+$ comboBoxComponent��% True.a��� 	 �@d�	IsChecked$
 FalseY��� 	 � {�
 .  �� -   $! checkBoxSectionBox��$��2��$��Place Section Box��$��Center=�$��Center=�" �� *IsSectionBoxChecked+���� *SectionboxCommand+�� -   $ buttonClose��#��[ $��3��$��	0,5,10,10q�$��Close��$��Right=�$	��Top=�$��27��$��80���� -   $ buttonWriteParam��#��[ $��3��$��	0,5,95,10q�$��Right=�$	��Top=�$��27��$	��150������ *WriteParametersCommand+.���� & �� Orientation$& 
Horizontal=�.+��� $��20��$��20��$��Resources/notepad.png���� $��5,0,0,0q�$��Write Parameters���� -   $ buttonFilter��#��[ $��3��$��	0,5,250,0q�$��Right=�$	��Top=�$��27��$	��130��.���� $& 
Horizontal=�.+��� $��20��$��20��$��Resources/filter.png���� $��5,0,0,0q�$��Apply Filters���� $��Stretch=�$��Stretch=�$��0q�$��4��.@��� .���� ���� *	IndexText+