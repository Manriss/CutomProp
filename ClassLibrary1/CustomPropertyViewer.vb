Imports System.Windows.Forms
Imports Autodesk.Navisworks.Api
Imports PropertyGridEx
Imports System.IO
Public Class CustomPropertyViewer
    Inherits UserControl
    Public Sub CuctomProp()
        InitializeComponent()

    End Sub
    Private Sub updateProp()
        Try
            ppgPropiedades.Item.Clear()

            If Not doc.CurrentSelection.IsEmpty And doc.CurrentSelection.SelectedItems.Count = 1 Then
                Dim item As ModelItem
                item = doc.CurrentSelection.SelectedItems.First 'el objeto seleccionado
                Dim cat As PropertyCategory
                For Each cat In item.PropertyCategories

                    For Each dp As DataProperty In cat.Properties
                        Dim newProp As New CustomProperty
                        newProp.Category = cat.DisplayName
                        newProp.Name = dp.DisplayName
                        newProp.Value = tiposDatoNavis(dp)
                        newProp.IsReadOnly = True
                        newProp.Visible = True
                        ppgPropiedades.Item.Add(newProp)
                    Next
                Next
                ppgPropiedades.Refresh()
            Else
                ppgPropiedades.Item.Clear()
                ppgPropiedades.Refresh()
            End If
        Catch ex As Exception
            MsgBox("Ups...algo salio mal...")
        End Try
    End Sub

    Private Sub CustomPropertyViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler doc.CurrentSelection.Changed, AddressOf updateProp
    End Sub



    Private Sub tsbAbout_Click(sender As Object, e As EventArgs) Handles tsbAbout.Click


        MsgBox("Visor de propiedades alternativo." & vbCr & "Plugin desarrollado por Manrique Gómez", vbInformation, Title:="Acerca de este plugin")
    End Sub


End Class
