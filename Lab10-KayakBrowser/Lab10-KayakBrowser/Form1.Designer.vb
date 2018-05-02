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
        Me.components = New System.ComponentModel.Container()
        Me.KayakTypesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KayaksDataSet = New Lab10_KayakBrowser.KayaksDataSet()
        Me.KayakTypesTableAdapter = New Lab10_KayakBrowser.KayaksDataSetTableAdapters.KayakTypesTableAdapter()
        Me.lstKayakName = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableAdapterManager = New Lab10_KayakBrowser.KayaksDataSetTableAdapters.TableAdapterManager()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        CType(Me.KayakTypesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KayaksDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KayakTypesBindingSource
        '
        Me.KayakTypesBindingSource.DataMember = "KayakTypes"
        Me.KayakTypesBindingSource.DataSource = Me.KayaksDataSet
        '
        'KayaksDataSet
        '
        Me.KayaksDataSet.DataSetName = "KayaksDataSet"
        Me.KayaksDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'KayakTypesTableAdapter
        '
        Me.KayakTypesTableAdapter.ClearBeforeFill = True
        '
        'lstKayakName
        '
        Me.lstKayakName.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.KayakTypesBindingSource, "Description", True))
        Me.lstKayakName.DataSource = Me.KayakTypesBindingSource
        Me.lstKayakName.DisplayMember = "Name"
        Me.lstKayakName.FormattingEnabled = True
        Me.lstKayakName.Location = New System.Drawing.Point(12, 63)
        Me.lstKayakName.Name = "lstKayakName"
        Me.lstKayakName.Size = New System.Drawing.Size(120, 95)
        Me.lstKayakName.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(202, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Select a Kayak type to view a description"
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.KayakTypesTableAdapter = Me.KayakTypesTableAdapter
        Me.TableAdapterManager.UpdateOrder = Lab10_KayakBrowser.KayaksDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'txtDescription
        '
        Me.txtDescription.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KayakTypesBindingSource, "Description", True))
        Me.txtDescription.Location = New System.Drawing.Point(182, 63)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(250, 100)
        Me.txtDescription.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(485, 261)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstKayakName)
        Me.Name = "Form1"
        Me.Text = "Kayak Browser"
        CType(Me.KayakTypesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KayaksDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents KayaksDataSet As KayaksDataSet
    Friend WithEvents KayakTypesBindingSource As BindingSource
    Friend WithEvents KayakTypesTableAdapter As KayaksDataSetTableAdapters.KayakTypesTableAdapter
    Friend WithEvents lstKayakName As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TableAdapterManager As KayaksDataSetTableAdapters.TableAdapterManager
    Friend WithEvents txtDescription As TextBox
End Class
