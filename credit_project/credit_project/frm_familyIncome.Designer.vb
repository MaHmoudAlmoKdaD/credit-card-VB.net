<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_familyIncome
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_familyIncome))
        Dim Req_numLabel As System.Windows.Forms.Label
        Dim In_T_codeLabel As System.Windows.Forms.Label
        Dim Family_f_valueLabel As System.Windows.Forms.Label
        Me.DatabaseDataSet = New credit_project.DatabaseDataSet()
        Me.Family_incomeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Family_incomeTableAdapter = New credit_project.DatabaseDataSetTableAdapters.Family_incomeTableAdapter()
        Me.TableAdapterManager = New credit_project.DatabaseDataSetTableAdapters.TableAdapterManager()
        Me.Family_incomeBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.Family_incomeBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Req_numTextBox = New System.Windows.Forms.TextBox()
        Me.In_T_codeTextBox = New System.Windows.Forms.TextBox()
        Me.Family_f_valueTextBox = New System.Windows.Forms.TextBox()
        Req_numLabel = New System.Windows.Forms.Label()
        In_T_codeLabel = New System.Windows.Forms.Label()
        Family_f_valueLabel = New System.Windows.Forms.Label()
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Family_incomeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Family_incomeBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Family_incomeBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'DatabaseDataSet
        '
        Me.DatabaseDataSet.DataSetName = "DatabaseDataSet"
        Me.DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Family_incomeBindingSource
        '
        Me.Family_incomeBindingSource.DataMember = "Family_income"
        Me.Family_incomeBindingSource.DataSource = Me.DatabaseDataSet
        '
        'Family_incomeTableAdapter
        '
        Me.Family_incomeTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AnswerTableAdapter = Nothing
        Me.TableAdapterManager.Assets_typeTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BondTableAdapter = Nothing
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
        'Family_incomeBindingNavigator
        '
        Me.Family_incomeBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Family_incomeBindingNavigator.BindingSource = Me.Family_incomeBindingSource
        Me.Family_incomeBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Family_incomeBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Family_incomeBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Family_incomeBindingNavigatorSaveItem})
        Me.Family_incomeBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Family_incomeBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Family_incomeBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Family_incomeBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Family_incomeBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Family_incomeBindingNavigator.Name = "Family_incomeBindingNavigator"
        Me.Family_incomeBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Family_incomeBindingNavigator.Size = New System.Drawing.Size(284, 25)
        Me.Family_incomeBindingNavigator.TabIndex = 0
        Me.Family_incomeBindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 15)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
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
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'Family_incomeBindingNavigatorSaveItem
        '
        Me.Family_incomeBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Family_incomeBindingNavigatorSaveItem.Image = CType(resources.GetObject("Family_incomeBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Family_incomeBindingNavigatorSaveItem.Name = "Family_incomeBindingNavigatorSaveItem"
        Me.Family_incomeBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.Family_incomeBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Req_numLabel
        '
        Req_numLabel.AutoSize = True
        Req_numLabel.Location = New System.Drawing.Point(43, 70)
        Req_numLabel.Name = "Req_numLabel"
        Req_numLabel.Size = New System.Drawing.Size(53, 13)
        Req_numLabel.TabIndex = 1
        Req_numLabel.Text = "Req num:"
        '
        'Req_numTextBox
        '
        Me.Req_numTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Family_incomeBindingSource, "Req_num", True))
        Me.Req_numTextBox.Location = New System.Drawing.Point(126, 67)
        Me.Req_numTextBox.Name = "Req_numTextBox"
        Me.Req_numTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Req_numTextBox.TabIndex = 2
        '
        'In_T_codeLabel
        '
        In_T_codeLabel.AutoSize = True
        In_T_codeLabel.Location = New System.Drawing.Point(43, 96)
        In_T_codeLabel.Name = "In_T_codeLabel"
        In_T_codeLabel.Size = New System.Drawing.Size(56, 13)
        In_T_codeLabel.TabIndex = 3
        In_T_codeLabel.Text = "In T code:"
        '
        'In_T_codeTextBox
        '
        Me.In_T_codeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Family_incomeBindingSource, "In_T_code", True))
        Me.In_T_codeTextBox.Location = New System.Drawing.Point(126, 93)
        Me.In_T_codeTextBox.Name = "In_T_codeTextBox"
        Me.In_T_codeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.In_T_codeTextBox.TabIndex = 4
        '
        'Family_f_valueLabel
        '
        Family_f_valueLabel.AutoSize = True
        Family_f_valueLabel.Location = New System.Drawing.Point(43, 122)
        Family_f_valueLabel.Name = "Family_f_valueLabel"
        Family_f_valueLabel.Size = New System.Drawing.Size(77, 13)
        Family_f_valueLabel.TabIndex = 5
        Family_f_valueLabel.Text = "Family f value:"
        '
        'Family_f_valueTextBox
        '
        Me.Family_f_valueTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Family_incomeBindingSource, "Family_f_value", True))
        Me.Family_f_valueTextBox.Location = New System.Drawing.Point(126, 119)
        Me.Family_f_valueTextBox.Name = "Family_f_valueTextBox"
        Me.Family_f_valueTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Family_f_valueTextBox.TabIndex = 6
        '
        'frm_familyIncome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Req_numLabel)
        Me.Controls.Add(Me.Req_numTextBox)
        Me.Controls.Add(In_T_codeLabel)
        Me.Controls.Add(Me.In_T_codeTextBox)
        Me.Controls.Add(Family_f_valueLabel)
        Me.Controls.Add(Me.Family_f_valueTextBox)
        Me.Controls.Add(Me.Family_incomeBindingNavigator)
        Me.Name = "frm_familyIncome"
        Me.Text = "frm_familyIncome"
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Family_incomeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Family_incomeBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Family_incomeBindingNavigator.ResumeLayout(False)
        Me.Family_incomeBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DatabaseDataSet As credit_project.DatabaseDataSet
    Friend WithEvents Family_incomeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Family_incomeTableAdapter As credit_project.DatabaseDataSetTableAdapters.Family_incomeTableAdapter
    Friend WithEvents TableAdapterManager As credit_project.DatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Family_incomeBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents Family_incomeBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Req_numTextBox As System.Windows.Forms.TextBox
    Friend WithEvents In_T_codeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Family_f_valueTextBox As System.Windows.Forms.TextBox
End Class
