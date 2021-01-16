<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_project
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
        Dim Pro_idLabel As System.Windows.Forms.Label
        Dim Pro_nameLabel As System.Windows.Forms.Label
        Dim Phone_numberLabel As System.Windows.Forms.Label
        Dim Begining_dateLabel As System.Windows.Forms.Label
        Dim Cas_numLabel As System.Windows.Forms.Label
        Dim W_t_codLabel As System.Windows.Forms.Label
        Dim Pr_codLabel As System.Windows.Forms.Label
        Dim Buil_numLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_project))
        Me.DatabaseDataSet = New credit_project.DatabaseDataSet()
        Me.ProjectBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProjectTableAdapter = New credit_project.DatabaseDataSetTableAdapters.ProjectTableAdapter()
        Me.TableAdapterManager = New credit_project.DatabaseDataSetTableAdapters.TableAdapterManager()
        Me.BuildingTableAdapter = New credit_project.DatabaseDataSetTableAdapters.BuildingTableAdapter()
        Me.Case_projectTableAdapter = New credit_project.DatabaseDataSetTableAdapters.Case_projectTableAdapter()
        Me.Project_typeTableAdapter = New credit_project.DatabaseDataSetTableAdapters.Project_typeTableAdapter()
        Me.Work_typeTableAdapter = New credit_project.DatabaseDataSetTableAdapters.Work_typeTableAdapter()
        Me.ProjectBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.ProjectBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Pro_idTextBox = New System.Windows.Forms.TextBox()
        Me.Pro_nameTextBox = New System.Windows.Forms.TextBox()
        Me.Phone_numberTextBox = New System.Windows.Forms.TextBox()
        Me.Begining_dateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.BuildingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ProjecttypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.WorktypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.CaseprojectBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Pro_idLabel = New System.Windows.Forms.Label()
        Pro_nameLabel = New System.Windows.Forms.Label()
        Phone_numberLabel = New System.Windows.Forms.Label()
        Begining_dateLabel = New System.Windows.Forms.Label()
        Cas_numLabel = New System.Windows.Forms.Label()
        W_t_codLabel = New System.Windows.Forms.Label()
        Pr_codLabel = New System.Windows.Forms.Label()
        Buil_numLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProjectBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProjectBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ProjectBindingNavigator.SuspendLayout()
        CType(Me.BuildingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProjecttypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WorktypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CaseprojectBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Pro_idLabel
        '
        Pro_idLabel.AutoSize = True
        Pro_idLabel.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Pro_idLabel.Location = New System.Drawing.Point(20, 76)
        Pro_idLabel.Name = "Pro_idLabel"
        Pro_idLabel.Size = New System.Drawing.Size(77, 13)
        Pro_idLabel.TabIndex = 1
        Pro_idLabel.Text = "Project ID:"
        '
        'Pro_nameLabel
        '
        Pro_nameLabel.AutoSize = True
        Pro_nameLabel.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Pro_nameLabel.Location = New System.Drawing.Point(63, 127)
        Pro_nameLabel.Name = "Pro_nameLabel"
        Pro_nameLabel.Size = New System.Drawing.Size(98, 13)
        Pro_nameLabel.TabIndex = 3
        Pro_nameLabel.Text = "Project name:"
        '
        'Phone_numberLabel
        '
        Phone_numberLabel.AutoSize = True
        Phone_numberLabel.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Phone_numberLabel.Location = New System.Drawing.Point(63, 153)
        Phone_numberLabel.Name = "Phone_numberLabel"
        Phone_numberLabel.Size = New System.Drawing.Size(105, 13)
        Phone_numberLabel.TabIndex = 5
        Phone_numberLabel.Text = "Phone number:"
        '
        'Begining_dateLabel
        '
        Begining_dateLabel.AutoSize = True
        Begining_dateLabel.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Begining_dateLabel.Location = New System.Drawing.Point(211, 79)
        Begining_dateLabel.Name = "Begining_dateLabel"
        Begining_dateLabel.Size = New System.Drawing.Size(41, 13)
        Begining_dateLabel.TabIndex = 7
        Begining_dateLabel.Text = "Date:"
        '
        'Cas_numLabel
        '
        Cas_numLabel.AutoSize = True
        Cas_numLabel.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Cas_numLabel.Location = New System.Drawing.Point(63, 179)
        Cas_numLabel.Name = "Cas_numLabel"
        Cas_numLabel.Size = New System.Drawing.Size(93, 13)
        Cas_numLabel.TabIndex = 9
        Cas_numLabel.Text = "Case Project:"
        '
        'W_t_codLabel
        '
        W_t_codLabel.AutoSize = True
        W_t_codLabel.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        W_t_codLabel.Location = New System.Drawing.Point(63, 205)
        W_t_codLabel.Name = "W_t_codLabel"
        W_t_codLabel.Size = New System.Drawing.Size(81, 13)
        W_t_codLabel.TabIndex = 11
        W_t_codLabel.Text = "Work Type:"
        '
        'Pr_codLabel
        '
        Pr_codLabel.AutoSize = True
        Pr_codLabel.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Pr_codLabel.Location = New System.Drawing.Point(63, 231)
        Pr_codLabel.Name = "Pr_codLabel"
        Pr_codLabel.Size = New System.Drawing.Size(94, 13)
        Pr_codLabel.TabIndex = 13
        Pr_codLabel.Text = "Project Type:"
        '
        'Buil_numLabel
        '
        Buil_numLabel.AutoSize = True
        Buil_numLabel.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Buil_numLabel.Location = New System.Drawing.Point(63, 257)
        Buil_numLabel.Name = "Buil_numLabel"
        Buil_numLabel.Size = New System.Drawing.Size(104, 13)
        Buil_numLabel.TabIndex = 15
        Buil_numLabel.Text = "Building Name:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Perpetua Titling MT", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.Location = New System.Drawing.Point(186, 34)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(109, 26)
        Label1.TabIndex = 17
        Label1.Text = "PROJECT"
        '
        'DatabaseDataSet
        '
        Me.DatabaseDataSet.DataSetName = "DatabaseDataSet"
        Me.DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProjectBindingSource
        '
        Me.ProjectBindingSource.DataMember = "Project"
        Me.ProjectBindingSource.DataSource = Me.DatabaseDataSet
        '
        'ProjectTableAdapter
        '
        Me.ProjectTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AnswerTableAdapter = Nothing
        Me.TableAdapterManager.Assets_typeTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.bnd1TableAdapter = Nothing
        Me.TableAdapterManager.BorrowerTableAdapter = Nothing
        Me.TableAdapterManager.BuildingTableAdapter = Me.BuildingTableAdapter
        Me.TableAdapterManager.Case_projectTableAdapter = Me.Case_projectTableAdapter
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
        Me.TableAdapterManager.InsuranceTableAdapter = Nothing
        Me.TableAdapterManager.Last_classTableAdapter = Nothing
        Me.TableAdapterManager.LinkTableAdapter = Nothing
        Me.TableAdapterManager.Loan_registerTableAdapter = Nothing
        Me.TableAdapterManager.PartnerTableAdapter = Nothing
        Me.TableAdapterManager.Payment_modeTableAdapter = Nothing
        Me.TableAdapterManager.PersonTableAdapter = Nothing
        Me.TableAdapterManager.Profession_statusTableAdapter = Nothing
        Me.TableAdapterManager.ProfessionTableAdapter = Nothing
        Me.TableAdapterManager.Project_spondTableAdapter = Nothing
        Me.TableAdapterManager.Project_typeTableAdapter = Me.Project_typeTableAdapter
        Me.TableAdapterManager.ProjectTableAdapter = Me.ProjectTableAdapter
        Me.TableAdapterManager.ProvinceTableAdapter = Nothing
        Me.TableAdapterManager.QuestionsTableAdapter = Nothing
        Me.TableAdapterManager.RegionTableAdapter = Nothing
        Me.TableAdapterManager.RelationTableAdapter = Nothing
        Me.TableAdapterManager.RequestTableAdapter = Nothing
        Me.TableAdapterManager.School_or_universityTableAdapter = Nothing
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
        Me.TableAdapterManager.Work_typeTableAdapter = Me.Work_typeTableAdapter
        Me.TableAdapterManager.WorkTableAdapter = Nothing
        '
        'BuildingTableAdapter
        '
        Me.BuildingTableAdapter.ClearBeforeFill = True
        '
        'Case_projectTableAdapter
        '
        Me.Case_projectTableAdapter.ClearBeforeFill = True
        '
        'Project_typeTableAdapter
        '
        Me.Project_typeTableAdapter.ClearBeforeFill = True
        '
        'Work_typeTableAdapter
        '
        Me.Work_typeTableAdapter.ClearBeforeFill = True
        '
        'ProjectBindingNavigator
        '
        Me.ProjectBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ProjectBindingNavigator.BindingSource = Me.ProjectBindingSource
        Me.ProjectBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ProjectBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ProjectBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ProjectBindingNavigatorSaveItem})
        Me.ProjectBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ProjectBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ProjectBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ProjectBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ProjectBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ProjectBindingNavigator.Name = "ProjectBindingNavigator"
        Me.ProjectBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ProjectBindingNavigator.Size = New System.Drawing.Size(513, 25)
        Me.ProjectBindingNavigator.TabIndex = 0
        Me.ProjectBindingNavigator.Text = "BindingNavigator1"
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
        'ProjectBindingNavigatorSaveItem
        '
        Me.ProjectBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ProjectBindingNavigatorSaveItem.Image = CType(resources.GetObject("ProjectBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ProjectBindingNavigatorSaveItem.Name = "ProjectBindingNavigatorSaveItem"
        Me.ProjectBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ProjectBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Pro_idTextBox
        '
        Me.Pro_idTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProjectBindingSource, "Pro_id", True))
        Me.Pro_idTextBox.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pro_idTextBox.Location = New System.Drawing.Point(103, 73)
        Me.Pro_idTextBox.Name = "Pro_idTextBox"
        Me.Pro_idTextBox.Size = New System.Drawing.Size(103, 21)
        Me.Pro_idTextBox.TabIndex = 2
        '
        'Pro_nameTextBox
        '
        Me.Pro_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProjectBindingSource, "Pro_name", True))
        Me.Pro_nameTextBox.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pro_nameTextBox.Location = New System.Drawing.Point(174, 124)
        Me.Pro_nameTextBox.Name = "Pro_nameTextBox"
        Me.Pro_nameTextBox.Size = New System.Drawing.Size(200, 21)
        Me.Pro_nameTextBox.TabIndex = 4
        '
        'Phone_numberTextBox
        '
        Me.Phone_numberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProjectBindingSource, "Phone_number", True))
        Me.Phone_numberTextBox.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Phone_numberTextBox.Location = New System.Drawing.Point(174, 150)
        Me.Phone_numberTextBox.Name = "Phone_numberTextBox"
        Me.Phone_numberTextBox.Size = New System.Drawing.Size(200, 21)
        Me.Phone_numberTextBox.TabIndex = 6
        '
        'Begining_dateDateTimePicker
        '
        Me.Begining_dateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ProjectBindingSource, "Begining_date", True))
        Me.Begining_dateDateTimePicker.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Begining_dateDateTimePicker.Location = New System.Drawing.Point(258, 73)
        Me.Begining_dateDateTimePicker.Name = "Begining_dateDateTimePicker"
        Me.Begining_dateDateTimePicker.Size = New System.Drawing.Size(243, 21)
        Me.Begining_dateDateTimePicker.TabIndex = 8
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ProjectBindingSource, "Buil_num", True))
        Me.ComboBox1.DataSource = Me.BuildingBindingSource
        Me.ComboBox1.DisplayMember = "Buil_name"
        Me.ComboBox1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(174, 257)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 18
        Me.ComboBox1.ValueMember = "Buil_num"
        '
        'BuildingBindingSource
        '
        Me.BuildingBindingSource.DataMember = "Building"
        Me.BuildingBindingSource.DataSource = Me.DatabaseDataSet
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Red
        Me.Button1.Location = New System.Drawing.Point(301, 255)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "NEW"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ComboBox2
        '
        Me.ComboBox2.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ProjectBindingSource, "Pr_cod", True))
        Me.ComboBox2.DataSource = Me.ProjecttypeBindingSource
        Me.ComboBox2.DisplayMember = "Prj_name"
        Me.ComboBox2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(174, 228)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox2.TabIndex = 20
        Me.ComboBox2.ValueMember = "Prj_num"
        '
        'ProjecttypeBindingSource
        '
        Me.ProjecttypeBindingSource.DataMember = "Project_type"
        Me.ProjecttypeBindingSource.DataSource = Me.DatabaseDataSet
        '
        'ComboBox3
        '
        Me.ComboBox3.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ProjectBindingSource, "W_t_cod", True))
        Me.ComboBox3.DataSource = Me.WorktypeBindingSource
        Me.ComboBox3.DisplayMember = "W_t_des"
        Me.ComboBox3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(174, 202)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox3.TabIndex = 21
        Me.ComboBox3.ValueMember = "W_t_code"
        '
        'WorktypeBindingSource
        '
        Me.WorktypeBindingSource.DataMember = "Work_type"
        Me.WorktypeBindingSource.DataSource = Me.DatabaseDataSet
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Red
        Me.Button2.Location = New System.Drawing.Point(301, 200)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 22
        Me.Button2.Text = "NEW"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ComboBox4
        '
        Me.ComboBox4.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ProjectBindingSource, "Cas_num", True))
        Me.ComboBox4.DataSource = Me.CaseprojectBindingSource
        Me.ComboBox4.DisplayMember = "Cas_des"
        Me.ComboBox4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Location = New System.Drawing.Point(174, 175)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox4.TabIndex = 23
        Me.ComboBox4.ValueMember = "Cas_num"
        '
        'CaseprojectBindingSource
        '
        Me.CaseprojectBindingSource.DataMember = "Case_project"
        Me.CaseprojectBindingSource.DataSource = Me.DatabaseDataSet
        '
        'frm_project
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(513, 291)
        Me.Controls.Add(Me.ComboBox4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Pro_idLabel)
        Me.Controls.Add(Me.Pro_idTextBox)
        Me.Controls.Add(Pro_nameLabel)
        Me.Controls.Add(Me.Pro_nameTextBox)
        Me.Controls.Add(Phone_numberLabel)
        Me.Controls.Add(Me.Phone_numberTextBox)
        Me.Controls.Add(Begining_dateLabel)
        Me.Controls.Add(Me.Begining_dateDateTimePicker)
        Me.Controls.Add(Cas_numLabel)
        Me.Controls.Add(W_t_codLabel)
        Me.Controls.Add(Pr_codLabel)
        Me.Controls.Add(Buil_numLabel)
        Me.Controls.Add(Me.ProjectBindingNavigator)
        Me.Name = "frm_project"
        Me.Text = "Project"
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProjectBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProjectBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ProjectBindingNavigator.ResumeLayout(False)
        Me.ProjectBindingNavigator.PerformLayout()
        CType(Me.BuildingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProjecttypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WorktypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CaseprojectBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DatabaseDataSet As credit_project.DatabaseDataSet
    Friend WithEvents ProjectBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProjectTableAdapter As credit_project.DatabaseDataSetTableAdapters.ProjectTableAdapter
    Friend WithEvents TableAdapterManager As credit_project.DatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ProjectBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents ProjectBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Pro_idTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Pro_nameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Phone_numberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Begining_dateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents BuildingTableAdapter As credit_project.DatabaseDataSetTableAdapters.BuildingTableAdapter
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents BuildingBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Project_typeTableAdapter As credit_project.DatabaseDataSetTableAdapters.Project_typeTableAdapter
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents ProjecttypeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Work_typeTableAdapter As credit_project.DatabaseDataSetTableAdapters.Work_typeTableAdapter
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents WorktypeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Case_projectTableAdapter As credit_project.DatabaseDataSetTableAdapters.Case_projectTableAdapter
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents ComboBox4 As System.Windows.Forms.ComboBox
    Friend WithEvents CaseprojectBindingSource As System.Windows.Forms.BindingSource
End Class
