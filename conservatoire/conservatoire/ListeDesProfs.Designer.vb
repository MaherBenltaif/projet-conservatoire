<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ListeDesProfs
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnSupprimer = New System.Windows.Forms.Button()
        Me.btnEditer = New System.Windows.Forms.Button()
        Me.btnNouveau = New System.Windows.Forms.Button()
        Me.btnRafraichir = New System.Windows.Forms.Button()
        Me.ListViewProfs = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'btnSupprimer
        '
        Me.btnSupprimer.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.btnSupprimer.Font = New System.Drawing.Font("Microsoft YaHei", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSupprimer.Location = New System.Drawing.Point(483, 31)
        Me.btnSupprimer.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSupprimer.Name = "btnSupprimer"
        Me.btnSupprimer.Size = New System.Drawing.Size(140, 31)
        Me.btnSupprimer.TabIndex = 11
        Me.btnSupprimer.Text = "Supprimer"
        Me.btnSupprimer.UseVisualStyleBackColor = False
        '
        'btnEditer
        '
        Me.btnEditer.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.btnEditer.Font = New System.Drawing.Font("Microsoft YaHei", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditer.Location = New System.Drawing.Point(326, 31)
        Me.btnEditer.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnEditer.Name = "btnEditer"
        Me.btnEditer.Size = New System.Drawing.Size(140, 31)
        Me.btnEditer.TabIndex = 10
        Me.btnEditer.Text = "Editer"
        Me.btnEditer.UseVisualStyleBackColor = False
        '
        'btnNouveau
        '
        Me.btnNouveau.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.btnNouveau.Font = New System.Drawing.Font("Microsoft YaHei", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNouveau.Location = New System.Drawing.Point(169, 31)
        Me.btnNouveau.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnNouveau.Name = "btnNouveau"
        Me.btnNouveau.Size = New System.Drawing.Size(140, 31)
        Me.btnNouveau.TabIndex = 9
        Me.btnNouveau.Text = "Nouveau"
        Me.btnNouveau.UseVisualStyleBackColor = False
        '
        'btnRafraichir
        '
        Me.btnRafraichir.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.btnRafraichir.Font = New System.Drawing.Font("Microsoft YaHei", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRafraichir.Location = New System.Drawing.Point(12, 31)
        Me.btnRafraichir.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnRafraichir.Name = "btnRafraichir"
        Me.btnRafraichir.Size = New System.Drawing.Size(140, 31)
        Me.btnRafraichir.TabIndex = 8
        Me.btnRafraichir.Text = "Rafraîchir"
        Me.btnRafraichir.UseVisualStyleBackColor = False
        '
        'ListViewProfs
        '
        Me.ListViewProfs.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ListViewProfs.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader7, Me.ColumnHeader8})
        Me.ListViewProfs.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListViewProfs.FullRowSelect = True
        Me.ListViewProfs.GridLines = True
        Me.ListViewProfs.HideSelection = False
        Me.ListViewProfs.Location = New System.Drawing.Point(12, 81)
        Me.ListViewProfs.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ListViewProfs.Name = "ListViewProfs"
        Me.ListViewProfs.Size = New System.Drawing.Size(1861, 881)
        Me.ListViewProfs.TabIndex = 7
        Me.ListViewProfs.UseCompatibleStateImageBehavior = False
        Me.ListViewProfs.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Nom"
        Me.ColumnHeader1.Width = 134
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Prenom"
        Me.ColumnHeader2.Width = 154
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Email"
        Me.ColumnHeader3.Width = 204
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Tel"
        Me.ColumnHeader4.Width = 146
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Adresse"
        Me.ColumnHeader5.Width = 250
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Classe"
        Me.ColumnHeader7.Width = 144
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Salaire"
        Me.ColumnHeader8.Width = 134
        '
        'ListeDesProfs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1885, 975)
        Me.Controls.Add(Me.btnSupprimer)
        Me.Controls.Add(Me.btnEditer)
        Me.Controls.Add(Me.btnNouveau)
        Me.Controls.Add(Me.btnRafraichir)
        Me.Controls.Add(Me.ListViewProfs)
        Me.Name = "ListeDesProfs"
        Me.Text = "ListeDesProfs"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnSupprimer As Button
    Friend WithEvents btnEditer As Button
    Friend WithEvents btnNouveau As Button
    Friend WithEvents btnRafraichir As Button
    Friend WithEvents ListViewProfs As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
End Class
