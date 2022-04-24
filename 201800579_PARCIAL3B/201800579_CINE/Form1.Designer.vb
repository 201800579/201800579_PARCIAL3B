<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.GPCliente = New System.Windows.Forms.GroupBox()
        Me.TBpelicula = New System.Windows.Forms.TextBox()
        Me.LBpelicula = New System.Windows.Forms.Label()
        Me.TBNit = New System.Windows.Forms.TextBox()
        Me.LBNIT = New System.Windows.Forms.Label()
        Me.GBBoletos = New System.Windows.Forms.GroupBox()
        Me.TB4d = New System.Windows.Forms.TextBox()
        Me.TB3d = New System.Windows.Forms.TextBox()
        Me.CB4d = New System.Windows.Forms.CheckBox()
        Me.CB3d = New System.Windows.Forms.CheckBox()
        Me.CBnormal = New System.Windows.Forms.CheckBox()
        Me.TBNomal = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AceparToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MostrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActualizarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LimpiarVectoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DTresultados = New System.Windows.Forms.DataGridView()
        Me.DTnit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DTpeli = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DTCantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DTsala = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DTtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GPbusqueda = New System.Windows.Forms.GroupBox()
        Me.TBbusqueda = New System.Windows.Forms.TextBox()
        Me.LBbusqueda = New System.Windows.Forms.Label()
        Me.GPCliente.SuspendLayout()
        Me.GBBoletos.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DTresultados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GPbusqueda.SuspendLayout()
        Me.SuspendLayout()
        '
        'GPCliente
        '
        Me.GPCliente.Controls.Add(Me.TBpelicula)
        Me.GPCliente.Controls.Add(Me.LBpelicula)
        Me.GPCliente.Controls.Add(Me.TBNit)
        Me.GPCliente.Controls.Add(Me.LBNIT)
        Me.GPCliente.Location = New System.Drawing.Point(33, 41)
        Me.GPCliente.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GPCliente.Name = "GPCliente"
        Me.GPCliente.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GPCliente.Size = New System.Drawing.Size(386, 114)
        Me.GPCliente.TabIndex = 0
        Me.GPCliente.TabStop = False
        Me.GPCliente.Text = "INGRESOS"
        '
        'TBpelicula
        '
        Me.TBpelicula.Location = New System.Drawing.Point(202, 68)
        Me.TBpelicula.Name = "TBpelicula"
        Me.TBpelicula.Size = New System.Drawing.Size(175, 29)
        Me.TBpelicula.TabIndex = 3
        '
        'LBpelicula
        '
        Me.LBpelicula.AutoSize = True
        Me.LBpelicula.Location = New System.Drawing.Point(7, 75)
        Me.LBpelicula.Name = "LBpelicula"
        Me.LBpelicula.Size = New System.Drawing.Size(189, 22)
        Me.LBpelicula.TabIndex = 2
        Me.LBpelicula.Text = "Nombre de la Pelicula"
        '
        'TBNit
        '
        Me.TBNit.Location = New System.Drawing.Point(202, 30)
        Me.TBNit.Name = "TBNit"
        Me.TBNit.Size = New System.Drawing.Size(175, 29)
        Me.TBNit.TabIndex = 1
        Me.TBNit.Text = "0"
        '
        'LBNIT
        '
        Me.LBNIT.AutoSize = True
        Me.LBNIT.Location = New System.Drawing.Point(157, 33)
        Me.LBNIT.Name = "LBNIT"
        Me.LBNIT.Size = New System.Drawing.Size(39, 22)
        Me.LBNIT.TabIndex = 0
        Me.LBNIT.Text = "NIT"
        '
        'GBBoletos
        '
        Me.GBBoletos.Controls.Add(Me.TB4d)
        Me.GBBoletos.Controls.Add(Me.TB3d)
        Me.GBBoletos.Controls.Add(Me.CB4d)
        Me.GBBoletos.Controls.Add(Me.CB3d)
        Me.GBBoletos.Controls.Add(Me.CBnormal)
        Me.GBBoletos.Controls.Add(Me.TBNomal)
        Me.GBBoletos.Location = New System.Drawing.Point(465, 41)
        Me.GBBoletos.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GBBoletos.Name = "GBBoletos"
        Me.GBBoletos.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GBBoletos.Size = New System.Drawing.Size(378, 157)
        Me.GBBoletos.TabIndex = 6
        Me.GBBoletos.TabStop = False
        Me.GBBoletos.Text = "Boletos"
        '
        'TB4d
        '
        Me.TB4d.Location = New System.Drawing.Point(161, 119)
        Me.TB4d.Name = "TB4d"
        Me.TB4d.Size = New System.Drawing.Size(175, 29)
        Me.TB4d.TabIndex = 10
        Me.TB4d.Text = "0"
        '
        'TB3d
        '
        Me.TB3d.Location = New System.Drawing.Point(161, 75)
        Me.TB3d.Name = "TB3d"
        Me.TB3d.Size = New System.Drawing.Size(175, 29)
        Me.TB3d.TabIndex = 9
        Me.TB3d.Text = "0"
        '
        'CB4d
        '
        Me.CB4d.AutoSize = True
        Me.CB4d.Location = New System.Drawing.Point(51, 122)
        Me.CB4d.Name = "CB4d"
        Me.CB4d.Size = New System.Drawing.Size(63, 26)
        Me.CB4d.TabIndex = 8
        Me.CB4d.Text = "4DX"
        Me.CB4d.UseVisualStyleBackColor = True
        '
        'CB3d
        '
        Me.CB3d.AutoSize = True
        Me.CB3d.Location = New System.Drawing.Point(51, 75)
        Me.CB3d.Name = "CB3d"
        Me.CB3d.Size = New System.Drawing.Size(52, 26)
        Me.CB3d.TabIndex = 7
        Me.CB3d.Text = "3D"
        Me.CB3d.UseVisualStyleBackColor = True
        '
        'CBnormal
        '
        Me.CBnormal.AutoSize = True
        Me.CBnormal.Location = New System.Drawing.Point(51, 33)
        Me.CBnormal.Name = "CBnormal"
        Me.CBnormal.Size = New System.Drawing.Size(91, 26)
        Me.CBnormal.TabIndex = 6
        Me.CBnormal.Text = "Normal"
        Me.CBnormal.UseVisualStyleBackColor = True
        '
        'TBNomal
        '
        Me.TBNomal.Location = New System.Drawing.Point(161, 33)
        Me.TBNomal.Name = "TBNomal"
        Me.TBNomal.Size = New System.Drawing.Size(175, 29)
        Me.TBNomal.TabIndex = 1
        Me.TBNomal.Text = "0"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Khaki
        Me.MenuStrip1.Font = New System.Drawing.Font("Microsoft New Tai Lue", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AceparToolStripMenuItem, Me.MostrarToolStripMenuItem, Me.BuscarToolStripMenuItem, Me.ActualizarToolStripMenuItem, Me.LimpiarVectoresToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 3, 0, 3)
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip1.Size = New System.Drawing.Size(869, 30)
        Me.MenuStrip1.TabIndex = 7
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AceparToolStripMenuItem
        '
        Me.AceparToolStripMenuItem.Name = "AceparToolStripMenuItem"
        Me.AceparToolStripMenuItem.Size = New System.Drawing.Size(76, 24)
        Me.AceparToolStripMenuItem.Text = "Aceptar"
        '
        'MostrarToolStripMenuItem
        '
        Me.MostrarToolStripMenuItem.Name = "MostrarToolStripMenuItem"
        Me.MostrarToolStripMenuItem.Size = New System.Drawing.Size(77, 24)
        Me.MostrarToolStripMenuItem.Text = "Mostrar"
        '
        'BuscarToolStripMenuItem
        '
        Me.BuscarToolStripMenuItem.Name = "BuscarToolStripMenuItem"
        Me.BuscarToolStripMenuItem.Size = New System.Drawing.Size(68, 24)
        Me.BuscarToolStripMenuItem.Text = "Buscar"
        '
        'ActualizarToolStripMenuItem
        '
        Me.ActualizarToolStripMenuItem.Name = "ActualizarToolStripMenuItem"
        Me.ActualizarToolStripMenuItem.Size = New System.Drawing.Size(91, 24)
        Me.ActualizarToolStripMenuItem.Text = "Actualizar"
        '
        'LimpiarVectoresToolStripMenuItem
        '
        Me.LimpiarVectoresToolStripMenuItem.Name = "LimpiarVectoresToolStripMenuItem"
        Me.LimpiarVectoresToolStripMenuItem.Size = New System.Drawing.Size(123, 24)
        Me.LimpiarVectoresToolStripMenuItem.Text = "Limpiar Matriz"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(51, 24)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'DTresultados
        '
        Me.DTresultados.BackgroundColor = System.Drawing.Color.OliveDrab
        Me.DTresultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DTresultados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DTnit, Me.DTpeli, Me.DTCantidad, Me.DTsala, Me.DTtotal})
        Me.DTresultados.Location = New System.Drawing.Point(14, 236)
        Me.DTresultados.Name = "DTresultados"
        Me.DTresultados.Size = New System.Drawing.Size(843, 285)
        Me.DTresultados.TabIndex = 8
        '
        'DTnit
        '
        Me.DTnit.HeaderText = "nit"
        Me.DTnit.Name = "DTnit"
        '
        'DTpeli
        '
        Me.DTpeli.HeaderText = "Pelicula"
        Me.DTpeli.Name = "DTpeli"
        Me.DTpeli.Width = 200
        '
        'DTCantidad
        '
        Me.DTCantidad.HeaderText = "Cantidad de Boletos"
        Me.DTCantidad.Name = "DTCantidad"
        '
        'DTsala
        '
        Me.DTsala.HeaderText = "Sala"
        Me.DTsala.Name = "DTsala"
        Me.DTsala.Width = 300
        '
        'DTtotal
        '
        Me.DTtotal.HeaderText = "Total"
        Me.DTtotal.Name = "DTtotal"
        '
        'GPbusqueda
        '
        Me.GPbusqueda.Controls.Add(Me.TBbusqueda)
        Me.GPbusqueda.Controls.Add(Me.LBbusqueda)
        Me.GPbusqueda.Location = New System.Drawing.Point(33, 163)
        Me.GPbusqueda.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GPbusqueda.Name = "GPbusqueda"
        Me.GPbusqueda.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GPbusqueda.Size = New System.Drawing.Size(386, 67)
        Me.GPbusqueda.TabIndex = 4
        Me.GPbusqueda.TabStop = False
        Me.GPbusqueda.Text = "INGRESOS"
        '
        'TBbusqueda
        '
        Me.TBbusqueda.Location = New System.Drawing.Point(202, 30)
        Me.TBbusqueda.Name = "TBbusqueda"
        Me.TBbusqueda.Size = New System.Drawing.Size(175, 29)
        Me.TBbusqueda.TabIndex = 1
        Me.TBbusqueda.Text = "0"
        '
        'LBbusqueda
        '
        Me.LBbusqueda.AutoSize = True
        Me.LBbusqueda.Location = New System.Drawing.Point(157, 33)
        Me.LBbusqueda.Name = "LBbusqueda"
        Me.LBbusqueda.Size = New System.Drawing.Size(39, 22)
        Me.LBbusqueda.TabIndex = 0
        Me.LBbusqueda.Text = "NIT"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OliveDrab
        Me.ClientSize = New System.Drawing.Size(869, 524)
        Me.Controls.Add(Me.GPbusqueda)
        Me.Controls.Add(Me.DTresultados)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.GBBoletos)
        Me.Controls.Add(Me.GPCliente)
        Me.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CINE PATO"
        Me.GPCliente.ResumeLayout(False)
        Me.GPCliente.PerformLayout()
        Me.GBBoletos.ResumeLayout(False)
        Me.GBBoletos.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DTresultados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GPbusqueda.ResumeLayout(False)
        Me.GPbusqueda.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents GPCliente As GroupBox
    Friend WithEvents TBpelicula As TextBox
    Friend WithEvents LBpelicula As Label
    Friend WithEvents TBNit As TextBox
    Friend WithEvents LBNIT As Label
    Friend WithEvents GBBoletos As GroupBox
    Friend WithEvents CB4d As CheckBox
    Friend WithEvents CB3d As CheckBox
    Friend WithEvents CBnormal As CheckBox
    Friend WithEvents TBNomal As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AceparToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MostrarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BuscarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ActualizarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LimpiarVectoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DTresultados As DataGridView
    Friend WithEvents DTnit As DataGridViewTextBoxColumn
    Friend WithEvents DTpeli As DataGridViewTextBoxColumn
    Friend WithEvents DTCantidad As DataGridViewTextBoxColumn
    Friend WithEvents DTsala As DataGridViewTextBoxColumn
    Friend WithEvents DTtotal As DataGridViewTextBoxColumn
    Friend WithEvents TB4d As TextBox
    Friend WithEvents TB3d As TextBox
    Friend WithEvents GPbusqueda As GroupBox
    Friend WithEvents TBbusqueda As TextBox
    Friend WithEvents LBbusqueda As Label
End Class
