<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_borrower
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
        Dim P_idLabel As System.Windows.Forms.Label
        Dim First_nameLabel As System.Windows.Forms.Label
        Dim Middle_nameLabel As System.Windows.Forms.Label
        Dim Last_nameLabel As System.Windows.Forms.Label
        Dim Mother_nameLabel As System.Windows.Forms.Label
        Dim Date_of_birthLabel As System.Windows.Forms.Label
        Dim GenderLabel As System.Windows.Forms.Label
        Dim Number_of__childrenLabel As System.Windows.Forms.Label
        Dim Record_numLabel As System.Windows.Forms.Label
        Dim Mob_phoneLabel As System.Windows.Forms.Label
        Dim Home_phoneLabel As System.Windows.Forms.Label
        Dim Fs_idLabel As System.Windows.Forms.Label
        Dim Tow_num_b_Label As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Me.DatabaseDataSet = New credit_project.DatabaseDataSet()
        Me.PersonBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PersonTableAdapter = New credit_project.DatabaseDataSetTableAdapters.PersonTableAdapter()
        Me.TableAdapterManager = New credit_project.DatabaseDataSetTableAdapters.TableAdapterManager()
        Me.P_idTextBox = New System.Windows.Forms.TextBox()
        Me.First_nameTextBox = New System.Windows.Forms.TextBox()
        Me.Middle_nameTextBox = New System.Windows.Forms.TextBox()
        Me.Last_nameTextBox = New System.Windows.Forms.TextBox()
        Me.Mother_nameTextBox = New System.Windows.Forms.TextBox()
        Me.Date_of_birthDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.GenderTextBox = New System.Windows.Forms.TextBox()
        Me.Number_of__childrenTextBox = New System.Windows.Forms.TextBox()
        Me.Record_numTextBox = New System.Windows.Forms.TextBox()
        Me.Mob_phoneTextBox = New System.Windows.Forms.TextBox()
        Me.Home_phoneTextBox = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.FamilystatusBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Family_statusTableAdapter = New credit_project.DatabaseDataSetTableAdapters.Family_statusTableAdapter()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.TownBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TownTableAdapter = New credit_project.DatabaseDataSetTableAdapters.TownTableAdapter()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.BuildingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BuildingTableAdapter = New credit_project.DatabaseDataSetTableAdapters.BuildingTableAdapter()
        Me.SecondaddressBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Second_addressTableAdapter = New credit_project.DatabaseDataSetTableAdapters.Second_addressTableAdapter()
        Me.grp_choose = New System.Windows.Forms.GroupBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.chk_gua = New System.Windows.Forms.RadioButton()
        Me.chk_bor = New System.Windows.Forms.RadioButton()
        Me.BorrowerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btn_add = New System.Windows.Forms.Button()
        Me.btn_Edit = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_First = New System.Windows.Forms.Button()
        Me.btn_priv = New System.Windows.Forms.Button()
        Me.btn_next = New System.Windows.Forms.Button()
        Me.btn_last = New System.Windows.Forms.Button()
        Me.GuranterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GuranterTableAdapter = New credit_project.DatabaseDataSetTableAdapters.GuranterTableAdapter()
        Me.BorrowerTableAdapter = New credit_project.DatabaseDataSetTableAdapters.BorrowerTableAdapter()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txt_search = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        P_idLabel = New System.Windows.Forms.Label()
        First_nameLabel = New System.Windows.Forms.Label()
        Middle_nameLabel = New System.Windows.Forms.Label()
        Last_nameLabel = New System.Windows.Forms.Label()
        Mother_nameLabel = New System.Windows.Forms.Label()
        Date_of_birthLabel = New System.Windows.Forms.Label()
        GenderLabel = New System.Windows.Forms.Label()
        Number_of__childrenLabel = New System.Windows.Forms.Label()
        Record_numLabel = New System.Windows.Forms.Label()
        Mob_phoneLabel = New System.Windows.Forms.Label()
        Home_phoneLabel = New System.Windows.Forms.Label()
        Fs_idLabel = New System.Windows.Forms.Label()
        Tow_num_b_Label = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PersonBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FamilystatusBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TownBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuildingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SecondaddressBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_choose.SuspendLayout()
        CType(Me.BorrowerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GuranterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'P_idLabel
        '
        P_idLabel.AutoSize = True
        P_idLabel.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        P_idLabel.Location = New System.Drawing.Point(157, 55)
        P_idLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        P_idLabel.Name = "P_idLabel"
        P_idLabel.Size = New System.Drawing.Size(75, 13)
        P_idLabel.TabIndex = 1
        P_idLabel.Text = "Person ID:"
        '
        'First_nameLabel
        '
        First_nameLabel.AutoSize = True
        First_nameLabel.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        First_nameLabel.Location = New System.Drawing.Point(44, 97)
        First_nameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        First_nameLabel.Name = "First_nameLabel"
        First_nameLabel.Size = New System.Drawing.Size(81, 13)
        First_nameLabel.TabIndex = 3
        First_nameLabel.Text = "First name:"
        '
        'Middle_nameLabel
        '
        Middle_nameLabel.AutoSize = True
        Middle_nameLabel.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Middle_nameLabel.Location = New System.Drawing.Point(44, 123)
        Middle_nameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Middle_nameLabel.Name = "Middle_nameLabel"
        Middle_nameLabel.Size = New System.Drawing.Size(93, 13)
        Middle_nameLabel.TabIndex = 5
        Middle_nameLabel.Text = "Middle name:"
        '
        'Last_nameLabel
        '
        Last_nameLabel.AutoSize = True
        Last_nameLabel.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Last_nameLabel.Location = New System.Drawing.Point(44, 149)
        Last_nameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Last_nameLabel.Name = "Last_nameLabel"
        Last_nameLabel.Size = New System.Drawing.Size(78, 13)
        Last_nameLabel.TabIndex = 7
        Last_nameLabel.Text = "Last name:"
        '
        'Mother_nameLabel
        '
        Mother_nameLabel.AutoSize = True
        Mother_nameLabel.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Mother_nameLabel.Location = New System.Drawing.Point(44, 175)
        Mother_nameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Mother_nameLabel.Name = "Mother_nameLabel"
        Mother_nameLabel.Size = New System.Drawing.Size(96, 13)
        Mother_nameLabel.TabIndex = 9
        Mother_nameLabel.Text = "Mother name:"
        '
        'Date_of_birthLabel
        '
        Date_of_birthLabel.AutoSize = True
        Date_of_birthLabel.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Date_of_birthLabel.Location = New System.Drawing.Point(454, 56)
        Date_of_birthLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Date_of_birthLabel.Name = "Date_of_birthLabel"
        Date_of_birthLabel.Size = New System.Drawing.Size(93, 13)
        Date_of_birthLabel.TabIndex = 11
        Date_of_birthLabel.Text = "Date of birth:"
        '
        'GenderLabel
        '
        GenderLabel.AutoSize = True
        GenderLabel.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        GenderLabel.Location = New System.Drawing.Point(44, 202)
        GenderLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        GenderLabel.Name = "GenderLabel"
        GenderLabel.Size = New System.Drawing.Size(58, 13)
        GenderLabel.TabIndex = 13
        GenderLabel.Text = "Gender:"
        '
        'Number_of__childrenLabel
        '
        Number_of__childrenLabel.AutoSize = True
        Number_of__childrenLabel.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Number_of__childrenLabel.Location = New System.Drawing.Point(44, 228)
        Number_of__childrenLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Number_of__childrenLabel.Name = "Number_of__childrenLabel"
        Number_of__childrenLabel.Size = New System.Drawing.Size(140, 13)
        Number_of__childrenLabel.TabIndex = 15
        Number_of__childrenLabel.Text = "Number of  children:"
        '
        'Record_numLabel
        '
        Record_numLabel.AutoSize = True
        Record_numLabel.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Record_numLabel.Location = New System.Drawing.Point(44, 254)
        Record_numLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Record_numLabel.Name = "Record_numLabel"
        Record_numLabel.Size = New System.Drawing.Size(88, 13)
        Record_numLabel.TabIndex = 17
        Record_numLabel.Text = "Record num:"
        '
        'Mob_phoneLabel
        '
        Mob_phoneLabel.AutoSize = True
        Mob_phoneLabel.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Mob_phoneLabel.Location = New System.Drawing.Point(44, 280)
        Mob_phoneLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Mob_phoneLabel.Name = "Mob_phoneLabel"
        Mob_phoneLabel.Size = New System.Drawing.Size(81, 13)
        Mob_phoneLabel.TabIndex = 19
        Mob_phoneLabel.Text = "Mob phone:"
        '
        'Home_phoneLabel
        '
        Home_phoneLabel.AutoSize = True
        Home_phoneLabel.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Home_phoneLabel.Location = New System.Drawing.Point(44, 306)
        Home_phoneLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Home_phoneLabel.Name = "Home_phoneLabel"
        Home_phoneLabel.Size = New System.Drawing.Size(92, 13)
        Home_phoneLabel.TabIndex = 21
        Home_phoneLabel.Text = "Home phone:"
        '
        'Fs_idLabel
        '
        Fs_idLabel.AutoSize = True
        Fs_idLabel.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Fs_idLabel.Location = New System.Drawing.Point(515, 135)
        Fs_idLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Fs_idLabel.Name = "Fs_idLabel"
        Fs_idLabel.Size = New System.Drawing.Size(100, 13)
        Fs_idLabel.TabIndex = 23
        Fs_idLabel.Text = "Family Status:"
        '
        'Tow_num_b_Label
        '
        Tow_num_b_Label.AutoSize = True
        Tow_num_b_Label.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Tow_num_b_Label.Location = New System.Drawing.Point(515, 166)
        Tow_num_b_Label.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Tow_num_b_Label.Name = "Tow_num_b_Label"
        Tow_num_b_Label.Size = New System.Drawing.Size(99, 13)
        Tow_num_b_Label.TabIndex = 25
        Tow_num_b_Label.Text = "Place Of Birth:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Perpetua Titling MT", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.Location = New System.Drawing.Point(384, 16)
        Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(100, 26)
        Label1.TabIndex = 33
        Label1.Text = "PERSON"
        AddHandler Label1.Click, AddressOf Me.Label1_Click
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label2.Location = New System.Drawing.Point(515, 193)
        Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(113, 13)
        Label2.TabIndex = 36
        Label2.Text = "Place Of Record:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label3.Location = New System.Drawing.Point(515, 220)
        Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(120, 13)
        Label3.TabIndex = 38
        Label3.Text = "Primary Address:"
        '
        'DatabaseDataSet
        '
        Me.DatabaseDataSet.DataSetName = "DatabaseDataSet"
        Me.DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PersonBindingSource
        '
        Me.PersonBindingSource.DataMember = "Person"
        Me.PersonBindingSource.DataSource = Me.DatabaseDataSet
        '
        'PersonTableAdapter
        '
        Me.PersonTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.PersonTableAdapter = Me.PersonTableAdapter
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
        'P_idTextBox
        '
        Me.P_idTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonBindingSource, "P_id", True))
        Me.P_idTextBox.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.P_idTextBox.Location = New System.Drawing.Point(261, 52)
        Me.P_idTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.P_idTextBox.Name = "P_idTextBox"
        Me.P_idTextBox.Size = New System.Drawing.Size(127, 21)
        Me.P_idTextBox.TabIndex = 2
        '
        'First_nameTextBox
        '
        Me.First_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonBindingSource, "First_name", True))
        Me.First_nameTextBox.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.First_nameTextBox.Location = New System.Drawing.Point(191, 94)
        Me.First_nameTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.First_nameTextBox.Name = "First_nameTextBox"
        Me.First_nameTextBox.Size = New System.Drawing.Size(129, 21)
        Me.First_nameTextBox.TabIndex = 4
        '
        'Middle_nameTextBox
        '
        Me.Middle_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonBindingSource, "Middle_name", True))
        Me.Middle_nameTextBox.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Middle_nameTextBox.Location = New System.Drawing.Point(191, 120)
        Me.Middle_nameTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Middle_nameTextBox.Name = "Middle_nameTextBox"
        Me.Middle_nameTextBox.Size = New System.Drawing.Size(129, 21)
        Me.Middle_nameTextBox.TabIndex = 6
        '
        'Last_nameTextBox
        '
        Me.Last_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonBindingSource, "Last_name", True))
        Me.Last_nameTextBox.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Last_nameTextBox.Location = New System.Drawing.Point(191, 146)
        Me.Last_nameTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Last_nameTextBox.Name = "Last_nameTextBox"
        Me.Last_nameTextBox.Size = New System.Drawing.Size(129, 21)
        Me.Last_nameTextBox.TabIndex = 8
        '
        'Mother_nameTextBox
        '
        Me.Mother_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonBindingSource, "Mother_name", True))
        Me.Mother_nameTextBox.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mother_nameTextBox.Location = New System.Drawing.Point(191, 172)
        Me.Mother_nameTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Mother_nameTextBox.Name = "Mother_nameTextBox"
        Me.Mother_nameTextBox.Size = New System.Drawing.Size(129, 21)
        Me.Mother_nameTextBox.TabIndex = 10
        '
        'Date_of_birthDateTimePicker
        '
        Me.Date_of_birthDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PersonBindingSource, "Date_of_birth", True))
        Me.Date_of_birthDateTimePicker.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Date_of_birthDateTimePicker.Location = New System.Drawing.Point(578, 52)
        Me.Date_of_birthDateTimePicker.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Date_of_birthDateTimePicker.Name = "Date_of_birthDateTimePicker"
        Me.Date_of_birthDateTimePicker.Size = New System.Drawing.Size(288, 21)
        Me.Date_of_birthDateTimePicker.TabIndex = 12
        '
        'GenderTextBox
        '
        Me.GenderTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonBindingSource, "Gender", True))
        Me.GenderTextBox.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GenderTextBox.Location = New System.Drawing.Point(191, 199)
        Me.GenderTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GenderTextBox.Name = "GenderTextBox"
        Me.GenderTextBox.Size = New System.Drawing.Size(129, 21)
        Me.GenderTextBox.TabIndex = 14
        '
        'Number_of__childrenTextBox
        '
        Me.Number_of__childrenTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonBindingSource, "Number_of_ children", True))
        Me.Number_of__childrenTextBox.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Number_of__childrenTextBox.Location = New System.Drawing.Point(191, 225)
        Me.Number_of__childrenTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Number_of__childrenTextBox.Name = "Number_of__childrenTextBox"
        Me.Number_of__childrenTextBox.Size = New System.Drawing.Size(129, 21)
        Me.Number_of__childrenTextBox.TabIndex = 16
        '
        'Record_numTextBox
        '
        Me.Record_numTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonBindingSource, "Record_num", True))
        Me.Record_numTextBox.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Record_numTextBox.Location = New System.Drawing.Point(191, 251)
        Me.Record_numTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Record_numTextBox.Name = "Record_numTextBox"
        Me.Record_numTextBox.Size = New System.Drawing.Size(129, 21)
        Me.Record_numTextBox.TabIndex = 18
        '
        'Mob_phoneTextBox
        '
        Me.Mob_phoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonBindingSource, "Mob_phone", True))
        Me.Mob_phoneTextBox.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mob_phoneTextBox.Location = New System.Drawing.Point(191, 277)
        Me.Mob_phoneTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Mob_phoneTextBox.Name = "Mob_phoneTextBox"
        Me.Mob_phoneTextBox.Size = New System.Drawing.Size(129, 21)
        Me.Mob_phoneTextBox.TabIndex = 20
        '
        'Home_phoneTextBox
        '
        Me.Home_phoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonBindingSource, "Home_phone", True))
        Me.Home_phoneTextBox.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Home_phoneTextBox.Location = New System.Drawing.Point(191, 303)
        Me.Home_phoneTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Home_phoneTextBox.Name = "Home_phoneTextBox"
        Me.Home_phoneTextBox.Size = New System.Drawing.Size(129, 21)
        Me.Home_phoneTextBox.TabIndex = 22
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.PersonBindingSource, "Fs_id", True))
        Me.ComboBox1.DataSource = Me.FamilystatusBindingSource
        Me.ComboBox1.DisplayMember = "Fs_des"
        Me.ComboBox1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(639, 132)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(112, 21)
        Me.ComboBox1.TabIndex = 34
        Me.ComboBox1.ValueMember = "Fs_id"
        '
        'FamilystatusBindingSource
        '
        Me.FamilystatusBindingSource.DataMember = "Family_status"
        Me.FamilystatusBindingSource.DataSource = Me.DatabaseDataSet
        '
        'Family_statusTableAdapter
        '
        Me.Family_statusTableAdapter.ClearBeforeFill = True
        '
        'ComboBox2
        '
        Me.ComboBox2.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.PersonBindingSource, "Tow_num(b)", True))
        Me.ComboBox2.DataSource = Me.TownBindingSource
        Me.ComboBox2.DisplayMember = "Tow_name"
        Me.ComboBox2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(639, 163)
        Me.ComboBox2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(112, 21)
        Me.ComboBox2.TabIndex = 35
        Me.ComboBox2.ValueMember = "Tow_num"
        '
        'TownBindingSource
        '
        Me.TownBindingSource.DataMember = "Town"
        Me.TownBindingSource.DataSource = Me.DatabaseDataSet
        '
        'TownTableAdapter
        '
        Me.TownTableAdapter.ClearBeforeFill = True
        '
        'ComboBox3
        '
        Me.ComboBox3.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.PersonBindingSource, "Tow_num(r)", True))
        Me.ComboBox3.DataSource = Me.TownBindingSource
        Me.ComboBox3.DisplayMember = "Tow_name"
        Me.ComboBox3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(639, 190)
        Me.ComboBox3.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(112, 21)
        Me.ComboBox3.TabIndex = 37
        Me.ComboBox3.ValueMember = "Tow_num"
        '
        'ComboBox4
        '
        Me.ComboBox4.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.PersonBindingSource, "Buil_num(r)", True))
        Me.ComboBox4.DataSource = Me.BuildingBindingSource
        Me.ComboBox4.DisplayMember = "Buil_name"
        Me.ComboBox4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Location = New System.Drawing.Point(639, 217)
        Me.ComboBox4.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(112, 21)
        Me.ComboBox4.TabIndex = 39
        Me.ComboBox4.ValueMember = "Buil_num"
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
        'SecondaddressBindingSource
        '
        Me.SecondaddressBindingSource.DataMember = "Second_address"
        Me.SecondaddressBindingSource.DataSource = Me.DatabaseDataSet
        '
        'Second_addressTableAdapter
        '
        Me.Second_addressTableAdapter.ClearBeforeFill = True
        '
        'grp_choose
        '
        Me.grp_choose.Controls.Add(Me.Button5)
        Me.grp_choose.Controls.Add(Me.chk_gua)
        Me.grp_choose.Controls.Add(Me.chk_bor)
        Me.grp_choose.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grp_choose.Location = New System.Drawing.Point(346, 122)
        Me.grp_choose.Name = "grp_choose"
        Me.grp_choose.Size = New System.Drawing.Size(147, 79)
        Me.grp_choose.TabIndex = 78
        Me.grp_choose.TabStop = False
        '
        'Button5
        '
        Me.Button5.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Button5.Location = New System.Drawing.Point(11, 27)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(127, 22)
        Me.Button5.TabIndex = 93
        Me.Button5.Text = "Detailed Info"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'chk_gua
        '
        Me.chk_gua.AutoSize = True
        Me.chk_gua.Location = New System.Drawing.Point(11, 55)
        Me.chk_gua.Name = "chk_gua"
        Me.chk_gua.Size = New System.Drawing.Size(83, 17)
        Me.chk_gua.TabIndex = 71
        Me.chk_gua.TabStop = True
        Me.chk_gua.Text = "Guranter"
        Me.chk_gua.UseVisualStyleBackColor = True
        '
        'chk_bor
        '
        Me.chk_bor.AutoSize = True
        Me.chk_bor.Location = New System.Drawing.Point(9, 8)
        Me.chk_bor.Name = "chk_bor"
        Me.chk_bor.Size = New System.Drawing.Size(85, 17)
        Me.chk_bor.TabIndex = 70
        Me.chk_bor.TabStop = True
        Me.chk_bor.Text = "Borrower"
        Me.chk_bor.UseVisualStyleBackColor = True
        '
        'BorrowerBindingSource
        '
        Me.BorrowerBindingSource.DataMember = "Borrower"
        Me.BorrowerBindingSource.DataSource = Me.DatabaseDataSet
        '
        'btn_add
        '
        Me.btn_add.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_add.ForeColor = System.Drawing.Color.Red
        Me.btn_add.Location = New System.Drawing.Point(418, 215)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(75, 55)
        Me.btn_add.TabIndex = 77
        Me.btn_add.Text = "Add"
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'btn_Edit
        '
        Me.btn_Edit.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Edit.ForeColor = System.Drawing.Color.Red
        Me.btn_Edit.Location = New System.Drawing.Point(337, 282)
        Me.btn_Edit.Name = "btn_Edit"
        Me.btn_Edit.Size = New System.Drawing.Size(156, 55)
        Me.btn_Edit.TabIndex = 76
        Me.btn_Edit.Text = "Edit"
        Me.btn_Edit.UseVisualStyleBackColor = True
        '
        'btn_delete
        '
        Me.btn_delete.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.ForeColor = System.Drawing.Color.Red
        Me.btn_delete.Location = New System.Drawing.Point(337, 215)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(75, 55)
        Me.btn_delete.TabIndex = 75
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'btn_First
        '
        Me.btn_First.ForeColor = System.Drawing.Color.Green
        Me.btn_First.Location = New System.Drawing.Point(499, 277)
        Me.btn_First.Name = "btn_First"
        Me.btn_First.Size = New System.Drawing.Size(75, 23)
        Me.btn_First.TabIndex = 82
        Me.btn_First.Text = "First"
        Me.btn_First.UseVisualStyleBackColor = True
        '
        'btn_priv
        '
        Me.btn_priv.ForeColor = System.Drawing.Color.Green
        Me.btn_priv.Location = New System.Drawing.Point(580, 277)
        Me.btn_priv.Name = "btn_priv"
        Me.btn_priv.Size = New System.Drawing.Size(87, 23)
        Me.btn_priv.TabIndex = 81
        Me.btn_priv.Text = "Previus"
        Me.btn_priv.UseVisualStyleBackColor = True
        '
        'btn_next
        '
        Me.btn_next.ForeColor = System.Drawing.Color.Green
        Me.btn_next.Location = New System.Drawing.Point(676, 277)
        Me.btn_next.Name = "btn_next"
        Me.btn_next.Size = New System.Drawing.Size(75, 23)
        Me.btn_next.TabIndex = 80
        Me.btn_next.Text = "Next"
        Me.btn_next.UseVisualStyleBackColor = True
        '
        'btn_last
        '
        Me.btn_last.ForeColor = System.Drawing.Color.Green
        Me.btn_last.Location = New System.Drawing.Point(757, 277)
        Me.btn_last.Name = "btn_last"
        Me.btn_last.Size = New System.Drawing.Size(88, 23)
        Me.btn_last.TabIndex = 79
        Me.btn_last.Text = "Last"
        Me.btn_last.UseVisualStyleBackColor = True
        '
        'GuranterBindingSource
        '
        Me.GuranterBindingSource.DataMember = "Guranter"
        Me.GuranterBindingSource.DataSource = Me.DatabaseDataSet
        '
        'GuranterTableAdapter
        '
        Me.GuranterTableAdapter.ClearBeforeFill = True
        '
        'BorrowerTableAdapter
        '
        Me.BorrowerTableAdapter.ClearBeforeFill = True
        '
        'Button2
        '
        Me.Button2.ForeColor = System.Drawing.Color.Crimson
        Me.Button2.Location = New System.Drawing.Point(11, 31)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 21)
        Me.Button2.TabIndex = 85
        Me.Button2.Text = "Search"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(770, 149)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 48)
        Me.Button3.TabIndex = 86
        Me.Button3.Text = "New Twon"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(770, 204)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 37)
        Me.Button4.TabIndex = 87
        Me.Button4.Text = "New Building"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(343, 94)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(145, 13)
        Me.Label7.TabIndex = 90
        Me.Label7.Text = "*Please Choose Type"
        Me.Label7.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(382, 114)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 13)
        Me.Label8.TabIndex = 91
        Me.Label8.Text = "of Person:"
        Me.Label8.Visible = False
        '
        'Button1
        '
        Me.Button1.ForeColor = System.Drawing.Color.Blue
        Me.Button1.Location = New System.Drawing.Point(499, 309)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(346, 28)
        Me.Button1.TabIndex = 83
        Me.Button1.Text = "More Details for Borrower"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txt_search
        '
        Me.txt_search.Location = New System.Drawing.Point(92, 31)
        Me.txt_search.Name = "txt_search"
        Me.txt_search.Size = New System.Drawing.Size(74, 21)
        Me.txt_search.TabIndex = 92
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(10, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(156, 13)
        Me.Label5.TabIndex = 93
        Me.Label5.Text = "* Search By Person ID:"
        '
        'frm_borrower
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(886, 361)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_search)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btn_First)
        Me.Controls.Add(Me.btn_priv)
        Me.Controls.Add(Me.btn_next)
        Me.Controls.Add(Me.btn_last)
        Me.Controls.Add(Me.grp_choose)
        Me.Controls.Add(Me.btn_add)
        Me.Controls.Add(Me.btn_Edit)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.ComboBox4)
        Me.Controls.Add(Label3)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Label1)
        Me.Controls.Add(P_idLabel)
        Me.Controls.Add(Me.P_idTextBox)
        Me.Controls.Add(First_nameLabel)
        Me.Controls.Add(Me.First_nameTextBox)
        Me.Controls.Add(Middle_nameLabel)
        Me.Controls.Add(Me.Middle_nameTextBox)
        Me.Controls.Add(Last_nameLabel)
        Me.Controls.Add(Me.Last_nameTextBox)
        Me.Controls.Add(Mother_nameLabel)
        Me.Controls.Add(Me.Mother_nameTextBox)
        Me.Controls.Add(Date_of_birthLabel)
        Me.Controls.Add(Me.Date_of_birthDateTimePicker)
        Me.Controls.Add(GenderLabel)
        Me.Controls.Add(Me.GenderTextBox)
        Me.Controls.Add(Number_of__childrenLabel)
        Me.Controls.Add(Me.Number_of__childrenTextBox)
        Me.Controls.Add(Record_numLabel)
        Me.Controls.Add(Me.Record_numTextBox)
        Me.Controls.Add(Mob_phoneLabel)
        Me.Controls.Add(Me.Mob_phoneTextBox)
        Me.Controls.Add(Home_phoneLabel)
        Me.Controls.Add(Me.Home_phoneTextBox)
        Me.Controls.Add(Fs_idLabel)
        Me.Controls.Add(Tow_num_b_Label)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "frm_borrower"
        Me.Text = "Person"
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PersonBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FamilystatusBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TownBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuildingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SecondaddressBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_choose.ResumeLayout(False)
        Me.grp_choose.PerformLayout()
        CType(Me.BorrowerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GuranterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DatabaseDataSet As credit_project.DatabaseDataSet
    Friend WithEvents PersonBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PersonTableAdapter As credit_project.DatabaseDataSetTableAdapters.PersonTableAdapter
    Friend WithEvents TableAdapterManager As credit_project.DatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents P_idTextBox As System.Windows.Forms.TextBox
    Friend WithEvents First_nameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Middle_nameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Last_nameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Mother_nameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Date_of_birthDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents GenderTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Number_of__childrenTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Record_numTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Mob_phoneTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Home_phoneTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents FamilystatusBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Family_statusTableAdapter As credit_project.DatabaseDataSetTableAdapters.Family_statusTableAdapter
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents TownBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TownTableAdapter As credit_project.DatabaseDataSetTableAdapters.TownTableAdapter
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox4 As System.Windows.Forms.ComboBox
    Friend WithEvents BuildingBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BuildingTableAdapter As credit_project.DatabaseDataSetTableAdapters.BuildingTableAdapter
    Friend WithEvents SecondaddressBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Second_addressTableAdapter As credit_project.DatabaseDataSetTableAdapters.Second_addressTableAdapter
    Friend WithEvents grp_choose As System.Windows.Forms.GroupBox
    Friend WithEvents btn_add As System.Windows.Forms.Button
    Friend WithEvents btn_Edit As System.Windows.Forms.Button
    Friend WithEvents btn_delete As System.Windows.Forms.Button
    Friend WithEvents btn_First As System.Windows.Forms.Button
    Friend WithEvents btn_priv As System.Windows.Forms.Button
    Friend WithEvents btn_next As System.Windows.Forms.Button
    Friend WithEvents btn_last As System.Windows.Forms.Button
    Friend WithEvents GuranterBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GuranterTableAdapter As credit_project.DatabaseDataSetTableAdapters.GuranterTableAdapter
    Friend WithEvents BorrowerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BorrowerTableAdapter As credit_project.DatabaseDataSetTableAdapters.BorrowerTableAdapter
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents chk_gua As System.Windows.Forms.RadioButton
    Friend WithEvents chk_bor As System.Windows.Forms.RadioButton
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txt_search As System.Windows.Forms.TextBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
