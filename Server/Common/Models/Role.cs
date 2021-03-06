﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GodCommon.Models
{
    public class Role
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual int Level { get; set; }
        public virtual bool IsMan { get; set; }
        public virtual User User { get; set; }
        public virtual int Exp { get; set; }
        public virtual int Coin { get; set; }
        public virtual int Diamond { get; set; }
        public virtual int Energy { get; set; }
        public virtual int Toughen { get; set; }
    }
}
