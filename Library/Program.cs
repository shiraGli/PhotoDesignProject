using Solid.Core.Repository;
using Solid.Core.Servise;
using Solid.Data;
using Solid.Servise;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//builder.Services.AddSingleton<DataContext>();
builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();
builder.Services.AddScoped<ICustomerServise, CustomerServise>();
builder.Services.AddScoped<IAccountRepository, AccountRepository>();
builder.Services.AddScoped<IAccountServise, AccountServise>();
builder.Services.AddScoped<IWriterRepository, WriterRepository>();
builder.Services.AddScoped<IWriterServise, WriterServise>();
builder.Services.AddScoped<ILendRepository, LendRepository>();
builder.Services.AddScoped<ILendServise, LendServise>();
builder.Services.AddScoped<IBookRepository, BookRepository>();
builder.Services.AddScoped<IBookServise, BookServise>();
builder.Services.AddScoped<IBook_on_loanRepository, Book_on_loanRepository>();
builder.Services.AddScoped<IBook_on_loanServise, Book_on_loanServise>();
builder.Services.AddScoped<ICityRepository, CityRepository>();
builder.Services.AddScoped<ICityService, CityService>();
builder.Services.AddDbContext<DataContext>();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
