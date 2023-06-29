Public Class Impression_liste_batiment

    Private Sub Impression_liste_batiment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'EDG_Mamou_G8_DataSet_original.BATIMENT'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.BATIMENTTableAdapter.Fill(Me.EDG_Mamou_G8_DataSet_original.BATIMENT)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class