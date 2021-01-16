Public Class frm_profession

    Private Sub ProfessionBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ProfessionBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ProfessionBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DatabaseDataSet)

    End Sub

    Private Sub frm_profession_DragOver(sender As Object, e As DragEventArgs) Handles Me.DragOver

    End Sub

    Private Sub frm_profession_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        frm_work.ProfessionTableAdapter.Fill(frm_work.DatabaseDataSet.Profession)
    End Sub

    Private Sub frm_profession_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabaseDataSet.Profession' table. You can move, or remove it, as needed.
        Me.ProfessionTableAdapter.Fill(Me.DatabaseDataSet.Profession)
        Pr_codTextBox.Text = "Auto Number"
        Pr_codTextBox.Enabled = False
    End Sub
End Class