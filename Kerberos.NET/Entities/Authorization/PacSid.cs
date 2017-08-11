﻿using Kerberos.NET.Entities;
using System;
using System.Security.Principal;

namespace Kerberos.NET.Entities.Authorization
{
    [Flags]
    public enum SidAttributes : uint
    {
        SE_GROUP_MANDATORY = 0x00000001,
        SE_GROUP_ENABLED_BY_DEFAULT = 0x00000002,
        SE_GROUP_ENABLED = 0x00000004,
        SE_GROUP_OWNER = 0x00000008,
        SE_GROUP_USE_FOR_DENY_ONLY = 0x00000010,
        SE_GROUP_INTEGRITY = 0x00000020,
        SE_GROUP_INTEGRITY_ENABLED = 0x00000040,
        SE_GROUP_RESOURCE = 0x20000000,
        SE_GROUP_LOGON_ID = 0xC0000000
    }

    public class PacSid
    {
        private readonly SecurityIdentifier id;
        private readonly SidAttributes attributes;
        
        public PacSid(SecurityIdentifier id, SidAttributes attributes)
        {
            this.id = id;
            this.attributes = attributes;
        }

        public SecurityIdentifier Id { get { return id; } }

        public SidAttributes Attributes { get { return attributes; } }
    }
}