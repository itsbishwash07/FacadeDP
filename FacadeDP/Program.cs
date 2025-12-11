using FacadeDP;
using Microsoft.AspNetCore.Builder;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddTransient<INotificationService, NotificationService>();
builder.Services.AddTransient<IinventoryService, InventoryService>();
builder.Services.AddTransient<IPaymentService, PaymentService>();

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();

var app = builder.Build();

//if (app.Environment.IsDevelopment())
//{
//    app.UseSwagger();
//    app.UseSwaggerUI();
//}

app.MapControllers();

app.Run();
