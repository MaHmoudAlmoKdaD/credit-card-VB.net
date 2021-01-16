<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_company
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_company))
        Dim Com_numLabel As System.Windows.Forms.Label
        Dim Com_nameLabel As System.Windows.Forms.Label
        Dim Com_phoneLabel As System.Windows.Forms.Label
        Dim Buil_numLabel As System.Windows.Forms.Label
        Dim Por_numLabel As System.Windows.Forms.Label
        Me.DatabaseDataSet = New credit_project.DatabaseDataSet()
        Me.CompanyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CompanyTableAdapter = New credit_project.DatabaseDataSetTableAdapters.CompanyTableAdapter()
        Me.TableAdapterManager = New credit_project.DatabaseDataSetTableAdapters.TableAdapterManager()
        Me.CompanyBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.CompanyBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Com_numTextBox = New System.Windows.Forms.TextBox()
        Me.Com_nameTextBox = New System.Windows.Forms.TextBox()
        Me.Com_phoneTextBox = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.BuildingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BuildingTableAdapter = New credit_project.DatabaseDataSetTableAdapters.BuildingTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        Com_numLabel = New System.Windows.Forms.Label()
        Com_nameLabel = New System.Windows.Forms.Label()
        Com_phoneLabel = New System.Windows.Forms.Label()
        Buil_numLabel = New System.Windows.Forms.Label()
        Por_numLabel = New System.Windows.Forms.Label()
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompanyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompanyBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CompanyBindingNavigator.SuspendLayout()
        CType(Me.BuildingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DatabaseDataSet
        '
        Me.DatabaseDataSet.DataSetName = "DatabaseDataSet"
        Me.DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CompanyBindingSource
        '
        Me.CompanyBindingSource.DataMember = "Company"
        Me.CompanyBindingSource.DataSource = Me.DatabaseDataSet
        '
        'CompanyTableAdapter
        '
        Me.CompanyTableAdapter.ClearBeforeFill = True
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
        'CompanyBindingNavigator
        '
        Me.CompanyBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CompanyBindingNavigator.BindingSource = Me.CompanyBindingSource
        Me.CompanyBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CompanyBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CompanyBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CompanyBindingNavigatorSaveItem})
        Me.CompanyBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CompanyBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CompanyBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CompanyBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CompanyBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CompanyBindingNavigator.Name = "CompanyBindingNavigator"
        Me.CompanyBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CompanyBindingNavigator.Size = New System.Drawing.Size(287, 25)
        Me.CompanyBindingNavigator.TabIndex = 0
        Me.CompanyBindingNavigator.Text = "BindingNavigator1"
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
        'CompanyBindingNavigatorSaveItem
        '
        Me.CompanyBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CompanyBindingNavigatorSaveItem.Image = CType(resources.GetObject("CompanyBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CompanyBindingNavigatorSaveItem.Name = "CompanyBindingNavigatorSaveItem"
        Me.CompanyBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.CompanyBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Com_numLabel
        '
        Com_numLabel.AutoSize = True
        Com_numLabel.Location = New System.Drawing.Point(17, 60)
        Com_numLabel.Name = "Com_numLabel"
        Com_numLabel.Size = New System.Drawing.Size(55, 13)
        Com_numLabel.TabIndex = 1
        Com_numLabel.Text = "Com num:"
        '
        'Com_numTextBox
        '
        Me.Com_numTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CompanyBindingSource, "Com_num", True))
        Me.Com_numTextBox.Location = New System.Drawing.Point(88, 57)
        Me.Com_numTextBox.Name = "Com_numTextBox"
        Me.Com_numTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Com_numTextBox.TabIndex = 2
        '
        'Com_nameLabel
        '
        Com_nameLabel.AutoSize = True
        Com_nameLabel.Location = New System.Drawing.Point(17, 86)
        Com_nameLabel.Name = "Com_nameLabel"
        Com_nameLabel.Size = New System.Drawing.Size(61, 13)
        Com_nameLabel.TabIndex = 3
        Com_nameLabel.Text = "Com name:"
        '
        'Com_nameTextBox
        '
        Me.Com_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CompanyBindingSource, "Com_name", True))
        Me.Com_nameTextBox.Location = New System.Drawing.Point(88, 83)
        Me.Com_nameTextBox.Name = "Com_nameTextBox"
        Me.Com_nameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Com_nameTextBox.TabIndex = 4
        '
        'Com_phoneLabel
        '
        Com_phoneLabel.AutoSize = True
        Com_phoneLabel.Location = New System.Drawing.Point(17, 112)
        Com_phoneLabel.Name = "Com_phoneLabel"
        Com_phoneLabel.Size = New System.Drawing.Size(65, 13)
        Com_phoneLabel.TabIndex = 5
        Com_phoneLabel.Text = "Com phone:"
        '
        'Com_phoneTextBox
        '
        Me.Com_phoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CompanyBindingSource, "Com_phone", True))
        Me.Com_phoneTextBox.Location = New System.Drawing.Point(88, 109)
        Me.Com_phoneTextBox.Name = "Com_phoneTextBox"
        Me.Com_phoneTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Com_phoneTextBox.TabIndex = 6
        '
        'Buil_numLabel
        '
        Buil_numLabel.AutoSize = True
        Buil_numLabel.Location = New System.Drawing.Point(17, 138)
        Buil_numLabel.Name = "Buil_numLabel"
        Buil_numLabel.Size = New System.Drawing.Size(77, 13)
        Buil_numLabel.TabIndex = 7
        Buil_numLabel.Text = "Building Name:"
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CompanyBindingSource, "Buil_num", True))
        Me.ComboBox1.DataSource = Me.BuildingBindingSource
        Me.ComboBox1.DisplayMember = "Buil_name"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(100, 135)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(100, 21)
        Me.ComboBox1.TabIndex = 8
        Me.ComboBox1.ValueMember = "Buil_num"
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
        'Button1
        '
        Me.Button1.ForeColor = System.Drawing.Color.Red
        Me.Button1.Location = New System.Drawing.Point(206, 135)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "New"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Por_numLabel
        '
        Por_numLabel.AutoSize = True
        Por_numLabel.Font = New System.Drawing.Font("Perpetua Titling MT", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Por_numLabel.Location = New System.Drawing.Point(68, 34)
        Por_numLabel.Name = "Por_numLabel"
        Por_numLabel.Size = New System.Drawing.Size(100, 20)
        Por_numLabel.TabIndex = 10
        Por_numLabel.Text = "COMPANY"
        '
        'frm_company
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(287, 171)
        Me.Controls.Add(Por_numLabel)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Com_numLabel)
        Me.Controls.Add(Me.Com_numTextBox)
        Me.Controls.Add(Com_nameLabel)
        Me.Controls.Add(Me.Com_nameTextBox)
        Me.Controls.Add(Com_phoneLabel)
        Me.Controls.Add(Me.Com_phoneTextBox)
        Me.Controls.Add(Buil_numLabel)
        Me.Controls.Add(Me.CompanyBindingNavigator)
        Me.Name = "frm_company"
        Me.Text = "Company"
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompanyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompanyBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CompanyBindingNavigator.ResumeLayout(False)
        Me.CompanyBindingNavigator.PerformLayout()
        CType(Me.BuildingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DatabaseDataSet As credit_project.DatabaseDataSet
    Friend WithEvents CompanyBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CompanyTableAdapter As credit_project.DatabaseDataSetTableAdapters.CompanyTableAdapter
    Friend WithEvents TableAdapterManager As credit_project.DatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CompanyBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents CompanyBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Com_numTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Com_nameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Com_phoneTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BuildingTableAdapter As credit_project.DatabaseDataSetTableAdapters.BuildingTableAdapter
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents BuildingBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
