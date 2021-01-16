Public Class Form2

    Private Sub CreditBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CreditBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CreditBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DatabaseDataSet)

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabaseDataSet.Payment_mode' table. You can move, or remove it, as needed.
        Me.Payment_modeTableAdapter.Fill(Me.DatabaseDataSet.Payment_mode)
        'TODO: This line of code loads data into the 'DatabaseDataSet.Request' table. You can move, or remove it, as needed.
        Me.RequestTableAdapter.Fill(Me.DatabaseDataSet.Request)
        'TODO: This line of code loads data into the 'DatabaseDataSet.bnd1' table. You can move, or remove it, as needed.
        Me.Bnd1TableAdapter.Fill(Me.DatabaseDataSet.bnd1)
        'TODO: This line of code loads data into the 'DatabaseDataSet.Credit' table. You can move, or remove it, as needed.
        Me.CreditTableAdapter.Fill(Me.DatabaseDataSet.Credit)



        Cre_codTextBox.Text = "Auto Number"
        Cre_codTextBox.Enabled = False
        Dim nm As Integer = Val(frm_request.txt_Rnum.Text)

        Try
            Me.CreditTableAdapter.FillBy(Me.DatabaseDataSet.Credit, New System.Nullable(Of Integer)(CType(nm, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
        Req_numTextBox.Enabled = False
        '  cbo_value.Enabled = False
        Cre_dateDateTimePicker.Enabled = False
        Cre_end_dateDateTimePicker.Enabled = False
        cbo_value.Enabled = False
        Cre_dateDateTimePicker.Enabled = False
        Cre_end_dateDateTimePicker.Enabled = False
        Call loadgrid()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Bnd1DataGridView.Enabled = True Then
            Bnd1BindingSource.EndEdit()
            Bnd1TableAdapter.Update(Me.DatabaseDataSet)
            Button1.Text = "ADD BOND"
            Bnd1DataGridView.Enabled = False
            Call loadgrid()
        Else
            If Val(cbo_value.Text) = Val(txt_result.Text) Then
                MessageBox.Show("This credit is finesh")
            Else
                Bnd1DataGridView.Enabled = True
                Button1.Text = "SAVE BOND"
                Bnd1BindingSource.AddNew()
            End If
        End If
    End Sub

    Private Sub BindingNavigatorMoveNextItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorMoveNextItem.Click
        Call loadgrid()

    End Sub
    Private Sub loadgrid()
        Bnd1BindingSource.MoveLast()
        txt_result.Text = ""
        Dim sum As Integer = 0
        Try
            If Me.Bnd1BindingSource.Position > -1 Then
                For Each row As DataRowView In Me.Bnd1BindingSource.List
                    sum = sum + row!bond_value
                Next
                txt_result.Text = sum
            Else
                txt_result.Text = ""
            End If

        Catch e As Exception

        End Try

    End Sub

  
    
End Class