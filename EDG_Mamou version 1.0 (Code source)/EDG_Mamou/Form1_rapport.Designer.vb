<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1_Rapport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1_Rapport))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtnum_rapport = New System.Windows.Forms.TextBox()
        Me.txtlibelle_rapport = New System.Windows.Forms.TextBox()
        Me.btn_ajout = New System.Windows.Forms.Button()
        Me.btn_annul = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmb_tpersonnel_rapport = New System.Windows.Forms.ComboBox()
        Me.rtxtdescription_rapport = New System.Windows.Forms.RichTextBox()
        Me.btn_modifier = New System.Windows.Forms.Button()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(11, 152)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 22)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Libelle"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(11, 116)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 22)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Personnel"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 22)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Numero"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(494, 51)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 24)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Description"
        '
        'txtnum_rapport
        '
        Me.txtnum_rapport.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnum_rapport.Location = New System.Drawing.Point(103, 78)
        Me.txtnum_rapport.Name = "txtnum_rapport"
        Me.txtnum_rapport.Size = New System.Drawing.Size(192, 24)
        Me.txtnum_rapport.TabIndex = 11
        '
        'txtlibelle_rapport
        '
        Me.txtlibelle_rapport.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlibelle_rapport.Location = New System.Drawing.Point(103, 151)
        Me.txtlibelle_rapport.Name = "txtlibelle_rapport"
        Me.txtlibelle_rapport.Size = New System.Drawing.Size(192, 24)
        Me.txtlibelle_rapport.TabIndex = 13
        '
        'btn_ajout
        '
        Me.btn_ajout.BackgroundImage = Global.EDG_Mamou.My.Resources.Resources.apply
        Me.btn_ajout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_ajout.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ajout.Location = New System.Drawing.Point(29, 303)
        Me.btn_ajout.Name = "btn_ajout"
        Me.btn_ajout.Size = New System.Drawing.Size(70, 57)
        Me.btn_ajout.TabIndex = 15
        Me.btn_ajout.UseVisualStyleBackColor = True
        '
        'btn_annul
        '
        Me.btn_annul.BackgroundImage = Global.EDG_Mamou.My.Resources.Resources.editdelete
        Me.btn_annul.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_annul.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_annul.Location = New System.Drawing.Point(216, 304)
        Me.btn_annul.Name = "btn_annul"
        Me.btn_annul.Size = New System.Drawing.Size(71, 57)
        Me.btn_annul.TabIndex = 16
        Me.btn_annul.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Green
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Yellow
        Me.Label6.Location = New System.Drawing.Point(2, 2)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(807, 49)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Rapport"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmb_tpersonnel_rapport
        '
        Me.cmb_tpersonnel_rapport.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_tpersonnel_rapport.FormattingEnabled = True
        Me.cmb_tpersonnel_rapport.Location = New System.Drawing.Point(103, 113)
        Me.cmb_tpersonnel_rapport.Name = "cmb_tpersonnel_rapport"
        Me.cmb_tpersonnel_rapport.Size = New System.Drawing.Size(192, 26)
        Me.cmb_tpersonnel_rapport.TabIndex = 18
        '
        'rtxtdescription_rapport
        '
        Me.rtxtdescription_rapport.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtxtdescription_rapport.Location = New System.Drawing.Point(301, 77)
        Me.rtxtdescription_rapport.Name = "rtxtdescription_rapport"
        Me.rtxtdescription_rapport.Size = New System.Drawing.Size(506, 334)
        Me.rtxtdescription_rapport.TabIndex = 10
        Me.rtxtdescription_rapport.Text = ""
        '
        'btn_modifier
        '
        Me.btn_modifier.BackgroundImage = Global.EDG_Mamou.My.Resources.Resources.kate
        Me.btn_modifier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_modifier.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_modifier.Location = New System.Drawing.Point(121, 304)
        Me.btn_modifier.Name = "btn_modifier"
        Me.btn_modifier.Size = New System.Drawing.Size(71, 57)
        Me.btn_modifier.TabIndex = 19
        Me.btn_modifier.UseVisualStyleBackColor = True
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Red
        Me.Label19.Location = New System.Drawing.Point(222, 366)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(59, 16)
        Me.Label19.TabIndex = 40
        Me.Label19.Text = "annuler"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Red
        Me.Label14.Location = New System.Drawing.Point(36, 366)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(56, 16)
        Me.Label14.TabIndex = 41
        Me.Label14.Text = "ajouter"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Red
        Me.Label17.Location = New System.Drawing.Point(128, 366)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(64, 16)
        Me.Label17.TabIndex = 42
        Me.Label17.Text = "modifier"
        '
        'Form1_Rapport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(813, 424)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.btn_modifier)
        Me.Controls.Add(Me.cmb_tpersonnel_rapport)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btn_annul)
        Me.Controls.Add(Me.btn_ajout)
        Me.Controls.Add(Me.txtlibelle_rapport)
        Me.Controls.Add(Me.txtnum_rapport)
        Me.Controls.Add(Me.rtxtdescription_rapport)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1_Rapport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1_Rapport"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtnum_rapport As System.Windows.Forms.TextBox
    Friend WithEvents txtlibelle_rapport As System.Windows.Forms.TextBox
    Friend WithEvents btn_ajout As System.Windows.Forms.Button
    Friend WithEvents btn_annul As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmb_tpersonnel_rapport As System.Windows.Forms.ComboBox
    Friend WithEvents rtxtdescription_rapport As System.Windows.Forms.RichTextBox
    Friend WithEvents btn_modifier As System.Windows.Forms.Button
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
End Class
