using Ordering.API;
using Ordering.Application;
using Ordering.Infrastructure;

var builder = WebApplication.CreateBuilder(args);
// add services to the container


builder.Services.AddApplicationServices().AddInfrastructureServices(builder.Configuration).AddApiServices();


var app = builder.Build();


//configutre the http request pipeline



app.Run();
