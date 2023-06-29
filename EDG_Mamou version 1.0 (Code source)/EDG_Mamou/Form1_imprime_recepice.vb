Public Class Form1_imprime_recepice

    Private Sub Form1_imprime_recepice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'EDG_Mamou_G8_DataSet_server.DataTable1'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.DataTable1TableAdapter.Fill(Me.EDG_Mamou_G8_DataSet_server.DataTable1, param_bat:=Form2_menu_principal.UserControl1_batiment1.lblcode_bat.Text)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class