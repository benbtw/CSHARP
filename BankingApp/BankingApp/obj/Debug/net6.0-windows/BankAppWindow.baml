   M S B A M L   `   `   `  ����E  ABankingApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:BankingApp
BankingApp  5          BankingApp.BankAppWindow   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      *localclr-namespace:BankingApp     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5        � Title$  BankAppWindow��5      $	��800��5	      $	��450��5
       � WindowStartupLocation$ CenterScreen=�5       � WindowStyle$
 None=�5      '  !System.Windows.Shell.WindowChrome   WindowChrome 5        5   
      CaptionHeight$ 0Q�5         CornerRadius$ 0��5         GlassFrameThickness$ 0q�5      .��5      �  � ColumnDefinitions 5   
   �� 5      $	��200 �6   �� 5      $	��600 �6   .+�5   
   �� $��0��6   
����p��.+�5      �� $��60��6   �� 5      $	��180��5      $��	Dashboard��5         navBTNS#��[  5       �� 5!      $��30��6   �� 5#      $	��180��5$      $��Transactions��5%      #��[  5&      �� 5'      $��30��6   �� 5)      $	��180��5*      $��Deposit��5+      #��[  5,      �� 5-      $��30��6   �� 5/      $	��180��50      $��Withdraw��51      #��[  52      �� 53      $��30��6   55      �� 57   
   $��1��6    �� Orientation$ 
Horizontal=�6%   .+�58       � -   5        	  �Name$
	 Main��58      �� 59      $��
50,0,0,200q�6    	 cards#��[ 6)   �� 5:      $��100,0,0,200q�6   #��[ 6*   5;      �� 5<   
   $��1��6   $ Vertical=�6%   .+�5=      �� -   5        
 ��Name$
 Transactions��5>      $	��302��5?      $	��150��5@      $��	0,290,0,0q�5A      .@�5B      �� $��Item1��6   �� 5C      $��Item1��6   �� 5D      $��Item1��6   �� 5E      $��Item1��6   5F      5G      �� 5H   
   $��1��5I      $��244,241,244,174q�5J      $��Transactions��5K      $��17(�5L      
����p��5M      �� 5N   
   $��1��5O      $��68,50,384,361q�5P      $��Checking Account��5Q      $��15(�5R      
�������5S      �� 5T   
   $��1��5U      $��364,50,112,365q�5V      $��Savings Account��5W      $��15(�5X      
�������5Y      �� 5Z   
   $��1��5[      $��364,76,51,296q�5\      $��200.45��5]      $��60(�5^      
�������5_      �� 5`   
   $��1��5a      $��68,76,332,296q�5b      $��200.45��5c      $��60(�5d      
�������5e      �� 5f   
   -   5         ��Name$ closeBTN��5g      $��1��5h      $��562,5,10,415q�5i        closeBTN#��[ 5k      5l      5m      