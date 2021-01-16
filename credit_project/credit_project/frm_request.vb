Imports System.Data
Imports System.Data.OleDb
Public Class frm_request
    Public str As String
    Public con As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\credit_project\credit_project\Database.accdb"
    Public dbcon As New OleDbConnection(con)
    Private da As OleDbDataAdapter
    Private ds As New DataSet
    Private pos As Integer = 0
    Private Sub frm_request_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabaseDataSet.Person' table. You can move, or remove it, as needed.
        Me.PersonTableAdapter.Fill(Me.DatabaseDataSet.Person)
        'TODO: This line of code loads data into the 'DatabaseDataSet.Family_spend' table. You can move, or remove it, as needed.
        Me.Family_spendTableAdapter.Fill(Me.DatabaseDataSet.Family_spend)
        'TODO: This line of code loads data into the 'DatabaseDataSet.Spend_type' table. You can move, or remove it, as needed.
        Me.Spend_typeTableAdapter.Fill(Me.DatabaseDataSet.Spend_type)

        Call txt(False)
        txt_Rnum.Text = " "
        Call button_enabled(False, False)
        btn_cancle.Visible = False
        ' btn_rguranter.Visible = False
        btn_borrower.Visible = False
        btn_credit.Enabled = False

    End Sub
    Private Sub btn_project_Click(sender As Object, e As EventArgs)
        btn_cancle.Visible = False
        btn_Search1.Visible = True
        frm_project.MdiParent = frm_main
        frm_project.Show()
    End Sub

    Private Sub btn_session_Click(sender As Object, e As EventArgs)
        btn_cancle.Visible = False
        btn_Search1.Visible = True
        frm_session.Show()
    End Sub

    Private Sub btn_credit_Click(sender As Object, e As EventArgs)
        btn_cancle.Visible = False
        btn_Search1.Visible = True
        ' frm_credit.MdiParent = frm_main
        'frm_credit.Show()
    End Sub

    Private Sub btn_borrower_Click(sender As Object, e As EventArgs) Handles btn_borrower.Click
        btn_cancle.Visible = False
        btn_Search1.Visible = True
        frm_borrower.MdiParent = frm_main
        frm_borrower.Show()
        '   frm_borrower.btn_First.Enabled = False
        '  frm_borrower.btn_next.Enabled = False
        '  frm_borrower.btn_priv.Enabled = False
        '  frm_borrower.btn_last.Enabled = False
        '  frm_borrower.btn_add.Enabled = False
        '  frm_borrower.btn_delete.Enabled = False
        '  frm_borrower.btn_Edit.Enabled = False
    End Sub

    Private Sub btn_creType_Click(sender As Object, e As EventArgs)
        btn_cancle.Visible = False
        btn_Search1.Visible = True

    End Sub

    Private Sub btn_SpenType_Click(sender As Object, e As EventArgs)
        btn_cancle.Visible = False
        btn_Search1.Visible = True

    End Sub

    Private Sub btn_incomeType_Click(sender As Object, e As EventArgs)
        btn_cancle.Visible = False
        btn_Search1.Visible = True

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        btn_cancle.Visible = False
        btn_Search1.Visible = True

    End Sub


    Private Sub btn_newRequest_Click(sender As Object, e As EventArgs) Handles btn_newRequest.Click

        btn_cancle.Visible = False
        btn_Search1.Visible = True
        frm_newRequest.MdiParent = frm_main
        frm_newRequest.Show()
    End Sub

    Private Sub labl()
        If txt_sessioncode.Text = 1 Then
            MessageBox.Show("The session was not held", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            btn_credit.Enabled = False
        Else
            If CB_YES.Checked = False Then

                MessageBox.Show("The request NOT Accepted.", "News", MessageBoxButtons.OK, MessageBoxIcon.Information)
                btn_credit.Enabled = False
            Else
                btn_credit.Enabled = True
            End If
            If txt_rCreTypNum.Text <> 1 Then
                lbl_pro.Visible = True
                lbl_pro1.Visible = False
                ' grp.Visible = False
            Else
                lbl_pro1.Visible = True
                lbl_pro.Visible = False
                '  grp.Visible = True
            End If
        End If
    End Sub
    Private Sub btn_rinsert_Click(sender As Object, e As EventArgs) Handles btn_rinsert.Click
        btn_Search1.Enabled = True
        btn_cancle.Visible = False
        btn_Search1.Visible = True
        Call button_enabled(False, True)
        Call loadingForm()
        btn_borrower.Visible = True
        ' btn_rguranter.Visible = True
        ' Call bondfalse()
        Call labl()
    End Sub


    Private Sub btn_first_Click(sender As Object, e As EventArgs) Handles btn_first.Click
        btn_cancle.Visible = False
        btn_Search1.Visible = True
        pos = 0
        Call loadingForm()
        Call button_enabled(False, True)
        '  Call bondfalse()
        Call labl()
    End Sub
    Private Sub loadingForm()
        str = "select * from Request"
        Dim cmd_req As New OleDbCommand(str, dbcon)
        da = New OleDbDataAdapter(cmd_req)
        ds = New DataSet
        da.Fill(ds)
        txt_Rnum.Text = ds.Tables(0).Rows(pos).Item(0)
        txt_rTotalcost.Text = ds.Tables(0).Rows(pos).Item(1)
        txt_rRequestvalue.Text = ds.Tables(0).Rows(pos).Item(2)
        txt_rCreditvalue.Text = ds.Tables(0).Rows(pos).Item(3)
        dtp_rdata.Text = ds.Tables(0).Rows(pos).Item(4)
        '  If ds.Tables(0).Rows(pos).Item(7) = -1 Then
        'MessageBox.Show("not held session")
        ' Else
        txt_sessioncode.Text = ds.Tables(0).Rows(pos).Item(7)
        'End If
        txt_rborrowerid.Text = ds.Tables(0).Rows(pos).Item(8)
        txt_projectcode.Text = ds.Tables(0).Rows(pos).Item(9)
        ' this command for fill table borrower(First name ,  Last name)
        Dim stborr As String
        stborr = "select First_name,last_name from Person , Request WHERE(Request.P_id =person.p_id)"
        Dim cmd_borr As New OleDbCommand(stborr, dbcon)
        da = New OleDbDataAdapter(cmd_borr)
        ds = New DataSet
        da.Fill(ds)
        txt_rborrfirname.Text = ds.Tables(0).Rows(pos).Item(0)
        txt_rborrlastname.Text = ds.Tables(0).Rows(pos).Item(1)
        'this command for fill table guranter(First name, Last name)
        Dim stGurnt As String
        stGurnt = "select First_name ,Last_name from Person,request,have_gaur where(have_gaur.p_id=person.p_id and request.req_num=have_gaur.req_num)"
        Dim cmd_gaur As New OleDbCommand(stGurnt, dbcon)
        da = New OleDbDataAdapter(cmd_gaur)
        ds = New DataSet
        da.Fill(ds)
        '  txt_RgurnFirstname.Text = ds.Tables(0).Rows(pos).Item(0)
        ' txt_rGurntLastname.Text = ds.Tables(0).Rows(pos).Item(1)
        'this command for  fill table guranter (guranter_ID)
        Dim st_havegurn As String
        st_havegurn = "select p_id from have_gaur , request where(request.req_num=have_gaur.req_num)"
        Dim cmdgaur As New OleDbCommand(st_havegurn, dbcon)
        da = New OleDbDataAdapter(cmd_gaur)
        ds = New DataSet
        da.Fill(ds)
        '   txt_rgurnID.Text = ds.Tables(0).Rows(pos).Item(0)
        'this command for fill table credit typr (all)
        Dim st_creTyp As String = "select * from Credit_type ,request where(credit_type.type_num=request.type_num)"
        Dim cmdcreTyp As New OleDbCommand(st_creTyp, dbcon)
        da = New OleDbDataAdapter(cmdcreTyp)
        ds = New DataSet
        da.Fill(ds)
        txt_rCreTypNum.Text = ds.Tables(0).Rows(pos).Item(0)
        txt_rCreTypName.Text = ds.Tables(0).Rows(pos).Item(1)
        'this command for fill Credit (Credit code)
        Dim st_CreCode As String
        st_CreCode = "select cre_cod from credit ,request where (credit.req_num=request.req_num)"
        Dim cmdCreCod As New OleDbCommand(st_CreCode, dbcon)
        da = New OleDbDataAdapter(cmdCreCod)
        ds = New DataSet
        da.Fill(ds)
        'txt_rcreCod.Text = ds.Tables(0).Rows(pos).Item(0)


        'this command for fill session(accept)
        Dim st_Accept As String
        st_Accept = "select * from sesion , request where (request.ses_code=sesion.ses_cod)"
        Dim cmdses As New OleDbCommand(st_Accept, dbcon)
        da = New OleDbDataAdapter(cmdses)
        ds = New DataSet
        da.Fill(ds)
        CB_YES.Checked = ds.Tables(0).Rows(pos).Item(3)

        ' this for fill spend Value:
        Dim st_SpValu As String
        st_SpValu = "select * from family_spend"
        Dim cmdspValu As New OleDbCommand(st_SpValu, dbcon)
        da = New OleDbDataAdapter(cmdspValu)
        ds = New DataSet
        da.Fill(ds)
        txt_rspendfamilyvalue.Text = ds.Tables(0).Rows(pos).Item(2)
        'this fill spend code , spend TYPE:
        Dim st_SpType As String
        st_SpType = "select * from spend_type,request,family_spend where(spend_type.sp_cod=family_spend.sp_cod and request.req_num=family_spend.req_num)"
        Dim cmdsptyp As New OleDbCommand(st_SpType, dbcon)
        da = New OleDbDataAdapter(cmdsptyp)
        ds = New DataSet
        da.Fill(ds)
        txt_rspendtypenum.Text = ds.Tables(0).Rows(pos).Item(0)
        txt_rSpendTypedes.Text = ds.Tables(0).Rows(pos).Item(1)

        ' this for fill income Value:
        Dim st_InValu As String
        st_InValu = "select * from family_income"
        Dim cmdInValu As New OleDbCommand(st_InValu, dbcon)
        da = New OleDbDataAdapter(cmdInValu)
        ds = New DataSet
        da.Fill(ds)
        txt_rInfamilyvalue.Text = ds.Tables(0).Rows(pos).Item(2)
        'this fill spend code , income TYPE:
        Dim st_inType As String
        st_inType = "select * from income_type,request,family_income where(income_type.in_t_code=family_income.in_t_code and request.req_num=family_income.req_num)"
        Dim cmdintyp As New OleDbCommand(st_inType, dbcon)
        da = New OleDbDataAdapter(cmdintyp)
        ds = New DataSet
        da.Fill(ds)
        txt_rincometypenum.Text = ds.Tables(0).Rows(pos).Item(0)
        txt_rincomeTypedes.Text = ds.Tables(0).Rows(pos).Item(1)

    End Sub
    Private Sub txt(ByVal a As Boolean)
        CB_YES.Enabled = a
        dtp_rdata.Enabled = a
        txt_rborrfirname.Enabled = a
        txt_rborrlastname.Enabled = a
        txt_rborrowerid.Enabled = a
        txt_rCreditvalue.Enabled = a
        txt_rCreTypNum.Enabled = a
        ' txt_RgurnFirstname.Enabled = a
        ' txt_rgurnID.Enabled = a
        ' txt_rGurntLastname.Enabled = a
        txt_Rnum.Enabled = a
        txt_projectcode.Enabled = a
        txt_rRequestvalue.Enabled = a
        txt_sessioncode.Enabled = a
        txt_rTotalcost.Enabled = a
        txt_rCreTypName.Enabled = a
        btn_Search1.Enabled = a

        txt_rspendfamilyvalue.Enabled = a
        txt_rspendtypenum.Enabled = a
        txt_rSpendTypedes.Enabled = a
        txt_rInfamilyvalue.Enabled = a
        txt_rincometypenum.Enabled = a
        txt_rincomeTypedes.Enabled = a
    End Sub
    Private Sub button_enabled(ByVal a As Boolean, b As Boolean)
        btn_first.Enabled = a
        btn_previus.Enabled = a
        btn_next.Enabled = b
        btn_last.Enabled = b
    End Sub


    Private Sub btn_previus_Click(sender As Object, e As EventArgs) Handles btn_previus.Click
        btn_cancle.Visible = False
        btn_Search1.Visible = True
        If pos <> 0 Then
            pos = pos - 1
            Call loadingForm()
            Call button_enabled(True, True)
        End If
        If pos = 0 Then
            Call button_enabled(False, True)
        End If
        ' Call bondfalse()
        Call labl()
    End Sub

    Private Sub btn_next_Click(sender As Object, e As EventArgs) Handles btn_next.Click
        btn_cancle.Visible = False
        btn_Search1.Visible = True

        If pos <> ds.Tables(0).Rows.Count - 1 Then
            pos = pos + 1
            Call loadingForm()
            Call button_enabled(True, True)
        End If
        If pos = ds.Tables(0).Rows.Count - 1 Then
            Call button_enabled(True, False)
        End If
        'Call bondfalse()
        Call labl()
    End Sub

    Private Sub btn_last_Click(sender As Object, e As EventArgs) Handles btn_last.Click
        btn_cancle.Visible = False
        btn_Search1.Visible = True
        pos = ds.Tables(0).Rows.Count - 1
        Call loadingForm()
        Call button_enabled(True, False)
        '  Call bondfalse()
        Call labl()
    End Sub

    Private Sub rb_rsearch_Click(sender As Object, e As EventArgs)
        ' Dim id As String
        ' id = InputBox("Enter Rquest number", "search")
        ' RequestBindingSource.Position = RequestBindingSource.Find("req_num", id)
        ' Call loadingForm()
    End Sub

    Private Sub btn_cancle_Click(sender As Object, e As EventArgs) Handles btn_cancle.Click
        btn_Search1.Visible = True
        btn_cancle.Visible = False
    End Sub

    Private Sub btn_searsh2_Click(sender As Object, e As EventArgs) Handles btn_searsh2.Click
        If txt_searsh.Text = " " Then
            pos = 0
            MessageBox.Show("you don't enter any value!!", "attention ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf (IsNumeric(txt_searsh.Text)) = False Then
            pos = 0
            MessageBox.Show("enter A number", "warrning ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf txt_searsh.Text <= 0 Then
            MessageBox.Show("enter value positive and greater than 0", "warrning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim str = "select req_num from request"
            Dim cmd As New OleDbCommand(str, dbcon)
            da = New OleDbDataAdapter(cmd)
            ds = New DataSet
            da.Fill(ds)
            Dim s As Boolean
            Dim x As Integer
            x = 0
            Dim i As Integer = ds.Tables(0).Rows.Count
            While x < i And s = False
                Dim data As Integer = ds.Tables(0).Rows(x).Item(0)
                If Val(txt_searsh.Text) = Data Then
                    s = True
                    pos = x
                Else
                    x = x + 1
                End If
            End While
            If s = True Then
                Call loadingForm()
            Else
                MessageBox.Show("the ID not exist")
            End If
        End If
        btn_Search1.Visible = True
        btn_cancle.Visible = False
        '  Call bondfalse()
        Call labl()
    End Sub

    Private Sub btn_Search1_Click(sender As Object, e As EventArgs) Handles btn_Search1.Click
        MessageBox.Show("PLEASE THE SEARSH BY REQUEST NUMBER", "attention ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        txt_searsh.Text = ""
        btn_Search1.Visible = False
        btn_cancle.Visible = True
        txt_searsh.Focus()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btn_credit.Click
        Form2.MdiParent = frm_main
        Form2.Show()
    End Sub

    Private Sub txt_searsh_LostFocus(sender As Object, e As EventArgs) Handles txt_searsh.LostFocus
        btn_searsh2.Focus()
    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs)
        btn_cancel.Show()
    End Sub
  

End Class