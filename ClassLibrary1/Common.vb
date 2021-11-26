Imports Autodesk.Navisworks.Api
Imports PropertyGridEx

Module Common
    Public doc As Document = Autodesk.Navisworks.Api.Application.ActiveDocument
    Public propList As New List(Of CustomProperty)
    ''' <summary>
    ''' Obtiene el valor de la propiedad en formato string
    ''' </summary>
    ''' <param name="dato"></param>
    ''' <returns></returns>
    Public Function tiposDatoNavis(ByVal dato As DataProperty) As String
        Try
            If dato IsNot Nothing Then
                Select Case dato.Value.DataType
                    Case VariantDataType.Boolean
                        Return dato.Value.ToBoolean.ToString
                    Case VariantDataType.DateTime
                        Return dato.Value.ToDateTime.ToString
                    Case VariantDataType.DisplayString
                        Return dato.Value.ToDisplayString
                    Case VariantDataType.Double
                        Return dato.Value.ToDouble.ToString
                    Case VariantDataType.DoubleAngle
                        Return dato.Value.ToDoubleAngle.ToString
                    Case VariantDataType.DoubleArea
                        Return dato.Value.ToDoubleArea.ToString
                    Case VariantDataType.DoubleLength
                        Return dato.Value.ToDoubleLength.ToString
                    Case VariantDataType.DoubleVolume
                        Return dato.Value.ToDoubleVolume.ToString
                    Case VariantDataType.IdentifierString
                        Return dato.Value.ToIdentifierString.ToString
                    Case VariantDataType.Int32
                        Return dato.Value.ToInt32.ToString
                    Case VariantDataType.NamedConstant
                        Return dato.Value.ToNamedConstant.ToString
                    Case VariantDataType.None
                        Return ""
                    Case VariantDataType.Point2D
                        Return dato.Value.ToPoint2D.ToString
                    Case VariantDataType.Point3D
                        Return dato.Value.ToPoint3D.ToString
                End Select
            Else
                'no he pasado un dato
                Return "La propiedad no existe"
            End If

        Catch ex As Exception
            MsgBox("ERROR en la conversion de datos" & ex.ToString)
            Return "error"
        End Try
    End Function
End Module
