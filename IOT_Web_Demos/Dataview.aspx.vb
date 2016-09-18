Imports IOT_Web_Demos.MySqlDatabase
Imports System.Net.Sockets
Public Class Dataview
    Inherits System.Web.UI.Page

    Dim db As New MySqlDatabase.Database

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            sensors.DataSource = db.GetDataReader("select sensortype,sensorname from sensortype order by sensortype")
            sensors.DataBind()
            sensors.Items.Insert(0, "所有传感器")
        End If
    End Sub

    Sub MyGridViewBind(sql As String)
        MyGridView.DataSource = db.GetDataReader(sql)
        MyGridView.DataBind()
    End Sub

    Private Sub dataview_LoadComplete(sender As Object, e As EventArgs) Handles Me.LoadComplete
        If IsPostBack Then
            Dim csName As [String] = "ButtonClickScript"
            Dim csType As Type = Me.[GetType]()

            ' Get a ClientScriptManager reference from the Page class. 
            Dim csm As ClientScriptManager = Page.ClientScript

            ' Check to see if the client script is already registered. 
            If Not csm.IsClientScriptBlockRegistered(csType, csName) Then
                Dim csText As New StringBuilder()
                csText.Append("<script type=""text/javascript""> function DoClick() {")
                csText.Append("document.getElementById('MainContent_Button1').click(); }")
                csText.Append("var t1 = window.setTimeout(DoClick,5000); ")
                csText.Append(" </script>")
                csm.RegisterClientScriptBlock(csType, csName, csText.ToString())
            End If
        End If
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sensor, sql As String
        sensor = sensors.SelectedValue
        If sensor = "所有传感器" Then
            sql = "select d.no as 序号 ,d.src as 节点号,d.datetime as 日期时间,s.sensorname as 传感器 ,d.value1 as 数据值1,d.value2 as 数据值2 from data d, sensortype s where d.sensortype=s.sensortype order by no desc limit 0,1"
        Else
            sql = "select d.no as 序号 ,d.src as 节点号,d.datetime as 日期时间,s.sensorname as 传感器 ,d.value1 as 数据值1,d.value2 as 数据值2 from data d, sensortype s where d.sensortype=s.sensortype and d.sensortype= " & sensor & " order by no desc limit 0,1"
        End If
        MyGridViewBind(sql)
    End Sub

    Protected Sub MyGridView_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MyGridView.SelectedIndexChanged

    End Sub
End Class