using System.Data.SqlClient;
using Dapper;
using Series.Models;
namespace Series.Models;
public class BD{


private static string _connectionString = @"Server=localhost;
DataBase=BDSeries;Trusted_Connection=True;";


public static List<Serie> ObtenerSeries(){
    
    using(SqlConnection db = new SqlConnection(_connectionString)){
        string sql = "select * from Series";
        return db.Query<Serie>(sql).ToList();
    }
}

public static List<Temporadas> ObtenerTemporadas(){
    
    using(SqlConnection db = new SqlConnection(_connectionString)){
        string sql = "select * from Temporadas";
        return db.Query<Temporadas>(sql).ToList();
    }
}

public static List<Actores> ObtenerActores(){
    
    using(SqlConnection db = new SqlConnection(_connectionString)){
        string sql = "select * from Actores";
        return db.Query<Actores>(sql).ToList();
    }
}



}