﻿using ICities;

namespace Mapper
{
    public class MapperMod : IUserMod
    {
        public string Name
        {
            get
            {
                return "Open City Maps";
            }
        }
        public string Description
        {
            get
            {
                return "Import Cities from Open Street Map";
            }
        }
    }
}
