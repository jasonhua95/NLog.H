# NLog.H
The easiest and easy to use Nlog。
```
Log.Info("Info");
Log.Error("Error");
```

### Create a nlog.config file.
Create nlog.config (lowercase all) file in the root of your project.

 ```
 <?xml version="1.0" encoding="utf-8" ?>
<nlog xmlns="http://www.nlog-project.org/schemas/NLog.xsd"
      xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
      autoReload="true"
      internalLogLevel="Info"
      internalLogFile="E:\VS2019\NLog.HTest\log\internal-nlog.log">

  <!-- enable asp.net core layout renderers -->
  <!--<extensions>
    <add assembly="NLog.Web.AspNetCore"/>
  </extensions>-->

  <!-- the targets to write to -->
  <targets>
    <!-- write logs to file  -->
    <target xsi:type="File" name="allfile" fileName="E:\VS2019\NLog.HTest\log\nlog-all-${shortdate}.log"
            layout="${longdate}|${event-properties:item=EventId_Id}|${uppercase:${level}}|${logger}|${message} ${exception:format=tostring}" />

    <!-- another file log, only own logs. Uses some ASP.NET core renderers -->
    <!--<target xsi:type="File" name="ownFile-web" fileName="E:\GitPublic\GithubWeb\GithubTest\log\nlog-own-${shortdate}.log"
            layout="${longdate}|${event-properties:item=EventId_Id}|${uppercase:${level}}|${logger}|${message} ${exception:format=tostring}|url: ${aspnet-request-url}|action: ${aspnet-mvc-action}" />-->
  </targets>

  <!-- rules to map from logger name to target -->
  <rules>
    <!--All logs, including from Microsoft-->
    <logger name="*" minlevel="Trace" writeTo="allfile" />

    <!--Skip non-critical Microsoft logs and so log only own logs-->
    <logger name="Microsoft.*" maxlevel="Info" final="true" />
    <!-- BlackHole without writeTo -->
    <!--<logger name="*" minlevel="Trace" writeTo="ownFile-web" />-->
  </rules>
</nlog>
 ```
 
### nlog.config need Always Copy
```
<ItemGroup>
<None Update="nlog.config">
  <CopyToOutputDirectory>Always</CopyToOutputDirectory>
</None>
</ItemGroup>
```
 
