   M S B A M L   `   `   `  ����  CybersecuritychatbotGUI(    "CybersecuritychatbotGUI.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Cybersecurity Chatbot��5   	   $	��650��6'   $	��750��64    � 
ResizeMode$ NoResize=�5   	    � WindowStartupLocation$ CenterScreen=�6   ���#1B263B.��5	      � $��20q�6   .+�5
   
   �� ���#FFFFFF �� CornerRadius$ 12��6&    �� Padding$ 20q�68   ���#3E5C76$��1q�5   '   ._�5      �  � RowDefinitions 5      �� 5      $
��Auto �6$   �� 5      $
��Auto �6$   �� 5      $
��Auto �6$   �� 5      $
��Auto �6$   �� 5      $��* �6$   �� 5      $
��Auto �6$   �� 5      $
��Auto �6$   �� 5      $
��Auto �6$   .+�5      �� $��Cybersecurity Chatbot��6   $��26(�69   $
��Bold"�6G   ���#1B263B$��0,0,0,20q�5   1   �� 5      $��Enter a Cyber Threat:��6   $��1��68   $��14(�6E   $��SemiBold"�5      ���#3E5C766.   �� 5!      -   5         ��Name$ txtThreatInput��5!      $��2��62   $��35��6?   $��14(�6K   $��0,5,0,15q�5"      $��10q�6,   ���#F0F4F8���#BCCCDC���#1B263B5#   0   �� 5&      $��3��6    �� Orientation$ 
Horizontal=�6*   $
��Left=�6C   $��0,0,0,15q�6^   .+�5'      �� -   5         ��Name$ 	btnSearch��5'      $��Search Definition��60   $	��150��6L   $��35��6X   6d   �� 5(      -   5        $ btnTips��5(      $��Get Tips��6.   $	��100��6A   $��35��6M   6Y   �� 5)      -   5        $ btnTaskManager��5)      $��Open Task Manager��65   $	��160��6Q   $��35��6]   6i   �� 5*      -   5        $ btnStartQuiz��5*      $��Start Cybersecurity Quiz��63   $	��180��6V   $��35��6b   6n   5+      �� 5.      -   5        $ 	txtOutput��5.      $��4��6-   $��0,0,0,20q�6:   	 �� TextWrapping$
	 Wrap=�5/      
 �� AcceptsReturn$

 True��6.   " �� VerticalScrollBarVisibility$
 Auto=�50       �� 
IsReadOnly$
 True��6=   $��14(�51      $��10q�6(   $	��180��65   ���#F8F9FA���#BCCCDC���#1B263B53      �� 56      $1��+Ask the Assistant (Natural Language Input):��6   $��5��6N   $��14(�57      $��SemiBold"�6&   ���#3E5C766<   �� 5:      -   5        $ txtNLPInput��5:      $��6��6/   $��35��6<   $��14(�6H   $��0,5,0,15q�5;      $��10q�6,   ���#F0F4F8���#BCCCDC���#1B263B5<   0   �� 5?      -   5        $ btnProcessNLP��5?      $��Process Request��60   $��7��6J   $	��150��5@      $��35��6%   61   5A      5B      5C      5D      