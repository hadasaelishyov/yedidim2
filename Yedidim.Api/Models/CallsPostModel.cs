﻿namespace Yedidim.Api.Models
{
    public class CallsPostModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }

        public int IdTypesOfCall { get; set; }

        public int IdVolunteer { get; set; }
    }
}
