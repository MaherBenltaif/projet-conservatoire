<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Professeur
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Classebox = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtAdresse = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTel = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPrenom = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNom = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtsalaire = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Classebox
        '
        Me.Classebox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Classebox.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Classebox.FormattingEnabled = True
        Me.Classebox.Items.AddRange(New Object() {"Guitare 1", "Guitare 2", "Violent 1", "Violent 2", "Piano 1"})
        Me.Classebox.Location = New System.Drawing.Point(287, 439)
        Me.Classebox.Name = "Classebox"
        Me.Classebox.Size = New System.Drawing.Size(538, 35)
        Me.Classebox.TabIndex = 87
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(460, 609)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(139, 49)
        Me.Button1.TabIndex = 94
        Me.Button1.Text = "Annuler"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(300, 609)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(139, 49)
        Me.Button2.TabIndex = 93
        Me.Button2.Text = "Enregistrer"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(73, 499)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 27)
        Me.Label1.TabIndex = 92
        Me.Label1.Text = "Salaire :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(74, 442)
        Me.Label7.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 27)
        Me.Label7.TabIndex = 91
        Me.Label7.Text = "Classe :"
        '
        'txtAdresse
        '
        Me.txtAdresse.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdresse.Location = New System.Drawing.Point(288, 354)
        Me.txtAdresse.Multiline = True
        Me.txtAdresse.Name = "txtAdresse"
        Me.txtAdresse.Size = New System.Drawing.Size(537, 71)
        Me.txtAdresse.TabIndex = 84
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(73, 357)
        Me.Label5.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 27)
        Me.Label5.TabIndex = 88
        Me.Label5.Text = "Adresse :"
        '
        'txtTel
        '
        Me.txtTel.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTel.Location = New System.Drawing.Point(288, 307)
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Size = New System.Drawing.Size(538, 34)
        Me.txtTel.TabIndex = 83
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(74, 307)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 27)
        Me.Label4.TabIndex = 85
        Me.Label4.Text = "Tel :"
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(288, 254)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(538, 34)
        Me.txtEmail.TabIndex = 81
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(74, 254)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 27)
        Me.Label3.TabIndex = 82
        Me.Label3.Text = "Email :"
        '
        'txtPrenom
        '
        Me.txtPrenom.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrenom.Location = New System.Drawing.Point(288, 202)
        Me.txtPrenom.Name = "txtPrenom"
        Me.txtPrenom.Size = New System.Drawing.Size(538, 34)
        Me.txtPrenom.TabIndex = 80
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(74, 205)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 27)
        Me.Label2.TabIndex = 79
        Me.Label2.Text = "Prenom :"
        '
        'txtNom
        '
        Me.txtNom.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNom.Location = New System.Drawing.Point(287, 146)
        Me.txtNom.Name = "txtNom"
        Me.txtNom.Size = New System.Drawing.Size(538, 34)
        Me.txtNom.TabIndex = 78
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(74, 149)
        Me.Label10.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(74, 27)
        Me.Label10.TabIndex = 77
        Me.Label10.Text = "Nom :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft YaHei", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(218, 32)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(462, 57)
        Me.Label8.TabIndex = 95
        Me.Label8.Text = "Nouveau Professeur"
        '
        'txtsalaire
        '
        Me.txtsalaire.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsalaire.Location = New System.Drawing.Point(287, 496)
        Me.txtsalaire.Name = "txtsalaire"
        Me.txtsalaire.Size = New System.Drawing.Size(538, 34)
        Me.txtsalaire.TabIndex = 96
        '
        'Professeur
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(898, 713)
        Me.Controls.Add(Me.txtsalaire)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Classebox)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtAdresse)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtTel)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtPrenom)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNom)
        Me.Controls.Add(Me.Label10)
        Me.Name = "Professeur"
        Me.Text = "Ajout Professeur"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Classebox As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtAdresse As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtTel As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPrenom As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNom As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtsalaire As TextBox
End Class
