Public Class frm_building

    Private Sub BuildingBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles BuildingBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.BuildingBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DatabaseDataSet)

    End Sub

    Private Sub frm_building_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        frm_company.BuildingTableAdapter.Fill(frm_company.DatabaseDataSet.Building)
        frm_borrower.BuildingTableAdapter.Fill(frm_borrower.DatabaseDataSet.Building)
        frm_project.BuildingTableAdapter.Fill(frm_project.DatabaseDataSet.Building)
    End Sub

    Private Sub frm_building_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabaseDataSet.Street' table. You can move, or remove it, as needed.
        Me.StreetTableAdapter.Fill(Me.DatabaseDataSet.Street)
        'TODO: This line of code loads data into the 'DatabaseDataSet.Building' table. You can move, or remove it, as needed.
        Me.BuildingTableAdapter.Fill(Me.DatabaseDataSet.Building)
        Buil_numTextBox.Text = "Auto Number"
        Buil_numTextBox.Enabled = False

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frm_street.Show()
    End Sub
End Class