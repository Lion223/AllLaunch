   M S B A M L   `   `   `  ����D  @AllLaunch, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:AllLaunchWPFAllLaunchWPF  5      H DAllLaunchCore, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullD2clr-namespace:AllLaunchCore;assembly=AllLaunchCoreAllLaunchCore 5      !    AllLaunchWPF.LaunchListPage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:AllLaunchWPF     5      Ccore2clr-namespace:AllLaunchCore;assembly=AllLaunchCore     5        N� Title$  LaunchListPage��5      .��5      �    BackgroundMainBrush#��[  6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      ��6   �� *LaunchListMenuBarHeight+ �� FallbackValue$ 48��.+�5   
   � $��0��6   .+�5      ��  �� Padding$ 20 10q�6   ._�5      ��  �� Orientation$ 
Horizontal=�6      AllLaunchWPF.MarginSetter   Margin$ 0 0 20 0q�66      LastItemMargin$ 0q�6[   .+�5      �� -   5         ��Name$ NameSortButton��5        
SortButton#��[ 6Y   $
��Name��6}   ��65   �� *NameSortCommand+6}   �� 5      -   5        $ StateSortButton��5      #��[ 6[   $��Status��6   ��66   �� *StateSortCommand+6   5      5      5       $   AllLaunchWPF.LaunchListControl  5$   
   $��1��6"      AllLaunchWPF.DropContent  5&   
   $��1��5'      $	��Top=�5)      $
��Left=�5*       � DataContext 5(      �� *NameSortPopupMenu+y�5+      �� *NameSortMenuVisible+	 �� 	Converter	 +  %AllLaunchWPF.VisibilityValueConverter  � 50   
   $��2��6     BackgroundElevation1Brush#��[ 6   
 � ColumnDefinitions
 51      �� 52      $��* �6#   6/   �� 54      $
��Auto �6#   62   �� 55      $��* �6#   6/   .+�58      �� $��1��6   $ 
Horizontal=�6)   $ 0 0 10 0q�59      $ 0q�5:      .+�5<      ��   	AddButton#��[ 6   ��6<   �� *
AddCommand+6]   �� 5=        UpdateButton#��[ 6   ��6?   �� *UpdateCommand+6c   �� 5>        RemoveButton#��[ 6   ��6?   �� *RemoveCommand+6c   �� 5?        LaunchButton#��[ 6   ��6?   �� *LaunchCommand+6c   �� 5@        
SaveButton#��[ 6   ��6=   �� *SaveCommand+6_   �� 5A        
LoadButton#��[ 6   ��6=   �� *LoadCommand+6_   �� 5B       	 ArgumentsButton#��[	 6   ��6B   �� *ArgumentsCommand+6i   5C      5D      5E      5F      