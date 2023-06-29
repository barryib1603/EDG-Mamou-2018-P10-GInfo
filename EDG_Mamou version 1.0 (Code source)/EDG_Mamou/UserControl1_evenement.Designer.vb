<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl1_evenement
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
        Me.dgvevenement = New System.Windows.Forms.DataGridView()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.cmb_rechercher = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtrecherche_even = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.rtxt_eve_sur_even = New System.Windows.Forms.RichTextBox()
        Me.lbldate_fin_even = New System.Windows.Forms.Label()
        Me.lbldate_debut_even = New System.Windows.Forms.Label()
        Me.lblzone_even = New System.Windows.Forms.Label()
        Me.lbllibelle_even = New System.Windows.Forms.Label()
        Me.lblposte_even = New System.Windows.Forms.Label()
        Me.lblagent_even = New System.Windows.Forms.Label()
        Me.lbl_num_even = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.dgv_evenement_poste = New System.Windows.Forms.DataGridView()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgvevenement, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgv_evenement_poste, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel7.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1153, 32)
        Me.Panel1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Green
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(400, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(753, 32)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Fiche Des Evenements"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Green
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(400, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Liste des Evenement"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Green
        Me.Panel2.Controls.Add(Me.dgvevenement)
        Me.Panel2.Controls.Add(Me.Panel6)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 32)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(400, 509)
        Me.Panel2.TabIndex = 1
        '
        'dgvevenement
        '
        Me.dgvevenement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvevenement.Location = New System.Drawing.Point(5, 73)
        Me.dgvevenement.Name = "dgvevenement"
        Me.dgvevenement.ReadOnly = True
        Me.dgvevenement.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvevenement.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvevenement.Size = New System.Drawing.Size(395, 414)
        Me.dgvevenement.TabIndex = 1
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Green
        Me.Panel6.Controls.Add(Me.cmb_rechercher)
        Me.Panel6.Controls.Add(Me.Label11)
        Me.Panel6.Controls.Add(Me.Button1)
        Me.Panel6.Controls.Add(Me.txtrecherche_even)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(400, 71)
        Me.Panel6.TabIndex = 0
        '
        'cmb_rechercher
        '
        Me.cmb_rechercher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_rechercher.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_rechercher.FormattingEnabled = True
        Me.cmb_rechercher.Items.AddRange(New Object() {"Numéro", "Agent", "Poste", "Zone", "Date debut", "Date fin"})
        Me.cmb_rechercher.Location = New System.Drawing.Point(164, 6)
        Me.cmb_rechercher.Name = "cmb_rechercher"
        Me.cmb_rechercher.Size = New System.Drawing.Size(184, 24)
        Me.cmb_rechercher.TabIndex = 3
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(51, 11)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(116, 19)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "rechercher par :"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(303, 31)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(46, 38)
        Me.Button1.TabIndex = 1
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtrecherche_even
        '
        Me.txtrecherche_even.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtrecherche_even.Location = New System.Drawing.Point(53, 36)
        Me.txtrecherche_even.Name = "txtrecherche_even"
        Me.txtrecherche_even.Size = New System.Drawing.Size(242, 29)
        Me.txtrecherche_even.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Green
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(400, 32)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(10, 509)
        Me.Panel3.TabIndex = 2
        '
        'Panel4
        '
        Me.Panel4.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Panel4.Controls.Add(Me.Button5)
        Me.Panel4.Controls.Add(Me.Button4)
        Me.Panel4.Controls.Add(Me.Button3)
        Me.Panel4.Controls.Add(Me.Button2)
        Me.Panel4.Location = New System.Drawing.Point(529, 485)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(200, 56)
        Me.Panel4.TabIndex = 3
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(443, 2)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(89, 52)
        Me.Button5.TabIndex = 3
        Me.Button5.Text = "Supprimer"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(337, 2)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(89, 52)
        Me.Button4.TabIndex = 2
        Me.Button4.Text = "Supprimer"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(227, 3)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(89, 52)
        Me.Button3.TabIndex = 1
        Me.Button3.Text = "Modifier"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(119, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(89, 52)
        Me.Button2.TabIndex = 0
        Me.Button2.Text = "Ajouter"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.TabControl1)
        Me.Panel5.Controls.Add(Me.Panel7)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(410, 32)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(743, 509)
        Me.Panel5.TabIndex = 4
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(732, 442)
        Me.TabControl1.TabIndex = 7
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Silver
        Me.TabPage1.Controls.Add(Me.rtxt_eve_sur_even)
        Me.TabPage1.Controls.Add(Me.lbldate_fin_even)
        Me.TabPage1.Controls.Add(Me.lbldate_debut_even)
        Me.TabPage1.Controls.Add(Me.lblzone_even)
        Me.TabPage1.Controls.Add(Me.lbllibelle_even)
        Me.TabPage1.Controls.Add(Me.lblposte_even)
        Me.TabPage1.Controls.Add(Me.lblagent_even)
        Me.TabPage1.Controls.Add(Me.lbl_num_even)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Location = New System.Drawing.Point(4, 28)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(724, 410)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Details"
        '
        'rtxt_eve_sur_even
        '
        Me.rtxt_eve_sur_even.Location = New System.Drawing.Point(358, 31)
        Me.rtxt_eve_sur_even.Name = "rtxt_eve_sur_even"
        Me.rtxt_eve_sur_even.ReadOnly = True
        Me.rtxt_eve_sur_even.Size = New System.Drawing.Size(366, 259)
        Me.rtxt_eve_sur_even.TabIndex = 16
        Me.rtxt_eve_sur_even.Text = ""
        '
        'lbldate_fin_even
        '
        Me.lbldate_fin_even.BackColor = System.Drawing.Color.Gainsboro
        Me.lbldate_fin_even.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldate_fin_even.Location = New System.Drawing.Point(112, 267)
        Me.lbldate_fin_even.Name = "lbldate_fin_even"
        Me.lbldate_fin_even.Size = New System.Drawing.Size(239, 22)
        Me.lbldate_fin_even.TabIndex = 15
        '
        'lbldate_debut_even
        '
        Me.lbldate_debut_even.BackColor = System.Drawing.Color.Gainsboro
        Me.lbldate_debut_even.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldate_debut_even.Location = New System.Drawing.Point(112, 226)
        Me.lbldate_debut_even.Name = "lbldate_debut_even"
        Me.lbldate_debut_even.Size = New System.Drawing.Size(239, 22)
        Me.lbldate_debut_even.TabIndex = 14
        '
        'lblzone_even
        '
        Me.lblzone_even.BackColor = System.Drawing.Color.Gainsboro
        Me.lblzone_even.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblzone_even.Location = New System.Drawing.Point(112, 145)
        Me.lblzone_even.Name = "lblzone_even"
        Me.lblzone_even.Size = New System.Drawing.Size(239, 22)
        Me.lblzone_even.TabIndex = 12
        '
        'lbllibelle_even
        '
        Me.lbllibelle_even.BackColor = System.Drawing.Color.Gainsboro
        Me.lbllibelle_even.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbllibelle_even.Location = New System.Drawing.Point(112, 186)
        Me.lbllibelle_even.Name = "lbllibelle_even"
        Me.lbllibelle_even.Size = New System.Drawing.Size(239, 22)
        Me.lbllibelle_even.TabIndex = 11
        '
        'lblposte_even
        '
        Me.lblposte_even.BackColor = System.Drawing.Color.Gainsboro
        Me.lblposte_even.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblposte_even.Location = New System.Drawing.Point(112, 108)
        Me.lblposte_even.Name = "lblposte_even"
        Me.lblposte_even.Size = New System.Drawing.Size(239, 22)
        Me.lblposte_even.TabIndex = 10
        '
        'lblagent_even
        '
        Me.lblagent_even.BackColor = System.Drawing.Color.Gainsboro
        Me.lblagent_even.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblagent_even.Location = New System.Drawing.Point(112, 68)
        Me.lblagent_even.Name = "lblagent_even"
        Me.lblagent_even.Size = New System.Drawing.Size(239, 22)
        Me.lblagent_even.TabIndex = 9
        '
        'lbl_num_even
        '
        Me.lbl_num_even.BackColor = System.Drawing.Color.Gainsboro
        Me.lbl_num_even.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_num_even.Location = New System.Drawing.Point(112, 29)
        Me.lbl_num_even.Name = "lbl_num_even"
        Me.lbl_num_even.Size = New System.Drawing.Size(239, 22)
        Me.lbl_num_even.TabIndex = 8
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(454, 6)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(172, 22)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "Evenement Survenu"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(15, 185)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 22)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Libelle"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 268)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 22)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Date Fin"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 227)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(103, 22)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Date Debut"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(15, 144)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 22)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Zone"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(15, 107)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 22)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Poste"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(15, 67)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 22)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Agent"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 22)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Numero"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.Silver
        Me.TabPage2.Controls.Add(Me.dgv_evenement_poste)
        Me.TabPage2.Controls.Add(Me.Panel8)
        Me.TabPage2.Controls.Add(Me.Label20)
        Me.TabPage2.Location = New System.Drawing.Point(4, 28)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(724, 410)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Evenement"
        '
        'dgv_evenement_poste
        '
        Me.dgv_evenement_poste.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv_evenement_poste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_evenement_poste.Location = New System.Drawing.Point(6, 36)
        Me.dgv_evenement_poste.Name = "dgv_evenement_poste"
        Me.dgv_evenement_poste.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_evenement_poste.Size = New System.Drawing.Size(712, 351)
        Me.dgv_evenement_poste.TabIndex = 5
        '
        'Panel8
        '
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel8.Location = New System.Drawing.Point(3, 393)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(718, 14)
        Me.Panel8.TabIndex = 4
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Times New Roman", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(127, 1)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(380, 31)
        Me.Label20.TabIndex = 2
        Me.Label20.Text = "La liste des Evenement du Poste"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.Green
        Me.Panel7.Controls.Add(Me.Label12)
        Me.Panel7.Controls.Add(Me.Label18)
        Me.Panel7.Controls.Add(Me.Label17)
        Me.Panel7.Controls.Add(Me.Label14)
        Me.Panel7.Controls.Add(Me.Button9)
        Me.Panel7.Controls.Add(Me.Button8)
        Me.Panel7.Controls.Add(Me.Button7)
        Me.Panel7.Controls.Add(Me.Button6)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel7.Location = New System.Drawing.Point(0, 442)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(743, 67)
        Me.Panel7.TabIndex = 0
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Yellow
        Me.Label12.Location = New System.Drawing.Point(293, 49)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(76, 15)
        Me.Label12.TabIndex = 17
        Me.Label12.Text = "Impression"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Yellow
        Me.Label18.Location = New System.Drawing.Point(179, 46)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(73, 15)
        Me.Label18.TabIndex = 16
        Me.Label18.Text = "Supprimer"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Yellow
        Me.Label17.Location = New System.Drawing.Point(93, 46)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(58, 15)
        Me.Label17.TabIndex = 15
        Me.Label17.Text = "Modifier"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Yellow
        Me.Label14.Location = New System.Drawing.Point(8, 46)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(52, 15)
        Me.Label14.TabIndex = 14
        Me.Label14.Text = "Ajouter"
        '
        'Button9
        '
        Me.Button9.BackgroundImage = Global.EDG_Mamou.My.Resources.Resources.button_cancel
        Me.Button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button9.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.Location = New System.Drawing.Point(185, 7)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(59, 37)
        Me.Button9.TabIndex = 3
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.BackgroundImage = Global.EDG_Mamou.My.Resources.Resources.printmgr
        Me.Button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.Location = New System.Drawing.Point(296, 5)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(81, 40)
        Me.Button8.TabIndex = 2
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.BackgroundImage = Global.EDG_Mamou.My.Resources.Resources.kate
        Me.Button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(96, 5)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(57, 39)
        Me.Button7.TabIndex = 1
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.BackgroundImage = Global.EDG_Mamou.My.Resources.Resources.edit_add
        Me.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(0, 5)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(70, 38)
        Me.Button6.TabIndex = 0
        Me.Button6.UseVisualStyleBackColor = True
        '
        'UserControl1_evenement
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Green
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "UserControl1_evenement"
        Me.Size = New System.Drawing.Size(1153, 541)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.dgvevenement, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.dgv_evenement_poste, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtrecherche_even As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents lbldate_fin_even As System.Windows.Forms.Label
    Friend WithEvents lbldate_debut_even As System.Windows.Forms.Label
    Friend WithEvents lblzone_even As System.Windows.Forms.Label
    Friend WithEvents lbllibelle_even As System.Windows.Forms.Label
    Friend WithEvents lblposte_even As System.Windows.Forms.Label
    Friend WithEvents lblagent_even As System.Windows.Forms.Label
    Friend WithEvents lbl_num_even As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents rtxt_eve_sur_even As System.Windows.Forms.RichTextBox
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents dgvevenement As System.Windows.Forms.DataGridView
    Friend WithEvents cmb_rechercher As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents dgv_evenement_poste As System.Windows.Forms.DataGridView
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label

End Class
