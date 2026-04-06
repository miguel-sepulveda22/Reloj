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
        Me.components = New System.ComponentModel.Container()
        Me.Horas = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Minutos = New System.Windows.Forms.Label()
        Me.Dia = New System.Windows.Forms.Label()
        Me.Fecha = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Config = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Tiempo = New System.Windows.Forms.Label()
        Me.Reset = New System.Windows.Forms.Button()
        Me.Start1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Start = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Segundos = New System.Windows.Forms.Label()
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Config.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Horas
        '
        Me.Horas.AutoSize = True
        Me.Horas.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Horas.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Horas.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Horas.Location = New System.Drawing.Point(86, 74)
        Me.Horas.Name = "Horas"
        Me.Horas.Size = New System.Drawing.Size(151, 108)
        Me.Horas.TabIndex = 0
        Me.Horas.Text = "00"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(243, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 108)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = ":"
        '
        'Minutos
        '
        Me.Minutos.AutoSize = True
        Me.Minutos.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Minutos.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Minutos.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Minutos.Location = New System.Drawing.Point(321, 74)
        Me.Minutos.Name = "Minutos"
        Me.Minutos.Size = New System.Drawing.Size(151, 108)
        Me.Minutos.TabIndex = 2
        Me.Minutos.Text = "00"
        '
        'Dia
        '
        Me.Dia.AutoSize = True
        Me.Dia.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Dia.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dia.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Dia.Location = New System.Drawing.Point(78, 170)
        Me.Dia.Name = "Dia"
        Me.Dia.Size = New System.Drawing.Size(121, 42)
        Me.Dia.TabIndex = 3
        Me.Dia.Text = "Lunes"
        '
        'Fecha
        '
        Me.Fecha.AutoSize = True
        Me.Fecha.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fecha.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Fecha.Location = New System.Drawing.Point(78, 212)
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Size = New System.Drawing.Size(380, 42)
        Me.Fecha.TabIndex = 4
        Me.Fecha.Text = "09 de Marzo del 2026"
        '
        'Timer1
        '
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 1000
        '
        'Config
        '
        Me.Config.Controls.Add(Me.Label4)
        Me.Config.Controls.Add(Me.ComboBox1)
        Me.Config.Controls.Add(Me.Start)
        Me.Config.Controls.Add(Me.Label2)
        Me.Config.Location = New System.Drawing.Point(66, 74)
        Me.Config.Name = "Config"
        Me.Config.Size = New System.Drawing.Size(363, 190)
        Me.Config.TabIndex = 7
        Me.Config.Visible = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Tiempo)
        Me.Panel1.Controls.Add(Me.Reset)
        Me.Panel1.Controls.Add(Me.Start1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(66, 74)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(363, 190)
        Me.Panel1.TabIndex = 9
        Me.Panel1.Visible = False
        '
        'Tiempo
        '
        Me.Tiempo.AutoSize = True
        Me.Tiempo.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tiempo.Location = New System.Drawing.Point(16, 52)
        Me.Tiempo.Name = "Tiempo"
        Me.Tiempo.Size = New System.Drawing.Size(199, 37)
        Me.Tiempo.TabIndex = 4
        Me.Tiempo.Text = "00:00:00.00"
        '
        'Reset
        '
        Me.Reset.Location = New System.Drawing.Point(122, 109)
        Me.Reset.Name = "Reset"
        Me.Reset.Size = New System.Drawing.Size(75, 23)
        Me.Reset.TabIndex = 2
        Me.Reset.Text = "Reset"
        Me.Reset.UseVisualStyleBackColor = True
        '
        'Start1
        '
        Me.Start1.Location = New System.Drawing.Point(19, 108)
        Me.Start1.Name = "Start1"
        Me.Start1.Size = New System.Drawing.Size(75, 23)
        Me.Start1.TabIndex = 1
        Me.Start1.Text = "Start"
        Me.Start1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(77, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 24)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Cronometro"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(289, 85)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 13)
        Me.Label4.TabIndex = 4
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Blanco", "Verde", "Rojo", "Azul", "Amarillo"})
        Me.ComboBox1.Location = New System.Drawing.Point(88, 148)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(179, 21)
        Me.ComboBox1.TabIndex = 8
        '
        'Start
        '
        Me.Start.Location = New System.Drawing.Point(19, 52)
        Me.Start.Name = "Start"
        Me.Start.Size = New System.Drawing.Size(47, 46)
        Me.Start.TabIndex = 1
        Me.Start.Text = "Button1"
        Me.Start.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(119, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Configuraciones"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Practica4.My.Resources.Resources.png_clipart_timer_clock_animation_cartoon_microphone_time_stopwatch_thumbnail
        Me.PictureBox3.Location = New System.Drawing.Point(451, 222)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(34, 29)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 5
        Me.PictureBox3.TabStop = False
        '
        'Segundos
        '
        Me.Segundos.AutoSize = True
        Me.Segundos.Location = New System.Drawing.Point(392, 61)
        Me.Segundos.Name = "Segundos"
        Me.Segundos.Size = New System.Drawing.Size(39, 13)
        Me.Segundos.TabIndex = 9
        Me.Segundos.Text = "Label3"
        '
        'Timer3
        '
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Practica4.My.Resources.Resources._8cbe8e941ff313a72c65c7d61b713e59
        Me.PictureBox2.Location = New System.Drawing.Point(451, 257)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(35, 35)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 6
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Practica4.My.Resources.Resources.Sin_título
        Me.PictureBox1.Location = New System.Drawing.Point(-2, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(555, 369)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(554, 364)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Segundos)
        Me.Controls.Add(Me.Config)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Fecha)
        Me.Controls.Add(Me.Dia)
        Me.Controls.Add(Me.Minutos)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Horas)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Config.ResumeLayout(False)
        Me.Config.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Horas As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Minutos As Label
    Friend WithEvents Dia As Label
    Friend WithEvents Fecha As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Timer2 As Timer
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Config As Panel
    Friend WithEvents Start As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Segundos As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Reset As Button
    Friend WithEvents Start1 As Button
    Friend WithEvents Timer3 As Timer
    Friend WithEvents Label4 As Label
    Friend WithEvents Tiempo As Label
    Friend WithEvents PictureBox3 As PictureBox
End Class
