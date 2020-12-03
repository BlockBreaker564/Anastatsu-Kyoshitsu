<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main_Game
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main_Game))
        Me.Nagisa = New System.Windows.Forms.PictureBox()
        Me.Karma = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SAAUSO_Knife = New System.Windows.Forms.PictureBox()
        Me.PictureBox4wall = New System.Windows.Forms.PictureBox()
        Me.PictureBox5wall = New System.Windows.Forms.PictureBox()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1wall = New System.Windows.Forms.PictureBox()
        Me.PictureBox2wall = New System.Windows.Forms.PictureBox()
        CType(Me.Nagisa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Karma, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SAAUSO_Knife, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4wall, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5wall, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1wall, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2wall, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Nagisa
        '
        Me.Nagisa.Image = CType(resources.GetObject("Nagisa.Image"), System.Drawing.Image)
        Me.Nagisa.Location = New System.Drawing.Point(867, 230)
        Me.Nagisa.Name = "Nagisa"
        Me.Nagisa.Size = New System.Drawing.Size(117, 144)
        Me.Nagisa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Nagisa.TabIndex = 5
        Me.Nagisa.TabStop = False
        '
        'Karma
        '
        Me.Karma.Image = CType(resources.GetObject("Karma.Image"), System.Drawing.Image)
        Me.Karma.Location = New System.Drawing.Point(12, 251)
        Me.Karma.Name = "Karma"
        Me.Karma.Size = New System.Drawing.Size(145, 74)
        Me.Karma.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Karma.TabIndex = 4
        Me.Karma.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'SAAUSO_Knife
        '
        Me.SAAUSO_Knife.Image = Global.game.My.Resources.Resources.SAAUSO_knife
        Me.SAAUSO_Knife.Location = New System.Drawing.Point(423, 263)
        Me.SAAUSO_Knife.Name = "SAAUSO_Knife"
        Me.SAAUSO_Knife.Size = New System.Drawing.Size(136, 50)
        Me.SAAUSO_Knife.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.SAAUSO_Knife.TabIndex = 7
        Me.SAAUSO_Knife.TabStop = False
        '
        'PictureBox4wall
        '
        Me.PictureBox4wall.Location = New System.Drawing.Point(3, -1)
        Me.PictureBox4wall.Name = "PictureBox4wall"
        Me.PictureBox4wall.Size = New System.Drawing.Size(992, 9)
        Me.PictureBox4wall.TabIndex = 9
        Me.PictureBox4wall.TabStop = False
        '
        'PictureBox5wall
        '
        Me.PictureBox5wall.Location = New System.Drawing.Point(-3, 588)
        Me.PictureBox5wall.Name = "PictureBox5wall"
        Me.PictureBox5wall.Size = New System.Drawing.Size(997, 10)
        Me.PictureBox5wall.TabIndex = 10
        Me.PictureBox5wall.TabStop = False
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        '
        'PictureBox1wall
        '
        Me.PictureBox1wall.Location = New System.Drawing.Point(-3, -1)
        Me.PictureBox1wall.Name = "PictureBox1wall"
        Me.PictureBox1wall.Size = New System.Drawing.Size(14, 601)
        Me.PictureBox1wall.TabIndex = 11
        Me.PictureBox1wall.TabStop = False
        '
        'PictureBox2wall
        '
        Me.PictureBox2wall.Location = New System.Drawing.Point(984, 5)
        Me.PictureBox2wall.Name = "PictureBox2wall"
        Me.PictureBox2wall.Size = New System.Drawing.Size(9, 592)
        Me.PictureBox2wall.TabIndex = 12
        Me.PictureBox2wall.TabStop = False
        '
        'Main_Game
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.game.My.Resources.Resources.class_3_e_by_shrineheart_ddbkig1_fullview
        Me.ClientSize = New System.Drawing.Size(996, 601)
        Me.Controls.Add(Me.PictureBox2wall)
        Me.Controls.Add(Me.PictureBox1wall)
        Me.Controls.Add(Me.PictureBox5wall)
        Me.Controls.Add(Me.PictureBox4wall)
        Me.Controls.Add(Me.Nagisa)
        Me.Controls.Add(Me.Karma)
        Me.Controls.Add(Me.SAAUSO_Knife)
        Me.DoubleBuffered = True
        Me.Name = "Main_Game"
        Me.Text = "Form1"
        CType(Me.Nagisa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Karma, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SAAUSO_Knife, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4wall, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5wall, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1wall, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2wall, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Nagisa As PictureBox
    Friend WithEvents Karma As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents SAAUSO_Knife As PictureBox
    Friend WithEvents PictureBox4wall As PictureBox
    Friend WithEvents PictureBox5wall As PictureBox
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Timer3 As Timer
    Friend WithEvents PictureBox1wall As PictureBox
    Friend WithEvents PictureBox2wall As PictureBox
End Class
