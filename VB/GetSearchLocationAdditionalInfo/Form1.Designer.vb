Namespace GetSearchLocationAdditionalInfo

    Partial Class Form1

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
            Me.panel1 = New System.Windows.Forms.Panel()
            Me.tbResults = New System.Windows.Forms.RichTextBox()
            Me.panelControl2 = New DevExpress.XtraEditors.PanelControl()
            Me.search = New System.Windows.Forms.Button()
            Me.labelControl2 = New DevExpress.XtraEditors.LabelControl()
            Me.tbLocation = New DevExpress.XtraEditors.TextEdit()
            CType((Me.panelControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl1.SuspendLayout()
            Me.panel1.SuspendLayout()
            CType((Me.panelControl2), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl2.SuspendLayout()
            CType((Me.tbLocation.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' panelControl1
            ' 
            Me.panelControl1.Controls.Add(Me.panel1)
            Me.panelControl1.Controls.Add(Me.panelControl2)
            Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Right
            Me.panelControl1.Location = New System.Drawing.Point(355, 0)
            Me.panelControl1.Name = "panelControl1"
            Me.panelControl1.Size = New System.Drawing.Size(338, 451)
            Me.panelControl1.TabIndex = 0
            ' 
            ' panel1
            ' 
            Me.panel1.Controls.Add(Me.tbResults)
            Me.panel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.panel1.Location = New System.Drawing.Point(2, 45)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(334, 404)
            Me.panel1.TabIndex = 2
            ' 
            ' tbResults
            ' 
            Me.tbResults.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tbResults.Location = New System.Drawing.Point(0, 0)
            Me.tbResults.Name = "tbResults"
            Me.tbResults.[ReadOnly] = True
            Me.tbResults.Size = New System.Drawing.Size(334, 404)
            Me.tbResults.TabIndex = 15
            Me.tbResults.Text = ""
            ' 
            ' panelControl2
            ' 
            Me.panelControl2.Controls.Add(Me.tbLocation)
            Me.panelControl2.Controls.Add(Me.search)
            Me.panelControl2.Controls.Add(Me.labelControl2)
            Me.panelControl2.Dock = System.Windows.Forms.DockStyle.Top
            Me.panelControl2.Location = New System.Drawing.Point(2, 2)
            Me.panelControl2.Name = "panelControl2"
            Me.panelControl2.Size = New System.Drawing.Size(334, 43)
            Me.panelControl2.TabIndex = 1
            ' 
            ' search
            ' 
            Me.search.Location = New System.Drawing.Point(184, 10)
            Me.search.Name = "search"
            Me.search.Size = New System.Drawing.Size(75, 23)
            Me.search.TabIndex = 10
            Me.search.Text = "Search"
            Me.search.UseVisualStyleBackColor = True
            AddHandler Me.search.Click, New System.EventHandler(AddressOf Me.search_Click)
            ' 
            ' labelControl2
            ' 
            Me.labelControl2.Location = New System.Drawing.Point(17, 15)
            Me.labelControl2.Name = "labelControl2"
            Me.labelControl2.Size = New System.Drawing.Size(44, 13)
            Me.labelControl2.TabIndex = 2
            Me.labelControl2.Text = "Location:"
            ' 
            ' tbLocation
            ' 
            Me.tbLocation.EditValue = "LA"
            Me.tbLocation.Location = New System.Drawing.Point(74, 12)
            Me.tbLocation.Name = "tbLocation"
            Me.tbLocation.Size = New System.Drawing.Size(100, 20)
            Me.tbLocation.TabIndex = 14
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(693, 451)
            Me.Controls.Add(Me.panelControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            AddHandler Me.Load, New System.EventHandler(AddressOf Me.Form1_Load)
            CType((Me.panelControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl1.ResumeLayout(False)
            Me.panel1.ResumeLayout(False)
            CType((Me.panelControl2), System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl2.ResumeLayout(False)
            Me.panelControl2.PerformLayout()
            CType((Me.tbLocation.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private panelControl1 As DevExpress.XtraEditors.PanelControl

        Private panel1 As System.Windows.Forms.Panel

        Private panelControl2 As DevExpress.XtraEditors.PanelControl

        Private search As System.Windows.Forms.Button

        Private tbResults As System.Windows.Forms.RichTextBox

        Private tbLocation As DevExpress.XtraEditors.TextEdit

        Private labelControl2 As DevExpress.XtraEditors.LabelControl
    End Class
End Namespace
