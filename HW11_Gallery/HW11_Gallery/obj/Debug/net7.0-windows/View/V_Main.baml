   M S B A M L   `   `   `  ����G  CHW11_Gallery, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:HW11_Gallery.ViewModelHW11_Gallery.ViewModel  5   	   5clr-namespace:HW11_Gallery.ViewHW11_Gallery.View  5   	       HW11_Gallery.View.V_Main   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   :	viewmodel$clr-namespace:HW11_Gallery.ViewModel     5   	   1localclr-namespace:HW11_Gallery.View     5   	   _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	      MaterialDesignBody#���   5	   	   $��Regular"�5
   	   $��13(�5   	   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5   	      TextRenderingMode$
 Auto=�5   	      MaterialDesignDarkBackground#���  5   	     MaterialDesignFont#���  5   	    � Title$ V_Main��5   	   $	��550��5   	   $	��550��6   $	��800��5   	   $	��800��6    � 	Resources 5        WindowBackgroundBrush �� 
StartPoint �� EndPoint � Color � Offset�� 5   
   %�   &	       �� 5      $	 1,0&�6@   $	 0,1&�6Q   .��5      � $ #434343��6   $ 0Q�6/   � 5      $ #1d1d1d��6   $ 1Q�6/   5      5       � DataContext 5      $   HW11_Gallery.ViewModel.VM_Main  5    
   .��5#      � #���  5$   	   	 � RowDefinitions	 5%   
   �� 5'      $��* �6   �� 5)      $
��auto �6   .+�5-   
   � $��0��5.      
 � ColumnDefinitions
 5/      �� 51      $
��auto �6#   �� 53      $��* �6#   �� 55      $
��auto �6#   .+�58      �� $��0��59      $��40q�5:      +  %MaterialDesignThemes.Wpf.SliderAssist   HideActiveTrack$ False��5;       � Minimum$ 0Q�5=       �� Orientation$ Vertical=�5>         MaterialDesignDarkForeground#���  5?         MaterialDesignDiscreteSlider#��[ 5@       �� TickPlacement$
 Both=�5B       � Maximum 5<      �� *MaximumImages+ �� TickFrequency 5A      �� * DiscreteVertical.TickFrequency+ � Value 5C      �� *CurrentPosition+ �� Mode$ TwoWay=�� 5F      -   5         �Name$ 	outerGrid��5G      $��1��5H      $
��0 25q�5I      .+�5K      &   MaterialDesignThemes.Wpf.Flipper    MaterialDesignCardFlipper#���  5N      ��5L      �� *ActualHeight+ �� ElementName$ 	outerGrid����5M      �� *ActualWidth+$ 	outerGrid��   FrontContent 5Q      � 5R      $
��auto��5S      $
��auto��5T      .+�5V      �� $��Center=�5W   !   $��Center=�5X   !   $��Uniform=�5Z   !   ��5Y   !   �� *CurrentImage.PathToPhoto+5Z   !   �� 5]      $
��auto��5^   !   $
��auto��5_   !   $�� ��5`   !      FlipCommand#��Z 5a   !      MaterialDesignFlatDarkButton#��[ 5b   !    � ToolTip$ 	More info��5c   !   � 5f      
 5g   "   �� 5h   &   $
��auto �67   �� 5i   &   $��* �67   �� 5j   &   $
��auto �67   .+�5n   "   �� $��0��5o   %   $��15 0 0 0q�5p   %     MaterialDesignBodyLight#���  5q   %   #���  5r   %    	 MaterialDesignIconButton#��[	 5t   %   $ 
Back image��5u   %   {�5s   %   �� *DataContext.ControlsEnabled+ �� RelativeSource �� *FindAncestor+ �� AncestorType
 Window��5v   %   �� *PrevImagesCommand+.��5w   &   '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ ChevronLeft=�5x   )   5y   #   �� 5|   "   $��2��5}   %   $��0 0 15 0q�5~   %   #���  5   %   #���  5�   %   #��[	 5�   %   $ 
Next image��5�   %   {�5�   %   �� *DataContext.ControlsEnabled+ �� *FindAncestor+
 Window��5�   %   �� *NextImagesCommand+.��5�   &     $ ChevronRight=�5�   )   5�   #   5�      5�         BackContent 5�      � 5�      $��Center=�5�      $
��auto��5�      $
��auto��5�      	 5�      �� 5�   "   $
��Auto �60   �� 5�   "   $��* �60   .+�5�      (  "MaterialDesignThemes.Wpf.ColorZone  $��0��5�   %   $��6q�5�   %      Mode$ PrimaryDark=�5�   %   .��5�   "   ��  �� Orientation$ 
Horizontal=�5�   %   .+�5�   &   �� $
��Left=�5�   )   #��Z 5�   )    &
 "MaterialDesignToolForegroundButton#��[
 5�   )   .��5�   *     $��Right=�5�   -   $ 	ArrowLeft=�5�   -   5�   '   �� 5�   &   $��8,0,0,0q�5�   )   $��Center=�5�   )   $��BACK TO IMAGE��5�   )   5�   #   5�        5�      $��1��5�   !   $��16q�5�   !   .  (MaterialDesignThemes.Wpf.ElevationAssist   	Elevation$	 Dp4=�5�   !   $}�False��5�   !      CornerRadius$ 	0 0 25 25��5�   !   $ 
PrimaryMid=�5�   !   .��5�   "   �� $ Vertical=�5�   %   $��25 25q�5�   %   .+�5�   &   �� $ 
Horizontal=�5�   )   .+�5�   *   ��  $  MaterialDesignHeadline6TextBlock#��[ 5�   -   $��0 0 15 0q�5�   -   $��AUTHOR: ��5�   -   �� 5�   *   #��[ 5�   -   ��5�   -   �� *CurrentImage.Author+5�   '   �� 5�   &   $��0 25 0 0q�5�   )   $ 
Horizontal=�5�   )   .+�5�   *   �� #��[ 5�   -   $��0 0 15 0q�5�   -   $��NAME: ��5�   -   �� 5�   *   #��[ 5�   -   ��5�   -   �� *CurrentImage.Name+5�   '   �� 5�   &   $��0 25 0 0q�5�   )   $ 
Horizontal=�5�   )   .+�5�   *   �� #��[ 5�   -   $��0 0 15 0q�5�   -   $��DATE: ��5�   -   �� 5�   *   #��[ 5�   -   ��5�   -   �� *CurrentImage.Date+5�   '   5�   #   5�      5�      5�      5�      �� 5�      $��2��5�      $ False��5�      $��40q�5�      $ 0Q�5�      $ Vertical=�5�      #���  5�      #��[ 5�      $
 Both=�5�       5�      �� *MaximumImages+ 5�      �� * DiscreteVertical.TickFrequency+ 5�      �� *CurrentPosition+$ TwoWay=�5�      � 5�   
   $��1��5�      $
��auto��5�      
 5�      �� 5�      $��* �6#   �� 5�      $��* �6#   �� 5      $��* �6#   .+�5     �� $ 
Horizontal=�5     $��0��5     .+�5     � $��2��5	     $��
15 25 5 25q�5
     $
��auto��5     $��Center=�5     $��Stretch=�5     .+�5     �� $	��2,0q�5     3  -MaterialDesignThemes.Wpf.ButtonProgressAssist    IsIndeterminate$
  True��5     !   IsIndicatorVisible$
! True��5     "   IndicatorForeground
" �   �#���  5     $��	ADD IMAGE��5       MaterialDesignFlatButton#��[ 5     ��5     �� *AddImagesCommand+5     5     � 5     $��2��5     $��
5 25 15 25q�5     $
��auto��5     $��Center=�5     $��Stretch=�5     .+�5     �� $	��2,0q�5      $
  True��5!     $
! True��5"     
" �   �#���  5$     $��SAVE IMAGES��5%     #��[ 5'     ��5&     �� *SaveImagesCommand+5'     5(     5*     � 5-     $��1��5.     $��Center=�5/     	 50     �� 51     $
��auto �6$   �� 52     $
��auto �6$   .+�54     (	  "MaterialDesignThemes.Wpf.RatingBar	  $��Center=�55     $��0��56     # 	  IsPreviewValueEnabled$
# True��57     
$ 	  Min$$ 0��58     % 	  ValueIncrements$
% 0.25Q�59     & 	  Value& 5:     �� *CurrentImage.MyMark+$ TwoWay=��� 5;     $��Center=�5<     $��1��5=     #���  5>      $  MaterialDesignSubtitle1TextBlock#��[ 5?     $ Average rating��5@     ��5A     �� *CurrentImage.AvaregeRating+5B     �� 5E     $ 
Horizontal=�5F     $��2��5G     .+�5I     � $��0��5J     $��15 25q�5K     $	��100��5L     $��Center=�5M     $��Stretch=�5N     .+�5O     �� $	��2,0q�5P     $
  True��5Q     $
! True��5R     
" �   �#���  5T     $��START��5U     #��[ 5W     ��5V     �� *StartImagesCommand+5W     5X     � 5[     $��2��5\     $��15 25q�5]     $	��100��5^     $��Center=�5_     $��Stretch=�5`     .+�5a     �� $	��2,0q�5b     $
  True��5c     $
! True��5d     
" �   �#���  5f     $	��END��5g     #��[ 5i     ��5h     �� *EndImagesCommand+5i     5j     5k     5m     5n     5o     