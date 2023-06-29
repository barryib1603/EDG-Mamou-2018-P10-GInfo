Public Class Form_Impression_recu_versement

    Private Sub Form_Impression_recu_versement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'EDG_Mamou_G8_DataSet_original.OPERATION1'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.OPERATION1TableAdapter.Fill(Me.EDG_Mamou_G8_DataSet_original.OPERATION1, Param1:=Form_Gestion_comptes.dgv_operation.CurrentRow.Cells(0).Value)


        Me.ReportViewer1.RefreshReport()
    End Sub
End Class