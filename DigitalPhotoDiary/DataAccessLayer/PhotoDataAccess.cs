using DigitalPhotoDiary.DataAccessLayer.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalPhotoDiary.DataAccessLayer
{
    class PhotoDataAccess: DataAccess
    {
        public Photo GetPhoto(int eventId, string name)
        {
            string sql = "SELECT * FROM Photos WHERE EventId=" + eventId + " AND Name= '"+name+"'";
            SqlDataReader reader = this.GetData(sql);
            if (reader.Read())
            {
                Photo photo = new Photo();
                photo.PhotoId = Convert.ToInt32(reader["PhotoId"]);
                photo.PhotoName = reader["Name"].ToString();
                photo.Directory = reader["Directory"].ToString();
                photo.Story = reader["Story"].ToString();
                photo.EventId = Convert.ToInt32(reader["EventId"]);
                return photo;
            }
            return null;
        }

       
        public int AddPhoto(Photo photo)
        {
            string sql = "INSERT INTO Photos(Name,Directory,Story,EventId) VALUES ('" + photo.PhotoName + "', '" + photo.Directory + "','" + photo.Story + "'," + photo.EventId+")";
            return this.ExecuteQuery(sql);
        }

        public int UpdatePhoto(string directory, int photoId)
        {
            string sql = "UPDATE Photos SET Directory='" + directory + "' WHERE PhotoId=" + photoId;
            return this.ExecuteQuery(sql);
        }
        public int UpdateStory(string story, int photoId)
        {
            string sql = "UPDATE Photos SET Story='" + story + "' WHERE PhotoId=" + photoId;
            return this.ExecuteQuery(sql);
        }
    }
}
