<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class btn_cancel
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
        Dim P_idLabel As System.Windows.Forms.Label
        Dim Pr_st_codLabel As System.Windows.Forms.Label
        Dim Sch_numLabel As System.Windows.Forms.Label
        Dim Cl_codLabel As System.Windows.Forms.Label
        Dim Ed_i_idLabel As System.Windows.Forms.Label
        Dim Insu_numLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(btn_cancel))
        Me.DatabaseDataSet = New credit_project.DatabaseDataSet()
        Me.BorrowerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BorrowerTableAdapter = New credit_project.DatabaseDataSetTableAdapters.BorrowerTableAdapter()
        Me.TableAdapterManager = New credit_project.DatabaseDataSetTableAdapters.TableAdapterManager()
        Me.Educational_levelTableAdapter = New credit_project.DatabaseDataSetTableAdapters.Educational_levelTableAdapter()
        Me.InsuranceTableAdapter = New credit_project.DatabaseDataSetTableAdapters.InsuranceTableAdapter()
        Me.Last_classTableAdapter = New credit_project.DatabaseDataSetTableAdapters.Last_classTableAdapter()
        Me.Profession_statusTableAdapter = New credit_project.DatabaseDataSetTableAdapters.Profession_statusTableAdapter()
        Me.School_or_universityTableAdapter = New credit_project.DatabaseDataSetTableAdapters.School_or_universityTableAdapter()
        Me.BorrowerBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.BorrowerBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.P_idTextBox = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ProfessionstatusBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.SchooloruniversityBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.LastclassBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.EducationallevelBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBox5 = New System.Windows.Forms.ComboBox()
        Me.InsuranceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ed_i_idTextBox = New System.Windows.Forms.TextBox()
        Me.btn_new = New System.Windows.Forms.Button()
        Me.ComboBox6 = New System.Windows.Forms.ComboBox()
        Me.PersonBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBox7 = New System.Windows.Forms.ComboBox()
        Me.ComboBox8 = New System.Windows.Forms.ComboBox()
        Me.PersonTableAdapter = New credit_project.DatabaseDataSetTableAdapters.PersonTableAdapter()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.Pr_st_codTextBox = New System.Windows.Forms.TextBox()
        Me.sch_txt = New System.Windows.Forms.TextBox()
        Me.Cl_codTextBox = New System.Windows.Forms.TextBox()
        Me.Insu_numTextBox = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_search = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        P_idLabel = New System.Windows.Forms.Label()
        Pr_st_codLabel = New System.Windows.Forms.Label()
        Sch_numLabel = New System.Windows.Forms.Label()
        Cl_codLabel = New System.Windows.Forms.Label()
        Ed_i_idLabel = New System.Windows.Forms.Label()
        Insu_numLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BorrowerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BorrowerBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BorrowerBindingNavigator.SuspendLayout()
        CType(Me.ProfessionstatusBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SchooloruniversityBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LastclassBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EducationallevelBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InsuranceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PersonBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'P_idLabel
        '
        P_idLabel.AutoSize = True
        P_idLabel.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        P_idLabel.Location = New System.Drawing.Point(28, 68)
        P_idLabel.Name = "P_idLabel"
        P_idLabel.Size = New System.Drawing.Size(82, 13)
        P_idLabel.TabIndex = 1
        P_idLabel.Text = "Borrwer ID:"
        '
        'Pr_st_codLabel
        '
        Pr_st_codLabel.AutoSize = True
        Pr_st_codLabel.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Pr_st_codLabel.Location = New System.Drawing.Point(57, 138)
        Pr_st_codLabel.Name = "Pr_st_codLabel"
        Pr_st_codLabel.Size = New System.Drawing.Size(125, 13)
        Pr_st_codLabel.TabIndex = 3
        Pr_st_codLabel.Text = "Profession Status:"
        '
        'Sch_numLabel
        '
        Sch_numLabel.AutoSize = True
        Sch_numLabel.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Sch_numLabel.Location = New System.Drawing.Point(57, 170)
        Sch_numLabel.Name = "Sch_numLabel"
        Sch_numLabel.Size = New System.Drawing.Size(146, 13)
        Sch_numLabel.TabIndex = 5
        Sch_numLabel.Text = "School OR University:"
        '
        'Cl_codLabel
        '
        Cl_codLabel.AutoSize = True
        Cl_codLabel.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Cl_codLabel.Location = New System.Drawing.Point(57, 192)
        Cl_codLabel.Name = "Cl_codLabel"
        Cl_codLabel.Size = New System.Drawing.Size(76, 13)
        Cl_codLabel.TabIndex = 7
        Cl_codLabel.Text = "Last Class:"
        '
        'Ed_i_idLabel
        '
        Ed_i_idLabel.AutoSize = True
        Ed_i_idLabel.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Ed_i_idLabel.Location = New System.Drawing.Point(57, 222)
        Ed_i_idLabel.Name = "Ed_i_idLabel"
        Ed_i_idLabel.Size = New System.Drawing.Size(111, 13)
        Ed_i_idLabel.TabIndex = 9
        Ed_i_idLabel.Text = "Education level:"
        '
        'Insu_numLabel
        '
        Insu_numLabel.AutoSize = True
        Insu_numLabel.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Insu_numLabel.Location = New System.Drawing.Point(57, 249)
        Insu_numLabel.Name = "Insu_numLabel"
        Insu_numLabel.Size = New System.Drawing.Size(77, 13)
        Insu_numLabel.TabIndex = 11
        Insu_numLabel.Text = "Insurance:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Perpetua Titling MT", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.Location = New System.Drawing.Point(111, 36)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(147, 26)
        Label1.TabIndex = 14
        Label1.Text = "BORROWER"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label3.Location = New System.Drawing.Point(57, 110)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(104, 13)
        Label3.TabIndex = 23
        Label3.Text = "Borrwer Name:"
        '
        'DatabaseDataSet
        '
        Me.DatabaseDataSet.DataSetName = "DatabaseDataSet"
        Me.DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BorrowerBindingSource
        '
        Me.BorrowerBindingSource.DataMember = "Borrower"
        Me.BorrowerBindingSource.DataSource = Me.DatabaseDataSet
        '
        'BorrowerTableAdapter
        '
        Me.BorrowerTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AnswerTableAdapter = Nothing
        Me.TableAdapterManager.Assets_typeTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.bnd1TableAdapter = Nothing
        Me.TableAdapterManager.BorrowerTableAdapter = Me.BorrowerTableAdapter
        Me.TableAdapterManager.BuildingTableAdapter = Nothing
        Me.TableAdapterManager.Case_projectTableAdapter = Nothing
        Me.TableAdapterManager.CategoryTableAdapter = Nothing
        Me.TableAdapterManager.CompanyTableAdapter = Nothing
        Me.TableAdapterManager.Concern_projectTableAdapter = Nothing
        Me.TableAdapterManager.Credit_typeTableAdapter = Nothing
        Me.TableAdapterManager.CreditTableAdapter = Nothing
        Me.TableAdapterManager.DetailsTableAdapter = Nothing
        Me.TableAdapterManager.DistristTableAdapter = Nothing
        Me.TableAdapterManager.Educational_levelTableAdapter = Me.Educational_levelTableAdapter
        Me.TableAdapterManager.Exist_answerTableAdapter = Nothing
        Me.TableAdapterManager.ExistTableAdapter = Nothing
        Me.TableAdapterManager.Family_incomeTableAdapter = Nothing
        Me.TableAdapterManager.Family_spendTableAdapter = Nothing
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
        Me.TableAdapterManager.InsuranceTableAdapter = Me.InsuranceTableAdapter
        Me.TableAdapterManager.Last_classTableAdapter = Me.Last_classTableAdapter
        Me.TableAdapterManager.LinkTableAdapter = Nothing
        Me.TableAdapterManager.Loan_registerTableAdapter = Nothing
        Me.TableAdapterManager.PartnerTableAdapter = Nothing
        Me.TableAdapterManager.Payment_modeTableAdapter = Nothing
        Me.TableAdapterManager.PersonTableAdapter = Nothing
        Me.TableAdapterManager.Profession_statusTableAdapter = Me.Profession_statusTableAdapter
        Me.TableAdapterManager.ProfessionTableAdapter = Nothing
        Me.TableAdapterManager.Project_spondTableAdapter = Nothing
        Me.TableAdapterManager.Project_typeTableAdapter = Nothing
        Me.TableAdapterManager.ProjectTableAdapter = Nothing
        Me.TableAdapterManager.ProvinceTableAdapter = Nothing
        Me.TableAdapterManager.QuestionsTableAdapter = Nothing
        Me.TableAdapterManager.RegionTableAdapter = Nothing
        Me.TableAdapterManager.RelationTableAdapter = Nothing
        Me.TableAdapterManager.RequestTableAdapter = Nothing
        Me.TableAdapterManager.School_or_universityTableAdapter = Me.School_or_universityTableAdapter
        Me.TableAdapterManager.Second_addressTableAdapter = Nothing
        Me.TableAdapterManager.Service_projectTableAdapter = Nothing
        Me.TableAdapterManager.sesionTableAdapter = Nothing
        Me.TableAdapterManager.ShiftTableAdapter = Nothing
        Me.TableAdapterManager.Social_typeTableAdapter = Nothing
        Me.TableAdapterManager.Spend_typeTableAdapter = Nothing
        Me.TableAdapterManager.StreetTableAdapter = Nothing
        Me.TableAdapterManager.SuppliersTableAdapter = Nothing
        Me.TableAdapterManager.TownTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = credit_project.DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.Work_typeTableAdapter = Nothing
        Me.TableAdapterManager.WorkTableAdapter = Nothing
        '
        'Educational_levelTableAdapter
        '
        Me.Educational_levelTableAdapter.ClearBeforeFill = True
        '
        'InsuranceTableAdapter
        '
        Me.InsuranceTableAdapter.ClearBeforeFill = True
        '
        'Last_classTableAdapter
        '
        Me.Last_classTableAdapter.ClearBeforeFill = True
        '
        'Profession_statusTableAdapter
        '
        Me.Profession_statusTableAdapter.ClearBeforeFill = True
        '
        'School_or_universityTableAdapter
        '
        Me.School_or_universityTableAdapter.ClearBeforeFill = True
        '
        'BorrowerBindingNavigator
        '
        Me.BorrowerBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.BorrowerBindingNavigator.BindingSource = Me.BorrowerBindingSource
        Me.BorrowerBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.BorrowerBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.BorrowerBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.BorrowerBindingNavigatorSaveItem})
        Me.BorrowerBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.BorrowerBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BorrowerBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BorrowerBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BorrowerBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BorrowerBindingNavigator.Name = "BorrowerBindingNavigator"
        Me.BorrowerBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.BorrowerBindingNavigator.Size = New System.Drawing.Size(470, 25)
        Me.BorrowerBindingNavigator.TabIndex = 0
        Me.BorrowerBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Enabled = False
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
        Me.BindingNavigatorDeleteItem.Enabled = False
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
        'BorrowerBindingNavigatorSaveItem
        '
        Me.BorrowerBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BorrowerBindingNavigatorSaveItem.Enabled = False
        Me.BorrowerBindingNavigatorSaveItem.Image = CType(resources.GetObject("BorrowerBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.BorrowerBindingNavigatorSaveItem.Name = "BorrowerBindingNavigatorSaveItem"
        Me.BorrowerBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.BorrowerBindingNavigatorSaveItem.Text = "Save Data"
        '
        'P_idTextBox
        '
        Me.P_idTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BorrowerBindingSource, "P_id", True))
        Me.P_idTextBox.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.P_idTextBox.Location = New System.Drawing.Point(116, 65)
        Me.P_idTextBox.Name = "P_idTextBox"
        Me.P_idTextBox.Size = New System.Drawing.Size(100, 21)
        Me.P_idTextBox.TabIndex = 2
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.BorrowerBindingSource, "Pr_st_cod", True))
        Me.ComboBox1.DataSource = Me.ProfessionstatusBindingSource
        Me.ComboBox1.DisplayMember = "Pr_st_des"
        Me.ComboBox1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(241, 135)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 13
        Me.ComboBox1.ValueMember = "Pr_st_cod"
        '
        'ProfessionstatusBindingSource
        '
        Me.ProfessionstatusBindingSource.DataMember = "Profession_status"
        Me.ProfessionstatusBindingSource.DataSource = Me.DatabaseDataSet
        '
        'ComboBox2
        '
        Me.ComboBox2.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.BorrowerBindingSource, "Sch_num", True))
        Me.ComboBox2.DataSource = Me.SchooloruniversityBindingSource
        Me.ComboBox2.DisplayMember = "Sch_name"
        Me.ComboBox2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(241, 162)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox2.TabIndex = 15
        Me.ComboBox2.ValueMember = "Sch_num"
        '
        'SchooloruniversityBindingSource
        '
        Me.SchooloruniversityBindingSource.DataMember = "School_or_university"
        Me.SchooloruniversityBindingSource.DataSource = Me.DatabaseDataSet
        '
        'ComboBox3
        '
        Me.ComboBox3.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.BorrowerBindingSource, "Cl_cod", True))
        Me.ComboBox3.DataSource = Me.LastclassBindingSource
        Me.ComboBox3.DisplayMember = "Cl_name"
        Me.ComboBox3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(241, 189)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox3.TabIndex = 16
        Me.ComboBox3.ValueMember = "Cl_cod"
        '
        'LastclassBindingSource
        '
        Me.LastclassBindingSource.DataMember = "Last_class"
        Me.LastclassBindingSource.DataSource = Me.DatabaseDataSet
        '
        'ComboBox4
        '
        Me.ComboBox4.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.BorrowerBindingSource, "Ed_i_id", True))
        Me.ComboBox4.DataSource = Me.EducationallevelBindingSource
        Me.ComboBox4.DisplayMember = "Ed_I_des"
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Location = New System.Drawing.Point(241, 219)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox4.TabIndex = 17
        Me.ComboBox4.ValueMember = "Ed_I_id"
        '
        'EducationallevelBindingSource
        '
        Me.EducationallevelBindingSource.DataMember = "Educational_level"
        Me.EducationallevelBindingSource.DataSource = Me.DatabaseDataSet
        '
        'ComboBox5
        '
        Me.ComboBox5.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.BorrowerBindingSource, "Insu_num", True))
        Me.ComboBox5.DataSource = Me.InsuranceBindingSource
        Me.ComboBox5.DisplayMember = "Insu_des"
        Me.ComboBox5.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox5.FormattingEnabled = True
        Me.ComboBox5.Location = New System.Drawing.Point(241, 246)
        Me.ComboBox5.Name = "ComboBox5"
        Me.ComboBox5.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox5.TabIndex = 18
        Me.ComboBox5.ValueMember = "Insu_num"
        '
        'InsuranceBindingSource
        '
        Me.InsuranceBindingSource.DataMember = "Insurance"
        Me.InsuranceBindingSource.DataSource = Me.DatabaseDataSet
        '
        'Ed_i_idTextBox
        '
        Me.Ed_i_idTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EducationallevelBindingSource, "Ed_I_id", True))
        Me.Ed_i_idTextBox.Location = New System.Drawing.Point(215, 219)
        Me.Ed_i_idTextBox.Name = "Ed_i_idTextBox"
        Me.Ed_i_idTextBox.Size = New System.Drawing.Size(20, 20)
        Me.Ed_i_idTextBox.TabIndex = 39
        '
        'btn_new
        '
        Me.btn_new.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_new.ForeColor = System.Drawing.Color.Red
        Me.btn_new.Location = New System.Drawing.Point(368, 165)
        Me.btn_new.Name = "btn_new"
        Me.btn_new.Size = New System.Drawing.Size(75, 23)
        Me.btn_new.TabIndex = 22
        Me.btn_new.Text = "New"
        Me.btn_new.UseVisualStyleBackColor = True
        '
        'ComboBox6
        '
        Me.ComboBox6.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.BorrowerBindingSource, "P_id", True))
        Me.ComboBox6.DataSource = Me.PersonBindingSource
        Me.ComboBox6.DisplayMember = "First_name"
        Me.ComboBox6.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox6.FormattingEnabled = True
        Me.ComboBox6.Location = New System.Drawing.Point(180, 107)
        Me.ComboBox6.Name = "ComboBox6"
        Me.ComboBox6.Size = New System.Drawing.Size(78, 21)
        Me.ComboBox6.TabIndex = 24
        Me.ComboBox6.ValueMember = "P_id"
        '
        'PersonBindingSource
        '
        Me.PersonBindingSource.DataMember = "Person"
        Me.PersonBindingSource.DataSource = Me.DatabaseDataSet
        '
        'ComboBox7
        '
        Me.ComboBox7.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.BorrowerBindingSource, "P_id", True))
        Me.ComboBox7.DataSource = Me.PersonBindingSource
        Me.ComboBox7.DisplayMember = "Last_name"
        Me.ComboBox7.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox7.FormattingEnabled = True
        Me.ComboBox7.Location = New System.Drawing.Point(331, 107)
        Me.ComboBox7.Name = "ComboBox7"
        Me.ComboBox7.Size = New System.Drawing.Size(78, 21)
        Me.ComboBox7.TabIndex = 25
        Me.ComboBox7.ValueMember = "P_id"
        '
        'ComboBox8
        '
        Me.ComboBox8.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.BorrowerBindingSource, "P_id", True))
        Me.ComboBox8.DataSource = Me.PersonBindingSource
        Me.ComboBox8.DisplayMember = "Middle_name"
        Me.ComboBox8.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox8.FormattingEnabled = True
        Me.ComboBox8.Location = New System.Drawing.Point(255, 107)
        Me.ComboBox8.Name = "ComboBox8"
        Me.ComboBox8.Size = New System.Drawing.Size(78, 21)
        Me.ComboBox8.TabIndex = 26
        Me.ComboBox8.ValueMember = "P_id"
        '
        'PersonTableAdapter
        '
        Me.PersonTableAdapter.ClearBeforeFill = True
        '
        'btn_save
        '
        Me.btn_save.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save.ForeColor = System.Drawing.Color.Crimson
        Me.btn_save.Location = New System.Drawing.Point(79, 284)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(89, 23)
        Me.btn_save.TabIndex = 29
        Me.btn_save.Text = "Save"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'btn_edit
        '
        Me.btn_edit.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_edit.ForeColor = System.Drawing.Color.Crimson
        Me.btn_edit.Location = New System.Drawing.Point(180, 283)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(89, 23)
        Me.btn_edit.TabIndex = 30
        Me.btn_edit.Text = "Edit"
        Me.btn_edit.UseVisualStyleBackColor = True
        '
        'Pr_st_codTextBox
        '
        Me.Pr_st_codTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProfessionstatusBindingSource, "Pr_st_cod", True))
        Me.Pr_st_codTextBox.Location = New System.Drawing.Point(216, 135)
        Me.Pr_st_codTextBox.Name = "Pr_st_codTextBox"
        Me.Pr_st_codTextBox.Size = New System.Drawing.Size(19, 20)
        Me.Pr_st_codTextBox.TabIndex = 33
        '
        'sch_txt
        '
        Me.sch_txt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SchooloruniversityBindingSource, "Sch_num", True))
        Me.sch_txt.Location = New System.Drawing.Point(216, 163)
        Me.sch_txt.Name = "sch_txt"
        Me.sch_txt.Size = New System.Drawing.Size(19, 20)
        Me.sch_txt.TabIndex = 35
        '
        'Cl_codTextBox
        '
        Me.Cl_codTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LastclassBindingSource, "Cl_cod", True))
        Me.Cl_codTextBox.Location = New System.Drawing.Point(216, 189)
        Me.Cl_codTextBox.Name = "Cl_codTextBox"
        Me.Cl_codTextBox.Size = New System.Drawing.Size(19, 20)
        Me.Cl_codTextBox.TabIndex = 37
        '
        'Insu_numTextBox
        '
        Me.Insu_numTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InsuranceBindingSource, "Insu_num", True))
        Me.Insu_numTextBox.Location = New System.Drawing.Point(216, 246)
        Me.Insu_numTextBox.Name = "Insu_numTextBox"
        Me.Insu_numTextBox.Size = New System.Drawing.Size(19, 20)
        Me.Insu_numTextBox.TabIndex = 41
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Blue
        Me.Button4.Location = New System.Drawing.Point(341, 65)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(79, 23)
        Me.Button4.TabIndex = 42
        Me.Button4.Text = "Search"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Crimson
        Me.Label2.Location = New System.Drawing.Point(291, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(167, 13)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "*Search by Borrower ID:"
        '
        'txt_search
        '
        Me.txt_search.Location = New System.Drawing.Point(331, 43)
        Me.txt_search.Name = "txt_search"
        Me.txt_search.Size = New System.Drawing.Size(100, 20)
        Me.txt_search.TabIndex = 44
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Crimson
        Me.Button1.Location = New System.Drawing.Point(285, 283)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(89, 23)
        Me.Button1.TabIndex = 45
        Me.Button1.Text = "Cancel"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btn_cancel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(470, 318)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txt_search)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Ed_i_idLabel)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.ComboBox4)
        Me.Controls.Add(Me.Ed_i_idTextBox)
        Me.Controls.Add(Me.Pr_st_codTextBox)
        Me.Controls.Add(Me.sch_txt)
        Me.Controls.Add(Me.Cl_codTextBox)
        Me.Controls.Add(Me.Insu_numTextBox)
        Me.Controls.Add(Me.btn_edit)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.ComboBox8)
        Me.Controls.Add(Me.ComboBox7)
        Me.Controls.Add(Me.ComboBox6)
        Me.Controls.Add(Label3)
        Me.Controls.Add(Me.btn_new)
        Me.Controls.Add(Me.ComboBox5)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(P_idLabel)
        Me.Controls.Add(Me.P_idTextBox)
        Me.Controls.Add(Pr_st_codLabel)
        Me.Controls.Add(Sch_numLabel)
        Me.Controls.Add(Cl_codLabel)
        Me.Controls.Add(Insu_numLabel)
        Me.Controls.Add(Me.BorrowerBindingNavigator)
        Me.Name = "btn_cancel"
        Me.Text = "Borrwer"
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BorrowerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BorrowerBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BorrowerBindingNavigator.ResumeLayout(False)
        Me.BorrowerBindingNavigator.PerformLayout()
        CType(Me.ProfessionstatusBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SchooloruniversityBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LastclassBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EducationallevelBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InsuranceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PersonBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DatabaseDataSet As credit_project.DatabaseDataSet
    Friend WithEvents BorrowerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BorrowerTableAdapter As credit_project.DatabaseDataSetTableAdapters.BorrowerTableAdapter
    Friend WithEvents TableAdapterManager As credit_project.DatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents BorrowerBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents BorrowerBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents P_idTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Profession_statusTableAdapter As credit_project.DatabaseDataSetTableAdapters.Profession_statusTableAdapter
    Friend WithEvents ProfessionstatusBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents School_or_universityTableAdapter As credit_project.DatabaseDataSetTableAdapters.School_or_universityTableAdapter
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents SchooloruniversityBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Last_classTableAdapter As credit_project.DatabaseDataSetTableAdapters.Last_classTableAdapter
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents LastclassBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Educational_levelTableAdapter As credit_project.DatabaseDataSetTableAdapters.Educational_levelTableAdapter
    Friend WithEvents ComboBox4 As System.Windows.Forms.ComboBox
    Friend WithEvents EducationallevelBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents InsuranceTableAdapter As credit_project.DatabaseDataSetTableAdapters.InsuranceTableAdapter
    Friend WithEvents ComboBox5 As System.Windows.Forms.ComboBox
    Friend WithEvents InsuranceBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents btn_new As System.Windows.Forms.Button
    Friend WithEvents ComboBox6 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox7 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox8 As System.Windows.Forms.ComboBox
    Friend WithEvents PersonBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PersonTableAdapter As credit_project.DatabaseDataSetTableAdapters.PersonTableAdapter
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents btn_edit As System.Windows.Forms.Button
    Friend WithEvents Pr_st_codTextBox As System.Windows.Forms.TextBox
    Friend WithEvents sch_txt As System.Windows.Forms.TextBox
    Friend WithEvents Cl_codTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Ed_i_idTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Insu_numTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_search As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
