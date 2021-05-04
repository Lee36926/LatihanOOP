Public Class Pelajar
    Private strNoMatrik As String
    Sub New(ByVal strNoMatrik As String)
        Me.strNoMatrik = strNoMatrik

    End Sub
    Public Function Politeknik() As String
        Dim strKodpoli As String = strNoMatrik.Substring(0, 2)

        If strKodpoli = 18 Then
            Return "PTSS"
        Else
            Return "NOT PTSS"
        End If
    End Function
    Public Function Program() As String
        Dim strKodProgram As String = strNoMatrik.Substring(2, 3)
        If strKodProgram = "DDT" Then
            Return "Diploma Teknologi Maklumat(Teknologi Digital)"
        Else
            Return "Not Diploma Teknologi Maklumat(Teknologi Digital)"
        End If
    End Function

    Public Function Ambilan() As String
        Dim strKodAmbilan As String = strNoMatrik.Substring(5, 3)
        Dim strKodTahun As String = strNoMatrik.Substring(8, 1)
        If strKodAmbilan = "19F" Then
            If strKodTahun = "1" Then
                Return "Jun 2019"
            ElseIf strKodTahun = "2" Then
                Return "Dec 2019"
            End If
        Else
            Return "Not Sesi 2019"
        End If
    End Function
End Class
