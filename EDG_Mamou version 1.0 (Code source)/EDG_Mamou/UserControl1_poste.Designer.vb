<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl1_poste
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
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dgv_poste = New System.Windows.Forms.DataGridView()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmb_rechercher = New System.Windows.Forms.ComboBox()
        Me.btnrechercher_post = New System.Windows.Forms.Button()
        Me.txtrecherche_poste = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.lbl_date_rac = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.lbllongBT_post = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblsectionpost = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.lbllongMT_post = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.lblnature_post = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lbltype_post = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblintensite_post = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblpuisance_post = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lbldepart_post = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lbl_libelle_post = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblzone_post = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblnum_post = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnmodif_post = New System.Windows.Forms.Button()
        Me.btnimp_post = New System.Windows.Forms.Button()
        Me.btnajouter_post = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgv_poste, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label22)
        Me.Panel1.Controls.Add(Me.Label21)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1092, 31)
        Me.Panel1.TabIndex = 0
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.Color.Green
        Me.Label22.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label22.ForeColor = System.Drawing.Color.Yellow
        Me.Label22.Location = New System.Drawing.Point(453, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(639, 31)
        Me.Label22.TabIndex = 1
        Me.Label22.Text = "Fiche des Postes"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.Color.Green
        Me.Label21.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label21.ForeColor = System.Drawing.Color.Yellow
        Me.Label21.Location = New System.Drawing.Point(0, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(453, 31)
        Me.Label21.TabIndex = 0
        Me.Label21.Text = "Liste des Postes"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Green
        Me.Panel2.Controls.Add(Me.dgv_poste)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 31)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(456, 474)
        Me.Panel2.TabIndex = 1
        '
        'dgv_poste
        '
        Me.dgv_poste.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_poste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_poste.Location = New System.Drawing.Point(9, 93)
        Me.dgv_poste.Name = "dgv_poste"
        Me.dgv_poste.ReadOnly = True
        Me.dgv_poste.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgv_poste.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_poste.Size = New System.Drawing.Size(440, 375)
        Me.dgv_poste.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Green
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.cmb_rechercher)
        Me.Panel3.Controls.Add(Me.btnrechercher_post)
        Me.Panel3.Controls.Add(Me.txtrecherche_poste)
        Me.Panel3.Location = New System.Drawing.Point(5, 1)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(446, 89)
        Me.Panel3.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Yellow
        Me.Label2.Location = New System.Drawing.Point(35, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Rechercher par "
        '
        'cmb_rechercher
        '
        Me.cmb_rechercher.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_rechercher.FormattingEnabled = True
        Me.cmb_rechercher.Items.AddRange(New Object() {"Numero", "Zone", "Libelle", "Depart"})
        Me.cmb_rechercher.Location = New System.Drawing.Point(166, 10)
        Me.cmb_rechercher.Name = "cmb_rechercher"
        Me.cmb_rechercher.Size = New System.Drawing.Size(245, 26)
        Me.cmb_rechercher.TabIndex = 2
        '
        'btnrechercher_post
        '
        Me.btnrechercher_post.BackgroundImage = Global.EDG_Mamou.My.Resources.Resources.kghostview
        Me.btnrechercher_post.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnrechercher_post.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnrechercher_post.Location = New System.Drawing.Point(361, 40)
        Me.btnrechercher_post.Name = "btnrechercher_post"
        Me.btnrechercher_post.Size = New System.Drawing.Size(50, 42)
        Me.btnrechercher_post.TabIndex = 1
        Me.btnrechercher_post.UseVisualStyleBackColor = True
        '
        'txtrecherche_poste
        '
        Me.txtrecherche_poste.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtrecherche_poste.Location = New System.Drawing.Point(38, 51)
        Me.txtrecherche_poste.Name = "txtrecherche_poste"
        Me.txtrecherche_poste.Size = New System.Drawing.Size(318, 24)
        Me.txtrecherche_poste.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Green
        Me.Panel4.Controls.Add(Me.TabControl1)
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(456, 31)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(636, 474)
        Me.Panel4.TabIndex = 2
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(628, 404)
        Me.TabControl1.TabIndex = 24
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage1.Controls.Add(Me.lbl_date_rac)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.lblnature_post)
        Me.TabPage1.Controls.Add(Me.Label16)
        Me.TabPage1.Controls.Add(Me.lbltype_post)
        Me.TabPage1.Controls.Add(Me.Label14)
        Me.TabPage1.Controls.Add(Me.lblintensite_post)
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Controls.Add(Me.lblpuisance_post)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.lbldepart_post)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.lbl_libelle_post)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.lblzone_post)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.lblnum_post)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 27)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(620, 373)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Details"
        '
        'lbl_date_rac
        '
        Me.lbl_date_rac.BackColor = System.Drawing.Color.White
        Me.lbl_date_rac.Location = New System.Drawing.Point(349, 301)
        Me.lbl_date_rac.Name = "lbl_date_rac"
        Me.lbl_date_rac.Size = New System.Drawing.Size(219, 23)
        Me.lbl_date_rac.TabIndex = 23
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(174, 303)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(160, 23)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Date Raccordement"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label25)
        Me.GroupBox2.Controls.Add(Me.lbllongBT_post)
        Me.GroupBox2.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(349, 225)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(268, 64)
        Me.GroupBox2.TabIndex = 21
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "LIGNE BT"
        '
        'Label25
        '
        Me.Label25.BackColor = System.Drawing.Color.White
        Me.Label25.Location = New System.Drawing.Point(132, 21)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(130, 23)
        Me.Label25.TabIndex = 18
        '
        'lbllongBT_post
        '
        Me.lbllongBT_post.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbllongBT_post.Location = New System.Drawing.Point(27, 21)
        Me.lbllongBT_post.Name = "lbllongBT_post"
        Me.lbllongBT_post.Size = New System.Drawing.Size(102, 23)
        Me.lbllongBT_post.TabIndex = 17
        Me.lbllongBT_post.Text = "Longueur"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblsectionpost)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.lbllongMT_post)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(349, 105)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(268, 100)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "LIGNE MT"
        '
        'lblsectionpost
        '
        Me.lblsectionpost.BackColor = System.Drawing.Color.White
        Me.lblsectionpost.Location = New System.Drawing.Point(135, 60)
        Me.lblsectionpost.Name = "lblsectionpost"
        Me.lblsectionpost.Size = New System.Drawing.Size(127, 23)
        Me.lblsectionpost.TabIndex = 20
        '
        'Label20
        '
        Me.Label20.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(31, 60)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(84, 23)
        Me.Label20.TabIndex = 19
        Me.Label20.Text = "Section"
        '
        'lbllongMT_post
        '
        Me.lbllongMT_post.BackColor = System.Drawing.Color.White
        Me.lbllongMT_post.Location = New System.Drawing.Point(132, 21)
        Me.lbllongMT_post.Name = "lbllongMT_post"
        Me.lbllongMT_post.Size = New System.Drawing.Size(130, 23)
        Me.lbllongMT_post.TabIndex = 18
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(27, 21)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(102, 23)
        Me.Label18.TabIndex = 17
        Me.Label18.Text = "Longueur"
        '
        'lblnature_post
        '
        Me.lblnature_post.BackColor = System.Drawing.Color.White
        Me.lblnature_post.Location = New System.Drawing.Point(450, 79)
        Me.lblnature_post.Name = "lblnature_post"
        Me.lblnature_post.Size = New System.Drawing.Size(159, 23)
        Me.lblnature_post.TabIndex = 15
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(343, 74)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(78, 23)
        Me.Label16.TabIndex = 14
        Me.Label16.Text = "Nature"
        '
        'lbltype_post
        '
        Me.lbltype_post.BackColor = System.Drawing.Color.White
        Me.lbltype_post.Location = New System.Drawing.Point(450, 26)
        Me.lbltype_post.Name = "lbltype_post"
        Me.lbltype_post.Size = New System.Drawing.Size(159, 23)
        Me.lbltype_post.TabIndex = 13
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(343, 26)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(68, 23)
        Me.Label14.TabIndex = 12
        Me.Label14.Text = "Type"
        '
        'lblintensite_post
        '
        Me.lblintensite_post.BackColor = System.Drawing.Color.White
        Me.lblintensite_post.Location = New System.Drawing.Point(107, 266)
        Me.lblintensite_post.Name = "lblintensite_post"
        Me.lblintensite_post.Size = New System.Drawing.Size(219, 23)
        Me.lblintensite_post.TabIndex = 11
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(6, 266)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(123, 23)
        Me.Label12.TabIndex = 10
        Me.Label12.Text = "Intensité"
        '
        'lblpuisance_post
        '
        Me.lblpuisance_post.BackColor = System.Drawing.Color.White
        Me.lblpuisance_post.Location = New System.Drawing.Point(107, 218)
        Me.lblpuisance_post.Name = "lblpuisance_post"
        Me.lblpuisance_post.Size = New System.Drawing.Size(219, 23)
        Me.lblpuisance_post.TabIndex = 9
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(6, 218)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(95, 23)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Puissance"
        '
        'lbldepart_post
        '
        Me.lbldepart_post.BackColor = System.Drawing.Color.White
        Me.lbldepart_post.Location = New System.Drawing.Point(107, 170)
        Me.lbldepart_post.Name = "lbldepart_post"
        Me.lbldepart_post.Size = New System.Drawing.Size(219, 23)
        Me.lbldepart_post.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, 170)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 23)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Depart"
        '
        'lbl_libelle_post
        '
        Me.lbl_libelle_post.BackColor = System.Drawing.Color.White
        Me.lbl_libelle_post.Location = New System.Drawing.Point(107, 122)
        Me.lbl_libelle_post.Name = "lbl_libelle_post"
        Me.lbl_libelle_post.Size = New System.Drawing.Size(219, 23)
        Me.lbl_libelle_post.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 122)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 23)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Libellé"
        '
        'lblzone_post
        '
        Me.lblzone_post.BackColor = System.Drawing.Color.White
        Me.lblzone_post.Location = New System.Drawing.Point(107, 74)
        Me.lblzone_post.Name = "lblzone_post"
        Me.lblzone_post.Size = New System.Drawing.Size(219, 23)
        Me.lblzone_post.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 23)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Zone"
        '
        'lblnum_post
        '
        Me.lblnum_post.BackColor = System.Drawing.Color.White
        Me.lblnum_post.Location = New System.Drawing.Point(107, 26)
        Me.lblnum_post.Name = "lblnum_post"
        Me.lblnum_post.Size = New System.Drawing.Size(219, 23)
        Me.lblnum_post.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "N°"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.DataGridView1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 27)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(620, 373)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Prelevements"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(6, 38)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(608, 329)
        Me.DataGridView1.TabIndex = 2
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.DataGridView2)
        Me.TabPage3.Location = New System.Drawing.Point(4, 27)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(620, 373)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Remplacements"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(6, 38)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView2.Size = New System.Drawing.Size(608, 329)
        Me.DataGridView2.TabIndex = 3
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Transparent
        Me.Panel5.Controls.Add(Me.Label7)
        Me.Panel5.Controls.Add(Me.Label17)
        Me.Panel5.Controls.Add(Me.Label5)
        Me.Panel5.Controls.Add(Me.btnmodif_post)
        Me.Panel5.Controls.Add(Me.btnimp_post)
        Me.Panel5.Controls.Add(Me.btnajouter_post)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(0, 410)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(636, 64)
        Me.Panel5.TabIndex = 23
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Yellow
        Me.Label7.Location = New System.Drawing.Point(172, 45)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 15)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Impression"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Yellow
        Me.Label17.Location = New System.Drawing.Point(87, 45)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(58, 15)
        Me.Label17.TabIndex = 15
        Me.Label17.Text = "Modifier"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Yellow
        Me.Label5.Location = New System.Drawing.Point(2, 45)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 15)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Ajouter"
        '
        'btnmodif_post
        '
        Me.btnmodif_post.BackgroundImage = Global.EDG_Mamou.My.Resources.Resources.kate
        Me.btnmodif_post.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnmodif_post.Location = New System.Drawing.Point(85, 3)
        Me.btnmodif_post.Name = "btnmodif_post"
        Me.btnmodif_post.Size = New System.Drawing.Size(62, 39)
        Me.btnmodif_post.TabIndex = 3
        Me.btnmodif_post.UseVisualStyleBackColor = True
        '
        'btnimp_post
        '
        Me.btnimp_post.BackgroundImage = Global.EDG_Mamou.My.Resources.Resources.printmgr
        Me.btnimp_post.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnimp_post.Location = New System.Drawing.Point(171, 3)
        Me.btnimp_post.Name = "btnimp_post"
        Me.btnimp_post.Size = New System.Drawing.Size(81, 40)
        Me.btnimp_post.TabIndex = 1
        Me.btnimp_post.UseVisualStyleBackColor = True
        '
        'btnajouter_post
        '
        Me.btnajouter_post.BackgroundImage = Global.EDG_Mamou.My.Resources.Resources.edit_add
        Me.btnajouter_post.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnajouter_post.Location = New System.Drawing.Point(0, 3)
        Me.btnajouter_post.Name = "btnajouter_post"
        Me.btnajouter_post.Size = New System.Drawing.Size(56, 38)
        Me.btnajouter_post.TabIndex = 0
        Me.btnajouter_post.UseVisualStyleBackColor = True
        '
        'UserControl1_poste
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Green
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "UserControl1_poste"
        Me.Size = New System.Drawing.Size(1092, 505)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.dgv_poste, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btnrechercher_post As System.Windows.Forms.Button
    Friend WithEvents txtrecherche_poste As System.Windows.Forms.TextBox
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents lbllongBT_post As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblsectionpost As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents lbllongMT_post As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents lblnature_post As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents lbltype_post As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents lblintensite_post As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lblpuisance_post As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lbldepart_post As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lbl_libelle_post As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblzone_post As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblnum_post As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents btnmodif_post As System.Windows.Forms.Button
    Friend WithEvents btnimp_post As System.Windows.Forms.Button
    Friend WithEvents btnajouter_post As System.Windows.Forms.Button
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents dgv_poste As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmb_rechercher As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents lbl_date_rac As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label

End Class
