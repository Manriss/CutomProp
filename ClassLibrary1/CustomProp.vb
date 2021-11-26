'------------------------------------------------------------------


Option Explicit On
#Region "DockingPanel"
Imports System.Windows.Forms
Imports Autodesk.Navisworks.Api.Plugins
Imports Autodesk.Navisworks.Api
Imports Autodesk.Navisworks.Api.DocumentParts
Imports System.Diagnostics
Imports System.IO

<PluginAttribute(
                "Propiedades",
                 "MGD",
                 ToolTip:="Visor de propiedades, Manrique Gómez",
                ExtendedToolTip:="extended",
                 DisplayName:="VISOR PROPIEDADES (v01.00) Navisworks2019 MGD")>
<DockPanePlugin(
250, 500, AutoScroll:=True, FixedSize:=False, MinimumHeight:=500, MinimumWidth:=250)>
Public Class CustomProp
    Inherits DockPanePlugin

    Public Overrides Function CreateControlPane() As Control

        Dim formulario As New CustomPropertyViewer
        formulario.Dock = DockStyle.Fill
        formulario.Text = "Propiedades"
        formulario.CreateControl()
        Return formulario
    End Function
    Public Overrides Sub DestroyControlPane(pane As Control)
        pane.Dispose()
    End Sub



End Class
#End Region
