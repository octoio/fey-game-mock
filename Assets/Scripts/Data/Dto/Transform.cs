using System;
using UnityEngine;

namespace Octoio.Fey.Data.Dto
{
    [Serializable]
    public class Transform
    {
        public Vector3 Position { get; private set; }
        public Vector3 Rotation { get; private set; }
        public Vector3 Scale { get; private set; }
    }
}
