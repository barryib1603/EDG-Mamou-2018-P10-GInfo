<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBatiments
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBatiments))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblannuler = New System.Windows.Forms.Label()
        Me.lblmodifier = New System.Windows.Forms.Label()
        Me.lblajout = New System.Windows.Forms.Label()
        Me.id_bat = New System.Windows.Forms.Label()
        Me.txt_id_bat = New System.Windows.Forms.TextBox()
        Me.cmb_agent_branch = New System.Windows.Forms.ComboBox()
        Me.cmb_client_bat = New System.Windows.Forms.ComboBox()
        Me.dt_date_brach = New System.Windows.Forms.DateTimePicker()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtFraiPayer_batiment = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbTournee = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.btnEnregistrer = New System.Windows.Forms.Button()
        Me.btnModifier = New System.Windows.Forms.Button()
        Me.btnQuitter = New System.Windows.Forms.Button()
        Me.cmbnature_branche_batiment = New System.Windows.Forms.ComboBox()
        Me.cmbCategorie_batiment = New System.Windows.Forms.ComboBox()
        Me.cmbTypeTension_batiment = New System.Windows.Forms.ComboBox()
        Me.cmbTypeBat_batiment = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtAmperage_batiment = New System.Windows.Forms.TextBox()
        Me.txtPuissance_batiment = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCode_batiment = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1017, 446)
        Me.Panel1.TabIndex = 0
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.Green
        Me.Label15.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label15.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Yellow
        Me.Label15.Location = New System.Drawing.Point(0, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(1017, 49)
        Me.Label15.TabIndex = 70
        Me.Label15.Text = "Gestion des Batiments"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblannuler)
        Me.GroupBox1.Controls.Add(Me.lblmodifier)
        Me.GroupBox1.Controls.Add(Me.lblajout)
        Me.GroupBox1.Controls.Add(Me.id_bat)
        Me.GroupBox1.Controls.Add(Me.txt_id_bat)
        Me.GroupBox1.Controls.Add(Me.cmb_agent_branch)
        Me.GroupBox1.Controls.Add(Me.cmb_client_bat)
        Me.GroupBox1.Controls.Add(Me.dt_date_brach)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.txtFraiPayer_batiment)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cmbTournee)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.btnEnregistrer)
        Me.GroupBox1.Controls.Add(Me.btnModifier)
        Me.GroupBox1.Controls.Add(Me.btnQuitter)
        Me.GroupBox1.Controls.Add(Me.cmbnature_branche_batiment)
        Me.GroupBox1.Controls.Add(Me.cmbCategorie_batiment)
        Me.GroupBox1.Controls.Add(Me.cmbTypeTension_batiment)
        Me.GroupBox1.Controls.Add(Me.cmbTypeBat_batiment)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.txtAmperage_batiment)
        Me.GroupBox1.Controls.Add(Me.txtPuissance_batiment)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtCode_batiment)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 40)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1003, 403)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "-"
        '
        'lblannuler
        '
        Me.lblannuler.AutoSize = True
        Me.lblannuler.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblannuler.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblannuler.Location = New System.Drawing.Point(659, 380)
        Me.lblannuler.Name = "lblannuler"
        Me.lblannuler.Size = New System.Drawing.Size(56, 15)
        Me.lblannuler.TabIndex = 111
        Me.lblannuler.Text = "Annuler"
        '
        'lblmodifier
        '
        Me.lblmodifier.AutoSize = True
        Me.lblmodifier.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmodifier.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblmodifier.Location = New System.Drawing.Point(489, 380)
        Me.lblmodifier.Name = "lblmodifier"
        Me.lblmodifier.Size = New System.Drawing.Size(58, 15)
        Me.lblmodifier.TabIndex = 110
        Me.lblmodifier.Text = "Modifier"
        '
        'lblajout
        '
        Me.lblajout.AutoSize = True
        Me.lblajout.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblajout.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblajout.Location = New System.Drawing.Point(334, 380)
        Me.lblajout.Name = "lblajout"
        Me.lblajout.Size = New System.Drawing.Size(52, 15)
        Me.lblajout.TabIndex = 109
        Me.lblajout.Text = "Ajouter"
        '
        'id_bat
        '
        Me.id_bat.AutoSize = True
        Me.id_bat.Location = New System.Drawing.Point(3, 70)
        Me.id_bat.Name = "id_bat"
        Me.id_bat.Size = New System.Drawing.Size(94, 22)
        Me.id_bat.TabIndex = 108
        Me.id_bat.Text = "Identifiant"
        '
        'txt_id_bat
        '
        Me.txt_id_bat.Location = New System.Drawing.Point(184, 67)
        Me.txt_id_bat.Name = "txt_id_bat"
        Me.txt_id_bat.Size = New System.Drawing.Size(278, 29)
        Me.txt_id_bat.TabIndex = 0
        '
        'cmb_agent_branch
        '
        Me.cmb_agent_branch.FormattingEnabled = True
        Me.cmb_agent_branch.Location = New System.Drawing.Point(184, 195)
        Me.cmb_agent_branch.Name = "cmb_agent_branch"
        Me.cmb_agent_branch.Size = New System.Drawing.Size(278, 30)
        Me.cmb_agent_branch.TabIndex = 3
        '
        'cmb_client_bat
        '
        Me.cmb_client_bat.FormattingEnabled = True
        Me.cmb_client_bat.Location = New System.Drawing.Point(662, 31)
        Me.cmb_client_bat.Name = "cmb_client_bat"
        Me.cmb_client_bat.Size = New System.Drawing.Size(278, 30)
        Me.cmb_client_bat.TabIndex = 6
        '
        'dt_date_brach
        '
        Me.dt_date_brach.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_date_brach.Location = New System.Drawing.Point(184, 281)
        Me.dt_date_brach.Name = "dt_date_brach"
        Me.dt_date_brach.Size = New System.Drawing.Size(278, 29)
        Me.dt_date_brach.TabIndex = 5
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(946, 271)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(51, 22)
        Me.Label13.TabIndex = 102
        Me.Label13.Text = "GNF"
        '
        'txtFraiPayer_batiment
        '
        Me.txtFraiPayer_batiment.Location = New System.Drawing.Point(662, 268)
        Me.txtFraiPayer_batiment.Name = "txtFraiPayer_batiment"
        Me.txtFraiPayer_batiment.Size = New System.Drawing.Size(277, 29)
        Me.txtFraiPayer_batiment.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(480, 271)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 22)
        Me.Label3.TabIndex = 100
        Me.Label3.Text = "Frais à Payer"
        '
        'cmbTournee
        '
        Me.cmbTournee.FormattingEnabled = True
        Me.cmbTournee.Location = New System.Drawing.Point(184, 109)
        Me.cmbTournee.Name = "cmbTournee"
        Me.cmbTournee.Size = New System.Drawing.Size(278, 30)
        Me.cmbTournee.TabIndex = 1
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(3, 117)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(69, 22)
        Me.Label16.TabIndex = 98
        Me.Label16.Text = "Tounée"
        '
        'btnEnregistrer
        '
        Me.btnEnregistrer.BackgroundImage = Global.EDG_Mamou.My.Resources.Resources.apply
        Me.btnEnregistrer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEnregistrer.Location = New System.Drawing.Point(328, 317)
        Me.btnEnregistrer.Name = "btnEnregistrer"
        Me.btnEnregistrer.Size = New System.Drawing.Size(71, 61)
        Me.btnEnregistrer.TabIndex = 12
        Me.btnEnregistrer.UseVisualStyleBackColor = True
        '
        'btnModifier
        '
        Me.btnModifier.BackgroundImage = Global.EDG_Mamou.My.Resources.Resources.kate
        Me.btnModifier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnModifier.Location = New System.Drawing.Point(485, 317)
        Me.btnModifier.Name = "btnModifier"
        Me.btnModifier.Size = New System.Drawing.Size(70, 58)
        Me.btnModifier.TabIndex = 13
        Me.btnModifier.UseVisualStyleBackColor = True
        '
        'btnQuitter
        '
        Me.btnQuitter.BackgroundImage = Global.EDG_Mamou.My.Resources.Resources.editdelete
        Me.btnQuitter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnQuitter.Location = New System.Drawing.Point(651, 317)
        Me.btnQuitter.Name = "btnQuitter"
        Me.btnQuitter.Size = New System.Drawing.Size(72, 61)
        Me.btnQuitter.TabIndex = 14
        Me.btnQuitter.UseVisualStyleBackColor = True
        '
        'cmbnature_branche_batiment
        '
        Me.cmbnature_branche_batiment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbnature_branche_batiment.FormattingEnabled = True
        Me.cmbnature_branche_batiment.Items.AddRange(New Object() {"Mono phasé", "Tri phasé"})
        Me.cmbnature_branche_batiment.Location = New System.Drawing.Point(184, 238)
        Me.cmbnature_branche_batiment.Name = "cmbnature_branche_batiment"
        Me.cmbnature_branche_batiment.Size = New System.Drawing.Size(278, 30)
        Me.cmbnature_branche_batiment.TabIndex = 4
        '
        'cmbCategorie_batiment
        '
        Me.cmbCategorie_batiment.FormattingEnabled = True
        Me.cmbCategorie_batiment.Location = New System.Drawing.Point(184, 152)
        Me.cmbCategorie_batiment.Name = "cmbCategorie_batiment"
        Me.cmbCategorie_batiment.Size = New System.Drawing.Size(278, 30)
        Me.cmbCategorie_batiment.TabIndex = 2
        '
        'cmbTypeTension_batiment
        '
        Me.cmbTypeTension_batiment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTypeTension_batiment.FormattingEnabled = True
        Me.cmbTypeTension_batiment.Items.AddRange(New Object() {"BT", "MT", "HT"})
        Me.cmbTypeTension_batiment.Location = New System.Drawing.Point(662, 217)
        Me.cmbTypeTension_batiment.Name = "cmbTypeTension_batiment"
        Me.cmbTypeTension_batiment.Size = New System.Drawing.Size(277, 30)
        Me.cmbTypeTension_batiment.TabIndex = 10
        '
        'cmbTypeBat_batiment
        '
        Me.cmbTypeBat_batiment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTypeBat_batiment.FormattingEnabled = True
        Me.cmbTypeBat_batiment.Items.AddRange(New Object() {"FORFAITAIRE", "NON FORFAITAIRE"})
        Me.cmbTypeBat_batiment.Location = New System.Drawing.Point(662, 171)
        Me.cmbTypeBat_batiment.Name = "cmbTypeBat_batiment"
        Me.cmbTypeBat_batiment.Size = New System.Drawing.Size(277, 30)
        Me.cmbTypeBat_batiment.TabIndex = 9
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(946, 81)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(23, 22)
        Me.Label14.TabIndex = 88
        Me.Label14.Text = "A"
        '
        'txtAmperage_batiment
        '
        Me.txtAmperage_batiment.Location = New System.Drawing.Point(662, 81)
        Me.txtAmperage_batiment.Name = "txtAmperage_batiment"
        Me.txtAmperage_batiment.Size = New System.Drawing.Size(277, 29)
        Me.txtAmperage_batiment.TabIndex = 7
        '
        'txtPuissance_batiment
        '
        Me.txtPuissance_batiment.Location = New System.Drawing.Point(662, 126)
        Me.txtPuissance_batiment.Name = "txtPuissance_batiment"
        Me.txtPuissance_batiment.Size = New System.Drawing.Size(277, 29)
        Me.txtPuissance_batiment.TabIndex = 8
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(945, 130)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(48, 22)
        Me.Label10.TabIndex = 83
        Me.Label10.Text = "Kwh"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(480, 220)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(118, 22)
        Me.Label8.TabIndex = 82
        Me.Label8.Text = "Type Tension"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(480, 174)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(129, 22)
        Me.Label7.TabIndex = 81
        Me.Label7.Text = "Type Batiment"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(480, 129)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 22)
        Me.Label6.TabIndex = 80
        Me.Label6.Text = "Puissance"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(480, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(182, 22)
        Me.Label2.TabIndex = 78
        Me.Label2.Text = "Amperage dijoncteur"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(3, 152)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(91, 22)
        Me.Label12.TabIndex = 75
        Me.Label12.Text = "Catégorie"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(480, 34)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(59, 22)
        Me.Label11.TabIndex = 74
        Me.Label11.Text = "Client"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(3, 198)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(172, 22)
        Me.Label9.TabIndex = 73
        Me.Label9.Text = "Branché par l'agent"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 241)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(181, 22)
        Me.Label5.TabIndex = 72
        Me.Label5.Text = "Nature Branchement"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 281)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(163, 22)
        Me.Label4.TabIndex = 71
        Me.Label4.Text = "Date Branchement"
        '
        'txtCode_batiment
        '
        Me.txtCode_batiment.Location = New System.Drawing.Point(184, 25)
        Me.txtCode_batiment.Name = "txtCode_batiment"
        Me.txtCode_batiment.ReadOnly = True
        Me.txtCode_batiment.Size = New System.Drawing.Size(278, 29)
        Me.txtCode_batiment.TabIndex = 70
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 22)
        Me.Label1.TabIndex = 69
        Me.Label1.Text = "Code"
        '
        'frmBatiments
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1017, 446)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmBatiments"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestion des Batiments"
        Me.TopMost = True
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnModifier As System.Windows.Forms.Button
    Friend WithEvents cmbnature_branche_batiment As System.Windows.Forms.ComboBox
    Friend WithEvents cmbCategorie_batiment As System.Windows.Forms.ComboBox
    Friend WithEvents cmbTypeTension_batiment As System.Windows.Forms.ComboBox
    Friend WithEvents cmbTypeBat_batiment As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtAmperage_batiment As System.Windows.Forms.TextBox
    Friend WithEvents txtPuissance_batiment As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtCode_batiment As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnEnregistrer As System.Windows.Forms.Button
    Friend WithEvents btnQuitter As System.Windows.Forms.Button
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtFraiPayer_batiment As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbTournee As System.Windows.Forms.ComboBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents dt_date_brach As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmb_client_bat As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_agent_branch As System.Windows.Forms.ComboBox
    Friend WithEvents txt_id_bat As System.Windows.Forms.TextBox
    Friend WithEvents id_bat As System.Windows.Forms.Label
    Friend WithEvents lblannuler As System.Windows.Forms.Label
    Friend WithEvents lblmodifier As System.Windows.Forms.Label
    Friend WithEvents lblajout As System.Windows.Forms.Label
End Class
