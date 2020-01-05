Imports LiveCharts
Imports LiveCharts.Uwp
' 空白ページの項目テンプレートについては、https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x411 を参照してください

''' <summary>
''' それ自体で使用できる空白ページまたはフレーム内に移動できる空白ページ。
''' </summary>
Public NotInheritable Class MainPage
    Inherits Page

    Private m_nHistgram(255) As Integer
    Private m_seriesCollection As SeriesCollection = New SeriesCollection()

    ''' <summary>
    ''' コンストラクタ
    ''' </summary>
    Public Sub New()

        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()

        ' InitializeComponent() 呼び出しの後で初期化を追加します。

    End Sub

    ''' <summary>
    ''' グラフ描画ボタンのクリックイベント
    ''' </summary>
    ''' <param name="sender">オブジェクト</param>
    ''' <param name="e">ルーティングイベントのデータ</param>
    Private Sub OnClickDrawGraph(sender As Object, e As RoutedEventArgs)
        DrawHistgram()
        Return
    End Sub

    ''' <summary>
    ''' グラフ描画処理
    ''' </summary>
    Public Sub DrawHistgram()
        Dim chartValue = New ChartValues(Of Integer)()
        For nIdx As Integer = 0 To m_nHistgram.Length - 1
            m_nHistgram(nIdx) = nIdx
            chartValue.Add(m_nHistgram(nIdx))
        Next nIdx

        Dim SeriesCollection = New SeriesCollection()

        Dim lineSeriesChart = New LineSeries With
        {
            .Values = chartValue
        }
        SeriesCollection.Add(lineSeriesChart)

        m_seriesCollection = SeriesCollection
        LiveChartsGraph.Series = m_seriesCollection
    End Sub
End Class
