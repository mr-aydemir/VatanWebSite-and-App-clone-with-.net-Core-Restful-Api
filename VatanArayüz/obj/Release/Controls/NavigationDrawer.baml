   M S B A M L   `   `   `  ���� G  CVatanArayüz, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null_4clr-namespace:NavigationDrawerControlForWPF.Controls&NavigationDrawerControlForWPF.Controls  \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089   MenuDarkSurfaceBrush  �� Color  DefaultBlueBrush  MenuLighterBlueBrush  ShowMenuButtonStyle �� 
TargetType �� Property �� Value �� 
TargetType �� Padding �� Orientation J� SnapsToDevicePixels �� Stretch	 �� Triggers
 :� RoutedEvent �� TargetProperty	 �� To g� Duration=    7NavigationDrawerControlForWPF.Controls.NavigationDrawer � RowDefinitions'  !System.Windows.VisualStateManager   VisualStateGroups%  System.Windows.VisualStateGroup   Transitions%  System.Windows.VisualTransition   GeneratedDuration   States   System.Windows.VisualState   
Storyboard �� 
TargetName	 W� To g� 	BeginTime �� KeyTime �� Value    	MenuWidth K� ZIndex    Content � ColumnDefinitions ��Name ��Name J� IsHitTestVisible     MenuBackground!    
MenuHeader"    Menu�� D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    :x,http://schemas.microsoft.com/winfx/2006/xaml     >local4clr-namespace:NavigationDrawerControlForWPF.Controls  %j  &	        &	      &	 *     &	 ?     '   �    7  7  7  7   �� $  	#7F222222���� $  	#FF0083FF���� $  	#FF58AEFF���� " ��.���  � ��
 ���� ��  � ��$ 48����  � �� �� " ��.R��� $ 2q�#��z��._��� ���� $ Vertical=�$��Center=� . .+�F� +���� ' '� ;X '� ;X@Ys� '@Ys	
�������$��5��$
 Fill=�$��20��$	��0,1q�F� +���� ' '� ;X '� ;X@Ys� '@Ys	
�������$��5��$
 Fill=�$��20��$	��0,1q�F� +���� ' '� ;X '� ;X@Ys� '@Ys	
�������$��5��$
 Fill=�$��20��$	��0,1q�	 :� $
 
MouseEnter��.[��� .���� .���� $ Background.Color�$ DeepSkyBlueX�$ 0:0:0.25D�:� $
 
MouseLeave��.[��� .���� .���� $ Background.Color�$ 0:0:0.25D��� "   .���  � ��8   ��  �@  MenuBackground8  ��  � ��$ Stretch=���  � ��$ Stretch=���  � �� �� "   .R��  �� $
��auto �$��32���� $��* �   
ViewStates��   $ 0:0:0.2D�.   
Normal��. �� .��W� $ 	PART_Menu��$ Width�$ 0X�$ 0:0:0.1D��� $ PART_MenuDarkSurface��$ Background.Color�$ TransparentX�$ 0:0:0.1D��� $ PART_MenuDarkSurface��$ IsHitTestVisible�$ 0:0:0.1X�.p�s� $ 0:0:0�� .    
MenuOpened��. �� .��W� $ 	PART_Menu��$ Width�# z $ 0:0:0.1D��� $ PART_MenuDarkSurface��$ Background.Color�$ 	#7F222222X�$ 0:0:0.1D��� $ PART_MenuDarkSurface��$ IsHitTestVisible�$ 0:0:0.1X�.p�s� $ 0:0:0�� . .+��� $��1��$ 0��._��� #��z �� #��z��$��0��$ 1��._��  �� $
��auto ��� $��* �.+��� $ PART_OpenMenuButton��8�� �� $ PART_MenuDarkSurface��8��  .  $��1��$ 1���� $ 	PART_Menu��$��2��$
��Left=�$ 2��#��z  #��z ._��  �� $
��auto ��� $��* �.+��� #��z! �� $��1��#��z" 