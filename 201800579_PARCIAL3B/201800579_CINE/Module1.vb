Module Module1

    Public contador = 0
    Public relleno = 0
    Public NIT(7) As String
    Public PELICULA(7) As String
    Public CANTIDAD(7) As Integer
    Public SALA(7) As String
    Public TOTAL(7) As Double

    Public Const prnomarl = 44
    Public Const prtresd = 62
    Public Const prCuatroD = 104



    Public Sub Limpiezaentradas()
        Form1.TB3d.Text = 0
        Form1.TB4d.Text = 0
        Form1.TBNit.Text = 0
        Form1.TBbusqueda.Text = 0
        Form1.TBNomal.Text = 0
        Form1.TBpelicula.Clear()

        Form1.CB3d.Checked = False
        Form1.CB4d.Checked = False
        Form1.CBnormal.Checked = False
    End Sub

    Public Sub adiosmatriz()
        Dim limpieza As Integer
        For limpieza = 0 To 6

            NIT(limpieza) = Nothing
            PELICULA(limpieza) = Nothing
            CANTIDAD(limpieza) = Nothing
            TOTAL(limpieza) = Nothing
            SALA(limpieza) = Nothing
        Next
        contador = 0
        relleno = 0

        Form1.DTresultados.Rows.Clear()
        Limpiezaentradas()
    End Sub

End Module
