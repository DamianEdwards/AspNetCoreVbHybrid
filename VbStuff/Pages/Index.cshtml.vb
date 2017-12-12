Imports Microsoft.AspNetCore.Mvc.RazorPages

Namespace Pages

    Public Class IndexModel
        Inherits PageModel

        Public Property Message() As String

        Public Sub OnGet()
            Message = "Hello from VB PageModel"
        End Sub
    End Class

End Namespace