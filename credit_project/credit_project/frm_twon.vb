Public Class frm_twon

    Private Sub TownBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TownBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TownBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DatabaseDataSet)

    End Sub

    Private Sub frm_twon_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed

    End Sub

    Private Sub frm_twon_DragLeave(sender As Object, e As EventArgs) Handles Me.DragLeave

    End Sub

    Private Sub frm_twon_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        frm_region.TownTableAdapter.Fill(frm_region.DatabaseDataSet.Town)
    End Sub

    Private Sub frm_twon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabaseDataSet.Distrist' table. You can move, or remove it, as needed.
        Me.DistristTableAdapter.Fill(Me.DatabaseDataSet.Distrist)
        'TODO: This line of code loads data into the 'DatabaseDataSet.Town' table. You can move, or remove it, as needed.
        Me.TownTableAdapter.Fill(Me.DatabaseDataSet.Town)
        Tow_numTextBox.Text = "Auto Number"
        Tow_numTextBox.Enabled = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frm_district.Show()
    End Sub
End Class