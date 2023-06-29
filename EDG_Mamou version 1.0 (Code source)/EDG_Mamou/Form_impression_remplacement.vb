Public Class Form_impression_remplacement

    Private Sub Form_impression_remplacement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'EDG_Mamou_G8_DataSet_original.REMPLACEMENT'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.REMPLACEMENTTableAdapter.Fill(Me.EDG_Mamou_G8_DataSet_original.REMPLACEMENT)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class