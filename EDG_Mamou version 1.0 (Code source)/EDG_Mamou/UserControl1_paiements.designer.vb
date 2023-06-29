<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl1_paiements
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
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.cbx_recherche_bat = New System.Windows.Forms.ComboBox()
        Me.cmb_annee_recherche_paie = New System.Windows.Forms.ComboBox()
        Me.cmb_jour_recherche_paie = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Cmb_recherche = New System.Windows.Forms.ComboBox()
        Me.txt_recherche_paie = New System.Windows.Forms.TextBox()
        Me.cmb_mois_recherche_paie = New System.Windows.Forms.ComboBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cbx_bat = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblmontantàpayé = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lbl_solde = New System.Windows.Forms.Label()
        Me.lblsold = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_con_paie = New System.Windows.Forms.ComboBox()
        Me.cb_nat_paie = New System.Windows.Forms.ComboBox()
        Me.txt_mont_paie = New System.Windows.Forms.TextBox()
        Me.txt_num_paie = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.dgv_paiement = New System.Windows.Forms.DataGridView()
        Me.btn_recherche = New System.Windows.Forms.Button()
        Me.btn_reçu = New System.Windows.Forms.Button()
        Me.btn_imprime_paiement = New System.Windows.Forms.Button()
        Me.btn_ajout_paiement = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.dgv_paiement, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Green
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1089, 35)
        Me.Panel1.TabIndex = 0
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Green
        Me.Label10.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Yellow
        Me.Label10.Location = New System.Drawing.Point(0, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(398, 35)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Paiement"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Green
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Yellow
        Me.Label8.Location = New System.Drawing.Point(392, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(697, 35)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Fiche de Paiement"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel7)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 35)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(381, 512)
        Me.Panel2.TabIndex = 1
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.Green
        Me.Panel7.Controls.Add(Me.cbx_recherche_bat)
        Me.Panel7.Controls.Add(Me.cmb_annee_recherche_paie)
        Me.Panel7.Controls.Add(Me.cmb_jour_recherche_paie)
        Me.Panel7.Controls.Add(Me.btn_recherche)
        Me.Panel7.Controls.Add(Me.Label1)
        Me.Panel7.Controls.Add(Me.Cmb_recherche)
        Me.Panel7.Controls.Add(Me.txt_recherche_paie)
        Me.Panel7.Controls.Add(Me.cmb_mois_recherche_paie)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel7.Location = New System.Drawing.Point(0, 420)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(381, 92)
        Me.Panel7.TabIndex = 2
        '
        'cbx_recherche_bat
        '
        Me.cbx_recherche_bat.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbx_recherche_bat.FormattingEnabled = True
        Me.cbx_recherche_bat.Location = New System.Drawing.Point(12, 46)
        Me.cbx_recherche_bat.Margin = New System.Windows.Forms.Padding(4)
        Me.cbx_recherche_bat.Name = "cbx_recherche_bat"
        Me.cbx_recherche_bat.Size = New System.Drawing.Size(305, 27)
        Me.cbx_recherche_bat.TabIndex = 103
        '
        'cmb_annee_recherche_paie
        '
        Me.cmb_annee_recherche_paie.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.cmb_annee_recherche_paie.FormattingEnabled = True
        Me.cmb_annee_recherche_paie.Location = New System.Drawing.Point(209, 49)
        Me.cmb_annee_recherche_paie.Name = "cmb_annee_recherche_paie"
        Me.cmb_annee_recherche_paie.Size = New System.Drawing.Size(108, 26)
        Me.cmb_annee_recherche_paie.TabIndex = 8
        '
        'cmb_jour_recherche_paie
        '
        Me.cmb_jour_recherche_paie.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.cmb_jour_recherche_paie.FormattingEnabled = True
        Me.cmb_jour_recherche_paie.Location = New System.Drawing.Point(11, 47)
        Me.cmb_jour_recherche_paie.Name = "cmb_jour_recherche_paie"
        Me.cmb_jour_recherche_paie.Size = New System.Drawing.Size(102, 26)
        Me.cmb_jour_recherche_paie.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(3, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 23)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "rechercher par:"
        '
        'Cmb_recherche
        '
        Me.Cmb_recherche.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmb_recherche.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmb_recherche.FormattingEnabled = True
        Me.Cmb_recherche.Items.AddRange(New Object() {"Numéro", "Facture", "Batiment"})
        Me.Cmb_recherche.Location = New System.Drawing.Point(131, 6)
        Me.Cmb_recherche.Name = "Cmb_recherche"
        Me.Cmb_recherche.Size = New System.Drawing.Size(244, 28)
        Me.Cmb_recherche.TabIndex = 4
        '
        'txt_recherche_paie
        '
        Me.txt_recherche_paie.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txt_recherche_paie.Location = New System.Drawing.Point(11, 48)
        Me.txt_recherche_paie.Name = "txt_recherche_paie"
        Me.txt_recherche_paie.Size = New System.Drawing.Size(306, 26)
        Me.txt_recherche_paie.TabIndex = 6
        '
        'cmb_mois_recherche_paie
        '
        Me.cmb_mois_recherche_paie.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.cmb_mois_recherche_paie.FormattingEnabled = True
        Me.cmb_mois_recherche_paie.Location = New System.Drawing.Point(119, 47)
        Me.cmb_mois_recherche_paie.Name = "cmb_mois_recherche_paie"
        Me.cmb_mois_recherche_paie.Size = New System.Drawing.Size(84, 26)
        Me.cmb_mois_recherche_paie.TabIndex = 7
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Green
        Me.Panel4.Controls.Add(Me.Label15)
        Me.Panel4.Controls.Add(Me.Button1)
        Me.Panel4.Controls.Add(Me.Label14)
        Me.Panel4.Controls.Add(Me.cbx_bat)
        Me.Panel4.Controls.Add(Me.Label13)
        Me.Panel4.Controls.Add(Me.GroupBox2)
        Me.Panel4.Controls.Add(Me.GroupBox1)
        Me.Panel4.Controls.Add(Me.Button5)
        Me.Panel4.Controls.Add(Me.Label9)
        Me.Panel4.Controls.Add(Me.Label7)
        Me.Panel4.Controls.Add(Me.btn_reçu)
        Me.Panel4.Controls.Add(Me.txt_con_paie)
        Me.Panel4.Controls.Add(Me.cb_nat_paie)
        Me.Panel4.Controls.Add(Me.txt_mont_paie)
        Me.Panel4.Controls.Add(Me.txt_num_paie)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Controls.Add(Me.btn_imprime_paiement)
        Me.Panel4.Controls.Add(Me.btn_ajout_paiement)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(381, 512)
        Me.Panel4.TabIndex = 3
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Century", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Yellow
        Me.Label15.Location = New System.Drawing.Point(6, 304)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(59, 16)
        Me.Label15.TabIndex = 104
        Me.Label15.Text = "Ajouter"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Constantia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(9, 327)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(81, 44)
        Me.Button1.TabIndex = 103
        Me.Button1.Text = "Actualiser"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Yellow
        Me.Label14.Location = New System.Drawing.Point(9, 93)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(132, 29)
        Me.Label14.TabIndex = 102
        Me.Label14.Text = "Bâtiment"
        '
        'cbx_bat
        '
        Me.cbx_bat.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbx_bat.FormattingEnabled = True
        Me.cbx_bat.Location = New System.Drawing.Point(142, 92)
        Me.cbx_bat.Margin = New System.Windows.Forms.Padding(4)
        Me.cbx_bat.Name = "cbx_bat"
        Me.cbx_bat.Size = New System.Drawing.Size(232, 27)
        Me.cbx_bat.TabIndex = 101
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Yellow
        Me.Label13.Location = New System.Drawing.Point(340, 223)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(39, 23)
        Me.Label13.TabIndex = 100
        Me.Label13.Text = "FG"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.lblmontantàpayé)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 172)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(378, 48)
        Me.GroupBox2.TabIndex = 91
        Me.GroupBox2.TabStop = False
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Yellow
        Me.Label12.Location = New System.Drawing.Point(337, 13)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(39, 23)
        Me.Label12.TabIndex = 100
        Me.Label12.Text = "FG"
        '
        'lblmontantàpayé
        '
        Me.lblmontantàpayé.BackColor = System.Drawing.Color.White
        Me.lblmontantàpayé.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmontantàpayé.ForeColor = System.Drawing.Color.Red
        Me.lblmontantàpayé.Location = New System.Drawing.Point(140, 15)
        Me.lblmontantàpayé.Name = "lblmontantàpayé"
        Me.lblmontantàpayé.Size = New System.Drawing.Size(195, 23)
        Me.lblmontantàpayé.TabIndex = 98
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Yellow
        Me.Label6.Location = New System.Drawing.Point(2, 15)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(132, 23)
        Me.Label6.TabIndex = 97
        Me.Label6.Text = "Reste à Payer"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.lbl_solde)
        Me.GroupBox1.Controls.Add(Me.lblsold)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 120)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(378, 52)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Yellow
        Me.Label11.Location = New System.Drawing.Point(336, 18)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(39, 23)
        Me.Label11.TabIndex = 99
        Me.Label11.Text = "FG"
        '
        'lbl_solde
        '
        Me.lbl_solde.BackColor = System.Drawing.Color.White
        Me.lbl_solde.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_solde.ForeColor = System.Drawing.Color.Red
        Me.lbl_solde.Location = New System.Drawing.Point(140, 16)
        Me.lbl_solde.Name = "lbl_solde"
        Me.lbl_solde.Size = New System.Drawing.Size(195, 23)
        Me.lbl_solde.TabIndex = 98
        '
        'lblsold
        '
        Me.lblsold.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsold.ForeColor = System.Drawing.Color.Yellow
        Me.lblsold.Location = New System.Drawing.Point(4, 17)
        Me.lblsold.Name = "lblsold"
        Me.lblsold.Size = New System.Drawing.Size(132, 23)
        Me.lblsold.TabIndex = 97
        Me.lblsold.Text = "Solde"
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.Green
        Me.Button5.Location = New System.Drawing.Point(270, 257)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(107, 49)
        Me.Button5.TabIndex = 13
        Me.Button5.Text = "Alimenter un Compte"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Yellow
        Me.Label9.Location = New System.Drawing.Point(74, 305)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(102, 15)
        Me.Label9.TabIndex = 88
        Me.Label9.Text = " Liste Paiement"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Yellow
        Me.Label7.Location = New System.Drawing.Point(195, 305)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 15)
        Me.Label7.TabIndex = 87
        Me.Label7.Text = " Réçu"
        '
        'txt_con_paie
        '
        Me.txt_con_paie.Font = New System.Drawing.Font("Times New Roman", 14.25!)
        Me.txt_con_paie.FormattingEnabled = True
        Me.txt_con_paie.Location = New System.Drawing.Point(162, 93)
        Me.txt_con_paie.Name = "txt_con_paie"
        Me.txt_con_paie.Size = New System.Drawing.Size(213, 29)
        Me.txt_con_paie.TabIndex = 84
        '
        'cb_nat_paie
        '
        Me.cb_nat_paie.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_nat_paie.FormattingEnabled = True
        Me.cb_nat_paie.Items.AddRange(New Object() {"Paiement de Facture par Cash", "Paiement de Facture par le Solde", "Paiement d'abonnement", "Paiement de la pénalité"})
        Me.cb_nat_paie.Location = New System.Drawing.Point(143, 50)
        Me.cb_nat_paie.Name = "cb_nat_paie"
        Me.cb_nat_paie.Size = New System.Drawing.Size(232, 29)
        Me.cb_nat_paie.TabIndex = 80
        '
        'txt_mont_paie
        '
        Me.txt_mont_paie.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_mont_paie.Location = New System.Drawing.Point(143, 221)
        Me.txt_mont_paie.Name = "txt_mont_paie"
        Me.txt_mont_paie.Size = New System.Drawing.Size(195, 29)
        Me.txt_mont_paie.TabIndex = 79
        '
        'txt_num_paie
        '
        Me.txt_num_paie.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_num_paie.Location = New System.Drawing.Point(143, 6)
        Me.txt_num_paie.Name = "txt_num_paie"
        Me.txt_num_paie.Size = New System.Drawing.Size(232, 29)
        Me.txt_num_paie.TabIndex = 78
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Yellow
        Me.Label4.Location = New System.Drawing.Point(7, 223)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 23)
        Me.Label4.TabIndex = 77
        Me.Label4.Text = "Montant"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Yellow
        Me.Label3.Location = New System.Drawing.Point(6, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(164, 29)
        Me.Label3.TabIndex = 76
        Me.Label3.Text = "N° Consommation"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Yellow
        Me.Label2.Location = New System.Drawing.Point(7, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 23)
        Me.Label2.TabIndex = 75
        Me.Label2.Text = "Nature"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Yellow
        Me.Label5.Location = New System.Drawing.Point(10, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(115, 23)
        Me.Label5.TabIndex = 74
        Me.Label5.Text = "Numéro"
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.dgv_paiement)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(381, 35)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(708, 512)
        Me.Panel6.TabIndex = 4
        '
        'dgv_paiement
        '
        Me.dgv_paiement.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_paiement.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_paiement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_paiement.Location = New System.Drawing.Point(0, -1)
        Me.dgv_paiement.Name = "dgv_paiement"
        Me.dgv_paiement.ReadOnly = True
        Me.dgv_paiement.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_paiement.Size = New System.Drawing.Size(705, 502)
        Me.dgv_paiement.TabIndex = 0
        '
        'btn_recherche
        '
        Me.btn_recherche.BackgroundImage = Global.EDG_Mamou.My.Resources.Resources.kghostview
        Me.btn_recherche.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_recherche.Location = New System.Drawing.Point(323, 37)
        Me.btn_recherche.Name = "btn_recherche"
        Me.btn_recherche.Size = New System.Drawing.Size(52, 48)
        Me.btn_recherche.TabIndex = 1
        Me.btn_recherche.UseVisualStyleBackColor = True
        '
        'btn_reçu
        '
        Me.btn_reçu.BackgroundImage = Global.EDG_Mamou.My.Resources.Resources.printmgr
        Me.btn_reçu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_reçu.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_reçu.Location = New System.Drawing.Point(191, 255)
        Me.btn_reçu.Name = "btn_reçu"
        Me.btn_reçu.Size = New System.Drawing.Size(52, 49)
        Me.btn_reçu.TabIndex = 85
        Me.btn_reçu.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_reçu.UseVisualStyleBackColor = True
        '
        'btn_imprime_paiement
        '
        Me.btn_imprime_paiement.BackgroundImage = Global.EDG_Mamou.My.Resources.Resources.printmgr
        Me.btn_imprime_paiement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_imprime_paiement.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_imprime_paiement.Location = New System.Drawing.Point(83, 257)
        Me.btn_imprime_paiement.Name = "btn_imprime_paiement"
        Me.btn_imprime_paiement.Size = New System.Drawing.Size(87, 49)
        Me.btn_imprime_paiement.TabIndex = 10
        Me.btn_imprime_paiement.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_imprime_paiement.UseVisualStyleBackColor = True
        '
        'btn_ajout_paiement
        '
        Me.btn_ajout_paiement.BackgroundImage = Global.EDG_Mamou.My.Resources.Resources.apply
        Me.btn_ajout_paiement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_ajout_paiement.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ajout_paiement.Location = New System.Drawing.Point(7, 257)
        Me.btn_ajout_paiement.Name = "btn_ajout_paiement"
        Me.btn_ajout_paiement.Size = New System.Drawing.Size(61, 47)
        Me.btn_ajout_paiement.TabIndex = 6
        Me.btn_ajout_paiement.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_ajout_paiement.UseVisualStyleBackColor = True
        '
        'UserControl1_paiements
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Green
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "UserControl1_paiements"
        Me.Size = New System.Drawing.Size(1089, 547)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        CType(Me.dgv_paiement, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents btn_recherche As System.Windows.Forms.Button
    Friend WithEvents btn_ajout_paiement As System.Windows.Forms.Button
    Friend WithEvents btn_imprime_paiement As System.Windows.Forms.Button
    Friend WithEvents Cmb_recherche As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgv_paiement As System.Windows.Forms.DataGridView
    Friend WithEvents txt_recherche_paie As System.Windows.Forms.TextBox
    Friend WithEvents cmb_annee_recherche_paie As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_mois_recherche_paie As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_jour_recherche_paie As System.Windows.Forms.ComboBox
    Friend WithEvents txt_con_paie As System.Windows.Forms.ComboBox
    Friend WithEvents cb_nat_paie As System.Windows.Forms.ComboBox
    Friend WithEvents txt_mont_paie As System.Windows.Forms.TextBox
    Friend WithEvents txt_num_paie As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btn_reçu As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblmontantàpayé As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_solde As System.Windows.Forms.Label
    Friend WithEvents lblsold As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cbx_bat As System.Windows.Forms.ComboBox
    Friend WithEvents cbx_recherche_bat As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label15 As System.Windows.Forms.Label

End Class
