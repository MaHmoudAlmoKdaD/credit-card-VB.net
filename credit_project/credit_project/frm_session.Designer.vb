<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_session
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
        Dim Label1 As System.Windows.Forms.Label
        Dim Ses_codLabel As System.Windows.Forms.Label
        Dim Ses_dateLabel As System.Windows.Forms.Label
        Dim Cred_valueLabel As System.Windows.Forms.Label
        Dim Accepted_y_n_Label As System.Windows.Forms.Label
        Dim Nb_paymentsLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_session))
        Me.DatabaseDataSet = New credit_project.DatabaseDataSet()
        Me.SesionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SesionTableAdapter = New credit_project.DatabaseDataSetTableAdapters.sesionTableAdapter()
        Me.TableAdapterManager = New credit_project.DatabaseDataSetTableAdapters.TableAdapterManager()
        Me.SesionBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.SesionBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Ses_codTextBox = New System.Windows.Forms.TextBox()
        Me.Ses_dateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Cred_valueTextBox = New System.Windows.Forms.TextBox()
        Me.Accepted_y_n_CheckBox = New System.Windows.Forms.CheckBox()
        Me.Nb_paymentsTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Label1 = New System.Windows.Forms.Label()
        Ses_codLabel = New System.Windows.Forms.Label()
        Ses_dateLabel = New System.Windows.Forms.Label()
        Cred_valueLabel = New System.Windows.Forms.Label()
        Accepted_y_n_Label = New System.Windows.Forms.Label()
        Nb_paymentsLabel = New System.Windows.Forms.Label()
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SesionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SesionBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SesionBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Perpetua Titling MT", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.Location = New System.Drawing.Point(151, 40)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(100, 26)
        Label1.TabIndex = 11
        Label1.Text = "SESSION"
        '
        'Ses_codLabel
        '
        Ses_codLabel.AutoSize = True
        Ses_codLabel.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Ses_codLabel.Location = New System.Drawing.Point(3, 83)
        Ses_codLabel.Name = "Ses_codLabel"
        Ses_codLabel.Size = New System.Drawing.Size(61, 13)
        Ses_codLabel.TabIndex = 12
        Ses_codLabel.Text = "Ses cod:"
        '
        'Ses_dateLabel
        '
        Ses_dateLabel.AutoSize = True
        Ses_dateLabel.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Ses_dateLabel.Location = New System.Drawing.Point(174, 83)
        Ses_dateLabel.Name = "Ses_dateLabel"
        Ses_dateLabel.Size = New System.Drawing.Size(67, 13)
        Ses_dateLabel.TabIndex = 14
        Ses_dateLabel.Text = "Ses date:"
        '
        'Cred_valueLabel
        '
        Cred_valueLabel.AutoSize = True
        Cred_valueLabel.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Cred_valueLabel.Location = New System.Drawing.Point(71, 114)
        Cred_valueLabel.Name = "Cred_valueLabel"
        Cred_valueLabel.Size = New System.Drawing.Size(81, 13)
        Cred_valueLabel.TabIndex = 16
        Cred_valueLabel.Text = "Cred value:"
        '
        'Accepted_y_n_Label
        '
        Accepted_y_n_Label.AutoSize = True
        Accepted_y_n_Label.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Accepted_y_n_Label.Location = New System.Drawing.Point(71, 142)
        Accepted_y_n_Label.Name = "Accepted_y_n_Label"
        Accepted_y_n_Label.Size = New System.Drawing.Size(103, 13)
        Accepted_y_n_Label.TabIndex = 18
        Accepted_y_n_Label.Text = "Accepted(y n):"
        '
        'Nb_paymentsLabel
        '
        Nb_paymentsLabel.AutoSize = True
        Nb_paymentsLabel.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Nb_paymentsLabel.Location = New System.Drawing.Point(71, 170)
        Nb_paymentsLabel.Name = "Nb_paymentsLabel"
        Nb_paymentsLabel.Size = New System.Drawing.Size(96, 13)
        Nb_paymentsLabel.TabIndex = 20
        Nb_paymentsLabel.Text = "Nb payments:"
        '
        'DatabaseDataSet
        '
        Me.DatabaseDataSet.DataSetName = "DatabaseDataSet"
        Me.DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SesionBindingSource
        '
        Me.SesionBindingSource.DataMember = "sesion"
        Me.SesionBindingSource.DataSource = Me.DatabaseDataSet
        '
        'SesionTableAdapter
        '
        Me.SesionTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.School_or_universityTableAdapter = Nothing
        Me.TableAdapterManager.Second_addressTableAdapter = Nothing
        Me.TableAdapterManager.Service_projectTableAdapter = Nothing
        Me.TableAdapterManager.sesionTableAdapter = Me.SesionTableAdapter
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
        'SesionBindingNavigator
        '
        Me.SesionBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.SesionBindingNavigator.BindingSource = Me.SesionBindingSource
        Me.SesionBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.SesionBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.SesionBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.SesionBindingNavigatorSaveItem})
        Me.SesionBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.SesionBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.SesionBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.SesionBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.SesionBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.SesionBindingNavigator.Name = "SesionBindingNavigator"
        Me.SesionBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.SesionBindingNavigator.Size = New System.Drawing.Size(488, 25)
        Me.SesionBindingNavigator.TabIndex = 12
        Me.SesionBindingNavigator.Text = "BindingNavigator1"
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
        'SesionBindingNavigatorSaveItem
        '
        Me.SesionBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SesionBindingNavigatorSaveItem.Image = CType(resources.GetObject("SesionBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.SesionBindingNavigatorSaveItem.Name = "SesionBindingNavigatorSaveItem"
        Me.SesionBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.SesionBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Ses_codTextBox
        '
        Me.Ses_codTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SesionBindingSource, "Ses_cod", True))
        Me.Ses_codTextBox.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ses_codTextBox.Location = New System.Drawing.Point(109, 80)
        Me.Ses_codTextBox.Name = "Ses_codTextBox"
        Me.Ses_codTextBox.Size = New System.Drawing.Size(59, 21)
        Me.Ses_codTextBox.TabIndex = 13
        '
        'Ses_dateDateTimePicker
        '
        Me.Ses_dateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.SesionBindingSource, "Ses_date", True))
        Me.Ses_dateDateTimePicker.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ses_dateDateTimePicker.Location = New System.Drawing.Point(247, 77)
        Me.Ses_dateDateTimePicker.Name = "Ses_dateDateTimePicker"
        Me.Ses_dateDateTimePicker.Size = New System.Drawing.Size(241, 21)
        Me.Ses_dateDateTimePicker.TabIndex = 15
        '
        'Cred_valueTextBox
        '
        Me.Cred_valueTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SesionBindingSource, "Cred_value", True))
        Me.Cred_valueTextBox.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cred_valueTextBox.Location = New System.Drawing.Point(177, 111)
        Me.Cred_valueTextBox.Name = "Cred_valueTextBox"
        Me.Cred_valueTextBox.Size = New System.Drawing.Size(200, 21)
        Me.Cred_valueTextBox.TabIndex = 17
        '
        'Accepted_y_n_CheckBox
        '
        Me.Accepted_y_n_CheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.SesionBindingSource, "Accepted(y_n)", True))
        Me.Accepted_y_n_CheckBox.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Accepted_y_n_CheckBox.Location = New System.Drawing.Point(177, 137)
        Me.Accepted_y_n_CheckBox.Name = "Accepted_y_n_CheckBox"
        Me.Accepted_y_n_CheckBox.Size = New System.Drawing.Size(200, 24)
        Me.Accepted_y_n_CheckBox.TabIndex = 19
        Me.Accepted_y_n_CheckBox.Text = "YES"
        Me.Accepted_y_n_CheckBox.UseVisualStyleBackColor = True
        '
        'Nb_paymentsTextBox
        '
        Me.Nb_paymentsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SesionBindingSource, "Nb_payments", True))
        Me.Nb_paymentsTextBox.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nb_paymentsTextBox.Location = New System.Drawing.Point(177, 167)
        Me.Nb_paymentsTextBox.Name = "Nb_paymentsTextBox"
        Me.Nb_paymentsTextBox.Size = New System.Drawing.Size(200, 21)
        Me.Nb_paymentsTextBox.TabIndex = 21
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Red
        Me.Button1.Location = New System.Drawing.Point(12, 28)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "Search"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frm_session
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(488, 198)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Ses_codLabel)
        Me.Controls.Add(Me.Ses_codTextBox)
        Me.Controls.Add(Ses_dateLabel)
        Me.Controls.Add(Me.Ses_dateDateTimePicker)
        Me.Controls.Add(Cred_valueLabel)
        Me.Controls.Add(Me.Cred_valueTextBox)
        Me.Controls.Add(Accepted_y_n_Label)
        Me.Controls.Add(Me.Accepted_y_n_CheckBox)
        Me.Controls.Add(Nb_paymentsLabel)
        Me.Controls.Add(Me.Nb_paymentsTextBox)
        Me.Controls.Add(Me.SesionBindingNavigator)
        Me.Controls.Add(Label1)
        Me.Name = "frm_session"
        Me.Text = "Session"
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SesionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SesionBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SesionBindingNavigator.ResumeLayout(False)
        Me.SesionBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DatabaseDataSet As credit_project.DatabaseDataSet
    Friend WithEvents SesionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SesionTableAdapter As credit_project.DatabaseDataSetTableAdapters.sesionTableAdapter
    Friend WithEvents TableAdapterManager As credit_project.DatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents SesionBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents SesionBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Ses_codTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Ses_dateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Cred_valueTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Accepted_y_n_CheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Nb_paymentsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
