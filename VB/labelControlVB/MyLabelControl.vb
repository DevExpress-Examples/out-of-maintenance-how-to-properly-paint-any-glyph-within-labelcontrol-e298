Imports Microsoft.VisualBasic
Imports System.Drawing
Imports System.Reflection
Imports System.ComponentModel
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Drawing
Imports DevExpress.XtraEditors.ViewInfo

Namespace DevExpress.CustomEditors
    Public Class MyLabelControl
        Inherits LabelControl
        'Initialize the new instance
        Public Sub New()
            MyBase.New()
            '...
        End Sub

        Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
            MyBase.OnPaint(e)
            Dim brush As Brush = Brushes.Yellow
            Dim location As New Point(e.ClipRectangle.Left + (Width - Height), e.ClipRectangle.Top)
            Dim size As New Size(e.ClipRectangle.Height, e.ClipRectangle.Height)
            Dim rect As New Rectangle(location, size)
            e.Graphics.FillEllipse(brush, rect)
        End Sub

        Private internalChange As Boolean = False

        Protected Overloads Overrides Sub LayoutChanged(ByVal isVisualUpdate As Boolean)
            If internalChange Then
                Return
            End If
            internalChange = True
            Try
                MyBase.LayoutChanged(isVisualUpdate)
                If Not (AutoSizeMode = LabelAutoSizeMode.None) Then
                    Size = New Size(Size.Width + Size.Height, Size.Height)
                End If
            Finally
                internalChange = False
            End Try
        End Sub
    End Class
End Namespace