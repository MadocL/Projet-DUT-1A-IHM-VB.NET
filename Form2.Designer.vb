'Projet IHM : application d'annotation et de reconnaissance de visages
'Mars-Mai 2020
'LEFEVRE Madoc & BORRA Camille TP 2C



<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PageAide
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PageAide))
        Me.LabelAide = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TextBoxAnnotation = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TextBoxRecherche = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBoxExemple = New System.Windows.Forms.PictureBox()
        Me.ButtonQtAide = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBoxExemple, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelAide
        '
        Me.LabelAide.AutoEllipsis = True
        Me.LabelAide.Location = New System.Drawing.Point(211, 14)
        Me.LabelAide.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelAide.Name = "LabelAide"
        Me.LabelAide.Size = New System.Drawing.Size(113, 46)
        Me.LabelAide.TabIndex = 0
        Me.LabelAide.Text = "Aide "
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TextBoxAnnotation)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(214, 77)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(280, 108)
        Me.Panel1.TabIndex = 1
        '
        'TextBoxAnnotation
        '
        Me.TextBoxAnnotation.Enabled = False
        Me.TextBoxAnnotation.Location = New System.Drawing.Point(0, 15)
        Me.TextBoxAnnotation.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TextBoxAnnotation.Multiline = True
        Me.TextBoxAnnotation.Name = "TextBoxAnnotation"
        Me.TextBoxAnnotation.Size = New System.Drawing.Size(281, 90)
        Me.TextBoxAnnotation.TabIndex = 6
        Me.TextBoxAnnotation.Text = resources.GetString("TextBoxAnnotation.Text")
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(2, 51)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 13)
        Me.Label4.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(83, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Pour annoter un visage"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.TextBoxRecherche)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Location = New System.Drawing.Point(214, 200)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(280, 79)
        Me.Panel2.TabIndex = 2
        '
        'TextBoxRecherche
        '
        Me.TextBoxRecherche.Enabled = False
        Me.TextBoxRecherche.Location = New System.Drawing.Point(0, 15)
        Me.TextBoxRecherche.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TextBoxRecherche.Multiline = True
        Me.TextBoxRecherche.Name = "TextBoxRecherche"
        Me.TextBoxRecherche.Size = New System.Drawing.Size(281, 63)
        Me.TextBoxRecherche.TabIndex = 6
        Me.TextBoxRecherche.Text = "1) Chargez la photo prealablement annoté de votre choix" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "2) Annotez la photo ou c" &
    "hargez des annotations sauvegardées" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "3) Appuyez sur ""Chercher un visage proche""" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(5, 45)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(218, 13)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "2) Appuyez sur ""Chercher un visage proche"""
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(2, 27)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(274, 13)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "1) Chargez la photo prealablement annoté de votre choix"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(50, 0)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(182, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Pour chercher un visage ressemblant"
        '
        'PictureBoxExemple
        '
        Me.PictureBoxExemple.Location = New System.Drawing.Point(8, 77)
        Me.PictureBoxExemple.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PictureBoxExemple.Name = "PictureBoxExemple"
        Me.PictureBoxExemple.Size = New System.Drawing.Size(174, 196)
        Me.PictureBoxExemple.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxExemple.TabIndex = 4
        Me.PictureBoxExemple.TabStop = False
        '
        'ButtonQtAide
        '
        Me.ButtonQtAide.Location = New System.Drawing.Point(409, 298)
        Me.ButtonQtAide.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ButtonQtAide.Name = "ButtonQtAide"
        Me.ButtonQtAide.Size = New System.Drawing.Size(79, 20)
        Me.ButtonQtAide.TabIndex = 5
        Me.ButtonQtAide.Text = "Quitter l'aide"
        Me.ButtonQtAide.UseVisualStyleBackColor = True
        '
        'PageAide
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(531, 341)
        Me.Controls.Add(Me.ButtonQtAide)
        Me.Controls.Add(Me.PictureBoxExemple)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.LabelAide)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "PageAide"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Aide"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBoxExemple, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LabelAide As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBoxExemple As PictureBox
    Friend WithEvents ButtonQtAide As Button
    Friend WithEvents TextBoxAnnotation As TextBox
    Friend WithEvents TextBoxRecherche As TextBox
End Class
