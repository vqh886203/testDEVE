   M S B A M L   `   `   `  ����  testDEVE    testDEVE.xam   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35a ]DevExpress.Xpf.Core.v17.1, Version=17.1.8.0, Culture=neutral, PublicKeyToken=b88d1754d700e49aW SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   <dxb2http://schemas.devexpress.com/winfx/2008/xaml/bars  5   	   ;dx2http://schemas.devexpress.com/winfx/2008/xaml/core  6H   f bDevExpress.Xpf.Grid.v17.1.Core, Version=17.1.8.0, Culture=neutral, PublicKeyToken=b88d1754d700e49aa ]DevExpress.Xpf.Grid.v17.1, Version=17.1.8.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a>dxg2http://schemas.devexpress.com/winfx/2008/xaml/grid   6�     � Title$	  xam��5   	   $��385.507��6   $��763.514��6&   .��5      � .+�5   
   ]� .+�5	      )  #DevExpress.Xpf.Bars.MainMenuControl  ,  &DevExpress.Xpf.Bars.ToolBarControlBase   Caption$
 File��6"   $	��Top=�61      Items. 5
      $  DevExpress.Xpf.Bars.BarSubItem  -   5          Name$ biFile��5
   !   !  DevExpress.Xpf.Bars.BarItem   Content)  #DevExpress.Xpf.Core.ObjectConverter$
 File 61      Items. 5      '  !DevExpress.Xpf.Bars.BarButtonItem  -   5          Name$ 
biFileOpen��5   (   $
 Open 6<      Glyph 6K   *  $DevExpress.Xpf.Core.DXImageExtension     Image1  +DevExpress.Xpf.Core.Native.DXImageConverter$ Open_16x16.png 	   
LargeGlyph	 6u     $ Open_32x32.png   5      -   5        $ 	biFileNew��5   (   $	 New 6;    6I     $ New_16x16.png 	 6r     $ New_32x32.png 5        5      -   5        $ biEdit��5   !   $
 Edit 61   . 5      +	  %DevExpress.Xpf.Bars.BarButtonItemLink	  %
  DevExpress.Xpf.Bars.BarItemLink
 
  BarItemName$
 biCut��6,   	  5      $
 biCopy��6,   	  5      $
 biPaste��6,   5      5      (  "DevExpress.Xpf.Bars.ToolBarControl  5      $
 Edit��6!   $	��Top=�60   . 5        -   5        $ biCut��5   $   $	 Cut 63    6A     $ Cut_16x16.png 	 6j     $ Cut_32x32.png   5      -   5        $ biCopy��5   $   $
 Copy 64    6C     $ Copy_16x16.png 	 6m     $ Copy_32x32.png   5      -   5        $ biPaste��5   $   $ Paste 65    6E     $ Paste_16x16.png 	 6p     $ Paste_32x32.png 5      *  $DevExpress.Xpf.Bars.StatusBarControl  5      $ 	StatusBar��6#   $��Bottom=�67      ShowSizeGrip . . 5      '  !DevExpress.Xpf.Bars.BarStaticItem  -   5          Name$ biRow��5   $   $
 Row: 63      
ShowBorder .  6B     5      -	   5        $ 
biRowValue��5   $   $ 1 68    .  6D     5      -
   5        $ biColumn��5   $   $ Column: 66    .  6H     5      -   5        $ biColumnValue��5   $   $ 2 6;   &   DevExpress.Xpf.Bars.BarCheckItem  5      -   5          Name$ biLeft��5   #      	Alignment$	 Far=�63      
GroupIndex$ 1��6r      	IsChecked$
 TrueY�6�    6C     $ AlignLeft_16x16.png 6�     5      -   5        $ biCenter��5   #   $	 Far=�65   $ 1��6v    6E     $ AlignCenter_16x16.png 6v     5       -   5        $ biRight��5    #   $	 Far=�64   $ 1��6t    6D     $ AlignRight_16x16.png 6t   5!      � 5#      .+�5$      %  DevExpress.Xpf.Grid.GridControl  -   5        $��gr��5$   "   )  #DevExpress.Xpf.Grid.DataControlBase   AutoGenerateColumns$
 None=�6,   #   EnableSmartColumnsGeneration .    SelectionMode$ MultipleRow=�6k      View 5%      #  DevExpress.Xpf.Grid.TableView  5&         AllowPerPixelScrolling . &   DevExpress.Xpf.Grid.DataViewBase   ShowTotalSummary . 6F      Columns. 5(      $  DevExpress.Xpf.Grid.GridColumn  $  DevExpress.Xpf.Grid.ColumnBase   	FieldName$ TenNV��6%      IsSmart . 67     5)      $ NgaySinh��6%    . 6:     5*      $ GioiTinh��6%    . 6:     5+      $ email��6%    . 67     5,      $	 SDT��6%    . 65   5-      5.      5/      51      52      