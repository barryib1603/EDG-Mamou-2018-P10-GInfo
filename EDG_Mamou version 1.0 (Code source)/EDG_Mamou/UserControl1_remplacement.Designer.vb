<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl1_remplacement
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
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txt_ancien_puis_remplacemt = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.dtp_rechercher = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txt_rechercher = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmb_rechercher = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtnouv_puis_remplacemt = New System.Windows.Forms.TextBox()
        Me.txtnum_remplacement = New System.Windows.Forms.TextBox()
        Me.dtp_remplace = New System.Windows.Forms.DateTimePicker()
        Me.btn_suppr = New System.Windows.Forms.Button()
        Me.btn_modif = New System.Windows.Forms.Button()
        Me.cbxposte_remplacment = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.dgv_remplacement = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.dgv_remplacement, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Green
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1044, 36)
        Me.Panel1.TabIndex = 0
        '
        'Label11
        '
        Me.Label11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Yellow
        Me.Label11.Location = New System.Drawing.Point(350, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(694, 36)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "Liste des Remplacements"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Yellow
        Me.Label10.Location = New System.Drawing.Point(0, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(350, 36)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Gestion des Remplacements"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Green
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.Label17)
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.Label18)
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.txt_ancien_puis_remplacemt)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.txtnouv_puis_remplacemt)
        Me.Panel2.Controls.Add(Me.txtnum_remplacement)
        Me.Panel2.Controls.Add(Me.dtp_remplace)
        Me.Panel2.Controls.Add(Me.btn_suppr)
        Me.Panel2.Controls.Add(Me.btn_modif)
        Me.Panel2.Controls.Add(Me.cbxposte_remplacment)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Button5)
        Me.Panel2.Controls.Add(Me.Button6)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 36)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(380, 447)
        Me.Panel2.TabIndex = 1
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Yellow
        Me.Label13.Location = New System.Drawing.Point(142, 254)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(56, 15)
        Me.Label13.TabIndex = 93
        Me.Label13.Text = "Annuler"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Yellow
        Me.Label17.Location = New System.Drawing.Point(70, 254)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(58, 15)
        Me.Label17.TabIndex = 92
        Me.Label17.Text = "Modifier"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Yellow
        Me.Label14.Location = New System.Drawing.Point(3, 254)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(52, 15)
        Me.Label14.TabIndex = 91
        Me.Label14.Text = "Ajouter"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Yellow
        Me.Label12.Location = New System.Drawing.Point(212, 254)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(76, 15)
        Me.Label12.TabIndex = 90
        Me.Label12.Text = "Impression"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Yellow
        Me.Label18.Location = New System.Drawing.Point(303, 254)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(73, 15)
        Me.Label18.TabIndex = 89
        Me.Label18.Text = "Supprimer"
        '
        'Button2
        '
        Me.Button2.BackgroundImage = Global.EDG_Mamou.My.Resources.Resources.printmgr
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(222, 204)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(62, 43)
        Me.Button2.TabIndex = 88
        Me.Button2.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txt_ancien_puis_remplacemt
        '
        Me.txt_ancien_puis_remplacemt.Enabled = False
        Me.txt_ancien_puis_remplacemt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold)
        Me.txt_ancien_puis_remplacemt.Location = New System.Drawing.Point(178, 83)
        Me.txt_ancien_puis_remplacemt.Name = "txt_ancien_puis_remplacemt"
        Me.txt_ancien_puis_remplacemt.Size = New System.Drawing.Size(123, 27)
        Me.txt_ancien_puis_remplacemt.TabIndex = 87
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Yellow
        Me.Label8.Location = New System.Drawing.Point(304, 87)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 22)
        Me.Label8.TabIndex = 86
        Me.Label8.Text = "kVA"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Yellow
        Me.Label9.Location = New System.Drawing.Point(10, 84)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(171, 22)
        Me.Label9.TabIndex = 85
        Me.Label9.Text = "Ancienne Puissance"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Green
        Me.Panel4.Controls.Add(Me.dtp_rechercher)
        Me.Panel4.Controls.Add(Me.Button1)
        Me.Panel4.Controls.Add(Me.txt_rechercher)
        Me.Panel4.Controls.Add(Me.Label7)
        Me.Panel4.Controls.Add(Me.cmb_rechercher)
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Location = New System.Drawing.Point(5, 291)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(346, 144)
        Me.Panel4.TabIndex = 84
        '
        'dtp_rechercher
        '
        Me.dtp_rechercher.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.dtp_rechercher.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_rechercher.Location = New System.Drawing.Point(7, 97)
        Me.dtp_rechercher.Name = "dtp_rechercher"
        Me.dtp_rechercher.Size = New System.Drawing.Size(267, 26)
        Me.dtp_rechercher.TabIndex = 85
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.EDG_Mamou.My.Resources.Resources.kghostview
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(280, 83)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(49, 48)
        Me.Button1.TabIndex = 85
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txt_rechercher
        '
        Me.txt_rechercher.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold)
        Me.txt_rechercher.Location = New System.Drawing.Point(7, 96)
        Me.txt_rechercher.Name = "txt_rechercher"
        Me.txt_rechercher.Size = New System.Drawing.Size(265, 27)
        Me.txt_rechercher.TabIndex = 85
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Yellow
        Me.Label7.Location = New System.Drawing.Point(4, 52)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(128, 18)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "rechercher par :"
        '
        'cmb_rechercher
        '
        Me.cmb_rechercher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_rechercher.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold)
        Me.cmb_rechercher.FormattingEnabled = True
        Me.cmb_rechercher.Items.AddRange(New Object() {"Numéro", "Poste", "Date"})
        Me.cmb_rechercher.Location = New System.Drawing.Point(138, 49)
        Me.cmb_rechercher.Name = "cmb_rechercher"
        Me.cmb_rechercher.Size = New System.Drawing.Size(191, 28)
        Me.cmb_rechercher.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Green
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Yellow
        Me.Label6.Location = New System.Drawing.Point(0, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(346, 37)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Rechercher"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtnouv_puis_remplacemt
        '
        Me.txtnouv_puis_remplacemt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold)
        Me.txtnouv_puis_remplacemt.Location = New System.Drawing.Point(178, 120)
        Me.txtnouv_puis_remplacemt.Name = "txtnouv_puis_remplacemt"
        Me.txtnouv_puis_remplacemt.Size = New System.Drawing.Size(123, 27)
        Me.txtnouv_puis_remplacemt.TabIndex = 83
        '
        'txtnum_remplacement
        '
        Me.txtnum_remplacement.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnum_remplacement.Location = New System.Drawing.Point(93, 8)
        Me.txtnum_remplacement.Name = "txtnum_remplacement"
        Me.txtnum_remplacement.Size = New System.Drawing.Size(255, 27)
        Me.txtnum_remplacement.TabIndex = 82
        '
        'dtp_remplace
        '
        Me.dtp_remplace.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.dtp_remplace.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_remplace.Location = New System.Drawing.Point(92, 157)
        Me.dtp_remplace.Name = "dtp_remplace"
        Me.dtp_remplace.Size = New System.Drawing.Size(254, 26)
        Me.dtp_remplace.TabIndex = 81
        '
        'btn_suppr
        '
        Me.btn_suppr.BackgroundImage = Global.EDG_Mamou.My.Resources.Resources.button_cancel
        Me.btn_suppr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_suppr.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_suppr.Location = New System.Drawing.Point(307, 204)
        Me.btn_suppr.Name = "btn_suppr"
        Me.btn_suppr.Size = New System.Drawing.Size(62, 43)
        Me.btn_suppr.TabIndex = 80
        Me.btn_suppr.UseVisualStyleBackColor = True
        '
        'btn_modif
        '
        Me.btn_modif.BackgroundImage = Global.EDG_Mamou.My.Resources.Resources.kate
        Me.btn_modif.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_modif.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_modif.Location = New System.Drawing.Point(70, 204)
        Me.btn_modif.Name = "btn_modif"
        Me.btn_modif.Size = New System.Drawing.Size(59, 43)
        Me.btn_modif.TabIndex = 79
        Me.btn_modif.UseVisualStyleBackColor = True
        '
        'cbxposte_remplacment
        '
        Me.cbxposte_remplacment.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxposte_remplacment.FormattingEnabled = True
        Me.cbxposte_remplacment.Location = New System.Drawing.Point(93, 45)
        Me.cbxposte_remplacment.Name = "cbxposte_remplacment"
        Me.cbxposte_remplacment.Size = New System.Drawing.Size(255, 28)
        Me.cbxposte_remplacment.TabIndex = 78
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Yellow
        Me.Label5.Location = New System.Drawing.Point(304, 120)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 22)
        Me.Label5.TabIndex = 77
        Me.Label5.Text = "kVA"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(10, 160)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 22)
        Me.Label1.TabIndex = 76
        Me.Label1.Text = "Date"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Yellow
        Me.Label2.Location = New System.Drawing.Point(10, 122)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(167, 22)
        Me.Label2.TabIndex = 73
        Me.Label2.Text = "Nouvelle Puissance"
        '
        'Button5
        '
        Me.Button5.BackgroundImage = Global.EDG_Mamou.My.Resources.Resources.apply
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button5.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(4, 204)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(55, 43)
        Me.Button5.TabIndex = 72
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.BackgroundImage = Global.EDG_Mamou.My.Resources.Resources.editdelete
        Me.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button6.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(143, 204)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(62, 43)
        Me.Button6.TabIndex = 71
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Yellow
        Me.Label3.Location = New System.Drawing.Point(11, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 22)
        Me.Label3.TabIndex = 70
        Me.Label3.Text = "Poste"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Yellow
        Me.Label4.Location = New System.Drawing.Point(11, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 22)
        Me.Label4.TabIndex = 68
        Me.Label4.Text = "Numéro"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Green
        Me.Panel3.Controls.Add(Me.dgv_remplacement)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(380, 36)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(664, 447)
        Me.Panel3.TabIndex = 2
        '
        'dgv_remplacement
        '
        Me.dgv_remplacement.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_remplacement.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_remplacement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_remplacement.Location = New System.Drawing.Point(7, 8)
        Me.dgv_remplacement.Name = "dgv_remplacement"
        Me.dgv_remplacement.ReadOnly = True
        Me.dgv_remplacement.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_remplacement.Size = New System.Drawing.Size(651, 427)
        Me.dgv_remplacement.TabIndex = 1
        '
        'UserControl1_remplacement
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "UserControl1_remplacement"
        Me.Size = New System.Drawing.Size(1044, 483)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.dgv_remplacement, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents dgv_remplacement As System.Windows.Forms.DataGridView
    Friend WithEvents btn_suppr As System.Windows.Forms.Button
    Friend WithEvents btn_modif As System.Windows.Forms.Button
    Friend WithEvents cbxposte_remplacment As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtp_remplace As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtnouv_puis_remplacemt As System.Windows.Forms.TextBox
    Friend WithEvents txtnum_remplacement As System.Windows.Forms.TextBox
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents dtp_rechercher As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txt_rechercher As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmb_rechercher As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_ancien_puis_remplacemt As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label

End Class
