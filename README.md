# ServerSideAnalytics
AspNet Core component for server side analytics (SSA)

Live demo running at [https://matteofabbri.org/stat](https://matteofabbri.org/stat)

## How to
The very basic use of analytics is invoking the UseServerSideAnalytics extension in your application startup code

```csharp
// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
public void Configure(IApplicationBuilder app)
{
   app.UseServerSideAnalytics(new MongoAnalyticStore("mongodb://192.168.0.11/matteo"));
}
```

I'm using Mongo DB to store my data because is my preferred database but you can you whatever database system you like, by implementing IAnalyticStore or by using one of my nugget: 

[https://www.nuget.org/packages/ServerSideAnalytics.Mongo](https://www.nuget.org/packages/ServerSideAnalytics.Mongo)

[https://www.nuget.org/packages/ServerSideAnalytics.SqlServer](https://www.nuget.org/packages/ServerSideAnalytics.SqlServer)

[https://www.nuget.org/packages/ServerSideAnalytics.Sqlite](https://www.nuget.org/packages/ServerSideAnalytics.Sqlite)

## Reading from the store
To show collected data in your app the best practice is to use the dependency injection pattern, like any other AspNet Core service. 
To do that bind IAnalyticStore into the ConfigureServices system method.

```csharp
//Startup.cs


//Asp Net Core system call where service are binded to container 
public void ConfigureServices(IServiceCollection services)
{
   //Here we bind IAnalyticStore to READ
   services.AddTransient<IAnalyticStore>(_=> GetAnalyticStore());
}

//Asp Net Core system call where web application is setted up
public void Configure(IApplicationBuilder app)
{
   //Here we bind IAnalyticStore to WRITE
   app.UseServerSideAnalytics(GetAnalyticStore());
}

private IAnalyticStore GetAnalyticStore() => 
	new MongoAnalyticStore("mongodb://192.168.0.11/matteo");
```

## Configuring the analytic system
By default Server Side Analytic keeps trace of every request. 
But obviously not everyone cares of every request that comes to his web application. 
By making this system running for a month I found thousand of request from crawlers fetching robots.txt and honestly I don't care about them. 
So how to filter request we don't care of ? By fluid extension methods. Here a brief example copy pasted from my website

```csharp
//Startup.cs            

public void Configure(IApplicationBuilder app)
{
    app.UseServerSideAnalytics(GetAnalyticStore())
	
	// Request into those url spaces will be not recorded
        .ExcludePath("/js", "/lib","/css")     
        
	// Request ending with this extension will be not recorded
	.ExcludeExtension(".jpg", ".ico", "robots.txt", "sitemap.xml")
        
        // Request coming from local host will be not recorded
        .ExcludeLoopBack();         
}
```

## Configuring analytics for API
What I shown above is a way to configure analytics for a web site but what if I want to use server side analytics just to measure the usage of my API ? 
Just exclude anything else by using the fluid method LimitToPath

```csharp
//Startup.cs            

public void Configure(IApplicationBuilder app)
{
     app.UseServerSideAnalytics(GetAnalyticStore())
         //Anything outside of this url space will be ignored
        .LimitToPath("/webapi");
}
```

## Configuring the store
Every store takes use two default table (or collection on Mongo) to store his data:

SSARequest : to store recieved requests
SSAGeoIp: to store IP address ranges used in ip geo coding

```csharp
private IAnalyticStore GetAnalyticStore() => 
	(new SqlServerAnalyticStore(Config.ConnectionString))
	
	    //Change the default table where request are stored
	    .RequestTable("MyRequestTable")
	
             //Change the default table where request are stored
	     .GeoIpTable("MyGeoIpTable");
```

## IP Geocoding
The store tries to resolve the country of incoming request by IP geocoding on local database via those methods: 
StoreGeoIpRangeAsync: which stores an IP range and relative country
ResolveCountryCodeAsync: which is called by ServerSideAnalytics internals to detect the country of incoming requests

If no corresponding IP range has been found CountryCode.World is assigned to the request.
Filling the database with IP range can be quite painfully, I spent hours downloading CSV from different sources just found that biggest part of detected countries was wrong or not found. 
So I wrote an another library ServerSideAnalytics.Extensions which contains some useful methods for make calculation on requests time series and three extension to add remote ip geocoding. 
Those extensions will encapsulate the current store into another which will try to resolve the geocoding locally and if it fails makes a call to a remote service to obtain the country and store it into local database

```csharp
//Startup.cs            

public IAnalyticStore GetAnalyticStore()
{
     var store = (new MongoAnalyticStore("mongodb://192.168.0.11/matteo"))
				   
	         //Use Ip Stack remote service (https://ipstack.com/)
		.UseIpStackFailOver("API KEY")
				   
		 //Use Ip Api remote service (http://ip-api.com)
		.UseIpApiFailOver()
				   
		  //Use Ip Info remote service (https://ipinfo.io/)
		.UseIpInfoFailOver("MY TOKEN");

	return store;
}
```
