   M S B A M L   `   `   `  ����E  ABankingApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:BankingApp
BankingApp  5          BankingApp.MainWindow   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      *localclr-namespace:BankingApp     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5        � Title$  BankApp��5      $	��800��5	      $	��450��5
       � WindowStartupLocation$ CenterScreen=�5       � WindowStyle$
 None=�5      '  !System.Windows.Shell.WindowChrome   WindowChrome 5        5   
      CaptionHeight$ 0Q�5         CornerRadius$ 0��5         GlassFrameThickness$ 0q�5      .��5      �  � ColumnDefinitions 5   
   �� 5      $	��400 �6   �� 5      $	��400 �6   .+�5   
    � -   5          �Name$
 Main��5      �� 5   
   $��0��6   
����p��.+�5      �� -   5        	 ��Name$	 upLBL��5       	  upLBL#��[  6#   �� 5      -   5        $	 
signTxtLBL��5        
signTxtLBL#��[ 6(   ��5      �� 5      $?��9Enter your personal info and create a new banking account��5      
 �� TextAlignment$
 Center=�5        �� TextWrapping$
 Wrap=�5!      5#      �� 5$      -   5         ��Name$ signBTN��5%        signBTN#��[ 5'      5(      �� 5*   
   $��1��6   
�������.+�5+      �� -   5        $	 logLBL��5+       
 logLBL#��[ 6$   �� 5-      -   5         ��Name$ emailBOX��5.        emailBOX#��[ 51      G� 53      -   5         G�Name$ passBOX��54        passBOX#��[ 57      �� 59        	forgotBTN#��[ 6   �� 5;      -   5        $ logBTN��5;       
 logBTN#��[ 6%   6E   5=      �� 5>   
   -	   5        $	 passLBL��5?      $��1��5@      $��94,248,239,179q�5A      $��Password��5B      �� 5C   
   $��1��5D      $��67,199,311,225q�5E      $��15(�5F       J� RenderTransformOrigin$ 8.791,0.214&�5G      $	��✉��5H      �� 5I   
   $��1��5J      $��67,248,311,179q�5K      $��15(�5L      $ 0.542,0.611&�5M      $
��🔒��5N      �� 5O   
   -
   5        $ closeBTN��5P      $��1��5Q      $��38��5R      $��352,10,10,414q�5S        closeBTN#��[ 5U      5V      5W      