<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_request
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.CB_YES = New System.Windows.Forms.CheckBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.btn_Search1 = New System.Windows.Forms.Button()
        Me.btn_searsh2 = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txt_searsh = New System.Windows.Forms.TextBox()
        Me.btn_cancle = New System.Windows.Forms.Button()
        Me.btn_last = New System.Windows.Forms.Button()
        Me.btn_next = New System.Windows.Forms.Button()
        Me.btn_previus = New System.Windows.Forms.Button()
        Me.btn_first = New System.Windows.Forms.Button()
        Me.btn_rinsert = New System.Windows.Forms.Button()
        Me.txt_projectcode = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btn_newRequest = New System.Windows.Forms.Button()
        Me.dtp_rdata = New System.Windows.Forms.DateTimePicker()
        Me.grp = New System.Windows.Forms.GroupBox()
        Me.txt_rCreTypName = New System.Windows.Forms.TextBox()
        Me.SpendtypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DatabaseDataSet = New credit_project.DatabaseDataSet()
        Me.txt_rCreTypNum = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_sessioncode = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_rCreditvalue = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_Rnum = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_rborrowerid = New System.Windows.Forms.TextBox()
        Me.txt_rTotalcost = New System.Windows.Forms.TextBox()
        Me.txt_rborrlastname = New System.Windows.Forms.TextBox()
        Me.txt_rborrfirname = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btn_borrower = New System.Windows.Forms.Button()
        Me.txt_rRequestvalue = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_credit = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txt_rSpendTypedes = New System.Windows.Forms.TextBox()
        Me.txt_rspendfamilyvalue = New System.Windows.Forms.TextBox()
        Me.txt_rspendtypenum = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.FamilyspendBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txt_rincomeTypedes = New System.Windows.Forms.TextBox()
        Me.txt_rInfamilyvalue = New System.Windows.Forms.TextBox()
        Me.txt_rincometypenum = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Spend_typeTableAdapter = New credit_project.DatabaseDataSetTableAdapters.Spend_typeTableAdapter()
        Me.Family_spendTableAdapter = New credit_project.DatabaseDataSetTableAdapters.Family_spendTableAdapter()
        Me.lbl_pro = New System.Windows.Forms.Label()
        Me.lbl_pro1 = New System.Windows.Forms.Label()
        Me.PersonBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PersonTableAdapter = New credit_project.DatabaseDataSetTableAdapters.PersonTableAdapter()
        Me.TableAdapterManager = New credit_project.DatabaseDataSetTableAdapters.TableAdapterManager()
        Me.grp.SuspendLayout()
        CType(Me.SpendtypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.FamilyspendBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.PersonBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CB_YES
        '
        Me.CB_YES.AutoSize = True
        Me.CB_YES.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_YES.Location = New System.Drawing.Point(577, 180)
        Me.CB_YES.Name = "CB_YES"
        Me.CB_YES.Size = New System.Drawing.Size(56, 22)
        Me.CB_YES.TabIndex = 80
        Me.CB_YES.Text = "yes"
        Me.CB_YES.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(402, 184)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(163, 18)
        Me.Label17.TabIndex = 79
        Me.Label17.Text = "Session (ACCEPT):"
        '
        'btn_Search1
        '
        Me.btn_Search1.BackColor = System.Drawing.Color.CadetBlue
        Me.btn_Search1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Search1.Location = New System.Drawing.Point(388, 293)
        Me.btn_Search1.Name = "btn_Search1"
        Me.btn_Search1.Size = New System.Drawing.Size(269, 54)
        Me.btn_Search1.TabIndex = 74
        Me.btn_Search1.Text = "Search"
        Me.btn_Search1.UseVisualStyleBackColor = False
        '
        'btn_searsh2
        '
        Me.btn_searsh2.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_searsh2.Location = New System.Drawing.Point(496, 324)
        Me.btn_searsh2.Name = "btn_searsh2"
        Me.btn_searsh2.Size = New System.Drawing.Size(75, 23)
        Me.btn_searsh2.TabIndex = 78
        Me.btn_searsh2.Text = "Searsh"
        Me.btn_searsh2.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Red
        Me.Label16.Location = New System.Drawing.Point(385, 299)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(237, 16)
        Me.Label16.TabIndex = 77
        Me.Label16.Text = "Please enter REQUEST NUMBER:"
        '
        'txt_searsh
        '
        Me.txt_searsh.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_searsh.Location = New System.Drawing.Point(388, 321)
        Me.txt_searsh.Name = "txt_searsh"
        Me.txt_searsh.Size = New System.Drawing.Size(100, 26)
        Me.txt_searsh.TabIndex = 76
        '
        'btn_cancle
        '
        Me.btn_cancle.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancle.Location = New System.Drawing.Point(577, 324)
        Me.btn_cancle.Name = "btn_cancle"
        Me.btn_cancle.Size = New System.Drawing.Size(75, 23)
        Me.btn_cancle.TabIndex = 75
        Me.btn_cancle.Text = "Cancle"
        Me.btn_cancle.UseVisualStyleBackColor = True
        '
        'btn_last
        '
        Me.btn_last.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_last.ForeColor = System.Drawing.Color.Firebrick
        Me.btn_last.Location = New System.Drawing.Point(616, 375)
        Me.btn_last.Name = "btn_last"
        Me.btn_last.Size = New System.Drawing.Size(75, 54)
        Me.btn_last.TabIndex = 73
        Me.btn_last.Text = "Last"
        Me.btn_last.UseVisualStyleBackColor = True
        '
        'btn_next
        '
        Me.btn_next.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_next.ForeColor = System.Drawing.Color.Firebrick
        Me.btn_next.Location = New System.Drawing.Point(535, 375)
        Me.btn_next.Name = "btn_next"
        Me.btn_next.Size = New System.Drawing.Size(75, 54)
        Me.btn_next.TabIndex = 72
        Me.btn_next.Text = "Next"
        Me.btn_next.UseVisualStyleBackColor = True
        '
        'btn_previus
        '
        Me.btn_previus.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_previus.ForeColor = System.Drawing.Color.Firebrick
        Me.btn_previus.Location = New System.Drawing.Point(439, 375)
        Me.btn_previus.Name = "btn_previus"
        Me.btn_previus.Size = New System.Drawing.Size(90, 54)
        Me.btn_previus.TabIndex = 71
        Me.btn_previus.Text = "Previous"
        Me.btn_previus.UseVisualStyleBackColor = True
        '
        'btn_first
        '
        Me.btn_first.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_first.ForeColor = System.Drawing.Color.Firebrick
        Me.btn_first.Location = New System.Drawing.Point(358, 375)
        Me.btn_first.Name = "btn_first"
        Me.btn_first.Size = New System.Drawing.Size(75, 54)
        Me.btn_first.TabIndex = 70
        Me.btn_first.Text = "First"
        Me.btn_first.UseVisualStyleBackColor = True
        '
        'btn_rinsert
        '
        Me.btn_rinsert.BackColor = System.Drawing.Color.Red
        Me.btn_rinsert.Font = New System.Drawing.Font("Verdana", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_rinsert.Location = New System.Drawing.Point(22, 43)
        Me.btn_rinsert.Name = "btn_rinsert"
        Me.btn_rinsert.Size = New System.Drawing.Size(325, 54)
        Me.btn_rinsert.TabIndex = 69
        Me.btn_rinsert.Text = "Load Data"
        Me.btn_rinsert.UseVisualStyleBackColor = False
        '
        'txt_projectcode
        '
        Me.txt_projectcode.Font = New System.Drawing.Font("Verdana", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_projectcode.Location = New System.Drawing.Point(866, 350)
        Me.txt_projectcode.Name = "txt_projectcode"
        Me.txt_projectcode.Size = New System.Drawing.Size(100, 26)
        Me.txt_projectcode.TabIndex = 68
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Verdana", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(724, 358)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(119, 18)
        Me.Label15.TabIndex = 67
        Me.Label15.Text = "Project Code:"
        '
        'btn_newRequest
        '
        Me.btn_newRequest.BackColor = System.Drawing.Color.OrangeRed
        Me.btn_newRequest.Font = New System.Drawing.Font("Verdana", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_newRequest.Location = New System.Drawing.Point(650, 43)
        Me.btn_newRequest.Name = "btn_newRequest"
        Me.btn_newRequest.Size = New System.Drawing.Size(316, 54)
        Me.btn_newRequest.TabIndex = 64
        Me.btn_newRequest.Text = "New Request"
        Me.btn_newRequest.UseVisualStyleBackColor = False
        '
        'dtp_rdata
        '
        Me.dtp_rdata.Font = New System.Drawing.Font("Verdana", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_rdata.Location = New System.Drawing.Point(602, 117)
        Me.dtp_rdata.Name = "dtp_rdata"
        Me.dtp_rdata.Size = New System.Drawing.Size(305, 26)
        Me.dtp_rdata.TabIndex = 63
        '
        'grp
        '
        Me.grp.Controls.Add(Me.txt_rCreTypName)
        Me.grp.Controls.Add(Me.txt_rCreTypNum)
        Me.grp.Controls.Add(Me.Label9)
        Me.grp.Font = New System.Drawing.Font("Verdana", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grp.Location = New System.Drawing.Point(19, 193)
        Me.grp.Name = "grp"
        Me.grp.Size = New System.Drawing.Size(268, 64)
        Me.grp.TabIndex = 59
        Me.grp.TabStop = False
        Me.grp.Text = "Credit Type"
        '
        'txt_rCreTypName
        '
        Me.txt_rCreTypName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SpendtypeBindingSource, "Sp_des", True))
        Me.txt_rCreTypName.Location = New System.Drawing.Point(105, 28)
        Me.txt_rCreTypName.Name = "txt_rCreTypName"
        Me.txt_rCreTypName.Size = New System.Drawing.Size(157, 26)
        Me.txt_rCreTypName.TabIndex = 33
        Me.txt_rCreTypName.Text = "Description"
        '
        'SpendtypeBindingSource
        '
        Me.SpendtypeBindingSource.DataMember = "Spend_type"
        Me.SpendtypeBindingSource.DataSource = Me.DatabaseDataSet
        '
        'DatabaseDataSet
        '
        Me.DatabaseDataSet.DataSetName = "DatabaseDataSet"
        Me.DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txt_rCreTypNum
        '
        Me.txt_rCreTypNum.Location = New System.Drawing.Point(66, 27)
        Me.txt_rCreTypNum.Name = "txt_rCreTypNum"
        Me.txt_rCreTypNum.Size = New System.Drawing.Size(31, 26)
        Me.txt_rCreTypNum.TabIndex = 34
        Me.txt_rCreTypNum.Text = "ID"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 24)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 18)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Type:"
        '
        'txt_sessioncode
        '
        Me.txt_sessioncode.Font = New System.Drawing.Font("Verdana", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_sessioncode.Location = New System.Drawing.Point(866, 308)
        Me.txt_sessioncode.Name = "txt_sessioncode"
        Me.txt_sessioncode.Size = New System.Drawing.Size(100, 26)
        Me.txt_sessioncode.TabIndex = 58
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(724, 316)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(123, 18)
        Me.Label8.TabIndex = 57
        Me.Label8.Text = "Session Code:"
        '
        'txt_rCreditvalue
        '
        Me.txt_rCreditvalue.Font = New System.Drawing.Font("Verdana", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_rCreditvalue.Location = New System.Drawing.Point(866, 263)
        Me.txt_rCreditvalue.Name = "txt_rCreditvalue"
        Me.txt_rCreditvalue.Size = New System.Drawing.Size(100, 26)
        Me.txt_rCreditvalue.TabIndex = 56
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(724, 271)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(138, 18)
        Me.Label7.TabIndex = 55
        Me.Label7.Text = "Credit Duration:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(724, 188)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 18)
        Me.Label5.TabIndex = 51
        Me.Label5.Text = "Total Cost:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(548, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 18)
        Me.Label4.TabIndex = 50
        Me.Label4.Text = "Date:"
        '
        'txt_Rnum
        '
        Me.txt_Rnum.Font = New System.Drawing.Font("Verdana", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Rnum.Location = New System.Drawing.Point(483, 117)
        Me.txt_Rnum.Name = "txt_Rnum"
        Me.txt_Rnum.Size = New System.Drawing.Size(57, 26)
        Me.txt_Rnum.TabIndex = 49
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(398, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 18)
        Me.Label3.TabIndex = 48
        Me.Label3.Text = "Number:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Perpetua Titling MT", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(424, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 29)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "Details"
        '
        'txt_rborrowerid
        '
        Me.txt_rborrowerid.Location = New System.Drawing.Point(9, 18)
        Me.txt_rborrowerid.Name = "txt_rborrowerid"
        Me.txt_rborrowerid.Size = New System.Drawing.Size(51, 26)
        Me.txt_rborrowerid.TabIndex = 12
        Me.txt_rborrowerid.Text = "ID"
        '
        'txt_rTotalcost
        '
        Me.txt_rTotalcost.Font = New System.Drawing.Font("Verdana", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_rTotalcost.Location = New System.Drawing.Point(866, 180)
        Me.txt_rTotalcost.Name = "txt_rTotalcost"
        Me.txt_rTotalcost.Size = New System.Drawing.Size(100, 26)
        Me.txt_rTotalcost.TabIndex = 52
        '
        'txt_rborrlastname
        '
        Me.txt_rborrlastname.Location = New System.Drawing.Point(160, 17)
        Me.txt_rborrlastname.Name = "txt_rborrlastname"
        Me.txt_rborrlastname.Size = New System.Drawing.Size(100, 26)
        Me.txt_rborrlastname.TabIndex = 14
        Me.txt_rborrlastname.Text = "La_name"
        '
        'txt_rborrfirname
        '
        Me.txt_rborrfirname.Location = New System.Drawing.Point(66, 18)
        Me.txt_rborrfirname.Name = "txt_rborrfirname"
        Me.txt_rborrfirname.Size = New System.Drawing.Size(88, 26)
        Me.txt_rborrfirname.TabIndex = 13
        Me.txt_rborrfirname.Text = "FI_Name"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(724, 228)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(136, 18)
        Me.Label6.TabIndex = 53
        Me.Label6.Text = "Request value: "
        '
        'btn_borrower
        '
        Me.btn_borrower.Location = New System.Drawing.Point(268, 16)
        Me.btn_borrower.Name = "btn_borrower"
        Me.btn_borrower.Size = New System.Drawing.Size(91, 27)
        Me.btn_borrower.TabIndex = 11
        Me.btn_borrower.Text = "Details"
        Me.btn_borrower.UseVisualStyleBackColor = True
        '
        'txt_rRequestvalue
        '
        Me.txt_rRequestvalue.Font = New System.Drawing.Font("Verdana", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_rRequestvalue.Location = New System.Drawing.Point(866, 220)
        Me.txt_rRequestvalue.Name = "txt_rRequestvalue"
        Me.txt_rRequestvalue.Size = New System.Drawing.Size(100, 26)
        Me.txt_rRequestvalue.TabIndex = 54
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_rborrlastname)
        Me.GroupBox1.Controls.Add(Me.txt_rborrfirname)
        Me.GroupBox1.Controls.Add(Me.txt_rborrowerid)
        Me.GroupBox1.Controls.Add(Me.btn_borrower)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(10, 117)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(366, 50)
        Me.GroupBox1.TabIndex = 46
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "borrower"
        '
        'btn_credit
        '
        Me.btn_credit.Font = New System.Drawing.Font("Verdana", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_credit.ForeColor = System.Drawing.Color.Green
        Me.btn_credit.Location = New System.Drawing.Point(388, 239)
        Me.btn_credit.Name = "btn_credit"
        Me.btn_credit.Size = New System.Drawing.Size(264, 31)
        Me.btn_credit.TabIndex = 83
        Me.btn_credit.Text = "CREDIT AND BOND"
        Me.btn_credit.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txt_rSpendTypedes)
        Me.GroupBox3.Controls.Add(Me.txt_rspendfamilyvalue)
        Me.GroupBox3.Controls.Add(Me.txt_rspendtypenum)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Font = New System.Drawing.Font("Verdana", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(19, 263)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(268, 90)
        Me.GroupBox3.TabIndex = 84
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Spend"
        '
        'txt_rSpendTypedes
        '
        Me.txt_rSpendTypedes.Location = New System.Drawing.Point(105, 19)
        Me.txt_rSpendTypedes.Name = "txt_rSpendTypedes"
        Me.txt_rSpendTypedes.Size = New System.Drawing.Size(157, 26)
        Me.txt_rSpendTypedes.TabIndex = 27
        Me.txt_rSpendTypedes.Text = "Description"
        '
        'txt_rspendfamilyvalue
        '
        Me.txt_rspendfamilyvalue.Location = New System.Drawing.Point(131, 54)
        Me.txt_rspendfamilyvalue.Name = "txt_rspendfamilyvalue"
        Me.txt_rspendfamilyvalue.Size = New System.Drawing.Size(129, 26)
        Me.txt_rspendfamilyvalue.TabIndex = 25
        '
        'txt_rspendtypenum
        '
        Me.txt_rspendtypenum.Location = New System.Drawing.Point(63, 19)
        Me.txt_rspendtypenum.Name = "txt_rspendtypenum"
        Me.txt_rspendtypenum.Size = New System.Drawing.Size(34, 26)
        Me.txt_rspendtypenum.TabIndex = 24
        Me.txt_rspendtypenum.Text = "ID"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(0, 62)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(118, 18)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "Family Value:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(3, 22)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(55, 18)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Type:"
        '
        'FamilyspendBindingSource
        '
        Me.FamilyspendBindingSource.DataMember = "Family_spend"
        Me.FamilyspendBindingSource.DataSource = Me.DatabaseDataSet
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txt_rincomeTypedes)
        Me.GroupBox4.Controls.Add(Me.txt_rInfamilyvalue)
        Me.GroupBox4.Controls.Add(Me.txt_rincometypenum)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Font = New System.Drawing.Font("Verdana", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(22, 359)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(265, 73)
        Me.GroupBox4.TabIndex = 85
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Income"
        '
        'txt_rincomeTypedes
        '
        Me.txt_rincomeTypedes.Location = New System.Drawing.Point(103, 18)
        Me.txt_rincomeTypedes.Name = "txt_rincomeTypedes"
        Me.txt_rincomeTypedes.Size = New System.Drawing.Size(157, 26)
        Me.txt_rincomeTypedes.TabIndex = 28
        Me.txt_rincomeTypedes.Text = "Name"
        '
        'txt_rInfamilyvalue
        '
        Me.txt_rInfamilyvalue.Location = New System.Drawing.Point(131, 47)
        Me.txt_rInfamilyvalue.Name = "txt_rInfamilyvalue"
        Me.txt_rInfamilyvalue.Size = New System.Drawing.Size(129, 26)
        Me.txt_rInfamilyvalue.TabIndex = 28
        '
        'txt_rincometypenum
        '
        Me.txt_rincometypenum.Location = New System.Drawing.Point(54, 19)
        Me.txt_rincometypenum.Name = "txt_rincometypenum"
        Me.txt_rincometypenum.Size = New System.Drawing.Size(43, 26)
        Me.txt_rincometypenum.TabIndex = 25
        Me.txt_rincometypenum.Text = "ID"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(3, 52)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(118, 18)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "Family Value:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(3, 22)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(55, 18)
        Me.Label13.TabIndex = 25
        Me.Label13.Text = "Type:"
        '
        'Spend_typeTableAdapter
        '
        Me.Spend_typeTableAdapter.ClearBeforeFill = True
        '
        'Family_spendTableAdapter
        '
        Me.Family_spendTableAdapter.ClearBeforeFill = True
        '
        'lbl_pro
        '
        Me.lbl_pro.AutoSize = True
        Me.lbl_pro.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_pro.ForeColor = System.Drawing.Color.Red
        Me.lbl_pro.Location = New System.Drawing.Point(723, 407)
        Me.lbl_pro.Name = "lbl_pro"
        Me.lbl_pro.Size = New System.Drawing.Size(220, 23)
        Me.lbl_pro.TabIndex = 87
        Me.lbl_pro.Text = "*He Has No Project"
        Me.lbl_pro.Visible = False
        '
        'lbl_pro1
        '
        Me.lbl_pro1.AutoSize = True
        Me.lbl_pro1.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_pro1.ForeColor = System.Drawing.Color.Green
        Me.lbl_pro1.Location = New System.Drawing.Point(723, 405)
        Me.lbl_pro1.Name = "lbl_pro1"
        Me.lbl_pro1.Size = New System.Drawing.Size(184, 23)
        Me.lbl_pro1.TabIndex = 88
        Me.lbl_pro1.Text = "*He Has Project"
        Me.lbl_pro1.Visible = False
        '
        'PersonBindingSource
        '
        Me.PersonBindingSource.DataMember = "Person"
        Me.PersonBindingSource.DataSource = Me.DatabaseDataSet
        '
        'PersonTableAdapter
        '
        Me.PersonTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AnswerTableAdapter = Nothing
        Me.TableAdapterManager.Assets_typeTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.bnd1TableAdapter = Nothing
        Me.TableAdapterManager.BorrowerTableAdapter = Nothing
        Me.TableAdapterManager.BuildingTableAdapter = Nothing
        Me.TableAdapterManager.Case_projectTableAdapter = Nothing
        Me.TableAdapterManager.CategoryTableAdapter = Nothing
        Me.TableAdapterManager.CompanyTableAdapter = Nothing
        Me.TableAdapterManager.Concern_projectTableAdapter = Nothing
        Me.TableAdapterManager.Credit_typeTableAdapter = Nothing
        Me.TableAdapterManager.CreditTableAdapter = Nothing
        Me.TableAdapterManager.DetailsTableAdapter = Nothing
        Me.TableAdapterManager.DistristTableAdapter = Nothing
        Me.TableAdapterManager.Educational_levelTableAdapter = Nothing
        Me.TableAdapterManager.Exist_answerTableAdapter = Nothing
        Me.TableAdapterManager.ExistTableAdapter = Nothing
        Me.TableAdapterManager.Family_incomeTableAdapter = Nothing
        Me.TableAdapterManager.Family_spendTableAdapter = Me.Family_spendTableAdapter
        Me.TableAdapterManager.Family_statusTableAdapter = Nothing
        Me.TableAdapterManager.GiveTableAdapter = Nothing
        Me.TableAdapterManager.GuranterTableAdapter = Nothing
        Me.TableAdapterManager.Has_answerTableAdapter = Nothing
        Me.TableAdapterManager.Has_emplTableAdapter = Nothing
        Me.TableAdapterManager.Have_assetsTableAdapter = Nothing
        Me.TableAdapterManager.Have_gaurTableAdapter = Nothing
        Me.TableAdapterManager.Have_insuTableAdapter = Nothing
        Me.TableAdapterManager.Have_partnerTableAdapter = Nothing
        Me.TableAdapterManager.Have_supTableAdapter = Nothing
        Me.TableAdapterManager.Income_typeTableAdapter = Nothing
        Me.TableAdapterManager.InsuranceTableAdapter = Nothing
        Me.TableAdapterManager.Last_classTableAdapter = Nothing
        Me.TableAdapterManager.LinkTableAdapter = Nothing
        Me.TableAdapterManager.Loan_registerTableAdapter = Nothing
        Me.TableAdapterManager.PartnerTableAdapter = Nothing
        Me.TableAdapterManager.Payment_modeTableAdapter = Nothing
        Me.TableAdapterManager.PersonTableAdapter = Me.PersonTableAdapter
        Me.TableAdapterManager.Profession_statusTableAdapter = Nothing
        Me.TableAdapterManager.ProfessionTableAdapter = Nothing
        Me.TableAdapterManager.Project_spondTableAdapter = Nothing
        Me.TableAdapterManager.Project_typeTableAdapter = Nothing
        Me.TableAdapterManager.ProjectTableAdapter = Nothing
        Me.TableAdapterManager.ProvinceTableAdapter = Nothing
        Me.TableAdapterManager.QuestionsTableAdapter = Nothing
        Me.TableAdapterManager.RegionTableAdapter = Nothing
        Me.TableAdapterManager.RelationTableAdapter = Nothing
        Me.TableAdapterManager.RequestTableAdapter = Nothing
        Me.TableAdapterManager.School_or_universityTableAdapter = Nothing
        Me.TableAdapterManager.Second_addressTableAdapter = Nothing
        Me.TableAdapterManager.Service_projectTableAdapter = Nothing
        Me.TableAdapterManager.sesionTableAdapter = Nothing
        Me.TableAdapterManager.SessionTableAdapter = Nothing
        Me.TableAdapterManager.ShiftTableAdapter = Nothing
        Me.TableAdapterManager.Social_typeTableAdapter = Nothing
        Me.TableAdapterManager.Spend_typeTableAdapter = Me.Spend_typeTableAdapter
        Me.TableAdapterManager.StreetTableAdapter = Nothing
        Me.TableAdapterManager.SuppliersTableAdapter = Nothing
        Me.TableAdapterManager.TownTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = credit_project.DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.Work_typeTableAdapter = Nothing
        Me.TableAdapterManager.WorkTableAdapter = Nothing
        '
        'frm_request
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(995, 682)
        Me.Controls.Add(Me.lbl_pro1)
        Me.Controls.Add(Me.lbl_pro)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btn_credit)
        Me.Controls.Add(Me.CB_YES)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.btn_Search1)
        Me.Controls.Add(Me.btn_searsh2)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txt_searsh)
        Me.Controls.Add(Me.btn_cancle)
        Me.Controls.Add(Me.btn_last)
        Me.Controls.Add(Me.btn_next)
        Me.Controls.Add(Me.btn_previus)
        Me.Controls.Add(Me.btn_first)
        Me.Controls.Add(Me.btn_rinsert)
        Me.Controls.Add(Me.txt_projectcode)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.btn_newRequest)
        Me.Controls.Add(Me.dtp_rdata)
        Me.Controls.Add(Me.grp)
        Me.Controls.Add(Me.txt_sessioncode)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txt_rCreditvalue)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_Rnum)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_rTotalcost)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_rRequestvalue)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frm_request"
        Me.Text = "Details"
        Me.grp.ResumeLayout(False)
        Me.grp.PerformLayout()
        CType(Me.SpendtypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.FamilyspendBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.PersonBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CB_YES As System.Windows.Forms.CheckBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents btn_Search1 As System.Windows.Forms.Button
    Friend WithEvents btn_searsh2 As System.Windows.Forms.Button
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txt_searsh As System.Windows.Forms.TextBox
    Friend WithEvents btn_cancle As System.Windows.Forms.Button
    Friend WithEvents btn_last As System.Windows.Forms.Button
    Friend WithEvents btn_next As System.Windows.Forms.Button
    Friend WithEvents btn_previus As System.Windows.Forms.Button
    Friend WithEvents btn_first As System.Windows.Forms.Button
    Friend WithEvents btn_rinsert As System.Windows.Forms.Button
    Friend WithEvents txt_projectcode As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents btn_newRequest As System.Windows.Forms.Button
    Friend WithEvents dtp_rdata As System.Windows.Forms.DateTimePicker
    Friend WithEvents grp As System.Windows.Forms.GroupBox
    Friend WithEvents txt_rCreTypName As System.Windows.Forms.TextBox
    Friend WithEvents txt_rCreTypNum As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txt_sessioncode As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_rCreditvalue As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_Rnum As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_rborrowerid As System.Windows.Forms.TextBox
    Friend WithEvents txt_rTotalcost As System.Windows.Forms.TextBox
    Friend WithEvents txt_rborrlastname As System.Windows.Forms.TextBox
    Friend WithEvents txt_rborrfirname As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btn_borrower As System.Windows.Forms.Button
    Friend WithEvents txt_rRequestvalue As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_credit As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_rSpendTypedes As System.Windows.Forms.TextBox
    Friend WithEvents txt_rspendfamilyvalue As System.Windows.Forms.TextBox
    Friend WithEvents txt_rspendtypenum As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_rincomeTypedes As System.Windows.Forms.TextBox
    Friend WithEvents txt_rInfamilyvalue As System.Windows.Forms.TextBox
    Friend WithEvents txt_rincometypenum As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents DatabaseDataSet As credit_project.DatabaseDataSet
    Friend WithEvents SpendtypeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Spend_typeTableAdapter As credit_project.DatabaseDataSetTableAdapters.Spend_typeTableAdapter
    Friend WithEvents FamilyspendBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Family_spendTableAdapter As credit_project.DatabaseDataSetTableAdapters.Family_spendTableAdapter
    Friend WithEvents lbl_pro As System.Windows.Forms.Label
    Friend WithEvents lbl_pro1 As System.Windows.Forms.Label
    Friend WithEvents PersonBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PersonTableAdapter As credit_project.DatabaseDataSetTableAdapters.PersonTableAdapter
    Friend WithEvents TableAdapterManager As credit_project.DatabaseDataSetTableAdapters.TableAdapterManager
End Class
