using System;
using UnityEngine;

namespace Octoio.Fey.Data.Dto
{
    [Serializable]
    public class Cursor
    {
        public Type.Cursor Type { get; private set; }
        public EntityReference IconReference { get; private set; }
        public Vector2 HotSpot { get; private set; }
    }
}
