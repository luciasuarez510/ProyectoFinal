<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
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
        Me.CmbComisaria = New System.Windows.Forms.ComboBox()
        Me.CmbOficial = New System.Windows.Forms.ComboBox()
        Me.btnIngreso = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'CmbComisaria
        '
        Me.CmbComisaria.FormattingEnabled = True
        Me.CmbComisaria.Location = New System.Drawing.Point(292, 204)
        Me.CmbComisaria.Name = "CmbComisaria"
        Me.CmbComisaria.Size = New System.Drawing.Size(195, 21)
        Me.CmbComisaria.TabIndex = 0
        Me.CmbComisaria.Text = "Comisaria"
        '
        'CmbOficial
        '
        Me.CmbOficial.Enabled = False
        Me.CmbOficial.FormattingEnabled = True
        Me.CmbOficial.Location = New System.Drawing.Point(292, 280)
        Me.CmbOficial.Name = "CmbOficial"
        Me.CmbOficial.Size = New System.Drawing.Size(195, 21)
        Me.CmbOficial.TabIndex = 1
        Me.CmbOficial.Text = "Oficial"
        '
        'btnIngreso
        '
        Me.btnIngreso.Location = New System.Drawing.Point(343, 369)
        Me.btnIngreso.Name = "btnIngreso"
        Me.btnIngreso.Size = New System.Drawing.Size(75, 23)
        Me.btnIngreso.TabIndex = 2
        Me.btnIngreso.Text = "Ingresar"
        Me.btnIngreso.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(201, 207)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Elija su comisaria"
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Entidades.My.Resources.Resources.Sin_título
        Me.ClientSize = New System.Drawing.Size(560, 446)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnIngreso)
        Me.Controls.Add(Me.CmbOficial)
        Me.Controls.Add(Me.CmbComisaria)
        Me.Enabled = False
        Me.Name = "login"
        Me.Text = "Form4"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CmbComisaria As System.Windows.Forms.ComboBox
    Friend WithEvents CmbOficial As System.Windows.Forms.ComboBox
    Friend WithEvents btnIngreso As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
