Public Class frmAltaV
    Private Sub frmAltaV_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'PARAMETROS INICIALES

        Me.CenterToScreen()

        Dim sql As String
        Dim tabla As DataTable

        txtCodigo.MaxLength = 5
        dtpFecha.MaxDate = Date.Today

        'Datos dentro del cmb
        sql = "select * from Categorias order by Categoria asc"
        tabla = New DataTable
        RecuperarSQL(sql, tabla)
        cmbCat.DataSource = tabla
        cmbCat.DisplayMember = "Categoria"
        cmbCat.ValueMember = "IdCategoria"
        cmbCat.DropDownStyle = ComboBoxStyle.DropDownList
        cmbCat.SelectedIndex = 0

        'rb un estado seleccionado
        rbDisp.Checked = True
    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        Dim sql As String
        If validacion() Then
            'Insertamos los valores en la base de datos
            sql = "insert into Variedades (Codigo, Variedad, Precio, FechaPublicacion, Estado, IdCategoria)"
            sql = sql & "Values('" & txtCodigo.Text & "','" & txtVariedad.Text & "',"
            sql = sql & "'" & txtPrecio.Text & "','" & dtpFecha.Value.ToString() & "',"
            If rbDisp.Checked Then
                sql = sql & "'" & rbDisp.Text & "',"
            ElseIf rbOfer.Checked Then
                sql = sql & "'" & rbOfer.Text & "',"
            Else
                sql = sql & "'" & rbSusp.Text & "',"
            End If
            sql = sql & "'" & cmbCat.SelectedValue & "')"
            EjecutarSQL(sql)
            MessageBox.Show("Registrado", "Enhorabuena", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("No se ha podido registrar", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Function validacion() As Boolean
        Dim TodoOk As Boolean
        Dim sql As String
        Dim tabla As DataTable

        If txtCodigo.TextLength = 5 Then
            If txtVariedad.Text.Trim <> String.Empty Then
                If txtVariedad.MaxLength <= 50 Then
                    If IsNumeric(txtPrecio.Text) Then
                        If txtPrecio.Text > 0 Then
                            TodoOk = True
                        Else
                            MessageBox.Show("El precio debe ser mayor a cero", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            txtPrecio.Focus()
                        End If
                    Else
                        MessageBox.Show("El Precio debe ser Numerico", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        txtPrecio.Focus()
                    End If
                Else
                    MessageBox.Show("Variedad no puede superar los 50 caracteres", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtVariedad.Focus()
                End If
            Else
                MessageBox.Show("Variedad no puede estar vacio", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtVariedad.Focus()
            End If
        Else
            MessageBox.Show("El código debe contener 5 caracteres", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtCodigo.Focus()
        End If
        'Validar que el codigo no este insertado en la bd'
        If TodoOk Then
            TodoOk = False
            sql = "select * from Variedades where Codigo ='" & txtCodigo.Text & "' "
            tabla = New DataTable
            RecuperarSQL(sql, tabla)
            If tabla.Rows.Count = 0 Then
                TodoOk = True
            Else
                MessageBox.Show("El codigo ingresado ya se ha registrado", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
        Return TodoOk
    End Function
End Class
