Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'KayaksDataSet.KayakTypes' table. You can move, or remove it, as needed.
        Me.KayakTypesTableAdapter.Fill(Me.KayaksDataSet.KayakTypes)

    End Sub

    Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.KayakTypesTableAdapter.FillBy(Me.KayaksDataSet.KayakTypes)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class
