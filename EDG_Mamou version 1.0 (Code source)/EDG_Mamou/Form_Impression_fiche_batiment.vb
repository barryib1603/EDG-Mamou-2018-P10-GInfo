Public Class Form_Impression_fiche_batiment

    Private Sub Form_Impression_fiche_batiment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'EDG_Mamou_G8_DataSet_original.BATIMENT1'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.BATIMENT1TableAdapter.Fill(Me.EDG_Mamou_G8_DataSet_original.BATIMENT1, Form2_menu_principal.UserControl1_batiment1.DGV_batiment.CurrentRow.Cells(0).Value)
       
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class