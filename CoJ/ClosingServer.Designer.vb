<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClosingServer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmClosingServer))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnShutdown = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Timershutdown = New System.Windows.Forms.Timer(Me.components)
        Me.PanelProgresBar = New System.Windows.Forms.Panel()
        Me.lblProgressBarr = New System.Windows.Forms.Label()
        Me.PanelProgresBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Playbill", 18.15652!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(2, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(454, 35)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Coj2 Dedicated Server is running!!!"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnShutdown
        '
        Me.btnShutdown.AutoSize = True
        Me.btnShutdown.BackColor = System.Drawing.Color.Firebrick
        Me.btnShutdown.Font = New System.Drawing.Font("Segoe UI", 8.139131!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShutdown.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btnShutdown.Location = New System.Drawing.Point(65, 132)
        Me.btnShutdown.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnShutdown.Name = "btnShutdown"
        Me.btnShutdown.Size = New System.Drawing.Size(139, 35)
        Me.btnShutdown.TabIndex = 29
        Me.btnShutdown.Text = "Shutdown (10s)"
        Me.btnShutdown.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.AutoSize = True
        Me.btnCancel.BackColor = System.Drawing.Color.OliveDrab
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 8.139131!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btnCancel.Location = New System.Drawing.Point(253, 132)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(139, 35)
        Me.btnCancel.TabIndex = 30
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'Timershutdown
        '
        '
        'PanelProgresBar
        '
        Me.PanelProgresBar.BackColor = System.Drawing.SystemColors.ControlLight
        Me.PanelProgresBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelProgresBar.Controls.Add(Me.lblProgressBarr)
        Me.PanelProgresBar.Location = New System.Drawing.Point(67, 88)
        Me.PanelProgresBar.Name = "PanelProgresBar"
        Me.PanelProgresBar.Size = New System.Drawing.Size(324, 19)
        Me.PanelProgresBar.TabIndex = 32
        '
        'lblProgressBarr
        '
        Me.lblProgressBarr.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.lblProgressBarr.Location = New System.Drawing.Point(0, 0)
        Me.lblProgressBarr.Name = "lblProgressBarr"
        Me.lblProgressBarr.Size = New System.Drawing.Size(51, 17)
        Me.lblProgressBarr.TabIndex = 0
        '
        'frmClosingServer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(459, 213)
        Me.Controls.Add(Me.PanelProgresBar)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnShutdown)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.139131!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(475, 252)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(475, 252)
        Me.Name = "frmClosingServer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Closing Server..."
        Me.PanelProgresBar.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnShutdown As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents Timershutdown As System.Windows.Forms.Timer
    Friend WithEvents PanelProgresBar As System.Windows.Forms.Panel
    Friend WithEvents lblProgressBarr As System.Windows.Forms.Label
End Class
