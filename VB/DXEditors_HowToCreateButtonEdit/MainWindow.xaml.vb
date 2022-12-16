Imports System
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Media.Imaging
Imports DevExpress.Xpf.Editors

Namespace DXEditors_HowToCreateButtonEdit

    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Public Partial Class MainWindow
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
            Me.CreateEditButton(Me.btnEdit, "/DXEditors_HowToCreateButtonEdit;component\plus.png")
        End Sub

        Private Sub CreateEditButton(ByVal edit As ButtonEdit, ByVal imgUri As String)
            Dim bitmap As BitmapImage = New BitmapImage(New Uri(imgUri, UriKind.Relative))
            Dim imgSource As Image = New Image() With {.Source = bitmap}
            Dim btnInfo As ButtonInfo = New ButtonInfo() With {.GlyphKind = GlyphKind.User, .Content = imgSource}
            edit.Buttons.Add(btnInfo)
        End Sub
    End Class
End Namespace
