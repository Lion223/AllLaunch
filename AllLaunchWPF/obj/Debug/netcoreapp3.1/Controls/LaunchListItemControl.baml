   M S B A M L   `   `   `  ����D  @AllLaunch, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:AllLaunchWPFAllLaunchWPF  5      H DAllLaunchCore, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullD2clr-namespace:AllLaunchCore;assembly=AllLaunchCoreAllLaunchCore 5      (    "AllLaunchWPF.LaunchListItemControl   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:AllLaunchWPF     5      Ccore2clr-namespace:AllLaunchCore;assembly=AllLaunchCore     5      $��58��5	        � 	Resources  5         ContentStyle �� 
TargetType �� Property �� Value �� 
TargetType �Name � ColumnDefinitions �� 	Converter1   +AllLaunchWPF.ApplicationStateValueConverter � RowDefinitions	 �� Orientation
 ��Name � UseLayoutRounding  LaunchListItemPlaceholder �� FallbackValue ��Name �� LineStackingStrategy �� 
LineHeight  Header3BoldTextBlock  BackgroundElevation2Brush  Header4RegularTextBlock �� Triggers P� Property P� Value �� 
TargetName  BackgroundAbasementBrush �� Value �� Binding  ActiveFocusHoverBrush " LaunchListItemPlaceholderHover��%o  &	        7  7  7  7  7  7  7  7  7  7  �� 5   
   " ��6%   .�5      ��  � �� 5      �� 5      " ��6&   .R�5      � $ 	Container��6   
������  5      �� 5   "   $
��Auto �63   �� 5   "   $��* �63   .+�5      �� $��0��6%   $��54��65   $��10��6A   ��6L   �� *State+   �� 5      $��1��6%   $��2��65   $��15 10q�6I   ._�5   "   �  5    &   �� 5!   *   $
��Auto �68   �� 5"   *   $
��Auto �68   .+�5%   &   �� $��0��61   $	 
Horizontal=�6>   .+�5'   *   �� $
 AppIcon��60   $��24��6A   $��24��6L   $
��Left=�6X   $
 True��6s   ��6�   �� *NotImplemented+8   �� 5)   *   $
 Name��64   $	��300��5*   0   $��5 0 0 0q�5+   0   $ BlockLineHeight=�5,   0   $ 22��6W   8�� $��CharacterEllipsis=�5.   0   8�� ��50   0   �� *Name+51   '   �� 54   &   $ 	Arguments��60   $��1��55   0   $
��Left=�56   0   $ BlockLineHeight=�57   0   $ 10��6W   8�� $��CharacterEllipsis=�59   0   8�� ��5;   0   �� *	Arguments+5=   #   5>      5?       5A      P� 5C       �@J�IsMouseOver$
 True��6=   . �5D   "   �� $ 	Container��6)   8   � ��6V   5E      P� 5F       �@J�IsMouseOver$ False��6>   . �5G   "   �� $ 	Container��6)    � ��
 ���� 6V   5H      �� 5J      $
 True��6I    6*   �� *
IsSelected+.a�5K   "   �� $ 	Container��6?   8   � ��6V   �� 5L   "   $
 Name��6?   8   � ��6Q   �� 5M   "   $ 	Arguments��6?   8   � ��6V   �� 5N   "   $ AppIcon��6;   8 	  � ��6P   5O      5Q      5S      5T      5U      .��5V      �� #��[  6X   5X      