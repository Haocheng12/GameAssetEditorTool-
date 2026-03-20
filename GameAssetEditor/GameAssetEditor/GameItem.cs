using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameAssetEditor
{
    public class GameItem
    {
        public string Name { get; set; } = "";
        public string Type { get; set; } = "";
        public int Value { get; set; }
        public string Description { get; set; } = "";

        public override string ToString()
        {
            return Name;
        }
    }
}
