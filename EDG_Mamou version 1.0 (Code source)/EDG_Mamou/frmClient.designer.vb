<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClient
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmClient))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblannuler = New System.Windows.Forms.Label()
        Me.lblmodifiercl = New System.Windows.Forms.Label()
        Me.lblajoutcli = New System.Windows.Forms.Label()
        Me.txtmail_cl = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnmodifier_cl = New System.Windows.Forms.Button()
        Me.TbPhoto = New System.Windows.Forms.TextBox()
        Me.DatNaissCL = New System.Windows.Forms.DateTimePicker()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.lbltitre_cl = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.txtPrenom = New System.Windows.Forms.TextBox()
        Me.txtAdresse = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.rbF = New System.Windows.Forms.RadioButton()
        Me.rbM = New System.Windows.Forms.RadioButton()
        Me.btnvalider_cl = New System.Windows.Forms.Button()
        Me.txtTelephone = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtNom = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblannuler)
        Me.Panel1.Controls.Add(Me.lblmodifiercl)
        Me.Panel1.Controls.Add(Me.lblajoutcli)
        Me.Panel1.Controls.Add(Me.txtmail_cl)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.btnmodifier_cl)
        Me.Panel1.Controls.Add(Me.TbPhoto)
        Me.Panel1.Controls.Add(Me.DatNaissCL)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.lbltitre_cl)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.txtPrenom)
        Me.Panel1.Controls.Add(Me.txtAdresse)
        Me.Panel1.Controls.Add(Me.GroupBox4)
        Me.Panel1.Controls.Add(Me.btnvalider_cl)
        Me.Panel1.Controls.Add(Me.txtTelephone)
        Me.Panel1.Controls.Add(Me.Label21)
        Me.Panel1.Controls.Add(Me.txtNom)
        Me.Panel1.Controls.Add(Me.Label23)
        Me.Panel1.Controls.Add(Me.Label24)
        Me.Panel1.Controls.Add(Me.Label25)
        Me.Panel1.Controls.Add(Me.Label27)
        Me.Panel1.Controls.Add(Me.txtNumero)
        Me.Panel1.Controls.Add(Me.Label28)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(619, 582)
        Me.Panel1.TabIndex = 0
        '
        'lblannuler
        '
        Me.lblannuler.AutoSize = True
        Me.lblannuler.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblannuler.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblannuler.Location = New System.Drawing.Point(528, 553)
        Me.lblannuler.Name = "lblannuler"
        Me.lblannuler.Size = New System.Drawing.Size(56, 15)
        Me.lblannuler.TabIndex = 97
        Me.lblannuler.Text = "Annuler"
        '
        'lblmodifiercl
        '
        Me.lblmodifiercl.AutoSize = True
        Me.lblmodifiercl.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmodifiercl.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblmodifiercl.Location = New System.Drawing.Point(430, 553)
        Me.lblmodifiercl.Name = "lblmodifiercl"
        Me.lblmodifiercl.Size = New System.Drawing.Size(58, 15)
        Me.lblmodifiercl.TabIndex = 96
        Me.lblmodifiercl.Text = "Modifier"
        '
        'lblajoutcli
        '
        Me.lblajoutcli.AutoSize = True
        Me.lblajoutcli.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblajoutcli.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblajoutcli.Location = New System.Drawing.Point(345, 553)
        Me.lblajoutcli.Name = "lblajoutcli"
        Me.lblajoutcli.Size = New System.Drawing.Size(52, 15)
        Me.lblajoutcli.TabIndex = 95
        Me.lblajoutcli.Text = "Ajouter"
        '
        'txtmail_cl
        '
        Me.txtmail_cl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtmail_cl.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmail_cl.Location = New System.Drawing.Point(106, 347)
        Me.txtmail_cl.MaxLength = 200
        Me.txtmail_cl.Name = "txtmail_cl"
        Me.txtmail_cl.Size = New System.Drawing.Size(248, 26)
        Me.txtmail_cl.TabIndex = 93
        Me.txtmail_cl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 348)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 21)
        Me.Label2.TabIndex = 94
        Me.Label2.Text = "E-Mail"
        '
        'btnmodifier_cl
        '
        Me.btnmodifier_cl.BackgroundImage = Global.EDG_Mamou.My.Resources.Resources.kate
        Me.btnmodifier_cl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnmodifier_cl.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmodifier_cl.Location = New System.Drawing.Point(423, 493)
        Me.btnmodifier_cl.Name = "btnmodifier_cl"
        Me.btnmodifier_cl.Size = New System.Drawing.Size(78, 57)
        Me.btnmodifier_cl.TabIndex = 92
        Me.btnmodifier_cl.UseVisualStyleBackColor = True
        '
        'TbPhoto
        '
        Me.TbPhoto.Location = New System.Drawing.Point(404, 347)
        Me.TbPhoto.Name = "TbPhoto"
        Me.TbPhoto.Size = New System.Drawing.Size(100, 20)
        Me.TbPhoto.TabIndex = 91
        Me.TbPhoto.Visible = False
        '
        'DatNaissCL
        '
        Me.DatNaissCL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DatNaissCL.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DatNaissCL.Location = New System.Drawing.Point(106, 299)
        Me.DatNaissCL.Name = "DatNaissCL"
        Me.DatNaissCL.Size = New System.Drawing.Size(248, 26)
        Me.DatNaissCL.TabIndex = 90
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(404, 304)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(200, 35)
        Me.Button2.TabIndex = 89
        Me.Button2.Text = "Choisir une image"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'lbltitre_cl
        '
        Me.lbltitre_cl.BackColor = System.Drawing.Color.Green
        Me.lbltitre_cl.Dock = System.Windows.Forms.DockStyle.Top
        Me.lbltitre_cl.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitre_cl.ForeColor = System.Drawing.Color.Yellow
        Me.lbltitre_cl.Location = New System.Drawing.Point(0, 0)
        Me.lbltitre_cl.Name = "lbltitre_cl"
        Me.lbltitre_cl.Size = New System.Drawing.Size(619, 50)
        Me.lbltitre_cl.TabIndex = 88
        Me.lbltitre_cl.Text = "Gestion des Clients"
        Me.lbltitre_cl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Location = New System.Drawing.Point(404, 97)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(200, 194)
        Me.Panel2.TabIndex = 86
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(200, 194)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Button3
        '
        Me.Button3.BackgroundImage = Global.EDG_Mamou.My.Resources.Resources.editdelete
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(520, 493)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(73, 57)
        Me.Button3.TabIndex = 77
        Me.Button3.UseVisualStyleBackColor = True
        '
        'txtPrenom
        '
        Me.txtPrenom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPrenom.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrenom.Location = New System.Drawing.Point(106, 172)
        Me.txtPrenom.MaxLength = 40
        Me.txtPrenom.Name = "txtPrenom"
        Me.txtPrenom.Size = New System.Drawing.Size(248, 26)
        Me.txtPrenom.TabIndex = 72
        Me.txtPrenom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtAdresse
        '
        Me.txtAdresse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAdresse.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdresse.Location = New System.Drawing.Point(106, 217)
        Me.txtAdresse.MaxLength = 40
        Me.txtAdresse.Name = "txtAdresse"
        Me.txtAdresse.Size = New System.Drawing.Size(248, 26)
        Me.txtAdresse.TabIndex = 73
        Me.txtAdresse.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.rbF)
        Me.GroupBox4.Controls.Add(Me.rbM)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.Green
        Me.GroupBox4.Location = New System.Drawing.Point(16, 403)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(342, 58)
        Me.GroupBox4.TabIndex = 85
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Genre"
        '
        'rbF
        '
        Me.rbF.AutoSize = True
        Me.rbF.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbF.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rbF.Location = New System.Drawing.Point(101, 28)
        Me.rbF.Name = "rbF"
        Me.rbF.Size = New System.Drawing.Size(85, 23)
        Me.rbF.TabIndex = 7
        Me.rbF.TabStop = True
        Me.rbF.Text = "Feminin"
        Me.rbF.UseVisualStyleBackColor = True
        '
        'rbM
        '
        Me.rbM.AutoSize = True
        Me.rbM.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbM.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rbM.Location = New System.Drawing.Point(6, 28)
        Me.rbM.Name = "rbM"
        Me.rbM.Size = New System.Drawing.Size(89, 23)
        Me.rbM.TabIndex = 6
        Me.rbM.TabStop = True
        Me.rbM.Text = "Masculin"
        Me.rbM.UseVisualStyleBackColor = True
        '
        'btnvalider_cl
        '
        Me.btnvalider_cl.BackgroundImage = Global.EDG_Mamou.My.Resources.Resources.apply
        Me.btnvalider_cl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnvalider_cl.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnvalider_cl.Location = New System.Drawing.Point(338, 493)
        Me.btnvalider_cl.Name = "btnvalider_cl"
        Me.btnvalider_cl.Size = New System.Drawing.Size(70, 57)
        Me.btnvalider_cl.TabIndex = 76
        Me.btnvalider_cl.UseVisualStyleBackColor = True
        '
        'txtTelephone
        '
        Me.txtTelephone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTelephone.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelephone.Location = New System.Drawing.Point(106, 258)
        Me.txtTelephone.MaxLength = 18
        Me.txtTelephone.Name = "txtTelephone"
        Me.txtTelephone.Size = New System.Drawing.Size(248, 26)
        Me.txtTelephone.TabIndex = 74
        Me.txtTelephone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(12, 259)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(88, 21)
        Me.Label21.TabIndex = 84
        Me.Label21.Text = "Téléphone"
        '
        'txtNom
        '
        Me.txtNom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNom.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNom.Location = New System.Drawing.Point(106, 129)
        Me.txtNom.MaxLength = 25
        Me.txtNom.Name = "txtNom"
        Me.txtNom.Size = New System.Drawing.Size(248, 26)
        Me.txtNom.TabIndex = 71
        Me.txtNom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(12, 173)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(68, 21)
        Me.Label23.TabIndex = 83
        Me.Label23.Text = "Prénom"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(12, 130)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(47, 21)
        Me.Label24.TabIndex = 82
        Me.Label24.Text = "Nom"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(12, 299)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(40, 21)
        Me.Label25.TabIndex = 81
        Me.Label25.Text = "Age"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(12, 218)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(71, 21)
        Me.Label27.TabIndex = 80
        Me.Label27.Text = "Adresse"
        '
        'txtNumero
        '
        Me.txtNumero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNumero.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumero.Location = New System.Drawing.Point(106, 89)
        Me.txtNumero.MaxLength = 10
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.ReadOnly = True
        Me.txtNumero.Size = New System.Drawing.Size(248, 26)
        Me.txtNumero.TabIndex = 70
        Me.txtNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(12, 90)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(70, 21)
        Me.Label28.TabIndex = 79
        Me.Label28.Text = "Numéro"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'frmClient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(619, 582)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmClient"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CLIENT"
        Me.TopMost = True
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents lbltitre_cl As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents txtPrenom As System.Windows.Forms.TextBox
    Friend WithEvents txtAdresse As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents rbF As System.Windows.Forms.RadioButton
    Friend WithEvents rbM As System.Windows.Forms.RadioButton
    Friend WithEvents btnvalider_cl As System.Windows.Forms.Button
    Friend WithEvents txtTelephone As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtNom As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents txtNumero As System.Windows.Forms.TextBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents DatNaissCL As System.Windows.Forms.DateTimePicker
    Friend WithEvents TbPhoto As System.Windows.Forms.TextBox
    Friend WithEvents btnmodifier_cl As System.Windows.Forms.Button
    Friend WithEvents txtmail_cl As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblannuler As System.Windows.Forms.Label
    Friend WithEvents lblmodifiercl As System.Windows.Forms.Label
    Friend WithEvents lblajoutcli As System.Windows.Forms.Label
End Class
