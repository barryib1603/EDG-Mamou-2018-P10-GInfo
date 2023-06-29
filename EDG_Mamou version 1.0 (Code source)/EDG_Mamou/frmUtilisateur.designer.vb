<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUtilisateur
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUtilisateur))
        Me.dtpDateCre_utilisateur = New System.Windows.Forms.DateTimePicker()
        Me.btnModifier = New System.Windows.Forms.Button()
        Me.txtLogin_utilisateur = New System.Windows.Forms.TextBox()
        Me.txtMotPasse_utilisateur = New System.Windows.Forms.TextBox()
        Me.btnEnregistrer = New System.Windows.Forms.Button()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtNom_utilisateur = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.txtNumero_utilisateur = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'dtpDateCre_utilisateur
        '
        Me.dtpDateCre_utilisateur.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDateCre_utilisateur.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDateCre_utilisateur.Location = New System.Drawing.Point(139, 255)
        Me.dtpDateCre_utilisateur.Name = "dtpDateCre_utilisateur"
        Me.dtpDateCre_utilisateur.Size = New System.Drawing.Size(327, 26)
        Me.dtpDateCre_utilisateur.TabIndex = 69
        '
        'btnModifier
        '
        Me.btnModifier.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModifier.Location = New System.Drawing.Point(345, 307)
        Me.btnModifier.Name = "btnModifier"
        Me.btnModifier.Size = New System.Drawing.Size(121, 36)
        Me.btnModifier.TabIndex = 62
        Me.btnModifier.Text = "Modifier"
        Me.btnModifier.UseVisualStyleBackColor = True
        '
        'txtLogin_utilisateur
        '
        Me.txtLogin_utilisateur.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLogin_utilisateur.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLogin_utilisateur.Location = New System.Drawing.Point(139, 170)
        Me.txtLogin_utilisateur.Name = "txtLogin_utilisateur"
        Me.txtLogin_utilisateur.Size = New System.Drawing.Size(328, 26)
        Me.txtLogin_utilisateur.TabIndex = 59
        Me.txtLogin_utilisateur.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtMotPasse_utilisateur
        '
        Me.txtMotPasse_utilisateur.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMotPasse_utilisateur.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMotPasse_utilisateur.Location = New System.Drawing.Point(139, 212)
        Me.txtMotPasse_utilisateur.Name = "txtMotPasse_utilisateur"
        Me.txtMotPasse_utilisateur.Size = New System.Drawing.Size(328, 26)
        Me.txtMotPasse_utilisateur.TabIndex = 60
        Me.txtMotPasse_utilisateur.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnEnregistrer
        '
        Me.btnEnregistrer.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnregistrer.Location = New System.Drawing.Point(207, 307)
        Me.btnEnregistrer.Name = "btnEnregistrer"
        Me.btnEnregistrer.Size = New System.Drawing.Size(121, 36)
        Me.btnEnregistrer.TabIndex = 61
        Me.btnEnregistrer.Text = "Enregistrer"
        Me.btnEnregistrer.UseVisualStyleBackColor = True
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(11, 255)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(112, 21)
        Me.Label21.TabIndex = 68
        Me.Label21.Text = "Date Création"
        '
        'txtNom_utilisateur
        '
        Me.txtNom_utilisateur.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNom_utilisateur.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNom_utilisateur.Location = New System.Drawing.Point(139, 128)
        Me.txtNom_utilisateur.Name = "txtNom_utilisateur"
        Me.txtNom_utilisateur.Size = New System.Drawing.Size(328, 26)
        Me.txtNom_utilisateur.TabIndex = 58
        Me.txtNom_utilisateur.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(12, 171)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(53, 21)
        Me.Label23.TabIndex = 67
        Me.Label23.Text = "Login"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(18, 129)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(47, 21)
        Me.Label24.TabIndex = 66
        Me.Label24.Text = "Nom"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(12, 213)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(112, 21)
        Me.Label27.TabIndex = 65
        Me.Label27.Text = "Mot de Passe"
        '
        'txtNumero_utilisateur
        '
        Me.txtNumero_utilisateur.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNumero_utilisateur.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumero_utilisateur.Location = New System.Drawing.Point(138, 86)
        Me.txtNumero_utilisateur.Name = "txtNumero_utilisateur"
        Me.txtNumero_utilisateur.Size = New System.Drawing.Size(328, 26)
        Me.txtNumero_utilisateur.TabIndex = 57
        Me.txtNumero_utilisateur.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(18, 87)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(70, 21)
        Me.Label28.TabIndex = 64
        Me.Label28.Text = "Numéro"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Green
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(479, 66)
        Me.Label1.TabIndex = 70
        Me.Label1.Text = "Gestion des Utilisateurs"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmUtilisateur
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(479, 374)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtpDateCre_utilisateur)
        Me.Controls.Add(Me.btnModifier)
        Me.Controls.Add(Me.txtLogin_utilisateur)
        Me.Controls.Add(Me.txtMotPasse_utilisateur)
        Me.Controls.Add(Me.btnEnregistrer)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.txtNom_utilisateur)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.txtNumero_utilisateur)
        Me.Controls.Add(Me.Label28)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmUtilisateur"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Utilisateur"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtpDateCre_utilisateur As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnModifier As System.Windows.Forms.Button
    Friend WithEvents txtLogin_utilisateur As System.Windows.Forms.TextBox
    Friend WithEvents txtMotPasse_utilisateur As System.Windows.Forms.TextBox
    Friend WithEvents btnEnregistrer As System.Windows.Forms.Button
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtNom_utilisateur As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents txtNumero_utilisateur As System.Windows.Forms.TextBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
