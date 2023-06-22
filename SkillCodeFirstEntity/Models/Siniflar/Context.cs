using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace SkillCodeFirstEntity.Models.Siniflar
{
    public class Context:DbContext//BU KISMA VT'de ki TABLOLARIMIZI TANIMLARIZ
    {
        public DbSet<Yetenekler> Yeteneklers { get; set; }
    }
}