Public Class Form1_imprime_facture_originale

   
    Private Sub Form1_imprime_facture_originale_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'EDG_Mamou_G8_DataSet_original.DataTable2'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.DataTable2TableAdapter.Fill(Me.EDG_Mamou_G8_DataSet_original.DataTable2, Param1:=Form2_menu_principal.UserControl1_facturation1.dgv_facturation.CurrentRow.Cells(0).Value)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class