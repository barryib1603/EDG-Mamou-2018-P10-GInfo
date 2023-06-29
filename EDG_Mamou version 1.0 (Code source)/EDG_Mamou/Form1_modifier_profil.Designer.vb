<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1_modifier_profil
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lbl_titre = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btn_modifier_mp = New System.Windows.Forms.Button()
        Me.btn_modifier_login = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.txt_confirme = New System.Windows.Forms.TextBox()
        Me.txt_nouv = New System.Windows.Forms.TextBox()
        Me.txt_ancien = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.lbl_titre)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(531, 39)
        Me.Panel1.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.EDG_Mamou.My.Resources.Resources.EDG_0
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(31, 26)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'lbl_titre
        '
        Me.lbl_titre.BackColor = System.Drawing.Color.Green
        Me.lbl_titre.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_titre.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_titre.ForeColor = System.Drawing.Color.Yellow
        Me.lbl_titre.Location = New System.Drawing.Point(0, 0)
        Me.lbl_titre.Name = "lbl_titre"
        Me.lbl_titre.Size = New System.Drawing.Size(493, 39)
        Me.lbl_titre.TabIndex = 1
        Me.lbl_titre.Text = "Modifier mon Profil"
        Me.lbl_titre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Green
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(493, 0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(38, 39)
        Me.Button2.TabIndex = 0
        Me.Button2.Text = "X"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Silver
        Me.Panel2.Controls.Add(Me.btn_modifier_mp)
        Me.Panel2.Controls.Add(Me.btn_modifier_login)
        Me.Panel2.Controls.Add(Me.Button3)
        Me.Panel2.Controls.Add(Me.txt_confirme)
        Me.Panel2.Controls.Add(Me.txt_nouv)
        Me.Panel2.Controls.Add(Me.txt_ancien)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 39)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(531, 172)
        Me.Panel2.TabIndex = 2
        '
        'btn_modifier_mp
        '
        Me.btn_modifier_mp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_modifier_mp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_modifier_mp.Location = New System.Drawing.Point(404, 125)
        Me.btn_modifier_mp.Name = "btn_modifier_mp"
        Me.btn_modifier_mp.Size = New System.Drawing.Size(111, 35)
        Me.btn_modifier_mp.TabIndex = 15
        Me.btn_modifier_mp.Text = "Valider"
        Me.btn_modifier_mp.UseVisualStyleBackColor = True
        '
        'btn_modifier_login
        '
        Me.btn_modifier_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_modifier_login.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_modifier_login.Location = New System.Drawing.Point(15, 125)
        Me.btn_modifier_login.Name = "btn_modifier_login"
        Me.btn_modifier_login.Size = New System.Drawing.Size(111, 35)
        Me.btn_modifier_login.TabIndex = 14
        Me.btn_modifier_login.Text = "Valider"
        Me.btn_modifier_login.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(222, 125)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(111, 35)
        Me.Button3.TabIndex = 13
        Me.Button3.Text = "Annuler"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'txt_confirme
        '
        Me.txt_confirme.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_confirme.Location = New System.Drawing.Point(112, 84)
        Me.txt_confirme.Name = "txt_confirme"
        Me.txt_confirme.Size = New System.Drawing.Size(403, 26)
        Me.txt_confirme.TabIndex = 12
        Me.txt_confirme.UseSystemPasswordChar = True
        '
        'txt_nouv
        '
        Me.txt_nouv.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nouv.Location = New System.Drawing.Point(112, 50)
        Me.txt_nouv.Name = "txt_nouv"
        Me.txt_nouv.Size = New System.Drawing.Size(403, 26)
        Me.txt_nouv.TabIndex = 11
        Me.txt_nouv.UseSystemPasswordChar = True
        '
        'txt_ancien
        '
        Me.txt_ancien.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ancien.Location = New System.Drawing.Point(112, 16)
        Me.txt_ancien.Name = "txt_ancien"
        Me.txt_ancien.Size = New System.Drawing.Size(403, 26)
        Me.txt_ancien.TabIndex = 10
        Me.txt_ancien.UseSystemPasswordChar = True
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(11, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 24)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Ancien :"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(11, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Confirmer :"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nouveau :"
        '
        'Form1_modifier_profil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(531, 211)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1_modifier_profil"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1_modifier_profil"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbl_titre As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents txt_confirme As System.Windows.Forms.TextBox
    Friend WithEvents txt_nouv As System.Windows.Forms.TextBox
    Friend WithEvents txt_ancien As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btn_modifier_login As System.Windows.Forms.Button
    Friend WithEvents btn_modifier_mp As System.Windows.Forms.Button
End Class
