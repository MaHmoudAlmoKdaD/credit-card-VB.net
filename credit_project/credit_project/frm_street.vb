Public Class frm_street

    Private Sub StreetBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles StreetBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.StreetBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DatabaseDataSet)

    End Sub

    Private Sub frm_street_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        frm_building.StreetTableAdapter.Fill(frm_building.DatabaseDataSet.Street)
    End Sub

    Private Sub frm_street_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabaseDataSet._Region' table. You can move, or remove it, as needed.
        Me.RegionTableAdapter.Fill(Me.DatabaseDataSet._Region)
        'TODO: This line of code loads data into the 'DatabaseDataSet.Street' table. You can move, or remove it, as needed.
        Me.StreetTableAdapter.Fill(Me.DatabaseDataSet.Street)
        Str_numTextBox.Text = "Auto number"
        Str_numTextBox.Enabled = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frm_region.Show()
    End Sub

    Private Sub Regi_numLabel_Click(sender As Object, e As EventArgs)
        Throw New NotImplementedException
    End Sub

    
End Class