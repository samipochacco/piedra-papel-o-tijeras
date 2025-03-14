<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Label1 = New Label()
        LabelResultado = New Label()
        LabelElecciónComputadora = New Label()
        btnpiedra = New Button()
        btnpapel = New Button()
        btnmachete = New Button()
        LabelRachavictorias = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Showcard Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(36, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(503, 35)
        Label1.TabIndex = 0
        Label1.Text = "Piedra,Papel o Machete Esencial"
        ' 
        ' LabelResultado
        ' 
        LabelResultado.AutoSize = True
        LabelResultado.Font = New Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LabelResultado.Location = New Point(36, 59)
        LabelResultado.Name = "LabelResultado"
        LabelResultado.Size = New Size(214, 26)
        LabelResultado.TabIndex = 1
        LabelResultado.Text = "Ganaste o Perdiste"
        ' 
        ' LabelElecciónComputadora
        ' 
        LabelElecciónComputadora.AutoSize = True
        LabelElecciónComputadora.Font = New Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LabelElecciónComputadora.Location = New Point(201, 452)
        LabelElecciónComputadora.Name = "LabelElecciónComputadora"
        LabelElecciónComputadora.Size = New Size(466, 26)
        LabelElecciónComputadora.TabIndex = 2
        LabelElecciónComputadora.Text = "Resultado de Elección de la Computadora"
        ' 
        ' btnpiedra
        ' 
        btnpiedra.BackgroundImage = My.Resources.Resources.puño_anime
        btnpiedra.BackgroundImageLayout = ImageLayout.Stretch
        btnpiedra.Location = New Point(145, 297)
        btnpiedra.Name = "btnpiedra"
        btnpiedra.Size = New Size(158, 134)
        btnpiedra.TabIndex = 3
        btnpiedra.UseVisualStyleBackColor = True
        ' 
        ' btnpapel
        ' 
        btnpapel.BackgroundImage = My.Resources.Resources.papel_de_baño
        btnpapel.BackgroundImageLayout = ImageLayout.Stretch
        btnpapel.Location = New Point(369, 297)
        btnpapel.Name = "btnpapel"
        btnpapel.Size = New Size(158, 134)
        btnpapel.TabIndex = 4
        btnpapel.UseVisualStyleBackColor = True
        ' 
        ' btnmachete
        ' 
        btnmachete.BackgroundImage = CType(resources.GetObject("btnmachete.BackgroundImage"), Image)
        btnmachete.BackgroundImageLayout = ImageLayout.Stretch
        btnmachete.Location = New Point(590, 297)
        btnmachete.Name = "btnmachete"
        btnmachete.Size = New Size(158, 134)
        btnmachete.TabIndex = 5
        btnmachete.UseVisualStyleBackColor = True
        ' 
        ' LabelRachavictorias
        ' 
        LabelRachavictorias.AutoSize = True
        LabelRachavictorias.Font = New Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LabelRachavictorias.Location = New Point(819, 109)
        LabelRachavictorias.Name = "LabelRachavictorias"
        LabelRachavictorias.Size = New Size(78, 26)
        LabelRachavictorias.TabIndex = 6
        LabelRachavictorias.Text = "Racha"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.koku_5
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(953, 548)
        Controls.Add(LabelRachavictorias)
        Controls.Add(btnmachete)
        Controls.Add(btnpapel)
        Controls.Add(btnpiedra)
        Controls.Add(LabelElecciónComputadora)
        Controls.Add(LabelResultado)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents LabelResultado As Label
    Friend WithEvents LabelElecciónComputadora As Label
    Friend WithEvents btnpiedra As Button
    Friend WithEvents btnpapel As Button
    Friend WithEvents btnmachete As Button
    Friend WithEvents LabelRachavictorias As Label

End Class
