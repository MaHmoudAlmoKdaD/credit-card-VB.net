Public Class frm_familyIncome

    Private Sub Family_incomeBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Family_incomeBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Family_incomeBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DatabaseDataSet)

    End Sub

    Private Sub frm_familyIncome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabaseDataSet.Family_income' table. You can move, or remove it, as needed.
        Me.Family_incomeTableAdapter.Fill(Me.DatabaseDataSet.Family_income)

    End Sub
End Class