Public Class Form_Impression_Liste_Interventionl

    Private Sub Form_Impression_Intervention_Individuel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'EDG_Mamou_G8_DataSet_original.INTERVENTION'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.INTERVENTIONTableAdapter.Fill(Me.EDG_Mamou_G8_DataSet_original.INTERVENTION)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class