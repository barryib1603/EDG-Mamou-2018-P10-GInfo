<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl1_nouveau_message
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
        Me.txt_objet = New System.Windows.Forms.TextBox()
        Me.rtxt_message = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnEnvoie = New System.Windows.Forms.Button()
        Me.btnAnnule = New System.Windows.Forms.Button()
        Me.cmb_a = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt_objet
        '
        Me.txt_objet.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_objet.Location = New System.Drawing.Point(126, 57)
        Me.txt_objet.Name = "txt_objet"
        Me.txt_objet.Size = New System.Drawing.Size(658, 26)
        Me.txt_objet.TabIndex = 1
        '
        'rtxt_message
        '
        Me.rtxt_message.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtxt_message.Location = New System.Drawing.Point(126, 102)
        Me.rtxt_message.Name = "rtxt_message"
        Me.rtxt_message.Size = New System.Drawing.Size(658, 286)
        Me.rtxt_message.TabIndex = 2
        Me.rtxt_message.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(33, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "A :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Yellow
        Me.Label2.Location = New System.Drawing.Point(33, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Objet :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Yellow
        Me.Label3.Location = New System.Drawing.Point(33, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Message :"
        '
        'btnEnvoie
        '
        Me.btnEnvoie.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnvoie.Location = New System.Drawing.Point(507, 404)
        Me.btnEnvoie.Name = "btnEnvoie"
        Me.btnEnvoie.Size = New System.Drawing.Size(127, 28)
        Me.btnEnvoie.TabIndex = 6
        Me.btnEnvoie.Text = "Envoyer"
        Me.btnEnvoie.UseVisualStyleBackColor = True
        '
        'btnAnnule
        '
        Me.btnAnnule.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnnule.Location = New System.Drawing.Point(657, 404)
        Me.btnAnnule.Name = "btnAnnule"
        Me.btnAnnule.Size = New System.Drawing.Size(127, 28)
        Me.btnAnnule.TabIndex = 7
        Me.btnAnnule.Text = "Annuler"
        Me.btnAnnule.UseVisualStyleBackColor = True
        '
        'cmb_a
        '
        Me.cmb_a.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.cmb_a.FormattingEnabled = True
        Me.cmb_a.Location = New System.Drawing.Point(126, 15)
        Me.cmb_a.Name = "cmb_a"
        Me.cmb_a.Size = New System.Drawing.Size(658, 28)
        Me.cmb_a.TabIndex = 8
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Green
        Me.Panel1.Controls.Add(Me.cmb_a)
        Me.Panel1.Controls.Add(Me.btnAnnule)
        Me.Panel1.Controls.Add(Me.txt_objet)
        Me.Panel1.Controls.Add(Me.btnEnvoie)
        Me.Panel1.Controls.Add(Me.rtxt_message)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(825, 448)
        Me.Panel1.TabIndex = 0
        '
        'UserControl1_nouveau_message
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Green
        Me.Controls.Add(Me.Panel1)
        Me.Name = "UserControl1_nouveau_message"
        Me.Size = New System.Drawing.Size(825, 448)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txt_objet As System.Windows.Forms.TextBox
    Friend WithEvents rtxt_message As System.Windows.Forms.RichTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnEnvoie As System.Windows.Forms.Button
    Friend WithEvents btnAnnule As System.Windows.Forms.Button
    Friend WithEvents cmb_a As System.Windows.Forms.ComboBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel

End Class
