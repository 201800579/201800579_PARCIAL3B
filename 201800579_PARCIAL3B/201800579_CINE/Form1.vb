Imports System.Math
Public Class Form1

    Dim T As Double

    'codigo para que solo permita ingreso de numeros
    Private Sub TBnit_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TBNit.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub


    'codigo para que solo permita ingreso de numeros
    Private Sub TBnormal_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TBNomal.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub


    'codigo para que solo permita ingreso de numeros
    Private Sub TB3d_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TB3d.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    'codigo para que solo permita ingreso de numeros
    Private Sub TB4d_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TB4d.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub AceparToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AceparToolStripMenuItem.Click

        'empezamos realizando un contador
        If contador < 7 Then

            'llenamos los vectores

            NIT(contador) = TBNit.Text
            PELICULA(contador) = TBpelicula.Text

            'normal
            If CBnormal.Checked = True Then
                CANTIDAD(contador) = TBNomal.Text
                SALA(contador) = "normal"
                T = prnomarl * TBNomal.Text
                TOTAL(contador) = Round(T, 2)
            End If

            'n3d
            If CB3d.Checked = True Then
                CANTIDAD(contador) = TB3d.Text
                SALA(contador) = "3D"
                T = prtresd * TBNomal.Text
                TOTAL(contador) = Round(T, 2)
            End If


            '4d
            If CB4d.Checked = True Then
                CANTIDAD(contador) = TB4d.Text
                SALA(contador) = "4DX"
                T = prCuatroD * TBNomal.Text
                TOTAL(contador) = Round(T, 2)
            End If



            ' 2 combinaciones
            If CBnormal.Checked = True And CB3d.Checked = True Then
                Dim boleto As Integer
                boleto = TBNomal.Text + TB3d.Text
                CANTIDAD(contador) = boleto
                SALA(contador) = "normal y 3D"
                T = prnomarl * TBNomal.Text + prtresd * TB3d.Text
                TOTAL(contador) = Round(T, 2)

            End If


            If CBnormal.Checked = True And CB4d.Checked = True Then

                Dim boleto As Integer
                boleto = TBNomal.Text + TB4d.Text
                CANTIDAD(contador) = boleto
                SALA(contador) = "normal y 4DX"
                T = prnomarl * TBNomal.Text + prCuatroD * TB4d.Text
                TOTAL(contador) = Round(T, 2)

            End If

            If CB4d.Checked = True And CB3d.Checked = True Then

                Dim boleto As Integer
                boleto = TB4d.Text + TB3d.Text
                CANTIDAD(contador) = boleto
                SALA(contador) = "4DX y 3D"
                T = prCuatroD * TB4d.Text + prtresd * TB3d.Text
                TOTAL(contador) = Round(T, 2)

            End If


            'tres combinaciones

            If CBnormal.Checked = True And CB4d.Checked = True And CB3d.Checked = True Then
                Dim boleto As Integer
                boleto = TB4d.Text + TB3d.Text + TBNomal.Text
                CANTIDAD(contador) = boleto
                SALA(contador) = "Normal, 4DX y 3D"
                T = prCuatroD * TB4d.Text + prtresd * TB3d.Text + prnomarl * TBNomal.Text
                TOTAL(contador) = Round(T, 2)
            End If

            'llenamos la matriz

            contador = contador + 1
            MsgBox("SEregistro con exito ", MsgBoxStyle.Information, "Registro")
            Limpiezaentradas()
        Else
            MessageBox.Show("Ya se lleno el cupo")
        End If
    End Sub

    Private Sub MostrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MostrarToolStripMenuItem.Click


        DTresultados.Rows.Clear()


        While (relleno <= (contador - 1))
            DTresultados.Rows.Add(NIT(relleno), PELICULA(relleno), CANTIDAD(relleno), SALA(relleno), TOTAL(relleno))
            relleno = relleno + 1
        End While





    End Sub

    Private Sub BuscarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuscarToolStripMenuItem.Click


        If TBbusqueda.Text = 0 Then
            MsgBox("INGRESE EL NIT", MsgBoxStyle.Information, "ERROR")
            TBbusqueda.Focus()
        Else
            Dim existe As Boolean = True
            Dim PARAusqueda = 0
            While (PARAusqueda <= 7) And (existe)
                If (NIT(PARAusqueda) = Val(TBbusqueda.Text)) Then
                    existe = False '
                Else
                    PARAusqueda = PARAusqueda + 1
                End If
            End While

            If (existe = False) Then
                MsgBox("Registro Encontrado exitosamente")
                DTresultados.Rows.Clear()
                DTresultados.Rows.Add(NIT(PARAusqueda), PELICULA(PARAusqueda), CANTIDAD(PARAusqueda), SALA(PARAusqueda), TOTAL(PARAusqueda))



            Else

                MsgBox("INGRESE EL NIT", MsgBoxStyle.Information, "ERROR")

            End If



        End If

    End Sub

    Private Sub LimpiarVectoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarVectoresToolStripMenuItem.Click
        adiosmatriz()
    End Sub

    Private Sub ActualizarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActualizarToolStripMenuItem.Click



    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        If MsgBox("¿Desea Salir?", vbQuestion + vbYesNo, "Salir") = vbYes Then

            Me.Close()
        End If
    End Sub
End Class
