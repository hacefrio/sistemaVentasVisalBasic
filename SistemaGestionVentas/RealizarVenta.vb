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
        fecha.Text = DateTime.Now.ToString("dd/MM/yyyy")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Dim stock As Integer = 0
        Try
            Dim cn As New SqlConnection
            cn.ConnectionString = conexion
            Dim adaptador As New SqlCommand("select cantidad from  dbo.inventario where id_producto = '" + id_producto.Text() + "';", cn)
            cn.Open()
            stock = adaptador.ExecuteScalar()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        stock = stock - cantidad.Text
        If stock < 0 Then
            MsgBox("No hay suficiente stock")
        Else
            If nBoleta.Text().Equals("") = True Then
                MsgBox("Porfavor, antes de agregar un producto, agrege un numero de boleta")
            Else
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
                    Dim cn As New SqlConnection
                    cn.ConnectionString = conexion
                    Dim adaptador2 As New SqlCommand("insert into dbo.detalleVenta values ('" + id_producto.Text() + "','" + cantidad.Text() + "','" + CStr(precio * CInt(cantidad.Text())) + "','" + nBoleta.Text() + "')", cn)
                    cn.Open()
                    adaptador2.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                Try
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
            End If
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim total As String
        total = 0
        If nBoleta.Text().Equals("") = True Then
            MsgBox("Porfavor, antes de realizar una venta, ingrese  el numero de boleta")
        Else
            Try
                Dim cn As New SqlConnection
                cn.ConnectionString = conexion
                Dim adaptador As New SqlCommand("select sum(total) from  dbo.detalleVenta where N_venta = '" + nBoleta.Text() + "';", cn)
                cn.Open()
                total = adaptador.ExecuteScalar()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            Try
                Dim cn As New SqlConnection
                cn.ConnectionString = conexion
                Dim adaptador As New SqlCommand("insert into dbo.ventas values ('" + nBoleta.Text() + "','" + total + "','" + CStr(total * 0.19) + "','" + CStr(total * 1.19) + "','" + fecha.Text + "')", cn)
                cn.Open()
                adaptador.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            MsgBox("Venta realizada con exito")
        End If

    End Sub


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If nBoleta.Text().Equals("") = True Then
            MsgBox("Porfavor, antes de ver carrito, agrege un numero de boleta")
        Else
            actualizarTabla()
        End If

    End Sub

End Class