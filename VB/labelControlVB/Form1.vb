Imports DevExpress.XtraEditors

Public Class Form1

    Private Sub TextEdit1_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextEdit1.EditValueChanged
        MyLabelControl1.Text = CType(sender, TextEdit).Text
    End Sub
End Class
