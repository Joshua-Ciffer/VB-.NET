﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
		Me.TabControl1 = New System.Windows.Forms.TabControl()
		Me.TabPage1 = New System.Windows.Forms.TabPage()
		Me.TabPage2 = New System.Windows.Forms.TabPage()
		Me.TabPage3 = New System.Windows.Forms.TabPage()
		Me.TabControl1.SuspendLayout()
		Me.SuspendLayout()
		'
		'TabControl1
		'
		Me.TabControl1.Controls.Add(Me.TabPage1)
		Me.TabControl1.Controls.Add(Me.TabPage2)
		Me.TabControl1.Controls.Add(Me.TabPage3)
		Me.TabControl1.Location = New System.Drawing.Point(0, 0)
		Me.TabControl1.Name = "TabControl1"
		Me.TabControl1.SelectedIndex = 0
		Me.TabControl1.Size = New System.Drawing.Size(2143, 1048)
		Me.TabControl1.TabIndex = 0
		'
		'TabPage1
		'
		Me.TabPage1.Location = New System.Drawing.Point(10, 48)
		Me.TabPage1.Name = "TabPage1"
		Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
		Me.TabPage1.Size = New System.Drawing.Size(2123, 990)
		Me.TabPage1.TabIndex = 0
		Me.TabPage1.Text = "Customer Info"
		Me.TabPage1.UseVisualStyleBackColor = True
		'
		'TabPage2
		'
		Me.TabPage2.Location = New System.Drawing.Point(10, 48)
		Me.TabPage2.Name = "TabPage2"
		Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
		Me.TabPage2.Size = New System.Drawing.Size(2123, 845)
		Me.TabPage2.TabIndex = 1
		Me.TabPage2.Text = "Home Options"
		Me.TabPage2.UseVisualStyleBackColor = True
		'
		'TabPage3
		'
		Me.TabPage3.Location = New System.Drawing.Point(10, 48)
		Me.TabPage3.Name = "TabPage3"
		Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
		Me.TabPage3.Size = New System.Drawing.Size(2123, 845)
		Me.TabPage3.TabIndex = 2
		Me.TabPage3.Text = "Summary"
		Me.TabPage3.UseVisualStyleBackColor = True
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(2155, 1047)
		Me.Controls.Add(Me.TabControl1)
		Me.Name = "Form1"
		Me.Text = "Form1"
		Me.TabControl1.ResumeLayout(False)
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents TabControl1 As TabControl
	Friend WithEvents TabPage1 As TabPage
	Friend WithEvents TabPage2 As TabPage
	Friend WithEvents TabPage3 As TabPage
End Class