Imports System.Data
Imports System.Data.OleDb
Public Class frm_newRequest
    Public str, str1, str2, str3 As String
    Public con As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\credit_project\credit_project\Database.accdb"
    Public dbcon As New OleDbConnection(con)
    Private da As OleDbDataAdapter
    Private ds As New DataSet
    Private pos As Integer = 0

    Dim cmd As New OleDbCommand(str1, dbcon)
     
    Private Sub grp_spend_income()
        txt_incType.Enabled = False
        Sp_codTextBox.Enabled = False
        Family_f_valueTextBox.Text = ""
        ComboBox4.Text = ""
        TextBox1.Text = ""
        ComboBox5.Text = ""
    End Sub

    Private Sub RequestBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles RequestBindingNavigatorSaveItem.Click
        If btn_pro.Enabled = False Then
            Pro_idTextBox.Text = 1
        End If
        If Ses_codeTextBox.Text = "" Then
            Ses_codeTextBox.Text = 1
        End If
        Me.Validate()
        Me.RequestBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DatabaseDataSet)
        grp.Visible = True
        Call grp_spend_income()
        Me.RequestTableAdapter.Fill(Me.DatabaseDataSet.Request)
        RequestBindingSource.Position = RequestBindingSource.Count - 1
        Call grp_spend_income()
        Button4.Enabled = True
        '  insr("insert into family_income (Req_num,In_T_code,Family_f_value) values('" & Req_numTextBox.Text & "','" & txt_incType.Text & "','" & Family_f_valueTextBox.Text & "')")
        ' insr1("insert into Family_spend (sp_cod,Req_num,Fs_value) values('" & Sp_codTextBox.Text & "','" & Req_numTextBox.Text & "','" & TextBox1.Text & "')")
    End Sub
    Private Sub frm_newRequest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabaseDataSet.Credit_type' table. You can move, or remove it, as needed.
        Me.Credit_typeTableAdapter.Fill(Me.DatabaseDataSet.Credit_type)
        'TODO: This line of code loads data into the 'DatabaseDataSet.Family_spend' table. You can move, or remove it, as needed.
        Me.Family_spendTableAdapter.Fill(Me.DatabaseDataSet.Family_spend)
        'TODO: This line of code loads data into the 'DatabaseDataSet.Spend_type' table. You can move, or remove it, as needed.
        Me.Spend_typeTableAdapter.Fill(Me.DatabaseDataSet.Spend_type)
        'TODO: This line of code loads data into the 'DatabaseDataSet.Family_income' table. You can move, or remove it, as needed.
        Me.Family_incomeTableAdapter.Fill(Me.DatabaseDataSet.Family_income)
        'TODO: This line of code loads data into the 'DatabaseDataSet.Income_type' table. You can move, or remove it, as needed.
        Me.Income_typeTableAdapter.Fill(Me.DatabaseDataSet.Income_type)
        'TODO: This line of code loads data into the 'DatabaseDataSet.Person' table. You can move, or remove it, as needed.
        Me.PersonTableAdapter.Fill(Me.DatabaseDataSet.Person)
        'TODO: This line of code loads data into the 'DatabaseDataSet.Request' table. You can move, or remove it, as needed.
        Me.RequestTableAdapter.Fill(Me.DatabaseDataSet.Request)
        Req_numTextBox.Text = "Auto Number"
        Req_numTextBox.Enabled = False
        ComboBox2.Enabled = False
        ComboBox3.Enabled = False
        btn_pro.Enabled = False
        Ses_codeTextBox.Enabled = False
        Pro_idTextBox.Enabled = False
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btn_pro.Click
        frm_project.MdiParent = frm_main
        frm_project.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        frm_session.MdiParent = frm_main
        frm_session.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        '.MdiParent = frm_main
        ' frm_credit.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frm_borrower.MdiParent = frm_main
        frm_borrower.Show()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs)
        frm_work.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        frm_work.MdiParent = frm_main
        frm_work.Show()
    End Sub
    Private Sub ComboBox6_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox6.SelectedIndexChanged
        If ComboBox6.SelectedIndex = 0 Then
            btn_pro.Enabled = True
        Else
            btn_pro.Enabled = False
        End If
    End Sub
    Private Sub insr(str As String)
        Dim cmd As New OleDbCommand(str, dbcon)
        da = New OleDbDataAdapter(cmd)
        ds = New DataSet
        da.Fill(ds)
    End Sub
    Private Sub insr1(str1 As String)
        Dim cmd As New OleDbCommand(str1, dbcon)
        da = New OleDbDataAdapter(cmd)
        ds = New DataSet
        da.Fill(ds)
    End Sub
    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        insr("insert into family_income (Req_num,In_T_code,Family_f_value) values('" & Req_numTextBox.Text & "','" & txt_incType.Text & "','" & Family_f_valueTextBox.Text & "')")
        insr1("insert into Family_spend (sp_cod,Req_num,Fs_value) values('" & Sp_codTextBox.Text & "','" & Req_numTextBox.Text & "','" & TextBox1.Text & "')")
        grp.Visible = False
    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        frm_credit2.MdiParent = frm_main
        frm_credit2.Show()
    End Sub
End Class