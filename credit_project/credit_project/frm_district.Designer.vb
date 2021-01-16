<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_district
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_district))
        Dim Dis_numLabel As System.Windows.Forms.Label
        Dim Dis_nameLabel As System.Windows.Forms.Label
        Dim Pro_numLabel As System.Windows.Forms.Label
        Dim Por_numLabel As System.Windows.Forms.Label
        Me.DatabaseDataSet = New credit_project.DatabaseDataSet()
        Me.DistristBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DistristTableAdapter = New credit_project.DatabaseDataSetTableAdapters.DistristTableAdapter()
        Me.TableAdapterManager = New credit_project.DatabaseDataSetTableAdapters.TableAdapterManager()
        Me.DistristBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.DistristBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Dis_numTextBox = New System.Windows.Forms.TextBox()
        Me.Dis_nameTextBox = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ProvinceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProvinceTableAdapter = New credit_project.DatabaseDataSetTableAdapters.ProvinceTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        Dis_numLabel = New System.Windows.Forms.Label()
        Dis_nameLabel = New System.Windows.Forms.Label()
        Pro_numLabel = New System.Windows.Forms.Label()
        Por_numLabel = New System.Windows.Forms.Label()
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DistristBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DistristBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DistristBindingNavigator.SuspendLayout()
        CType(Me.ProvinceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DatabaseDataSet
        '
        Me.DatabaseDataSet.DataSetName = "DatabaseDataSet"
        Me.DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DistristBindingSource
        '
        Me.DistristBindingSource.DataMember = "Distrist"
        Me.DistristBindingSource.DataSource = Me.DatabaseDataSet
        '
        'DistristTableAdapter
        '
        Me.DistristTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.DistristTableAdapter = Me.DistristTableAdapter
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
        Me.TableAdapterManager.ProvinceTableAdapter = Me.ProvinceTableAdapter
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
        'DistristBindingNavigator
        '
        Me.DistristBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.DistristBindingNavigator.BindingSource = Me.DistristBindingSource
        Me.DistristBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.DistristBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.DistristBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.DistristBindingNavigatorSaveItem})
        Me.DistristBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.DistristBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.DistristBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.DistristBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.DistristBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.DistristBindingNavigator.Name = "DistristBindingNavigator"
        Me.DistristBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.DistristBindingNavigator.Size = New System.Drawing.Size(284, 25)
        Me.DistristBindingNavigator.TabIndex = 0
        Me.DistristBindingNavigator.Text = "BindingNavigator1"
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
        'DistristBindingNavigatorSaveItem
        '
        Me.DistristBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DistristBindingNavigatorSaveItem.Image = CType(resources.GetObject("DistristBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.DistristBindingNavigatorSaveItem.Name = "DistristBindingNavigatorSaveItem"
        Me.DistristBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.DistristBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Dis_numLabel
        '
        Dis_numLabel.AutoSize = True
        Dis_numLabel.Location = New System.Drawing.Point(31, 55)
        Dis_numLabel.Name = "Dis_numLabel"
        Dis_numLabel.Size = New System.Drawing.Size(48, 13)
        Dis_numLabel.TabIndex = 1
        Dis_numLabel.Text = "Dis num:"
        '
        'Dis_numTextBox
        '
        Me.Dis_numTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DistristBindingSource, "Dis_num", True))
        Me.Dis_numTextBox.Location = New System.Drawing.Point(91, 52)
        Me.Dis_numTextBox.Name = "Dis_numTextBox"
        Me.Dis_numTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Dis_numTextBox.TabIndex = 2
        '
        'Dis_nameLabel
        '
        Dis_nameLabel.AutoSize = True
        Dis_nameLabel.Location = New System.Drawing.Point(31, 81)
        Dis_nameLabel.Name = "Dis_nameLabel"
        Dis_nameLabel.Size = New System.Drawing.Size(54, 13)
        Dis_nameLabel.TabIndex = 3
        Dis_nameLabel.Text = "Dis name:"
        '
        'Dis_nameTextBox
        '
        Me.Dis_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DistristBindingSource, "Dis_name", True))
        Me.Dis_nameTextBox.Location = New System.Drawing.Point(91, 78)
        Me.Dis_nameTextBox.Name = "Dis_nameTextBox"
        Me.Dis_nameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Dis_nameTextBox.TabIndex = 4
        '
        'Pro_numLabel
        '
        Pro_numLabel.AutoSize = True
        Pro_numLabel.Location = New System.Drawing.Point(31, 107)
        Pro_numLabel.Name = "Pro_numLabel"
        Pro_numLabel.Size = New System.Drawing.Size(82, 13)
        Pro_numLabel.TabIndex = 5
        Pro_numLabel.Text = "Province Name:"
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DistristBindingSource, "Pro_num", True))
        Me.ComboBox1.DataSource = Me.ProvinceBindingSource
        Me.ComboBox1.DisplayMember = "Por_name"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(119, 104)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(95, 21)
        Me.ComboBox1.TabIndex = 7
        Me.ComboBox1.ValueMember = "Por_num"
        '
        'ProvinceBindingSource
        '
        Me.ProvinceBindingSource.DataMember = "Province"
        Me.ProvinceBindingSource.DataSource = Me.DatabaseDataSet
        '
        'ProvinceTableAdapter
        '
        Me.ProvinceTableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.ForeColor = System.Drawing.Color.Red
        Me.Button1.Location = New System.Drawing.Point(221, 104)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "New"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Por_numLabel
        '
        Por_numLabel.AutoSize = True
        Por_numLabel.Font = New System.Drawing.Font("Perpetua Titling MT", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Por_numLabel.Location = New System.Drawing.Point(87, 29)
        Por_numLabel.Name = "Por_numLabel"
        Por_numLabel.Size = New System.Drawing.Size(90, 20)
        Por_numLabel.TabIndex = 9
        Por_numLabel.Text = "District"
        '
        'frm_district
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 138)
        Me.Controls.Add(Por_numLabel)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Dis_numLabel)
        Me.Controls.Add(Me.Dis_numTextBox)
        Me.Controls.Add(Dis_nameLabel)
        Me.Controls.Add(Me.Dis_nameTextBox)
        Me.Controls.Add(Pro_numLabel)
        Me.Controls.Add(Me.DistristBindingNavigator)
        Me.Name = "frm_district"
        Me.Text = "District"
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DistristBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DistristBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DistristBindingNavigator.ResumeLayout(False)
        Me.DistristBindingNavigator.PerformLayout()
        CType(Me.ProvinceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DatabaseDataSet As credit_project.DatabaseDataSet
    Friend WithEvents DistristBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DistristTableAdapter As credit_project.DatabaseDataSetTableAdapters.DistristTableAdapter
    Friend WithEvents TableAdapterManager As credit_project.DatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DistristBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents DistristBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Dis_numTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Dis_nameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ProvinceTableAdapter As credit_project.DatabaseDataSetTableAdapters.ProvinceTableAdapter
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents ProvinceBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
