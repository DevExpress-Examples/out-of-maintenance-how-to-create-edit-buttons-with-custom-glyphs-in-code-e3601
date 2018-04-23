Imports Microsoft.VisualBasic
Imports System
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Media.Imaging
Imports DevExpress.Xpf.Editors

Namespace DXEditors_HowToCreateButtonEdit
	''' <summary>
	''' Interaction logic for MainWindow.xaml
	''' </summary>
	Partial Public Class MainWindow
		Inherits Window
		Public Sub New()
			InitializeComponent()
			CreateEditButton(btnEdit, "/DXEditors_HowToCreateButtonEdit;component\plus.png")
		End Sub

		Private Sub CreateEditButton(ByVal edit As ButtonEdit, ByVal imgUri As String)
			Dim bitmap As New BitmapImage(New Uri(imgUri, UriKind.Relative))
			Dim imgSource As New Image() With {.Source = bitmap}
			Dim btnInfo As New ButtonInfo() With {.GlyphKind = GlyphKind.User, .Content = imgSource}
			edit.Buttons.Add(btnInfo)
		End Sub
	End Class
End Namespace
