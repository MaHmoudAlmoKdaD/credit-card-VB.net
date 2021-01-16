<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_credit2
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
        Dim Label1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_credit2))
        Me.DatabaseDataSet = New credit_project.DatabaseDataSet()
        Me.CreditBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CreditTableAdapter = New credit_project.DatabaseDataSetTableAdapters.CreditTableAdapter()
        Me.TableAdapterManager = New credit_project.DatabaseDataSetTableAdapters.TableAdapterManager()
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
        Cre_codLabel = New System.Windows.Forms.Label()
        Cre_dateLabel = New System.Windows.Forms.Label()
        Cre_end_dateLabel = New System.Windows.Forms.Label()
        Req_numLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CreditBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CreditBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CreditBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'Cre_codLabel
        '
        Cre_codLabel.AutoSize = True
        Cre_codLabel.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Cre_codLabel.Location = New System.Drawing.Point(38, 83)
        Cre_codLabel.Name = "Cre_codLabel"
        Cre_codLabel.Size = New System.Drawing.Size(60, 13)
        Cre_codLabel.TabIndex = 1
        Cre_codLabel.Text = "Cre cod:"
        '
        'Cre_dateLabel
        '
        Cre_dateLabel.AutoSize = True
        Cre_dateLabel.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Cre_dateLabel.Location = New System.Drawing.Point(38, 140)
        Cre_dateLabel.Name = "Cre_dateLabel"
        Cre_dateLabel.Size = New System.Drawing.Size(66, 13)
        Cre_dateLabel.TabIndex = 3
        Cre_dateLabel.Text = "Cre date:"
        '
        'Cre_end_dateLabel
        '
        Cre_end_dateLabel.AutoSize = True
        Cre_end_dateLabel.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Cre_end_dateLabel.Location = New System.Drawing.Point(38, 166)
        Cre_end_dateLabel.Name = "Cre_end_dateLabel"
        Cre_end_dateLabel.Size = New System.Drawing.Size(94, 13)
        Cre_end_dateLabel.TabIndex = 5
        Cre_end_dateLabel.Text = "Cre end date:"
        '
        'Req_numLabel
        '
        Req_numLabel.AutoSize = True
        Req_numLabel.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Req_numLabel.Location = New System.Drawing.Point(38, 110)
        Req_numLabel.Name = "Req_numLabel"
        Req_numLabel.Size = New System.Drawing.Size(67, 13)
        Req_numLabel.TabIndex = 7
        Req_numLabel.Text = "Req num:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Perpetua Titling MT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.Location = New System.Drawing.Point(132, 42)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(86, 23)
        Label1.TabIndex = 9
        Label1.Text = "CREDIT"
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
        Me.TableAdapterManager.bnd1TableAdapter = Nothing
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
        Me.TableAdapterManager.Payment_modeTableAdapter = Nothing
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
        Me.TableAdapterManager.RequestTableAdapter = Nothing
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
        Me.CreditBindingNavigator.Size = New System.Drawing.Size(390, 25)
        Me.CreditBindingNavigator.TabIndex = 0
        Me.CreditBindingNavigator.Text = "BindingNavigator1"
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
        Me.Cre_codTextBox.Location = New System.Drawing.Point(155, 80)
        Me.Cre_codTextBox.Name = "Cre_codTextBox"
        Me.Cre_codTextBox.Size = New System.Drawing.Size(200, 21)
        Me.Cre_codTextBox.TabIndex = 2
        '
        'Cre_dateDateTimePicker
        '
        Me.Cre_dateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CreditBindingSource, "Cre_date", True))
        Me.Cre_dateDateTimePicker.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cre_dateDateTimePicker.Location = New System.Drawing.Point(155, 136)
        Me.Cre_dateDateTimePicker.Name = "Cre_dateDateTimePicker"
        Me.Cre_dateDateTimePicker.Size = New System.Drawing.Size(235, 21)
        Me.Cre_dateDateTimePicker.TabIndex = 4
        '
        'Cre_end_dateDateTimePicker
        '
        Me.Cre_end_dateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CreditBindingSource, "Cre_end_date", True))
        Me.Cre_end_dateDateTimePicker.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cre_end_dateDateTimePicker.Location = New System.Drawing.Point(155, 162)
        Me.Cre_end_dateDateTimePicker.Name = "Cre_end_dateDateTimePicker"
        Me.Cre_end_dateDateTimePicker.Size = New System.Drawing.Size(235, 21)
        Me.Cre_end_dateDateTimePicker.TabIndex = 6
        '
        'Req_numTextBox
        '
        Me.Req_numTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CreditBindingSource, "Req_num", True))
        Me.Req_numTextBox.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Req_numTextBox.Location = New System.Drawing.Point(155, 107)
        Me.Req_numTextBox.Name = "Req_numTextBox"
        Me.Req_numTextBox.Size = New System.Drawing.Size(200, 21)
        Me.Req_numTextBox.TabIndex = 8
        '
        'frm_credit2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(390, 199)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Cre_codLabel)
        Me.Controls.Add(Me.Cre_codTextBox)
        Me.Controls.Add(Cre_dateLabel)
        Me.Controls.Add(Me.Cre_dateDateTimePicker)
        Me.Controls.Add(Cre_end_dateLabel)
        Me.Controls.Add(Me.Cre_end_dateDateTimePicker)
        Me.Controls.Add(Req_numLabel)
        Me.Controls.Add(Me.Req_numTextBox)
        Me.Controls.Add(Me.CreditBindingNavigator)
        Me.Name = "frm_credit2"
        Me.Text = "frm_credit2"
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CreditBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CreditBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CreditBindingNavigator.ResumeLayout(False)
        Me.CreditBindingNavigator.PerformLayout()
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
End Class
