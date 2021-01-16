Public Class frm_company

    Private Sub CompanyBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CompanyBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CompanyBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DatabaseDataSet)

    End Sub

    Private Sub frm_company_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        frm_work.CompanyTableAdapter.Fill(frm_work.DatabaseDataSet.Company)
    End Sub

    Private Sub frm_company_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabaseDataSet.Building' table. You can move, or remove it, as needed.
        Me.BuildingTableAdapter.Fill(Me.DatabaseDataSet.Building)
        'TODO: This line of code loads data into the 'DatabaseDataSet.Company' table. You can move, or remove it, as needed.
        Me.CompanyTableAdapter.Fill(Me.DatabaseDataSet.Company)
        Com_numTextBox.Text = "Auto Number"
        Com_numTextBox.Enabled = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frm_building.Show()
    End Sub
End Class