<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Impression_recu_versement
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.EDG_Mamou_G8_DataSet_original = New EDG_Mamou.EDG_Mamou_G8_DataSet_original()
        Me.OPERATION1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OPERATION1TableAdapter = New EDG_Mamou.EDG_Mamou_G8_DataSet_originalTableAdapters.OPERATION1TableAdapter()
        CType(Me.EDG_Mamou_G8_DataSet_original, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OPERATION1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.OPERATION1BindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "EDG_Mamou.Report_reçu_Versement.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(3, 5)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(683, 371)
        Me.ReportViewer1.TabIndex = 0
        '
        'EDG_Mamou_G8_DataSet_original
        '
        Me.EDG_Mamou_G8_DataSet_original.DataSetName = "EDG_Mamou_G8_DataSet_original"
        Me.EDG_Mamou_G8_DataSet_original.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OPERATION1BindingSource
        '
        Me.OPERATION1BindingSource.DataMember = "OPERATION1"
        Me.OPERATION1BindingSource.DataSource = Me.EDG_Mamou_G8_DataSet_original
        '
        'OPERATION1TableAdapter
        '
        Me.OPERATION1TableAdapter.ClearBeforeFill = True
        '
        'Form_Impression_recu_versement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(695, 383)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "Form_Impression_recu_versement"
        Me.Text = "Form_Impression_recu_versement"
        CType(Me.EDG_Mamou_G8_DataSet_original, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OPERATION1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents OPERATION1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EDG_Mamou_G8_DataSet_original As EDG_Mamou.EDG_Mamou_G8_DataSet_original
    Friend WithEvents OPERATION1TableAdapter As EDG_Mamou.EDG_Mamou_G8_DataSet_originalTableAdapters.OPERATION1TableAdapter
End Class
