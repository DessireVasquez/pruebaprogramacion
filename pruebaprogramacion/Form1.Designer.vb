<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmColores
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.TxtColores = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.btnRojo = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TxtColores
        '
        Me.TxtColores.Location = New System.Drawing.Point(263, 73)
        Me.TxtColores.Multiline = True
        Me.TxtColores.Name = "TxtColores"
        Me.TxtColores.Size = New System.Drawing.Size(549, 320)
        Me.TxtColores.TabIndex = 0
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'btnRojo
        '
        Me.btnRojo.Location = New System.Drawing.Point(137, 73)
        Me.btnRojo.Name = "btnRojo"
        Me.btnRojo.Size = New System.Drawing.Size(103, 48)
        Me.btnRojo.TabIndex = 2
        Me.btnRojo.Text = "Rojo"
        Me.btnRojo.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(134, 144)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(105, 45)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Azul"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(134, 204)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(101, 52)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Amarillo"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(134, 273)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(98, 48)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "Negro"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(134, 349)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(97, 44)
        Me.Button5.TabIndex = 6
        Me.Button5.Text = "Rosado"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'FrmColores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.IndianRed
        Me.ClientSize = New System.Drawing.Size(875, 475)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnRojo)
        Me.Controls.Add(Me.TxtColores)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "FrmColores"
        Me.Text = "Colores"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtColores As TextBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents btnRojo As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
End Class
