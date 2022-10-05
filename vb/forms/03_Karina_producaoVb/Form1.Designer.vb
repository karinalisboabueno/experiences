<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BtnCopiaBD = New System.Windows.Forms.Button()
        Me.BtnInserirNaBd = New System.Windows.Forms.Button()
        Me.TxtQuilometragem = New System.Windows.Forms.TextBox()
        Me.TxtDiaSemana = New System.Windows.Forms.TextBox()
        Me.TxtMarcaViatura = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnDeletaBD = New System.Windows.Forms.Button()
        Me.BtnLimpaGrid = New System.Windows.Forms.Button()
        Me.TxtSoma1 = New System.Windows.Forms.TextBox()
        Me.TxtSoma2 = New System.Windows.Forms.TextBox()
        Me.BtnSomaKm = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.BtnListBoxKm = New System.Windows.Forms.Button()
        Me.BtnModificaRegisto = New System.Windows.Forms.Button()
        Me.BtnContaViagens = New System.Windows.Forms.Button()
        Me.TxtViatura = New System.Windows.Forms.TextBox()
        Me.TxtTotalViagens = New System.Windows.Forms.TextBox()
        Me.BtnRemoverViagem = New System.Windows.Forms.Button()
        Me.TxtEliminaViagem = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(22, 21)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(518, 208)
        Me.DataGridView1.TabIndex = 0
        '
        'BtnCopiaBD
        '
        Me.BtnCopiaBD.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnCopiaBD.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnCopiaBD.Location = New System.Drawing.Point(22, 244)
        Me.BtnCopiaBD.Name = "BtnCopiaBD"
        Me.BtnCopiaBD.Size = New System.Drawing.Size(100, 42)
        Me.BtnCopiaBD.TabIndex = 1
        Me.BtnCopiaBD.Text = "3- Copia BD "
        Me.BtnCopiaBD.UseVisualStyleBackColor = False
        '
        'BtnInserirNaBd
        '
        Me.BtnInserirNaBd.Location = New System.Drawing.Point(340, 316)
        Me.BtnInserirNaBd.Name = "BtnInserirNaBd"
        Me.BtnInserirNaBd.Size = New System.Drawing.Size(109, 23)
        Me.BtnInserirNaBd.TabIndex = 2
        Me.BtnInserirNaBd.Text = "2 - Inserir dados"
        Me.BtnInserirNaBd.UseVisualStyleBackColor = True
        '
        'TxtQuilometragem
        '
        Me.TxtQuilometragem.Location = New System.Drawing.Point(234, 317)
        Me.TxtQuilometragem.Name = "TxtQuilometragem"
        Me.TxtQuilometragem.Size = New System.Drawing.Size(100, 23)
        Me.TxtQuilometragem.TabIndex = 3
        '
        'TxtDiaSemana
        '
        Me.TxtDiaSemana.Location = New System.Drawing.Point(128, 318)
        Me.TxtDiaSemana.Name = "TxtDiaSemana"
        Me.TxtDiaSemana.Size = New System.Drawing.Size(100, 23)
        Me.TxtDiaSemana.TabIndex = 4
        '
        'TxtMarcaViatura
        '
        Me.TxtMarcaViatura.Location = New System.Drawing.Point(22, 318)
        Me.TxtMarcaViatura.Name = "TxtMarcaViatura"
        Me.TxtMarcaViatura.Size = New System.Drawing.Size(100, 23)
        Me.TxtMarcaViatura.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 300)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 15)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Marca"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(128, 300)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(24, 15)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Dia"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(239, 299)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 15)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Quilometros"
        '
        'BtnDeletaBD
        '
        Me.BtnDeletaBD.BackColor = System.Drawing.Color.Red
        Me.BtnDeletaBD.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnDeletaBD.Location = New System.Drawing.Point(153, 244)
        Me.BtnDeletaBD.Name = "BtnDeletaBD"
        Me.BtnDeletaBD.Size = New System.Drawing.Size(93, 42)
        Me.BtnDeletaBD.TabIndex = 9
        Me.BtnDeletaBD.Text = "1 - Deleta BD"
        Me.BtnDeletaBD.UseVisualStyleBackColor = False
        '
        'BtnLimpaGrid
        '
        Me.BtnLimpaGrid.Location = New System.Drawing.Point(276, 244)
        Me.BtnLimpaGrid.Name = "BtnLimpaGrid"
        Me.BtnLimpaGrid.Size = New System.Drawing.Size(90, 42)
        Me.BtnLimpaGrid.TabIndex = 10
        Me.BtnLimpaGrid.Text = "4- Limpa Grid"
        Me.BtnLimpaGrid.UseVisualStyleBackColor = True
        '
        'TxtSoma1
        '
        Me.TxtSoma1.Location = New System.Drawing.Point(22, 376)
        Me.TxtSoma1.Name = "TxtSoma1"
        Me.TxtSoma1.Size = New System.Drawing.Size(100, 23)
        Me.TxtSoma1.TabIndex = 11
        '
        'TxtSoma2
        '
        Me.TxtSoma2.Location = New System.Drawing.Point(234, 376)
        Me.TxtSoma2.Name = "TxtSoma2"
        Me.TxtSoma2.Size = New System.Drawing.Size(100, 23)
        Me.TxtSoma2.TabIndex = 12
        '
        'BtnSomaKm
        '
        Me.BtnSomaKm.Location = New System.Drawing.Point(128, 376)
        Me.BtnSomaKm.Name = "BtnSomaKm"
        Me.BtnSomaKm.Size = New System.Drawing.Size(100, 23)
        Me.BtnSomaKm.TabIndex = 13
        Me.BtnSomaKm.Text = "5-Soma Km"
        Me.BtnSomaKm.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 357)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 15)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Marca"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(237, 357)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 15)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Resultado Soma"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 15
        Me.ListBox1.Location = New System.Drawing.Point(654, 21)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(126, 214)
        Me.ListBox1.TabIndex = 16
        '
        'BtnListBoxKm
        '
        Me.BtnListBoxKm.Location = New System.Drawing.Point(654, 244)
        Me.BtnListBoxKm.Name = "BtnListBoxKm"
        Me.BtnListBoxKm.Size = New System.Drawing.Size(126, 42)
        Me.BtnListBoxKm.TabIndex = 17
        Me.BtnListBoxKm.Text = "7- Copia Viatura List"
        Me.BtnListBoxKm.UseVisualStyleBackColor = True
        '
        'BtnModificaRegisto
        '
        Me.BtnModificaRegisto.Location = New System.Drawing.Point(396, 244)
        Me.BtnModificaRegisto.Name = "BtnModificaRegisto"
        Me.BtnModificaRegisto.Size = New System.Drawing.Size(85, 42)
        Me.BtnModificaRegisto.TabIndex = 18
        Me.BtnModificaRegisto.Text = "8 -Modificar Registo"
        Me.BtnModificaRegisto.UseVisualStyleBackColor = True
        '
        'BtnContaViagens
        '
        Me.BtnContaViagens.Location = New System.Drawing.Point(128, 420)
        Me.BtnContaViagens.Name = "BtnContaViagens"
        Me.BtnContaViagens.Size = New System.Drawing.Size(118, 25)
        Me.BtnContaViagens.TabIndex = 19
        Me.BtnContaViagens.Text = "6- Conta viagens"
        Me.BtnContaViagens.UseVisualStyleBackColor = True
        '
        'TxtViatura
        '
        Me.TxtViatura.Location = New System.Drawing.Point(22, 420)
        Me.TxtViatura.Name = "TxtViatura"
        Me.TxtViatura.Size = New System.Drawing.Size(100, 23)
        Me.TxtViatura.TabIndex = 20
        '
        'TxtTotalViagens
        '
        Me.TxtTotalViagens.Location = New System.Drawing.Point(252, 422)
        Me.TxtTotalViagens.Name = "TxtTotalViagens"
        Me.TxtTotalViagens.Size = New System.Drawing.Size(100, 23)
        Me.TxtTotalViagens.TabIndex = 21
        '
        'BtnRemoverViagem
        '
        Me.BtnRemoverViagem.Location = New System.Drawing.Point(478, 381)
        Me.BtnRemoverViagem.Name = "BtnRemoverViagem"
        Me.BtnRemoverViagem.Size = New System.Drawing.Size(129, 23)
        Me.BtnRemoverViagem.TabIndex = 22
        Me.BtnRemoverViagem.Text = "Remover Viagem"
        Me.BtnRemoverViagem.UseVisualStyleBackColor = True
        '
        'TxtEliminaViagem
        '
        Me.TxtEliminaViagem.Location = New System.Drawing.Point(613, 382)
        Me.TxtEliminaViagem.Name = "TxtEliminaViagem"
        Me.TxtEliminaViagem.Size = New System.Drawing.Size(100, 23)
        Me.TxtEliminaViagem.TabIndex = 23
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(839, 21)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(136, 23)
        Me.ComboBox1.TabIndex = 24
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1029, 517)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.TxtEliminaViagem)
        Me.Controls.Add(Me.BtnRemoverViagem)
        Me.Controls.Add(Me.TxtTotalViagens)
        Me.Controls.Add(Me.TxtViatura)
        Me.Controls.Add(Me.BtnContaViagens)
        Me.Controls.Add(Me.BtnModificaRegisto)
        Me.Controls.Add(Me.BtnListBoxKm)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.BtnSomaKm)
        Me.Controls.Add(Me.TxtSoma2)
        Me.Controls.Add(Me.TxtSoma1)
        Me.Controls.Add(Me.BtnLimpaGrid)
        Me.Controls.Add(Me.BtnDeletaBD)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtMarcaViatura)
        Me.Controls.Add(Me.TxtDiaSemana)
        Me.Controls.Add(Me.TxtQuilometragem)
        Me.Controls.Add(Me.BtnInserirNaBd)
        Me.Controls.Add(Me.BtnCopiaBD)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BtnCopiaBD As Button
    Friend WithEvents BtnInserirNaBd As Button
    Friend WithEvents TxtQuilometragem As TextBox
    Friend WithEvents TxtDiaSemana As TextBox
    Friend WithEvents TxtMarcaViatura As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnDeletaBD As Button
    Friend WithEvents BtnLimpaGrid As Button
    Friend WithEvents TxtSoma1 As TextBox
    Friend WithEvents TxtSoma2 As TextBox
    Friend WithEvents BtnSomaKm As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents BtnListBoxKm As Button
    Friend WithEvents BtnModificaRegisto As Button
    Friend WithEvents BtnContaViagens As Button
    Friend WithEvents TxtViatura As TextBox
    Friend WithEvents TxtTotalViagens As TextBox
    Friend WithEvents BtnRemoverViagem As Button
    Friend WithEvents TxtEliminaViagem As TextBox
    Friend WithEvents ComboBox1 As ComboBox
End Class
