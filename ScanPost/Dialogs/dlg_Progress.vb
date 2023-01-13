Imports System.Windows.Forms

Public Class dlg_Progress

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub New(Location As Point)
        InitializeComponent()

        Me.StartPosition = FormStartPosition.Manual
        Me.Location = Location
    End Sub
End Class
