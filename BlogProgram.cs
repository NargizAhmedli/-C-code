using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace _19042022
{
    class Post
    {
        public void AddPost(string title, string content)
        {
            Post posts = new Post();
            using (SqlConnection con = new SqlConnection(Sql.ConnectionString))
            {
                con.Open();

                string query = "INSERT INTO Post(Title,Content) VALUES (@title,@content)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddValue("title", posts.Title);
                cmd.Parameters.AddValue("content", posts.Content);
            }
        }

        public Post GetPostById(int id)
        {
            Post posts = new Post();
            using (SqlConnection con = new SqlConnection(Sql.ConnectionString))
            {
                con.Open();

                string query = "SELECT * FROM Post WHERE Id=@id";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddValue("id", id);
                cmd.Parameters.AddValue("id", id);
                using (SqlDataReader dr = cmd.ExecuteReader())
                {

                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {

                            posts.Id = dr.GetInt32(0);
                            posts.Title = dr.GetString(1);
                            posts.Content = dr.GetString(2);
                        }
                        return posts;
                    }
                    return null;

                }
            }
        }

        public List<Post> GetAllPosts()
        {
            List<Post> posts = new List<Post>();
            using (SqlConnection con = new SqlConnection(Sql.ConnectionString))
            {
                con.Open();

                string query = "SELECT *FROM Post";
                SqlCommand cmd = new SqlCommand(query, con);
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        Post post = new Post
                        {
                            Id = rd.GetInt32(0),
                            Title = rd.GetString(1),
                            Content = rd.GetString(2)
                        };
                        posts.Add(post);
                    }
                    return posts;
                }

            }
        }
    
       

        public void DeletePost(int id)
        {
            using (SqlConnection con = new SqlConnection(Sql.ConnectionString))
            {
                con.Open();

                string query = "DELETE * FROM Post AS P WHERE P.Id=" + id;
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
            }
        }

        public void EditPostTitle(int id)
        {

            using (SqlConnection con = new SqlConnection(Sql.ConnectionString))
            {
                con.Open();

                string query = "UPDATE Post SET Title='value' WHERE Id=@id";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddValue("id", id);


            }
        }

    }
}
