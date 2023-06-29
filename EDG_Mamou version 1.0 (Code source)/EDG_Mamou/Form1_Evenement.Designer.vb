<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1_Evenement
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
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtnum_even = New System.Windows.Forms.TextBox()
        Me.txtlibelle_even = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.rtxt_evensur_even = New System.Windows.Forms.RichTextBox()
        Me.cmb_agent = New System.Windows.Forms.ComboBox()
        Me.cmb_poste = New System.Windows.Forms.ComboBox()
        Me.cmb_zone = New System.Windows.Forms.ComboBox()
        Me.dtpdebut = New System.Windows.Forms.DateTimePicker()
        Me.dtpfin = New System.Windows.Forms.DateTimePicker()
        Me.btnModifier_ev = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(562, 41)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(172, 22)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "Evenement Survenu"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(8, 260)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 22)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Libelle"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(8, 363)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 22)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Date Fin"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(8, 314)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(103, 22)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Date Debut"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 217)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 22)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Zone"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 165)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 22)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Poste"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 119)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 22)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Agent"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 22)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Numero"
        '
        'txtnum_even
        '
        Me.txtnum_even.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnum_even.Location = New System.Drawing.Point(114, 67)
        Me.txtnum_even.Name = "txtnum_even"
        Me.txtnum_even.ReadOnly = True
        Me.txtnum_even.Size = New System.Drawing.Size(260, 29)
        Me.txtnum_even.TabIndex = 16
        '
        'txtlibelle_even
        '
        Me.txtlibelle_even.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlibelle_even.Location = New System.Drawing.Point(114, 260)
        Me.txtlibelle_even.Name = "txtlibelle_even"
        Me.txtlibelle_even.Size = New System.Drawing.Size(260, 29)
        Me.txtlibelle_even.TabIndex = 20
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Green
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(875, 41)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Gestion des Evenements"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.EDG_Mamou.My.Resources.Resources.apply
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(114, 406)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(68, 45)
        Me.Button1.TabIndex = 25
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackgroundImage = Global.EDG_Mamou.My.Resources.Resources.editdelete
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(295, 406)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(74, 45)
        Me.Button2.TabIndex = 26
        Me.Button2.UseVisualStyleBackColor = True
        '
        'rtxt_evensur_even
        '
        Me.rtxt_evensur_even.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtxt_evensur_even.Location = New System.Drawing.Point(380, 67)
        Me.rtxt_evensur_even.Name = "rtxt_evensur_even"
        Me.rtxt_evensur_even.Size = New System.Drawing.Size(487, 395)
        Me.rtxt_evensur_even.TabIndex = 27
        Me.rtxt_evensur_even.Text = ""
        '
        'cmb_agent
        '
        Me.cmb_agent.Font = New System.Drawing.Font("Times New Roman", 14.25!)
        Me.cmb_agent.FormattingEnabled = True
        Me.cmb_agent.Location = New System.Drawing.Point(114, 118)
        Me.cmb_agent.Name = "cmb_agent"
        Me.cmb_agent.Size = New System.Drawing.Size(259, 29)
        Me.cmb_agent.TabIndex = 28
        '
        'cmb_poste
        '
        Me.cmb_poste.Font = New System.Drawing.Font("Times New Roman", 14.25!)
        Me.cmb_poste.FormattingEnabled = True
        Me.cmb_poste.Location = New System.Drawing.Point(115, 165)
        Me.cmb_poste.Name = "cmb_poste"
        Me.cmb_poste.Size = New System.Drawing.Size(259, 29)
        Me.cmb_poste.TabIndex = 29
        '
        'cmb_zone
        '
        Me.cmb_zone.Font = New System.Drawing.Font("Times New Roman", 14.25!)
        Me.cmb_zone.FormattingEnabled = True
        Me.cmb_zone.Location = New System.Drawing.Point(114, 210)
        Me.cmb_zone.Name = "cmb_zone"
        Me.cmb_zone.Size = New System.Drawing.Size(259, 29)
        Me.cmb_zone.TabIndex = 30
        '
        'dtpdebut
        '
        Me.dtpdebut.Font = New System.Drawing.Font("Times New Roman", 14.25!)
        Me.dtpdebut.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpdebut.Location = New System.Drawing.Point(114, 307)
        Me.dtpdebut.Name = "dtpdebut"
        Me.dtpdebut.Size = New System.Drawing.Size(260, 29)
        Me.dtpdebut.TabIndex = 31
        '
        'dtpfin
        '
        Me.dtpfin.Font = New System.Drawing.Font("Times New Roman", 14.25!)
        Me.dtpfin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfin.Location = New System.Drawing.Point(114, 358)
        Me.dtpfin.Name = "dtpfin"
        Me.dtpfin.Size = New System.Drawing.Size(260, 29)
        Me.dtpfin.TabIndex = 32
        '
        'btnModifier_ev
        '
        Me.btnModifier_ev.BackgroundImage = Global.EDG_Mamou.My.Resources.Resources.kate
        Me.btnModifier_ev.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnModifier_ev.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModifier_ev.Location = New System.Drawing.Point(202, 406)
        Me.btnModifier_ev.Name = "btnModifier_ev"
        Me.btnModifier_ev.Size = New System.Drawing.Size(69, 45)
        Me.btnModifier_ev.TabIndex = 33
        Me.btnModifier_ev.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Red
        Me.Label14.Location = New System.Drawing.Point(112, 454)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(56, 16)
        Me.Label14.TabIndex = 34
        Me.Label14.Text = "ajouter"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Red
        Me.Label17.Location = New System.Drawing.Point(207, 454)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(64, 16)
        Me.Label17.TabIndex = 35
        Me.Label17.Text = "modifier"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Red
        Me.Label18.Location = New System.Drawing.Point(292, 454)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(77, 16)
        Me.Label18.TabIndex = 36
        Me.Label18.Text = "supprimer"
        '
        'Form1_Evenement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(875, 477)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.btnModifier_ev)
        Me.Controls.Add(Me.dtpfin)
        Me.Controls.Add(Me.dtpdebut)
        Me.Controls.Add(Me.cmb_zone)
        Me.Controls.Add(Me.cmb_poste)
        Me.Controls.Add(Me.cmb_agent)
        Me.Controls.Add(Me.rtxt_evensur_even)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtlibelle_even)
        Me.Controls.Add(Me.txtnum_even)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.MaximizeBox = False
        Me.Name = "Form1_Evenement"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1_Evenement"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtnum_even As System.Windows.Forms.TextBox
    Friend WithEvents txtlibelle_even As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents rtxt_evensur_even As System.Windows.Forms.RichTextBox
    Friend WithEvents cmb_agent As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_poste As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_zone As System.Windows.Forms.ComboBox
    Friend WithEvents dtpdebut As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpfin As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnModifier_ev As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
End Class
