Public Class frm_region

    Private Sub RegionBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles RegionBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.RegionBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DatabaseDataSet)

    End Sub

    Private Sub frm_region_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        frm_street.RegionTableAdapter.Fill(frm_street.DatabaseDataSet._Region)
    End Sub

    Private Sub frm_region_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabaseDataSet.Town' table. You can move, or remove it, as needed.
        Me.TownTableAdapter.Fill(Me.DatabaseDataSet.Town)
        'TODO: This line of code loads data into the 'DatabaseDataSet._Region' table. You can move, or remove it, as needed.
        Me.RegionTableAdapter.Fill(Me.DatabaseDataSet._Region)
        Regi_numTextBox.Text = "Auto Number"
        Regi_numTextBox.Enabled = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frm_twon.Show()
    End Sub
End Class