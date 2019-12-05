Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlException
Imports System.Data.DataTableReader
Imports System.Data.Odbc

Public Class VerInventario

    Private Sub VerInventario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        actualizarTabla()
    End Sub

    Private Sub actualizarTabla()
        Try
            Dim dt As New DataTable
            Dim conexion As String
            conexion = "Server=localhost\SQLEXPRESS02;Database=master;Initial Catalog=SistemaVentas;Trusted_Connection=True;"
            Dim cn As New SqlConnection
            cn.ConnectionString = conexion
            Using adaptador As New SqlDataAdapter("SELECT dbo.producto.Nombre_producto, dbo.inventario.ID_producto, dbo.inventario.cantidad FROM dbo.inventario INNER JOIN dbo.producto ON dbo.inventario.ID_producto = dbo.producto.ID_producto;", conexion)
                adaptador.Fill(dt)
            End Using
            DataGrid.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim dt As New DataTable
            Dim conexion As String
            conexion = "Server=localhost\SQLEXPRESS02;Database=master;Initial Catalog=SistemaVentas;Trusted_Connection=True;"
            Dim cn As New SqlConnection
            cn.ConnectionString = conexion
            Using adaptador As New SqlDataAdapter("SELECT dbo.producto.Nombre_producto, dbo.inventario.ID_producto, dbo.inventario.cantidad FROM dbo.inventario INNER JOIN dbo.producto ON dbo.inventario.ID_producto = dbo.producto.ID_producto where   dbo.producto.Nombre_producto='" + campoBuscar.Text + "';", conexion)
                adaptador.Fill(dt)
            End Using
            DataGrid.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        MsgBox("Proceso terminado")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            Dim conexion As String
            conexion = "Server=localhost\SQLEXPRESS02;Database=master;Initial Catalog=SistemaVentas;Trusted_Connection=True;"
            Dim cn As New SqlConnection
            cn.ConnectionString = conexion
            Dim adaptador As New SqlCommand("UPDATE inventario  SET cantidad ='" + cantidad.Text + "'where ID_producto ='" + nombre.Text + "';", cn)
            cn.Open()
            adaptador.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        actualizarTabla()
        MsgBox("Proceso terminado")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        actualizarTabla()
    End Sub
End Class