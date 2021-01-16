<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_school
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
        Dim Sch_numLabel As System.Windows.Forms.Label
        Dim Sch_nameLabel As System.Windows.Forms.Label
        Dim Sch_public_y_n_Label As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_school))
        Me.DatabaseDataSet = New credit_project.DatabaseDataSet()
        Me.School_or_universityBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.School_or_universityTableAdapter = New credit_project.DatabaseDataSetTableAdapters.School_or_universityTableAdapter()
        Me.TableAdapterManager = New credit_project.DatabaseDataSetTableAdapters.TableAdapterManager()
        Me.School_or_universityBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.School_or_universityBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Sch_numTextBox = New System.Windows.Forms.TextBox()
        Me.Sch_nameTextBox = New System.Windows.Forms.TextBox()
        Me.Sch_public_y_n_CheckBox = New System.Windows.Forms.CheckBox()
        Sch_numLabel = New System.Windows.Forms.Label()
        Sch_nameLabel = New System.Windows.Forms.Label()
        Sch_public_y_n_Label = New System.Windows.Forms.Label()
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.School_or_universityBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.School_or_universityBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.School_or_universityBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'Sch_numLabel
        '
        Sch_numLabel.AutoSize = True
        Sch_numLabel.Location = New System.Drawing.Point(10, 44)
        Sch_numLabel.Name = "Sch_numLabel"
        Sch_numLabel.Size = New System.Drawing.Size(51, 13)
        Sch_numLabel.TabIndex = 1
        Sch_numLabel.Text = "Sch num:"
        '
        'Sch_nameLabel
        '
        Sch_nameLabel.AutoSize = True
        Sch_nameLabel.Location = New System.Drawing.Point(10, 70)
        Sch_nameLabel.Name = "Sch_nameLabel"
        Sch_nameLabel.Size = New System.Drawing.Size(57, 13)
        Sch_nameLabel.TabIndex = 3
        Sch_nameLabel.Text = "Sch name:"
        '
        'Sch_public_y_n_Label
        '
        Sch_public_y_n_Label.AutoSize = True
        Sch_public_y_n_Label.Location = New System.Drawing.Point(10, 98)
        Sch_public_y_n_Label.Name = "Sch_public_y_n_Label"
        Sch_public_y_n_Label.Size = New System.Drawing.Size(81, 13)
        Sch_public_y_n_Label.TabIndex = 5
        Sch_public_y_n_Label.Text = "Sch public(y n):"
        '
        'DatabaseDataSet
        '
        Me.DatabaseDataSet.DataSetName = "DatabaseDataSet"
        Me.DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'School_or_universityBindingSource
        '
        Me.School_or_universityBindingSource.DataMember = "School_or_university"
        Me.School_or_universityBindingSource.DataSource = Me.DatabaseDataSet
        '
        'School_or_universityTableAdapter
        '
        Me.School_or_universityTableAdapter.ClearBeforeFill = True
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
        'School_or_universityBindingNavigator
        '
        Me.School_or_universityBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.School_or_universityBindingNavigator.BindingSource = Me.School_or_universityBindingSource
        Me.School_or_universityBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.School_or_universityBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.School_or_universityBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.School_or_universityBindingNavigatorSaveItem})
        Me.School_or_universityBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.School_or_universityBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.School_or_universityBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.School_or_universityBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.School_or_universityBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.School_or_universityBindingNavigator.Name = "School_or_universityBindingNavigator"
        Me.School_or_universityBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.School_or_universityBindingNavigator.Size = New System.Drawing.Size(284, 25)
        Me.School_or_universityBindingNavigator.TabIndex = 0
        Me.School_or_universityBindingNavigator.Text = "BindingNavigator1"
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
        'School_or_universityBindingNavigatorSaveItem
        '
        Me.School_or_universityBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.School_or_universityBindingNavigatorSaveItem.Image = CType(resources.GetObject("School_or_universityBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.School_or_universityBindingNavigatorSaveItem.Name = "School_or_universityBindingNavigatorSaveItem"
        Me.School_or_universityBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.School_or_universityBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Sch_numTextBox
        '
        Me.Sch_numTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.School_or_universityBindingSource, "Sch_num", True))
        Me.Sch_numTextBox.Location = New System.Drawing.Point(97, 41)
        Me.Sch_numTextBox.Name = "Sch_numTextBox"
        Me.Sch_numTextBox.Size = New System.Drawing.Size(104, 20)
        Me.Sch_numTextBox.TabIndex = 2
        '
        'Sch_nameTextBox
        '
        Me.Sch_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.School_or_universityBindingSource, "Sch_name", True))
        Me.Sch_nameTextBox.Location = New System.Drawing.Point(97, 67)
        Me.Sch_nameTextBox.Name = "Sch_nameTextBox"
        Me.Sch_nameTextBox.Size = New System.Drawing.Size(104, 20)
        Me.Sch_nameTextBox.TabIndex = 4
        '
        'Sch_public_y_n_CheckBox
        '
        Me.Sch_public_y_n_CheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.School_or_universityBindingSource, "Sch_public(y_n)", True))
        Me.Sch_public_y_n_CheckBox.Location = New System.Drawing.Point(97, 93)
        Me.Sch_public_y_n_CheckBox.Name = "Sch_public_y_n_CheckBox"
        Me.Sch_public_y_n_CheckBox.Size = New System.Drawing.Size(104, 24)
        Me.Sch_public_y_n_CheckBox.TabIndex = 6
        Me.Sch_public_y_n_CheckBox.Text = "CheckBox1"
        Me.Sch_public_y_n_CheckBox.UseVisualStyleBackColor = True
        '
        'frm_school
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 128)
        Me.Controls.Add(Sch_numLabel)
        Me.Controls.Add(Me.Sch_numTextBox)
        Me.Controls.Add(Sch_nameLabel)
        Me.Controls.Add(Me.Sch_nameTextBox)
        Me.Controls.Add(Sch_public_y_n_Label)
        Me.Controls.Add(Me.Sch_public_y_n_CheckBox)
        Me.Controls.Add(Me.School_or_universityBindingNavigator)
        Me.Name = "frm_school"
        Me.Text = "School"
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.School_or_universityBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.School_or_universityBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.School_or_universityBindingNavigator.ResumeLayout(False)
        Me.School_or_universityBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DatabaseDataSet As credit_project.DatabaseDataSet
    Friend WithEvents School_or_universityBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents School_or_universityTableAdapter As credit_project.DatabaseDataSetTableAdapters.School_or_universityTableAdapter
    Friend WithEvents TableAdapterManager As credit_project.DatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents School_or_universityBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents School_or_universityBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Sch_numTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Sch_nameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Sch_public_y_n_CheckBox As System.Windows.Forms.CheckBox
End Class
