'Projet IHM : application d'annotation et de reconnaissance de visages
'Mars-Mai 2020
'LEFEVRE Madoc & BORRA Camille TP 2C


<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PagePrincipale
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
        Me.btnChar = New System.Windows.Forms.Button()
        Me.btnEnr = New System.Windows.Forms.Button()
        Me.btnAff = New System.Windows.Forms.Button()
        Me.btnAide = New System.Windows.Forms.Button()
        Me.panelReco = New System.Windows.Forms.Panel()
        Me.lblTitrePhotoRessemblante = New System.Windows.Forms.Label()
        Me.lblPhotoRessemblante = New System.Windows.Forms.Label()
        Me.btnCher = New System.Windows.Forms.Button()
        Me.btnCharAn = New System.Windows.Forms.Button()
        Me.btnSupAn = New System.Windows.Forms.Button()
        Me.pbImage = New System.Windows.Forms.PictureBox()
        Me.pnlVis = New System.Windows.Forms.Panel()
        Me.pnlAnnotRapid = New System.Windows.Forms.Panel()
        Me.btnStopAnnotRapid = New System.Windows.Forms.Button()
        Me.lblAnnotRapid = New System.Windows.Forms.Label()
        Me.btnAnnotRapid = New System.Windows.Forms.Button()
        Me.lblTitreAnnot = New System.Windows.Forms.Label()
        Me.btnBNG = New System.Windows.Forms.Button()
        Me.btnBVG = New System.Windows.Forms.Button()
        Me.btnBM = New System.Windows.Forms.Button()
        Me.btnLD = New System.Windows.Forms.Button()
        Me.btnLG = New System.Windows.Forms.Button()
        Me.btnBND = New System.Windows.Forms.Button()
        Me.btnBL = New System.Windows.Forms.Button()
        Me.btnY1 = New System.Windows.Forms.Button()
        Me.btnBVD = New System.Windows.Forms.Button()
        Me.btnBN = New System.Windows.Forms.Button()
        Me.btnY2 = New System.Windows.Forms.Button()
        Me.btnLH = New System.Windows.Forms.Button()
        Me.pnlImgEtAnnot = New System.Windows.Forms.Panel()
        Me.panelReco.SuspendLayout()
        CType(Me.pbImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlVis.SuspendLayout()
        Me.pnlAnnotRapid.SuspendLayout()
        Me.pnlImgEtAnnot.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnChar
        '
        Me.btnChar.Location = New System.Drawing.Point(12, 8)
        Me.btnChar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnChar.Name = "btnChar"
        Me.btnChar.Size = New System.Drawing.Size(150, 25)
        Me.btnChar.TabIndex = 1
        Me.btnChar.Text = "Charger une image"
        Me.btnChar.UseVisualStyleBackColor = True
        '
        'btnEnr
        '
        Me.btnEnr.Location = New System.Drawing.Point(203, 8)
        Me.btnEnr.Margin = New System.Windows.Forms.Padding(2)
        Me.btnEnr.Name = "btnEnr"
        Me.btnEnr.Size = New System.Drawing.Size(150, 25)
        Me.btnEnr.TabIndex = 0
        Me.btnEnr.Text = "Enregistrer les données "
        Me.btnEnr.UseVisualStyleBackColor = True
        '
        'btnAff
        '
        Me.btnAff.Location = New System.Drawing.Point(389, 8)
        Me.btnAff.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAff.Name = "btnAff"
        Me.btnAff.Size = New System.Drawing.Size(150, 25)
        Me.btnAff.TabIndex = 3
        Me.btnAff.Text = "Changer mode d'affichage"
        Me.btnAff.UseVisualStyleBackColor = True
        '
        'btnAide
        '
        Me.btnAide.Cursor = System.Windows.Forms.Cursors.Help
        Me.btnAide.Location = New System.Drawing.Point(574, 8)
        Me.btnAide.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAide.Name = "btnAide"
        Me.btnAide.Size = New System.Drawing.Size(150, 25)
        Me.btnAide.TabIndex = 4
        Me.btnAide.Text = "Aide"
        Me.btnAide.UseVisualStyleBackColor = True
        '
        'panelReco
        '
        Me.panelReco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelReco.Controls.Add(Me.lblTitrePhotoRessemblante)
        Me.panelReco.Controls.Add(Me.lblPhotoRessemblante)
        Me.panelReco.Controls.Add(Me.btnCher)
        Me.panelReco.Location = New System.Drawing.Point(396, 38)
        Me.panelReco.Margin = New System.Windows.Forms.Padding(2)
        Me.panelReco.Name = "panelReco"
        Me.panelReco.Size = New System.Drawing.Size(328, 129)
        Me.panelReco.TabIndex = 5
        '
        'lblTitrePhotoRessemblante
        '
        Me.lblTitrePhotoRessemblante.Location = New System.Drawing.Point(3, 0)
        Me.lblTitrePhotoRessemblante.Name = "lblTitrePhotoRessemblante"
        Me.lblTitrePhotoRessemblante.Size = New System.Drawing.Size(320, 18)
        Me.lblTitrePhotoRessemblante.TabIndex = 2
        Me.lblTitrePhotoRessemblante.Text = "Reconnaître un visage"
        Me.lblTitrePhotoRessemblante.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPhotoRessemblante
        '
        Me.lblPhotoRessemblante.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPhotoRessemblante.Location = New System.Drawing.Point(7, 23)
        Me.lblPhotoRessemblante.Name = "lblPhotoRessemblante"
        Me.lblPhotoRessemblante.Size = New System.Drawing.Size(311, 64)
        Me.lblPhotoRessemblante.TabIndex = 1
        '
        'btnCher
        '
        Me.btnCher.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnCher.Location = New System.Drawing.Point(90, 91)
        Me.btnCher.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCher.Name = "btnCher"
        Me.btnCher.Size = New System.Drawing.Size(150, 25)
        Me.btnCher.TabIndex = 0
        Me.btnCher.Text = "Chercher un visage proche"
        Me.btnCher.UseVisualStyleBackColor = True
        '
        'btnCharAn
        '
        Me.btnCharAn.Location = New System.Drawing.Point(6, 33)
        Me.btnCharAn.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCharAn.Name = "btnCharAn"
        Me.btnCharAn.Size = New System.Drawing.Size(150, 25)
        Me.btnCharAn.TabIndex = 18
        Me.btnCharAn.Text = "Charger des annotations"
        Me.btnCharAn.UseVisualStyleBackColor = True
        '
        'btnSupAn
        '
        Me.btnSupAn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSupAn.Location = New System.Drawing.Point(173, 33)
        Me.btnSupAn.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSupAn.Name = "btnSupAn"
        Me.btnSupAn.Size = New System.Drawing.Size(150, 25)
        Me.btnSupAn.TabIndex = 19
        Me.btnSupAn.Text = "Retirer les annotations"
        Me.btnSupAn.UseVisualStyleBackColor = True
        '
        'pbImage
        '
        Me.pbImage.BackColor = System.Drawing.Color.White
        Me.pbImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbImage.Cursor = System.Windows.Forms.Cursors.Cross
        Me.pbImage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbImage.Location = New System.Drawing.Point(0, 0)
        Me.pbImage.Margin = New System.Windows.Forms.Padding(2)
        Me.pbImage.Name = "pbImage"
        Me.pbImage.Size = New System.Drawing.Size(378, 504)
        Me.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbImage.TabIndex = 20
        Me.pbImage.TabStop = False
        '
        'pnlVis
        '
        Me.pnlVis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlVis.Controls.Add(Me.pnlAnnotRapid)
        Me.pnlVis.Controls.Add(Me.lblTitreAnnot)
        Me.pnlVis.Controls.Add(Me.btnBNG)
        Me.pnlVis.Controls.Add(Me.btnBVG)
        Me.pnlVis.Controls.Add(Me.btnBM)
        Me.pnlVis.Controls.Add(Me.btnLD)
        Me.pnlVis.Controls.Add(Me.btnLG)
        Me.pnlVis.Controls.Add(Me.btnBND)
        Me.pnlVis.Controls.Add(Me.btnBL)
        Me.pnlVis.Controls.Add(Me.btnY1)
        Me.pnlVis.Controls.Add(Me.btnBVD)
        Me.pnlVis.Controls.Add(Me.btnBN)
        Me.pnlVis.Controls.Add(Me.btnY2)
        Me.pnlVis.Controls.Add(Me.btnLH)
        Me.pnlVis.Controls.Add(Me.btnCharAn)
        Me.pnlVis.Controls.Add(Me.btnSupAn)
        Me.pnlVis.Location = New System.Drawing.Point(396, 172)
        Me.pnlVis.Name = "pnlVis"
        Me.pnlVis.Size = New System.Drawing.Size(328, 370)
        Me.pnlVis.TabIndex = 21
        '
        'pnlAnnotRapid
        '
        Me.pnlAnnotRapid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlAnnotRapid.Controls.Add(Me.btnStopAnnotRapid)
        Me.pnlAnnotRapid.Controls.Add(Me.lblAnnotRapid)
        Me.pnlAnnotRapid.Controls.Add(Me.btnAnnotRapid)
        Me.pnlAnnotRapid.Location = New System.Drawing.Point(3, 71)
        Me.pnlAnnotRapid.Name = "pnlAnnotRapid"
        Me.pnlAnnotRapid.Size = New System.Drawing.Size(320, 45)
        Me.pnlAnnotRapid.TabIndex = 34
        '
        'btnStopAnnotRapid
        '
        Me.btnStopAnnotRapid.Location = New System.Drawing.Point(3, 10)
        Me.btnStopAnnotRapid.Name = "btnStopAnnotRapid"
        Me.btnStopAnnotRapid.Size = New System.Drawing.Size(131, 25)
        Me.btnStopAnnotRapid.TabIndex = 35
        Me.btnStopAnnotRapid.Text = "Arrêter"
        Me.btnStopAnnotRapid.UseVisualStyleBackColor = True
        Me.btnStopAnnotRapid.Visible = False
        '
        'lblAnnotRapid
        '
        Me.lblAnnotRapid.Location = New System.Drawing.Point(140, 3)
        Me.lblAnnotRapid.Name = "lblAnnotRapid"
        Me.lblAnnotRapid.Size = New System.Drawing.Size(170, 36)
        Me.lblAnnotRapid.TabIndex = 34
        Me.lblAnnotRapid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnAnnotRapid
        '
        Me.btnAnnotRapid.Location = New System.Drawing.Point(3, 10)
        Me.btnAnnotRapid.Name = "btnAnnotRapid"
        Me.btnAnnotRapid.Size = New System.Drawing.Size(131, 25)
        Me.btnAnnotRapid.TabIndex = 33
        Me.btnAnnotRapid.Text = "Annotation rapide"
        Me.btnAnnotRapid.UseVisualStyleBackColor = True
        '
        'lblTitreAnnot
        '
        Me.lblTitreAnnot.Location = New System.Drawing.Point(0, 0)
        Me.lblTitreAnnot.Name = "lblTitreAnnot"
        Me.lblTitreAnnot.Size = New System.Drawing.Size(328, 18)
        Me.lblTitreAnnot.TabIndex = 32
        Me.lblTitreAnnot.Text = "Annoter le visage"
        Me.lblTitreAnnot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnBNG
        '
        Me.btnBNG.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnBNG.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnBNG.Location = New System.Drawing.Point(4, 152)
        Me.btnBNG.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBNG.Name = "btnBNG"
        Me.btnBNG.Size = New System.Drawing.Size(120, 27)
        Me.btnBNG.TabIndex = 27
        Me.btnBNG.Text = "Bord Nez Gauche"
        Me.btnBNG.UseVisualStyleBackColor = False
        '
        'btnBVG
        '
        Me.btnBVG.BackColor = System.Drawing.Color.Fuchsia
        Me.btnBVG.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnBVG.Location = New System.Drawing.Point(4, 214)
        Me.btnBVG.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBVG.Name = "btnBVG"
        Me.btnBVG.Size = New System.Drawing.Size(120, 27)
        Me.btnBVG.TabIndex = 31
        Me.btnBVG.Text = "Bord Visage Gauche"
        Me.btnBVG.UseVisualStyleBackColor = False
        '
        'btnBM
        '
        Me.btnBM.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnBM.Location = New System.Drawing.Point(101, 245)
        Me.btnBM.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBM.Name = "btnBM"
        Me.btnBM.Size = New System.Drawing.Size(120, 27)
        Me.btnBM.TabIndex = 26
        Me.btnBM.Text = "Bas Menton"
        Me.btnBM.UseVisualStyleBackColor = False
        '
        'btnLD
        '
        Me.btnLD.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.btnLD.Location = New System.Drawing.Point(201, 307)
        Me.btnLD.Margin = New System.Windows.Forms.Padding(2)
        Me.btnLD.Name = "btnLD"
        Me.btnLD.Size = New System.Drawing.Size(120, 27)
        Me.btnLD.TabIndex = 20
        Me.btnLD.Text = "Droite Lèvres"
        Me.btnLD.UseVisualStyleBackColor = False
        '
        'btnLG
        '
        Me.btnLG.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnLG.Location = New System.Drawing.Point(4, 307)
        Me.btnLG.Margin = New System.Windows.Forms.Padding(2)
        Me.btnLG.Name = "btnLG"
        Me.btnLG.Size = New System.Drawing.Size(120, 27)
        Me.btnLG.TabIndex = 25
        Me.btnLG.Text = "Gauche Lèvres"
        Me.btnLG.UseVisualStyleBackColor = False
        '
        'btnBND
        '
        Me.btnBND.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnBND.Location = New System.Drawing.Point(201, 152)
        Me.btnBND.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBND.Name = "btnBND"
        Me.btnBND.Size = New System.Drawing.Size(120, 27)
        Me.btnBND.TabIndex = 30
        Me.btnBND.Text = "Bord Nez Droit"
        Me.btnBND.UseVisualStyleBackColor = False
        '
        'btnBL
        '
        Me.btnBL.BackColor = System.Drawing.Color.Maroon
        Me.btnBL.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnBL.Location = New System.Drawing.Point(101, 338)
        Me.btnBL.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBL.Name = "btnBL"
        Me.btnBL.Size = New System.Drawing.Size(120, 27)
        Me.btnBL.TabIndex = 24
        Me.btnBL.Text = "Bas Lèvres"
        Me.btnBL.UseVisualStyleBackColor = False
        '
        'btnY1
        '
        Me.btnY1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnY1.Location = New System.Drawing.Point(201, 121)
        Me.btnY1.Margin = New System.Windows.Forms.Padding(2)
        Me.btnY1.Name = "btnY1"
        Me.btnY1.Size = New System.Drawing.Size(120, 27)
        Me.btnY1.TabIndex = 21
        Me.btnY1.Text = "Oeil Droit"
        Me.btnY1.UseVisualStyleBackColor = False
        '
        'btnBVD
        '
        Me.btnBVD.BackColor = System.Drawing.Color.DarkViolet
        Me.btnBVD.ForeColor = System.Drawing.SystemColors.Control
        Me.btnBVD.Location = New System.Drawing.Point(201, 214)
        Me.btnBVD.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBVD.Name = "btnBVD"
        Me.btnBVD.Size = New System.Drawing.Size(120, 27)
        Me.btnBVD.TabIndex = 29
        Me.btnBVD.Text = "Bord Visage Droit"
        Me.btnBVD.UseVisualStyleBackColor = False
        '
        'btnBN
        '
        Me.btnBN.BackColor = System.Drawing.Color.Green
        Me.btnBN.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnBN.Location = New System.Drawing.Point(101, 183)
        Me.btnBN.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBN.Name = "btnBN"
        Me.btnBN.Size = New System.Drawing.Size(120, 27)
        Me.btnBN.TabIndex = 28
        Me.btnBN.Text = "Bas Nez"
        Me.btnBN.UseVisualStyleBackColor = False
        '
        'btnY2
        '
        Me.btnY2.BackColor = System.Drawing.Color.Blue
        Me.btnY2.ForeColor = System.Drawing.Color.White
        Me.btnY2.Location = New System.Drawing.Point(4, 121)
        Me.btnY2.Margin = New System.Windows.Forms.Padding(2)
        Me.btnY2.Name = "btnY2"
        Me.btnY2.Size = New System.Drawing.Size(120, 27)
        Me.btnY2.TabIndex = 22
        Me.btnY2.Text = "Oeil Gauche"
        Me.btnY2.UseVisualStyleBackColor = False
        '
        'btnLH
        '
        Me.btnLH.BackColor = System.Drawing.Color.Red
        Me.btnLH.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnLH.Location = New System.Drawing.Point(101, 276)
        Me.btnLH.Margin = New System.Windows.Forms.Padding(2)
        Me.btnLH.Name = "btnLH"
        Me.btnLH.Size = New System.Drawing.Size(120, 27)
        Me.btnLH.TabIndex = 23
        Me.btnLH.Text = "Haut Lèvres"
        Me.btnLH.UseVisualStyleBackColor = False
        '
        'pnlImgEtAnnot
        '
        Me.pnlImgEtAnnot.Controls.Add(Me.pbImage)
        Me.pnlImgEtAnnot.Location = New System.Drawing.Point(12, 38)
        Me.pnlImgEtAnnot.Name = "pnlImgEtAnnot"
        Me.pnlImgEtAnnot.Size = New System.Drawing.Size(378, 504)
        Me.pnlImgEtAnnot.TabIndex = 22
        '
        'PagePrincipale
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(730, 549)
        Me.Controls.Add(Me.pnlImgEtAnnot)
        Me.Controls.Add(Me.pnlVis)
        Me.Controls.Add(Me.panelReco)
        Me.Controls.Add(Me.btnAide)
        Me.Controls.Add(Me.btnAff)
        Me.Controls.Add(Me.btnEnr)
        Me.Controls.Add(Me.btnChar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(746, 588)
        Me.MinimumSize = New System.Drawing.Size(746, 588)
        Me.Name = "PagePrincipale"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Application d’annotation et de reconnaissance de visages"
        Me.panelReco.ResumeLayout(False)
        CType(Me.pbImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlVis.ResumeLayout(False)
        Me.pnlAnnotRapid.ResumeLayout(False)
        Me.pnlImgEtAnnot.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnChar As Button
    Friend WithEvents btnEnr As Button
    Friend WithEvents btnAff As Button
    Friend WithEvents btnAide As Button
    Friend WithEvents panelReco As Panel
    Friend WithEvents btnCher As Button
    Friend WithEvents btnCharAn As Button
    Friend WithEvents btnSupAn As Button
    Friend WithEvents pbImage As PictureBox
    Friend WithEvents pnlVis As Panel
    Friend WithEvents btnBNG As Button
    Friend WithEvents btnBVG As Button
    Friend WithEvents btnBM As Button
    Friend WithEvents btnLD As Button
    Friend WithEvents btnLG As Button
    Friend WithEvents btnBND As Button
    Friend WithEvents btnBL As Button
    Friend WithEvents btnY1 As Button
    Friend WithEvents btnBVD As Button
    Friend WithEvents btnBN As Button
    Friend WithEvents btnY2 As Button
    Friend WithEvents btnLH As Button
    Friend WithEvents pnlImgEtAnnot As Panel
    Friend WithEvents lblPhotoRessemblante As Label
    Friend WithEvents lblTitrePhotoRessemblante As Label
    Friend WithEvents lblTitreAnnot As Label
    Friend WithEvents pnlAnnotRapid As Panel
    Friend WithEvents lblAnnotRapid As Label
    Friend WithEvents btnAnnotRapid As Button
    Friend WithEvents btnStopAnnotRapid As Button
End Class
