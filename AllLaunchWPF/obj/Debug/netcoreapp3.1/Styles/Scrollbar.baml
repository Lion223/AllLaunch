   M S B A M L   `   `   `  ����D  @AllLaunch, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:AllLaunchWPFAllLaunchWPF  5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089   ScrollBarThumb  �� 
TargetType �� Property �� Value �� 
TargetType ��Name J� SnapsToDevicePixels  ActiveFocusHoverBrush �� RelativeSource �Name  BackgroundAbasementBrush �� Padding	 ]�Name
 J� IsMouseOver ]� DecreaseRepeatButton J� Opacity �� PageUpCommand ]� IncreaseRepeatButton �� PageDownCommand ]� Thumb �� Triggers P� Property P� Value �� PageLeftCommand �� PageRightCommand � ColumnDefinitions � RowDefinitions ��Name ��Name �� CanContentScroll �� CanHorizontallyScroll �� CanVerticallyScroll ��Name4   .System.Windows.Automation.AutomationProperties    AutomationId � Cursor  �� ScrollableHeight! � Maximum" � Minimum*# �� #ComputedVerticalScrollBarVisibility$ �� ViewportHeight% �� ViewportSize& � Value' �� Mode( �� ScrollableWidth) �� Orientation,* �� %ComputedHorizontalScrollBarVisibility+ �� ViewportWidth, �� Triggers- :� RoutedEvent	. W� To/ g� Duration0 �� 
TargetName1 �� TargetProperty�� 5      F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     :x,http://schemas.microsoft.com/winfx/2006/xaml     5      $localclr-namespace:AllLaunchWPF  5      %�  &	        7  '�� 3    7  7   7   '�� �    �� 5      "  n�6#   .�5   
   ��  �@�OverridesDefaultStyle$
 true��62   �� 5   
    � ��$ false��6&   �� 5   
    � �� 5	      �� 5
      " n�6"   .R�5      �� $ 	Rectangle��6   $
 True��5   !   8��  #��z��5   !   #��z��5   !   5      5      5      �� 5      "  ��6   .�5   
   ��  �@��IsPressAndHoldEnabled$ false��69   �� 5   
    �@��IsFlicksEnabled$ false��63   �� 5   
    � ��$ 10��6"   �� 5   
    � ��$ 	-10 0 0 0q�6#   �� 5   
    � �� 6%   �� *Width+ �� *Self+�� 5   
    � �� 5      �� 5      " ��6"   .R�5      � $
 Body��6   $
 true��6)   8��  .+�5       �� $ 0q�6!   ._�5!      ]� $	 
PART_Track��6$   $
��true��5"       #{�z
 5#       $��10��5$       $��Center=�5%        5&   "   �� 5'   &   $ 0Q�63   #��Z 6?    5)   "   �� 5*   &   $ 0Q�63   #��Z 6?    5,   "   n� 5-   &   8�� 6,   5/      50      51      52      54       55   
   P� 56       �@��Orientation$ 
Horizontal=�6-   . �57      ��  � ��$
 Auto��6*   �� 58       � ��$ 0��6-   �� 59       � ��$ 10��6+   �� 5:       � �� 6.   �� *Height+ �� *Self+�� 5;       � ��$ 	0 -10 0 0q�6+   �� 5=       � �� 5>      �� 5?      " ��6*   .R�5@      � $
 Body��6#   $
 true��61   .+�5A   "   ]� $	 
PART_Track��6(   #{�z
 5B   %   $��10��5C   %    5E   &   �� 5F   *   $ 0Q�67   #��Z 6C    5H   &   �� 5I   *   $ 0Q�67   #��Z 6C    5K   &   n� 5L   *   8�� 60   5N   #   5O      5P      5R      5S      5U      �� 5W      "  ��6   .�5X   
   ��  � �� 5Y      �� 5Z      " ��6"   .R�5[      � $
 Grid��6   #��z��6)    5\      �� 5]      $��* �6/   �� 5^      $
��Auto �6/    5`      �� 5a      $��* �6,   �� 5b      $
��Auto �6,   .+�5d      �� $ Corner��6$   $��1��64   #��� ��6D   $��1��6�   �� 5e      $! PART_ScrollContentPresenter��61   # z��6V   $ False��6�   $ False��6�   #��z��6�   #��z��6�   $��0��6  #��z��6.  $��0��6Q  �� 5g      $ PART_VerticalScrollBar��6$   $	 0.2Q�5h   $   $ VerticalScrollBar��5i   $   $ Arrow��5j   $   $��1��5k   $   #! z  5l   $   $" 0Q�5m   $   $��0��5n   $   #y�z# 5o   $   #% z$ 5q   $   & 5p   $   �� *VerticalOffset+$' OneWay=� �� *TemplatedParent+5q   $   �� 5s      $ PART_HorizontalScrollBar��6$   $	 0.2Q�5t   $   $ HorizontalScrollBar��5u   $   $ Arrow��5v   $   $��0��5w   $   #! z( 5x   $   $" 0Q�5y   $   $) 
Horizontal=�5z   $   $��1��5{   $   #y�z* 5|   $   #% z+ 5~   $   & 5}   $   �� *HorizontalOffset+$' OneWay=� �� *TemplatedParent+5~   $   5�      , 5�      :� 5�      $- 
MouseEnter��6'   .[�5�      �� .��5�   "   �� .��5�   &   W� . 166   $/ 0:0:0.1D�6=   $0 PART_VerticalScrollBar��6P   $1 Opacity�6   W� 5�   &   . 166   $/ 0:0:0.1D�6=   $0 PART_HorizontalScrollBar��6P   $1 Opacity�6�   5�   #   5�      5�      :� 5�      $- 
MouseLeave��6'   .[�5�      �� .��5�   "   �� .��5�   &   W� . 0.266   $/ 0:0:0.1D�6?   $0 PART_VerticalScrollBar��6R   $1 Opacity�6�   W� 5�   &   . 0.266   $/ 0:0:0.1D�6?   $0 PART_HorizontalScrollBar��6R   $1 Opacity�6�   5�   #   5�      5�      5�      5�      5�      5�      