Public Class Form_Impression_Intervention_Individuelle

    
    Private Sub Form_Impression_Intervention_Individuelle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'EDG_Mamou_G8_DataSet_original.INTERVENTION1'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.INTERVENTION1TableAdapter.Fill(Me.EDG_Mamou_G8_DataSet_original.INTERVENTION1, Param1:=Form2_menu_principal.UserControl1_intervention1.dgvInterv.CurrentRow.Cells(1).Value)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class