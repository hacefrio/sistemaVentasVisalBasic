﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VerVentas
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.nBoleta = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Vmes = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MesAno = New System.Windows.Forms.TextBox()
        Me.ventasMes = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.DataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGrid
        '
        Me.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGrid.Location = New System.Drawing.Point(12, 12)
        Me.DataGrid.Name = "DataGrid"
        Me.DataGrid.Size = New System.Drawing.Size(506, 286)
        Me.DataGrid.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(128, 306)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Numero boleta"
        '
        'nBoleta
        '
        Me.nBoleta.Location = New System.Drawing.Point(209, 304)
        Me.nBoleta.Name = "nBoleta"
        Me.nBoleta.Size = New System.Drawing.Size(100, 20)
        Me.nBoleta.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(313, 303)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(90, 20)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "ver detalles"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Vmes
        '
        Me.Vmes.AutoSize = True
        Me.Vmes.Location = New System.Drawing.Point(140, 372)
        Me.Vmes.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Vmes.Name = "Vmes"
        Me.Vmes.Size = New System.Drawing.Size(82, 13)
        Me.Vmes.TabIndex = 4
        Me.Vmes.Text = "Ventas del mes:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(128, 350)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "ingrese mes y año:"
        '
        'MesAno
        '
        Me.MesAno.Location = New System.Drawing.Point(226, 348)
        Me.MesAno.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MesAno.Name = "MesAno"
        Me.MesAno.Size = New System.Drawing.Size(68, 20)
        Me.MesAno.TabIndex = 6
        Me.MesAno.Text = "12-2019"
        '
        'ventasMes
        '
        Me.ventasMes.Location = New System.Drawing.Point(226, 372)
        Me.ventasMes.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ventasMes.Name = "ventasMes"
        Me.ventasMes.Size = New System.Drawing.Size(68, 20)
        Me.ventasMes.TabIndex = 7
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(315, 345)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(51, 20)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "calcular"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'VerVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(530, 396)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.ventasMes)
        Me.Controls.Add(Me.MesAno)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Vmes)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.nBoleta)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGrid)
        Me.Name = "VerVentas"
        Me.Text = "VerVentas"
        CType(Me.DataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGrid As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents nBoleta As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Vmes As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents MesAno As System.Windows.Forms.TextBox
    Friend WithEvents ventasMes As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
