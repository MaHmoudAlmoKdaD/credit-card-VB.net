<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_work
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
        Dim Work_numLabel As System.Windows.Forms.Label
        Dim Work_beg_dateLabel As System.Windows.Forms.Label
        Dim Last_salaryLabel As System.Windows.Forms.Label
        Dim Reason_leave_workLabel As System.Windows.Forms.Label
        Dim Work_end_dateLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_work))
        Me.DatabaseDataSet = New credit_project.DatabaseDataSet()
        Me.WorkBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WorkTableAdapter = New credit_project.DatabaseDataSetTableAdapters.WorkTableAdapter()
        Me.TableAdapterManager = New credit_project.DatabaseDataSetTableAdapters.TableAdapterManager()
        Me.CompanyTableAdapter = New credit_project.DatabaseDataSetTableAdapters.CompanyTableAdapter()
        Me.PersonTableAdapter = New credit_project.DatabaseDataSetTableAdapters.PersonTableAdapter()
        Me.ProfessionTableAdapter = New credit_project.DatabaseDataSetTableAdapters.ProfessionTableAdapter()
        Me.WorkBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.WorkBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Work_numTextBox = New System.Windows.Forms.TextBox()
        Me.Work_beg_dateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Last_salaryDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Reason_leave_workTextBox = New System.Windows.Forms.TextBox()
        Me.Work_end_dateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.PersonBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.CompanyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBox5 = New System.Windows.Forms.ComboBox()
        Me.ProfessionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Work_numLabel = New System.Windows.Forms.Label()
        Work_beg_dateLabel = New System.Windows.Forms.Label()
        Last_salaryLabel = New System.Windows.Forms.Label()
        Reason_leave_workLabel = New System.Windows.Forms.Label()
        Work_end_dateLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WorkBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WorkBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.WorkBindingNavigator.SuspendLayout()
        CType(Me.PersonBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.CompanyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProfessionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Work_numLabel
        '
        Work_numLabel.AutoSize = True
        Work_numLabel.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Work_numLabel.Location = New System.Drawing.Point(93, 72)
        Work_numLabel.Name = "Work_numLabel"
        Work_numLabel.Size = New System.Drawing.Size(77, 13)
        Work_numLabel.TabIndex = 1
        Work_numLabel.Text = "Work num:"
        '
        'Work_beg_dateLabel
        '
        Work_beg_dateLabel.AutoSize = True
        Work_beg_dateLabel.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Work_beg_dateLabel.Location = New System.Drawing.Point(16, 112)
        Work_beg_dateLabel.Name = "Work_beg_dateLabel"
        Work_beg_dateLabel.Size = New System.Drawing.Size(106, 13)
        Work_beg_dateLabel.TabIndex = 3
        Work_beg_dateLabel.Text = "Work beg date:"
        '
        'Last_salaryLabel
        '
        Last_salaryLabel.AutoSize = True
        Last_salaryLabel.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Last_salaryLabel.Location = New System.Drawing.Point(16, 167)
        Last_salaryLabel.Name = "Last_salaryLabel"
        Last_salaryLabel.Size = New System.Drawing.Size(83, 13)
        Last_salaryLabel.TabIndex = 5
        Last_salaryLabel.Text = "Last salary:"
        '
        'Reason_leave_workLabel
        '
        Reason_leave_workLabel.AutoSize = True
        Reason_leave_workLabel.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Reason_leave_workLabel.Location = New System.Drawing.Point(16, 192)
        Reason_leave_workLabel.Name = "Reason_leave_workLabel"
        Reason_leave_workLabel.Size = New System.Drawing.Size(134, 13)
        Reason_leave_workLabel.TabIndex = 7
        Reason_leave_workLabel.Text = "Reason leave work:"
        '
        'Work_end_dateLabel
        '
        Work_end_dateLabel.AutoSize = True
        Work_end_dateLabel.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Work_end_dateLabel.Location = New System.Drawing.Point(16, 141)
        Work_end_dateLabel.Name = "Work_end_dateLabel"
        Work_end_dateLabel.Size = New System.Drawing.Size(106, 13)
        Work_end_dateLabel.TabIndex = 9
        Work_end_dateLabel.Text = "Work end date:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Perpetua Titling MT", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.Location = New System.Drawing.Point(252, 42)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(86, 26)
        Label1.TabIndex = 17
        Label1.Text = "WORK"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label2.Location = New System.Drawing.Point(322, 75)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(0, 13)
        Label2.TabIndex = 21
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(6, 17)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(41, 13)
        Label3.TabIndex = 23
        Label3.Text = "First:"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label4.Location = New System.Drawing.Point(82, 17)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(49, 13)
        Label4.TabIndex = 24
        Label4.Text = "Midlle:"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label5.Location = New System.Drawing.Point(166, 17)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(38, 13)
        Label5.TabIndex = 25
        Label5.Text = "Last:"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label6.Location = New System.Drawing.Point(10, 217)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(112, 13)
        Label6.TabIndex = 24
        Label6.Text = "Company Name:"
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label7.Location = New System.Drawing.Point(16, 244)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(80, 13)
        Label7.TabIndex = 26
        Label7.Text = "Profession:"
        '
        'DatabaseDataSet
        '
        Me.DatabaseDataSet.DataSetName = "DatabaseDataSet"
        Me.DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'WorkBindingSource
        '
        Me.WorkBindingSource.DataMember = "Work"
        Me.WorkBindingSource.DataSource = Me.DatabaseDataSet
        '
        'WorkTableAdapter
        '
        Me.WorkTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.CompanyTableAdapter = Me.CompanyTableAdapter
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
        Me.TableAdapterManager.PersonTableAdapter = Me.PersonTableAdapter
        Me.TableAdapterManager.Profession_statusTableAdapter = Nothing
        Me.TableAdapterManager.ProfessionTableAdapter = Me.ProfessionTableAdapter
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
        Me.TableAdapterManager.ShiftTableAdapter = Nothing
        Me.TableAdapterManager.Social_typeTableAdapter = Nothing
        Me.TableAdapterManager.Spend_typeTableAdapter = Nothing
        Me.TableAdapterManager.StreetTableAdapter = Nothing
        Me.TableAdapterManager.SuppliersTableAdapter = Nothing
        Me.TableAdapterManager.TownTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = credit_project.DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.Work_typeTableAdapter = Nothing
        Me.TableAdapterManager.WorkTableAdapter = Me.WorkTableAdapter
        '
        'CompanyTableAdapter
        '
        Me.CompanyTableAdapter.ClearBeforeFill = True
        '
        'PersonTableAdapter
        '
        Me.PersonTableAdapter.ClearBeforeFill = True
        '
        'ProfessionTableAdapter
        '
        Me.ProfessionTableAdapter.ClearBeforeFill = True
        '
        'WorkBindingNavigator
        '
        Me.WorkBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.WorkBindingNavigator.BindingSource = Me.WorkBindingSource
        Me.WorkBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.WorkBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.WorkBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.WorkBindingNavigatorSaveItem})
        Me.WorkBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.WorkBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.WorkBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.WorkBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.WorkBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.WorkBindingNavigator.Name = "WorkBindingNavigator"
        Me.WorkBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.WorkBindingNavigator.Size = New System.Drawing.Size(692, 25)
        Me.WorkBindingNavigator.TabIndex = 0
        Me.WorkBindingNavigator.Text = "BindingNavigator1"
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
        'WorkBindingNavigatorSaveItem
        '
        Me.WorkBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.WorkBindingNavigatorSaveItem.Image = CType(resources.GetObject("WorkBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.WorkBindingNavigatorSaveItem.Name = "WorkBindingNavigatorSaveItem"
        Me.WorkBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.WorkBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Work_numTextBox
        '
        Me.Work_numTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WorkBindingSource, "Work_num", True))
        Me.Work_numTextBox.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Work_numTextBox.Location = New System.Drawing.Point(176, 69)
        Me.Work_numTextBox.Name = "Work_numTextBox"
        Me.Work_numTextBox.Size = New System.Drawing.Size(86, 21)
        Me.Work_numTextBox.TabIndex = 2
        '
        'Work_beg_dateDateTimePicker
        '
        Me.Work_beg_dateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.WorkBindingSource, "Work_beg_date", True))
        Me.Work_beg_dateDateTimePicker.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Work_beg_dateDateTimePicker.Location = New System.Drawing.Point(157, 106)
        Me.Work_beg_dateDateTimePicker.Name = "Work_beg_dateDateTimePicker"
        Me.Work_beg_dateDateTimePicker.Size = New System.Drawing.Size(236, 21)
        Me.Work_beg_dateDateTimePicker.TabIndex = 4
        '
        'Last_salaryDateTimePicker
        '
        Me.Last_salaryDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.WorkBindingSource, "Last_salary", True))
        Me.Last_salaryDateTimePicker.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Last_salaryDateTimePicker.Location = New System.Drawing.Point(157, 161)
        Me.Last_salaryDateTimePicker.Name = "Last_salaryDateTimePicker"
        Me.Last_salaryDateTimePicker.Size = New System.Drawing.Size(236, 21)
        Me.Last_salaryDateTimePicker.TabIndex = 6
        '
        'Reason_leave_workTextBox
        '
        Me.Reason_leave_workTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WorkBindingSource, "Reason_leave_work", True))
        Me.Reason_leave_workTextBox.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Reason_leave_workTextBox.Location = New System.Drawing.Point(157, 187)
        Me.Reason_leave_workTextBox.Name = "Reason_leave_workTextBox"
        Me.Reason_leave_workTextBox.Size = New System.Drawing.Size(236, 21)
        Me.Reason_leave_workTextBox.TabIndex = 8
        '
        'Work_end_dateDateTimePicker
        '
        Me.Work_end_dateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.WorkBindingSource, "Work_end_date", True))
        Me.Work_end_dateDateTimePicker.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Work_end_dateDateTimePicker.Location = New System.Drawing.Point(157, 135)
        Me.Work_end_dateDateTimePicker.Name = "Work_end_dateDateTimePicker"
        Me.Work_end_dateDateTimePicker.Size = New System.Drawing.Size(236, 21)
        Me.Work_end_dateDateTimePicker.TabIndex = 10
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.WorkBindingSource, "P_id", True))
        Me.ComboBox1.DataSource = Me.PersonBindingSource
        Me.ComboBox1.DisplayMember = "Last_name"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(169, 37)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(87, 21)
        Me.ComboBox1.TabIndex = 18
        Me.ComboBox1.ValueMember = "P_id"
        '
        'PersonBindingSource
        '
        Me.PersonBindingSource.DataMember = "Person"
        Me.PersonBindingSource.DataSource = Me.DatabaseDataSet
        '
        'ComboBox2
        '
        Me.ComboBox2.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.WorkBindingSource, "P_id", True))
        Me.ComboBox2.DataSource = Me.PersonBindingSource
        Me.ComboBox2.DisplayMember = "First_name"
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(2, 37)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(87, 21)
        Me.ComboBox2.TabIndex = 19
        Me.ComboBox2.ValueMember = "P_id"
        '
        'ComboBox3
        '
        Me.ComboBox3.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.WorkBindingSource, "P_id", True))
        Me.ComboBox3.DataSource = Me.PersonBindingSource
        Me.ComboBox3.DisplayMember = "Middle_name"
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(85, 37)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(87, 21)
        Me.ComboBox3.TabIndex = 20
        Me.ComboBox3.ValueMember = "P_id"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Label5)
        Me.GroupBox1.Controls.Add(Label4)
        Me.GroupBox1.Controls.Add(Label3)
        Me.GroupBox1.Controls.Add(Me.ComboBox3)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.ComboBox2)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(417, 106)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(263, 66)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "NAME"
        '
        'ComboBox4
        '
        Me.ComboBox4.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.WorkBindingSource, "Com_num", True))
        Me.ComboBox4.DataSource = Me.CompanyBindingSource
        Me.ComboBox4.DisplayMember = "Com_name"
        Me.ComboBox4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Location = New System.Drawing.Point(157, 214)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox4.TabIndex = 23
        Me.ComboBox4.ValueMember = "Com_num"
        '
        'CompanyBindingSource
        '
        Me.CompanyBindingSource.DataMember = "Company"
        Me.CompanyBindingSource.DataSource = Me.DatabaseDataSet
        '
        'ComboBox5
        '
        Me.ComboBox5.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.WorkBindingSource, "Pr_cod", True))
        Me.ComboBox5.DataSource = Me.ProfessionBindingSource
        Me.ComboBox5.DisplayMember = "Pr_des"
        Me.ComboBox5.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox5.FormattingEnabled = True
        Me.ComboBox5.Location = New System.Drawing.Point(157, 241)
        Me.ComboBox5.Name = "ComboBox5"
        Me.ComboBox5.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox5.TabIndex = 25
        Me.ComboBox5.ValueMember = "Pr_cod"
        '
        'ProfessionBindingSource
        '
        Me.ProfessionBindingSource.DataMember = "Profession"
        Me.ProfessionBindingSource.DataSource = Me.DatabaseDataSet
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Red
        Me.Button1.Location = New System.Drawing.Point(294, 215)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 27
        Me.Button1.Text = "NEW"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Red
        Me.Button2.Location = New System.Drawing.Point(294, 244)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 28
        Me.Button2.Text = "NEW"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'frm_work
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(692, 277)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Label7)
        Me.Controls.Add(Me.ComboBox5)
        Me.Controls.Add(Label6)
        Me.Controls.Add(Me.ComboBox4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Work_numLabel)
        Me.Controls.Add(Me.Work_numTextBox)
        Me.Controls.Add(Work_beg_dateLabel)
        Me.Controls.Add(Me.Work_beg_dateDateTimePicker)
        Me.Controls.Add(Last_salaryLabel)
        Me.Controls.Add(Me.Last_salaryDateTimePicker)
        Me.Controls.Add(Reason_leave_workLabel)
        Me.Controls.Add(Me.Reason_leave_workTextBox)
        Me.Controls.Add(Work_end_dateLabel)
        Me.Controls.Add(Me.Work_end_dateDateTimePicker)
        Me.Controls.Add(Me.WorkBindingNavigator)
        Me.Name = "frm_work"
        Me.Text = "Work"
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WorkBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WorkBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.WorkBindingNavigator.ResumeLayout(False)
        Me.WorkBindingNavigator.PerformLayout()
        CType(Me.PersonBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.CompanyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProfessionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DatabaseDataSet As credit_project.DatabaseDataSet
    Friend WithEvents WorkBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents WorkTableAdapter As credit_project.DatabaseDataSetTableAdapters.WorkTableAdapter
    Friend WithEvents TableAdapterManager As credit_project.DatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents WorkBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents WorkBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Work_numTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Work_beg_dateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Last_salaryDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Reason_leave_workTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Work_end_dateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents PersonTableAdapter As credit_project.DatabaseDataSetTableAdapters.PersonTableAdapter
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PersonBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CompanyTableAdapter As credit_project.DatabaseDataSetTableAdapters.CompanyTableAdapter
    Friend WithEvents ComboBox4 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox5 As System.Windows.Forms.ComboBox
    Friend WithEvents CompanyBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProfessionTableAdapter As credit_project.DatabaseDataSetTableAdapters.ProfessionTableAdapter
    Friend WithEvents ProfessionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
