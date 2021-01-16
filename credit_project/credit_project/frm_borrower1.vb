Imports System.Data
Imports System.Data.OleDb
Public Class btn_cancel
    Public str, str1, str2 As String
    Public con As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\credit_project\credit_project\Database.accdb"
    Public dbcon As New OleDbConnection(con)
    Private da As OleDbDataAdapter
    Private ds As New DataSet
    Private Sub BorrowerBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles BorrowerBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.BorrowerBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DatabaseDataSet)
    End Sub
    Private Sub insr_bor(str1 As String)
        Dim cmd As New OleDbCommand(str1, dbcon)
        da = New OleDbDataAdapter(cmd)
        ds = New DataSet
        da.Fill(ds)
    End Sub
    Private Sub frm_borrower1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'TODO: This line of code loads data into the 'DatabaseDataSet.Person' table. You can move, or remove it, as needed.
        Me.PersonTableAdapter.Fill(Me.DatabaseDataSet.Person)
        'TODO: This line of code loads data into the 'DatabaseDataSet.Insurance' table. You can move, or remove it, as needed.
        Me.InsuranceTableAdapter.Fill(Me.DatabaseDataSet.Insurance)
        'TODO: This line of code loads data into the 'DatabaseDataSet.Educational_level' table. You can move, or remove it, as needed.
        Me.Educational_levelTableAdapter.Fill(Me.DatabaseDataSet.Educational_level)
        'TODO: This line of code loads data into the 'DatabaseDataSet.Last_class' table. You can move, or remove it, as needed.
        Me.Last_classTableAdapter.Fill(Me.DatabaseDataSet.Last_class)
        'TODO: This line of code loads data into the 'DatabaseDataSet.School_or_university' table. You can move, or remove it, as needed.
        Me.School_or_universityTableAdapter.Fill(Me.DatabaseDataSet.School_or_university)
        'TODO: This line of code loads data into the 'DatabaseDataSet.Profession_status' table. You can move, or remove it, as needed.
        Me.Profession_statusTableAdapter.Fill(Me.DatabaseDataSet.Profession_status)
        'TODO: This line of code loads data into the 'DatabaseDataSet.Borrower' table. You can move, or remove it, as needed.
        Me.BorrowerTableAdapter.Fill(Me.DatabaseDataSet.Borrower)
        P_idTextBox.Enabled = False
        BorrowerBindingSource.Position = BorrowerBindingSource.Count - 1
        Call txt()
    End Sub

    Private Sub txt()
        Pr_st_codTextBox.Enabled = False
        sch_txt.Enabled = False
        Cl_codTextBox.Enabled = False
        Ed_i_idTextBox.Enabled = False
        Insu_numTextBox.Enabled = False
        ComboBox1.Enabled = False
        ComboBox2.Enabled = False
        ComboBox3.Enabled = False
        ComboBox4.Enabled = False
        ComboBox5.Enabled = False
        ComboBox6.Enabled = False
        ComboBox7.Enabled = False
        ComboBox8.Enabled = False
        btn_save.Enabled = False
        btn_new.Enabled = False
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_new.Click
        frm_school.MdiParent = frm_main
        frm_school.Show()
    End Sub
    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click
        '  ComboBox6.Enabled = False
        ComboBox7.Enabled = False
        ComboBox8.Enabled = False
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        'insr_bor("insert into borrower(p_id,pr_st_cod,sch_num,cl_cod,ed_i_id,insu_num) values('" & frm_borrower.P_idTextBox.Text & "','" & Pr_st_codTextBox.Text & "','" & sch_txt.Text & "','" & "','" & Cl_codTextBox.Text & "','" & Ed_i_idTextBox.Text & "','" & Insu_numTextBox.Text & "')")
        upda("update Borrower set pr_st_cod =" & Pr_st_codTextBox.Text & ", Sch_num =" & sch_txt.Text & ", Cl_cod =" & Cl_codTextBox.Text & ",Ed_i_id=" & Ed_i_idTextBox.Text & ", insu_num=" & Insu_numTextBox.Text & " where p_id=" & P_idTextBox.Text)
        Call txt()
    End Sub
    Private Sub upda(str As String)
        Dim cmd As New OleDbCommand(str, dbcon)
        da = New OleDbDataAdapter(cmd)
        ds = New DataSet
        da.Fill(ds)
    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        ComboBox1.Enabled = True
        ComboBox2.Enabled = True
        ComboBox3.Enabled = True
        ComboBox4.Enabled = True
        ComboBox5.Enabled = True
        btn_save.Enabled = True
        btn_new.Enabled = True
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If txt_search.Text = " " Then
            MessageBox.Show("you don't enter any value!!", "attention ", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ElseIf (IsNumeric(txt_search.Text)) = False Then
            MessageBox.Show("enter A number", "attention ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf txt_search.Text <= 0 Then
            MessageBox.Show("enter value positive and greater than 0")
        Else
            str = "select p_id from borrower"
            Dim cmd As New OleDbCommand(str, dbcon)
            da = New OleDbDataAdapter(cmd)
            ds = New DataSet
            da.Fill(ds)
            Dim s As Boolean
            Dim y, se As Integer
            y = 0
            se = 0
            Dim i As Integer = ds.Tables(0).Rows.Count
            While y < i And s = False
                Dim data As Integer = ds.Tables(0).Rows(y).Item(0)
                If Val(txt_search.Text) = data Then
                    s = True
                Else
                    y = y + 1
                    se = se + 1
                End If
            End While
            If s = True Then
                BorrowerBindingSource.Position = se
            Else
                MessageBox.Show("the Borrower not exists")
            End If
        End If
        txt_search.Text = ""
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Call txt()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs)

    End Sub
End Class