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
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.nBoleta = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.DataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGrid
        '
        Me.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGrid.Location = New System.Drawing.Point(12, 12)
        Me.DataGrid.Name = "DataGrid"
        Me.DataGrid.Size = New System.Drawing.Size(478, 321)
        Me.DataGrid.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(530, 96)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Realizar Venta"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 365)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "id producto"
        '
        'id_producto
        '
        Me.id_producto.Location = New System.Drawing.Point(84, 365)
        Me.id_producto.Name = "id_producto"
        Me.id_producto.Size = New System.Drawing.Size(100, 20)
        Me.id_producto.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 396)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Cantidad"
        '
        'cantidad
        '
        Me.cantidad.Location = New System.Drawing.Point(84, 396)
        Me.cantidad.Name = "cantidad"
        Me.cantidad.Size = New System.Drawing.Size(100, 20)
        Me.cantidad.TabIndex = 5
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(204, 383)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Agregar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(496, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Numero boleta"
        '
        'nBoleta
        '
        Me.nBoleta.Location = New System.Drawing.Point(578, 27)
        Me.nBoleta.Name = "nBoleta"
        Me.nBoleta.Size = New System.Drawing.Size(56, 20)
        Me.nBoleta.TabIndex = 8
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(530, 64)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(104, 23)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "Ver carrito"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'RealizarVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(691, 418)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.nBoleta)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.cantidad)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.id_producto)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGrid)
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
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents nBoleta As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
