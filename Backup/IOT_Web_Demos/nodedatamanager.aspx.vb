Imports IOT_Web_Demos.MySqlDatabase

Public Class nodedatamanager
    Inherits System.Web.UI.Page

    Dim db As New MySqlDatabase.Database

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        NodeDataViewBind()

        If Not IsPostBack Then
            nodelist.DataSource = db.GetDataReader("select srcno,location from srcs order by srcno")
            nodelist.DataBind()
            nodelist.Items.Insert(0, "所有节点")
        End If
    End Sub

    Sub NodeDataViewBind()
        nodedataView.DataSource = db.GetDataReader("select srcno as 节点号,location as 地点, 传感器名称, 数据量 from srcs left join (select src as 节点号,s.sensorname as 传感器名称 ,count(*) as 数据量 from data d, sensortype s,srcs n where(d.sensortype = s.sensortype) group by 节点号 ,传感器名称) a on srcs.srcno=a.节点号")
        nodedataView.DataBind()
    End Sub
End Class