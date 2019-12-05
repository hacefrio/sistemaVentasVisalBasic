Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlException
Imports System.Data.DataTableReader
Imports System.Data.Odbc


Public Class VerVentas

    Private Sub actualizarTabla()
        Try
            Dim dt As New DataTable
            Dim conexion As String
            conexion = "Server=localhost\SQLEXPRESS02;Database=master;Initial Catalog=SistemaVentas;Trusted_Connection=True;"
            Dim cn As New SqlConnection
            cn.ConnectionString = conexion
            Using adaptador As New SqlDataAdapter("SELECT N_venta, total, iva, total_final from ventas;", conexion)
                adaptador.Fill(dt)
            End Using
            DataGrid.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub VerVentas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        actualizarTabla()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        verVentaDetalle.TextBox1.Text = nBoleta.Text
        verVentaDetalle.Show()

    End Sub
End Class