   M S B A M L   `   `   `  ����E  ABankingApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:BankingApp
BankingApp  5          BankingApp.SignUpWindow   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      *localclr-namespace:BankingApp     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5        � Title$  BankApp��5      $	��800��5	      $	��450��5
       � WindowStartupLocation$ CenterScreen=�5       � WindowStyle$
 None=�5      '  !System.Windows.Shell.WindowChrome   WindowChrome 5        5   
      CaptionHeight$ 0Q�5         CornerRadius$ 0��5         GlassFrameThickness$ 0q�5      .��5      �  � ColumnDefinitions 5   
   �� 5      $	��400 �6   �� 5      $	��400 �6   .+�5   
    � -   5          �Name$
 Main��5      �� 5   
   $��0��6   
����p��.+�5      �� -   5        	 ��Name$	 upLBL��5      $��Login��5       	  upLBL#��[  5      �� 5      -   5        $	 
signTxtLBL��5        
signTxtLBL#��[ 6(   ��5       �� 5!      $9��3Already have an account? click the button to login!��5"      
 �� TextAlignment$
 Center=�5#       �� TextWrapping$
 Wrap=�5$      5&      �� 5'      -   5         ��Name$ logInBTN��5(      $��Login��5*        signBTN#��[ 5+      5,      �� 5.   
   $��1��6   
�������.+�5/      �� -   5        $	 logLBL��50      $��Sign Up��51       
 logLBL#��[ 52      �� 54      -   5         ��Name$ emailBOX��55        emailBOX#��[ 58      G� 5:      -   5         G�Name$ passBOX��5;        passBOX#��[ 5>      �� 5@      -   5        $ 	signUpBTN��5A      $��Create Account��5B       
 logBTN#��[ 5C      5E      �� 5F   
   -	   5        $	 passLBL��5G      $��1��5H      $��94,248,239,179q�5I      $��Password��5J      �� 5K   
   $��1��5L      $��67,199,311,225q�5M      $��15(�5N       J� RenderTransformOrigin$ 8.791,0.214&�5O      $	��✉��5P      �� 5Q   
   $��1��5R      $��67,248,311,179q�5S      $��15(�5T      $ 0.542,0.611&�5U      $
��🔒��5V      5W      5X      