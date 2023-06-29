Public Class Form_impression_liste_paiement

   
    Private Sub Form_impression_liste_paiement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'EDG_Mamou_G8_DataSet_original.PAIEMENT'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.PAIEMENTTableAdapter.Fill(Me.EDG_Mamou_G8_DataSet_original.PAIEMENT)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class