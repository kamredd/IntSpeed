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
        Me.lblActualSpeed = New System.Windows.Forms.Label()
        Me.lblISpeed = New System.Windows.Forms.Label()
        Me.btnSpeed = New System.Windows.Forms.Button()
        Me.lblTest = New System.Windows.Forms.Label()
        Me.lstSpeed = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'lblActualSpeed
        '
        Me.lblActualSpeed.AutoSize = True
        Me.lblActualSpeed.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblActualSpeed.Location = New System.Drawing.Point(570, 395)
        Me.lblActualSpeed.Name = "lblActualSpeed"
        Me.lblActualSpeed.Size = New System.Drawing.Size(0, 18)
        Me.lblActualSpeed.TabIndex = 1
        Me.lblActualSpeed.Visible = False
        '
        'lblISpeed
        '
        Me.lblISpeed.AutoSize = True
        Me.lblISpeed.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblISpeed.Location = New System.Drawing.Point(366, 395)
        Me.lblISpeed.Name = "lblISpeed"
        Me.lblISpeed.Size = New System.Drawing.Size(186, 18)
        Me.lblISpeed.TabIndex = 2
        Me.lblISpeed.Text = "Average Internet Speed:"
        '
        'btnSpeed
        '
        Me.btnSpeed.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.btnSpeed.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSpeed.Location = New System.Drawing.Point(310, 105)
        Me.btnSpeed.Name = "btnSpeed"
        Me.btnSpeed.Size = New System.Drawing.Size(197, 40)
        Me.btnSpeed.TabIndex = 3
        Me.btnSpeed.Text = "Enter Internet Speed"
        Me.btnSpeed.UseVisualStyleBackColor = False
        '
        'lblTest
        '
        Me.lblTest.AutoSize = True
        Me.lblTest.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTest.Location = New System.Drawing.Point(267, 45)
        Me.lblTest.Name = "lblTest"
        Me.lblTest.Size = New System.Drawing.Size(394, 33)
        Me.lblTest.TabIndex = 4
        Me.lblTest.Text = "Internet Speed Test Survey"
        '
        'lstSpeed
        '
        Me.lstSpeed.FormattingEnabled = True
        Me.lstSpeed.Location = New System.Drawing.Point(561, 105)
        Me.lstSpeed.Name = "lstSpeed"
        Me.lstSpeed.Size = New System.Drawing.Size(120, 95)
        Me.lstSpeed.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.IntSpeed.My.Resources.Resources.speed
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lstSpeed)
        Me.Controls.Add(Me.lblTest)
        Me.Controls.Add(Me.btnSpeed)
        Me.Controls.Add(Me.lblISpeed)
        Me.Controls.Add(Me.lblActualSpeed)
        Me.Name = "Form1"
        Me.Text = "Internet Speed Test Survey for Home Users"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblActualSpeed As Label
    Friend WithEvents lblISpeed As Label
    Friend WithEvents btnSpeed As Button
    Friend WithEvents lblTest As Label
    Friend WithEvents lstSpeed As ListBox
End Class
