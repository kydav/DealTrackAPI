using System;
using Microsoft.EntityFrameworkCore;

namespace DealTrackAPI.Models
{
    public class DealTrackDBContext : DbContext
    {
        //https://www.entityframeworktutorial.net/efcore/create-model-for-existing-database-in-ef-core.aspx
        public DealTrackDBContext()
        {
        }
    }
}
