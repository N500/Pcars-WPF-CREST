Imports System.IO
Imports System.Net
Imports System.Text
Imports Pcars_WPF.Example
Imports Newtonsoft.Json
Imports System.Windows.Threading

Partial Public Class MainWindow
    Inherits Window

    Private dt As New DispatcherTimer With {.Interval = TimeSpan.FromMilliseconds(1)}



    Public Sub New()

        InitializeComponent()

        AddHandler dt.Tick, AddressOf Timer1_Tick

    End Sub
    <MTAThread>
    Public Async Function getjson() As Task(Of String)

        Dim url As String = String.Format("http://localhost:8080/crest/v1/api")

        Dim request As HttpWebRequest = DirectCast(WebRequest.Create(url), HttpWebRequest)

        Using response As WebResponse = request.GetResponse()

            Using responsestream As Stream = response.GetResponseStream()

                Dim Reader As New StreamReader(responsestream, Encoding.UTF8)

                Return Await Task.Run(Function() Reader.ReadToEnd())

            End Using

        End Using

    End Function

    Public Async Sub Timer1_Tick(sender As Object, e As EventArgs)

        Dim jsonreturn As String = Await getjson()

        Dim r = JsonConvert.DeserializeObject(Of SampleResponse1)(jsonreturn)

        ProgressBar1.Maximum = Math.Max(r.CarState.MMaxRPM, r.CarState.MRpm)

        ProgressBar1.Value = r.CarState.MRpm

        Label1.Text = CType(r.CarState.MRpm, String)

    End Sub


    Public Sub Button1_Click_1(sender As Object, e As RoutedEventArgs) Handles Button1.Click
        dt.IsEnabled = True
        dt.Start()
    End Sub

End Class