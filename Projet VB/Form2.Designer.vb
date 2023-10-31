<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Gestion
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_prixU = New System.Windows.Forms.TextBox()
        Me.txt_montant = New System.Windows.Forms.TextBox()
        Me.btn_ajouter = New System.Windows.Forms.Button()
        Me.btn_supp = New System.Windows.Forms.Button()
        Me.btn_modifier = New System.Windows.Forms.Button()
        Me.Cmb_produit = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btn_calculer = New System.Windows.Forms.Button()
        Me.btn_quiter = New System.Windows.Forms.Button()
        Me.lst_produit = New System.Windows.Forms.ListBox()
        Me.lst_prixU = New System.Windows.Forms.ListBox()
        Me.lst_qauntite = New System.Windows.Forms.ListBox()
        Me.lst_montantHT = New System.Windows.Forms.ListBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_totalPU = New System.Windows.Forms.TextBox()
        Me.txt_totalQ = New System.Windows.Forms.TextBox()
        Me.txt_totalMHT = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_TVA = New System.Windows.Forms.TextBox()
        Me.txt_remise = New System.Windows.Forms.TextBox()
        Me.txt_quantite = New System.Windows.Forms.TextBox()
        Me.txt_modifier = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 23)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Produit :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(22, 68)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Prix unitaire :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(23, 126)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 23)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Quantité :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(23, 192)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 23)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Montant :"
        '
        'txt_prixU
        '
        Me.txt_prixU.Enabled = False
        Me.txt_prixU.Location = New System.Drawing.Point(218, 68)
        Me.txt_prixU.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_prixU.Name = "txt_prixU"
        Me.txt_prixU.Size = New System.Drawing.Size(181, 28)
        Me.txt_prixU.TabIndex = 4
        '
        'txt_montant
        '
        Me.txt_montant.Enabled = False
        Me.txt_montant.Location = New System.Drawing.Point(218, 187)
        Me.txt_montant.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_montant.Name = "txt_montant"
        Me.txt_montant.Size = New System.Drawing.Size(181, 28)
        Me.txt_montant.TabIndex = 7
        '
        'btn_ajouter
        '
        Me.btn_ajouter.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ajouter.Location = New System.Drawing.Point(600, 23)
        Me.btn_ajouter.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_ajouter.Name = "btn_ajouter"
        Me.btn_ajouter.Size = New System.Drawing.Size(143, 34)
        Me.btn_ajouter.TabIndex = 8
        Me.btn_ajouter.Text = "Ajouter"
        Me.btn_ajouter.UseVisualStyleBackColor = True
        '
        'btn_supp
        '
        Me.btn_supp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_supp.Location = New System.Drawing.Point(600, 80)
        Me.btn_supp.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_supp.Name = "btn_supp"
        Me.btn_supp.Size = New System.Drawing.Size(142, 36)
        Me.btn_supp.TabIndex = 9
        Me.btn_supp.Text = "Supprimer"
        Me.btn_supp.UseVisualStyleBackColor = True
        '
        'btn_modifier
        '
        Me.btn_modifier.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_modifier.Location = New System.Drawing.Point(601, 140)
        Me.btn_modifier.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_modifier.Name = "btn_modifier"
        Me.btn_modifier.Size = New System.Drawing.Size(142, 34)
        Me.btn_modifier.TabIndex = 10
        Me.btn_modifier.Text = "Modifier"
        Me.btn_modifier.UseVisualStyleBackColor = True
        '
        'Cmb_produit
        '
        Me.Cmb_produit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmb_produit.FormattingEnabled = True
        Me.Cmb_produit.Items.AddRange(New Object() {"clavier", "souris", "imprimante", "ordinateur"})
        Me.Cmb_produit.Location = New System.Drawing.Point(218, 19)
        Me.Cmb_produit.Margin = New System.Windows.Forms.Padding(4)
        Me.Cmb_produit.Name = "Cmb_produit"
        Me.Cmb_produit.Size = New System.Drawing.Size(181, 30)
        Me.Cmb_produit.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(56, 270)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 25)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Produit"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(275, 270)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(129, 25)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Prix Unitaire"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(532, 270)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(94, 25)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Qauntite"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(759, 270)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(125, 25)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Montant HT"
        '
        'btn_calculer
        '
        Me.btn_calculer.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_calculer.Location = New System.Drawing.Point(1055, 341)
        Me.btn_calculer.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_calculer.Name = "btn_calculer"
        Me.btn_calculer.Size = New System.Drawing.Size(117, 47)
        Me.btn_calculer.TabIndex = 16
        Me.btn_calculer.Text = "Calculer"
        Me.btn_calculer.UseVisualStyleBackColor = True
        '
        'btn_quiter
        '
        Me.btn_quiter.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_quiter.Location = New System.Drawing.Point(1055, 434)
        Me.btn_quiter.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_quiter.Name = "btn_quiter"
        Me.btn_quiter.Size = New System.Drawing.Size(117, 46)
        Me.btn_quiter.TabIndex = 17
        Me.btn_quiter.Text = "Quitter"
        Me.btn_quiter.UseVisualStyleBackColor = True
        '
        'lst_produit
        '
        Me.lst_produit.FormattingEnabled = True
        Me.lst_produit.ItemHeight = 22
        Me.lst_produit.Location = New System.Drawing.Point(47, 317)
        Me.lst_produit.Name = "lst_produit"
        Me.lst_produit.Size = New System.Drawing.Size(151, 246)
        Me.lst_produit.TabIndex = 18
        '
        'lst_prixU
        '
        Me.lst_prixU.FormattingEnabled = True
        Me.lst_prixU.ItemHeight = 22
        Me.lst_prixU.Location = New System.Drawing.Point(280, 317)
        Me.lst_prixU.Name = "lst_prixU"
        Me.lst_prixU.Size = New System.Drawing.Size(155, 246)
        Me.lst_prixU.TabIndex = 19
        '
        'lst_qauntite
        '
        Me.lst_qauntite.FormattingEnabled = True
        Me.lst_qauntite.ItemHeight = 22
        Me.lst_qauntite.Location = New System.Drawing.Point(527, 317)
        Me.lst_qauntite.Name = "lst_qauntite"
        Me.lst_qauntite.Size = New System.Drawing.Size(157, 246)
        Me.lst_qauntite.TabIndex = 20
        '
        'lst_montantHT
        '
        Me.lst_montantHT.FormattingEnabled = True
        Me.lst_montantHT.ItemHeight = 22
        Me.lst_montantHT.Location = New System.Drawing.Point(752, 317)
        Me.lst_montantHT.Name = "lst_montantHT"
        Me.lst_montantHT.Size = New System.Drawing.Size(149, 246)
        Me.lst_montantHT.TabIndex = 21
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(69, 614)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(68, 24)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Total :"
        '
        'txt_totalPU
        '
        Me.txt_totalPU.Enabled = False
        Me.txt_totalPU.Location = New System.Drawing.Point(270, 610)
        Me.txt_totalPU.Name = "txt_totalPU"
        Me.txt_totalPU.Size = New System.Drawing.Size(165, 28)
        Me.txt_totalPU.TabIndex = 23
        '
        'txt_totalQ
        '
        Me.txt_totalQ.Enabled = False
        Me.txt_totalQ.Location = New System.Drawing.Point(509, 610)
        Me.txt_totalQ.Name = "txt_totalQ"
        Me.txt_totalQ.Size = New System.Drawing.Size(163, 28)
        Me.txt_totalQ.TabIndex = 24
        '
        'txt_totalMHT
        '
        Me.txt_totalMHT.Enabled = False
        Me.txt_totalMHT.Location = New System.Drawing.Point(745, 610)
        Me.txt_totalMHT.Name = "txt_totalMHT"
        Me.txt_totalMHT.Size = New System.Drawing.Size(156, 28)
        Me.txt_totalMHT.TabIndex = 25
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(68, 682)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(121, 24)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "TVA (20%) :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(69, 743)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(92, 24)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "Remise :"
        '
        'txt_TVA
        '
        Me.txt_TVA.Enabled = False
        Me.txt_TVA.Location = New System.Drawing.Point(280, 682)
        Me.txt_TVA.Name = "txt_TVA"
        Me.txt_TVA.Size = New System.Drawing.Size(383, 28)
        Me.txt_TVA.TabIndex = 28
        '
        'txt_remise
        '
        Me.txt_remise.Enabled = False
        Me.txt_remise.Location = New System.Drawing.Point(280, 743)
        Me.txt_remise.Name = "txt_remise"
        Me.txt_remise.Size = New System.Drawing.Size(383, 28)
        Me.txt_remise.TabIndex = 29
        '
        'txt_quantite
        '
        Me.txt_quantite.Location = New System.Drawing.Point(221, 126)
        Me.txt_quantite.Name = "txt_quantite"
        Me.txt_quantite.Size = New System.Drawing.Size(178, 28)
        Me.txt_quantite.TabIndex = 31
        '
        'txt_modifier
        '
        Me.txt_modifier.Location = New System.Drawing.Point(790, 146)
        Me.txt_modifier.Name = "txt_modifier"
        Me.txt_modifier.Size = New System.Drawing.Size(165, 28)
        Me.txt_modifier.TabIndex = 32
        '
        'frm_Gestion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSeaGreen
        Me.ClientSize = New System.Drawing.Size(1224, 811)
        Me.Controls.Add(Me.txt_modifier)
        Me.Controls.Add(Me.txt_quantite)
        Me.Controls.Add(Me.txt_remise)
        Me.Controls.Add(Me.txt_TVA)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txt_totalMHT)
        Me.Controls.Add(Me.txt_totalQ)
        Me.Controls.Add(Me.txt_totalPU)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lst_montantHT)
        Me.Controls.Add(Me.lst_qauntite)
        Me.Controls.Add(Me.lst_prixU)
        Me.Controls.Add(Me.lst_produit)
        Me.Controls.Add(Me.btn_quiter)
        Me.Controls.Add(Me.btn_calculer)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Cmb_produit)
        Me.Controls.Add(Me.btn_modifier)
        Me.Controls.Add(Me.btn_supp)
        Me.Controls.Add(Me.btn_ajouter)
        Me.Controls.Add(Me.txt_montant)
        Me.Controls.Add(Me.txt_prixU)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frm_Gestion"
        Me.Text = "Gestion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_prixU As TextBox
    Friend WithEvents txt_montant As TextBox
    Friend WithEvents btn_ajouter As Button
    Friend WithEvents btn_supp As Button
    Friend WithEvents btn_modifier As Button
    Friend WithEvents Cmb_produit As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btn_calculer As Button
    Friend WithEvents btn_quiter As Button
    Friend WithEvents lst_produit As ListBox
    Friend WithEvents lst_prixU As ListBox
    Friend WithEvents lst_qauntite As ListBox
    Friend WithEvents lst_montantHT As ListBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_totalPU As TextBox
    Friend WithEvents txt_totalQ As TextBox
    Friend WithEvents txt_totalMHT As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txt_TVA As TextBox
    Friend WithEvents txt_remise As TextBox
    Friend WithEvents txt_quantite As TextBox
    Friend WithEvents txt_modifier As TextBox
End Class
