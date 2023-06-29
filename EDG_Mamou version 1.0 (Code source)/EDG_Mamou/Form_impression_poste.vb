Public Class Form_impression_poste

   
    Private Sub Form_impression_poste_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'EDG_Mamou_G8_DataSet_original.POSTE'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.POSTETableAdapter.Fill(Me.EDG_Mamou_G8_DataSet_original.POSTE)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class