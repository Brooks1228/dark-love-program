<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPerson1 = New System.Windows.Forms.TextBox()
        Me.txtPerson2 = New System.Windows.Forms.TextBox()
        Me.btnStrength = New System.Windows.Forms.Button()
        Me.lblPeopleMath = New System.Windows.Forms.Label()
        Me.lblMatchStrength = New System.Windows.Forms.Label()
        Me.picIMage = New System.Windows.Forms.PictureBox()
        CType(Me.picIMage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(246, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(308, 58)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "love detector <3"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Monotype Corsiva", 26.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 43)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Person 1:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Monotype Corsiva", 26.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(392, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(133, 43)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Person 2:"
        '
        'txtPerson1
        '
        Me.txtPerson1.BackColor = System.Drawing.SystemColors.Window
        Me.txtPerson1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPerson1.Location = New System.Drawing.Point(151, 90)
        Me.txtPerson1.Name = "txtPerson1"
        Me.txtPerson1.Size = New System.Drawing.Size(216, 35)
        Me.txtPerson1.TabIndex = 3
        '
        'txtPerson2
        '
        Me.txtPerson2.BackColor = System.Drawing.SystemColors.Window
        Me.txtPerson2.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPerson2.Location = New System.Drawing.Point(531, 90)
        Me.txtPerson2.Name = "txtPerson2"
        Me.txtPerson2.Size = New System.Drawing.Size(224, 35)
        Me.txtPerson2.TabIndex = 4
        '
        'btnStrength
        '
        Me.btnStrength.BackColor = System.Drawing.SystemColors.Window
        Me.btnStrength.Font = New System.Drawing.Font("Monotype Corsiva", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStrength.Location = New System.Drawing.Point(255, 150)
        Me.btnStrength.Name = "btnStrength"
        Me.btnStrength.Size = New System.Drawing.Size(299, 40)
        Me.btnStrength.TabIndex = 5
        Me.btnStrength.Text = "Determine Strength"
        Me.btnStrength.UseVisualStyleBackColor = False
        '
        'lblPeopleMath
        '
        Me.lblPeopleMath.Font = New System.Drawing.Font("Monotype Corsiva", 21.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPeopleMath.Location = New System.Drawing.Point(50, 193)
        Me.lblPeopleMath.Name = "lblPeopleMath"
        Me.lblPeopleMath.Size = New System.Drawing.Size(705, 36)
        Me.lblPeopleMath.TabIndex = 6
        Me.lblPeopleMath.Text = "Person1 + Person 2"
        Me.lblPeopleMath.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblPeopleMath.Visible = False
        '
        'lblMatchStrength
        '
        Me.lblMatchStrength.Font = New System.Drawing.Font("Monotype Corsiva", 21.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMatchStrength.Location = New System.Drawing.Point(12, 405)
        Me.lblMatchStrength.Name = "lblMatchStrength"
        Me.lblMatchStrength.Size = New System.Drawing.Size(783, 36)
        Me.lblMatchStrength.TabIndex = 7
        Me.lblMatchStrength.Text = "Match Outcome"
        Me.lblMatchStrength.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblMatchStrength.Visible = False
        '
        'picIMage
        '
        Me.picIMage.Location = New System.Drawing.Point(255, 245)
        Me.picIMage.Name = "picIMage"
        Me.picIMage.Size = New System.Drawing.Size(299, 140)
        Me.picIMage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picIMage.TabIndex = 8
        Me.picIMage.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.picIMage)
        Me.Controls.Add(Me.lblMatchStrength)
        Me.Controls.Add(Me.lblPeopleMath)
        Me.Controls.Add(Me.btnStrength)
        Me.Controls.Add(Me.txtPerson2)
        Me.Controls.Add(Me.txtPerson1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Love Detector"
        CType(Me.picIMage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPerson1 As TextBox
    Friend WithEvents txtPerson2 As TextBox
    Friend WithEvents btnStrength As Button
    Friend WithEvents lblPeopleMath As Label
    Friend WithEvents lblMatchStrength As Label
    Friend WithEvents picIMage As PictureBox
End Class
