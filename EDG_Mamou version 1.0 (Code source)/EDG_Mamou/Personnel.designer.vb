<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Personnel
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Personnel))
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.datNaissPers = New System.Windows.Forms.DateTimePicker()
        Me.gbx = New System.Windows.Forms.GroupBox()
        Me.rbFpers = New System.Windows.Forms.RadioButton()
        Me.rbMpers = New System.Windows.Forms.RadioButton()
        Me.txtadresse = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtTel = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtMail = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnImg = New System.Windows.Forms.Button()
        Me.txtbadge = New System.Windows.Forms.TextBox()
        Me.txtPre = New System.Windows.Forms.TextBox()
        Me.txtNom = New System.Windows.Forms.TextBox()
        Me.txtMat = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.BtnValide_pers = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.picbxPerson = New System.Windows.Forms.PictureBox()
        Me.TbPhoto = New System.Windows.Forms.TextBox()
        Me.txtfonc = New System.Windows.Forms.TextBox()
        Me.BtnModifier_pers = New System.Windows.Forms.Button()
        Me.txtser = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbx_statut_pers = New System.Windows.Forms.ComboBox()
        Me.lblajout = New System.Windows.Forms.Label()
        Me.lblmodifier = New System.Windows.Forms.Label()
        Me.lblannuler = New System.Windows.Forms.Label()
        Me.gbx.SuspendLayout()
        CType(Me.picbxPerson, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'datNaissPers
        '
        Me.datNaissPers.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datNaissPers.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datNaissPers.Location = New System.Drawing.Point(131, 239)
        Me.datNaissPers.Name = "datNaissPers"
        Me.datNaissPers.Size = New System.Drawing.Size(284, 26)
        Me.datNaissPers.TabIndex = 50
        '
        'gbx
        '
        Me.gbx.Controls.Add(Me.rbFpers)
        Me.gbx.Controls.Add(Me.rbMpers)
        Me.gbx.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbx.Location = New System.Drawing.Point(448, 278)
        Me.gbx.Name = "gbx"
        Me.gbx.Size = New System.Drawing.Size(299, 59)
        Me.gbx.TabIndex = 49
        Me.gbx.TabStop = False
        Me.gbx.Text = "Genre"
        '
        'rbFpers
        '
        Me.rbFpers.AutoSize = True
        Me.rbFpers.Location = New System.Drawing.Point(174, 28)
        Me.rbFpers.Name = "rbFpers"
        Me.rbFpers.Size = New System.Drawing.Size(87, 25)
        Me.rbFpers.TabIndex = 1
        Me.rbFpers.TabStop = True
        Me.rbFpers.Text = "Feminin"
        Me.rbFpers.UseVisualStyleBackColor = True
        '
        'rbMpers
        '
        Me.rbMpers.AutoSize = True
        Me.rbMpers.Location = New System.Drawing.Point(18, 28)
        Me.rbMpers.Name = "rbMpers"
        Me.rbMpers.Size = New System.Drawing.Size(95, 25)
        Me.rbMpers.TabIndex = 0
        Me.rbMpers.TabStop = True
        Me.rbMpers.Text = "Masculin"
        Me.rbMpers.UseVisualStyleBackColor = True
        '
        'txtadresse
        '
        Me.txtadresse.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtadresse.Location = New System.Drawing.Point(535, 353)
        Me.txtadresse.Name = "txtadresse"
        Me.txtadresse.Size = New System.Drawing.Size(253, 26)
        Me.txtadresse.TabIndex = 48
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(444, 356)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(71, 21)
        Me.Label12.TabIndex = 47
        Me.Label12.Text = "Adresse"
        '
        'txtTel
        '
        Me.txtTel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTel.Location = New System.Drawing.Point(535, 400)
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Size = New System.Drawing.Size(253, 26)
        Me.txtTel.TabIndex = 46
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(442, 405)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(87, 21)
        Me.Label11.TabIndex = 45
        Me.Label11.Text = "Telephone"
        '
        'txtMail
        '
        Me.txtMail.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMail.Location = New System.Drawing.Point(535, 447)
        Me.txtMail.MaxLength = 200
        Me.txtMail.Name = "txtMail"
        Me.txtMail.Size = New System.Drawing.Size(253, 26)
        Me.txtMail.TabIndex = 44
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(444, 454)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(59, 21)
        Me.Label10.TabIndex = 43
        Me.Label10.Text = "E-Mail"
        '
        'btnImg
        '
        Me.btnImg.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImg.Location = New System.Drawing.Point(535, 242)
        Me.btnImg.Name = "btnImg"
        Me.btnImg.Size = New System.Drawing.Size(178, 30)
        Me.btnImg.TabIndex = 42
        Me.btnImg.Text = "Choisir une Image"
        Me.btnImg.UseVisualStyleBackColor = True
        '
        'txtbadge
        '
        Me.txtbadge.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbadge.Location = New System.Drawing.Point(131, 396)
        Me.txtbadge.Name = "txtbadge"
        Me.txtbadge.Size = New System.Drawing.Size(284, 26)
        Me.txtbadge.TabIndex = 39
        '
        'txtPre
        '
        Me.txtPre.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPre.Location = New System.Drawing.Point(131, 187)
        Me.txtPre.Name = "txtPre"
        Me.txtPre.Size = New System.Drawing.Size(284, 26)
        Me.txtPre.TabIndex = 36
        '
        'txtNom
        '
        Me.txtNom.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNom.Location = New System.Drawing.Point(131, 135)
        Me.txtNom.Name = "txtNom"
        Me.txtNom.Size = New System.Drawing.Size(284, 26)
        Me.txtNom.TabIndex = 35
        '
        'txtMat
        '
        Me.txtMat.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMat.Location = New System.Drawing.Point(131, 83)
        Me.txtMat.Name = "txtMat"
        Me.txtMat.Size = New System.Drawing.Size(284, 26)
        Me.txtMat.TabIndex = 34
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(14, 403)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(102, 19)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "Numero Badge"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(14, 350)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 21)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "Service"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(14, 297)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 21)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "fonction"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(14, 191)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 21)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Prenom"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 138)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 21)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Nom"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 21)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Matricule"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(14, 244)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 21)
        Me.Label3.TabIndex = 51
        Me.Label3.Text = "Né(e) le"
        '
        'Button3
        '
        Me.Button3.BackgroundImage = Global.EDG_Mamou.My.Resources.Resources.editdelete
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(719, 493)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(71, 60)
        Me.Button3.TabIndex = 53
        Me.Button3.UseVisualStyleBackColor = True
        '
        'BtnValide_pers
        '
        Me.BtnValide_pers.BackgroundImage = Global.EDG_Mamou.My.Resources.Resources.apply
        Me.BtnValide_pers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnValide_pers.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnValide_pers.Location = New System.Drawing.Point(550, 493)
        Me.BtnValide_pers.Name = "BtnValide_pers"
        Me.BtnValide_pers.Size = New System.Drawing.Size(69, 60)
        Me.BtnValide_pers.TabIndex = 52
        Me.BtnValide_pers.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Green
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Yellow
        Me.Label5.Location = New System.Drawing.Point(0, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(841, 58)
        Me.Label5.TabIndex = 54
        Me.Label5.Text = "Gestion des Personnels"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picbxPerson
        '
        Me.picbxPerson.BackgroundImage = Global.EDG_Mamou.My.Resources.Resources.default_avatar1
        Me.picbxPerson.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picbxPerson.Location = New System.Drawing.Point(535, 72)
        Me.picbxPerson.Name = "picbxPerson"
        Me.picbxPerson.Size = New System.Drawing.Size(178, 164)
        Me.picbxPerson.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picbxPerson.TabIndex = 41
        Me.picbxPerson.TabStop = False
        '
        'TbPhoto
        '
        Me.TbPhoto.Location = New System.Drawing.Point(719, 143)
        Me.TbPhoto.Name = "TbPhoto"
        Me.TbPhoto.Size = New System.Drawing.Size(71, 20)
        Me.TbPhoto.TabIndex = 55
        Me.TbPhoto.Visible = False
        '
        'txtfonc
        '
        Me.txtfonc.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfonc.Location = New System.Drawing.Point(131, 291)
        Me.txtfonc.Name = "txtfonc"
        Me.txtfonc.Size = New System.Drawing.Size(284, 26)
        Me.txtfonc.TabIndex = 37
        '
        'BtnModifier_pers
        '
        Me.BtnModifier_pers.BackgroundImage = Global.EDG_Mamou.My.Resources.Resources.kate
        Me.BtnModifier_pers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnModifier_pers.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnModifier_pers.Location = New System.Drawing.Point(635, 493)
        Me.BtnModifier_pers.Name = "BtnModifier_pers"
        Me.BtnModifier_pers.Size = New System.Drawing.Size(68, 60)
        Me.BtnModifier_pers.TabIndex = 58
        Me.BtnModifier_pers.UseVisualStyleBackColor = True
        '
        'txtser
        '
        Me.txtser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtser.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.txtser.FormattingEnabled = True
        Me.txtser.Location = New System.Drawing.Point(131, 343)
        Me.txtser.Name = "txtser"
        Me.txtser.Size = New System.Drawing.Size(284, 27)
        Me.txtser.TabIndex = 59
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(17, 454)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(53, 21)
        Me.Label9.TabIndex = 56
        Me.Label9.Text = "Statut"
        '
        'cbx_statut_pers
        '
        Me.cbx_statut_pers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_statut_pers.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbx_statut_pers.FormattingEnabled = True
        Me.cbx_statut_pers.Items.AddRange(New Object() {"En Service", "Hors Service"})
        Me.cbx_statut_pers.Location = New System.Drawing.Point(131, 448)
        Me.cbx_statut_pers.Name = "cbx_statut_pers"
        Me.cbx_statut_pers.Size = New System.Drawing.Size(284, 27)
        Me.cbx_statut_pers.TabIndex = 57
        '
        'lblajout
        '
        Me.lblajout.AutoSize = True
        Me.lblajout.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblajout.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblajout.Location = New System.Drawing.Point(556, 556)
        Me.lblajout.Name = "lblajout"
        Me.lblajout.Size = New System.Drawing.Size(51, 15)
        Me.lblajout.TabIndex = 60
        Me.lblajout.Text = "ajouter"
        '
        'lblmodifier
        '
        Me.lblmodifier.AutoSize = True
        Me.lblmodifier.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmodifier.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblmodifier.Location = New System.Drawing.Point(639, 556)
        Me.lblmodifier.Name = "lblmodifier"
        Me.lblmodifier.Size = New System.Drawing.Size(59, 15)
        Me.lblmodifier.TabIndex = 61
        Me.lblmodifier.Text = "modifier"
        '
        'lblannuler
        '
        Me.lblannuler.AutoSize = True
        Me.lblannuler.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblannuler.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblannuler.Location = New System.Drawing.Point(727, 556)
        Me.lblannuler.Name = "lblannuler"
        Me.lblannuler.Size = New System.Drawing.Size(55, 15)
        Me.lblannuler.TabIndex = 62
        Me.lblannuler.Text = "annuler"
        '
        'Personnel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(841, 581)
        Me.Controls.Add(Me.lblannuler)
        Me.Controls.Add(Me.lblmodifier)
        Me.Controls.Add(Me.lblajout)
        Me.Controls.Add(Me.txtser)
        Me.Controls.Add(Me.BtnModifier_pers)
        Me.Controls.Add(Me.cbx_statut_pers)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TbPhoto)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.BtnValide_pers)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.datNaissPers)
        Me.Controls.Add(Me.gbx)
        Me.Controls.Add(Me.txtadresse)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtTel)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtMail)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btnImg)
        Me.Controls.Add(Me.picbxPerson)
        Me.Controls.Add(Me.txtbadge)
        Me.Controls.Add(Me.txtfonc)
        Me.Controls.Add(Me.txtPre)
        Me.Controls.Add(Me.txtNom)
        Me.Controls.Add(Me.txtMat)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Personnel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestion du Personnel"
        Me.gbx.ResumeLayout(False)
        Me.gbx.PerformLayout()
        CType(Me.picbxPerson, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents datNaissPers As System.Windows.Forms.DateTimePicker
    Friend WithEvents gbx As System.Windows.Forms.GroupBox
    Friend WithEvents txtadresse As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtTel As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtMail As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnImg As System.Windows.Forms.Button
    Friend WithEvents picbxPerson As System.Windows.Forms.PictureBox
    Friend WithEvents txtbadge As System.Windows.Forms.TextBox
    Friend WithEvents txtPre As System.Windows.Forms.TextBox
    Friend WithEvents txtNom As System.Windows.Forms.TextBox
    Friend WithEvents txtMat As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents BtnValide_pers As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents rbFpers As System.Windows.Forms.RadioButton
    Friend WithEvents rbMpers As System.Windows.Forms.RadioButton
    Friend WithEvents TbPhoto As System.Windows.Forms.TextBox
    Friend WithEvents txtfonc As System.Windows.Forms.TextBox
    Friend WithEvents BtnModifier_pers As System.Windows.Forms.Button
    Friend WithEvents txtser As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cbx_statut_pers As System.Windows.Forms.ComboBox
    Friend WithEvents lblajout As System.Windows.Forms.Label
    Friend WithEvents lblmodifier As System.Windows.Forms.Label
    Friend WithEvents lblannuler As System.Windows.Forms.Label

End Class
