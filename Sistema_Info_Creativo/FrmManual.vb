Public Class FrmManual
    Private Sub FrmManual_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim filePath As String = "C:\Users\Hector Said Obando\OneDrive\Documentos\2PAC2023\Implantacion\AVANCE-12-07-INFOCREATIVOS\manual.rtf" ' Ruta y nombre del documento de Word

        If System.IO.File.Exists(filePath) Then
            RichTextBox1.LoadFile(filePath, RichTextBoxStreamType.RichText)
            RichTextBox1.ReadOnly = True
        Else
            RichTextBox1.Text = "El archivo no se encontró."
        End If
    End Sub
End Class