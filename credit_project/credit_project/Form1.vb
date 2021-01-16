Public Class frm_main

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs)
        frm_request.MdiParent = Me
        frm_request.Show()
    End Sub

    Private Sub OpenToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem1.Click
        frm_borrower.MdiParent = Me
        frm_borrower.Show()
    End Sub

    Private Sub OpenToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem2.Click
        frm_session.MdiParent = Me
        frm_session.Show()
    End Sub

    Private Sub OpenToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem3.Click
        frm_project.MdiParent = Me
        frm_project.Show()
    End Sub
    Private Sub frm_main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frm_request.MdiParent = Me
        frm_request.Show()
    End Sub

    Private Sub OpenToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        frm_request.MdiParent = Me
        frm_request.Show()
    End Sub

    Private Sub RequestsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RequestsToolStripMenuItem.Click
        frm_rpt_request.MdiParent = Me
        frm_rpt_request.Show()
    End Sub

    Private Sub RequestAcceptedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RequestAcceptedToolStripMenuItem.Click
        frm_rpt_requestWithSession.MdiParent = Me
        frm_rpt_requestWithSession.Show()
    End Sub

    Private Sub RequestclientToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RequestclientToolStripMenuItem.Click
        frm_rpt3.MdiParent = Me
        frm_rpt3.Show()
    End Sub
End Class
