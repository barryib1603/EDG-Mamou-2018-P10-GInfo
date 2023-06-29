<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usercontroler2_personnel
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
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DGVPERSONNEL = New System.Windows.Forms.DataGridView()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cmb_rechercher = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Txt_recherche = New System.Windows.Forms.TextBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage9 = New System.Windows.Forms.TabPage()
        Me.lblStatut_pers = New System.Windows.Forms.Label()
        Me.Statut = New System.Windows.Forms.Label()
        Me.lbl_pers_genre = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.lbl_pers_tel = New System.Windows.Forms.Label()
        Me.lbl_pers_adresse = New System.Windows.Forms.Label()
        Me.lbl_pers_email = New System.Windows.Forms.Label()
        Me.lbl_pers_service = New System.Windows.Forms.Label()
        Me.lbl_pers_mat = New System.Windows.Forms.Label()
        Me.lbl_pers_nom = New System.Windows.Forms.Label()
        Me.lbl_pers_prenom = New System.Windows.Forms.Label()
        Me.lbl_pers_age = New System.Windows.Forms.Label()
        Me.lbl_pers_fonction = New System.Windows.Forms.Label()
        Me.lbl_pers_badge = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Pict_pers_image = New System.Windows.Forms.PictureBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TabPage10 = New System.Windows.Forms.TabPage()
        Me.dgvintervenAgent = New System.Windows.Forms.DataGridView()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.dgvEvenAgent = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DGVPERSONNEL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage9.SuspendLayout()
        CType(Me.Pict_pers_image, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage10.SuspendLayout()
        CType(Me.dgvintervenAgent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgvEvenAgent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Green
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1116, 34)
        Me.Panel1.TabIndex = 0
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label14.ForeColor = System.Drawing.Color.Yellow
        Me.Label14.Location = New System.Drawing.Point(333, 4)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(242, 25)
        Me.Label14.TabIndex = 2
        Me.Label14.Text = "Information Personnel"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(74, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(209, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Liste du Personnel"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Green
        Me.Panel2.Controls.Add(Me.DGVPERSONNEL)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 34)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(336, 515)
        Me.Panel2.TabIndex = 1
        '
        'DGVPERSONNEL
        '
        Me.DGVPERSONNEL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGVPERSONNEL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVPERSONNEL.Location = New System.Drawing.Point(10, 79)
        Me.DGVPERSONNEL.Name = "DGVPERSONNEL"
        Me.DGVPERSONNEL.ReadOnly = True
        Me.DGVPERSONNEL.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DGVPERSONNEL.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVPERSONNEL.Size = New System.Drawing.Size(320, 427)
        Me.DGVPERSONNEL.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Green
        Me.Panel3.Controls.Add(Me.Label15)
        Me.Panel3.Controls.Add(Me.cmb_rechercher)
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Controls.Add(Me.Txt_recherche)
        Me.Panel3.Location = New System.Drawing.Point(10, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(320, 73)
        Me.Panel3.TabIndex = 0
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(12, 4)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(123, 18)
        Me.Label15.TabIndex = 3
        Me.Label15.Text = "rechercher par:"
        '
        'cmb_rechercher
        '
        Me.cmb_rechercher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_rechercher.FormattingEnabled = True
        Me.cmb_rechercher.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.cmb_rechercher.Items.AddRange(New Object() {"Matricule", "Nom", "Prénom"})
        Me.cmb_rechercher.Location = New System.Drawing.Point(145, 3)
        Me.cmb_rechercher.Name = "cmb_rechercher"
        Me.cmb_rechercher.Size = New System.Drawing.Size(164, 21)
        Me.cmb_rechercher.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(257, 29)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(54, 42)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Recherche"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Txt_recherche
        '
        Me.Txt_recherche.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_recherche.Location = New System.Drawing.Point(11, 35)
        Me.Txt_recherche.Name = "Txt_recherche"
        Me.Txt_recherche.Size = New System.Drawing.Size(241, 29)
        Me.Txt_recherche.TabIndex = 2
        '
        'Panel5
        '
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(336, 34)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(780, 438)
        Me.Panel5.TabIndex = 3
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Green
        Me.Panel4.Controls.Add(Me.Label20)
        Me.Panel4.Controls.Add(Me.Label18)
        Me.Panel4.Controls.Add(Me.Label17)
        Me.Panel4.Controls.Add(Me.Label21)
        Me.Panel4.Controls.Add(Me.Button3)
        Me.Panel4.Controls.Add(Me.Label19)
        Me.Panel4.Controls.Add(Me.Button2)
        Me.Panel4.Controls.Add(Me.Button7)
        Me.Panel4.Controls.Add(Me.Button8)
        Me.Panel4.Controls.Add(Me.Button9)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(336, 472)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(780, 77)
        Me.Panel4.TabIndex = 2
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Yellow
        Me.Label20.Location = New System.Drawing.Point(182, 48)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(72, 15)
        Me.Label20.TabIndex = 22
        Me.Label20.Text = "supprimer"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Yellow
        Me.Label18.Location = New System.Drawing.Point(88, 48)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(59, 15)
        Me.Label18.TabIndex = 21
        Me.Label18.Text = "modifier"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Yellow
        Me.Label17.Location = New System.Drawing.Point(1, 47)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(51, 15)
        Me.Label17.TabIndex = 20
        Me.Label17.Text = "ajouter"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Century", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Yellow
        Me.Label21.Location = New System.Drawing.Point(711, 49)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(59, 16)
        Me.Label21.TabIndex = 19
        Me.Label21.Text = "La liste"
        '
        'Button3
        '
        Me.Button3.BackgroundImage = Global.EDG_Mamou.My.Resources.Resources.printmgr
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(710, 4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(60, 45)
        Me.Button3.TabIndex = 18
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Century", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Yellow
        Me.Label19.Location = New System.Drawing.Point(573, 49)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(113, 16)
        Me.Label19.TabIndex = 16
        Me.Label19.Text = "Fiche individuel"
        '
        'Button2
        '
        Me.Button2.BackgroundImage = Global.EDG_Mamou.My.Resources.Resources.printmgr
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(597, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(60, 46)
        Me.Button2.TabIndex = 13
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.BackgroundImage = Global.EDG_Mamou.My.Resources.Resources.button_cancel
        Me.Button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button7.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(185, 6)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(65, 43)
        Me.Button7.TabIndex = 12
        Me.Button7.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.BackgroundImage = Global.EDG_Mamou.My.Resources.Resources.kate
        Me.Button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button8.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.Location = New System.Drawing.Point(90, 4)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(58, 45)
        Me.Button8.TabIndex = 11
        Me.Button8.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.BackgroundImage = Global.EDG_Mamou.My.Resources.Resources.edit_add
        Me.Button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button9.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.Location = New System.Drawing.Point(0, 4)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(53, 45)
        Me.Button9.TabIndex = 10
        Me.Button9.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button9.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage9)
        Me.TabControl1.Controls.Add(Me.TabPage10)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(336, 34)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(770, 436)
        Me.TabControl1.TabIndex = 5
        '
        'TabPage9
        '
        Me.TabPage9.BackColor = System.Drawing.Color.LightGray
        Me.TabPage9.Controls.Add(Me.lblStatut_pers)
        Me.TabPage9.Controls.Add(Me.Statut)
        Me.TabPage9.Controls.Add(Me.lbl_pers_genre)
        Me.TabPage9.Controls.Add(Me.Label26)
        Me.TabPage9.Controls.Add(Me.lbl_pers_tel)
        Me.TabPage9.Controls.Add(Me.lbl_pers_adresse)
        Me.TabPage9.Controls.Add(Me.lbl_pers_email)
        Me.TabPage9.Controls.Add(Me.lbl_pers_service)
        Me.TabPage9.Controls.Add(Me.lbl_pers_mat)
        Me.TabPage9.Controls.Add(Me.lbl_pers_nom)
        Me.TabPage9.Controls.Add(Me.lbl_pers_prenom)
        Me.TabPage9.Controls.Add(Me.lbl_pers_age)
        Me.TabPage9.Controls.Add(Me.lbl_pers_fonction)
        Me.TabPage9.Controls.Add(Me.lbl_pers_badge)
        Me.TabPage9.Controls.Add(Me.Label2)
        Me.TabPage9.Controls.Add(Me.Label13)
        Me.TabPage9.Controls.Add(Me.Label12)
        Me.TabPage9.Controls.Add(Me.Pict_pers_image)
        Me.TabPage9.Controls.Add(Me.Label10)
        Me.TabPage9.Controls.Add(Me.Label9)
        Me.TabPage9.Controls.Add(Me.Label8)
        Me.TabPage9.Controls.Add(Me.Label7)
        Me.TabPage9.Controls.Add(Me.Label3)
        Me.TabPage9.Controls.Add(Me.Label4)
        Me.TabPage9.Controls.Add(Me.Label5)
        Me.TabPage9.Controls.Add(Me.Label6)
        Me.TabPage9.Location = New System.Drawing.Point(4, 27)
        Me.TabPage9.Name = "TabPage9"
        Me.TabPage9.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage9.Size = New System.Drawing.Size(762, 405)
        Me.TabPage9.TabIndex = 0
        Me.TabPage9.Text = "Détails"
        '
        'lblStatut_pers
        '
        Me.lblStatut_pers.BackColor = System.Drawing.Color.White
        Me.lblStatut_pers.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatut_pers.Location = New System.Drawing.Point(95, 305)
        Me.lblStatut_pers.Name = "lblStatut_pers"
        Me.lblStatut_pers.Size = New System.Drawing.Size(343, 27)
        Me.lblStatut_pers.TabIndex = 47
        '
        'Statut
        '
        Me.Statut.AutoSize = True
        Me.Statut.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Statut.Location = New System.Drawing.Point(7, 308)
        Me.Statut.Name = "Statut"
        Me.Statut.Size = New System.Drawing.Size(62, 21)
        Me.Statut.TabIndex = 46
        Me.Statut.Text = "Statut :"
        '
        'lbl_pers_genre
        '
        Me.lbl_pers_genre.BackColor = System.Drawing.Color.White
        Me.lbl_pers_genre.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_pers_genre.Location = New System.Drawing.Point(540, 234)
        Me.lbl_pers_genre.Name = "lbl_pers_genre"
        Me.lbl_pers_genre.Size = New System.Drawing.Size(206, 27)
        Me.lbl_pers_genre.TabIndex = 45
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(448, 240)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(64, 21)
        Me.Label26.TabIndex = 44
        Me.Label26.Text = "Genre :"
        '
        'lbl_pers_tel
        '
        Me.lbl_pers_tel.BackColor = System.Drawing.Color.White
        Me.lbl_pers_tel.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_pers_tel.Location = New System.Drawing.Point(540, 300)
        Me.lbl_pers_tel.Name = "lbl_pers_tel"
        Me.lbl_pers_tel.Size = New System.Drawing.Size(206, 27)
        Me.lbl_pers_tel.TabIndex = 43
        '
        'lbl_pers_adresse
        '
        Me.lbl_pers_adresse.BackColor = System.Drawing.Color.White
        Me.lbl_pers_adresse.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_pers_adresse.Location = New System.Drawing.Point(540, 268)
        Me.lbl_pers_adresse.Name = "lbl_pers_adresse"
        Me.lbl_pers_adresse.Size = New System.Drawing.Size(206, 27)
        Me.lbl_pers_adresse.TabIndex = 42
        '
        'lbl_pers_email
        '
        Me.lbl_pers_email.BackColor = System.Drawing.Color.White
        Me.lbl_pers_email.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_pers_email.Location = New System.Drawing.Point(95, 271)
        Me.lbl_pers_email.Name = "lbl_pers_email"
        Me.lbl_pers_email.Size = New System.Drawing.Size(343, 27)
        Me.lbl_pers_email.TabIndex = 41
        '
        'lbl_pers_service
        '
        Me.lbl_pers_service.BackColor = System.Drawing.Color.White
        Me.lbl_pers_service.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_pers_service.Location = New System.Drawing.Point(95, 198)
        Me.lbl_pers_service.Name = "lbl_pers_service"
        Me.lbl_pers_service.Size = New System.Drawing.Size(343, 27)
        Me.lbl_pers_service.TabIndex = 40
        '
        'lbl_pers_mat
        '
        Me.lbl_pers_mat.BackColor = System.Drawing.Color.White
        Me.lbl_pers_mat.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_pers_mat.Location = New System.Drawing.Point(95, 8)
        Me.lbl_pers_mat.Name = "lbl_pers_mat"
        Me.lbl_pers_mat.Size = New System.Drawing.Size(343, 27)
        Me.lbl_pers_mat.TabIndex = 39
        '
        'lbl_pers_nom
        '
        Me.lbl_pers_nom.BackColor = System.Drawing.Color.White
        Me.lbl_pers_nom.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_pers_nom.Location = New System.Drawing.Point(95, 46)
        Me.lbl_pers_nom.Name = "lbl_pers_nom"
        Me.lbl_pers_nom.Size = New System.Drawing.Size(343, 27)
        Me.lbl_pers_nom.TabIndex = 38
        '
        'lbl_pers_prenom
        '
        Me.lbl_pers_prenom.BackColor = System.Drawing.Color.White
        Me.lbl_pers_prenom.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_pers_prenom.Location = New System.Drawing.Point(95, 84)
        Me.lbl_pers_prenom.Name = "lbl_pers_prenom"
        Me.lbl_pers_prenom.Size = New System.Drawing.Size(343, 27)
        Me.lbl_pers_prenom.TabIndex = 37
        '
        'lbl_pers_age
        '
        Me.lbl_pers_age.BackColor = System.Drawing.Color.White
        Me.lbl_pers_age.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_pers_age.Location = New System.Drawing.Point(95, 122)
        Me.lbl_pers_age.Name = "lbl_pers_age"
        Me.lbl_pers_age.Size = New System.Drawing.Size(343, 27)
        Me.lbl_pers_age.TabIndex = 36
        '
        'lbl_pers_fonction
        '
        Me.lbl_pers_fonction.BackColor = System.Drawing.Color.White
        Me.lbl_pers_fonction.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_pers_fonction.Location = New System.Drawing.Point(95, 160)
        Me.lbl_pers_fonction.Name = "lbl_pers_fonction"
        Me.lbl_pers_fonction.Size = New System.Drawing.Size(343, 27)
        Me.lbl_pers_fonction.TabIndex = 35
        '
        'lbl_pers_badge
        '
        Me.lbl_pers_badge.BackColor = System.Drawing.Color.White
        Me.lbl_pers_badge.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_pers_badge.Location = New System.Drawing.Point(95, 236)
        Me.lbl_pers_badge.Name = "lbl_pers_badge"
        Me.lbl_pers_badge.Size = New System.Drawing.Size(343, 27)
        Me.lbl_pers_badge.TabIndex = 34
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 273)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 21)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Email :"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(445, 306)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(96, 21)
        Me.Label13.TabIndex = 29
        Me.Label13.Text = "Telephone :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(448, 274)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(80, 21)
        Me.Label12.TabIndex = 27
        Me.Label12.Text = "Adresse :"
        '
        'Pict_pers_image
        '
        Me.Pict_pers_image.BackgroundImage = Global.EDG_Mamou.My.Resources.Resources.default_avatar
        Me.Pict_pers_image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Pict_pers_image.Location = New System.Drawing.Point(518, 6)
        Me.Pict_pers_image.Name = "Pict_pers_image"
        Me.Pict_pers_image.Size = New System.Drawing.Size(228, 214)
        Me.Pict_pers_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pict_pers_image.TabIndex = 25
        Me.Pict_pers_image.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(7, 239)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(92, 21)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "Badge N° :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(7, 126)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(77, 21)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Né(e) le :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(7, 204)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 21)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Service :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 215)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(0, 21)
        Me.Label7.TabIndex = 17
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(5, 165)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 21)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Fonction :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(5, 87)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 21)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Prenom :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(5, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 21)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Nom :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(5, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 21)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Matricule :"
        '
        'TabPage10
        '
        Me.TabPage10.Controls.Add(Me.dgvintervenAgent)
        Me.TabPage10.Controls.Add(Me.Label11)
        Me.TabPage10.Location = New System.Drawing.Point(4, 27)
        Me.TabPage10.Name = "TabPage10"
        Me.TabPage10.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage10.Size = New System.Drawing.Size(762, 405)
        Me.TabPage10.TabIndex = 1
        Me.TabPage10.Text = "Intervention"
        Me.TabPage10.UseVisualStyleBackColor = True
        '
        'dgvintervenAgent
        '
        Me.dgvintervenAgent.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvintervenAgent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvintervenAgent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvintervenAgent.Location = New System.Drawing.Point(6, 38)
        Me.dgvintervenAgent.Name = "dgvintervenAgent"
        Me.dgvintervenAgent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvintervenAgent.Size = New System.Drawing.Size(750, 361)
        Me.dgvintervenAgent.TabIndex = 2
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold)
        Me.Label11.Location = New System.Drawing.Point(130, 2)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(489, 33)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "Interventions réalisées par l'Agent"
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label16)
        Me.TabPage1.Controls.Add(Me.dgvEvenAgent)
        Me.TabPage1.Location = New System.Drawing.Point(4, 27)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(762, 405)
        Me.TabPage1.TabIndex = 2
        Me.TabPage1.Text = "Evenement"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold)
        Me.Label16.Location = New System.Drawing.Point(158, 3)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(438, 33)
        Me.Label16.TabIndex = 4
        Me.Label16.Text = "Evenement concernant l'Agent"
        '
        'dgvEvenAgent
        '
        Me.dgvEvenAgent.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvEvenAgent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvEvenAgent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEvenAgent.Location = New System.Drawing.Point(6, 42)
        Me.dgvEvenAgent.Name = "dgvEvenAgent"
        Me.dgvEvenAgent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvEvenAgent.Size = New System.Drawing.Size(750, 357)
        Me.dgvEvenAgent.TabIndex = 3
        '
        'usercontroler2_personnel
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.Green
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "usercontroler2_personnel"
        Me.Size = New System.Drawing.Size(1116, 549)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.DGVPERSONNEL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage9.ResumeLayout(False)
        Me.TabPage9.PerformLayout()
        CType(Me.Pict_pers_image, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage10.ResumeLayout(False)
        Me.TabPage10.PerformLayout()
        CType(Me.dgvintervenAgent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.dgvEvenAgent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Txt_recherche As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage9 As System.Windows.Forms.TabPage
    Friend WithEvents lbl_pers_genre As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents lbl_pers_tel As System.Windows.Forms.Label
    Friend WithEvents lbl_pers_adresse As System.Windows.Forms.Label
    Friend WithEvents lbl_pers_email As System.Windows.Forms.Label
    Friend WithEvents lbl_pers_service As System.Windows.Forms.Label
    Friend WithEvents lbl_pers_mat As System.Windows.Forms.Label
    Friend WithEvents lbl_pers_nom As System.Windows.Forms.Label
    Friend WithEvents lbl_pers_prenom As System.Windows.Forms.Label
    Friend WithEvents lbl_pers_age As System.Windows.Forms.Label
    Friend WithEvents lbl_pers_fonction As System.Windows.Forms.Label
    Friend WithEvents lbl_pers_badge As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Pict_pers_image As System.Windows.Forms.PictureBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TabPage10 As System.Windows.Forms.TabPage
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents DGVPERSONNEL As System.Windows.Forms.DataGridView
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents cmb_rechercher As System.Windows.Forms.ComboBox
    Friend WithEvents lblStatut_pers As System.Windows.Forms.Label
    Friend WithEvents Statut As System.Windows.Forms.Label
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents dgvintervenAgent As System.Windows.Forms.DataGridView
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents dgvEvenAgent As System.Windows.Forms.DataGridView
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label

End Class
