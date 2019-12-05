<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VerProductos
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
        Me.buscarProducto = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.nombre = New System.Windows.Forms.TextBox()
        Me.IDproducto = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.precio = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.IDEliminar = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        CType(Me.DataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGrid
        '
        Me.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGrid.Location = New System.Drawing.Point(12, 32)
        Me.DataGrid.Name = "DataGrid"
        Me.DataGrid.Size = New System.Drawing.Size(373, 435)
        Me.DataGrid.TabIndex = 0
        '
        'buscarProducto
        '
        Me.buscarProducto.Location = New System.Drawing.Point(136, 4)
        Me.buscarProducto.Name = "buscarProducto"
        Me.buscarProducto.Size = New System.Drawing.Size(100, 20)
        Me.buscarProducto.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(242, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Buscar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'nombre
        '
        Me.nombre.Location = New System.Drawing.Point(464, 66)
        Me.nombre.Name = "nombre"
        Me.nombre.Size = New System.Drawing.Size(100, 20)
        Me.nombre.TabIndex = 14
        '
        'IDproducto
        '
        Me.IDproducto.Location = New System.Drawing.Point(464, 40)
        Me.IDproducto.Name = "IDproducto"
        Me.IDproducto.Size = New System.Drawing.Size(100, 20)
        Me.IDproducto.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(403, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Nombre:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(391, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "ID Producto:"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(479, 118)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Agregar"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.UseVisualStyleBackColor = True
        '
        'precio
        '
        Me.precio.Location = New System.Drawing.Point(464, 92)
        Me.precio.Name = "precio"
        Me.precio.Size = New System.Drawing.Size(100, 20)
        Me.precio.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(403, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Precio:"
        '
        'IDEliminar
        '
        Me.IDEliminar.Location = New System.Drawing.Point(464, 184)
        Me.IDEliminar.Name = "IDEliminar"
        Me.IDEliminar.Size = New System.Drawing.Size(100, 20)
        Me.IDEliminar.TabIndex = 18
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(391, 187)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "ID producto:"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(479, 227)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(54, 26)
        Me.Button3.TabIndex = 19
        Me.Button3.Text = "Eliminar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(41, 1)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 20
        Me.Button4.Text = "Actualizar"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'VerProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(566, 563)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.IDEliminar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.precio)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.nombre)
        Me.Controls.Add(Me.IDproducto)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.buscarProducto)
        Me.Controls.Add(Me.DataGrid)
        Me.Name = "VerProductos"
        Me.Text = "VerProductos"
        CType(Me.DataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGrid As System.Windows.Forms.DataGridView
    Friend WithEvents buscarProducto As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents nombre As System.Windows.Forms.TextBox
    Friend WithEvents IDproducto As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents precio As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents IDEliminar As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As Button
End Class
