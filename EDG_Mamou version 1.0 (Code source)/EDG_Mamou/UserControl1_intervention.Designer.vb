<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl1_intervention
    Inherits System.Windows.Forms.UserControl

    'UserControl remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btn_sup = New System.Windows.Forms.Button()
        Me.txtMatricule = New System.Windows.Forms.ComboBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.cbxnature_recher = New System.Windows.Forms.ComboBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.txt_recherche_paie = New System.Windows.Forms.TextBox()
        Me.Cmb_recherche = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btn_recherche = New System.Windows.Forms.Button()
        Me.cmb_nature = New System.Windows.Forms.ComboBox()
        Me.cmb_bat = New System.Windows.Forms.ComboBox()
        Me.dtpDateDebut = New System.Windows.Forms.DateTimePicker()
        Me.txtFrais = New System.Windows.Forms.TextBox()
        Me.lblfrais = New System.Windows.Forms.Label()
        Me.btnModifier_interven = New System.Windows.Forms.Button()
        Me.btn_Imp_Indivi = New System.Windows.Forms.Button()
        Me.btnEnregistrer_interven = New System.Windows.Forms.Button()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.dgvInterv = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.dgvInterv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Green
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1156, 34)
        Me.Panel1.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Green
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Yellow
        Me.Label3.Location = New System.Drawing.Point(377, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(779, 34)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Liste des interventions"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Green
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Yellow
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(377, 34)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Interventions"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Green
        Me.Panel2.Controls.Add(Me.Label17)
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Controls.Add(Me.Label18)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.btn_sup)
        Me.Panel2.Controls.Add(Me.txtMatricule)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.cmb_nature)
        Me.Panel2.Controls.Add(Me.cmb_bat)
        Me.Panel2.Controls.Add(Me.dtpDateDebut)
        Me.Panel2.Controls.Add(Me.txtFrais)
        Me.Panel2.Controls.Add(Me.lblfrais)
        Me.Panel2.Controls.Add(Me.btnModifier_interven)
        Me.Panel2.Controls.Add(Me.btn_Imp_Indivi)
        Me.Panel2.Controls.Add(Me.btnEnregistrer_interven)
        Me.Panel2.Controls.Add(Me.Label21)
        Me.Panel2.Controls.Add(Me.Label23)
        Me.Panel2.Controls.Add(Me.Label24)
        Me.Panel2.Controls.Add(Me.Label27)
        Me.Panel2.Controls.Add(Me.txtNumero)
        Me.Panel2.Controls.Add(Me.Label28)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 34)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(347, 451)
        Me.Panel2.TabIndex = 1
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Yellow
        Me.Label17.Location = New System.Drawing.Point(63, 290)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(58, 15)
        Me.Label17.TabIndex = 88
        Me.Label17.Text = "Modifier"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Yellow
        Me.Label14.Location = New System.Drawing.Point(2, 290)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(52, 15)
        Me.Label14.TabIndex = 87
        Me.Label14.Text = "Ajouter"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Yellow
        Me.Label18.Location = New System.Drawing.Point(274, 291)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(73, 15)
        Me.Label18.TabIndex = 86
        Me.Label18.Text = "Supprimer"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Yellow
        Me.Label5.Location = New System.Drawing.Point(209, 291)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 15)
        Me.Label5.TabIndex = 85
        Me.Label5.Text = "Collective"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(130, 291)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 15)
        Me.Label1.TabIndex = 84
        Me.Label1.Text = "Individuelle"
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.EDG_Mamou.My.Resources.Resources.printmgr
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(216, 242)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(47, 45)
        Me.Button1.TabIndex = 83
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btn_sup
        '
        Me.btn_sup.BackgroundImage = Global.EDG_Mamou.My.Resources.Resources.button_cancel
        Me.btn_sup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_sup.Location = New System.Drawing.Point(288, 243)
        Me.btn_sup.Name = "btn_sup"
        Me.btn_sup.Size = New System.Drawing.Size(53, 45)
        Me.btn_sup.TabIndex = 82
        Me.btn_sup.UseVisualStyleBackColor = True
        '
        'txtMatricule
        '
        Me.txtMatricule.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMatricule.FormattingEnabled = True
        Me.txtMatricule.Location = New System.Drawing.Point(116, 41)
        Me.txtMatricule.Name = "txtMatricule"
        Me.txtMatricule.Size = New System.Drawing.Size(220, 27)
        Me.txtMatricule.TabIndex = 81
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Green
        Me.Panel4.Controls.Add(Me.cbxnature_recher)
        Me.Panel4.Controls.Add(Me.DateTimePicker1)
        Me.Panel4.Controls.Add(Me.txt_recherche_paie)
        Me.Panel4.Controls.Add(Me.Cmb_recherche)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.Label7)
        Me.Panel4.Controls.Add(Me.btn_recherche)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 328)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(347, 123)
        Me.Panel4.TabIndex = 80
        '
        'cbxnature_recher
        '
        Me.cbxnature_recher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxnature_recher.FormattingEnabled = True
        Me.cbxnature_recher.Items.AddRange(New Object() {"Coupure", "Retablissement"})
        Me.cbxnature_recher.Location = New System.Drawing.Point(18, 76)
        Me.cbxnature_recher.Name = "cbxnature_recher"
        Me.cbxnature_recher.Size = New System.Drawing.Size(146, 21)
        Me.cbxnature_recher.TabIndex = 8
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(18, 79)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(225, 20)
        Me.DateTimePicker1.TabIndex = 7
        '
        'txt_recherche_paie
        '
        Me.txt_recherche_paie.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txt_recherche_paie.Location = New System.Drawing.Point(16, 76)
        Me.txt_recherche_paie.Name = "txt_recherche_paie"
        Me.txt_recherche_paie.Size = New System.Drawing.Size(274, 26)
        Me.txt_recherche_paie.TabIndex = 6
        '
        'Cmb_recherche
        '
        Me.Cmb_recherche.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmb_recherche.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmb_recherche.FormattingEnabled = True
        Me.Cmb_recherche.Items.AddRange(New Object() {"Numéro", "Nature", "Date Debut", "Date Fin"})
        Me.Cmb_recherche.Location = New System.Drawing.Point(125, 40)
        Me.Cmb_recherche.Name = "Cmb_recherche"
        Me.Cmb_recherche.Size = New System.Drawing.Size(205, 28)
        Me.Cmb_recherche.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 23)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "rechercher par:"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Green
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label7.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Yellow
        Me.Label7.Location = New System.Drawing.Point(0, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(347, 32)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Rechercher"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_recherche
        '
        Me.btn_recherche.BackgroundImage = Global.EDG_Mamou.My.Resources.Resources.kghostview
        Me.btn_recherche.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_recherche.Location = New System.Drawing.Point(291, 72)
        Me.btn_recherche.Name = "btn_recherche"
        Me.btn_recherche.Size = New System.Drawing.Size(45, 39)
        Me.btn_recherche.TabIndex = 1
        Me.btn_recherche.UseVisualStyleBackColor = True
        '
        'cmb_nature
        '
        Me.cmb_nature.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_nature.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_nature.FormattingEnabled = True
        Me.cmb_nature.Items.AddRange(New Object() {"Coupure", "Retablissement"})
        Me.cmb_nature.Location = New System.Drawing.Point(115, 128)
        Me.cmb_nature.Name = "cmb_nature"
        Me.cmb_nature.Size = New System.Drawing.Size(220, 27)
        Me.cmb_nature.TabIndex = 79
        '
        'cmb_bat
        '
        Me.cmb_bat.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_bat.FormattingEnabled = True
        Me.cmb_bat.Location = New System.Drawing.Point(115, 85)
        Me.cmb_bat.Name = "cmb_bat"
        Me.cmb_bat.Size = New System.Drawing.Size(220, 27)
        Me.cmb_bat.TabIndex = 78
        '
        'dtpDateDebut
        '
        Me.dtpDateDebut.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDateDebut.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDateDebut.Location = New System.Drawing.Point(116, 173)
        Me.dtpDateDebut.Name = "dtpDateDebut"
        Me.dtpDateDebut.Size = New System.Drawing.Size(219, 26)
        Me.dtpDateDebut.TabIndex = 73
        '
        'txtFrais
        '
        Me.txtFrais.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFrais.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFrais.Location = New System.Drawing.Point(116, 214)
        Me.txtFrais.Name = "txtFrais"
        Me.txtFrais.Size = New System.Drawing.Size(220, 26)
        Me.txtFrais.TabIndex = 71
        Me.txtFrais.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblfrais
        '
        Me.lblfrais.AutoSize = True
        Me.lblfrais.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfrais.ForeColor = System.Drawing.Color.Yellow
        Me.lblfrais.Location = New System.Drawing.Point(14, 217)
        Me.lblfrais.Name = "lblfrais"
        Me.lblfrais.Size = New System.Drawing.Size(53, 22)
        Me.lblfrais.TabIndex = 72
        Me.lblfrais.Text = "Frais"
        '
        'btnModifier_interven
        '
        Me.btnModifier_interven.BackgroundImage = Global.EDG_Mamou.My.Resources.Resources.kate
        Me.btnModifier_interven.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnModifier_interven.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModifier_interven.Location = New System.Drawing.Point(67, 242)
        Me.btnModifier_interven.Name = "btnModifier_interven"
        Me.btnModifier_interven.Size = New System.Drawing.Size(58, 45)
        Me.btnModifier_interven.TabIndex = 63
        Me.btnModifier_interven.UseVisualStyleBackColor = True
        '
        'btn_Imp_Indivi
        '
        Me.btn_Imp_Indivi.BackgroundImage = Global.EDG_Mamou.My.Resources.Resources.printmgr
        Me.btn_Imp_Indivi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Imp_Indivi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Imp_Indivi.Location = New System.Drawing.Point(145, 242)
        Me.btn_Imp_Indivi.Name = "btn_Imp_Indivi"
        Me.btn_Imp_Indivi.Size = New System.Drawing.Size(47, 45)
        Me.btn_Imp_Indivi.TabIndex = 64
        Me.btn_Imp_Indivi.UseVisualStyleBackColor = True
        '
        'btnEnregistrer_interven
        '
        Me.btnEnregistrer_interven.BackgroundImage = Global.EDG_Mamou.My.Resources.Resources.apply
        Me.btnEnregistrer_interven.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEnregistrer_interven.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnregistrer_interven.Location = New System.Drawing.Point(7, 242)
        Me.btnEnregistrer_interven.Name = "btnEnregistrer_interven"
        Me.btnEnregistrer_interven.Size = New System.Drawing.Size(51, 45)
        Me.btnEnregistrer_interven.TabIndex = 62
        Me.btnEnregistrer_interven.UseVisualStyleBackColor = True
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Yellow
        Me.Label21.Location = New System.Drawing.Point(13, 174)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(54, 22)
        Me.Label21.TabIndex = 70
        Me.Label21.Text = "Date "
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Yellow
        Me.Label23.Location = New System.Drawing.Point(12, 87)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(84, 22)
        Me.Label23.TabIndex = 69
        Me.Label23.Text = "Batiment"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Yellow
        Me.Label24.Location = New System.Drawing.Point(13, 42)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(58, 22)
        Me.Label24.TabIndex = 68
        Me.Label24.Text = "Agent"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.Yellow
        Me.Label27.Location = New System.Drawing.Point(12, 130)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(67, 22)
        Me.Label27.TabIndex = 66
        Me.Label27.Text = "Nature"
        '
        'txtNumero
        '
        Me.txtNumero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNumero.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumero.Location = New System.Drawing.Point(116, 1)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(220, 26)
        Me.txtNumero.TabIndex = 58
        Me.txtNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.Yellow
        Me.Label28.Location = New System.Drawing.Point(14, 1)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(76, 22)
        Me.Label28.TabIndex = 65
        Me.Label28.Text = "Numéro"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.dgvInterv)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(347, 34)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(809, 451)
        Me.Panel3.TabIndex = 2
        '
        'dgvInterv
        '
        Me.dgvInterv.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvInterv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvInterv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvInterv.Location = New System.Drawing.Point(0, 0)
        Me.dgvInterv.Name = "dgvInterv"
        Me.dgvInterv.ReadOnly = True
        Me.dgvInterv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvInterv.Size = New System.Drawing.Size(809, 439)
        Me.dgvInterv.TabIndex = 0
        '
        'UserControl1_intervention
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Green
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "UserControl1_intervention"
        Me.Size = New System.Drawing.Size(1156, 485)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.dgvInterv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents dtpDateDebut As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtFrais As System.Windows.Forms.TextBox
    Friend WithEvents lblfrais As System.Windows.Forms.Label
    Friend WithEvents btnModifier_interven As System.Windows.Forms.Button
    Friend WithEvents btn_Imp_Indivi As System.Windows.Forms.Button
    Friend WithEvents btnEnregistrer_interven As System.Windows.Forms.Button
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents txtNumero As System.Windows.Forms.TextBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents cmb_bat As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_nature As System.Windows.Forms.ComboBox
    Friend WithEvents dgvInterv As System.Windows.Forms.DataGridView
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents txt_recherche_paie As System.Windows.Forms.TextBox
    Friend WithEvents Cmb_recherche As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btn_recherche As System.Windows.Forms.Button
    Friend WithEvents txtMatricule As System.Windows.Forms.ComboBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents cbxnature_recher As System.Windows.Forms.ComboBox
    Friend WithEvents btn_sup As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label

End Class
