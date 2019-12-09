Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlException
Imports System.Data.DataTableReader
Imports System.Data.Odbc


Public Class VerVentas
    Dim conexion As String = "Server=localhost\SQLEXPRESS02;Database=master;Initial Catalog=SistemaVentas;Trusted_Connection=True;"
    Private Sub actualizarTabla()
        Try
            Dim dt As New DataTable
            Dim cn As New SqlConnection
            cn.ConnectionString = conexion
            Using adaptador As New SqlDataAdapter("SELECT N_venta, total, iva, total_final, fecha from ventas;", conexion)
                adaptador.Fill(dt)
            End Using
            DataGrid.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub VerVentas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        actualizarTabla()
        Dim total As Integer
        total= 0
        Try
            Dim cn As New SqlConnection
            cn.ConnectionString = conexion
            Dim adaptador As New SqlCommand("select sum(total_final) from  dbo.ventas where fecha LIKE'%" + MesAno.Text + "%' ;", cn)
            cn.Open()
            total = adaptador.ExecuteScalar()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        ventasMes.Text = total

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        verVentaDetalle.auxiliar.Text = nBoleta.Text
        verVentaDetalle.Show()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            Dim cn As New SqlConnection
            cn.ConnectionString = conexion
            Dim adaptador As New SqlCommand("select sum(total_final) from  dbo.ventas where fecha LIKE'%" + MesAno.Text + "%' ;", cn)
            cn.Open()
            ventasMes.Text = adaptador.ExecuteScalar()
        Catch ex As Exception
            MsgBox("Ingree una fecha valida")
        End Try
    End Sub
End Class