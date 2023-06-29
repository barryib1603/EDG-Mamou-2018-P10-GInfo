<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl1_prelevement
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
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btn_sup = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.cmb_jour_recherche_paie = New System.Windows.Forms.ComboBox()
        Me.cmb_annee_recherche_paie = New System.Windows.Forms.ComboBox()
        Me.cmb_mois_recherche_paie = New System.Windows.Forms.ComboBox()
        Me.txt_recherche_paie = New System.Windows.Forms.TextBox()
        Me.Cmb_recherche = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btn_recherche = New System.Windows.Forms.Button()
        Me.cmb_poste = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dtpprelev = New System.Windows.Forms.DateTimePicker()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtI3 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtI2 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtI1 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtIo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNumero_prelev = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.dgv_prelevement = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.dgv_prelevement, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Green
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1080, 42)
        Me.Panel1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Yellow
        Me.Label2.Location = New System.Drawing.Point(290, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(790, 42)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Liste De Prelevement"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(290, 42)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Prelevement"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Green
        Me.Panel2.Controls.Add(Me.Label18)
        Me.Panel2.Controls.Add(Me.Label17)
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Controls.Add(Me.Button3)
        Me.Panel2.Controls.Add(Me.btn_sup)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.cmb_poste)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.dtpprelev)
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.txtI3)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.txtI2)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.txtI1)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.txtIo)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.txtNumero_prelev)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 42)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(316, 456)
        Me.Panel2.TabIndex = 1
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Yellow
        Me.Label18.Location = New System.Drawing.Point(165, 297)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(73, 15)
        Me.Label18.TabIndex = 80
        Me.Label18.Text = "Supprimer"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Yellow
        Me.Label17.Location = New System.Drawing.Point(84, 297)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(58, 15)
        Me.Label17.TabIndex = 79
        Me.Label17.Text = "Modifier"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Yellow
        Me.Label14.Location = New System.Drawing.Point(18, 297)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(52, 15)
        Me.Label14.TabIndex = 78
        Me.Label14.Text = "Ajouter"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(248, 249)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(51, 43)
        Me.Button3.TabIndex = 77
        Me.Button3.Text = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        Me.Button3.Visible = False
        '
        'btn_sup
        '
        Me.btn_sup.BackgroundImage = Global.EDG_Mamou.My.Resources.Resources.button_cancel
        Me.btn_sup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_sup.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_sup.Location = New System.Drawing.Point(169, 248)
        Me.btn_sup.Name = "btn_sup"
        Me.btn_sup.Size = New System.Drawing.Size(62, 43)
        Me.btn_sup.TabIndex = 76
        Me.btn_sup.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Green
        Me.Panel4.Controls.Add(Me.cmb_jour_recherche_paie)
        Me.Panel4.Controls.Add(Me.cmb_annee_recherche_paie)
        Me.Panel4.Controls.Add(Me.cmb_mois_recherche_paie)
        Me.Panel4.Controls.Add(Me.txt_recherche_paie)
        Me.Panel4.Controls.Add(Me.Cmb_recherche)
        Me.Panel4.Controls.Add(Me.Label10)
        Me.Panel4.Controls.Add(Me.Label11)
        Me.Panel4.Controls.Add(Me.btn_recherche)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 334)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(316, 122)
        Me.Panel4.TabIndex = 75
        '
        'cmb_jour_recherche_paie
        '
        Me.cmb_jour_recherche_paie.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.cmb_jour_recherche_paie.FormattingEnabled = True
        Me.cmb_jour_recherche_paie.Location = New System.Drawing.Point(10, 92)
        Me.cmb_jour_recherche_paie.Name = "cmb_jour_recherche_paie"
        Me.cmb_jour_recherche_paie.Size = New System.Drawing.Size(85, 26)
        Me.cmb_jour_recherche_paie.TabIndex = 10
        '
        'cmb_annee_recherche_paie
        '
        Me.cmb_annee_recherche_paie.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.cmb_annee_recherche_paie.FormattingEnabled = True
        Me.cmb_annee_recherche_paie.Location = New System.Drawing.Point(176, 92)
        Me.cmb_annee_recherche_paie.Name = "cmb_annee_recherche_paie"
        Me.cmb_annee_recherche_paie.Size = New System.Drawing.Size(82, 26)
        Me.cmb_annee_recherche_paie.TabIndex = 8
        '
        'cmb_mois_recherche_paie
        '
        Me.cmb_mois_recherche_paie.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.cmb_mois_recherche_paie.FormattingEnabled = True
        Me.cmb_mois_recherche_paie.Location = New System.Drawing.Point(101, 92)
        Me.cmb_mois_recherche_paie.Name = "cmb_mois_recherche_paie"
        Me.cmb_mois_recherche_paie.Size = New System.Drawing.Size(69, 26)
        Me.cmb_mois_recherche_paie.TabIndex = 7
        '
        'txt_recherche_paie
        '
        Me.txt_recherche_paie.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txt_recherche_paie.Location = New System.Drawing.Point(10, 93)
        Me.txt_recherche_paie.Name = "txt_recherche_paie"
        Me.txt_recherche_paie.Size = New System.Drawing.Size(248, 26)
        Me.txt_recherche_paie.TabIndex = 6
        '
        'Cmb_recherche
        '
        Me.Cmb_recherche.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmb_recherche.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmb_recherche.FormattingEnabled = True
        Me.Cmb_recherche.Items.AddRange(New Object() {"Numéro", "Poste", "Date"})
        Me.Cmb_recherche.Location = New System.Drawing.Point(130, 48)
        Me.Cmb_recherche.Name = "Cmb_recherche"
        Me.Cmb_recherche.Size = New System.Drawing.Size(174, 28)
        Me.Cmb_recherche.TabIndex = 4
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Yellow
        Me.Label10.Location = New System.Drawing.Point(6, 50)
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
        Me.Label11.Size = New System.Drawing.Size(316, 34)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Rechercher"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_recherche
        '
        Me.btn_recherche.BackgroundImage = Global.EDG_Mamou.My.Resources.Resources.kghostview
        Me.btn_recherche.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_recherche.Location = New System.Drawing.Point(264, 87)
        Me.btn_recherche.Name = "btn_recherche"
        Me.btn_recherche.Size = New System.Drawing.Size(40, 36)
        Me.btn_recherche.TabIndex = 1
        Me.btn_recherche.UseVisualStyleBackColor = True
        '
        'cmb_poste
        '
        Me.cmb_poste.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_poste.FormattingEnabled = True
        Me.cmb_poste.Location = New System.Drawing.Point(85, 35)
        Me.cmb_poste.Name = "cmb_poste"
        Me.cmb_poste.Size = New System.Drawing.Size(228, 28)
        Me.cmb_poste.TabIndex = 17
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Green
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Yellow
        Me.Label9.Location = New System.Drawing.Point(14, 39)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(78, 24)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Poste"
        '
        'dtpprelev
        '
        Me.dtpprelev.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpprelev.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpprelev.Location = New System.Drawing.Point(85, 217)
        Me.dtpprelev.Name = "dtpprelev"
        Me.dtpprelev.Size = New System.Drawing.Size(228, 26)
        Me.dtpprelev.TabIndex = 15
        '
        'Button2
        '
        Me.Button2.BackgroundImage = Global.EDG_Mamou.My.Resources.Resources.kate
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(85, 251)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(57, 43)
        Me.Button2.TabIndex = 13
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.EDG_Mamou.My.Resources.Resources.apply
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(17, 251)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(55, 43)
        Me.Button1.TabIndex = 12
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Green
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Yellow
        Me.Label8.Location = New System.Drawing.Point(14, 224)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 24)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Date"
        '
        'txtI3
        '
        Me.txtI3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtI3.Location = New System.Drawing.Point(85, 181)
        Me.txtI3.Name = "txtI3"
        Me.txtI3.Size = New System.Drawing.Size(228, 26)
        Me.txtI3.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Green
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Yellow
        Me.Label7.Location = New System.Drawing.Point(14, 187)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 24)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "I3"
        '
        'txtI2
        '
        Me.txtI2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtI2.Location = New System.Drawing.Point(85, 145)
        Me.txtI2.Name = "txtI2"
        Me.txtI2.Size = New System.Drawing.Size(228, 26)
        Me.txtI2.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Green
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Yellow
        Me.Label6.Location = New System.Drawing.Point(14, 150)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 24)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "I2"
        '
        'txtI1
        '
        Me.txtI1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtI1.Location = New System.Drawing.Point(85, 109)
        Me.txtI1.Name = "txtI1"
        Me.txtI1.Size = New System.Drawing.Size(228, 26)
        Me.txtI1.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Green
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Yellow
        Me.Label5.Location = New System.Drawing.Point(14, 113)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 24)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "I1"
        '
        'txtIo
        '
        Me.txtIo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIo.Location = New System.Drawing.Point(85, 73)
        Me.txtIo.Name = "txtIo"
        Me.txtIo.Size = New System.Drawing.Size(228, 26)
        Me.txtIo.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Green
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Yellow
        Me.Label4.Location = New System.Drawing.Point(14, 76)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 24)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Io"
        '
        'txtNumero_prelev
        '
        Me.txtNumero_prelev.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumero_prelev.Location = New System.Drawing.Point(85, 3)
        Me.txtNumero_prelev.Name = "txtNumero_prelev"
        Me.txtNumero_prelev.Size = New System.Drawing.Size(228, 26)
        Me.txtNumero_prelev.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Green
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Yellow
        Me.Label3.Location = New System.Drawing.Point(8, 5)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 24)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Numéro"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel3.Location = New System.Drawing.Point(316, 42)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(764, 456)
        Me.Panel3.TabIndex = 2
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Green
        Me.Panel5.Controls.Add(Me.dgv_prelevement)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(764, 456)
        Me.Panel5.TabIndex = 2
        '
        'dgv_prelevement
        '
        Me.dgv_prelevement.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_prelevement.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_prelevement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_prelevement.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9, Me.Column10})
        Me.dgv_prelevement.Location = New System.Drawing.Point(14, 3)
        Me.dgv_prelevement.MultiSelect = False
        Me.dgv_prelevement.Name = "dgv_prelevement"
        Me.dgv_prelevement.ReadOnly = True
        Me.dgv_prelevement.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgv_prelevement.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_prelevement.Size = New System.Drawing.Size(735, 436)
        Me.dgv_prelevement.TabIndex = 2
        '
        'Column1
        '
        Me.Column1.HeaderText = "Numero"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Io"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "I1"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "I2"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "I3"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.HeaderText = "Poste"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column7
        '
        Me.Column7.HeaderText = "Imoy(A)"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'Column8
        '
        Me.Column8.HeaderText = "Tch"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        '
        'Column9
        '
        Me.Column9.HeaderText = "Taux des"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        '
        'Column10
        '
        Me.Column10.HeaderText = "Date"
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        '
        'PrintDocument1
        '
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'UserControl1_prelevement
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "UserControl1_prelevement"
        Me.Size = New System.Drawing.Size(1080, 498)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        CType(Me.dgv_prelevement, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents txtI3 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtI2 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtI1 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtIo As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtNumero_prelev As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents dtpprelev As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmb_poste As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents dgv_prelevement As System.Windows.Forms.DataGridView
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents cmb_jour_recherche_paie As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_annee_recherche_paie As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_mois_recherche_paie As System.Windows.Forms.ComboBox
    Friend WithEvents txt_recherche_paie As System.Windows.Forms.TextBox
    Friend WithEvents Cmb_recherche As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btn_recherche As System.Windows.Forms.Button
    Friend WithEvents btn_sup As System.Windows.Forms.Button
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label

End Class
