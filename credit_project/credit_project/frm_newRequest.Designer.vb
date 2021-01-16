<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_newRequest
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
        Dim Req_numLabel As System.Windows.Forms.Label
        Dim Total_costLabel As System.Windows.Forms.Label
        Dim Req_valueLabel As System.Windows.Forms.Label
        Dim Credit_durationLabel As System.Windows.Forms.Label
        Dim Req_dateLabel As System.Windows.Forms.Label
        Dim Ses_codeLabel As System.Windows.Forms.Label
        Dim Pro_idLabel As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim Label8 As System.Windows.Forms.Label
        Dim Label9 As System.Windows.Forms.Label
        Dim Label11 As System.Windows.Forms.Label
        Dim Label12 As System.Windows.Forms.Label
        Dim Label13 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_newRequest))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DatabaseDataSet = New credit_project.DatabaseDataSet()
        Me.RequestBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RequestTableAdapter = New credit_project.DatabaseDataSetTableAdapters.RequestTableAdapter()
        Me.TableAdapterManager = New credit_project.DatabaseDataSetTableAdapters.TableAdapterManager()
        Me.Family_incomeTableAdapter = New credit_project.DatabaseDataSetTableAdapters.Family_incomeTableAdapter()
        Me.Family_spendTableAdapter = New credit_project.DatabaseDataSetTableAdapters.Family_spendTableAdapter()
        Me.Income_typeTableAdapter = New credit_project.DatabaseDataSetTableAdapters.Income_typeTableAdapter()
        Me.PersonTableAdapter = New credit_project.DatabaseDataSetTableAdapters.PersonTableAdapter()
        Me.Spend_typeTableAdapter = New credit_project.DatabaseDataSetTableAdapters.Spend_typeTableAdapter()
        Me.RequestBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.RequestBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Req_numTextBox = New System.Windows.Forms.TextBox()
        Me.Total_costTextBox = New System.Windows.Forms.TextBox()
        Me.Req_valueTextBox = New System.Windows.Forms.TextBox()
        Me.Credit_durationTextBox = New System.Windows.Forms.TextBox()
        Me.Req_dateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Ses_codeTextBox = New System.Windows.Forms.TextBox()
        Me.Pro_idTextBox = New System.Windows.Forms.TextBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.PersonBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Family_f_valueTextBox = New System.Windows.Forms.TextBox()
        Me.RequestFamilyIncomeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txt_incType = New System.Windows.Forms.TextBox()
        Me.IncometypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.FamilyincomeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Sp_codTextBox = New System.Windows.Forms.TextBox()
        Me.SpendtypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.RequestFamilyspendBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBox5 = New System.Windows.Forms.ComboBox()
        Me.FamilyspendBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBox6 = New System.Windows.Forms.ComboBox()
        Me.CredittypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Credit_typeTableAdapter = New credit_project.DatabaseDataSetTableAdapters.Credit_typeTableAdapter()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.btn_pro = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.grp = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Req_numLabel = New System.Windows.Forms.Label()
        Total_costLabel = New System.Windows.Forms.Label()
        Req_valueLabel = New System.Windows.Forms.Label()
        Credit_durationLabel = New System.Windows.Forms.Label()
        Req_dateLabel = New System.Windows.Forms.Label()
        Ses_codeLabel = New System.Windows.Forms.Label()
        Pro_idLabel = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        Label8 = New System.Windows.Forms.Label()
        Label9 = New System.Windows.Forms.Label()
        Label11 = New System.Windows.Forms.Label()
        Label12 = New System.Windows.Forms.Label()
        Label13 = New System.Windows.Forms.Label()
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RequestBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RequestBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RequestBindingNavigator.SuspendLayout()
        CType(Me.PersonBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.RequestFamilyIncomeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IncometypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FamilyincomeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpendtypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RequestFamilyspendBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FamilyspendBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CredittypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStripContainer1.TopToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.grp.SuspendLayout()
        Me.SuspendLayout()
        '
        'Req_numLabel
        '
        Req_numLabel.AutoSize = True
        Req_numLabel.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Req_numLabel.Location = New System.Drawing.Point(109, 85)
        Req_numLabel.Name = "Req_numLabel"
        Req_numLabel.Size = New System.Drawing.Size(118, 13)
        Req_numLabel.TabIndex = 2
        Req_numLabel.Text = "Request Number:"
        '
        'Total_costLabel
        '
        Total_costLabel.AutoSize = True
        Total_costLabel.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Total_costLabel.Location = New System.Drawing.Point(402, 152)
        Total_costLabel.Name = "Total_costLabel"
        Total_costLabel.Size = New System.Drawing.Size(72, 13)
        Total_costLabel.TabIndex = 4
        Total_costLabel.Text = "total cost:"
        '
        'Req_valueLabel
        '
        Req_valueLabel.AutoSize = True
        Req_valueLabel.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Req_valueLabel.Location = New System.Drawing.Point(402, 194)
        Req_valueLabel.Name = "Req_valueLabel"
        Req_valueLabel.Size = New System.Drawing.Size(103, 13)
        Req_valueLabel.TabIndex = 6
        Req_valueLabel.Text = "Request value:"
        '
        'Credit_durationLabel
        '
        Credit_durationLabel.AutoSize = True
        Credit_durationLabel.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Credit_durationLabel.Location = New System.Drawing.Point(402, 222)
        Credit_durationLabel.Name = "Credit_durationLabel"
        Credit_durationLabel.Size = New System.Drawing.Size(109, 13)
        Credit_durationLabel.TabIndex = 8
        Credit_durationLabel.Text = "Credit duration:"
        '
        'Req_dateLabel
        '
        Req_dateLabel.AutoSize = True
        Req_dateLabel.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Req_dateLabel.Location = New System.Drawing.Point(410, 85)
        Req_dateLabel.Name = "Req_dateLabel"
        Req_dateLabel.Size = New System.Drawing.Size(45, 13)
        Req_dateLabel.TabIndex = 10
        Req_dateLabel.Text = " Date:"
        '
        'Ses_codeLabel
        '
        Ses_codeLabel.AutoSize = True
        Ses_codeLabel.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Ses_codeLabel.Location = New System.Drawing.Point(403, 297)
        Ses_codeLabel.Name = "Ses_codeLabel"
        Ses_codeLabel.Size = New System.Drawing.Size(96, 13)
        Ses_codeLabel.TabIndex = 16
        Ses_codeLabel.Text = "Session code:"
        '
        'Pro_idLabel
        '
        Pro_idLabel.AutoSize = True
        Pro_idLabel.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Pro_idLabel.Location = New System.Drawing.Point(407, 332)
        Pro_idLabel.Name = "Pro_idLabel"
        Pro_idLabel.Size = New System.Drawing.Size(77, 13)
        Pro_idLabel.TabIndex = 20
        Pro_idLabel.Text = "Project ID:"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Location = New System.Drawing.Point(7, 37)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(43, 13)
        Label5.TabIndex = 31
        Label5.Text = "Type:"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Location = New System.Drawing.Point(7, 83)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(95, 13)
        Label6.TabIndex = 32
        Label6.Text = "Family Value:"
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.Location = New System.Drawing.Point(208, 84)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(95, 13)
        Label7.TabIndex = 32
        Label7.Text = "Family Value:"
        '
        'Label8
        '
        Label8.AutoSize = True
        Label8.Location = New System.Drawing.Point(208, 38)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(43, 13)
        Label8.TabIndex = 31
        Label8.Text = "Type:"
        '
        'Label9
        '
        Label9.AutoSize = True
        Label9.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label9.Location = New System.Drawing.Point(403, 258)
        Label9.Name = "Label9"
        Label9.Size = New System.Drawing.Size(86, 13)
        Label9.TabIndex = 35
        Label9.Text = "Credit Type:"
        '
        'Label11
        '
        Label11.AutoSize = True
        Label11.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label11.ForeColor = System.Drawing.Color.Blue
        Label11.Location = New System.Drawing.Point(7, 9)
        Label11.Name = "Label11"
        Label11.Size = New System.Drawing.Size(65, 13)
        Label11.TabIndex = 75
        Label11.Text = "INCOME :"
        '
        'Label12
        '
        Label12.AutoSize = True
        Label12.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label12.ForeColor = System.Drawing.Color.Blue
        Label12.Location = New System.Drawing.Point(208, 9)
        Label12.Name = "Label12"
        Label12.Size = New System.Drawing.Size(57, 13)
        Label12.TabIndex = 76
        Label12.Text = "SPEND :"
        '
        'Label13
        '
        Label13.AutoSize = True
        Label13.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label13.ForeColor = System.Drawing.Color.Green
        Label13.Location = New System.Drawing.Point(410, 359)
        Label13.Name = "Label13"
        Label13.Size = New System.Drawing.Size(251, 13)
        Label13.TabIndex = 76
        Label13.Text = "*Click Save To Enter the Credit Form:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Perpetua Titling MT", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(273, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(173, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NEW REQUEST"
        '
        'DatabaseDataSet
        '
        Me.DatabaseDataSet.DataSetName = "DatabaseDataSet"
        Me.DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RequestBindingSource
        '
        Me.RequestBindingSource.DataMember = "Request"
        Me.RequestBindingSource.DataSource = Me.DatabaseDataSet
        '
        'RequestTableAdapter
        '
        Me.RequestTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.Family_incomeTableAdapter = Me.Family_incomeTableAdapter
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
        Me.TableAdapterManager.Income_typeTableAdapter = Me.Income_typeTableAdapter
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
        Me.TableAdapterManager.RequestTableAdapter = Me.RequestTableAdapter
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
        'Family_incomeTableAdapter
        '
        Me.Family_incomeTableAdapter.ClearBeforeFill = True
        '
        'Family_spendTableAdapter
        '
        Me.Family_spendTableAdapter.ClearBeforeFill = True
        '
        'Income_typeTableAdapter
        '
        Me.Income_typeTableAdapter.ClearBeforeFill = True
        '
        'PersonTableAdapter
        '
        Me.PersonTableAdapter.ClearBeforeFill = True
        '
        'Spend_typeTableAdapter
        '
        Me.Spend_typeTableAdapter.ClearBeforeFill = True
        '
        'RequestBindingNavigator
        '
        Me.RequestBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.RequestBindingNavigator.BindingSource = Me.RequestBindingSource
        Me.RequestBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.RequestBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.RequestBindingNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.RequestBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.RequestBindingNavigatorSaveItem})
        Me.RequestBindingNavigator.Location = New System.Drawing.Point(3, 0)
        Me.RequestBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.RequestBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.RequestBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.RequestBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.RequestBindingNavigator.Name = "RequestBindingNavigator"
        Me.RequestBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.RequestBindingNavigator.Size = New System.Drawing.Size(278, 25)
        Me.RequestBindingNavigator.TabIndex = 1
        Me.RequestBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'RequestBindingNavigatorSaveItem
        '
        Me.RequestBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.RequestBindingNavigatorSaveItem.Image = CType(resources.GetObject("RequestBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.RequestBindingNavigatorSaveItem.Name = "RequestBindingNavigatorSaveItem"
        Me.RequestBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.RequestBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Req_numTextBox
        '
        Me.Req_numTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RequestBindingSource, "Req_num", True))
        Me.Req_numTextBox.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Req_numTextBox.Location = New System.Drawing.Point(233, 82)
        Me.Req_numTextBox.Name = "Req_numTextBox"
        Me.Req_numTextBox.Size = New System.Drawing.Size(83, 21)
        Me.Req_numTextBox.TabIndex = 3
        '
        'Total_costTextBox
        '
        Me.Total_costTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RequestBindingSource, "total_cost", True))
        Me.Total_costTextBox.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Total_costTextBox.Location = New System.Drawing.Point(517, 149)
        Me.Total_costTextBox.Name = "Total_costTextBox"
        Me.Total_costTextBox.Size = New System.Drawing.Size(113, 21)
        Me.Total_costTextBox.TabIndex = 5
        '
        'Req_valueTextBox
        '
        Me.Req_valueTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RequestBindingSource, "Req_value", True))
        Me.Req_valueTextBox.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Req_valueTextBox.Location = New System.Drawing.Point(517, 188)
        Me.Req_valueTextBox.Name = "Req_valueTextBox"
        Me.Req_valueTextBox.Size = New System.Drawing.Size(113, 21)
        Me.Req_valueTextBox.TabIndex = 7
        '
        'Credit_durationTextBox
        '
        Me.Credit_durationTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RequestBindingSource, "Credit_duration", True))
        Me.Credit_durationTextBox.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Credit_durationTextBox.Location = New System.Drawing.Point(517, 219)
        Me.Credit_durationTextBox.Name = "Credit_durationTextBox"
        Me.Credit_durationTextBox.Size = New System.Drawing.Size(113, 21)
        Me.Credit_durationTextBox.TabIndex = 9
        '
        'Req_dateDateTimePicker
        '
        Me.Req_dateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.RequestBindingSource, "Req_date", True))
        Me.Req_dateDateTimePicker.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Req_dateDateTimePicker.Location = New System.Drawing.Point(461, 82)
        Me.Req_dateDateTimePicker.Name = "Req_dateDateTimePicker"
        Me.Req_dateDateTimePicker.Size = New System.Drawing.Size(244, 21)
        Me.Req_dateDateTimePicker.TabIndex = 11
        '
        'Ses_codeTextBox
        '
        Me.Ses_codeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RequestBindingSource, "Ses_code", True))
        Me.Ses_codeTextBox.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ses_codeTextBox.Location = New System.Drawing.Point(517, 292)
        Me.Ses_codeTextBox.Name = "Ses_codeTextBox"
        Me.Ses_codeTextBox.Size = New System.Drawing.Size(113, 21)
        Me.Ses_codeTextBox.TabIndex = 17
        '
        'Pro_idTextBox
        '
        Me.Pro_idTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RequestBindingSource, "Pro_id", True))
        Me.Pro_idTextBox.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pro_idTextBox.Location = New System.Drawing.Point(517, 329)
        Me.Pro_idTextBox.Name = "Pro_idTextBox"
        Me.Pro_idTextBox.Size = New System.Drawing.Size(113, 21)
        Me.Pro_idTextBox.TabIndex = 21
        '
        'ComboBox3
        '
        Me.ComboBox3.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.RequestBindingSource, "P_id", True))
        Me.ComboBox3.DataSource = Me.PersonBindingSource
        Me.ComboBox3.DisplayMember = "Last_name"
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(179, 44)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(92, 21)
        Me.ComboBox3.TabIndex = 24
        Me.ComboBox3.ValueMember = "P_id"
        '
        'PersonBindingSource
        '
        Me.PersonBindingSource.DataMember = "Person"
        Me.PersonBindingSource.DataSource = Me.DatabaseDataSet
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.RequestBindingSource, "P_id", True))
        Me.ComboBox1.DataSource = Me.PersonBindingSource
        Me.ComboBox1.DisplayMember = "First_name"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(4, 44)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(92, 21)
        Me.ComboBox1.TabIndex = 25
        Me.ComboBox1.ValueMember = "P_id"
        '
        'ComboBox2
        '
        Me.ComboBox2.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.RequestBindingSource, "P_id", True))
        Me.ComboBox2.DataSource = Me.PersonBindingSource
        Me.ComboBox2.DisplayMember = "Middle_name"
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(92, 44)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(92, 21)
        Me.ComboBox2.TabIndex = 26
        Me.ComboBox2.ValueMember = "P_id"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.ComboBox3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.ComboBox2)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 149)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(271, 91)
        Me.GroupBox1.TabIndex = 27
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Borrower Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(89, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Midlle:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(176, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Last:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "First:"
        '
        'Family_f_valueTextBox
        '
        Me.Family_f_valueTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RequestFamilyIncomeBindingSource, "Family_f_value", True))
        Me.Family_f_valueTextBox.Location = New System.Drawing.Point(108, 78)
        Me.Family_f_valueTextBox.Name = "Family_f_valueTextBox"
        Me.Family_f_valueTextBox.Size = New System.Drawing.Size(72, 21)
        Me.Family_f_valueTextBox.TabIndex = 62
        '
        'RequestFamilyIncomeBindingSource
        '
        Me.RequestFamilyIncomeBindingSource.DataMember = "RequestFamily income"
        Me.RequestFamilyIncomeBindingSource.DataSource = Me.RequestBindingSource
        '
        'txt_incType
        '
        Me.txt_incType.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IncometypeBindingSource, "In_t_code", True))
        Me.txt_incType.Location = New System.Drawing.Point(56, 34)
        Me.txt_incType.Name = "txt_incType"
        Me.txt_incType.Size = New System.Drawing.Size(29, 21)
        Me.txt_incType.TabIndex = 61
        '
        'IncometypeBindingSource
        '
        Me.IncometypeBindingSource.DataMember = "Income_type"
        Me.IncometypeBindingSource.DataSource = Me.DatabaseDataSet
        '
        'ComboBox4
        '
        Me.ComboBox4.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.RequestFamilyIncomeBindingSource, "In_T_code", True))
        Me.ComboBox4.DataSource = Me.IncometypeBindingSource
        Me.ComboBox4.DisplayMember = "In_t_des"
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Location = New System.Drawing.Point(85, 34)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(95, 21)
        Me.ComboBox4.TabIndex = 24
        Me.ComboBox4.ValueMember = "In_t_code"
        '
        'FamilyincomeBindingSource
        '
        Me.FamilyincomeBindingSource.DataMember = "Family_income"
        Me.FamilyincomeBindingSource.DataSource = Me.DatabaseDataSet
        '
        'Sp_codTextBox
        '
        Me.Sp_codTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SpendtypeBindingSource, "Sp_cod", True))
        Me.Sp_codTextBox.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sp_codTextBox.Location = New System.Drawing.Point(257, 34)
        Me.Sp_codTextBox.Name = "Sp_codTextBox"
        Me.Sp_codTextBox.Size = New System.Drawing.Size(29, 21)
        Me.Sp_codTextBox.TabIndex = 74
        '
        'SpendtypeBindingSource
        '
        Me.SpendtypeBindingSource.DataMember = "Spend_type"
        Me.SpendtypeBindingSource.DataSource = Me.DatabaseDataSet
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RequestFamilyspendBindingSource, "Fs_value", True))
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.RequestFamilyspendBindingSource, "Req_num", True))
        Me.TextBox1.Location = New System.Drawing.Point(309, 78)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(76, 21)
        Me.TextBox1.TabIndex = 33
        '
        'RequestFamilyspendBindingSource
        '
        Me.RequestFamilyspendBindingSource.DataMember = "RequestFamily_spend"
        Me.RequestFamilyspendBindingSource.DataSource = Me.RequestBindingSource
        '
        'ComboBox5
        '
        Me.ComboBox5.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.RequestFamilyIncomeBindingSource, "In_T_code", True))
        Me.ComboBox5.DataSource = Me.SpendtypeBindingSource
        Me.ComboBox5.DisplayMember = "Sp_des"
        Me.ComboBox5.FormattingEnabled = True
        Me.ComboBox5.Location = New System.Drawing.Point(286, 34)
        Me.ComboBox5.Name = "ComboBox5"
        Me.ComboBox5.Size = New System.Drawing.Size(99, 21)
        Me.ComboBox5.TabIndex = 24
        Me.ComboBox5.ValueMember = "Sp_cod"
        '
        'FamilyspendBindingSource
        '
        Me.FamilyspendBindingSource.DataMember = "Family_spend"
        Me.FamilyspendBindingSource.DataSource = Me.DatabaseDataSet
        '
        'ComboBox6
        '
        Me.ComboBox6.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.RequestBindingSource, "Type_num", True))
        Me.ComboBox6.DataSource = Me.CredittypeBindingSource
        Me.ComboBox6.DisplayMember = "type_name"
        Me.ComboBox6.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox6.FormattingEnabled = True
        Me.ComboBox6.Location = New System.Drawing.Point(517, 255)
        Me.ComboBox6.Name = "ComboBox6"
        Me.ComboBox6.Size = New System.Drawing.Size(113, 21)
        Me.ComboBox6.TabIndex = 30
        Me.ComboBox6.ValueMember = "type_num"
        '
        'CredittypeBindingSource
        '
        Me.CredittypeBindingSource.DataMember = "Credit_type"
        Me.CredittypeBindingSource.DataSource = Me.DatabaseDataSet
        '
        'Credit_typeTableAdapter
        '
        Me.Credit_typeTableAdapter.ClearBeforeFill = True
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.Red
        Me.Button6.Location = New System.Drawing.Point(630, 291)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 57
        Me.Button6.Text = "Session"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'btn_pro
        '
        Me.btn_pro.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_pro.ForeColor = System.Drawing.Color.Red
        Me.btn_pro.Location = New System.Drawing.Point(630, 329)
        Me.btn_pro.Name = "btn_pro"
        Me.btn_pro.Size = New System.Drawing.Size(75, 23)
        Me.btn_pro.TabIndex = 55
        Me.btn_pro.Text = "Project"
        Me.btn_pro.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Red
        Me.Button1.Location = New System.Drawing.Point(289, 172)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 51)
        Me.Button1.TabIndex = 58
        Me.Button1.Text = "New Person"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Blue
        Me.Button3.Location = New System.Drawing.Point(406, 114)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(224, 23)
        Me.Button3.TabIndex = 70
        Me.Button3.Text = "THE WORK"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'ToolStripContainer1
        '
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(736, 2)
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, -3)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.Size = New System.Drawing.Size(736, 27)
        Me.ToolStripContainer1.TabIndex = 73
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'ToolStripContainer1.TopToolStripPanel
        '
        Me.ToolStripContainer1.TopToolStripPanel.Controls.Add(Me.RequestBindingNavigator)
        '
        'grp
        '
        Me.grp.Controls.Add(Label12)
        Me.grp.Controls.Add(Label11)
        Me.grp.Controls.Add(Me.Button2)
        Me.grp.Controls.Add(Me.Sp_codTextBox)
        Me.grp.Controls.Add(Me.Family_f_valueTextBox)
        Me.grp.Controls.Add(Me.TextBox1)
        Me.grp.Controls.Add(Label7)
        Me.grp.Controls.Add(Label6)
        Me.grp.Controls.Add(Label8)
        Me.grp.Controls.Add(Me.ComboBox4)
        Me.grp.Controls.Add(Me.ComboBox5)
        Me.grp.Controls.Add(Me.txt_incType)
        Me.grp.Controls.Add(Label5)
        Me.grp.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grp.Location = New System.Drawing.Point(16, 246)
        Me.grp.Name = "grp"
        Me.grp.Size = New System.Drawing.Size(388, 152)
        Me.grp.TabIndex = 74
        Me.grp.TabStop = False
        Me.grp.Visible = False
        '
        'Button2
        '
        Me.Button2.ForeColor = System.Drawing.Color.Green
        Me.Button2.Location = New System.Drawing.Point(121, 105)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(179, 28)
        Me.Button2.TabIndex = 35
        Me.Button2.Text = "SAVE"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Enabled = False
        Me.Button4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Blue
        Me.Button4.Location = New System.Drawing.Point(413, 375)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(217, 23)
        Me.Button4.TabIndex = 75
        Me.Button4.Text = "Credit"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'frm_newRequest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(756, 410)
        Me.Controls.Add(Label13)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.grp)
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.btn_pro)
        Me.Controls.Add(Label9)
        Me.Controls.Add(Me.ComboBox6)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Req_numLabel)
        Me.Controls.Add(Me.Req_numTextBox)
        Me.Controls.Add(Total_costLabel)
        Me.Controls.Add(Me.Total_costTextBox)
        Me.Controls.Add(Req_valueLabel)
        Me.Controls.Add(Me.Req_valueTextBox)
        Me.Controls.Add(Credit_durationLabel)
        Me.Controls.Add(Me.Credit_durationTextBox)
        Me.Controls.Add(Req_dateLabel)
        Me.Controls.Add(Me.Req_dateDateTimePicker)
        Me.Controls.Add(Ses_codeLabel)
        Me.Controls.Add(Me.Ses_codeTextBox)
        Me.Controls.Add(Pro_idLabel)
        Me.Controls.Add(Me.Pro_idTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frm_newRequest"
        Me.Text = "Request"
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RequestBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RequestBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RequestBindingNavigator.ResumeLayout(False)
        Me.RequestBindingNavigator.PerformLayout()
        CType(Me.PersonBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.RequestFamilyIncomeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IncometypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FamilyincomeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpendtypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RequestFamilyspendBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FamilyspendBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CredittypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStripContainer1.TopToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.grp.ResumeLayout(False)
        Me.grp.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DatabaseDataSet As credit_project.DatabaseDataSet
    Friend WithEvents RequestBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RequestTableAdapter As credit_project.DatabaseDataSetTableAdapters.RequestTableAdapter
    Friend WithEvents TableAdapterManager As credit_project.DatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents RequestBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RequestBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Req_numTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Total_costTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Req_valueTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Credit_durationTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Req_dateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Ses_codeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Pro_idTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PersonTableAdapter As credit_project.DatabaseDataSetTableAdapters.PersonTableAdapter
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ComboBox4 As System.Windows.Forms.ComboBox
    Friend WithEvents PersonBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Income_typeTableAdapter As credit_project.DatabaseDataSetTableAdapters.Income_typeTableAdapter
    Friend WithEvents IncometypeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Family_incomeTableAdapter As credit_project.DatabaseDataSetTableAdapters.Family_incomeTableAdapter
    Friend WithEvents RequestFamilyIncomeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Spend_typeTableAdapter As credit_project.DatabaseDataSetTableAdapters.Spend_typeTableAdapter
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox5 As System.Windows.Forms.ComboBox
    Friend WithEvents SpendtypeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Family_spendTableAdapter As credit_project.DatabaseDataSetTableAdapters.Family_spendTableAdapter
    Friend WithEvents RequestFamilyspendBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FamilyincomeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FamilyspendBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ComboBox6 As System.Windows.Forms.ComboBox
    Friend WithEvents CredittypeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Credit_typeTableAdapter As credit_project.DatabaseDataSetTableAdapters.Credit_typeTableAdapter
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents btn_pro As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txt_incType As System.Windows.Forms.TextBox
    Friend WithEvents Family_f_valueTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents ToolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents Sp_codTextBox As System.Windows.Forms.TextBox
    Friend WithEvents grp As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
End Class
