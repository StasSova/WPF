   M S B A M L   `   `   `  ����G  CHW11_Gallery, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:HW11_Gallery.ViewHW11_Gallery.View  5      ?$clr-namespace:HW11_Gallery.ViewModelHW11_Gallery.ViewModel  5           HW11_Gallery.View.V_SignUp   5      W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:HW11_Gallery.View     5      3VM$clr-namespace:HW11_Gallery.ViewModel     5      _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	         MaterialDesignBody#���   5
      $��Regular"�5      $��13(�5      &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5         TextRenderingMode$
 Auto=�5         MaterialDesignDarkBackground#���  5        MaterialDesignFont#���  5       � DataContext 5      &    HW11_Gallery.ViewModel.VM_SignUp  5   
   .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6    � ColumnDefinitions 5   
   �� 5      $
��0.1* �6   �� 5      $��* �6   �� 5       $
��0.1* �6   .+�5#   
   �� $��1��5$      $��0��5%       $  MaterialDesignHeadline3TextBlock#��[ 5&      $��Center=�5'      $��	0,30,0,30q�5(      $��SigUp��5)      #  MaterialDesignThemes.Wpf.Card  5+   
   $��1��5,      $��1��5-      #���  5.       J� Opacity$	 0.3Q�5/      $��15q�50      51      �� 53   
   $��1��54      $��1��55      $��25q�56       �� Orientation$ Vertical=�57      .+�59      �� -   5         ��Name$ NameTextBox��5:      $��0,0,0,15q�5<      .  (MaterialDesignThemes.Wpf.TextFieldAssist   HasClearButton$
 True��5=      	   HasLeadingIcon$
	 True��5>      
   LeadingIcon$
 Account=�5?      )  #MaterialDesignThemes.Wpf.HintAssist   
HelperText$  ��5@         Hint$ Login��5A      ��5;      �� *Login+5A      �� 5D      $��0,0,0,15q�5E      $
 True��5G      $
	 True��5H      $

 Lock=�5I      $ At least 8 characters��5J      $ Password��5K      ��5F      �� *
Password+5K      �� 5N      $��0,0,0,35q�5O      $
 True��5Q      $
	 True��5R      $
 	LockReset=�5S      $ At least 8 characters��5T      $ Repeat password��5U      ��5P      �� *RepeatPassword+5U      �� 5Y      $��0,0,0,15q�5Z      $
 True��5\      $
	 True��5]      $
 AccountCircle=�5^      $
 Name��5_      ��5[      �� *Name+5_      �� 5c      $��0,0,0,55q�5d      $
 True��5f      $
	 True��5g      $
 AccountCircle=�5h      $ Surname��5i      ��5e      �� *	Surname+5i      �� 5m      +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 10��5n        MaterialDesignRaisedButton#��[ 5p       � ToolTip$3 -MaterialDesignRaisedButton with Round Corners��5r      {�5o      �� *DataContext.ControlsEnabled+ �� RelativeSource �� *FindAncestor+ �� AncestorType
 Window��5q      �� *SignUpCommand+.��5s      �� $��Sign Up��5t      5u      5v      5w      5x      