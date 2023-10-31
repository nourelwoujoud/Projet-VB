<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_authentifier
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
        Me.txt_login = New System.Windows.Forms.TextBox()
        Me.txt_pw = New System.Windows.Forms.TextBox()
        Me.btn_annuler = New System.Windows.Forms.Button()
        Me.btn_valider = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(325, 101)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(171, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nom Utilisateur :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(325, 158)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(157, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Mot de Passe :"
        '
        'txt_login
        '
        Me.txt_login.Location = New System.Drawing.Point(528, 101)
        Me.txt_login.Name = "txt_login"
        Me.txt_login.Size = New System.Drawing.Size(192, 22)
        Me.txt_login.TabIndex = 2
        '
        'txt_pw
        '
        Me.txt_pw.Location = New System.Drawing.Point(537, 158)
        Me.txt_pw.Name = "txt_pw"
        Me.txt_pw.Size = New System.Drawing.Size(183, 22)
        Me.txt_pw.TabIndex = 3
        Me.txt_pw.UseSystemPasswordChar = True
        '
        'btn_annuler
        '
        Me.btn_annuler.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_annuler.Location = New System.Drawing.Point(433, 264)
        Me.btn_annuler.Name = "btn_annuler"
        Me.btn_annuler.Size = New System.Drawing.Size(98, 39)
        Me.btn_annuler.TabIndex = 4
        Me.btn_annuler.Text = "Annuler"
        Me.btn_annuler.UseVisualStyleBackColor = True
        '
        'btn_valider
        '
        Me.btn_valider.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_valider.Location = New System.Drawing.Point(613, 264)
        Me.btn_valider.Name = "btn_valider"
        Me.btn_valider.Size = New System.Drawing.Size(107, 39)
        Me.btn_valider.TabIndex = 5
        Me.btn_valider.Text = "Valider"
        Me.btn_valider.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Projet_VB.My.Resources.Resources.images
        Me.PictureBox1.Location = New System.Drawing.Point(12, 63)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(307, 284)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'frm_authentifier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(859, 447)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btn_valider)
        Me.Controls.Add(Me.btn_annuler)
        Me.Controls.Add(Me.txt_pw)
        Me.Controls.Add(Me.txt_login)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frm_authentifier"
        Me.Text = "Authentifer"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_login As TextBox
    Friend WithEvents txt_pw As TextBox
    Friend WithEvents btn_annuler As Button
    Friend WithEvents btn_valider As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
