   M S B A M L   `   `   `  ����D  @AllLaunch, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:AllLaunchWPFAllLaunchWPF  5   	   H DAllLaunchCore, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullD2clr-namespace:AllLaunchCore;assembly=AllLaunchCoreAllLaunchCore 5   	       AllLaunchWPF.DialogWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:AllLaunchWPF     5   	   Ccore2clr-namespace:AllLaunchCore;assembly=AllLaunchCore     5   	     � WindowStyle$
  None=�5	   	    � 
ResizeMode$ NoResize=�5
   	    � SizeToContent$ WidthAndHeight=�5   	    � AllowsTransparency$
 True��5   	    � WindowStartupLocation$ CenterScreen=�5   	    � Title 5   	   �� *Title+��5      �� 5   
    �� 
TargetType" �6   .R�5      ��  �� Padding 6   �� *OuterMarginSizeThickness+._�5      �  J� IsHitTestVisible$
 True��6   .+�5      ��    BackgroundMainBrush#��[  6   	 J� Effect	 5      3  -System.Windows.Media.Effects.DropShadowEffect  5      
   ShadowDepth$
 0Q�6/      
BlurRadius$ 8Q�6?      Opacity$	 0.3Q�6N   5      � 5        � RowDefinitions 5!      �� 5#      $
��Auto �6,   �� 5%      $��* �6,   .+�5)      �� $��0��6!   $ 
20 20 20 0q�6U   y�6.   �� *TitleVisibility+._�5*      ��   Header1BoldTextBlock#��[ 5,   !     BackgroundElevation2Brush#��[ 5-   !   ��5+   !   �� *Title+5-   !   5/      �� 52      $��1��6!   ._�53      �� #��z��6/   54      55      56      57      58      '  !System.Windows.Shell.WindowChrome   WindowChrome 5<        5=   
      CaptionHeight$ 45Q�5?         GlassFrameThickness$ 0q�5@         CornerRadius$ 0��5A         ResizeBorderThickness 5>      �� *ResizeBorderThickness+5A      .��5F      �� $ 20q�6   ._�5G   
   �� ��6   �� *	Content+5H      5J      