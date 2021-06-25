<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAltaV
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
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.lblVariedad = New System.Windows.Forms.Label()
        Me.txtVariedad = New System.Windows.Forms.TextBox()
        Me.lblCat = New System.Windows.Forms.Label()
        Me.cmbCat = New System.Windows.Forms.ComboBox()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbSusp = New System.Windows.Forms.RadioButton()
        Me.rbOfer = New System.Windows.Forms.RadioButton()
        Me.rbDisp = New System.Windows.Forms.RadioButton()
        Me.lblPrecio = New System.Windows.Forms.Label()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(117, 46)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(59, 20)
        Me.txtCodigo.TabIndex = 0
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Location = New System.Drawing.Point(68, 53)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(43, 13)
        Me.lblCodigo.TabIndex = 1
        Me.lblCodigo.Text = "Codigo:"
        '
        'lblVariedad
        '
        Me.lblVariedad.AutoSize = True
        Me.lblVariedad.Location = New System.Drawing.Point(62, 93)
        Me.lblVariedad.Name = "lblVariedad"
        Me.lblVariedad.Size = New System.Drawing.Size(52, 13)
        Me.lblVariedad.TabIndex = 3
        Me.lblVariedad.Text = "Variedad:"
        '
        'txtVariedad
        '
        Me.txtVariedad.Location = New System.Drawing.Point(117, 86)
        Me.txtVariedad.MaxLength = 50
        Me.txtVariedad.Name = "txtVariedad"
        Me.txtVariedad.Size = New System.Drawing.Size(316, 20)
        Me.txtVariedad.TabIndex = 1
        '
        'lblCat
        '
        Me.lblCat.AutoSize = True
        Me.lblCat.Location = New System.Drawing.Point(56, 128)
        Me.lblCat.Name = "lblCat"
        Me.lblCat.Size = New System.Drawing.Size(55, 13)
        Me.lblCat.TabIndex = 4
        Me.lblCat.Text = "Categoria:"
        '
        'cmbCat
        '
        Me.cmbCat.FormattingEnabled = True
        Me.cmbCat.Location = New System.Drawing.Point(117, 120)
        Me.cmbCat.Name = "cmbCat"
        Me.cmbCat.Size = New System.Drawing.Size(121, 21)
        Me.cmbCat.TabIndex = 2
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Location = New System.Drawing.Point(46, 166)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(65, 13)
        Me.lblFecha.TabIndex = 6
        Me.lblFecha.Text = "Publicación:"
        '
        'dtpFecha
        '
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(117, 159)
        Me.dtpFecha.MaxDate = New Date(2021, 6, 21, 0, 0, 0, 0)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(95, 20)
        Me.dtpFecha.TabIndex = 3
        Me.dtpFecha.Value = New Date(2021, 6, 21, 0, 0, 0, 0)
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbSusp)
        Me.GroupBox1.Controls.Add(Me.rbOfer)
        Me.GroupBox1.Controls.Add(Me.rbDisp)
        Me.GroupBox1.Location = New System.Drawing.Point(117, 195)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(316, 75)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Estado"
        '
        'rbSusp
        '
        Me.rbSusp.AutoSize = True
        Me.rbSusp.Location = New System.Drawing.Point(210, 33)
        Me.rbSusp.Name = "rbSusp"
        Me.rbSusp.Size = New System.Drawing.Size(81, 17)
        Me.rbSusp.TabIndex = 7
        Me.rbSusp.TabStop = True
        Me.rbSusp.Text = "Suspendida"
        Me.rbSusp.UseVisualStyleBackColor = True
        '
        'rbOfer
        '
        Me.rbOfer.AutoSize = True
        Me.rbOfer.Location = New System.Drawing.Point(121, 33)
        Me.rbOfer.Name = "rbOfer"
        Me.rbOfer.Size = New System.Drawing.Size(54, 17)
        Me.rbOfer.TabIndex = 6
        Me.rbOfer.TabStop = True
        Me.rbOfer.Text = "Oferta"
        Me.rbOfer.UseVisualStyleBackColor = True
        '
        'rbDisp
        '
        Me.rbDisp.AutoSize = True
        Me.rbDisp.Location = New System.Drawing.Point(18, 33)
        Me.rbDisp.Name = "rbDisp"
        Me.rbDisp.Size = New System.Drawing.Size(74, 17)
        Me.rbDisp.TabIndex = 5
        Me.rbDisp.TabStop = True
        Me.rbDisp.Text = "Disponible"
        Me.rbDisp.UseVisualStyleBackColor = True
        '
        'lblPrecio
        '
        Me.lblPrecio.AutoSize = True
        Me.lblPrecio.Location = New System.Drawing.Point(71, 293)
        Me.lblPrecio.Name = "lblPrecio"
        Me.lblPrecio.Size = New System.Drawing.Size(40, 13)
        Me.lblPrecio.TabIndex = 9
        Me.lblPrecio.Text = "Precio:"
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(117, 286)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(95, 20)
        Me.txtPrecio.TabIndex = 8
        '
        'btnRegistrar
        '
        Me.btnRegistrar.Location = New System.Drawing.Point(179, 331)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(113, 23)
        Me.btnRegistrar.TabIndex = 9
        Me.btnRegistrar.Text = "Registrar"
        Me.btnRegistrar.UseVisualStyleBackColor = True
        '
        'frmAltaV
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(464, 372)
        Me.Controls.Add(Me.btnRegistrar)
        Me.Controls.Add(Me.txtPrecio)
        Me.Controls.Add(Me.lblPrecio)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.cmbCat)
        Me.Controls.Add(Me.lblCat)
        Me.Controls.Add(Me.lblVariedad)
        Me.Controls.Add(Me.txtVariedad)
        Me.Controls.Add(Me.lblCodigo)
        Me.Controls.Add(Me.txtCodigo)
        Me.Name = "frmAltaV"
        Me.Text = "Alta de Variedad"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents lblCodigo As Label
    Friend WithEvents lblVariedad As Label
    Friend WithEvents txtVariedad As TextBox
    Friend WithEvents lblCat As Label
    Friend WithEvents cmbCat As ComboBox
    Friend WithEvents lblFecha As Label
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbSusp As RadioButton
    Friend WithEvents rbOfer As RadioButton
    Friend WithEvents rbDisp As RadioButton
    Friend WithEvents lblPrecio As Label
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents btnRegistrar As Button
End Class
