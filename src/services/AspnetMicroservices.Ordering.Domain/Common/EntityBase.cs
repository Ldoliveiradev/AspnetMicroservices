﻿using System;

namespace AspnetMicroservices.Ordering.Domain.Common
{
    public abstract class EntityBase
    {
        public int Id { get; protected set; }
        public string CreatedBy { get; set; }
        public DateTime CreateDate { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
    }
}
