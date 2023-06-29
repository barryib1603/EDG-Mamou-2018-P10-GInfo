Public Class Form_Impression_Rapport

    Private Sub Form_Impression_Rapport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'EDG_Mamou_G8_DataSet_original.RAPPORT_ADMIN1'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.RAPPORT_ADMIN1TableAdapter.Fill(Me.EDG_Mamou_G8_DataSet_original.RAPPORT_ADMIN1, Form2_menu_principal.UserControl1_Rapport1.dgvrapport.CurrentRow.Cells(0).Value)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class