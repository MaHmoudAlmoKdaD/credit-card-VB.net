Public Class frm_district

    Private Sub DistristBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles DistristBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.DistristBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DatabaseDataSet)

    End Sub

    Private Sub frm_district_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        frm_twon.DistristTableAdapter.Fill(frm_twon.DatabaseDataSet.Distrist)
    End Sub

    Private Sub frm_district_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabaseDataSet.Province' table. You can move, or remove it, as needed.
        Me.ProvinceTableAdapter.Fill(Me.DatabaseDataSet.Province)
        'TODO: This line of code loads data into the 'DatabaseDataSet.Distrist' table. You can move, or remove it, as needed.
        Me.DistristTableAdapter.Fill(Me.DatabaseDataSet.Distrist)
        Dis_numTextBox.Text = "Auto Number"
        Dis_numTextBox.Enabled = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frm_province.Show()
    End Sub
End Class