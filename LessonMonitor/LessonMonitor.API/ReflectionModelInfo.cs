using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace LessonMonitor.API
{
    public class ReflectionModelInfo
    {
        public string ModelName { get; set; }
        public List<string> PropertiesNames { get; set; } = new List<string>();
    }
}
