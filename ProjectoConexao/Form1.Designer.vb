<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnregistar = New System.Windows.Forms.Button()
        Me.txtnome = New System.Windows.Forms.TextBox()
        Me.txttelefone = New System.Windows.Forms.TextBox()
        Me.txtapelido = New System.Windows.Forms.TextBox()
        Me.Nome = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtv_clientes = New System.Windows.Forms.DataGridView()
        Me.txtprocurar = New System.Windows.Forms.TextBox()
        Me.btnprocurar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.dtv_clientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnregistar
        '
        Me.btnregistar.Location = New System.Drawing.Point(507, 54)
        Me.btnregistar.Name = "btnregistar"
        Me.btnregistar.Size = New System.Drawing.Size(136, 40)
        Me.btnregistar.TabIndex = 0
        Me.btnregistar.Text = "Registar"
        Me.btnregistar.UseVisualStyleBackColor = True
        '
        'txtnome
        '
        Me.txtnome.Location = New System.Drawing.Point(11, 67)
        Me.txtnome.Multiline = True
        Me.txtnome.Name = "txtnome"
        Me.txtnome.Size = New System.Drawing.Size(135, 27)
        Me.txtnome.TabIndex = 1
        '
        'txttelefone
        '
        Me.txttelefone.Location = New System.Drawing.Point(323, 67)
        Me.txttelefone.Multiline = True
        Me.txttelefone.Name = "txttelefone"
        Me.txttelefone.Size = New System.Drawing.Size(135, 27)
        Me.txttelefone.TabIndex = 2
        '
        'txtapelido
        '
        Me.txtapelido.Location = New System.Drawing.Point(168, 67)
        Me.txtapelido.Multiline = True
        Me.txtapelido.Name = "txtapelido"
        Me.txtapelido.Size = New System.Drawing.Size(135, 27)
        Me.txtapelido.TabIndex = 3
        '
        'Nome
        '
        Me.Nome.AutoSize = True
        Me.Nome.Location = New System.Drawing.Point(11, 38)
        Me.Nome.Name = "Nome"
        Me.Nome.Size = New System.Drawing.Size(45, 17)
        Me.Nome.TabIndex = 4
        Me.Nome.Text = "Nome"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(165, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Apelido"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(320, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Telefone"
        '
        'dtv_clientes
        '
        Me.dtv_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtv_clientes.Location = New System.Drawing.Point(15, 240)
        Me.dtv_clientes.Name = "dtv_clientes"
        Me.dtv_clientes.RowTemplate.Height = 24
        Me.dtv_clientes.Size = New System.Drawing.Size(645, 219)
        Me.dtv_clientes.TabIndex = 7
        '
        'txtprocurar
        '
        Me.txtprocurar.Location = New System.Drawing.Point(317, 139)
        Me.txtprocurar.Multiline = True
        Me.txtprocurar.Name = "txtprocurar"
        Me.txtprocurar.Size = New System.Drawing.Size(182, 37)
        Me.txtprocurar.TabIndex = 8
        '
        'btnprocurar
        '
        Me.btnprocurar.Location = New System.Drawing.Point(509, 139)
        Me.btnprocurar.Name = "btnprocurar"
        Me.btnprocurar.Size = New System.Drawing.Size(136, 37)
        Me.btnprocurar.TabIndex = 9
        Me.btnprocurar.Text = "Procurar"
        Me.btnprocurar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(314, 119)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 17)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Procurar por ID"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtapelido)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnregistar)
        Me.GroupBox1.Controls.Add(Me.btnprocurar)
        Me.GroupBox1.Controls.Add(Me.txtnome)
        Me.GroupBox1.Controls.Add(Me.txtprocurar)
        Me.GroupBox1.Controls.Add(Me.txttelefone)
        Me.GroupBox1.Controls.Add(Me.Nome)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 24)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(656, 191)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(672, 474)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dtv_clientes)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.dtv_clientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnregistar As System.Windows.Forms.Button
    Friend WithEvents txtnome As System.Windows.Forms.TextBox
    Friend WithEvents txttelefone As System.Windows.Forms.TextBox
    Friend WithEvents txtapelido As System.Windows.Forms.TextBox
    Friend WithEvents Nome As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtv_clientes As System.Windows.Forms.DataGridView
    Friend WithEvents txtprocurar As System.Windows.Forms.TextBox
    Friend WithEvents btnprocurar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox

End Class
