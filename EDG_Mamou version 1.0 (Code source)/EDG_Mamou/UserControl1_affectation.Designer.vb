<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl1_affectation
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
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.dgv_affectation = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.rbdesacffecter = New System.Windows.Forms.CheckBox()
        Me.btn_supprim = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.txtrecherch_affec = New System.Windows.Forms.TextBox()
        Me.Cmb_recherche = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btn_recherche = New System.Windows.Forms.Button()
        Me.date_fin_affecte = New System.Windows.Forms.DateTimePicker()
        Me.date_debut_affecte = New System.Windows.Forms.DateTimePicker()
        Me.cmb_zone = New System.Windows.Forms.ComboBox()
        Me.cmb_agent = New System.Windows.Forms.ComboBox()
        Me.txt_affecte = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_modifie = New System.Windows.Forms.Button()
        Me.btn_ajoute = New System.Windows.Forms.Button()
        Me.lbldate_fin = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel3.SuspendLayout()
        CType(Me.dgv_affectation, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Green
        Me.Panel3.Controls.Add(Me.dgv_affectation)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(371, 43)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(749, 453)
        Me.Panel3.TabIndex = 35
        '
        'dgv_affectation
        '
        Me.dgv_affectation.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_affectation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_affectation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_affectation.Location = New System.Drawing.Point(0, 3)
        Me.dgv_affectation.Name = "dgv_affectation"
        Me.dgv_affectation.ReadOnly = True
        Me.dgv_affectation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_affectation.Size = New System.Drawing.Size(740, 434)
        Me.dgv_affectation.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel2.BackColor = System.Drawing.Color.Green
        Me.Panel2.Controls.Add(Me.Label18)
        Me.Panel2.Controls.Add(Me.Label17)
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Controls.Add(Me.rbdesacffecter)
        Me.Panel2.Controls.Add(Me.btn_supprim)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.date_fin_affecte)
        Me.Panel2.Controls.Add(Me.date_debut_affecte)
        Me.Panel2.Controls.Add(Me.cmb_zone)
        Me.Panel2.Controls.Add(Me.cmb_agent)
        Me.Panel2.Controls.Add(Me.txt_affecte)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.btn_modifie)
        Me.Panel2.Controls.Add(Me.btn_ajoute)
        Me.Panel2.Controls.Add(Me.lbldate_fin)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 43)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(371, 453)
        Me.Panel2.TabIndex = 34
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Yellow
        Me.Label18.Location = New System.Drawing.Point(176, 277)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(73, 15)
        Me.Label18.TabIndex = 81
        Me.Label18.Text = "Supprimer"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Yellow
        Me.Label17.Location = New System.Drawing.Point(89, 278)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(58, 15)
        Me.Label17.TabIndex = 80
        Me.Label17.Text = "Modifier"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Yellow
        Me.Label14.Location = New System.Drawing.Point(12, 278)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(52, 15)
        Me.Label14.TabIndex = 79
        Me.Label14.Text = "Ajouter"
        '
        'rbdesacffecter
        '
        Me.rbdesacffecter.AutoSize = True
        Me.rbdesacffecter.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbdesacffecter.ForeColor = System.Drawing.Color.Yellow
        Me.rbdesacffecter.Location = New System.Drawing.Point(239, 173)
        Me.rbdesacffecter.Name = "rbdesacffecter"
        Me.rbdesacffecter.Size = New System.Drawing.Size(123, 26)
        Me.rbdesacffecter.TabIndex = 78
        Me.rbdesacffecter.Text = "Desaffecter"
        Me.rbdesacffecter.UseVisualStyleBackColor = True
        '
        'btn_supprim
        '
        Me.btn_supprim.BackgroundImage = Global.EDG_Mamou.My.Resources.Resources.button_cancel
        Me.btn_supprim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_supprim.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_supprim.Location = New System.Drawing.Point(185, 237)
        Me.btn_supprim.Name = "btn_supprim"
        Me.btn_supprim.Size = New System.Drawing.Size(56, 38)
        Me.btn_supprim.TabIndex = 77
        Me.btn_supprim.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Green
        Me.Panel4.Controls.Add(Me.DateTimePicker1)
        Me.Panel4.Controls.Add(Me.txtrecherch_affec)
        Me.Panel4.Controls.Add(Me.Cmb_recherche)
        Me.Panel4.Controls.Add(Me.Label10)
        Me.Panel4.Controls.Add(Me.Label11)
        Me.Panel4.Controls.Add(Me.btn_recherche)
        Me.Panel4.Location = New System.Drawing.Point(3, 320)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(365, 133)
        Me.Panel4.TabIndex = 76
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(31, 80)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(248, 24)
        Me.DateTimePicker1.TabIndex = 7
        '
        'txtrecherch_affec
        '
        Me.txtrecherch_affec.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtrecherch_affec.Location = New System.Drawing.Point(31, 91)
        Me.txtrecherch_affec.Name = "txtrecherch_affec"
        Me.txtrecherch_affec.Size = New System.Drawing.Size(248, 24)
        Me.txtrecherch_affec.TabIndex = 6
        '
        'Cmb_recherche
        '
        Me.Cmb_recherche.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmb_recherche.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmb_recherche.FormattingEnabled = True
        Me.Cmb_recherche.Items.AddRange(New Object() {"Numéro", "Agent", "Zone", "Date Debut", "Date Fin"})
        Me.Cmb_recherche.Location = New System.Drawing.Point(151, 46)
        Me.Cmb_recherche.Name = "Cmb_recherche"
        Me.Cmb_recherche.Size = New System.Drawing.Size(174, 28)
        Me.Cmb_recherche.TabIndex = 4
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Yellow
        Me.Label10.Location = New System.Drawing.Point(27, 48)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(122, 23)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "rechercher par:"
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Green
        Me.Label11.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label11.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Yellow
        Me.Label11.Location = New System.Drawing.Point(0, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(365, 34)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Rechercher"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_recherche
        '
        Me.btn_recherche.BackgroundImage = Global.EDG_Mamou.My.Resources.Resources.kghostview
        Me.btn_recherche.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_recherche.Location = New System.Drawing.Point(285, 84)
        Me.btn_recherche.Name = "btn_recherche"
        Me.btn_recherche.Size = New System.Drawing.Size(40, 36)
        Me.btn_recherche.TabIndex = 1
        Me.btn_recherche.UseVisualStyleBackColor = True
        '
        'date_fin_affecte
        '
        Me.date_fin_affecte.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.date_fin_affecte.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.date_fin_affecte.Location = New System.Drawing.Point(103, 200)
        Me.date_fin_affecte.Name = "date_fin_affecte"
        Me.date_fin_affecte.Size = New System.Drawing.Size(251, 29)
        Me.date_fin_affecte.TabIndex = 61
        '
        'date_debut_affecte
        '
        Me.date_debut_affecte.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.date_debut_affecte.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.date_debut_affecte.Location = New System.Drawing.Point(102, 136)
        Me.date_debut_affecte.Name = "date_debut_affecte"
        Me.date_debut_affecte.Size = New System.Drawing.Size(251, 29)
        Me.date_debut_affecte.TabIndex = 60
        '
        'cmb_zone
        '
        Me.cmb_zone.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_zone.FormattingEnabled = True
        Me.cmb_zone.Location = New System.Drawing.Point(102, 90)
        Me.cmb_zone.Name = "cmb_zone"
        Me.cmb_zone.Size = New System.Drawing.Size(251, 32)
        Me.cmb_zone.TabIndex = 59
        '
        'cmb_agent
        '
        Me.cmb_agent.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_agent.FormattingEnabled = True
        Me.cmb_agent.Location = New System.Drawing.Point(102, 45)
        Me.cmb_agent.Name = "cmb_agent"
        Me.cmb_agent.Size = New System.Drawing.Size(252, 32)
        Me.cmb_agent.TabIndex = 58
        '
        'txt_affecte
        '
        Me.txt_affecte.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_affecte.Location = New System.Drawing.Point(102, 6)
        Me.txt_affecte.Name = "txt_affecte"
        Me.txt_affecte.Size = New System.Drawing.Size(252, 29)
        Me.txt_affecte.TabIndex = 57
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Yellow
        Me.Label4.Location = New System.Drawing.Point(10, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 29)
        Me.Label4.TabIndex = 51
        Me.Label4.Text = "N°"
        '
        'btn_modifie
        '
        Me.btn_modifie.BackgroundImage = Global.EDG_Mamou.My.Resources.Resources.kate
        Me.btn_modifie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_modifie.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_modifie.Location = New System.Drawing.Point(92, 236)
        Me.btn_modifie.Name = "btn_modifie"
        Me.btn_modifie.Size = New System.Drawing.Size(60, 39)
        Me.btn_modifie.TabIndex = 49
        Me.btn_modifie.UseVisualStyleBackColor = True
        '
        'btn_ajoute
        '
        Me.btn_ajoute.BackgroundImage = Global.EDG_Mamou.My.Resources.Resources.apply
        Me.btn_ajoute.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_ajoute.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ajoute.Location = New System.Drawing.Point(15, 236)
        Me.btn_ajoute.Name = "btn_ajoute"
        Me.btn_ajoute.Size = New System.Drawing.Size(50, 39)
        Me.btn_ajoute.TabIndex = 48
        Me.btn_ajoute.UseVisualStyleBackColor = True
        '
        'lbldate_fin
        '
        Me.lbldate_fin.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldate_fin.ForeColor = System.Drawing.Color.Yellow
        Me.lbldate_fin.Location = New System.Drawing.Point(14, 204)
        Me.lbldate_fin.Name = "lbldate_fin"
        Me.lbldate_fin.Size = New System.Drawing.Size(83, 29)
        Me.lbldate_fin.TabIndex = 46
        Me.lbldate_fin.Text = "Date fin"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Yellow
        Me.Label5.Location = New System.Drawing.Point(13, 141)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 29)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "Date"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Yellow
        Me.Label3.Location = New System.Drawing.Point(13, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 29)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "Zone"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(10, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 29)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Agent"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Green
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.ForeColor = System.Drawing.Color.Yellow
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1120, 43)
        Me.Panel1.TabIndex = 33
        '
        'Label6
        '
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(377, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(743, 43)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Liste des Affectations"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(0, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(377, 43)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Affectations"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'UserControl1_affectation
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "UserControl1_affectation"
        Me.Size = New System.Drawing.Size(1120, 496)
        Me.Panel3.ResumeLayout(False)
        CType(Me.dgv_affectation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btn_modifie As System.Windows.Forms.Button
    Friend WithEvents btn_ajoute As System.Windows.Forms.Button
    Friend WithEvents lbldate_fin As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents date_fin_affecte As System.Windows.Forms.DateTimePicker
    Friend WithEvents date_debut_affecte As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmb_zone As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_agent As System.Windows.Forms.ComboBox
    Friend WithEvents txt_affecte As System.Windows.Forms.TextBox
    Friend WithEvents dgv_affectation As System.Windows.Forms.DataGridView
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents txtrecherch_affec As System.Windows.Forms.TextBox
    Friend WithEvents Cmb_recherche As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btn_recherche As System.Windows.Forms.Button
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents btn_supprim As System.Windows.Forms.Button
    Friend WithEvents rbdesacffecter As System.Windows.Forms.CheckBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label

End Class
