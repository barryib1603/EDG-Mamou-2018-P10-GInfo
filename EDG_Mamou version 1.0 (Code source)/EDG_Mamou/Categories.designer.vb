<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Categories
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Categories))
        Me.GroupBox1_categorie = New System.Windows.Forms.GroupBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.dgvcategorie = New System.Windows.Forms.DataGridView()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txt_limit_franchi = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txt_prime_fix = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txt_franchi_pourcent = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtmontant3_cat = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtmontant2_cat = New System.Windows.Forms.TextBox()
        Me.txttranche3_cat = New System.Windows.Forms.TextBox()
        Me.txtmontant1_cat = New System.Windows.Forms.TextBox()
        Me.txttranche2_cat = New System.Windows.Forms.TextBox()
        Me.txttranche1_cat = New System.Windows.Forms.TextBox()
        Me.txtcategorie_cat = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox1_categorie.SuspendLayout()
        CType(Me.dgvcategorie, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1_categorie
        '
        Me.GroupBox1_categorie.Controls.Add(Me.Label25)
        Me.GroupBox1_categorie.Controls.Add(Me.Label24)
        Me.GroupBox1_categorie.Controls.Add(Me.Label22)
        Me.GroupBox1_categorie.Controls.Add(Me.dgvcategorie)
        Me.GroupBox1_categorie.Controls.Add(Me.Label23)
        Me.GroupBox1_categorie.Controls.Add(Me.Button4)
        Me.GroupBox1_categorie.Controls.Add(Me.Button5)
        Me.GroupBox1_categorie.Controls.Add(Me.GroupBox3)
        Me.GroupBox1_categorie.Controls.Add(Me.Button3)
        Me.GroupBox1_categorie.Controls.Add(Me.Button1)
        Me.GroupBox1_categorie.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1_categorie.Location = New System.Drawing.Point(4, 46)
        Me.GroupBox1_categorie.Name = "GroupBox1_categorie"
        Me.GroupBox1_categorie.Size = New System.Drawing.Size(928, 513)
        Me.GroupBox1_categorie.TabIndex = 0
        Me.GroupBox1_categorie.TabStop = False
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label25.Location = New System.Drawing.Point(847, 168)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(59, 16)
        Me.Label25.TabIndex = 21
        Me.Label25.Text = "Annuler"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label24.Location = New System.Drawing.Point(745, 168)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(64, 16)
        Me.Label24.TabIndex = 20
        Me.Label24.Text = "Modifier"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label22.Location = New System.Drawing.Point(840, 74)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(79, 16)
        Me.Label22.TabIndex = 18
        Me.Label22.Text = "Supprimer"
        '
        'dgvcategorie
        '
        Me.dgvcategorie.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvcategorie.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvcategorie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvcategorie.Location = New System.Drawing.Point(6, 231)
        Me.dgvcategorie.Name = "dgvcategorie"
        Me.dgvcategorie.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvcategorie.Size = New System.Drawing.Size(914, 269)
        Me.dgvcategorie.TabIndex = 7
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label23.Location = New System.Drawing.Point(745, 76)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(57, 16)
        Me.Label23.TabIndex = 19
        Me.Label23.Text = "Ajouter"
        '
        'Button4
        '
        Me.Button4.BackgroundImage = Global.EDG_Mamou.My.Resources.Resources.button_cancel
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(846, 13)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(60, 58)
        Me.Button4.TabIndex = 6
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.BackgroundImage = Global.EDG_Mamou.My.Resources.Resources.editdelete
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(846, 114)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(60, 55)
        Me.Button5.TabIndex = 4
        Me.Button5.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label20)
        Me.GroupBox3.Controls.Add(Me.txt_limit_franchi)
        Me.GroupBox3.Controls.Add(Me.Label21)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Controls.Add(Me.txt_prime_fix)
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.txt_franchi_pourcent)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.txtmontant3_cat)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.txtmontant2_cat)
        Me.GroupBox3.Controls.Add(Me.txttranche3_cat)
        Me.GroupBox3.Controls.Add(Me.txtmontant1_cat)
        Me.GroupBox3.Controls.Add(Me.txttranche2_cat)
        Me.GroupBox3.Controls.Add(Me.txttranche1_cat)
        Me.GroupBox3.Controls.Add(Me.txtcategorie_cat)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Location = New System.Drawing.Point(-6, 0)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(732, 225)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        '
        'Label20
        '
        Me.Label20.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(336, 189)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(56, 23)
        Me.Label20.TabIndex = 30
        Me.Label20.Text = "GNF" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txt_limit_franchi
        '
        Me.txt_limit_franchi.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_limit_franchi.Location = New System.Drawing.Point(219, 186)
        Me.txt_limit_franchi.Name = "txt_limit_franchi"
        Me.txt_limit_franchi.Size = New System.Drawing.Size(116, 27)
        Me.txt_limit_franchi.TabIndex = 29
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(13, 186)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(207, 23)
        Me.Label21.TabIndex = 28
        Me.Label21.Text = "Limite franchissement"
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(675, 152)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(56, 23)
        Me.Label18.TabIndex = 27
        Me.Label18.Text = "GNF" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txt_prime_fix
        '
        Me.txt_prime_fix.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_prime_fix.Location = New System.Drawing.Point(521, 147)
        Me.txt_prime_fix.Name = "txt_prime_fix"
        Me.txt_prime_fix.Size = New System.Drawing.Size(149, 27)
        Me.txt_prime_fix.TabIndex = 26
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(405, 150)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(104, 23)
        Me.Label19.TabIndex = 25
        Me.Label19.Text = "Prime Fixe"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(13, 152)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(152, 23)
        Me.Label15.TabIndex = 18
        Me.Label15.Text = "Franchissement"
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(336, 153)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(28, 31)
        Me.Label14.TabIndex = 21
        Me.Label14.Text = "%"
        '
        'txt_franchi_pourcent
        '
        Me.txt_franchi_pourcent.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_franchi_pourcent.Location = New System.Drawing.Point(192, 151)
        Me.txt_franchi_pourcent.Name = "txt_franchi_pourcent"
        Me.txt_franchi_pourcent.Size = New System.Drawing.Size(143, 27)
        Me.txt_franchi_pourcent.TabIndex = 20
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(675, 87)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(53, 26)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "GNF" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(675, 121)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 23)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "GNF" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(675, 48)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 31)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "GNF" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txtmontant3_cat
        '
        Me.txtmontant3_cat.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmontant3_cat.Location = New System.Drawing.Point(521, 114)
        Me.txtmontant3_cat.Name = "txtmontant3_cat"
        Me.txtmontant3_cat.Size = New System.Drawing.Size(149, 27)
        Me.txtmontant3_cat.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(403, 116)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(91, 23)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = " Montant"
        '
        'txtmontant2_cat
        '
        Me.txtmontant2_cat.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmontant2_cat.Location = New System.Drawing.Point(521, 81)
        Me.txtmontant2_cat.Name = "txtmontant2_cat"
        Me.txtmontant2_cat.Size = New System.Drawing.Size(149, 27)
        Me.txtmontant2_cat.TabIndex = 11
        '
        'txttranche3_cat
        '
        Me.txttranche3_cat.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttranche3_cat.Location = New System.Drawing.Point(192, 116)
        Me.txttranche3_cat.Name = "txttranche3_cat"
        Me.txttranche3_cat.Size = New System.Drawing.Size(143, 27)
        Me.txttranche3_cat.TabIndex = 10
        '
        'txtmontant1_cat
        '
        Me.txtmontant1_cat.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmontant1_cat.Location = New System.Drawing.Point(521, 48)
        Me.txtmontant1_cat.Name = "txtmontant1_cat"
        Me.txtmontant1_cat.Size = New System.Drawing.Size(149, 27)
        Me.txtmontant1_cat.TabIndex = 9
        '
        'txttranche2_cat
        '
        Me.txttranche2_cat.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttranche2_cat.Location = New System.Drawing.Point(192, 81)
        Me.txttranche2_cat.Name = "txttranche2_cat"
        Me.txttranche2_cat.Size = New System.Drawing.Size(143, 27)
        Me.txttranche2_cat.TabIndex = 8
        '
        'txttranche1_cat
        '
        Me.txttranche1_cat.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttranche1_cat.Location = New System.Drawing.Point(192, 46)
        Me.txttranche1_cat.Name = "txttranche1_cat"
        Me.txttranche1_cat.Size = New System.Drawing.Size(143, 27)
        Me.txttranche1_cat.TabIndex = 7
        '
        'txtcategorie_cat
        '
        Me.txtcategorie_cat.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcategorie_cat.Location = New System.Drawing.Point(192, 12)
        Me.txtcategorie_cat.Name = "txtcategorie_cat"
        Me.txtcategorie_cat.Size = New System.Drawing.Size(478, 27)
        Me.txtcategorie_cat.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(403, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 23)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = " Montant"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(403, 82)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 23)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = " Montant"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(13, 118)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(174, 23)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Troisième Tranche" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(182, 23)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Deuxième Tranche"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(170, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Premiere Tranche"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = " Categorie"
        '
        'Button3
        '
        Me.Button3.BackgroundImage = Global.EDG_Mamou.My.Resources.Resources.kate
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(745, 114)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(60, 52)
        Me.Button3.TabIndex = 5
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.EDG_Mamou.My.Resources.Resources.apply
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(745, 14)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(60, 57)
        Me.Button1.TabIndex = 0
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Green
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Yellow
        Me.Label11.Location = New System.Drawing.Point(6, 1)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(945, 42)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "Gestion des Catégories de Batiments"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Categories
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(936, 558)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.GroupBox1_categorie)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Categories"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Categories"
        Me.GroupBox1_categorie.ResumeLayout(False)
        Me.GroupBox1_categorie.PerformLayout()
        CType(Me.dgvcategorie, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1_categorie As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtmontant3_cat As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtmontant2_cat As System.Windows.Forms.TextBox
    Friend WithEvents txttranche3_cat As System.Windows.Forms.TextBox
    Friend WithEvents txtmontant1_cat As System.Windows.Forms.TextBox
    Friend WithEvents txttranche2_cat As System.Windows.Forms.TextBox
    Friend WithEvents txttranche1_cat As System.Windows.Forms.TextBox
    Friend WithEvents txtcategorie_cat As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents dgvcategorie As System.Windows.Forms.DataGridView
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txt_franchi_pourcent As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txt_limit_franchi As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txt_prime_fix As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label

End Class
