Public Class frm_Gestion
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Cmb_produit_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cmb_produit.SelectedIndexChanged
        If Cmb_produit.SelectedItem = "clavier" Then
            txt_prixU.Text = "30"
        ElseIf Cmb_produit.SelectedItem = "souris" Then
            txt_prixU.Text = "15"
        ElseIf Cmb_produit.SelectedItem = "imprimante" Then
            txt_prixU.Text = "500"
        ElseIf Cmb_produit.SelectedItem = "ordinateur" Then
            txt_prixU.Text = "1000"
        End If
    End Sub

    Private Sub btn_ajouter_Click(sender As Object, e As EventArgs) Handles btn_ajouter.Click
        If Cmb_produit.SelectedIndex = -1 Then
            MsgBox("il faut entrer le produit")
        Else
            Dim quantite As String
            quantite = txt_quantite.Text
            If Integer.TryParse(quantite, vbNull) Then
                If quantite > 0 Then
                    txt_montant.Text = quantite * txt_prixU.Text
                    Dim ch1 As String
                    Dim ch2 As String
                    Dim ch3 As String
                    Dim ch4 As String
                    ch1 = Cmb_produit.SelectedItem
                    ch2 = txt_prixU.Text
                    ch3 = quantite
                    ch4 = txt_montant.Text
                    lst_produit.Items.Add(ch1)
                    lst_prixU.Items.Add(ch2)
                    lst_qauntite.Items.Add(ch3)
                    lst_montantHT.Items.Add(ch4)
                    Cmb_produit.SelectedIndex = -1
                    txt_prixU.Clear()
                    txt_quantite.Clear()
                    txt_montant.Clear()

                Else
                    MsgBox(" la quantite doit etre superieur à 0")

                End If
            Else
                MsgBox("la quantite doit etre numerique")

            End If
        End If


    End Sub

    Private Sub btn_quiter_Click(sender As Object, e As EventArgs) Handles btn_quiter.Click
        End
    End Sub

    Private Sub btn_supp_Click(sender As Object, e As EventArgs) Handles btn_supp.Click
        Dim supp As Integer
        supp = lst_produit.Items.Count()
        If supp = 0 Then
            MsgBox("il n'y a pas de produit pour supprimer !")
        Else
            supp = supp - 1
            lst_produit.Items.RemoveAt(supp)
            lst_prixU.Items.RemoveAt(supp)
            lst_qauntite.Items.RemoveAt(supp)
            lst_montantHT.Items.RemoveAt(supp)
        End If
    End Sub

    Private Sub btn_calculer_Click(sender As Object, e As EventArgs) Handles btn_calculer.Click
        Dim somme As Single
        Dim tva As Single
        For Each Str As String In lst_qauntite.Items
            somme = somme + CInt(Str)
        Next
        txt_totalQ.Text = somme
        somme = 0
        For Each Str As String In lst_montantHT.Items
            somme = somme + CInt(Str)
        Next
        txt_totalMHT.Text = somme
        somme = 0
        For Each Str As String In lst_prixU.Items
            somme = somme + CInt(Str)
        Next
        txt_totalPU.Text = somme

        tva = txt_totalMHT.Text + (txt_totalMHT.Text * 0.2)
        txt_TVA.Text = tva
        If txt_totalMHT.Text > 1000 Then
            txt_remise.Text = txt_totalMHT.Text + (txt_totalMHT.Text * 0.01)
        Else
            MsgBox("il n'y a pas de remise")
        End If





    End Sub

    Private Sub btn_modifier_Click(sender As Object, e As EventArgs) Handles btn_modifier.Click
        Dim modifier As String
        Dim quantite As String
        quantite = txt_quantite.Text
        modifier = txt_modifier.Text
        If txt_quantite.Text = "" Then
            MsgBox("il faut choisir la nouveau quantite")
        Else
            If Integer.TryParse(quantite, vbNull) Then
                If quantite > 0 Then
                    If modifier = "" Then
                        MsgBox("il faut entrez la numéro de la ligne")
                    Else

                        If Integer.TryParse(modifier, vbNull) < 0 Then
                            If Int(modifier) < 0 Then
                                MsgBox("la ligne doit etre superieur à 0")
                            Else
                                lst_qauntite.Items.RemoveAt(Int(modifier) - 1)
                                lst_qauntite.Items.Insert(Int(modifier) - 1, quantite)
                                lst_montantHT.Items(Int(modifier) - 1) = Int(lst_prixU.Items(Int(modifier) - 1)) * quantite
                            End If
                        Else
                            MsgBox("la ligne doit etre numerique ")
                        End If
                    End If
                Else
                    MsgBox("la quantite doit etre superieur a 0")
                End If
            Else
                MsgBox("la quantite doit etre numerique")

            End If
        End If

    End Sub
End Class