Public Class frm_school

    Private Sub School_or_universityBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles School_or_universityBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.School_or_universityBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DatabaseDataSet)

    End Sub

    Private Sub frm_school_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        btn_cancel.School_or_universityTableAdapter.Fill(btn_cancel.DatabaseDataSet.School_or_university)
    End Sub

    Private Sub frm_school_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabaseDataSet.School_or_university' table. You can move, or remove it, as needed.
        Me.School_or_universityTableAdapter.Fill(Me.DatabaseDataSet.School_or_university)
        Sch_numTextBox.Text = "Auto number"
        Sch_numTextBox.Enabled = False
    End Sub
End Class