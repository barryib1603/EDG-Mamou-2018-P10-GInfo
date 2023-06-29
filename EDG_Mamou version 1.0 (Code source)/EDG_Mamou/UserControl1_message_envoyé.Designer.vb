<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl1_message_envoyé
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
        Me.dgvmessageEnvoye = New System.Windows.Forms.DataGridView()
        CType(Me.dgvmessageEnvoye, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvmessageEnvoye
        '
        Me.dgvmessageEnvoye.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvmessageEnvoye.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvmessageEnvoye.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvmessageEnvoye.Location = New System.Drawing.Point(0, 0)
        Me.dgvmessageEnvoye.Name = "dgvmessageEnvoye"
        Me.dgvmessageEnvoye.ReadOnly = True
        Me.dgvmessageEnvoye.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvmessageEnvoye.Size = New System.Drawing.Size(968, 445)
        Me.dgvmessageEnvoye.TabIndex = 0
        '
        'UserControl1_message_envoyé
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.Controls.Add(Me.dgvmessageEnvoye)
        Me.Name = "UserControl1_message_envoyé"
        Me.Size = New System.Drawing.Size(968, 445)
        CType(Me.dgvmessageEnvoye, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvmessageEnvoye As System.Windows.Forms.DataGridView

End Class
