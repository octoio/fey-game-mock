using System;
using UnityEngine;

namespace Octoio.Fey.Data.Dto
{
    [Serializable]
    public class Quality
    {
        public Metadata Metadata { get; private set; }
        public Type.Quality Type { get; private set; }
        public Color Color { get; private set; }
        public Color TextColor { get; private set; }
        public Color TextOverColor { get; private set; }
    }
}
