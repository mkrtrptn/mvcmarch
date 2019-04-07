using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using AdoMovieGalleryApp.Models;

namespace AdoMovieGalleryApp.Models
{
    public class DAL
    {
        SqlConnection con = new SqlConnection("user id=sa;password=123;database=REMOTE;data source=MUKTAR");
        SqlCommand cmd = new SqlCommand();
        
        public void addmovie(movie m)
        {
            
            cmd.CommandText = "insert into movies values(@movieid,@moviename,@moviefile)";
            cmd.Connection = con;
            cmd.Parameters.AddWithValue("@movieid",m.movieid);
            cmd.Parameters.AddWithValue("@moviename",m.moviename);
            cmd.Parameters.AddWithValue("@moviefile",m.moviefile);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            
        }

        public List<movie> getmovies()
        {
            List<movie> movies = new List<movie>();
            cmd.Connection = con;
            cmd.CommandText = "select * from movies";
            con.Open();

            SqlDataReader dr = cmd.ExecuteReader();

            while(dr.Read())
            {
                movies.Add(new movie { movieid =(Int32)dr["movieid"] , moviename =dr["moviename"].ToString(), moviefile=dr["moviefile"].ToString()  });

            }
            dr.Close();
            con.Close();

            return movies;
            
        }


        public void deletemovie(int movieid)
        {
            cmd.Connection = con;
            cmd.CommandText = "delete from movies where movieid=@movieid";
            cmd.Parameters.AddWithValue("@movieid",movieid);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }




    }
}