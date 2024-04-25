<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewCarForm
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
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.abortButton = New System.Windows.Forms.Button()
        Me.okButton = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.manufacturerTextBox = New System.Windows.Forms.TextBox()
        Me.modelTextBox = New System.Windows.Forms.TextBox()
        Me.powerNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.buildDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.colorTextBox = New System.Windows.Forms.TextBox()
        Me.engineComboBox = New System.Windows.Forms.ComboBox()
        Me.licencePlateMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.powerNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoSize = True
        Me.FlowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.Salmon
        Me.FlowLayoutPanel1.Controls.Add(Me.abortButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.okButton)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 447)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(612, 41)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'abortButton
        '
        Me.abortButton.AutoSize = True
        Me.abortButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.abortButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.abortButton.Location = New System.Drawing.Point(483, 3)
        Me.abortButton.Name = "abortButton"
        Me.abortButton.Size = New System.Drawing.Size(126, 35)
        Me.abortButton.TabIndex = 0
        Me.abortButton.Text = "Abbrechen"
        Me.abortButton.UseVisualStyleBackColor = True
        '
        'okButton
        '
        Me.okButton.AutoSize = True
        Me.okButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.okButton.Location = New System.Drawing.Point(361, 3)
        Me.okButton.Name = "okButton"
        Me.okButton.Padding = New System.Windows.Forms.Padding(32, 0, 32, 0)
        Me.okButton.Size = New System.Drawing.Size(116, 35)
        Me.okButton.TabIndex = 1
        Me.okButton.Text = "OK"
        Me.okButton.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.Label7, 0, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.manufacturerTextBox, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.modelTextBox, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.powerNumericUpDown, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.buildDateTimePicker, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.colorTextBox, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.engineComboBox, 1, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.licencePlateMaskedTextBox, 1, 7)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 37)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 9
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(612, 410)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Manufacturer"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Model"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(135, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Power in KW"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 137)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 25)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "BuildDate"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 174)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 25)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Color"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 212)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(120, 25)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Enginetype"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 247)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(140, 25)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Licence plate"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(0, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(142, 37)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "New Car"
        '
        'manufacturerTextBox
        '
        Me.manufacturerTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.manufacturerTextBox.Location = New System.Drawing.Point(149, 23)
        Me.manufacturerTextBox.Name = "manufacturerTextBox"
        Me.manufacturerTextBox.Size = New System.Drawing.Size(460, 31)
        Me.manufacturerTextBox.TabIndex = 7
        '
        'modelTextBox
        '
        Me.modelTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.modelTextBox.Location = New System.Drawing.Point(149, 60)
        Me.modelTextBox.Name = "modelTextBox"
        Me.modelTextBox.Size = New System.Drawing.Size(460, 31)
        Me.modelTextBox.TabIndex = 8
        '
        'powerNumericUpDown
        '
        Me.powerNumericUpDown.Dock = System.Windows.Forms.DockStyle.Fill
        Me.powerNumericUpDown.Location = New System.Drawing.Point(149, 97)
        Me.powerNumericUpDown.Name = "powerNumericUpDown"
        Me.powerNumericUpDown.Size = New System.Drawing.Size(460, 31)
        Me.powerNumericUpDown.TabIndex = 9
        '
        'buildDateTimePicker
        '
        Me.buildDateTimePicker.Dock = System.Windows.Forms.DockStyle.Fill
        Me.buildDateTimePicker.Location = New System.Drawing.Point(149, 134)
        Me.buildDateTimePicker.Name = "buildDateTimePicker"
        Me.buildDateTimePicker.Size = New System.Drawing.Size(460, 31)
        Me.buildDateTimePicker.TabIndex = 10
        '
        'colorTextBox
        '
        Me.colorTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.colorTextBox.Location = New System.Drawing.Point(149, 171)
        Me.colorTextBox.Name = "colorTextBox"
        Me.colorTextBox.Size = New System.Drawing.Size(460, 31)
        Me.colorTextBox.TabIndex = 11
        '
        'engineComboBox
        '
        Me.engineComboBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.engineComboBox.FormattingEnabled = True
        Me.engineComboBox.Location = New System.Drawing.Point(149, 208)
        Me.engineComboBox.Name = "engineComboBox"
        Me.engineComboBox.Size = New System.Drawing.Size(460, 33)
        Me.engineComboBox.TabIndex = 12
        '
        'licencePlateMaskedTextBox
        '
        Me.licencePlateMaskedTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.licencePlateMaskedTextBox.Location = New System.Drawing.Point(146, 244)
        Me.licencePlateMaskedTextBox.Margin = New System.Windows.Forms.Padding(0, 0, 0, 0)
        Me.licencePlateMaskedTextBox.Mask = "aaA-aaA ###0"
        Me.licencePlateMaskedTextBox.Name = "licencePlateMaskedTextBox"
        Me.licencePlateMaskedTextBox.Size = New System.Drawing.Size(466, 31)
        Me.licencePlateMaskedTextBox.TabIndex = 13
        '
        'NewCarForm
        '
        Me.AcceptButton = Me.okButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.abortButton
        Me.ClientSize = New System.Drawing.Size(612, 488)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Name = "NewCarForm"
        Me.Text = "New Car"
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.powerNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents abortButton As Button
    Friend WithEvents okButton As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents manufacturerTextBox As TextBox
    Friend WithEvents modelTextBox As TextBox
    Friend WithEvents powerNumericUpDown As NumericUpDown
    Friend WithEvents buildDateTimePicker As DateTimePicker
    Friend WithEvents colorTextBox As TextBox
    Friend WithEvents engineComboBox As ComboBox
    Friend WithEvents licencePlateMaskedTextBox As MaskedTextBox
End Class
