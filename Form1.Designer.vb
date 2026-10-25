Imports Assignment_Header_GUI.NativeHandler

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form
    
    Friend toolstrip As TabControl = New TabControl()
    Friend basicSettings As TabPage = New TabPage("Basic Settings")
    Friend texts As TabPage = New TabPage("Texts")
    Friend images As TabPage = New TabPage("Images")
    Friend finals As TabPage = New TabPage("Final")
    
    ' basic settings
    Friend bsWidthLabel As Label = New Label()
    Friend bsWidthControl As NumericUpDown = New NumericUpDown()
    
    Friend bsHeightLabel As Label = New Label()
    Friend bsHeightControl As NumericUpDown = New NumericUpDown()
    
    Friend bsBackColourLabel As Label = New Label()
    Friend WithEvents bsBackColourControl As Button = New Button()
    
    Friend WithEvents bsSelectFontButton As Button = New Button()
    Friend bsSelectFontAddressLabel As Label = New Label() 

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
        components = New System.ComponentModel.Container()
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Text = "Assignment Header GUI"
        
        Toolstrip.Location = New System.Drawing.Point(0,0)
        Toolstrip.Size = New Size(Me.Width - 10,Me.Height)
        Toolstrip.TabIndex = 0
        Toolstrip.Visible = True
        
        bsWidthLabel.Text = "Width:"
        bsWidthLabel.Location = New Point(bsWidthLabel.Location.X, bsWidthLabel.Location.Y + 2)
        bsWidthControl.ThousandsSeparator = True
        bsWidthControl.Increment = 1
        bsWidthControl.DecimalPlaces = 0
        bsWidthControl.Location = New Point(bsWidthControl.Size.Width + 5,bsWidthControl.Location.Y)
        bsWidthControl.Minimum = 1
        bsWidthControl.Maximum = 1000000000000000000
        bsWidthControl.Value = 2500
        
        bsHeightLabel.Text = "Height:"
        bsHeightLabel.Location = New Point(bsWidthLabel.Location.X, bsWidthLabel.Location.Y + 52)
        bsHeightControl.ThousandsSeparator = True
        bsHeightControl.Increment = 1
        bsHeightControl.DecimalPlaces = 0
        bsHeightControl.Location = New Point(bsWidthControl.Size.Width + 5,bsWidthControl.Location.Y + 50)
        bsHeightControl.Minimum = 1
        bsHeightControl.Maximum = 1000000000000000000
        bsHeightControl.Value = 250
        
        bsSelectFontButton.Text = "Font"
        bsSelectFontButton.Location = New Point(bsSelectFontButton.Location.X, bsSelectFontButton.Location.Y + 102)
        
        bsSelectFontAddressLabel.Text = "not selected"
        bsSelectFontAddressLabel.Location = New Point(bsSelectFontAddressLabel.Location.X, bsSelectFontAddressLabel.Location.Y + 122)
        bsSelectFontAddressLabel.Width = Me.Width
        
        bsBackColourLabel.Text = "Colour:"
        bsBackColourLabel.Location = New Point(bsWidthLabel.Location.X, bsWidthLabel.Location.Y + 152)
        
        bsBackColourControl.Text = "Select Colour"
        bsBackColourControl.Location = New Point(bsBackColourControl.Location.X + bsBackColourLabel.Width + 10, bsBackColourControl.Location.Y + 152)
        
        basicSettings.Controls.Add(bsWidthLabel)
        basicSettings.Controls.Add(bsWidthControl)
        
        basicSettings.Controls.Add(bsHeightLabel)
        basicSettings.Controls.Add(bsHeightControl)
        
        basicSettings.Controls.Add(bsSelectFontButton)
        basicSettings.Controls.Add(bsSelectFontAddressLabel)
        
        basicSettings.Controls.Add(bsBackColourLabel)
        basicSettings.Controls.Add(bsBackColourControl)
        
        Me.Controls.Add(Toolstrip)
        
        Toolstrip.Controls.Add(basicSettings)
        Toolstrip.Controls.Add(texts)
        Toolstrip.Controls.Add(images)
        Toolstrip.Controls.Add(finals)
        
        Dim backcolour As Colour
        backcolour = New Colour With {
            .red = 100,
            .green = 100,
            .blue = 100
            }
        
        AbstractGenerator(Nothing, 0, Nothing, 0, 1920,1080,3, backcolour,"[FONT FILE]",".netified")
    End Sub
End Class
