<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
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
        Me.components = New System.ComponentModel.Container()
        Me.data = New System.Windows.Forms.DataGridView()
        Me.clnRank = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clnAward_level = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clnid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clnEventid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clnrank_delta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clnfame_points_to_improve_award = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clnupdated_at = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clnbattles = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clnclan_rank = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clnclan_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clnurl = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clnbattles_to_award = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clnfame_points = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clnfront_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clnNickName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clnClanname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clnRealm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clndate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TakeSnapButton = New System.Windows.Forms.Button()
        Me.ViewDatabaseButton = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.UpdateNamesButton = New System.Windows.Forms.Button()
        Me.TotalRecordsLabel = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Progress = New System.Windows.Forms.ProgressBar()
        Me.CheckButton = New System.Windows.Forms.Button()
        Me.CompareButton = New System.Windows.Forms.Button()
        CType(Me.data, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'data
        '
        Me.data.AllowUserToAddRows = False
        Me.data.AllowUserToDeleteRows = False
        Me.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.data.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clnRank, Me.clnAward_level, Me.clnid, Me.clnEventid, Me.clnrank_delta, Me.clnfame_points_to_improve_award, Me.clnupdated_at, Me.clnbattles, Me.clnclan_rank, Me.clnclan_id, Me.clnurl, Me.clnbattles_to_award, Me.clnfame_points, Me.clnfront_id, Me.clnNickName, Me.clnClanname, Me.clnRealm, Me.clndate})
        Me.data.Location = New System.Drawing.Point(12, 42)
        Me.data.Name = "data"
        Me.data.ReadOnly = True
        Me.data.RowTemplate.Height = 25
        Me.data.Size = New System.Drawing.Size(823, 150)
        Me.data.TabIndex = 0
        '
        'clnRank
        '
        Me.clnRank.HeaderText = "Rank"
        Me.clnRank.Name = "clnRank"
        Me.clnRank.ReadOnly = True
        '
        'clnAward_level
        '
        Me.clnAward_level.HeaderText = "award_level"
        Me.clnAward_level.Name = "clnAward_level"
        Me.clnAward_level.ReadOnly = True
        '
        'clnid
        '
        Me.clnid.HeaderText = "Account ID"
        Me.clnid.Name = "clnid"
        Me.clnid.ReadOnly = True
        '
        'clnEventid
        '
        Me.clnEventid.HeaderText = "Event ID"
        Me.clnEventid.Name = "clnEventid"
        Me.clnEventid.ReadOnly = True
        '
        'clnrank_delta
        '
        Me.clnrank_delta.HeaderText = "rank_delta"
        Me.clnrank_delta.Name = "clnrank_delta"
        Me.clnrank_delta.ReadOnly = True
        '
        'clnfame_points_to_improve_award
        '
        Me.clnfame_points_to_improve_award.HeaderText = "fame_points_to_improve_award"
        Me.clnfame_points_to_improve_award.Name = "clnfame_points_to_improve_award"
        Me.clnfame_points_to_improve_award.ReadOnly = True
        '
        'clnupdated_at
        '
        Me.clnupdated_at.HeaderText = "updated_at"
        Me.clnupdated_at.Name = "clnupdated_at"
        Me.clnupdated_at.ReadOnly = True
        '
        'clnbattles
        '
        Me.clnbattles.HeaderText = "battles"
        Me.clnbattles.Name = "clnbattles"
        Me.clnbattles.ReadOnly = True
        '
        'clnclan_rank
        '
        Me.clnclan_rank.HeaderText = "clan_rank"
        Me.clnclan_rank.Name = "clnclan_rank"
        Me.clnclan_rank.ReadOnly = True
        '
        'clnclan_id
        '
        Me.clnclan_id.HeaderText = "clan_id"
        Me.clnclan_id.Name = "clnclan_id"
        Me.clnclan_id.ReadOnly = True
        '
        'clnurl
        '
        Me.clnurl.HeaderText = "url"
        Me.clnurl.Name = "clnurl"
        Me.clnurl.ReadOnly = True
        '
        'clnbattles_to_award
        '
        Me.clnbattles_to_award.HeaderText = "battles_to_award"
        Me.clnbattles_to_award.Name = "clnbattles_to_award"
        Me.clnbattles_to_award.ReadOnly = True
        '
        'clnfame_points
        '
        Me.clnfame_points.HeaderText = "fame_points"
        Me.clnfame_points.Name = "clnfame_points"
        Me.clnfame_points.ReadOnly = True
        '
        'clnfront_id
        '
        Me.clnfront_id.HeaderText = "front_id"
        Me.clnfront_id.Name = "clnfront_id"
        Me.clnfront_id.ReadOnly = True
        '
        'clnNickName
        '
        Me.clnNickName.HeaderText = "Nickname"
        Me.clnNickName.Name = "clnNickName"
        Me.clnNickName.ReadOnly = True
        '
        'clnClanname
        '
        Me.clnClanname.HeaderText = "Clan"
        Me.clnClanname.Name = "clnClanname"
        Me.clnClanname.ReadOnly = True
        '
        'clnRealm
        '
        Me.clnRealm.HeaderText = "Realm"
        Me.clnRealm.Name = "clnRealm"
        Me.clnRealm.ReadOnly = True
        '
        'clndate
        '
        Me.clndate.HeaderText = "Date"
        Me.clndate.Name = "clndate"
        Me.clndate.ReadOnly = True
        '
        'TakeSnapButton
        '
        Me.TakeSnapButton.Location = New System.Drawing.Point(13, 13)
        Me.TakeSnapButton.Name = "TakeSnapButton"
        Me.TakeSnapButton.Size = New System.Drawing.Size(97, 23)
        Me.TakeSnapButton.TabIndex = 1
        Me.TakeSnapButton.Text = "Take Snapshot"
        Me.TakeSnapButton.UseVisualStyleBackColor = True
        '
        'ViewDatabaseButton
        '
        Me.ViewDatabaseButton.Location = New System.Drawing.Point(116, 13)
        Me.ViewDatabaseButton.Name = "ViewDatabaseButton"
        Me.ViewDatabaseButton.Size = New System.Drawing.Size(94, 23)
        Me.ViewDatabaseButton.TabIndex = 1
        Me.ViewDatabaseButton.Text = "View Database"
        Me.ViewDatabaseButton.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'UpdateNamesButton
        '
        Me.UpdateNamesButton.Location = New System.Drawing.Point(216, 13)
        Me.UpdateNamesButton.Name = "UpdateNamesButton"
        Me.UpdateNamesButton.Size = New System.Drawing.Size(128, 23)
        Me.UpdateNamesButton.TabIndex = 1
        Me.UpdateNamesButton.Text = "UpdateNames"
        Me.UpdateNamesButton.UseVisualStyleBackColor = True
        '
        'TotalRecordsLabel
        '
        Me.TotalRecordsLabel.AutoSize = True
        Me.TotalRecordsLabel.Location = New System.Drawing.Point(420, 17)
        Me.TotalRecordsLabel.Name = "TotalRecordsLabel"
        Me.TotalRecordsLabel.Size = New System.Drawing.Size(80, 15)
        Me.TotalRecordsLabel.TabIndex = 2
        Me.TotalRecordsLabel.Text = "Total Records:"
        '
        'Progress
        '
        Me.Progress.Location = New System.Drawing.Point(627, 12)
        Me.Progress.Name = "Progress"
        Me.Progress.Size = New System.Drawing.Size(221, 23)
        Me.Progress.Step = 1
        Me.Progress.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.Progress.TabIndex = 3
        '
        'CheckButton
        '
        Me.CheckButton.Location = New System.Drawing.Point(350, 12)
        Me.CheckButton.Name = "CheckButton"
        Me.CheckButton.Size = New System.Drawing.Size(64, 24)
        Me.CheckButton.TabIndex = 4
        Me.CheckButton.Text = "Check"
        Me.CheckButton.UseVisualStyleBackColor = True
        '
        'CompareButton
        '
        Me.CompareButton.Location = New System.Drawing.Point(557, 13)
        Me.CompareButton.Name = "CompareButton"
        Me.CompareButton.Size = New System.Drawing.Size(64, 24)
        Me.CompareButton.TabIndex = 4
        Me.CompareButton.Text = "Compare"
        Me.CompareButton.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(860, 346)
        Me.Controls.Add(Me.CompareButton)
        Me.Controls.Add(Me.CheckButton)
        Me.Controls.Add(Me.Progress)
        Me.Controls.Add(Me.TotalRecordsLabel)
        Me.Controls.Add(Me.UpdateNamesButton)
        Me.Controls.Add(Me.ViewDatabaseButton)
        Me.Controls.Add(Me.TakeSnapButton)
        Me.Controls.Add(Me.data)
        Me.Name = "MainForm"
        Me.Text = "WoT BanWave v1"
        CType(Me.data, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents data As DataGridView
    Friend WithEvents TakeSnapButton As Button
    Friend WithEvents ViewDatabaseButton As Button
    Friend WithEvents clnRank As DataGridViewTextBoxColumn
    Friend WithEvents clnAward_level As DataGridViewTextBoxColumn
    Friend WithEvents clnid As DataGridViewTextBoxColumn
    Friend WithEvents clnEventid As DataGridViewTextBoxColumn
    Friend WithEvents clnrank_delta As DataGridViewTextBoxColumn
    Friend WithEvents clnfame_points_to_improve_award As DataGridViewTextBoxColumn
    Friend WithEvents clnupdated_at As DataGridViewTextBoxColumn
    Friend WithEvents clnbattles As DataGridViewTextBoxColumn
    Friend WithEvents clnclan_rank As DataGridViewTextBoxColumn
    Friend WithEvents clnclan_id As DataGridViewTextBoxColumn
    Friend WithEvents clnurl As DataGridViewTextBoxColumn
    Friend WithEvents clnbattles_to_award As DataGridViewTextBoxColumn
    Friend WithEvents clnfame_points As DataGridViewTextBoxColumn
    Friend WithEvents clnfront_id As DataGridViewTextBoxColumn
    Friend WithEvents clnNickName As DataGridViewTextBoxColumn
    Friend WithEvents clnClanname As DataGridViewTextBoxColumn
    Friend WithEvents clnRealm As DataGridViewTextBoxColumn
    Friend WithEvents clndate As DataGridViewTextBoxColumn
    Friend WithEvents Timer1 As Timer
    Friend WithEvents UpdateNamesButton As Button
    Friend WithEvents TotalRecordsLabel As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Progress As ProgressBar
    Friend WithEvents CheckButton As Button
    Friend WithEvents CompareButton As Button
End Class
