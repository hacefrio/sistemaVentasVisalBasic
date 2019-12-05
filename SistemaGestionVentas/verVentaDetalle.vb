Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlException
Imports System.Data.DataTableReader
Imports System.Data.Odbc
Public Class verVentaDetalle


    Private Sub actualizarTabla()
        Try
            Dim dt As New DataTable
            Dim conexion As String
            conexion = "Server=localhost\SQLEXPRESS02;Database=master;Initial Catalog=SistemaVentas;Trusted_Connection=True;"
            Dim cn As New SqlConnection
            cn.ConnectionString = conexion
            Using adaptador As New SqlDataAdapter("SELECT dbo.detalleVenta.ID_producto, dbo.producto.Nombre_producto, dbo.detalleVenta.cantidad, dbo.detalleVenta.total FROM dbo.detalleVenta INNER JOIN dbo.producto ON dbo.detalleVenta.ID_producto = dbo.producto.ID_producto where n_venta='" + TextBox1.Text() + "' ;", conexion)
                adaptador.Fill(dt)
            End Using
            DataGrid.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub verVentaDetalle_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        actualizarTabla()
    End Sub
End Class