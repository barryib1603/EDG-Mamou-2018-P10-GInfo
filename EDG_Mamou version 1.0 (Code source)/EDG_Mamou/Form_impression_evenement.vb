Public Class Form_impression_evenement

    Private Sub Form_impression_evenement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'EDG_Mamou_G8DataSet.EVENEMENT1'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.EVENEMENT1TableAdapter.Fill(Me.EDG_Mamou_G8DataSet.EVENEMENT1, Param1:=Form2_menu_principal.UserControl1_evenement1.dgvevenement.CurrentRow.Cells(0).Value.ToString)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class