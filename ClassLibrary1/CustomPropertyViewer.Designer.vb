<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CustomPropertyViewer
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CustomPropertyViewer))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ppgPropiedades = New PropertyGridEx.PropertyGridEx()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbAbout = New System.Windows.Forms.ToolStripButton()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ppgPropiedades)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(365, 603)
        Me.Panel1.TabIndex = 0
        '
        'ppgPropiedades
        '
        '
        '
        '
        Me.ppgPropiedades.DocCommentDescription.AccessibleName = ""
        Me.ppgPropiedades.DocCommentDescription.AutoEllipsis = True
        Me.ppgPropiedades.DocCommentDescription.Cursor = System.Windows.Forms.Cursors.Default
        Me.ppgPropiedades.DocCommentDescription.Location = New System.Drawing.Point(3, 18)
        Me.ppgPropiedades.DocCommentDescription.Name = ""
        Me.ppgPropiedades.DocCommentDescription.Size = New System.Drawing.Size(359, 37)
        Me.ppgPropiedades.DocCommentDescription.TabIndex = 1
        Me.ppgPropiedades.DocCommentImage = Nothing
        '
        '
        '
        Me.ppgPropiedades.DocCommentTitle.Cursor = System.Windows.Forms.Cursors.Default
        Me.ppgPropiedades.DocCommentTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.ppgPropiedades.DocCommentTitle.Location = New System.Drawing.Point(3, 3)
        Me.ppgPropiedades.DocCommentTitle.Name = ""
        Me.ppgPropiedades.DocCommentTitle.Size = New System.Drawing.Size(359, 15)
        Me.ppgPropiedades.DocCommentTitle.TabIndex = 0
        Me.ppgPropiedades.DocCommentTitle.UseMnemonic = False
        Me.ppgPropiedades.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ppgPropiedades.Location = New System.Drawing.Point(0, 0)
        Me.ppgPropiedades.Name = "ppgPropiedades"
        Me.ppgPropiedades.SelectedObject = CType(resources.GetObject("ppgPropiedades.SelectedObject"), Object)
        Me.ppgPropiedades.ShowCustomProperties = True
        Me.ppgPropiedades.Size = New System.Drawing.Size(365, 603)
        Me.ppgPropiedades.TabIndex = 0
        '
        '
        '
        Me.ppgPropiedades.ToolStrip.AccessibleName = "Barra de herramientas"
        Me.ppgPropiedades.ToolStrip.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar
        Me.ppgPropiedades.ToolStrip.AllowMerge = False
        Me.ppgPropiedades.ToolStrip.AutoSize = False
        Me.ppgPropiedades.ToolStrip.CanOverflow = False
        Me.ppgPropiedades.ToolStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.ppgPropiedades.ToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ppgPropiedades.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.tsbAbout})
        Me.ppgPropiedades.ToolStrip.Location = New System.Drawing.Point(0, 1)
        Me.ppgPropiedades.ToolStrip.Name = ""
        Me.ppgPropiedades.ToolStrip.Padding = New System.Windows.Forms.Padding(2, 0, 1, 0)
        Me.ppgPropiedades.ToolStrip.Size = New System.Drawing.Size(365, 25)
        Me.ppgPropiedades.ToolStrip.TabIndex = 1
        Me.ppgPropiedades.ToolStrip.TabStop = True
        Me.ppgPropiedades.ToolStrip.Text = "PropertyGridToolBar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'tsbAbout
        '
        Me.tsbAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbAbout.Image = Global.CustomProp.MGD.My.Resources.Resources.httpzcoolcomcnpicpngpng_7937png
        Me.tsbAbout.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbAbout.Name = "tsbAbout"
        Me.tsbAbout.Size = New System.Drawing.Size(23, 22)
        Me.tsbAbout.Text = "About"
        '
        'CustomPropertyViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Name = "CustomPropertyViewer"
        Me.Size = New System.Drawing.Size(365, 603)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Windows.Forms.Panel
    Friend WithEvents ppgPropiedades As PropertyGridEx.PropertyGridEx
    Friend WithEvents ToolStripSeparator1 As Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbAbout As Windows.Forms.ToolStripButton
End Class
