﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_impression_evenement
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
        Me.EDG_Mamou_G8DataSet = New EDG_Mamou.EDG_Mamou_G8DataSet()
        Me.EVENEMENT1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EVENEMENT1TableAdapter = New EDG_Mamou.EDG_Mamou_G8DataSetTableAdapters.EVENEMENT1TableAdapter()
        CType(Me.EDG_Mamou_G8DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EVENEMENT1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.EVENEMENT1BindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "EDG_Mamou.Report_evenement.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 1)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(896, 520)
        Me.ReportViewer1.TabIndex = 0
        '
        'EDG_Mamou_G8DataSet
        '
        Me.EDG_Mamou_G8DataSet.DataSetName = "EDG_Mamou_G8DataSet"
        Me.EDG_Mamou_G8DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EVENEMENT1BindingSource
        '
        Me.EVENEMENT1BindingSource.DataMember = "EVENEMENT1"
        Me.EVENEMENT1BindingSource.DataSource = Me.EDG_Mamou_G8DataSet
        '
        'EVENEMENT1TableAdapter
        '
        Me.EVENEMENT1TableAdapter.ClearBeforeFill = True
        '
        'Form_impression_evenement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(919, 527)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "Form_impression_evenement"
        Me.Text = "Form_impression_evenement"
        CType(Me.EDG_Mamou_G8DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EVENEMENT1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents EVENEMENT1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EDG_Mamou_G8DataSet As EDG_Mamou.EDG_Mamou_G8DataSet
    Friend WithEvents EVENEMENT1TableAdapter As EDG_Mamou.EDG_Mamou_G8DataSetTableAdapters.EVENEMENT1TableAdapter
End Class
