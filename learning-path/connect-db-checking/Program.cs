using connect_db_checking.Context;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var context = new DuyContext("server=localhost;port=3306;database=ASP_web_empty;user=duyaiti;password=12345678");
var list = context.GetStudents();

app.MapGet("/", () => "List student: \n\n" + string.Join("\n", list));
// app.MapMethods()
app.MapGet(pattern: "/{id}", () => "Student :\n\n" + context.GetStudent(1));
app.Run();
