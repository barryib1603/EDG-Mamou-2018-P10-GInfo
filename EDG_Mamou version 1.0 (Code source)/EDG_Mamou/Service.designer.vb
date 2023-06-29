<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Service
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Service))
        Me.btnvalider = New System.Windows.Forms.Button()
        Me.btnsupprimer = New System.Windows.Forms.Button()
        Me.btnmodifier = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgv_service = New System.Windows.Forms.DataGridView()
        Me.txtlibelle_service = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_supprim = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.dgv_service, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnvalider
        '
        Me.btnvalider.BackgroundImage = Global.EDG_Mamou.My.Resources.Resources.apply
        Me.btnvalider.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnvalider.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnvalider.Location = New System.Drawing.Point(407, 70)
        Me.btnvalider.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnvalider.Name = "btnvalider"
        Me.btnvalider.Size = New System.Drawing.Size(66, 49)
        Me.btnvalider.TabIndex = 14
        Me.btnvalider.UseVisualStyleBackColor = True
        '
        'btnsupprimer
        '
        Me.btnsupprimer.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsupprimer.Location = New System.Drawing.Point(778, 532)
        Me.btnsupprimer.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnsupprimer.Name = "btnsupprimer"
        Me.btnsupprimer.Size = New System.Drawing.Size(229, 52)
        Me.btnsupprimer.TabIndex = 13
        Me.btnsupprimer.Text = "SUPPRIMER"
        Me.btnsupprimer.UseVisualStyleBackColor = True
        '
        'btnmodifier
        '
        Me.btnmodifier.BackgroundImage = Global.EDG_Mamou.My.Resources.Resources.kate
        Me.btnmodifier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnmodifier.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmodifier.Location = New System.Drawing.Point(499, 70)
        Me.btnmodifier.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnmodifier.Name = "btnmodifier"
        Me.btnmodifier.Size = New System.Drawing.Size(71, 49)
        Me.btnmodifier.TabIndex = 12
        Me.btnmodifier.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 72)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 22)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Libellé :"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(672, 60)
        Me.Panel1.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Green
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Yellow
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(672, 60)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Gestion des Services"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgv_service
        '
        Me.dgv_service.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_service.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_service.Location = New System.Drawing.Point(18, 155)
        Me.dgv_service.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dgv_service.Name = "dgv_service"
        Me.dgv_service.ReadOnly = True
        Me.dgv_service.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_service.Size = New System.Drawing.Size(642, 361)
        Me.dgv_service.TabIndex = 17
        '
        'txtlibelle_service
        '
        Me.txtlibelle_service.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlibelle_service.Location = New System.Drawing.Point(87, 70)
        Me.txtlibelle_service.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtlibelle_service.Name = "txtlibelle_service"
        Me.txtlibelle_service.Size = New System.Drawing.Size(312, 26)
        Me.txtlibelle_service.TabIndex = 18
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Red
        Me.Label14.Location = New System.Drawing.Point(409, 124)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(56, 16)
        Me.Label14.TabIndex = 22
        Me.Label14.Text = "ajouter"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(503, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 16)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "modifier"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(586, 122)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 16)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Supprimer"
        '
        'btn_supprim
        '
        Me.btn_supprim.BackgroundImage = Global.EDG_Mamou.My.Resources.Resources.button_cancel
        Me.btn_supprim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_supprim.Location = New System.Drawing.Point(585, 70)
        Me.btn_supprim.Name = "btn_supprim"
        Me.btn_supprim.Size = New System.Drawing.Size(72, 49)
        Me.btn_supprim.TabIndex = 20
        Me.btn_supprim.UseVisualStyleBackColor = True
        '
        'Service
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(672, 577)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.btn_supprim)
        Me.Controls.Add(Me.txtlibelle_service)
        Me.Controls.Add(Me.dgv_service)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnvalider)
        Me.Controls.Add(Me.btnsupprimer)
        Me.Controls.Add(Me.btnmodifier)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.Name = "Service"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SERVICE"
        Me.Panel1.ResumeLayout(False)
        CType(Me.dgv_service, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnvalider As System.Windows.Forms.Button
    Friend WithEvents btnsupprimer As System.Windows.Forms.Button
    Friend WithEvents btnmodifier As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dgv_service As System.Windows.Forms.DataGridView
    Friend WithEvents txtlibelle_service As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btn_supprim As System.Windows.Forms.Button
End Class
