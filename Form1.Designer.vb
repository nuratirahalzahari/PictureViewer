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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.showButton = New System.Windows.Forms.Button()
        Me.Clearbtn = New System.Windows.Forms.Button()
        Me.Backgroundbtn = New System.Windows.Forms.Button()
        Me.Closebtn = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.07692!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.92308!))
        Me.TableLayoutPanel1.Controls.Add(Me.PictureBox1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.CheckBox1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.FlowLayoutPanel1, 1, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(873, 543)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TableLayoutPanel1.SetColumnSpan(Me.PictureBox1, 2)
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(867, 482)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(3, 491)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(70, 20)
        Me.CheckBox1.TabIndex = 1
        Me.CheckBox1.Text = "Stretch"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.Closebtn)
        Me.FlowLayoutPanel1.Controls.Add(Me.Backgroundbtn)
        Me.FlowLayoutPanel1.Controls.Add(Me.Clearbtn)
        Me.FlowLayoutPanel1.Controls.Add(Me.showButton)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(204, 491)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(666, 49)
        Me.FlowLayoutPanel1.TabIndex = 2
        '
        'showButton
        '
        Me.showButton.AutoSize = True
        Me.showButton.Location = New System.Drawing.Point(478, 3)
        Me.showButton.Name = "showButton"
        Me.showButton.Size = New System.Drawing.Size(161, 26)
        Me.showButton.TabIndex = 0
        Me.showButton.Text = "Show a picture"
        Me.showButton.UseVisualStyleBackColor = True
        '
        'Clearbtn
        '
        Me.Clearbtn.AutoSize = True
        Me.Clearbtn.Location = New System.Drawing.Point(329, 3)
        Me.Clearbtn.Name = "Clearbtn"
        Me.Clearbtn.Size = New System.Drawing.Size(143, 26)
        Me.Clearbtn.TabIndex = 1
        Me.Clearbtn.Text = "Clear the picture"
        Me.Clearbtn.UseVisualStyleBackColor = True
        '
        'Backgroundbtn
        '
        Me.Backgroundbtn.AutoSize = True
        Me.Backgroundbtn.Location = New System.Drawing.Point(141, 3)
        Me.Backgroundbtn.Name = "Backgroundbtn"
        Me.Backgroundbtn.Size = New System.Drawing.Size(182, 26)
        Me.Backgroundbtn.TabIndex = 2
        Me.Backgroundbtn.Text = "Set the background color"
        Me.Backgroundbtn.UseVisualStyleBackColor = True
        '
        'Closebtn
        '
        Me.Closebtn.AutoSize = True
        Me.Closebtn.Location = New System.Drawing.Point(3, 3)
        Me.Closebtn.Name = "Closebtn"
        Me.Closebtn.Size = New System.Drawing.Size(132, 26)
        Me.Closebtn.TabIndex = 3
        Me.Closebtn.Text = "Close"
        Me.Closebtn.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Filter = "JPEG Files (.jpg)|.jpg|PNG Files (.png)|.png|BMP Files (.bmp)|.bmp|All files (.)|" &
    "."
        Me.OpenFileDialog1.Title = "Select a picture file"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(873, 543)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "Form1"
        Me.Text = "Picture Viewer"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Closebtn As Button
    Friend WithEvents Backgroundbtn As Button
    Friend WithEvents Clearbtn As Button
    Friend WithEvents showButton As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents ColorDialog1 As ColorDialog
End Class
