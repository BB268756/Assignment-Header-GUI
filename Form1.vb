Public Class Form1
    
    Public Sub bsSelectFontCallback(ByVal sender As Object, ByVal e As System.EventArgs) Handles bsSelectFontButton.Click
        Dim openFileDialog As New OpenFileDialog()
        
        openFileDialog.InitialDirectory = "C:\Windows\Fonts"
        openFileDialog.Filter = "Truetype Font Files (*.ttf)|*.ttf|Any (*.*)|*.*"
        openFileDialog.FilterIndex = 2
        openFileDialog.RestoreDirectory = True
        
        If openFileDialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Dim file As String = openFileDialog.FileName
            If file Is Nothing Then
                Throw new Exception("invalid file")
            End If
            bsSelectFontAddressLabel.Text = file
        End If
    End Sub
    
    Public Sub bsSelectColourCallback(ByVal sender As Object, ByVal e As System.EventArgs) Handles bsBackColourControl.Click
        Dim colourDialog As New ColorDialog()
        
        colourDialog.AllowFullOpen = True
        colourDialog.ShowHelp = True
        
        If (colourDialog.ShowDialog() = System.Windows.Forms.DialogResult.OK) Then
            Dim colour = colourDialog.Color
            bsBackColourControl.BackColor = colour
        End If
    End Sub
    
End Class
