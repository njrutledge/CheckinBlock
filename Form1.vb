
Imports System.Threading.Tasks
Public Class Form1
    Private WithEvents countdownTimer As New Timer()

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.


        Me.TopMost = True

        'SchedulePopupAt4PM()
    End Sub

    Private Sub btnStartTimer_Click(sender As Object, e As EventArgs) Handles btnStartTimer.Click
        btnStartTimer.Enabled = False
        countdownTimer.Interval = 1000
        AddHandler countdownTimer.Tick, AddressOf UpdateCountdown
        remainingTime = 20
        countdownTimer.Enabled = True
        btnClose.Text = $"{remainingTime} sec remaining"

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        btnClose.Enabled = False

        Close()
    End Sub

    Private remainingTime As Integer = 20

    Public Sub UpdateCountdown(sender As Object, e As EventArgs)
        If remainingTime > 0 Then
            remainingTime -= 1
            btnClose.Text = $"{remainingTime} sec remaining"
        Else
            btnClose.Enabled = True
            countdownTimer.Stop()
            btnClose.Text = "Close"
            countdownTimer.Enabled = False
        End If
    End Sub

    'Private Sub SchedulePopupAt4PM()
    ' Schedule a task using Task Scheduler to run your app every day at 3 PM
    'Dim taskScheduler = New Microsoft.Win32.TaskScheduler()
    '   taskScheduler.Connect()
    '
    'Dim taskDef As ITaskDefinition = taskScheduler.NewTask(0)
    '    taskDef.RegistrationInfo.Description = "Popup App at 3 PM"
    '    taskDef.Principal.UserId = "NT AUTHORITY\SYSTEM"

    'Dim trigger As ITrigger = taskDef.Triggers.Create(_
    '        TaskTriggerType.Daily,
    '        1,
    '0,
    '0,
    '15,
    '0)
    '
    '   Dim execAction As IExecAction = CType(taskDef.Actions.Create(TaskActionType.Execute), IExecAction)
    '      execAction.Path = Application.ExecutablePath
    '
    'Dim rootFolder As ITaskFolder = taskScheduler.GetFolder("\")
    '   rootFolder.RegisterTaskDefinition(
    '      "PopupAppTask",
    '     taskDef,
    'CInt(TaskCreation.CreateOrUpdate),
    '        Nothing,
    '        Nothing,
    '        TaskLogonType.InteractiveToken,
    '        Nothing)
    'End Sub



End Class
