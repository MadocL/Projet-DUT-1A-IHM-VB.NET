'Projet IHM : application d'annotation et de reconnaissance de visages
'Mars-Mai 2020
'LEFEVRE Madoc & BORRA Camille TP 2C


Public Class PageAide
    ReadOnly srcURl As String = Application.StartupPath + "\..\..\src"
    Private Sub PictureBoxExemple_Click(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBoxExemple.ImageLocation = srcURl + "\pageAide" + ".png"
        LabelAide.Font = New Font("Arial", 30) 'Changement de taille du label Aide'
    End Sub

    Private Sub ButtonQtAide_Click(sender As Object, e As EventArgs) Handles ButtonQtAide.Click
        Me.Hide() 'Disparition de la form2
        PagePrincipale.Show() 'Apparition de la form 1

    End Sub
End Class