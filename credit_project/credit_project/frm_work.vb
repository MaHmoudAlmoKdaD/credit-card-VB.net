Public Class frm_work

    Private Sub WorkBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles WorkBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.WorkBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DatabaseDataSet)

    End Sub

    Private Sub frm_work_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabaseDataSet.Profession' table. You can move, or remove it, as needed.
        Me.ProfessionTableAdapter.Fill(Me.DatabaseDataSet.Profession)
        'TODO: This line of code loads data into the 'DatabaseDataSet.Company' table. You can move, or remove it, as needed.
        Me.CompanyTableAdapter.Fill(Me.DatabaseDataSet.Company)
        'TODO: This line of code loads data into the 'DatabaseDataSet.Person' table. You can move, or remove it, as needed.
        Me.PersonTableAdapter.Fill(Me.DatabaseDataSet.Person)
        'TODO: This line of code loads data into the 'DatabaseDataSet.Work' table. You can move, or remove it, as needed.
        Me.WorkTableAdapter.Fill(Me.DatabaseDataSet.Work)
        Work_numTextBox.Text = "Auto Number"
        Work_numTextBox.Enabled = False
        ComboBox3.Enabled = False
        ComboBox1.Enabled = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frm_company.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        frm_profession.show()
    End Sub

End Class