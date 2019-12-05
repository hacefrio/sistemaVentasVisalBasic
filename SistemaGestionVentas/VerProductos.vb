Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlException
Imports System.Data.DataTableReader
Imports System.Data.Odbc

Public Class VerProductos
    Dim conexion As String = "Server=localhost\SQLEXPRESS02;Database=master;Initial Catalog=SistemaVentas;Trusted_Connection=True;"

    Private Sub VerProductos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        actualizarTabla()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim dt As New DataTable
            Dim cn As New SqlConnection
            cn.ConnectionString = conexion
            Using adaptador As New SqlDataAdapter("SELECT ID_producto, Nombre_producto,precio from dbo.producto where Nombre_producto ='" + buscarProducto.Text + "'", conexion)
                adaptador.Fill(dt)
            End Using
            DataGrid.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Try
            Dim cn As New SqlConnection
            cn.ConnectionString = conexion
            Dim adaptador As New SqlCommand("insert into dbo.producto  values('" + IDproducto.Text + "','" + nombre.Text + "','" + precio.Text + "')", cn)
            cn.Open()
            adaptador.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Try
            Dim cn As New SqlConnection
            cn.ConnectionString = conexion
            Dim adaptador As New SqlCommand("insert into dbo.inventario  values('" + IDproducto.Text + "',0)", cn)
            cn.Open()
            adaptador.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        actualizarTabla()
        MsgBox("Proceso terminado")
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            Dim cn As New SqlConnection
            cn.ConnectionString = conexion
            Dim adaptador As New SqlCommand("delete from dbo.producto  where ID_producto='" + IDEliminar.Text + "'", cn)
            cn.Open()
            adaptador.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Try
            Dim cn As New SqlConnection
            cn.ConnectionString = conexion
            Dim adaptador As New SqlCommand("delete from dbo.inventario  where ID_producto='" + IDEliminar.Text + "'", cn)
            cn.Open()
            adaptador.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        actualizarTabla()
        MsgBox("Proceso terminado")
    End Sub

    Private Sub actualizarTabla()
        Try
            Dim dt As New DataTable
            Dim cn As New SqlConnection
            cn.ConnectionString = conexion
            Using adaptador As New SqlDataAdapter("SELECT ID_producto, Nombre_producto,precio from dbo.producto ", conexion)
                adaptador.Fill(dt)
            End Using
            DataGrid.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        actualizarTabla()
    End Sub
End Class