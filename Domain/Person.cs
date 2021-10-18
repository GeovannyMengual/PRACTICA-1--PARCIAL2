using System;

namespace QueryApi.Domain
{
    //Este apartado para nuestra consulta de datos, por  lo tanto declaramo de la siguiente manera
    public record Person(int Id, string FirstName, string LastName, string Email, char Gender, string Job, int Age);
}