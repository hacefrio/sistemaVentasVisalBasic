Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlException
Imports System.Data.DataTableReader
Imports System.Data.Odbc

Public Class RealizarVenta
    Dim conexion As String = "Server=localhost\SQLEXPRESS02;Database=master;Initial Catalog=SistemaVentas;Trusted_Connection=True;"

    Private Sub actualizarTabla()
        Try
            Dim dt As New DataTable
            Dim cn As New SqlConnection
            cn.ConnectionString = conexion
            Using adaptador As New SqlDataAdapter("SELECT dbo.detalleVenta.ID_producto, dbo.producto.Nombre_producto, dbo.detalleVenta.cantidad, dbo.detalleVenta.total FROM dbo.detalleVenta INNER JOIN dbo.producto ON dbo.detalleVenta.ID_producto = dbo.producto.ID_producto where n_venta='" + nBoleta.Text() + "' ;", conexion)
                adaptador.Fill(dt)
            End Using
            DataGrid.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub RealizarVenta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim precio As String
        precio = 0
        Try
            Dim cn As New SqlConnection
            cn.ConnectionString = conexion
            Dim adaptador1 As New SqlCommand("select precio from  producto where id_producto = '" + id_producto.Text() + "';", cn)
            cn.Open()
            precio = adaptador1.ExecuteScalar()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Try
            Dim conexion As String
            conexion = "Server=localhost\SQLEXPRESS02;Database=master;Initial Catalog=SistemaVentas;Trusted_Connection=True;"
            Dim cn As New SqlConnection
            cn.ConnectionString = conexion
            Dim adaptador2 As New SqlCommand("insert into dbo.detalleVenta values ('" + id_producto.Text() + "','" + cantidad.Text() + "','" + CStr(precio * CInt(cantidad.Text())) + "','" + nBoleta.Text() + "')", cn)
            cn.Open()
            adaptador2.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Try
            Dim conexion As String
            conexion = "Server=localhost\SQLEXPRESS02;Database=master;Initial Catalog=SistemaVentas;Trusted_Connection=True;"
            Dim cn As New SqlConnection
            cn.ConnectionString = conexion
            Dim adaptador As New SqlCommand("UPDATE inventario  SET cantidad =cantidad-'" + cantidad.Text + "'where ID_producto ='" + id_producto.Text + "';", cn)
            cn.Open()
            adaptador.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        actualizarTabla()
        MsgBox("Proceso terminado")

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim total As String
        total = 0
        Try
            Dim cn As New SqlConnection
            cn.ConnectionString = conexion
            Dim adaptador1 As New SqlCommand("select sum(total) from  detalleVenta where id_producto = '" + id_producto.Text() + "';", cn)
            cn.Open()
            total = adaptador1.ExecuteScalar()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Try
            Dim cn As New SqlConnection
            cn.ConnectionString = conexion
            Dim adaptador2 As New SqlCommand("insert into dbo.ventas values ('" + nBoleta.Text() + "','" + total + "','" + CStr(total * 0.19) + "','" + CStr(total * 1.19) + "')", cn)
            cn.Open()
            adaptador2.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        MsgBox("Venta realizada con exito")
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        actualizarTabla()
    End Sub
End Class