<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_profession
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_profession))
        Dim Pr_codLabel As System.Windows.Forms.Label
        Dim Pr_desLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Me.DatabaseDataSet = New credit_project.DatabaseDataSet()
        Me.ProfessionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProfessionTableAdapter = New credit_project.DatabaseDataSetTableAdapters.ProfessionTableAdapter()
        Me.TableAdapterManager = New credit_project.DatabaseDataSetTableAdapters.TableAdapterManager()
        Me.ProfessionBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.ProfessionBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Pr_codTextBox = New System.Windows.Forms.TextBox()
        Me.Pr_desTextBox = New System.Windows.Forms.TextBox()
        Pr_codLabel = New System.Windows.Forms.Label()
        Pr_desLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProfessionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProfessionBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ProfessionBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'DatabaseDataSet
        '
        Me.DatabaseDataSet.DataSetName = "DatabaseDataSet"
        Me.DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProfessionBindingSource
        '
        Me.ProfessionBindingSource.DataMember = "Profession"
        Me.ProfessionBindingSource.DataSource = Me.DatabaseDataSet
        '
        'ProfessionTableAdapter
        '
        Me.ProfessionTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.WorkTableAdapter = Nothing
        '
        'ProfessionBindingNavigator
        '
        Me.ProfessionBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ProfessionBindingNavigator.BindingSource = Me.ProfessionBindingSource
        Me.ProfessionBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ProfessionBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ProfessionBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ProfessionBindingNavigatorSaveItem})
        Me.ProfessionBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ProfessionBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ProfessionBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ProfessionBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ProfessionBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ProfessionBindingNavigator.Name = "ProfessionBindingNavigator"
        Me.ProfessionBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ProfessionBindingNavigator.Size = New System.Drawing.Size(284, 25)
        Me.ProfessionBindingNavigator.TabIndex = 0
        Me.ProfessionBindingNavigator.Text = "BindingNavigator1"
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
        'ProfessionBindingNavigatorSaveItem
        '
        Me.ProfessionBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ProfessionBindingNavigatorSaveItem.Image = CType(resources.GetObject("ProfessionBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ProfessionBindingNavigatorSaveItem.Name = "ProfessionBindingNavigatorSaveItem"
        Me.ProfessionBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.ProfessionBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Pr_codLabel
        '
        Pr_codLabel.AutoSize = True
        Pr_codLabel.Location = New System.Drawing.Point(29, 77)
        Pr_codLabel.Name = "Pr_codLabel"
        Pr_codLabel.Size = New System.Drawing.Size(41, 13)
        Pr_codLabel.TabIndex = 1
        Pr_codLabel.Text = "Pr cod:"
        '
        'Pr_codTextBox
        '
        Me.Pr_codTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProfessionBindingSource, "Pr_cod", True))
        Me.Pr_codTextBox.Location = New System.Drawing.Point(76, 74)
        Me.Pr_codTextBox.Name = "Pr_codTextBox"
        Me.Pr_codTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Pr_codTextBox.TabIndex = 2
        '
        'Pr_desLabel
        '
        Pr_desLabel.AutoSize = True
        Pr_desLabel.Location = New System.Drawing.Point(29, 103)
        Pr_desLabel.Name = "Pr_desLabel"
        Pr_desLabel.Size = New System.Drawing.Size(41, 13)
        Pr_desLabel.TabIndex = 3
        Pr_desLabel.Text = "Pr des:"
        '
        'Pr_desTextBox
        '
        Me.Pr_desTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProfessionBindingSource, "Pr_des", True))
        Me.Pr_desTextBox.Location = New System.Drawing.Point(76, 100)
        Me.Pr_desTextBox.Name = "Pr_desTextBox"
        Me.Pr_desTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Pr_desTextBox.TabIndex = 4
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Perpetua Titling MT", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.Location = New System.Drawing.Point(72, 39)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(112, 20)
        Label1.TabIndex = 5
        Label1.Text = "PROFESSION"
        '
        'frm_profession
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 133)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Pr_codLabel)
        Me.Controls.Add(Me.Pr_codTextBox)
        Me.Controls.Add(Pr_desLabel)
        Me.Controls.Add(Me.Pr_desTextBox)
        Me.Controls.Add(Me.ProfessionBindingNavigator)
        Me.Name = "frm_profession"
        Me.Text = "frm_profession"
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProfessionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProfessionBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ProfessionBindingNavigator.ResumeLayout(False)
        Me.ProfessionBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DatabaseDataSet As credit_project.DatabaseDataSet
    Friend WithEvents ProfessionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProfessionTableAdapter As credit_project.DatabaseDataSetTableAdapters.ProfessionTableAdapter
    Friend WithEvents TableAdapterManager As credit_project.DatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ProfessionBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents ProfessionBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Pr_codTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Pr_desTextBox As System.Windows.Forms.TextBox
End Class
