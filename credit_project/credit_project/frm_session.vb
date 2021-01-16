Public Class frm_session

    Private Sub SessionBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
      
    End Sub
    ' Private Sub sesReserved()

    '     If SesionBindingSource.Position = 0 Then
    'Ses_codTextBox.Enabled = False
    '  Ses_dateDateTimePicker.Enabled = False
    '   Cred_valueTextBox.Enabled = False
    '   Accepted_y_n_CheckBox.Enabled = False
    '   Nb_paymentsTextBox.Enabled = False
    '   End If
    '  If SesionBindingSource.Position <> 0 Then
    '
    'Ses_codTextBox.Enabled = True
    '  Ses_dateDateTimePicker.Enabled = True
    '  '  Cred_valueTextBox.Enabled = True
    '  Accepted_y_n_CheckBox.Enabled = True
    ' '  Nb_paymentsTextBox.Enabled = True
    ' End If
    ' End Sub
    Private Sub frm_session_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabaseDataSet.sesion' table. You can move, or remove it, as needed.
        Me.SesionTableAdapter.Fill(Me.DatabaseDataSet.sesion)
        Ses_codTextBox.Text = "Auto Number"
        Ses_codTextBox.Enabled = False
        '  Call sesReserved()
    End Sub

    Private Sub SesionBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub SesionBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs) Handles SesionBindingNavigatorSaveItem.Click
        If Ses_dateDateTimePicker.Text < Today Then
            MessageBox.Show("The Date of Session Must be Greater than Reqest Date")
        Else
            Me.Validate()
            Me.SesionBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.DatabaseDataSet)
            Me.SesionTableAdapter.Fill(Me.DatabaseDataSet.sesion)
            SesionBindingSource.Position = SesionBindingSource.Count - 1
            Dim x As Integer = Ses_codTextBox.Text
            frm_newRequest.Ses_codeTextBox.Text = x
        End If

    End Sub

    Private Sub BindingNavigatorMoveFirstItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorMoveFirstItem.Click
        'Call sesReserved()
    End Sub

    Private Sub BindingNavigatorMovePreviousItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorMovePreviousItem.Click
        '  Call sesReserved()
    End Sub

    Private Sub BindingNavigatorMoveNextItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorMoveNextItem.Click
        '  Call sesReserved()
    End Sub

    Private Sub BindingNavigatorMoveLastItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorMoveLastItem.Click
        '  Call sesReserved()
    End Sub
End Class