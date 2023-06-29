<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1_poste
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1_poste))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbltitre_poste = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblAnnuler = New System.Windows.Forms.Label()
        Me.lblModifier = New System.Windows.Forms.Label()
        Me.lblAjouter = New System.Windows.Forms.Label()
        Me.dtpraccorde = New System.Windows.Forms.DateTimePicker()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtnature_poste = New System.Windows.Forms.ComboBox()
        Me.txttype_poste = New System.Windows.Forms.ComboBox()
        Me.cmb_depart = New System.Windows.Forms.ComboBox()
        Me.cmb_zone = New System.Windows.Forms.ComboBox()
        Me.Btn_modif = New System.Windows.Forms.Button()
        Me.Btn_annul = New System.Windows.Forms.Button()
        Me.Btn_ajou = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtlignebt_long_poste = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtlignemt_section_poste = New System.Windows.Forms.TextBox()
        Me.txtlignemt_long_poste = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtintensite_nominale_poste = New System.Windows.Forms.TextBox()
        Me.txtpuissance_nominale_poste = New System.Windows.Forms.TextBox()
        Me.txtlibelle_poste = New System.Windows.Forms.TextBox()
        Me.txtnum_poste = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lbltitre_poste)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(820, 58)
        Me.Panel1.TabIndex = 0
        '
        'lbltitre_poste
        '
        Me.lbltitre_poste.BackColor = System.Drawing.Color.Green
        Me.lbltitre_poste.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbltitre_poste.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitre_poste.ForeColor = System.Drawing.Color.Yellow
        Me.lbltitre_poste.Location = New System.Drawing.Point(0, 0)
        Me.lbltitre_poste.Name = "lbltitre_poste"
        Me.lbltitre_poste.Size = New System.Drawing.Size(820, 58)
        Me.lbltitre_poste.TabIndex = 0
        Me.lbltitre_poste.Text = "Gestion des Postes"
        Me.lbltitre_poste.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.lblAnnuler)
        Me.Panel2.Controls.Add(Me.lblModifier)
        Me.Panel2.Controls.Add(Me.lblAjouter)
        Me.Panel2.Controls.Add(Me.dtpraccorde)
        Me.Panel2.Controls.Add(Me.Label17)
        Me.Panel2.Controls.Add(Me.txtnature_poste)
        Me.Panel2.Controls.Add(Me.txttype_poste)
        Me.Panel2.Controls.Add(Me.cmb_depart)
        Me.Panel2.Controls.Add(Me.cmb_zone)
        Me.Panel2.Controls.Add(Me.Btn_modif)
        Me.Panel2.Controls.Add(Me.Btn_annul)
        Me.Panel2.Controls.Add(Me.Btn_ajou)
        Me.Panel2.Controls.Add(Me.Label16)
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Controls.Add(Me.GroupBox2)
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Controls.Add(Me.txtintensite_nominale_poste)
        Me.Panel2.Controls.Add(Me.txtpuissance_nominale_poste)
        Me.Panel2.Controls.Add(Me.txtlibelle_poste)
        Me.Panel2.Controls.Add(Me.txtnum_poste)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 58)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(820, 405)
        Me.Panel2.TabIndex = 1
        '
        'lblAnnuler
        '
        Me.lblAnnuler.AutoSize = True
        Me.lblAnnuler.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnnuler.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblAnnuler.Location = New System.Drawing.Point(727, 378)
        Me.lblAnnuler.Name = "lblAnnuler"
        Me.lblAnnuler.Size = New System.Drawing.Size(60, 16)
        Me.lblAnnuler.TabIndex = 41
        Me.lblAnnuler.Text = "Annuler"
        '
        'lblModifier
        '
        Me.lblModifier.AutoSize = True
        Me.lblModifier.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModifier.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblModifier.Location = New System.Drawing.Point(637, 377)
        Me.lblModifier.Name = "lblModifier"
        Me.lblModifier.Size = New System.Drawing.Size(64, 16)
        Me.lblModifier.TabIndex = 39
        Me.lblModifier.Text = "Modifier"
        '
        'lblAjouter
        '
        Me.lblAjouter.AutoSize = True
        Me.lblAjouter.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAjouter.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblAjouter.Location = New System.Drawing.Point(556, 378)
        Me.lblAjouter.Name = "lblAjouter"
        Me.lblAjouter.Size = New System.Drawing.Size(57, 16)
        Me.lblAjouter.TabIndex = 38
        Me.lblAjouter.Text = "Ajouter"
        '
        'dtpraccorde
        '
        Me.dtpraccorde.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpraccorde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpraccorde.Location = New System.Drawing.Point(358, 280)
        Me.dtpraccorde.Name = "dtpraccorde"
        Me.dtpraccorde.Size = New System.Drawing.Size(213, 24)
        Me.dtpraccorde.TabIndex = 37
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(181, 280)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(171, 24)
        Me.Label17.TabIndex = 36
        Me.Label17.Text = "Date Raccordement"
        '
        'txtnature_poste
        '
        Me.txtnature_poste.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnature_poste.FormattingEnabled = True
        Me.txtnature_poste.Items.AddRange(New Object() {"Public", "Privé"})
        Me.txtnature_poste.Location = New System.Drawing.Point(103, 146)
        Me.txtnature_poste.Name = "txtnature_poste"
        Me.txtnature_poste.Size = New System.Drawing.Size(239, 25)
        Me.txtnature_poste.TabIndex = 35
        '
        'txttype_poste
        '
        Me.txttype_poste.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttype_poste.FormattingEnabled = True
        Me.txttype_poste.Items.AddRange(New Object() {"Cabine", "Aerien"})
        Me.txttype_poste.Location = New System.Drawing.Point(103, 111)
        Me.txttype_poste.Name = "txttype_poste"
        Me.txttype_poste.Size = New System.Drawing.Size(239, 25)
        Me.txttype_poste.TabIndex = 34
        '
        'cmb_depart
        '
        Me.cmb_depart.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.cmb_depart.FormattingEnabled = True
        Me.cmb_depart.Location = New System.Drawing.Point(103, 217)
        Me.cmb_depart.Name = "cmb_depart"
        Me.cmb_depart.Size = New System.Drawing.Size(239, 26)
        Me.cmb_depart.TabIndex = 33
        '
        'cmb_zone
        '
        Me.cmb_zone.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.cmb_zone.FormattingEnabled = True
        Me.cmb_zone.Location = New System.Drawing.Point(103, 179)
        Me.cmb_zone.Name = "cmb_zone"
        Me.cmb_zone.Size = New System.Drawing.Size(239, 26)
        Me.cmb_zone.TabIndex = 32
        '
        'Btn_modif
        '
        Me.Btn_modif.BackgroundImage = Global.EDG_Mamou.My.Resources.Resources.kate
        Me.Btn_modif.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_modif.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_modif.Location = New System.Drawing.Point(632, 322)
        Me.Btn_modif.Name = "Btn_modif"
        Me.Btn_modif.Size = New System.Drawing.Size(69, 52)
        Me.Btn_modif.TabIndex = 31
        Me.Btn_modif.UseVisualStyleBackColor = True
        '
        'Btn_annul
        '
        Me.Btn_annul.BackgroundImage = Global.EDG_Mamou.My.Resources.Resources.editdelete
        Me.Btn_annul.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_annul.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_annul.Location = New System.Drawing.Point(723, 320)
        Me.Btn_annul.Name = "Btn_annul"
        Me.Btn_annul.Size = New System.Drawing.Size(66, 54)
        Me.Btn_annul.TabIndex = 30
        Me.Btn_annul.UseVisualStyleBackColor = True
        '
        'Btn_ajou
        '
        Me.Btn_ajou.BackgroundImage = Global.EDG_Mamou.My.Resources.Resources.apply
        Me.Btn_ajou.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_ajou.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_ajou.Location = New System.Drawing.Point(549, 320)
        Me.Btn_ajou.Name = "Btn_ajou"
        Me.Btn_ajou.Size = New System.Drawing.Size(67, 54)
        Me.Btn_ajou.TabIndex = 29
        Me.Btn_ajou.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(757, 212)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(58, 24)
        Me.Label16.TabIndex = 28
        Me.Label16.Text = "KVA"
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(757, 242)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(58, 24)
        Me.Label15.TabIndex = 27
        Me.Label15.Text = "A"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txtlignebt_long_poste)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.ForestGreen
        Me.GroupBox2.Location = New System.Drawing.Point(359, 130)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(456, 67)
        Me.GroupBox2.TabIndex = 26
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Ligne BT"
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(391, 26)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(24, 24)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "m"
        '
        'txtlignebt_long_poste
        '
        Me.txtlignebt_long_poste.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlignebt_long_poste.Location = New System.Drawing.Point(106, 24)
        Me.txtlignebt_long_poste.Name = "txtlignebt_long_poste"
        Me.txtlignebt_long_poste.Size = New System.Drawing.Size(282, 24)
        Me.txtlignebt_long_poste.TabIndex = 23
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(11, 24)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(91, 24)
        Me.Label14.TabIndex = 21
        Me.Label14.Text = "Longueur"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.txtlignemt_section_poste)
        Me.GroupBox1.Controls.Add(Me.txtlignemt_long_poste)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.ForestGreen
        Me.GroupBox1.Location = New System.Drawing.Point(359, 19)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(456, 98)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ligne MT"
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(398, 58)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(52, 24)
        Me.Label13.TabIndex = 26
        Me.Label13.Text = "mm²"
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(396, 23)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(24, 24)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "m"
        '
        'txtlignemt_section_poste
        '
        Me.txtlignemt_section_poste.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlignemt_section_poste.Location = New System.Drawing.Point(106, 59)
        Me.txtlignemt_section_poste.Name = "txtlignemt_section_poste"
        Me.txtlignemt_section_poste.Size = New System.Drawing.Size(284, 24)
        Me.txtlignemt_section_poste.TabIndex = 24
        '
        'txtlignemt_long_poste
        '
        Me.txtlignemt_long_poste.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlignemt_long_poste.Location = New System.Drawing.Point(106, 22)
        Me.txtlignemt_long_poste.Name = "txtlignemt_long_poste"
        Me.txtlignemt_long_poste.Size = New System.Drawing.Size(284, 24)
        Me.txtlignemt_long_poste.TabIndex = 23
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(11, 61)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 24)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Section"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(11, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(89, 24)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Longueur"
        '
        'txtintensite_nominale_poste
        '
        Me.txtintensite_nominale_poste.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtintensite_nominale_poste.Location = New System.Drawing.Point(538, 242)
        Me.txtintensite_nominale_poste.Name = "txtintensite_nominale_poste"
        Me.txtintensite_nominale_poste.Size = New System.Drawing.Size(213, 24)
        Me.txtintensite_nominale_poste.TabIndex = 22
        '
        'txtpuissance_nominale_poste
        '
        Me.txtpuissance_nominale_poste.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpuissance_nominale_poste.Location = New System.Drawing.Point(538, 210)
        Me.txtpuissance_nominale_poste.Name = "txtpuissance_nominale_poste"
        Me.txtpuissance_nominale_poste.Size = New System.Drawing.Size(211, 24)
        Me.txtpuissance_nominale_poste.TabIndex = 15
        '
        'txtlibelle_poste
        '
        Me.txtlibelle_poste.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlibelle_poste.Location = New System.Drawing.Point(103, 73)
        Me.txtlibelle_poste.Name = "txtlibelle_poste"
        Me.txtlibelle_poste.Size = New System.Drawing.Size(239, 24)
        Me.txtlibelle_poste.TabIndex = 14
        '
        'txtnum_poste
        '
        Me.txtnum_poste.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnum_poste.Location = New System.Drawing.Point(103, 40)
        Me.txtnum_poste.Name = "txtnum_poste"
        Me.txtnum_poste.Size = New System.Drawing.Size(239, 24)
        Me.txtnum_poste.TabIndex = 13
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(12, 219)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(77, 24)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Depart"
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(361, 244)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(171, 24)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Intensité nominale"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 181)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 24)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Zone"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 144)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 24)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Nature"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 108)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 24)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Type"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(361, 210)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(171, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Puissance nominale"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Libellé"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "N°"
        '
        'Form1_poste
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(820, 463)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1_poste"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1_poste"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtnum_poste As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtlignebt_long_poste As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtlignemt_section_poste As System.Windows.Forms.TextBox
    Friend WithEvents txtlignemt_long_poste As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtintensite_nominale_poste As System.Windows.Forms.TextBox
    Friend WithEvents txtpuissance_nominale_poste As System.Windows.Forms.TextBox
    Friend WithEvents txtlibelle_poste As System.Windows.Forms.TextBox
    Friend WithEvents lbltitre_poste As System.Windows.Forms.Label
    Friend WithEvents Btn_modif As System.Windows.Forms.Button
    Friend WithEvents Btn_annul As System.Windows.Forms.Button
    Friend WithEvents Btn_ajou As System.Windows.Forms.Button
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cmb_depart As System.Windows.Forms.ComboBox
    Friend WithEvents txtnature_poste As System.Windows.Forms.ComboBox
    Friend WithEvents txttype_poste As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_zone As System.Windows.Forms.ComboBox
    Friend WithEvents dtpraccorde As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents lblAjouter As System.Windows.Forms.Label
    Friend WithEvents lblModifier As System.Windows.Forms.Label
    Friend WithEvents lblAnnuler As System.Windows.Forms.Label
End Class
