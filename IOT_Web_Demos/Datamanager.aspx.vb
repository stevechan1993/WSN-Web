Imports IOT_Web_Demos.MySqlDatabase

Public Class Datamanager
    Inherits System.Web.UI.Page

    Dim db As New MySqlDatabase.Database

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        statisticsViewBind()
        If Not IsPostBack Then
            sensors.DataSource = db.GetDataReader("select sensortype,sensorname from sensortype order by sensortype")
            sensors.DataBind()
            sensors.Items.Insert(0, "所有传感器")
        End If
    End Sub

    Sub statisticsViewBind()
        statisticsView.DataSource = db.GetDataReader("select d.sensortype as 传感器类型,s.sensorname as 传感器名称,count(*) as 数据量 from data d, sensortype s where d.sensortype=s.sensortype group by 传感器类型,传感器名称 order by d.sensortype ")
        statisticsView.DataBind()
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sensor, sql As String

        sensor = sensors.SelectedValue
        If sensor = "所有传感器" Then
            sql = "delete from data"
        Else
            sql = "delete from data where sensortype= " & sensor
        End If
        db.DeleteData(sql)
        statisticsViewBind()
    End Sub

End Class