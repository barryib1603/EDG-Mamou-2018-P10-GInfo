<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1_activites
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgv_activite = New System.Windows.Forms.DataGridView()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cb_dat = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cb_uti = New System.Windows.Forms.CheckBox()
        Me.cbx_utili = New System.Windows.Forms.ComboBox()
        Me.txt_dat = New System.Windows.Forms.MaskedTextBox()
        CType(Me.dgv_activite, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Green
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(893, 57)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Les activités des utilisateurs"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgv_activite
        '
        Me.dgv_activite.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_activite.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_activite.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_activite.Location = New System.Drawing.Point(10, 183)
        Me.dgv_activite.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgv_activite.Name = "dgv_activite"
        Me.dgv_activite.Size = New System.Drawing.Size(870, 431)
        Me.dgv_activite.TabIndex = 2
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(779, 132)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(101, 42)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Actualiser"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.GroupBox1.Controls.Add(Me.cb_dat)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.cb_uti)
        Me.GroupBox1.Controls.Add(Me.cbx_utili)
        Me.GroupBox1.Controls.Add(Me.txt_dat)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(10, 66)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(571, 108)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Rechercher Par :"
        '
        'cb_dat
        '
        Me.cb_dat.AutoSize = True
        Me.cb_dat.Location = New System.Drawing.Point(334, 27)
        Me.cb_dat.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cb_dat.Name = "cb_dat"
        Me.cb_dat.Size = New System.Drawing.Size(57, 23)
        Me.cb_dat.TabIndex = 1
        Me.cb_dat.Text = "Date"
        Me.cb_dat.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.EDG_Mamou.My.Resources.Resources.kghostview
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Location = New System.Drawing.Point(488, 46)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(48, 46)
        Me.Button1.TabIndex = 7
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cb_uti
        '
        Me.cb_uti.AutoSize = True
        Me.cb_uti.Location = New System.Drawing.Point(44, 27)
        Me.cb_uti.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cb_uti.Name = "cb_uti"
        Me.cb_uti.Size = New System.Drawing.Size(88, 23)
        Me.cb_uti.TabIndex = 0
        Me.cb_uti.Text = "Utilisateur"
        Me.cb_uti.UseVisualStyleBackColor = True
        '
        'cbx_utili
        '
        Me.cbx_utili.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbx_utili.FormattingEnabled = True
        Me.cbx_utili.Location = New System.Drawing.Point(42, 55)
        Me.cbx_utili.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbx_utili.Name = "cbx_utili"
        Me.cbx_utili.Size = New System.Drawing.Size(276, 27)
        Me.cbx_utili.TabIndex = 0
        '
        'txt_dat
        '
        Me.txt_dat.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_dat.Location = New System.Drawing.Point(332, 55)
        Me.txt_dat.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_dat.Mask = "00/00/0000"
        Me.txt_dat.Name = "txt_dat"
        Me.txt_dat.Size = New System.Drawing.Size(148, 26)
        Me.txt_dat.TabIndex = 4
        Me.txt_dat.ValidatingType = GetType(Date)
        '
        'Form1_activites
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(893, 620)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgv_activite)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form1_activites"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1_activites"
        CType(Me.dgv_activite, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgv_activite As System.Windows.Forms.DataGridView
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cb_dat As System.Windows.Forms.CheckBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cb_uti As System.Windows.Forms.CheckBox
    Friend WithEvents cbx_utili As System.Windows.Forms.ComboBox
    Friend WithEvents txt_dat As System.Windows.Forms.MaskedTextBox
End Class
