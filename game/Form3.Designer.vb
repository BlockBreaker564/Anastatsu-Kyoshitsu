<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
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
        Me.wall1 = New System.Windows.Forms.PictureBox()
        Me.wall2 = New System.Windows.Forms.PictureBox()
        Me.wall3 = New System.Windows.Forms.PictureBox()
        Me.wall4 = New System.Windows.Forms.PictureBox()
        Me.wall6 = New System.Windows.Forms.PictureBox()
        Me.wall7 = New System.Windows.Forms.PictureBox()
        Me.wall8 = New System.Windows.Forms.PictureBox()
        Me.wall5 = New System.Windows.Forms.PictureBox()
        CType(Me.wall1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.wall2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.wall3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.wall4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.wall6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.wall7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.wall8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.wall5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'wall1
        '
        Me.wall1.Location = New System.Drawing.Point(12, 11)
        Me.wall1.Name = "wall1"
        Me.wall1.Size = New System.Drawing.Size(10, 588)
        Me.wall1.TabIndex = 1
        Me.wall1.TabStop = False
        '
        'wall2
        '
        Me.wall2.Location = New System.Drawing.Point(12, 12)
        Me.wall2.Name = "wall2"
        Me.wall2.Size = New System.Drawing.Size(974, 12)
        Me.wall2.TabIndex = 2
        Me.wall2.TabStop = False
        '
        'wall3
        '
        Me.wall3.Location = New System.Drawing.Point(977, 12)
        Me.wall3.Name = "wall3"
        Me.wall3.Size = New System.Drawing.Size(14, 587)
        Me.wall3.TabIndex = 3
        Me.wall3.TabStop = False
        '
        'wall4
        '
        Me.wall4.Location = New System.Drawing.Point(12, 585)
        Me.wall4.Name = "wall4"
        Me.wall4.Size = New System.Drawing.Size(979, 15)
        Me.wall4.TabIndex = 4
        Me.wall4.TabStop = False
        '
        'wall6
        '
        Me.wall6.Location = New System.Drawing.Point(53, 70)
        Me.wall6.Name = "wall6"
        Me.wall6.Size = New System.Drawing.Size(13, 529)
        Me.wall6.TabIndex = 5
        Me.wall6.TabStop = False
        '
        'wall7
        '
        Me.wall7.Location = New System.Drawing.Point(53, 70)
        Me.wall7.Name = "wall7"
        Me.wall7.Size = New System.Drawing.Size(388, 17)
        Me.wall7.TabIndex = 6
        Me.wall7.TabStop = False
        '
        'wall8
        '
        Me.wall8.Location = New System.Drawing.Point(541, 70)
        Me.wall8.Name = "wall8"
        Me.wall8.Size = New System.Drawing.Size(388, 17)
        Me.wall8.TabIndex = 7
        Me.wall8.TabStop = False
        '
        'wall5
        '
        Me.wall5.Location = New System.Drawing.Point(916, 71)
        Me.wall5.Name = "wall5"
        Me.wall5.Size = New System.Drawing.Size(13, 529)
        Me.wall5.TabIndex = 8
        Me.wall5.TabStop = False
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.game.My.Resources.Resources.class_3_e_by_shrineheart_ddbkig1_fullview
        Me.ClientSize = New System.Drawing.Size(1003, 612)
        Me.Controls.Add(Me.wall5)
        Me.Controls.Add(Me.wall8)
        Me.Controls.Add(Me.wall7)
        Me.Controls.Add(Me.wall6)
        Me.Controls.Add(Me.wall4)
        Me.Controls.Add(Me.wall3)
        Me.Controls.Add(Me.wall2)
        Me.Controls.Add(Me.wall1)
        Me.Name = "Form3"
        Me.Text = "Form3"
        CType(Me.wall1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.wall2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.wall3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.wall4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.wall6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.wall7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.wall8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.wall5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents wall1 As PictureBox
    Friend WithEvents wall2 As PictureBox
    Friend WithEvents wall3 As PictureBox
    Friend WithEvents wall4 As PictureBox

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Friend WithEvents wall6 As PictureBox
    Friend WithEvents wall7 As PictureBox
    Friend WithEvents wall8 As PictureBox

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Friend WithEvents wall5 As PictureBox


End Class


