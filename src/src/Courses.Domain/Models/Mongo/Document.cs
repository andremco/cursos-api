using Courses.Domain.Interfaces.Mongo;
using MongoDB.Bson;
using System;

namespace Courses.Domain.Models.Mongo
{
    public abstract class Document : IDocument
    {
        public ObjectId Id { get; set; }

        public DateTime CreatedAt => Id.CreationTime;
    }
}
