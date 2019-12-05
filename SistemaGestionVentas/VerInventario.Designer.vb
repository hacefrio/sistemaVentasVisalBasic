<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VerInventario
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
        Me.campoBuscar = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cantidad = New System.Windows.Forms.TextBox()
        Me.nombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.DataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGrid
        '
        Me.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGrid.Location = New System.Drawing.Point(12, 48)
        Me.DataGrid.Name = "DataGrid"
        Me.DataGrid.Size = New System.Drawing.Size(339, 360)
        Me.DataGrid.TabIndex = 0
        '
        'campoBuscar
        '
        Me.campoBuscar.Location = New System.Drawing.Point(139, 12)
        Me.campoBuscar.Name = "campoBuscar"
        Me.campoBuscar.Size = New System.Drawing.Size(100, 20)
        Me.campoBuscar.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(245, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(76, 20)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Buscar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cantidad
        '
        Me.cantidad.Location = New System.Drawing.Point(427, 105)
        Me.cantidad.Name = "cantidad"
        Me.cantidad.Size = New System.Drawing.Size(100, 20)
        Me.cantidad.TabIndex = 9
        '
        'nombre
        '
        Me.nombre.Location = New System.Drawing.Point(427, 79)
        Me.nombre.Name = "nombre"
        Me.nombre.Size = New System.Drawing.Size(100, 20)
        Me.nombre.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(364, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Cantidad:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(364, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "id producto"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(439, 141)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Agregar"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(44, 11)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(74, 20)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "Actualizar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'VerInventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(568, 490)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.cantidad)
        Me.Controls.Add(Me.nombre)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.campoBuscar)
        Me.Controls.Add(Me.DataGrid)
        Me.Name = "VerInventario"
        Me.Text = "VerInventario"
        CType(Me.DataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGrid As System.Windows.Forms.DataGridView
    Friend WithEvents campoBuscar As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cantidad As System.Windows.Forms.TextBox
    Friend WithEvents nombre As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As Button
End Class
