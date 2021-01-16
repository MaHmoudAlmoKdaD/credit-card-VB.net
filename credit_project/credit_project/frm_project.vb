Public Class frm_project

    Private Sub ProjectBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ProjectBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ProjectBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DatabaseDataSet)
        Me.ProjectTableAdapter.Fill(Me.DatabaseDataSet.Project)
        ProjectBindingSource.Position = ProjectBindingSource.Count - 1
        Dim x As Integer = Pro_idTextBox.Text
        frm_newRequest.Pro_idTextBox.Text = x
    End Sub

    Private Sub frm_project_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabaseDataSet.Case_project' table. You can move, or remove it, as needed.
        Me.Case_projectTableAdapter.Fill(Me.DatabaseDataSet.Case_project)
        'TODO: This line of code loads data into the 'DatabaseDataSet.Work_type' table. You can move, or remove it, as needed.
        Me.Work_typeTableAdapter.Fill(Me.DatabaseDataSet.Work_type)
        'TODO: This line of code loads data into the 'DatabaseDataSet.Project_type' table. You can move, or remove it, as needed.
        Me.Project_typeTableAdapter.Fill(Me.DatabaseDataSet.Project_type)
        'TODO: This line of code loads data into the 'DatabaseDataSet.Building' table. You can move, or remove it, as needed.
        Me.BuildingTableAdapter.Fill(Me.DatabaseDataSet.Building)
        'TODO: This line of code loads data into the 'DatabaseDataSet.Project' table. You can move, or remove it, as needed.
        Me.ProjectTableAdapter.Fill(Me.DatabaseDataSet.Project)
        Pro_idTextBox.Enabled = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        frm_workType.MdiParent = frm_main
        frm_workType.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frm_building.MdiParent = frm_main
        frm_building.Show()
    End Sub
End Class