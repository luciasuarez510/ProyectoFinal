<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pantallaprincipal
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
        Me.btnMostrarD = New System.Windows.Forms.Button()
        Me.btnAgregarD = New System.Windows.Forms.Button()
        Me.btnAgregarP = New System.Windows.Forms.Button()
        Me.btnIngresarDenun = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnMostrarD
        '
        Me.btnMostrarD.Location = New System.Drawing.Point(244, 163)
        Me.btnMostrarD.Name = "btnMostrarD"
        Me.btnMostrarD.Size = New System.Drawing.Size(111, 48)
        Me.btnMostrarD.TabIndex = 0
        Me.btnMostrarD.Text = "Mostrar denuncias"
        Me.btnMostrarD.UseVisualStyleBackColor = True
        '
        'btnAgregarD
        '
        Me.btnAgregarD.Location = New System.Drawing.Point(244, 279)
        Me.btnAgregarD.Name = "btnAgregarD"
        Me.btnAgregarD.Size = New System.Drawing.Size(111, 48)
        Me.btnAgregarD.TabIndex = 1
        Me.btnAgregarD.Text = "Agregar denuncias"
        Me.btnAgregarD.UseVisualStyleBackColor = True
        '
        'btnAgregarP
        '
        Me.btnAgregarP.Location = New System.Drawing.Point(404, 279)
        Me.btnAgregarP.Name = "btnAgregarP"
        Me.btnAgregarP.Size = New System.Drawing.Size(111, 48)
        Me.btnAgregarP.TabIndex = 2
        Me.btnAgregarP.Text = "Agregar persona"
        Me.btnAgregarP.UseVisualStyleBackColor = True
        '
        'btnIngresarDenun
        '
        Me.btnIngresarDenun.Location = New System.Drawing.Point(404, 163)
        Me.btnIngresarDenun.Name = "btnIngresarDenun"
        Me.btnIngresarDenun.Size = New System.Drawing.Size(111, 48)
        Me.btnIngresarDenun.TabIndex = 3
        Me.btnIngresarDenun.Text = "Ingresar denuncias"
        Me.btnIngresarDenun.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.Location = New System.Drawing.Point(404, 217)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(111, 30)
        Me.btnEditar.TabIndex = 4
        Me.btnEditar.Text = "Editar denuncias"
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'pantallaprincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Entidades.My.Resources.Resources.Sin_título
        Me.ClientSize = New System.Drawing.Size(560, 446)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnIngresarDenun)
        Me.Controls.Add(Me.btnAgregarP)
        Me.Controls.Add(Me.btnAgregarD)
        Me.Controls.Add(Me.btnMostrarD)
        Me.Name = "pantallaprincipal"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnMostrarD As System.Windows.Forms.Button
    Friend WithEvents btnAgregarD As System.Windows.Forms.Button
    Friend WithEvents btnAgregarP As System.Windows.Forms.Button
    Friend WithEvents btnIngresarDenun As System.Windows.Forms.Button
    Friend WithEvents btnEditar As System.Windows.Forms.Button
End Class
