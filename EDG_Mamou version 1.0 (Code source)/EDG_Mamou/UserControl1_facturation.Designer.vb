<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl1_facturation
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.dtpfin = New System.Windows.Forms.DateTimePicker()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.dtpdebut = New System.Windows.Forms.DateTimePicker()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_ancien_index = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.cmb_jour_recherche_paie = New System.Windows.Forms.ComboBox()
        Me.cmb_annee_recherche_paie = New System.Windows.Forms.ComboBox()
        Me.cmb_mois_recherche_paie = New System.Windows.Forms.ComboBox()
        Me.txt_recherche_paie = New System.Windows.Forms.TextBox()
        Me.Cmb_recherche = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cbx_annee_cons = New System.Windows.Forms.ComboBox()
        Me.cmb_bat = New System.Windows.Forms.ComboBox()
        Me.cbx_mois_cons = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_nouvel_index = New System.Windows.Forms.TextBox()
        Me.TxtNumero_cons = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.dgv_facturation = New System.Windows.Forms.DataGridView()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btn_recherche = New System.Windows.Forms.Button()
        Me.btnvalider_cons = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.dgv_facturation, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Green
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.ForeColor = System.Drawing.Color.Yellow
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1193, 41)
        Me.Panel1.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(417, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(776, 41)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Liste des Consommations"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(0, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(417, 41)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Consommation"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel5)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 41)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(331, 421)
        Me.Panel2.TabIndex = 1
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Green
        Me.Panel5.Controls.Add(Me.Button3)
        Me.Panel5.Controls.Add(Me.Button2)
        Me.Panel5.Controls.Add(Me.Button1)
        Me.Panel5.Controls.Add(Me.dtpfin)
        Me.Panel5.Controls.Add(Me.Label14)
        Me.Panel5.Controls.Add(Me.dtpdebut)
        Me.Panel5.Controls.Add(Me.Label13)
        Me.Panel5.Controls.Add(Me.Label12)
        Me.Panel5.Controls.Add(Me.Label10)
        Me.Panel5.Controls.Add(Me.txt_ancien_index)
        Me.Panel5.Controls.Add(Me.Label9)
        Me.Panel5.Controls.Add(Me.Panel6)
        Me.Panel5.Controls.Add(Me.cbx_annee_cons)
        Me.Panel5.Controls.Add(Me.cmb_bat)
        Me.Panel5.Controls.Add(Me.btnvalider_cons)
        Me.Panel5.Controls.Add(Me.cbx_mois_cons)
        Me.Panel5.Controls.Add(Me.Label6)
        Me.Panel5.Controls.Add(Me.txt_nouvel_index)
        Me.Panel5.Controls.Add(Me.TxtNumero_cons)
        Me.Panel5.Controls.Add(Me.Label4)
        Me.Panel5.Controls.Add(Me.Label3)
        Me.Panel5.Controls.Add(Me.Label2)
        Me.Panel5.Controls.Add(Me.Label1)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(331, 421)
        Me.Panel5.TabIndex = 13
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button3.Location = New System.Drawing.Point(207, 260)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(72, 38)
        Me.Button3.TabIndex = 91
        Me.Button3.Text = "Actualiser"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'dtpfin
        '
        Me.dtpfin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpfin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfin.Location = New System.Drawing.Point(207, 230)
        Me.dtpfin.Name = "dtpfin"
        Me.dtpfin.Size = New System.Drawing.Size(118, 26)
        Me.dtpfin.TabIndex = 89
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Yellow
        Me.Label14.Location = New System.Drawing.Point(5, 236)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(155, 20)
        Me.Label14.TabIndex = 88
        Me.Label14.Text = "Fin consommation"
        '
        'dtpdebut
        '
        Me.dtpdebut.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpdebut.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpdebut.Location = New System.Drawing.Point(207, 198)
        Me.dtpdebut.Name = "dtpdebut"
        Me.dtpdebut.Size = New System.Drawing.Size(118, 26)
        Me.dtpdebut.TabIndex = 87
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Yellow
        Me.Label13.Location = New System.Drawing.Point(5, 204)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(179, 20)
        Me.Label13.TabIndex = 86
        Me.Label13.Text = "debut Consommation"
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Yellow
        Me.Label12.Location = New System.Drawing.Point(272, 68)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(48, 24)
        Me.Label12.TabIndex = 85
        Me.Label12.Text = "kWh"
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Yellow
        Me.Label10.Location = New System.Drawing.Point(271, 99)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(48, 24)
        Me.Label10.TabIndex = 84
        Me.Label10.Text = "kWh"
        '
        'txt_ancien_index
        '
        Me.txt_ancien_index.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ancien_index.Location = New System.Drawing.Point(119, 66)
        Me.txt_ancien_index.Name = "txt_ancien_index"
        Me.txt_ancien_index.ReadOnly = True
        Me.txt_ancien_index.Size = New System.Drawing.Size(151, 26)
        Me.txt_ancien_index.TabIndex = 82
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Yellow
        Me.Label9.Location = New System.Drawing.Point(2, 72)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(111, 20)
        Me.Label9.TabIndex = 83
        Me.Label9.Text = "Ancien index"
        '
        'Panel6
        '
        Me.Panel6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel6.BackColor = System.Drawing.Color.Green
        Me.Panel6.Controls.Add(Me.cmb_jour_recherche_paie)
        Me.Panel6.Controls.Add(Me.cmb_annee_recherche_paie)
        Me.Panel6.Controls.Add(Me.cmb_mois_recherche_paie)
        Me.Panel6.Controls.Add(Me.txt_recherche_paie)
        Me.Panel6.Controls.Add(Me.Cmb_recherche)
        Me.Panel6.Controls.Add(Me.Label8)
        Me.Panel6.Controls.Add(Me.Label11)
        Me.Panel6.Controls.Add(Me.btn_recherche)
        Me.Panel6.Location = New System.Drawing.Point(9, 307)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(322, 107)
        Me.Panel6.TabIndex = 81
        '
        'cmb_jour_recherche_paie
        '
        Me.cmb_jour_recherche_paie.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.cmb_jour_recherche_paie.FormattingEnabled = True
        Me.cmb_jour_recherche_paie.Location = New System.Drawing.Point(6, 77)
        Me.cmb_jour_recherche_paie.Name = "cmb_jour_recherche_paie"
        Me.cmb_jour_recherche_paie.Size = New System.Drawing.Size(55, 26)
        Me.cmb_jour_recherche_paie.TabIndex = 9
        '
        'cmb_annee_recherche_paie
        '
        Me.cmb_annee_recherche_paie.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.cmb_annee_recherche_paie.FormattingEnabled = True
        Me.cmb_annee_recherche_paie.Location = New System.Drawing.Point(165, 78)
        Me.cmb_annee_recherche_paie.Name = "cmb_annee_recherche_paie"
        Me.cmb_annee_recherche_paie.Size = New System.Drawing.Size(102, 26)
        Me.cmb_annee_recherche_paie.TabIndex = 8
        '
        'cmb_mois_recherche_paie
        '
        Me.cmb_mois_recherche_paie.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.cmb_mois_recherche_paie.FormattingEnabled = True
        Me.cmb_mois_recherche_paie.Items.AddRange(New Object() {"Aucun", "Janvier", "Fevrier", "Mars ", "Avril", "Mai", "Juin", "Juillet", "Août", "Septembre", "Octobre", "Novembre", "Decembre"})
        Me.cmb_mois_recherche_paie.Location = New System.Drawing.Point(68, 78)
        Me.cmb_mois_recherche_paie.Name = "cmb_mois_recherche_paie"
        Me.cmb_mois_recherche_paie.Size = New System.Drawing.Size(91, 26)
        Me.cmb_mois_recherche_paie.TabIndex = 7
        '
        'txt_recherche_paie
        '
        Me.txt_recherche_paie.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txt_recherche_paie.Location = New System.Drawing.Point(6, 79)
        Me.txt_recherche_paie.Name = "txt_recherche_paie"
        Me.txt_recherche_paie.Size = New System.Drawing.Size(261, 26)
        Me.txt_recherche_paie.TabIndex = 6
        '
        'Cmb_recherche
        '
        Me.Cmb_recherche.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmb_recherche.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmb_recherche.FormattingEnabled = True
        Me.Cmb_recherche.Items.AddRange(New Object() {"Facture", "Batiment", "Mois et Annee", "Année"})
        Me.Cmb_recherche.Location = New System.Drawing.Point(123, 37)
        Me.Cmb_recherche.Name = "Cmb_recherche"
        Me.Cmb_recherche.Size = New System.Drawing.Size(193, 28)
        Me.Cmb_recherche.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Yellow
        Me.Label8.Location = New System.Drawing.Point(1, 40)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(122, 23)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "rechercher par:"
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Green
        Me.Label11.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label11.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Yellow
        Me.Label11.Location = New System.Drawing.Point(0, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(322, 32)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Rechercher"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cbx_annee_cons
        '
        Me.cbx_annee_cons.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbx_annee_cons.FormattingEnabled = True
        Me.cbx_annee_cons.Items.AddRange(New Object() {"2016", "2017", "2018"})
        Me.cbx_annee_cons.Location = New System.Drawing.Point(119, 164)
        Me.cbx_annee_cons.Name = "cbx_annee_cons"
        Me.cbx_annee_cons.Size = New System.Drawing.Size(206, 28)
        Me.cbx_annee_cons.TabIndex = 37
        '
        'cmb_bat
        '
        Me.cmb_bat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_bat.FormattingEnabled = True
        Me.cmb_bat.Location = New System.Drawing.Point(119, 32)
        Me.cmb_bat.Name = "cmb_bat"
        Me.cmb_bat.Size = New System.Drawing.Size(206, 28)
        Me.cmb_bat.TabIndex = 36
        '
        'cbx_mois_cons
        '
        Me.cbx_mois_cons.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbx_mois_cons.FormattingEnabled = True
        Me.cbx_mois_cons.Items.AddRange(New Object() {"Aucun", "Janvier", "Fevrier", "Mars ", "Avril", "Mai", "Juin", "Juillet", "Août", "Septembre", "Octobre", "Novembre", "Decembre"})
        Me.cbx_mois_cons.Location = New System.Drawing.Point(119, 130)
        Me.cbx_mois_cons.Name = "cbx_mois_cons"
        Me.cbx_mois_cons.Size = New System.Drawing.Size(206, 28)
        Me.cbx_mois_cons.TabIndex = 32
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Yellow
        Me.Label6.Location = New System.Drawing.Point(0, 171)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 20)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = " Année"
        '
        'txt_nouvel_index
        '
        Me.txt_nouvel_index.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nouvel_index.Location = New System.Drawing.Point(119, 98)
        Me.txt_nouvel_index.Name = "txt_nouvel_index"
        Me.txt_nouvel_index.Size = New System.Drawing.Size(151, 26)
        Me.txt_nouvel_index.TabIndex = 27
        '
        'TxtNumero_cons
        '
        Me.TxtNumero_cons.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNumero_cons.Location = New System.Drawing.Point(119, 0)
        Me.TxtNumero_cons.Name = "TxtNumero_cons"
        Me.TxtNumero_cons.ReadOnly = True
        Me.TxtNumero_cons.Size = New System.Drawing.Size(206, 26)
        Me.TxtNumero_cons.TabIndex = 23
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Yellow
        Me.Label4.Location = New System.Drawing.Point(2, 138)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 20)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Mois" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Yellow
        Me.Label3.Location = New System.Drawing.Point(2, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 20)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Nouvel index"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Yellow
        Me.Label2.Location = New System.Drawing.Point(2, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 20)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Batiment"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(2, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 24)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Numero"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Green
        Me.Panel3.Controls.Add(Me.dgv_facturation)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(331, 41)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(862, 421)
        Me.Panel3.TabIndex = 2
        '
        'dgv_facturation
        '
        Me.dgv_facturation.AllowUserToAddRows = False
        Me.dgv_facturation.AllowUserToDeleteRows = False
        Me.dgv_facturation.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_facturation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_facturation.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_facturation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_facturation.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_facturation.Location = New System.Drawing.Point(6, 2)
        Me.dgv_facturation.Name = "dgv_facturation"
        Me.dgv_facturation.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_facturation.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_facturation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_facturation.Size = New System.Drawing.Size(848, 412)
        Me.dgv_facturation.TabIndex = 2
        '
        'Button2
        '
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = Global.EDG_Mamou.My.Resources.Resources.printmgraaaaa
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(103, 260)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(104, 38)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Imprimer"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.EDG_Mamou.My.Resources.Resources.editdelete
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Location = New System.Drawing.Point(279, 260)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(48, 38)
        Me.Button1.TabIndex = 90
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btn_recherche
        '
        Me.btn_recherche.BackgroundImage = Global.EDG_Mamou.My.Resources.Resources.kghostview
        Me.btn_recherche.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_recherche.Location = New System.Drawing.Point(273, 71)
        Me.btn_recherche.Name = "btn_recherche"
        Me.btn_recherche.Size = New System.Drawing.Size(45, 39)
        Me.btn_recherche.TabIndex = 1
        Me.btn_recherche.UseVisualStyleBackColor = True
        '
        'btnvalider_cons
        '
        Me.btnvalider_cons.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnvalider_cons.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnvalider_cons.Image = Global.EDG_Mamou.My.Resources.Resources.apply3
        Me.btnvalider_cons.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnvalider_cons.Location = New System.Drawing.Point(13, 260)
        Me.btnvalider_cons.Name = "btnvalider_cons"
        Me.btnvalider_cons.Size = New System.Drawing.Size(91, 38)
        Me.btnvalider_cons.TabIndex = 33
        Me.btnvalider_cons.Text = "Ajouter"
        Me.btnvalider_cons.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnvalider_cons.UseVisualStyleBackColor = True
        '
        'UserControl1_facturation
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "UserControl1_facturation"
        Me.Size = New System.Drawing.Size(1193, 462)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.dgv_facturation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents btnvalider_cons As System.Windows.Forms.Button
    Friend WithEvents cbx_mois_cons As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_nouvel_index As System.Windows.Forms.TextBox
    Friend WithEvents TxtNumero_cons As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbx_annee_cons As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_bat As System.Windows.Forms.ComboBox
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents cmb_jour_recherche_paie As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_annee_recherche_paie As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_mois_recherche_paie As System.Windows.Forms.ComboBox
    Friend WithEvents txt_recherche_paie As System.Windows.Forms.TextBox
    Friend WithEvents Cmb_recherche As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btn_recherche As System.Windows.Forms.Button
    Friend WithEvents dgv_facturation As System.Windows.Forms.DataGridView
    Friend WithEvents txt_ancien_index As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents dtpdebut As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents dtpfin As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button

End Class
