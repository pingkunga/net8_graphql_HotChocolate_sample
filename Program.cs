using GraphQLAPI.GraphQL.Mutation;
using GraphQLAPI.GraphQL.Query;
using GraphQLAPI.GraphQL.Type;
using GraphQLAPI.Infra;
using GraphQLAPI.Infra.Repositories;
using GraphQLAPI.Services;
using HotChocolate.AspNetCore;
using HotChocolate.AspNetCore.Playground;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddAutoMapper(typeof(Program));
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Repiository
builder.Services.AddScoped<ISupplierRepository, SupplierRepository>();

//Service
builder.Services.AddScoped<ISupplierService, SupplierService>();

builder.Services.AddGraphQLServer()
                .AddType<SupplierType>()
                .AddQueryType<SupplierGraphQLQuery>()
                .AddMutationType<SupplierGraphQLMutation>(); // Register the mutation type

String connectionString = builder.Configuration.GetConnectionString("TiDBConnn");
builder.Services.AddDbContext<DataDBContext>(opt => opt.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));


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

app.UsePlayground(new PlaygroundOptions
{
    QueryPath = "/graphql",
    Path = "/playground"
});
app.MapGraphQL(); //for frontend

app.Run();
