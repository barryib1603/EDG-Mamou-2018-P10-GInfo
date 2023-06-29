Public Class Impression_liste_client

    Private Sub Impression_liste_client_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'EDG_Mamou_G8_DataSet_original.CLIENT'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.CLIENTTableAdapter.Fill(Me.EDG_Mamou_G8_DataSet_original.CLIENT)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs)

    End Sub
End Class