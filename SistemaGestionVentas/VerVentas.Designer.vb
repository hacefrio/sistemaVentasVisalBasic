<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.Label1.Location = New System.Drawing.Point(45, 336)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Numero boleta"
        '
        'nBoleta
        '
        Me.nBoleta.Location = New System.Drawing.Point(127, 333)
        Me.nBoleta.Name = "nBoleta"
        Me.nBoleta.Size = New System.Drawing.Size(100, 20)
        Me.nBoleta.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(247, 333)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(90, 20)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "ver detalles"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'VerVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(530, 372)
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
End Class
