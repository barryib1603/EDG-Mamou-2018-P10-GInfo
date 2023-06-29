Public Class Form_Impression_recu_paiement

  
   
   
    
    Private Sub Form_Impression_recu_paiement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'EDG_Mamou_G8_DataSet_original.PAIEMENT1'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.PAIEMENT1TableAdapter.Fill(Me.EDG_Mamou_G8_DataSet_original.PAIEMENT1, Param1:=Form2_menu_principal.UserControl1_paiements1.dgv_paiement.CurrentRow.Cells(0).Value)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class