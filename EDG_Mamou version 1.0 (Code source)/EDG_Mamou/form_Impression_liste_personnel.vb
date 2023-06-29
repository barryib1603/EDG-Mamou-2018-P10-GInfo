Public Class form_Impression_liste_personnel



    Private Sub form_Impression_liste_personnel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'EDG_Mamou_G8_DataSet_original.PERSONNEL'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.PERSONNELTableAdapter.Fill(Me.EDG_Mamou_G8_DataSet_original.PERSONNEL)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class