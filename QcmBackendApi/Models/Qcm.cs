﻿namespace QcmBackendApi.Models
{
    public class Qcm
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Subject { get; set; }
        public int NbPoint { get; set; }
        public string Author { get; set; }
    }
}