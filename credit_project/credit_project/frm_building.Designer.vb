<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_building
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
        Dim Buil_numLabel As System.Windows.Forms.Label
        Dim Buil_nameLabel As System.Windows.Forms.Label
        Dim Str_numLabel As System.Windows.Forms.Label
        Dim Por_numLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_building))
        Me.DatabaseDataSet = New credit_project.DatabaseDataSet()
        Me.BuildingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BuildingTableAdapter = New credit_project.DatabaseDataSetTableAdapters.BuildingTableAdapter()
        Me.TableAdapterManager = New credit_project.DatabaseDataSetTableAdapters.TableAdapterManager()
        Me.StreetTableAdapter = New credit_project.DatabaseDataSetTableAdapters.StreetTableAdapter()
        Me.BuildingBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.BuildingBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Buil_numTextBox = New System.Windows.Forms.TextBox()
        Me.Buil_nameTextBox = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.StreetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Buil_numLabel = New System.Windows.Forms.Label()
        Buil_nameLabel = New System.Windows.Forms.Label()
        Str_numLabel = New System.Windows.Forms.Label()
        Por_numLabel = New System.Windows.Forms.Label()
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuildingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuildingBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BuildingBindingNavigator.SuspendLayout()
        CType(Me.StreetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Buil_numLabel
        '
        Buil_numLabel.AutoSize = True
        Buil_numLabel.Location = New System.Drawing.Point(32, 56)
        Buil_numLabel.Name = "Buil_numLabel"
        Buil_numLabel.Size = New System.Drawing.Size(50, 13)
        Buil_numLabel.TabIndex = 1
        Buil_numLabel.Text = "Buil num:"
        '
        'Buil_nameLabel
        '
        Buil_nameLabel.AutoSize = True
        Buil_nameLabel.Location = New System.Drawing.Point(32, 82)
        Buil_nameLabel.Name = "Buil_nameLabel"
        Buil_nameLabel.Size = New System.Drawing.Size(56, 13)
        Buil_nameLabel.TabIndex = 3
        Buil_nameLabel.Text = "Buil name:"
        '
        'Str_numLabel
        '
        Str_numLabel.AutoSize = True
        Str_numLabel.Location = New System.Drawing.Point(32, 108)
        Str_numLabel.Name = "Str_numLabel"
        Str_numLabel.Size = New System.Drawing.Size(70, 13)
        Str_numLabel.TabIndex = 5
        Str_numLabel.Text = "Street name:"
        '
        'Por_numLabel
        '
        Por_numLabel.AutoSize = True
        Por_numLabel.Font = New System.Drawing.Font("Perpetua Titling MT", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Por_numLabel.Location = New System.Drawing.Point(81, 30)
        Por_numLabel.Name = "Por_numLabel"
        Por_numLabel.Size = New System.Drawing.Size(98, 20)
        Por_numLabel.TabIndex = 8
        Por_numLabel.Text = "BUILDING"
        '
        'DatabaseDataSet
        '
        Me.DatabaseDataSet.DataSetName = "DatabaseDataSet"
        Me.DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BuildingBindingSource
        '
        Me.BuildingBindingSource.DataMember = "Building"
        Me.BuildingBindingSource.DataSource = Me.DatabaseDataSet
        '
        'BuildingTableAdapter
        '
        Me.BuildingTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AnswerTableAdapter = Nothing
        Me.TableAdapterManager.Assets_typeTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.bnd1TableAdapter = Nothing
        Me.TableAdapterManager.BorrowerTableAdapter = Nothing
        Me.TableAdapterManager.BuildingTableAdapter = Me.BuildingTableAdapter
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
        Me.TableAdapterManager.School_or_universityTableAdapter = Nothing
        Me.TableAdapterManager.Second_addressTableAdapter = Nothing
        Me.TableAdapterManager.Service_projectTableAdapter = Nothing
        Me.TableAdapterManager.sesionTableAdapter = Nothing
        Me.TableAdapterManager.ShiftTableAdapter = Nothing
        Me.TableAdapterManager.Social_typeTableAdapter = Nothing
        Me.TableAdapterManager.Spend_typeTableAdapter = Nothing
        Me.TableAdapterManager.StreetTableAdapter = Me.StreetTableAdapter
        Me.TableAdapterManager.SuppliersTableAdapter = Nothing
        Me.TableAdapterManager.TownTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = credit_project.DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.Work_typeTableAdapter = Nothing
        Me.TableAdapterManager.WorkTableAdapter = Nothing
        '
        'StreetTableAdapter
        '
        Me.StreetTableAdapter.ClearBeforeFill = True
        '
        'BuildingBindingNavigator
        '
        Me.BuildingBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.BuildingBindingNavigator.BindingSource = Me.BuildingBindingSource
        Me.BuildingBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.BuildingBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.BuildingBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.BuildingBindingNavigatorSaveItem})
        Me.BuildingBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.BuildingBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BuildingBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BuildingBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BuildingBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BuildingBindingNavigator.Name = "BuildingBindingNavigator"
        Me.BuildingBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.BuildingBindingNavigator.Size = New System.Drawing.Size(293, 25)
        Me.BuildingBindingNavigator.TabIndex = 0
        Me.BuildingBindingNavigator.Text = "BindingNavigator1"
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
        'BuildingBindingNavigatorSaveItem
        '
        Me.BuildingBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BuildingBindingNavigatorSaveItem.Image = CType(resources.GetObject("BuildingBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.BuildingBindingNavigatorSaveItem.Name = "BuildingBindingNavigatorSaveItem"
        Me.BuildingBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.BuildingBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Buil_numTextBox
        '
        Me.Buil_numTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BuildingBindingSource, "Buil_num", True))
        Me.Buil_numTextBox.Location = New System.Drawing.Point(94, 53)
        Me.Buil_numTextBox.Name = "Buil_numTextBox"
        Me.Buil_numTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Buil_numTextBox.TabIndex = 2
        '
        'Buil_nameTextBox
        '
        Me.Buil_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BuildingBindingSource, "Buil_name", True))
        Me.Buil_nameTextBox.Location = New System.Drawing.Point(94, 79)
        Me.Buil_nameTextBox.Name = "Buil_nameTextBox"
        Me.Buil_nameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Buil_nameTextBox.TabIndex = 4
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.BuildingBindingSource, "Str_num", True))
        Me.ComboBox1.DataSource = Me.StreetBindingSource
        Me.ComboBox1.DisplayMember = "Str_name"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(94, 105)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(100, 21)
        Me.ComboBox1.TabIndex = 6
        Me.ComboBox1.ValueMember = "Str_num"
        '
        'StreetBindingSource
        '
        Me.StreetBindingSource.DataMember = "Street"
        Me.StreetBindingSource.DataSource = Me.DatabaseDataSet
        '
        'Button1
        '
        Me.Button1.ForeColor = System.Drawing.Color.Red
        Me.Button1.Location = New System.Drawing.Point(201, 105)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "New"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frm_building
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(293, 138)
        Me.Controls.Add(Por_numLabel)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Buil_numLabel)
        Me.Controls.Add(Me.Buil_numTextBox)
        Me.Controls.Add(Buil_nameLabel)
        Me.Controls.Add(Me.Buil_nameTextBox)
        Me.Controls.Add(Str_numLabel)
        Me.Controls.Add(Me.BuildingBindingNavigator)
        Me.Name = "frm_building"
        Me.Text = "Building"
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuildingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuildingBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BuildingBindingNavigator.ResumeLayout(False)
        Me.BuildingBindingNavigator.PerformLayout()
        CType(Me.StreetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DatabaseDataSet As credit_project.DatabaseDataSet
    Friend WithEvents BuildingBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BuildingTableAdapter As credit_project.DatabaseDataSetTableAdapters.BuildingTableAdapter
    Friend WithEvents TableAdapterManager As credit_project.DatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents BuildingBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents BuildingBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents StreetTableAdapter As credit_project.DatabaseDataSetTableAdapters.StreetTableAdapter
    Friend WithEvents Buil_numTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Buil_nameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents StreetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
