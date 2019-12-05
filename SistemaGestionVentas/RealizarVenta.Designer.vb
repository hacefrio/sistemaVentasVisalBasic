<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RealizarVenta
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.DataGrid = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.id_producto = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cantidad = New System.Windows.Forms.TextBox()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.nBoleta = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.fecha = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.DataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGrid
        '
        Me.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGrid.Location = New System.Drawing.Point(18, 18)
        Me.DataGrid.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DataGrid.Name = "DataGrid"
        Me.DataGrid.Size = New System.Drawing.Size(717, 494)
        Me.DataGrid.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(793, 202)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(156, 35)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Realizar Venta"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 562)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "id producto"
        '
        'id_producto
        '
        Me.id_producto.Location = New System.Drawing.Point(126, 562)
        Me.id_producto.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.id_producto.Name = "id_producto"
        Me.id_producto.Size = New System.Drawing.Size(148, 26)
        Me.id_producto.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(42, 609)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Cantidad"
        '
        'cantidad
        '
        Me.cantidad.Location = New System.Drawing.Point(126, 609)
        Me.cantidad.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cantidad.Name = "cantidad"
        Me.cantidad.Size = New System.Drawing.Size(148, 26)
        Me.cantidad.TabIndex = 5
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(306, 589)
        Me.btnAgregar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(112, 35)
        Me.btnAgregar.TabIndex = 6
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(744, 42)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Numero boleta"
        '
        'nBoleta
        '
        Me.nBoleta.Location = New System.Drawing.Point(867, 42)
        Me.nBoleta.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.nBoleta.Name = "nBoleta"
        Me.nBoleta.Size = New System.Drawing.Size(105, 26)
        Me.nBoleta.TabIndex = 8
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(793, 157)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(156, 35)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "Ver carrito"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'fecha
        '
        Me.fecha.Location = New System.Drawing.Point(867, 95)
        Me.fecha.Name = "fecha"
        Me.fecha.Size = New System.Drawing.Size(105, 26)
        Me.fecha.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(804, 98)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 20)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "fecha:"
        '
        'RealizarVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1036, 643)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.fecha)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.nBoleta)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.cantidad)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.id_producto)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGrid)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "RealizarVenta"
        Me.Text = "Form2"
        CType(Me.DataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGrid As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents id_producto As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cantidad As System.Windows.Forms.TextBox
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents nBoleta As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents fecha As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
