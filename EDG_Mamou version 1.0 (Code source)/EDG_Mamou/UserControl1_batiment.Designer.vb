<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl1_batiment
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DGV_batiment = New System.Windows.Forms.DataGridView()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.cmb_entrez_recherche = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cmb_rechercher = New System.Windows.Forms.ComboBox()
        Me.txt_recherche_bat = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.lblmodifier_bat = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.lbltype_tension_bat = New System.Windows.Forms.Label()
        Me.lbltype_batiment_bat = New System.Windows.Forms.Label()
        Me.lblpuissance_bat = New System.Windows.Forms.Label()
        Me.lblamp_dijon_bat = New System.Windows.Forms.Label()
        Me.lblfrais_paye_bat = New System.Windows.Forms.Label()
        Me.lbldate_branche_bat = New System.Windows.Forms.Label()
        Me.lblnat_branche_bat = New System.Windows.Forms.Label()
        Me.lblagent_bat = New System.Windows.Forms.Label()
        Me.lbtcat_bat = New System.Windows.Forms.Label()
        Me.lblcode_bat = New System.Windows.Forms.Label()
        Me.lblclient_bat = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.dgv_consom_batim = New System.Windows.Forms.DataGridView()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.dgvPaiementBat = New System.Windows.Forms.DataGridView()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.dgvIntervenBat = New System.Windows.Forms.DataGridView()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.lbl_solde_bat = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.dgv_compte = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DGV_batiment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        CType(Me.dgv_consom_batim, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgvPaiementBat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.dgvIntervenBat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage5.SuspendLayout()
        CType(Me.dgv_compte, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Green
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.ForeColor = System.Drawing.Color.Yellow
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1213, 43)
        Me.Panel1.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(465, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(267, 37)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Fiche Batiment"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(45, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(267, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Liste des Batiments"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Green
        Me.Panel2.Controls.Add(Me.DGV_batiment)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 43)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(370, 511)
        Me.Panel2.TabIndex = 11
        '
        'DGV_batiment
        '
        Me.DGV_batiment.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGV_batiment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DGV_batiment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_batiment.Location = New System.Drawing.Point(15, 86)
        Me.DGV_batiment.Name = "DGV_batiment"
        Me.DGV_batiment.ReadOnly = True
        Me.DGV_batiment.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DGV_batiment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_batiment.Size = New System.Drawing.Size(340, 418)
        Me.DGV_batiment.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Green
        Me.Panel3.Controls.Add(Me.cmb_entrez_recherche)
        Me.Panel3.Controls.Add(Me.Label13)
        Me.Panel3.Controls.Add(Me.cmb_rechercher)
        Me.Panel3.Controls.Add(Me.txt_recherche_bat)
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Location = New System.Drawing.Point(15, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(340, 81)
        Me.Panel3.TabIndex = 0
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(500, 6)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(86, 34)
        Me.Button4.TabIndex = 2
        Me.Button4.Text = "Actualiser"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'cmb_entrez_recherche
        '
        Me.cmb_entrez_recherche.Font = New System.Drawing.Font("Times New Roman", 14.25!)
        Me.cmb_entrez_recherche.FormattingEnabled = True
        Me.cmb_entrez_recherche.Location = New System.Drawing.Point(35, 41)
        Me.cmb_entrez_recherche.Name = "cmb_entrez_recherche"
        Me.cmb_entrez_recherche.Size = New System.Drawing.Size(240, 29)
        Me.cmb_entrez_recherche.TabIndex = 14
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(41, 6)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(121, 21)
        Me.Label13.TabIndex = 13
        Me.Label13.Text = "rechercher par:"
        '
        'cmb_rechercher
        '
        Me.cmb_rechercher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_rechercher.FormattingEnabled = True
        Me.cmb_rechercher.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.cmb_rechercher.Items.AddRange(New Object() {"Code", "Client", "Catégorie", "Type de tension", "Type de Batiment", "Zone", "Tournée", "Agent qui a branché"})
        Me.cmb_rechercher.Location = New System.Drawing.Point(169, 7)
        Me.cmb_rechercher.Name = "cmb_rechercher"
        Me.cmb_rechercher.Size = New System.Drawing.Size(159, 21)
        Me.cmb_rechercher.TabIndex = 12
        '
        'txt_recherche_bat
        '
        Me.txt_recherche_bat.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_recherche_bat.Location = New System.Drawing.Point(35, 41)
        Me.txt_recherche_bat.Name = "txt_recherche_bat"
        Me.txt_recherche_bat.Size = New System.Drawing.Size(240, 29)
        Me.txt_recherche_bat.TabIndex = 11
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.EDG_Mamou.My.Resources.Resources.kghostview
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Location = New System.Drawing.Point(279, 35)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(50, 41)
        Me.Button1.TabIndex = 10
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Green
        Me.Panel4.Controls.Add(Me.Button4)
        Me.Panel4.Controls.Add(Me.Label20)
        Me.Panel4.Controls.Add(Me.Label19)
        Me.Panel4.Controls.Add(Me.Label18)
        Me.Panel4.Controls.Add(Me.lblmodifier_bat)
        Me.Panel4.Controls.Add(Me.Label14)
        Me.Panel4.Controls.Add(Me.Button5)
        Me.Panel4.Controls.Add(Me.Button3)
        Me.Panel4.Controls.Add(Me.Button2)
        Me.Panel4.Controls.Add(Me.Button7)
        Me.Panel4.Controls.Add(Me.Button8)
        Me.Panel4.Controls.Add(Me.Button9)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(370, 495)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(843, 59)
        Me.Panel4.TabIndex = 12
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Yellow
        Me.Label20.Location = New System.Drawing.Point(187, 42)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(65, 15)
        Me.Label20.TabIndex = 17
        Me.Label20.Text = "Collective"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Yellow
        Me.Label19.Location = New System.Drawing.Point(388, 42)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(81, 15)
        Me.Label19.TabIndex = 16
        Me.Label19.Text = "Individuelle"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Yellow
        Me.Label18.Location = New System.Drawing.Point(281, 42)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(73, 15)
        Me.Label18.TabIndex = 15
        Me.Label18.Text = "Supprimer"
        '
        'lblmodifier_bat
        '
        Me.lblmodifier_bat.AutoSize = True
        Me.lblmodifier_bat.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmodifier_bat.ForeColor = System.Drawing.Color.Yellow
        Me.lblmodifier_bat.Location = New System.Drawing.Point(97, 42)
        Me.lblmodifier_bat.Name = "lblmodifier_bat"
        Me.lblmodifier_bat.Size = New System.Drawing.Size(58, 15)
        Me.lblmodifier_bat.TabIndex = 14
        Me.lblmodifier_bat.Text = "Modifier"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Yellow
        Me.Label14.Location = New System.Drawing.Point(6, 42)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(52, 15)
        Me.Label14.TabIndex = 13
        Me.Label14.Text = "Ajouter"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(701, 9)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 33)
        Me.Button5.TabIndex = 12
        Me.Button5.Text = "Button5"
        Me.Button5.UseVisualStyleBackColor = True
        Me.Button5.Visible = False
        '
        'Button3
        '
        Me.Button3.BackgroundImage = Global.EDG_Mamou.My.Resources.Resources.printmgr
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(391, 5)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(60, 34)
        Me.Button3.TabIndex = 11
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackgroundImage = Global.EDG_Mamou.My.Resources.Resources.printmgr
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(190, 6)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(60, 33)
        Me.Button2.TabIndex = 10
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.BackgroundImage = Global.EDG_Mamou.My.Resources.Resources.button_cancel
        Me.Button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button7.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(284, 6)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(60, 33)
        Me.Button7.TabIndex = 8
        Me.Button7.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.BackgroundImage = Global.EDG_Mamou.My.Resources.Resources.kate
        Me.Button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button8.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.Location = New System.Drawing.Point(95, 6)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(61, 33)
        Me.Button8.TabIndex = 7
        Me.Button8.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.BackgroundImage = Global.EDG_Mamou.My.Resources.Resources.edit_add
        Me.Button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button9.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.Location = New System.Drawing.Point(3, 5)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(60, 34)
        Me.Button9.TabIndex = 6
        Me.Button9.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.TabControl1)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(370, 43)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(843, 452)
        Me.Panel5.TabIndex = 13
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(830, 452)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Gainsboro
        Me.TabPage1.Controls.Add(Me.lbltype_tension_bat)
        Me.TabPage1.Controls.Add(Me.lbltype_batiment_bat)
        Me.TabPage1.Controls.Add(Me.lblpuissance_bat)
        Me.TabPage1.Controls.Add(Me.lblamp_dijon_bat)
        Me.TabPage1.Controls.Add(Me.lblfrais_paye_bat)
        Me.TabPage1.Controls.Add(Me.lbldate_branche_bat)
        Me.TabPage1.Controls.Add(Me.lblnat_branche_bat)
        Me.TabPage1.Controls.Add(Me.lblagent_bat)
        Me.TabPage1.Controls.Add(Me.lbtcat_bat)
        Me.TabPage1.Controls.Add(Me.lblcode_bat)
        Me.TabPage1.Controls.Add(Me.lblclient_bat)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label15)
        Me.TabPage1.Controls.Add(Me.Label16)
        Me.TabPage1.Location = New System.Drawing.Point(4, 27)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(822, 421)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Détails"
        '
        'lbltype_tension_bat
        '
        Me.lbltype_tension_bat.BackColor = System.Drawing.Color.White
        Me.lbltype_tension_bat.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltype_tension_bat.Location = New System.Drawing.Point(583, 269)
        Me.lbltype_tension_bat.Name = "lbltype_tension_bat"
        Me.lbltype_tension_bat.Size = New System.Drawing.Size(189, 25)
        Me.lbltype_tension_bat.TabIndex = 122
        '
        'lbltype_batiment_bat
        '
        Me.lbltype_batiment_bat.BackColor = System.Drawing.Color.White
        Me.lbltype_batiment_bat.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltype_batiment_bat.Location = New System.Drawing.Point(583, 209)
        Me.lbltype_batiment_bat.Name = "lbltype_batiment_bat"
        Me.lbltype_batiment_bat.Size = New System.Drawing.Size(189, 25)
        Me.lbltype_batiment_bat.TabIndex = 121
        '
        'lblpuissance_bat
        '
        Me.lblpuissance_bat.BackColor = System.Drawing.Color.White
        Me.lblpuissance_bat.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpuissance_bat.Location = New System.Drawing.Point(583, 149)
        Me.lblpuissance_bat.Name = "lblpuissance_bat"
        Me.lblpuissance_bat.Size = New System.Drawing.Size(189, 25)
        Me.lblpuissance_bat.TabIndex = 120
        '
        'lblamp_dijon_bat
        '
        Me.lblamp_dijon_bat.BackColor = System.Drawing.Color.White
        Me.lblamp_dijon_bat.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblamp_dijon_bat.Location = New System.Drawing.Point(583, 89)
        Me.lblamp_dijon_bat.Name = "lblamp_dijon_bat"
        Me.lblamp_dijon_bat.Size = New System.Drawing.Size(189, 25)
        Me.lblamp_dijon_bat.TabIndex = 119
        '
        'lblfrais_paye_bat
        '
        Me.lblfrais_paye_bat.BackColor = System.Drawing.Color.White
        Me.lblfrais_paye_bat.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfrais_paye_bat.Location = New System.Drawing.Point(583, 29)
        Me.lblfrais_paye_bat.Name = "lblfrais_paye_bat"
        Me.lblfrais_paye_bat.Size = New System.Drawing.Size(189, 25)
        Me.lblfrais_paye_bat.TabIndex = 118
        '
        'lbldate_branche_bat
        '
        Me.lbldate_branche_bat.BackColor = System.Drawing.Color.White
        Me.lbldate_branche_bat.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldate_branche_bat.Location = New System.Drawing.Point(182, 279)
        Me.lbldate_branche_bat.Name = "lbldate_branche_bat"
        Me.lbldate_branche_bat.Size = New System.Drawing.Size(210, 25)
        Me.lbldate_branche_bat.TabIndex = 117
        '
        'lblnat_branche_bat
        '
        Me.lblnat_branche_bat.BackColor = System.Drawing.Color.White
        Me.lblnat_branche_bat.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnat_branche_bat.Location = New System.Drawing.Point(182, 229)
        Me.lblnat_branche_bat.Name = "lblnat_branche_bat"
        Me.lblnat_branche_bat.Size = New System.Drawing.Size(210, 25)
        Me.lblnat_branche_bat.TabIndex = 116
        '
        'lblagent_bat
        '
        Me.lblagent_bat.BackColor = System.Drawing.Color.White
        Me.lblagent_bat.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblagent_bat.Location = New System.Drawing.Point(182, 176)
        Me.lblagent_bat.Name = "lblagent_bat"
        Me.lblagent_bat.Size = New System.Drawing.Size(210, 25)
        Me.lblagent_bat.TabIndex = 115
        '
        'lbtcat_bat
        '
        Me.lbtcat_bat.BackColor = System.Drawing.Color.White
        Me.lbtcat_bat.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbtcat_bat.Location = New System.Drawing.Point(182, 129)
        Me.lbtcat_bat.Name = "lbtcat_bat"
        Me.lbtcat_bat.Size = New System.Drawing.Size(210, 25)
        Me.lbtcat_bat.TabIndex = 111
        '
        'lblcode_bat
        '
        Me.lblcode_bat.BackColor = System.Drawing.Color.White
        Me.lblcode_bat.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcode_bat.Location = New System.Drawing.Point(182, 29)
        Me.lblcode_bat.Name = "lblcode_bat"
        Me.lblcode_bat.Size = New System.Drawing.Size(210, 25)
        Me.lblcode_bat.TabIndex = 110
        '
        'lblclient_bat
        '
        Me.lblclient_bat.BackColor = System.Drawing.Color.White
        Me.lblclient_bat.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblclient_bat.Location = New System.Drawing.Point(182, 79)
        Me.lblclient_bat.Name = "lblclient_bat"
        Me.lblclient_bat.Size = New System.Drawing.Size(210, 25)
        Me.lblclient_bat.TabIndex = 109
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(405, 272)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(109, 18)
        Me.Label8.TabIndex = 107
        Me.Label8.Text = "Type Tension"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(402, 212)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(115, 18)
        Me.Label7.TabIndex = 106
        Me.Label7.Text = "Type Batiment"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(402, 152)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 18)
        Me.Label6.TabIndex = 105
        Me.Label6.Text = "Puissance"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(403, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 18)
        Me.Label3.TabIndex = 104
        Me.Label3.Text = "Frais à Payer"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(402, 92)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(165, 18)
        Me.Label4.TabIndex = 103
        Me.Label4.Text = "Amperage Dijoncteur"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(5, 130)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(81, 18)
        Me.Label12.TabIndex = 100
        Me.Label12.Text = "Catégorie"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(5, 81)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(51, 18)
        Me.Label11.TabIndex = 99
        Me.Label11.Text = "Client"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(5, 179)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(153, 18)
        Me.Label9.TabIndex = 98
        Me.Label9.Text = "Branché par l'agent"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(5, 228)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(162, 18)
        Me.Label5.TabIndex = 97
        Me.Label5.Text = "Nature Branchement"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(5, 277)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(147, 18)
        Me.Label15.TabIndex = 96
        Me.Label15.Text = "Date Branchement"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(5, 32)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(48, 18)
        Me.Label16.TabIndex = 94
        Me.Label16.Text = "Code"
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.dgv_consom_batim)
        Me.TabPage4.Controls.Add(Me.Label10)
        Me.TabPage4.Location = New System.Drawing.Point(4, 27)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(822, 421)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Consommations"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'dgv_consom_batim
        '
        Me.dgv_consom_batim.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_consom_batim.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv_consom_batim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_consom_batim.Location = New System.Drawing.Point(6, 39)
        Me.dgv_consom_batim.Name = "dgv_consom_batim"
        Me.dgv_consom_batim.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_consom_batim.Size = New System.Drawing.Size(810, 378)
        Me.dgv_consom_batim.TabIndex = 4
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold)
        Me.Label10.Location = New System.Drawing.Point(215, 3)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(444, 33)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "Historique des consommations"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.dgvPaiementBat)
        Me.TabPage2.Controls.Add(Me.Label25)
        Me.TabPage2.Location = New System.Drawing.Point(4, 27)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(822, 421)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Paiements"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'dgvPaiementBat
        '
        Me.dgvPaiementBat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvPaiementBat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPaiementBat.Location = New System.Drawing.Point(6, 40)
        Me.dgvPaiementBat.Name = "dgvPaiementBat"
        Me.dgvPaiementBat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPaiementBat.Size = New System.Drawing.Size(810, 342)
        Me.dgvPaiementBat.TabIndex = 2
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold)
        Me.Label25.Location = New System.Drawing.Point(72, 3)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(678, 33)
        Me.Label25.TabIndex = 1
        Me.Label25.Text = "Liste des paiements effectués Pour ce Batiment"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.dgvIntervenBat)
        Me.TabPage3.Controls.Add(Me.Label26)
        Me.TabPage3.Location = New System.Drawing.Point(4, 27)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(822, 421)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Interventions"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'dgvIntervenBat
        '
        Me.dgvIntervenBat.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvIntervenBat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvIntervenBat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvIntervenBat.Location = New System.Drawing.Point(6, 39)
        Me.dgvIntervenBat.Name = "dgvIntervenBat"
        Me.dgvIntervenBat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvIntervenBat.Size = New System.Drawing.Size(810, 378)
        Me.dgvIntervenBat.TabIndex = 2
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold)
        Me.Label26.Location = New System.Drawing.Point(135, 3)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(589, 33)
        Me.Label26.TabIndex = 1
        Me.Label26.Text = "Interventions Survenues Sur Ce Batiment"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.Label22)
        Me.TabPage5.Controls.Add(Me.lbl_solde_bat)
        Me.TabPage5.Controls.Add(Me.Label21)
        Me.TabPage5.Controls.Add(Me.dgv_compte)
        Me.TabPage5.Location = New System.Drawing.Point(4, 27)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(822, 421)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Compte"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'Label22
        '
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(348, 9)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(48, 40)
        Me.Label22.TabIndex = 7
        Me.Label22.Text = "FG"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_solde_bat
        '
        Me.lbl_solde_bat.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_solde_bat.Location = New System.Drawing.Point(97, 9)
        Me.lbl_solde_bat.Name = "lbl_solde_bat"
        Me.lbl_solde_bat.Size = New System.Drawing.Size(259, 40)
        Me.lbl_solde_bat.TabIndex = 6
        Me.lbl_solde_bat.Text = "000000"
        Me.lbl_solde_bat.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label21
        '
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(6, 9)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(97, 40)
        Me.Label21.TabIndex = 5
        Me.Label21.Text = "Solde :"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dgv_compte
        '
        Me.dgv_compte.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_compte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_compte.Location = New System.Drawing.Point(6, 59)
        Me.dgv_compte.Name = "dgv_compte"
        Me.dgv_compte.Size = New System.Drawing.Size(810, 323)
        Me.dgv_compte.TabIndex = 0
        '
        'UserControl1_batiment
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.Green
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "UserControl1_batiment"
        Me.Size = New System.Drawing.Size(1213, 554)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.DGV_batiment, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        CType(Me.dgv_consom_batim, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.dgvPaiementBat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.dgvIntervenBat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage5.ResumeLayout(False)
        CType(Me.dgv_compte, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents txt_recherche_bat As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents lbtcat_bat As System.Windows.Forms.Label
    Friend WithEvents lblcode_bat As System.Windows.Forms.Label
    Friend WithEvents lblclient_bat As System.Windows.Forms.Label
    Friend WithEvents lbltype_tension_bat As System.Windows.Forms.Label
    Friend WithEvents lbltype_batiment_bat As System.Windows.Forms.Label
    Friend WithEvents lblpuissance_bat As System.Windows.Forms.Label
    Friend WithEvents lblamp_dijon_bat As System.Windows.Forms.Label
    Friend WithEvents lblfrais_paye_bat As System.Windows.Forms.Label
    Friend WithEvents lbldate_branche_bat As System.Windows.Forms.Label
    Friend WithEvents lblnat_branche_bat As System.Windows.Forms.Label
    Friend WithEvents lblagent_bat As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents DGV_batiment As System.Windows.Forms.DataGridView
    Friend WithEvents dgvPaiementBat As System.Windows.Forms.DataGridView
    Friend WithEvents dgvIntervenBat As System.Windows.Forms.DataGridView
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents dgv_consom_batim As System.Windows.Forms.DataGridView
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cmb_rechercher As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_entrez_recherche As System.Windows.Forms.ComboBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents dgv_compte As System.Windows.Forms.DataGridView
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents lblmodifier_bat As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents lbl_solde_bat As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label

End Class
