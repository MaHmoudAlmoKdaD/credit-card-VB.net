<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim Cre_codLabel As System.Windows.Forms.Label
        Dim Cre_dateLabel As System.Windows.Forms.Label
        Dim Cre_end_dateLabel As System.Windows.Forms.Label
        Dim Req_numLabel As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.DatabaseDataSet = New credit_project.DatabaseDataSet()
        Me.CreditBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CreditTableAdapter = New credit_project.DatabaseDataSetTableAdapters.CreditTableAdapter()
        Me.TableAdapterManager = New credit_project.DatabaseDataSetTableAdapters.TableAdapterManager()
        Me.Bnd1TableAdapter = New credit_project.DatabaseDataSetTableAdapters.bnd1TableAdapter()
        Me.Payment_modeTableAdapter = New credit_project.DatabaseDataSetTableAdapters.Payment_modeTableAdapter()
        Me.RequestTableAdapter = New credit_project.DatabaseDataSetTableAdapters.RequestTableAdapter()
        Me.CreditBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.CreditBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Cre_codTextBox = New System.Windows.Forms.TextBox()
        Me.Cre_dateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Cre_end_dateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Req_numTextBox = New System.Windows.Forms.TextBox()
        Me.Bnd1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Bnd1DataGridView = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txt_result = New System.Windows.Forms.TextBox()
        Me.RequestBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Payment_modeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cbo_value = New System.Windows.Forms.ComboBox()
        Me.PaymentmodeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Cre_codLabel = New System.Windows.Forms.Label()
        Cre_dateLabel = New System.Windows.Forms.Label()
        Cre_end_dateLabel = New System.Windows.Forms.Label()
        Req_numLabel = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CreditBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CreditBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CreditBindingNavigator.SuspendLayout()
        CType(Me.Bnd1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bnd1DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RequestBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Payment_modeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PaymentmodeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Cre_codLabel
        '
        Cre_codLabel.AutoSize = True
        Cre_codLabel.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Cre_codLabel.Location = New System.Drawing.Point(45, 61)
        Cre_codLabel.Name = "Cre_codLabel"
        Cre_codLabel.Size = New System.Drawing.Size(85, 13)
        Cre_codLabel.TabIndex = 1
        Cre_codLabel.Text = "Credit code:"
        '
        'Cre_dateLabel
        '
        Cre_dateLabel.AutoSize = True
        Cre_dateLabel.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Cre_dateLabel.Location = New System.Drawing.Point(329, 70)
        Cre_dateLabel.Name = "Cre_dateLabel"
        Cre_dateLabel.Size = New System.Drawing.Size(83, 13)
        Cre_dateLabel.TabIndex = 3
        Cre_dateLabel.Text = "Credit date:"
        '
        'Cre_end_dateLabel
        '
        Cre_end_dateLabel.AutoSize = True
        Cre_end_dateLabel.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Cre_end_dateLabel.Location = New System.Drawing.Point(329, 96)
        Cre_end_dateLabel.Name = "Cre_end_dateLabel"
        Cre_end_dateLabel.Size = New System.Drawing.Size(111, 13)
        Cre_end_dateLabel.TabIndex = 5
        Cre_end_dateLabel.Text = "Credit end date:"
        '
        'Req_numLabel
        '
        Req_numLabel.AutoSize = True
        Req_numLabel.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Req_numLabel.Location = New System.Drawing.Point(45, 92)
        Req_numLabel.Name = "Req_numLabel"
        Req_numLabel.Size = New System.Drawing.Size(117, 13)
        Req_numLabel.TabIndex = 7
        Req_numLabel.Text = "Request number:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label2.Location = New System.Drawing.Point(41, 122)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(90, 13)
        Label2.TabIndex = 17
        Label2.Text = "Credit Value:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.Location = New System.Drawing.Point(535, 429)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(52, 13)
        Label1.TabIndex = 18
        Label1.Text = "TOTAL:"
        '
        'DatabaseDataSet
        '
        Me.DatabaseDataSet.DataSetName = "DatabaseDataSet"
        Me.DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CreditBindingSource
        '
        Me.CreditBindingSource.DataMember = "Credit"
        Me.CreditBindingSource.DataSource = Me.DatabaseDataSet
        '
        'CreditTableAdapter
        '
        Me.CreditTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AnswerTableAdapter = Nothing
        Me.TableAdapterManager.Assets_typeTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.bnd1TableAdapter = Me.Bnd1TableAdapter
        Me.TableAdapterManager.BorrowerTableAdapter = Nothing
        Me.TableAdapterManager.BuildingTableAdapter = Nothing
        Me.TableAdapterManager.Case_projectTableAdapter = Nothing
        Me.TableAdapterManager.CategoryTableAdapter = Nothing
        Me.TableAdapterManager.CompanyTableAdapter = Nothing
        Me.TableAdapterManager.Concern_projectTableAdapter = Nothing
        Me.TableAdapterManager.Credit_typeTableAdapter = Nothing
        Me.TableAdapterManager.CreditTableAdapter = Me.CreditTableAdapter
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
        Me.TableAdapterManager.Payment_modeTableAdapter = Me.Payment_modeTableAdapter
        Me.TableAdapterManager.PersonTableAdapter = Nothing
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
        Me.TableAdapterManager.Spend_typeTableAdapter = Nothing
        Me.TableAdapterManager.StreetTableAdapter = Nothing
        Me.TableAdapterManager.SuppliersTableAdapter = Nothing
        Me.TableAdapterManager.TownTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = credit_project.DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.Work_typeTableAdapter = Nothing
        Me.TableAdapterManager.WorkTableAdapter = Nothing
        '
        'Bnd1TableAdapter
        '
        Me.Bnd1TableAdapter.ClearBeforeFill = True
        '
        'Payment_modeTableAdapter
        '
        Me.Payment_modeTableAdapter.ClearBeforeFill = True
        '
        'RequestTableAdapter
        '
        Me.RequestTableAdapter.ClearBeforeFill = True
        '
        'CreditBindingNavigator
        '
        Me.CreditBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CreditBindingNavigator.BindingSource = Me.CreditBindingSource
        Me.CreditBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CreditBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CreditBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CreditBindingNavigatorSaveItem})
        Me.CreditBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CreditBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CreditBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CreditBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CreditBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CreditBindingNavigator.Name = "CreditBindingNavigator"
        Me.CreditBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CreditBindingNavigator.Size = New System.Drawing.Size(756, 25)
        Me.CreditBindingNavigator.TabIndex = 0
        Me.CreditBindingNavigator.Text = "BindingNavigator1"
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
        'CreditBindingNavigatorSaveItem
        '
        Me.CreditBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CreditBindingNavigatorSaveItem.Image = CType(resources.GetObject("CreditBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CreditBindingNavigatorSaveItem.Name = "CreditBindingNavigatorSaveItem"
        Me.CreditBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.CreditBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Cre_codTextBox
        '
        Me.Cre_codTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CreditBindingSource, "Cre_cod", True))
        Me.Cre_codTextBox.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cre_codTextBox.Location = New System.Drawing.Point(168, 53)
        Me.Cre_codTextBox.Name = "Cre_codTextBox"
        Me.Cre_codTextBox.Size = New System.Drawing.Size(62, 21)
        Me.Cre_codTextBox.TabIndex = 2
        '
        'Cre_dateDateTimePicker
        '
        Me.Cre_dateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CreditBindingSource, "Cre_date", True))
        Me.Cre_dateDateTimePicker.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cre_dateDateTimePicker.Location = New System.Drawing.Point(446, 64)
        Me.Cre_dateDateTimePicker.Name = "Cre_dateDateTimePicker"
        Me.Cre_dateDateTimePicker.Size = New System.Drawing.Size(247, 21)
        Me.Cre_dateDateTimePicker.TabIndex = 4
        '
        'Cre_end_dateDateTimePicker
        '
        Me.Cre_end_dateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CreditBindingSource, "Cre_end_date", True))
        Me.Cre_end_dateDateTimePicker.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cre_end_dateDateTimePicker.Location = New System.Drawing.Point(446, 90)
        Me.Cre_end_dateDateTimePicker.Name = "Cre_end_dateDateTimePicker"
        Me.Cre_end_dateDateTimePicker.Size = New System.Drawing.Size(247, 21)
        Me.Cre_end_dateDateTimePicker.TabIndex = 6
        '
        'Req_numTextBox
        '
        Me.Req_numTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CreditBindingSource, "Req_num", True))
        Me.Req_numTextBox.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Req_numTextBox.Location = New System.Drawing.Point(168, 88)
        Me.Req_numTextBox.Name = "Req_numTextBox"
        Me.Req_numTextBox.Size = New System.Drawing.Size(62, 21)
        Me.Req_numTextBox.TabIndex = 8
        '
        'Bnd1BindingSource
        '
        Me.Bnd1BindingSource.DataMember = "Credit_bnd1"
        Me.Bnd1BindingSource.DataSource = Me.CreditBindingSource
        '
        'Bnd1DataGridView
        '
        Me.Bnd1DataGridView.AutoGenerateColumns = False
        Me.Bnd1DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Bnd1DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.Bnd1DataGridView.DataSource = Me.Bnd1BindingSource
        Me.Bnd1DataGridView.Location = New System.Drawing.Point(26, 193)
        Me.Bnd1DataGridView.Name = "Bnd1DataGridView"
        Me.Bnd1DataGridView.Size = New System.Drawing.Size(685, 220)
        Me.Bnd1DataGridView.TabIndex = 9
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ControlText
        Me.Button1.Font = New System.Drawing.Font("Verdana", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Green
        Me.Button1.Location = New System.Drawing.Point(26, 157)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(685, 31)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "ADD BOND"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txt_result
        '
        Me.txt_result.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_result.Location = New System.Drawing.Point(605, 426)
        Me.txt_result.Name = "txt_result"
        Me.txt_result.Size = New System.Drawing.Size(100, 21)
        Me.txt_result.TabIndex = 15
        '
        'RequestBindingSource
        '
        Me.RequestBindingSource.DataMember = "Request"
        Me.RequestBindingSource.DataSource = Me.DatabaseDataSet
        '
        'Payment_modeBindingSource
        '
        Me.Payment_modeBindingSource.DataMember = "Payment_mode"
        Me.Payment_modeBindingSource.DataSource = Me.DatabaseDataSet
        '
        'cbo_value
        '
        Me.cbo_value.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CreditBindingSource, "Req_num", True))
        Me.cbo_value.DataSource = Me.RequestBindingSource
        Me.cbo_value.DisplayMember = "Req_value"
        Me.cbo_value.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_value.FormattingEnabled = True
        Me.cbo_value.Location = New System.Drawing.Point(168, 118)
        Me.cbo_value.Name = "cbo_value"
        Me.cbo_value.Size = New System.Drawing.Size(62, 21)
        Me.cbo_value.TabIndex = 16
        Me.cbo_value.ValueMember = "Req_num"
        '
        'PaymentmodeBindingSource
        '
        Me.PaymentmodeBindingSource.DataMember = "Payment_mode"
        Me.PaymentmodeBindingSource.DataSource = Me.DatabaseDataSet
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Bond_num"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Bond_num"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Cre_cod"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Cre_cod"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Bond_value"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Bond_value"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Bond_date"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Bond_date"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Bond_due_date"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Bond_due_date"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Pay_id"
        Me.DataGridViewTextBoxColumn6.DataSource = Me.PaymentmodeBindingSource
        Me.DataGridViewTextBoxColumn6.DisplayMember = "Pay_des"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Pay_id"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn6.ValueMember = "Pay_id"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(756, 459)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Me.cbo_value)
        Me.Controls.Add(Me.txt_result)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Bnd1DataGridView)
        Me.Controls.Add(Cre_codLabel)
        Me.Controls.Add(Me.Cre_codTextBox)
        Me.Controls.Add(Cre_dateLabel)
        Me.Controls.Add(Me.Cre_dateDateTimePicker)
        Me.Controls.Add(Cre_end_dateLabel)
        Me.Controls.Add(Me.Cre_end_dateDateTimePicker)
        Me.Controls.Add(Req_numLabel)
        Me.Controls.Add(Me.Req_numTextBox)
        Me.Controls.Add(Me.CreditBindingNavigator)
        Me.Name = "Form2"
        Me.Text = "BOND"
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CreditBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CreditBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CreditBindingNavigator.ResumeLayout(False)
        Me.CreditBindingNavigator.PerformLayout()
        CType(Me.Bnd1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bnd1DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RequestBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Payment_modeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PaymentmodeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DatabaseDataSet As credit_project.DatabaseDataSet
    Friend WithEvents CreditBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CreditTableAdapter As credit_project.DatabaseDataSetTableAdapters.CreditTableAdapter
    Friend WithEvents TableAdapterManager As credit_project.DatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CreditBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents CreditBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Cre_codTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Cre_dateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Cre_end_dateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Req_numTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Bnd1TableAdapter As credit_project.DatabaseDataSetTableAdapters.bnd1TableAdapter
    Friend WithEvents Bnd1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Bnd1DataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txt_result As System.Windows.Forms.TextBox
    Friend WithEvents RequestTableAdapter As credit_project.DatabaseDataSetTableAdapters.RequestTableAdapter
    Friend WithEvents RequestBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Payment_modeTableAdapter As credit_project.DatabaseDataSetTableAdapters.Payment_modeTableAdapter
    Friend WithEvents Payment_modeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents cbo_value As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents PaymentmodeBindingSource As System.Windows.Forms.BindingSource
End Class
