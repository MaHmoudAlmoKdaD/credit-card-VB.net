Public Class frm_credit2

    Private Sub CreditBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CreditBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CreditBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DatabaseDataSet)

    End Sub

    Private Sub frm_credit2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabaseDataSet.Credit' table. You can move, or remove it, as needed.
        Me.CreditTableAdapter.Fill(Me.DatabaseDataSet.Credit)
        Cre_codTextBox.Enabled = False
    End Sub
End Class