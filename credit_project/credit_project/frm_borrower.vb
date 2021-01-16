Imports System.Data
Imports System.Data.OleDb
Public Class frm_borrower
    Public str, str1, str2 As String
    Public con As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\credit_project\credit_project\Database.accdb"
    Public dbcon As New OleDbConnection(con)
    Private da As OleDbDataAdapter
    Private ds As New DataSet
    Private pos As Integer
    Private nex As Integer
    Dim x As Integer
    Public opn As Boolean = False
    Private Sub PersonBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.PersonBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DatabaseDataSet)
    End Sub

    Private Sub frm_borrower_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        frm_newRequest.PersonTableAdapter.Fill(frm_newRequest.DatabaseDataSet.Person)
        'TODO: This line of code loads data into the 'DatabaseDataSet.Request' table. You can move, or remove it, as needed.
        frm_newRequest.RequestTableAdapter.Fill(frm_newRequest.DatabaseDataSet.Request)
    End Sub

    Private Sub frm_borrower_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabaseDataSet.Borrower' table. You can move, or remove it, as needed.
        Me.BorrowerTableAdapter.Fill(Me.DatabaseDataSet.Borrower)
        'TODO: This line of code loads data into the 'DatabaseDataSet.Guranter' table. You can move, or remove it, as needed.
        Me.GuranterTableAdapter.Fill(Me.DatabaseDataSet.Guranter)
        'TODO: This line of code loads data into the 'DatabaseDataSet.Second_address' table. You can move, or remove it, as needed.
        Me.Second_addressTableAdapter.Fill(Me.DatabaseDataSet.Second_address)
        'TODO: This line of code loads data into the 'DatabaseDataSet.Building' table. You can move, or remove it, as needed.
        Me.BuildingTableAdapter.Fill(Me.DatabaseDataSet.Building)
        'TODO: This line of code loads data into the 'DatabaseDataSet.Town' table. You can move, or remove it, as needed.
        Me.TownTableAdapter.Fill(Me.DatabaseDataSet.Town)
        'TODO: This line of code loads data into the 'DatabaseDataSet.Family_status' table. You can move, or remove it, as needed.
        Me.Family_statusTableAdapter.Fill(Me.DatabaseDataSet.Family_status)
        'TODO: This line of code loads data into the 'DatabaseDataSet.Person' table. You can move, or remove it, as needed.
        Me.PersonTableAdapter.Fill(Me.DatabaseDataSet.Person)
        P_idTextBox.Text = "Auto Number"
        P_idTextBox.Enabled = False
        Call btn(False, True)
        chk_bor.Checked = True
        grp_choose.Visible = False
    End Sub


    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Dim ans As Integer
        ans = MessageBox.Show("delete", "delete records?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

        If ans = 6 Then
            PersonBindingSource.RemoveCurrent()
            PersonTableAdapter.Update(DatabaseDataSet)
        End If
    End Sub
    Private Sub btn(ByVal f As Boolean, ByVal p As Boolean)
        btn_First.Enabled = f
        btn_priv.Enabled = f
        btn_last.Enabled = p
        btn_next.Enabled = p
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        chk_bor.Checked = False
        chk_gua.Checked = False
        If btn_add.Text = "Add" Then
            btn_add.Text = "save"
            btn_Edit.Text = "cancel"

            pos = PersonBindingSource.Position
            PersonBindingSource.AddNew()
            Call btn(False, False)
            First_nameTextBox.Focus()
            grp_choose.Visible = False
        Else
           
            btn_add.Text = "Add"
            btn_Edit.Text = "Edit"
            PersonBindingSource.EndEdit()
            PersonTableAdapter.Update(DatabaseDataSet.Person)
            If pos = PersonBindingSource.Count - 1 Then
                Call btn(True, False)
            Else
                Call btn(True, True)
            End If
            Me.PersonTableAdapter.Fill(Me.DatabaseDataSet.Person)
            PersonBindingSource.Position = PersonBindingSource.Count - 1
            grp_choose.Visible = True
            Label7.Visible = True
            Label8.Visible = True
            ' If chk_bor.Checked = True Then
            '  x = P_idTextBox.Text
            ' BorrowerBindingSource.AddNew()
            ' P_idTextBox1.Text = x
            '  BorrowerBindingSource.EndEdit()
            ' BorrowerTableAdapter.Update(Me.DatabaseDataSet)
            ' opn = True
            ' Else
            '    If chk_gua.Checked = True Then
            'x = P_idTextBox.Text
            '   GuranterBindingSource.AddNew()
            '   txt_bid.Text = x
            '   GuranterBindingSource.EndEdit()
            '    GuranterTableAdapter.Update(DatabaseDataSet)
            '  End If
            '  End If
            'If opn = True Then
            '      frm_borrower1.Show()
            'End If
        End If
    End Sub
    


    Private Sub btn_Edit_Click(sender As Object, e As EventArgs) Handles btn_Edit.Click
        If btn_Edit.Text = "Edit" Then
            btn_add.Text = "save"
            btn_Edit.Text = "cancel"

            Call btn(False, False)
            pos = PersonBindingSource.Position
        Else
            btn_add.Text = "Add"
            btn_Edit.Text = "Edit"

            PersonBindingSource.CancelEdit()
            If pos = PersonBindingSource.Count - 1 Then
                Call btn(True, False)
            ElseIf pos = 0 Then
                Call btn(False, True)
            Else
                Call btn(True, True)
            End If
            PersonBindingSource.Position = pos
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        btn_cancel.MdiParent = frm_main
        btn_cancel.Show()
    End Sub

    Private Sub btn_First_Click(sender As Object, e As EventArgs) Handles btn_First.Click
        PersonBindingSource.MoveFirst()
        Call btn(False, True)
        Call checkborrower()
    End Sub

    Private Sub btn_last_Click(sender As Object, e As EventArgs) Handles btn_last.Click
        PersonBindingSource.MoveLast()
        Call btn(True, False)
        Call checkborrower()
    End Sub

    Private Sub btn_next_Click(sender As Object, e As EventArgs) Handles btn_next.Click
        PersonBindingSource.MoveNext()
        Call btn(True, True)
        If PersonBindingSource.Position = PersonBindingSource.Count - 1 Then
            Call btn(True, False)
        End If
        Call checkborrower()
    End Sub

    Private Sub btn_priv_Click(sender As Object, e As EventArgs) Handles btn_priv.Click
        PersonBindingSource.MovePrevious()
        Call btn(True, True)
        If PersonBindingSource.Position = 0 Then
            Call btn(False, True)
        End If
        Call checkborrower()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        frm_building.MdiParent = frm_main
        frm_building.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        frm_twon.MdiParent = frm_main
        frm_twon.Show()
    End Sub
    Private Sub checkborrower()
        str = "select p_id from Borrower"
        Dim cmd As New OleDbCommand(str, dbcon)
        da = New OleDbDataAdapter(cmd)
        ds = New DataSet
        da.Fill(ds)
        Dim s As Boolean
        Dim y As Integer
        y = 0
        Dim i As Integer = ds.Tables(0).Rows.Count
        While y < i And s = False
            Dim data As Integer = ds.Tables(0).Rows(y).Item(0)
            If Val(P_idTextBox.Text) = data Then
                s = True
            Else
                y = y + 1
            End If
        End While
        If s = True Then
            chk_bor.Checked = True
            chk_gua.Checked = False
        Else
            chk_gua.Checked = True
            chk_bor.Checked = False
        End If

    End Sub

    '   Private Sub insr_bor(str1 As String)
    'Dim cmd As New OleDbCommand(str1, dbcon)
    '     da = New OleDbDataAdapter(cmd)
    '     ds = New DataSet
    '     da.Fill(ds)
    ' End Sub
    Private Sub insr(str2 As String)
        Dim cmd As New OleDbCommand(str2, dbcon)
        da = New OleDbDataAdapter(cmd)
        ds = New DataSet
        da.Fill(ds)
    End Sub
    Private Sub insr_bor(str1 As String)
        Dim cmd As New OleDbCommand(str1, dbcon)
        da = New OleDbDataAdapter(cmd)
        ds = New DataSet
        da.Fill(ds)
    End Sub
    Private Sub chk_bor_Click(sender As Object, e As EventArgs) Handles chk_bor.Click

        insr_bor("insert into borrower(p_id) values('" & P_idTextBox.Text & "')")
        'frm_borrower1.MdiParent = frm_main
        ' frm_borrower1.Show()

    End Sub

    Private Sub chk_gua_Click(sender As Object, e As EventArgs) Handles chk_gua.Click

        insr("insert into guranter(p_id) values('" & P_idTextBox.Text & "')")
        MessageBox.Show("Insert As Guarantor")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If txt_search.Text = " " Then
            MessageBox.Show("you don't enter any value!!", "attention ", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ElseIf (IsNumeric(txt_search.Text)) = False Then
            MessageBox.Show("enter A number", "attention ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf txt_search.Text <= 0 Then
            MessageBox.Show("enter value positive and greater than 0")
        Else
            str = "select p_id from person"
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
                PersonBindingSource.Position = se
            Else
                MessageBox.Show("the Borrower not exists")
            End If
        End If
        txt_search.Text = ""
    End Sub

    Private Sub GenderTextBox_LostFocus(sender As Object, e As EventArgs) Handles GenderTextBox.LostFocus
        If GenderTextBox.Text <> "female" And GenderTextBox.Text <> "male" Then
            MessageBox.Show("The value must be = female or male")
            GenderTextBox.Focus()
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        btn_cancel.MdiParent = frm_main
        btn_cancel.Show()
    End Sub

    
End Class