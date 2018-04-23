<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TextEdit1 = New Global.DevExpress.XtraEditors.TextEdit
        Me.MyLabelControl1 = New labelControlVB.DevExpress.CustomEditors.MyLabelControl
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextEdit1
        '
        Me.TextEdit1.EditValue = "Type here"
        Me.TextEdit1.Location = New System.Drawing.Point(88, 156)
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Size = New System.Drawing.Size(100, 20)
        Me.TextEdit1.TabIndex = 0
        '
        'MyLabelControl1
        '
        Me.MyLabelControl1.Location = New System.Drawing.Point(88, 68)
        Me.MyLabelControl1.Name = "MyLabelControl1"
        Me.MyLabelControl1.Size = New System.Drawing.Size(93, 13)
        Me.MyLabelControl1.TabIndex = 1
        Me.MyLabelControl1.Text = "MyLabelControl1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 264)
        Me.Controls.Add(Me.MyLabelControl1)
        Me.Controls.Add(Me.TextEdit1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextEdit1 As Global.DevExpress.XtraEditors.TextEdit
    Friend WithEvents MyLabelControl1 As labelControlVB.DevExpress.CustomEditors.MyLabelControl

End Class
