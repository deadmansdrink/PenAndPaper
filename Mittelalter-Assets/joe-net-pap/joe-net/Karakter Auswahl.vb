Public Class Karakter_Auswahl
    Private Sub Karakter_Auswahl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (Not System.IO.File.Exists(Hauptmenue.YourPath2 + "\pro.joe")) Then

            Dim leer As String = "<Frei>:<Frei>:<Frei>:<Frei>:<Frei>:<Frei>:<Frei>:<Frei>"
            Dim list As String = ""

            My.Computer.FileSystem.WriteAllText(Hauptmenue.YourPath2 + "\pro.joe", leer, True)

            My.Computer.FileSystem.WriteAllText(Hauptmenue.YourPath2 + "\pro1.joe", list, True)
            My.Computer.FileSystem.WriteAllText(Hauptmenue.YourPath2 + "\pro2.joe", list, True)
            My.Computer.FileSystem.WriteAllText(Hauptmenue.YourPath2 + "\pro3.joe", list, True)
            My.Computer.FileSystem.WriteAllText(Hauptmenue.YourPath2 + "\pro4.joe", list, True)
            My.Computer.FileSystem.WriteAllText(Hauptmenue.YourPath2 + "\pro5.joe", list, True)
            My.Computer.FileSystem.WriteAllText(Hauptmenue.YourPath2 + "\pro6.joe", list, True)
            My.Computer.FileSystem.WriteAllText(Hauptmenue.YourPath2 + "\pro7.joe", list, True)
            My.Computer.FileSystem.WriteAllText(Hauptmenue.YourPath2 + "\pro8.joe", list, True)


        Else
            Dim fileReader As String
            fileReader = My.Computer.FileSystem.ReadAllText(Hauptmenue.YourPath2 + "\pro.joe")
            Dim pro() As String = fileReader.Split(":")

            TextBox1.Text = pro(0)
            TextBox2.Text = pro(1)
            TextBox3.Text = pro(2)
            TextBox4.Text = pro(3)
            TextBox5.Text = pro(4)
            TextBox6.Text = pro(5)
            TextBox7.Text = pro(6)
            TextBox8.Text = pro(7)


            If Not pro(0) = "<Frei>" Then
                Anzeigen_Button1.Enabled = True
            End If

            If Not pro(1) = "<Frei>" Then
                Anzeigen_Button2.Enabled = True
            End If

            If Not pro(2) = "<Frei>" Then
                Anzeigen_Button3.Enabled = True
            End If

            If Not pro(3) = "<Frei>" Then
                Anzeigen_Button4.Enabled = True
            End If

            If Not pro(4) = "<Frei>" Then
                Anzeigen_Button5.Enabled = True
            End If

            If Not pro(5) = "<Frei>" Then
                Anzeigen_Button6.Enabled = True
            End If

            If Not pro(6) = "<Frei>" Then
                Anzeigen_Button7.Enabled = True
            End If

            If Not pro(7) = "<Frei>" Then
                Anzeigen_Button8.Enabled = True
            End If

            If Not CharacterC.CARPRO = "" Then
                Speichern_Button1.Enabled = True
                Speichern_Button2.Enabled = True
                Speichern_Button3.Enabled = True
                Speichern_Button4.Enabled = True
                Speichern_Button5.Enabled = True
                Speichern_Button6.Enabled = True
                Speichern_Button7.Enabled = True
                Speichern_Button8.Enabled = True
            End If
        End If
    End Sub

    Private Sub Speichern_Button1_Click(sender As Object, e As EventArgs) Handles Speichern_Button1.Click
        Dim fileReader As String
        fileReader = My.Computer.FileSystem.ReadAllText(Hauptmenue.YourPath2 + "\pro.joe")
        Dim pro() As String = fileReader.Split(":")

        If pro(1) = "<Frei>" Then
            My.Computer.FileSystem.WriteAllText(Hauptmenue.YourPath2 + "\pro1.joe", CharacterC.CARPRO, True)
            Dim pri As String = pro(0) + ":" + pro(1) + ":" + pro(2) + ":" + pro(3) + ":" + pro(4) + ":" + pro(5) + ":" + pro(6) + ":" + pro(7)

        End If

    End Sub
End Class