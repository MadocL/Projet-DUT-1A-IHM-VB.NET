'Projet IHM : application d'annotation et de reconnaissance de visages
'Mars-Mai 2020
'LEFEVRE Madoc & BORRA Camille TP 2C


Imports System.Drawing
Imports System.IO
Imports System.Threading

Public Class PagePrincipale
    Dim btns() As Button
    Dim coordsAnnot() As Integer
    Dim annotations As PictureBox()
    Dim imageURL As String
    ReadOnly srcURl As String = Application.StartupPath + "\..\..\src"
    Dim dataURL As String = Application.StartupPath + "\..\..\data"
    Dim imgFolder As String = Path.GetFullPath(Application.StartupPath + "\..\..\data")
    Dim format As String = "portrait"
    Dim i_annot_rapid As Nullable(Of Integer)

    ReadOnly pbAnnotY1 As PictureBox = New PictureBox()
    ReadOnly pbAnnotY2 As PictureBox = New PictureBox()
    ReadOnly pbAnnotBVG As PictureBox = New PictureBox()
    ReadOnly pbAnnotBVD As PictureBox = New PictureBox()
    ReadOnly pbAnnotBN As PictureBox = New PictureBox()
    ReadOnly pbAnnotBNG As PictureBox = New PictureBox()
    ReadOnly pbAnnotBND As PictureBox = New PictureBox()
    ReadOnly pbAnnotBM As PictureBox = New PictureBox()
    ReadOnly pbAnnotLH As PictureBox = New PictureBox()
    ReadOnly pbAnnotBL As PictureBox = New PictureBox()
    ReadOnly pbAnnotLG As PictureBox = New PictureBox()
    ReadOnly pbAnnotLD As PictureBox = New PictureBox()

    Public Sub Init() Handles MyBase.Load 'fonction qui initialise les variables à l'ouverture du logiciel
        Dim i As Integer
        btns = {btnY1, btnY2, btnBVG, btnBVD, btnBN, btnBNG, btnBND, btnBM, btnLH, btnBL, btnLG, btnLD}
        coordsAnnot = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
        annotations = {pbAnnotY1, pbAnnotY2, pbAnnotBVD, pbAnnotBVG, pbAnnotBN, pbAnnotBNG, pbAnnotBND, pbAnnotBM, pbAnnotLH, pbAnnotBL, pbAnnotLG, pbAnnotLD}
        '                   0-1      2-3          4-5         6-7       8-9         10-11      12-13      14-15      16-17       18-19      20-21    22-23

        For i = 0 To 11
            annotations(i).ImageLocation = srcURl + "\annotation" + btns(i).Name + ".png"
            annotations(i).Parent = pbImage
            annotations(i).Visible = False
            annotations(i).Size = New Size(16, 16)
            annotations(i).BackColor = Color.Transparent
        Next

        ConfigDirectory()
    End Sub

    Private Sub ConfigDirectory() 'procédure pour configurer les répertoires par défaut si l'utilisateur le veut
        Dim msg As String = "Voulez-vous modifier le répertoire par défaut du fichier d'annotation ? Si vous cliquez sur 'Non', le répertoire sera le dossier 'data' du logiciel"
        Dim titre As String = "Configuration du chemin d'accès du fichier d'annotation"
        Dim FolderBrowser As FolderBrowserDialog = New FolderBrowserDialog()

        If MessageBox.Show(msg, titre, MessageBoxButtons.YesNo) = DialogResult.Yes Then
            FolderBrowser.Description = titre
            FolderBrowser.ShowDialog()
            dataURL = FolderBrowser.SelectedPath
        End If

        msg = "Voulez-vous modifier le répertoire par défaut des images ? Si vous cliquez sur 'Non', le répertoire sera le dossier 'data' du logiciel"
        titre = "Configuration du chemin d'accès aux images"
        If MessageBox.Show(msg, titre, MessageBoxButtons.YesNo) = DialogResult.Yes Then
            FolderBrowser.Description = titre
            FolderBrowser.ShowDialog()
            imgFolder = FolderBrowser.SelectedPath
        End If
    End Sub
    Private Sub BtnChar_Click(sender As Object, e As EventArgs) Handles btnChar.Click

        Dim OpenFileDialog1 As OpenFileDialog

        OpenFileDialog1 = New OpenFileDialog With {
            .Filter = "Image Files(*.BMP;*.PNG;*.JPG;*.GIF)|*.BMP;*.PNG;*.JPG;*.GIF|All files (*.*)|*.*",
            .Title = "Ouvrir une image à annoter",
            .InitialDirectory = imgFolder
        }

        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then 'execution de la fenêtre pour ouvrir l'image
            imageURL = OpenFileDialog1.FileName 'je choppe le chemin d'accès à l'image sélectionnée...
            pbImage.ImageLocation = imageURL '...et je le met dans le paramètre correspondant de la PictureBox pbImage
            pbImage.Load()
        End If

        For i = 0 To 11
            annotations(i).Visible = False 'je masque toutes les annotations
        Next
        coordsAnnot = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0} 'je reset toutes les coords
        lblPhotoRessemblante.Text = Nothing
    End Sub

    Private Sub PbImage_Click(sender As Object, e As EventArgs) Handles pbImage.Click
        Dim pointAnnotation As Point
        Dim boutonSélectionnné As Boolean = False
        Dim i As Integer = 0

        While Not boutonSélectionnné And i < 12 'je regarde quel bouton est sélectionné
            boutonSélectionnné = btns(i).Focused
            i += 1
        End While

        If boutonSélectionnné Then
            pointAnnotation = pbImage.PointToClient(MousePosition) 'je choppe la position du curseur (relative à pbImage)


            'j'enregistre les coords de l'annotation dans le tableau fait pour,
            'avec une position spécifique dans ce tableau pour chaque type d'annotation

            coordsAnnot((i - 1) * 2) = pointAnnotation.X
            coordsAnnot(((i - 1) * 2) + 1) = pointAnnotation.Y

            'je soustrait 8 aux deux coordonnées pour que l'annotation soit centrée
            '(autrement c'est le coin de l'image qui est aux bonnes coordonnées)

            pointAnnotation.X -= 8
            pointAnnotation.Y -= 8

            annotations(i - 1).Location = pointAnnotation
            annotations(i - 1).Visible = True
        Else
            MessageBox.Show("Veuillez sélectionner un bouton avant d'annoter.", "Annotation impossible", MessageBoxButtons.OK) 'si aucun bouton n'est sélectionné
        End If
    End Sub

    Private Sub BtnSupAn_Click(sender As Object, e As EventArgs) Handles btnSupAn.Click
        Dim i As Integer

        If CheckAnnoté() Then 's'il y a au moins une annotation
            Dim titre As String = "Suppression des annotations"
            Dim msg As String = "Etes-vous sûr de vouloir retirer toutes les annotations ?"

            If MessageBox.Show(msg, titre, MessageBoxButtons.YesNo) = System.Windows.Forms.DialogResult.Yes Then 'je demande la confirmation
                For i = 0 To 11
                    annotations(i).Visible = False 'je masque toutes les annotations
                Next
                coordsAnnot = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0} 'je reset toutes les coords
            End If
        Else
            MessageBox.Show("Il n'y a aucune annotation à supprimer", "Action impossible", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub BtnEnr_Click(sender As Object, e As EventArgs) Handles btnEnr.Click
        If pbImage.Image Is Nothing Then
            MessageBox.Show("Chargez une image et annotez-la avant d'enregistrer", "Enregistrement impossible", MessageBoxButtons.OK)
        Else
            If Not CheckAnnoté() Then
                MessageBox.Show("Posez au moins une annotation avant d'enregistrer", "Enregistrement impossible", MessageBoxButtons.OK)
            Else
                If CheckAnnotéComplètement(coordsAnnot) Then 'si toutes les annotations sont placées
                    EnregistrerAnnot()
                Else 's'il manque des annotations
                    Dim titre As String = "Annotation incomplète"
                    Dim msg As String = "Les annotations seront enregistrées bien que vous n'ayez pas fini de poser toutes les annotations"

                    If MessageBox.Show(msg, titre, MessageBoxButtons.OKCancel) = System.Windows.Forms.DialogResult.OK Then 'je préviens à l'utilisateur qu'il n'a pas fini d'annoter
                        EnregistrerAnnot()
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub EnregistrerAnnot() 'procédure pour enregistrer les annotations dans le csv
        Dim i As Integer
        Dim line As String = URLToName(imageURL) 'je mets le nom de l'image

        For i = 0 To 23
            line += vbTab + CType(coordsAnnot(i), String) 'j'ajoute chaque coordonnées à la string "line"
        Next
        My.Computer.FileSystem.WriteAllText(dataURL + "\annotations.csv", vbCrLf + line, True) 'j'ajoute au fichier csv la string line (après être passé à la ligne)
        MessageBox.Show("Annotations de l'image " + URLToName(imageURL) + " enregistrée(s)", "Enregistrement effectué", MessageBoxButtons.OK) 'message de confirmation
    End Sub

    Private Function URLToName(URL As String) As String 'fonction pour prélever le nom de l'image à partir de son URL
        Dim URLSplit As String() = URL.Split("\")
        Return URLSplit(URLSplit.Length - 1)
    End Function

    Private Function CheckAnnotéComplètement() 'fonction pour vérifier que toutes les annotations ont été faites
        Dim rempli = True
        Dim i As Integer = 0

        While rempli And i < 12
            If coordsAnnot(i) = 0 Then
                rempli = False
            End If
            i += 1
        End While
        Return rempli
    End Function
    Private Function CheckAnnoté() As Boolean 'fonction pour vérifier s'il existe au moins une annotation
        Dim i As Integer
        Dim annoté As Boolean = False

        While Not annoté And i < 12
            annoté = annotations(i).Visible
            i += 1
        End While

        Return annoté
    End Function

    Private Sub BtnCharAn_Click(sender As Object, e As EventArgs) Handles btnCharAn.Click
        If imageURL Is Nothing Then 'si aucune image n'a été chargée
            MessageBox.Show("Chargez une image avant de charger des annotations", "Chargement impossible", MessageBoxButtons.OK)
        Else
            Dim j As Integer
            Dim trouvé As Boolean = False
            Dim line As String()
            Dim i As Integer

            Using MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser(dataURL + "\annotations.csv") 'je lis le csv avec les annotations enregisrtées
                MyReader.TextFieldType = FileIO.FieldType.Delimited
                MyReader.SetDelimiters(vbTab) 'je délimite les lignes avec le caractère "tabulation"

                'tant que je ne suis pas arrivé à la fin du fichier et que je n'ai pas trouvé les bonnes annotations (cad avec un titre d'image pareil)
                While Not MyReader.EndOfData And Not trouvé
                    line = MyReader.ReadFields()

                    'si le nom du fichier de la ligne courante est le même que l'image chargée
                    If line(0) = URLToName(imageURL) Then
                        For i = 1 To 24
                            coordsAnnot(i - 1) = line(i) 'j'enregistre en mémoire toutes les coordonnées
                        Next
                        trouvé = True
                    End If
                End While
            End Using

            For j = 0 To 11 'ensuite, j'affiche toutes les annotations avec les positions récupérées ci-dessus
                annotations(j).Location = New Point(coordsAnnot(j * 2) - 8, coordsAnnot((j * 2) + 1) - 8)
                annotations(j).Visible = True
            Next
        End If
    End Sub

    Private Function CalculerDistance(pos1X As Integer, pos1Y As Integer, pos2X As Integer, pos2Y As Integer) 'fonction pour calculer la distance entre deux points à l'aide de Pythagore
        Dim deltaX As Integer = CalculerDelta(pos1X, pos2X)
        Dim deltaY As Integer = CalculerDelta(pos1Y, pos2Y)
        Return Math.Sqrt(deltaX * deltaX + deltaY * deltaY)
    End Function

    Private Function ComparerVisages(coordsAnnotB As Integer())
        Dim milieuYeuxA As Point = CalculerMilieuYeux(coordsAnnot(0), coordsAnnot(1), coordsAnnot(2), coordsAnnot(3))
        Dim milieuYeuxB As Point = CalculerMilieuYeux(coordsAnnotB(0), coordsAnnotB(1), coordsAnnotB(2), coordsAnnotB(3))

        'A étant la personne actuellement affichée
        'calcul des différents ratio de A :
        Dim ratioLevresA As Double = CalculerDistance(coordsAnnot(16), coordsAnnot(17), coordsAnnot(18), coordsAnnot(19)) / CalculerDistance(coordsAnnot(20), coordsAnnot(21), coordsAnnot(22), coordsAnnot(23))
        Dim ratioNezA As Double = CalculerDistance(milieuYeuxA.X, milieuYeuxA.Y, coordsAnnot(8), coordsAnnot(9)) / CalculerDistance(coordsAnnot(10), coordsAnnot(11), coordsAnnot(12), coordsAnnot(13))
        Dim ratioVisageA As Double = CalculerDistance(milieuYeuxA.X, milieuYeuxA.Y, coordsAnnot(14), coordsAnnot(15)) / CalculerDistance(coordsAnnot(4), coordsAnnot(5), coordsAnnot(6), coordsAnnot(7))
        Dim ratioYeuxA As Double = CalculerDistance(coordsAnnot(4), coordsAnnot(5), coordsAnnot(6), coordsAnnot(7)) / CalculerDistance(coordsAnnot(0), coordsAnnot(1), coordsAnnot(2), coordsAnnot(3))

        'B étant la personne cherchée
        'calcul des différents ratio de B :
        Dim ratioLevresB As Double = CalculerDistance(coordsAnnotB(16), coordsAnnotB(17), coordsAnnotB(18), coordsAnnotB(19)) / CalculerDistance(coordsAnnotB(20), coordsAnnotB(21), coordsAnnotB(22), coordsAnnotB(23))
        Dim ratioNezB As Double = CalculerDistance(milieuYeuxB.X, milieuYeuxB.Y, coordsAnnotB(8), coordsAnnotB(9)) / CalculerDistance(coordsAnnotB(10), coordsAnnotB(11), coordsAnnotB(12), coordsAnnotB(13))
        Dim ratioVisageB As Double = CalculerDistance(milieuYeuxB.X, milieuYeuxB.Y, coordsAnnotB(14), coordsAnnotB(15)) / CalculerDistance(coordsAnnotB(4), coordsAnnotB(5), coordsAnnotB(6), coordsAnnotB(7))
        Dim ratioYeuxB As Double = CalculerDistance(coordsAnnotB(4), coordsAnnotB(5), coordsAnnotB(6), coordsAnnotB(7)) / CalculerDistance(coordsAnnotB(0), coordsAnnotB(1), coordsAnnotB(2), coordsAnnotB(3))

        'calcul de la ressemblance à l'aide de tous les ratio
        Dim ressemblance As Double = Math.Pow(ratioLevresA - ratioLevresB, 2) + Math.Pow(ratioNezA - ratioNezB, 2) + Math.Pow(ratioVisageA - ratioVisageB, 2) + Math.Pow(ratioYeuxA - ratioYeuxB, 2)
        Return ressemblance
    End Function

    Public Function CalculerMilieuYeux(pos1X As Integer, pos1Y As Integer, pos2X As Integer, pos2Y As Integer) 'calcule le point à équidistance des deux yeux
        Dim deltaX As Integer = CalculerDelta(pos1X, pos2X)
        Dim deltaY As Integer = CalculerDelta(pos1Y, pos2Y)
        Dim X As Integer
        Dim Y As Integer

        If pos1X < pos2X Then
            X = pos1X + CType(deltaX / 2, Integer)
        Else
            X = pos2X + CType(deltaX / 2, Integer)
        End If

        If pos1Y < pos2Y Then
            Y = pos1Y + CType(deltaY / 2, Integer)
        Else
            Y = pos2Y + CType(deltaY / 2, Integer)
        End If

        Return New Point(X, Y)
    End Function

    Public Function CalculerDelta(pos1 As Integer, pos2 As Integer) 'calcule la différence entre deux coordonnées, renvoie toujours un nombre positif
        Dim delta As Integer
        If pos1 > pos2 Then
            delta = pos1 - pos2
        Else
            delta = pos2 - pos1
        End If
        Return delta
    End Function

    Private Sub BtnCher_Click(sender As Object, e As EventArgs) Handles btnCher.Click
        If imageURL Is Nothing Then 'si aucune image n'est chargée
            MessageBox.Show("Veuillez charger une image et l'annoter complètement avant de lancer une procédure de recherche", "Recherche impossible", MessageBoxButtons.OK)
        Else
            If CheckAnnotéComplètement() Then 'si l'annotation de l'image est complète

                Dim line As String()
                Dim i As Integer
                Dim j As Integer = 0
                Dim coordsAnnotB As Integer() = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
                Dim ressemblances(100) As Double
                Dim titres(100) As String
                Dim memePersonne As String

                Using MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser(dataURL + "\annotations.csv") 'je lis le csv contenant les annotations enregistrées
                    MyReader.TextFieldType = FileIO.FieldType.Delimited
                    MyReader.SetDelimiters(vbTab) 'je délimite les lignes avec le caractère "tabulation"

                    While Not MyReader.EndOfData 'tant que je ne suis pas arrivé à la fin du fichier
                        line = MyReader.ReadFields()
                        If Not (line(0) = "imagefile" Or line(0) = URLToName(imageURL)) Then 'si le titre de l'image est différent de "imagefile" ou de l'image actuellement affichée
                            'je récupère toutes les coordonnés des annotations de l'image
                            For i = 1 To 24
                                coordsAnnotB(i - 1) = line(i)
                            Next
                            ressemblances(j) = ComparerVisages(coordsAnnotB) 'calcul de la ressemblance 
                            titres(j) = line(0)
                            j += 1
                        End If
                    End While
                End Using

                Dim min As Double = ressemblances(0) 'je cherche le valeur minimale de ressemblance
                For i = 0 To ressemblances.Length - 1
                    If ressemblances(i) < ressemblances(min) And Not (ressemblances(i) = 0) Then
                        min = i
                    End If
                Next
                If min < 0.05 Then 'si la ressemblance est inférieure à 0.05, je dis que c'est la même personne
                    memePersonne = "Oui"
                Else
                    memePersonne = "Non"
                End If
                lblPhotoRessemblante.Text = "Image : " + titres(min) + " " + CType(ressemblances(min), String) + vbCrLf + "Même personne ? " + memePersonne 'j'affiche le titre de l'image la plus ressemblante
            Else 'si l'annotation n'est pas finie, je le dis à l'utilisateur
                MessageBox.Show("Veuillez finir d'annoter la photo actuellement chargée (ou chargez une annotation enregistrée) avant de lancer une procédure de recherche", "Recherche impossible", MessageBoxButtons.OK)
            End If
        End If

    End Sub

    Private Sub BtnAide_Click(sender As Object, e As EventArgs) Handles btnAide.Click
        Me.Hide() 'Disparition de la form 1
        PageAide.Show() 'Apparition de la form 2

    End Sub
    Private Sub BtnAff_Click(sender As Object, e As EventArgs) Handles btnAff.Click 'change l'affichage en paysage ou en portrait
        If format = "portrait" Then
            pnlImgEtAnnot.Size = New Size(452, 339)
            pnlVis.Size = New Size(251, 500)
            pnlVis.Location = New Point(473, 38)
            lblTitreAnnot.Size = New Size(251, 18)
            btnCharAn.Location = New Point(48, 35)
            btnSupAn.Location = New Point(48, 65)
            btnY2.Location = New Point(2, 162)
            btnY1.Location = New Point(126, 162)
            btnBNG.Location = New Point(2, 216)
            btnBND.Location = New Point(126, 216)
            btnBN.Location = New Point(63, 250)
            btnBVG.Location = New Point(2, 302)
            btnBVD.Location = New Point(126, 302)
            btnBM.Location = New Point(63, 336)
            btnLH.Location = New Point(63, 389)
            btnLG.Location = New Point(2, 423)
            btnLD.Location = New Point(126, 423)
            btnBL.Location = New Point(63, 457)
            panelReco.Location = New Point(11, 382)
            panelReco.Size = New Size(457, 156)
            lblTitrePhotoRessemblante.Size = New Size(449, 18)
            lblPhotoRessemblante.Location = New Point(3, 32)
            lblPhotoRessemblante.Size = New Size(449, 53)
            btnCher.Location = New Point(146, 105)
            lblAnnotRapid.Size = New Size(126, 36)
            pnlAnnotRapid.Size = New Size(239, 45)
            btnAnnotRapid.Size = New Size(99, 25)
            btnStopAnnotRapid.Size = New Size(99, 25)
            lblAnnotRapid.Location = New Point(108, 3)
            pnlAnnotRapid.Location = New Point(3, 105)

            format = "paysage"
        Else
            panelReco.Location = New Point(396, 38)
            panelReco.Size = New Size(328, 129)
            lblTitrePhotoRessemblante.Size = New Size(320, 18)
            lblPhotoRessemblante.Location = New Point(7, 27)
            lblPhotoRessemblante.Size = New Size(311, 53)
            btnCher.Location = New Point(90, 91)
            btnCharAn.Location = New Point(6, 33)
            btnSupAn.Location = New Point(197, 33)
            pnlVis.Location = New Point(396, 172)
            pnlVis.Size = New Size(328, 370)
            pnlImgEtAnnot.Location = New Point(12, 38)
            pnlImgEtAnnot.Size = New Size(378, 504)
            btnSupAn.Location = New Point(173, 33)
            lblTitreAnnot.Size = New Size(328, 18)

            lblAnnotRapid.Size = New Size(170, 36)
            pnlAnnotRapid.Size = New Size(320, 45)
            btnAnnotRapid.Size = New Size(131, 25)
            btnStopAnnotRapid.Size = New Size(131, 25)
            lblAnnotRapid.Location = New Point(140, 3)
            pnlAnnotRapid.Location = New Point(3, 71)

            btnLH.Location = New Point(101, 276)
            btnY2.Location = New Point(4, 121)
            btnBN.Location = New Point(101, 183)
            btnBVD.Location = New Point(201, 214)
            btnY1.Location = New Point(201, 121)
            btnBL.Location = New Point(101, 338)
            btnBND.Location = New Point(201, 152)
            btnLG.Location = New Point(4, 307)
            btnLD.Location = New Point(201, 307)
            btnBM.Location = New Point(101, 245)
            btnBVG.Location = New Point(4, 214)
            btnBNG.Location = New Point(4, 152)

            format = "portrait"
        End If
    End Sub

    Private Sub BtnAnnotRapid_Click(sender As Object, e As EventArgs) Handles btnAnnotRapid.Click, pbImage.Click, btnStopAnnotRapid.Click
        'fonction pour annoter rapidement (sans avoir à cliquer sur chaque bouton pour poser une nouvelle annotation)
        Dim pointCaracteristique() = {"l'oeil droit", "l'oeil gauche", "le bord du visage le plus à gauche", "le bord du visage le plus à droite", "le bas du nez", "le bord gauche du nez", "le bord droit du nez", "le bas du menton", "le haut des lèvres", "le bas des lèvres", "le bord gauche des lèvres, puis le bord droit", ""}

        If sender.Name = "btnAnnotRapid" Then 'si j'appuie sur le bouton "annotation rapide"
            btnAnnotRapid.Visible = False
            btnStopAnnotRapid.Visible = True
            i_annot_rapid = 0
            btns(i_annot_rapid).Focus() 'je focus le bouton correspondant à la première annotation
            lblAnnotRapid.Text = "Annotez " + pointCaracteristique(i_annot_rapid) 'j'affiche dans le label le point caractéristique à annoter

            btnChar.Enabled = False 'je désactive tous les autres boutons pour éviter que l'utilisateur n'appuie dessus (et enlève le focus)
            btnEnr.Enabled = False
            btnAff.Enabled = False
            btnAide.Enabled = False
            btnCharAn.Enabled = False
            btnSupAn.Enabled = False
            btnCher.Enabled = False

        ElseIf sender.Name = "pbImage" And Not i_annot_rapid Is Nothing Then 'si j'ajoute une annotation
            i_annot_rapid += 1
            btns(i_annot_rapid).Focus() 'je focus le bouton correspondant à l'annotation suivante
            lblAnnotRapid.Text = "Annotez " + pointCaracteristique(i_annot_rapid) 'j'affiche dans le label le point caractéristique à annoter
        Else
            i_annot_rapid = 11
        End If

        If i_annot_rapid = 11 Then 'quand j'ai finit d'annoter, je mets i_annot_rapid à Nothing et je remets tous les boutons dans l'état dans lequel ils étaient avant
            btnAnnotRapid.Visible = True
            btnStopAnnotRapid.Visible = False
            lblAnnotRapid.Text = ""
            i_annot_rapid = Nothing

            btnChar.Enabled = True
            btnEnr.Enabled = True
            btnAff.Enabled = True
            btnAide.Enabled = True
            btnCharAn.Enabled = True
            btnSupAn.Enabled = True
            btnCher.Enabled = True
        End If
    End Sub
End Class
