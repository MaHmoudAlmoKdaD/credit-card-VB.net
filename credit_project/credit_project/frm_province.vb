Public Class frm_province

    Private Sub ProvinceBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ProvinceBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ProvinceBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DatabaseDataSet)

    End Sub

    Private Sub frm_province_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        frm_district.ProvinceTableAdapter.Fill(frm_district.DatabaseDataSet.Province)
    End Sub

    Private Sub frm_province_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabaseDataSet.Province' table. You can move, or remove it, as needed.
        Me.ProvinceTableAdapter.Fill(Me.DatabaseDataSet.Province)
        Por_numTextBox.Text = "Auto Number"
        Por_numTextBox.Enabled = False
    End Sub
End Class