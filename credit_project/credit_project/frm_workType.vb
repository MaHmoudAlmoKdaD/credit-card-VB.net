Public Class frm_workType

    Private Sub Work_typeBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Work_typeBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Work_typeBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DatabaseDataSet)

    End Sub

    Private Sub frm_workType_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        frm_project.Work_typeTableAdapter.Fill(frm_project.DatabaseDataSet.Work_type)
    End Sub

    Private Sub frm_workType_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'TODO: This line of code loads data into the 'DatabaseDataSet.Work_type' table. You can move, or remove it, as needed.
        Me.Work_typeTableAdapter.Fill(Me.DatabaseDataSet.Work_type)
        W_t_codeTextBox.Text = "Auto Number"
        W_t_codeTextBox.Enabled = False
    End Sub
End Class