<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Impression_fiche_personnel
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
        Me.PERSONNEL1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PERSONNEL1TableAdapter = New EDG_Mamou.EDG_Mamou_G8_DataSet_originalTableAdapters.PERSONNEL1TableAdapter()
        CType(Me.EDG_Mamou_G8_DataSet_original, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PERSONNEL1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.PERSONNEL1BindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "EDG_Mamou.Report_impression_fiche_personnel.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(850, 430)
        Me.ReportViewer1.TabIndex = 0
        '
        'EDG_Mamou_G8_DataSet_original
        '
        Me.EDG_Mamou_G8_DataSet_original.DataSetName = "EDG_Mamou_G8_DataSet_original"
        Me.EDG_Mamou_G8_DataSet_original.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PERSONNEL1BindingSource
        '
        Me.PERSONNEL1BindingSource.DataMember = "PERSONNEL1"
        Me.PERSONNEL1BindingSource.DataSource = Me.EDG_Mamou_G8_DataSet_original
        '
        'PERSONNEL1TableAdapter
        '
        Me.PERSONNEL1TableAdapter.ClearBeforeFill = True
        '
        'Form_Impression_fiche_personnel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(850, 430)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "Form_Impression_fiche_personnel"
        Me.Text = "Form_Impression_fiche_personnel"
        CType(Me.EDG_Mamou_G8_DataSet_original, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PERSONNEL1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents PERSONNEL1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EDG_Mamou_G8_DataSet_original As EDG_Mamou.EDG_Mamou_G8_DataSet_original
    Friend WithEvents PERSONNEL1TableAdapter As EDG_Mamou.EDG_Mamou_G8_DataSet_originalTableAdapters.PERSONNEL1TableAdapter
End Class
