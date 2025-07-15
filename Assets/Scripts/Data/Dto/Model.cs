using System;
using UnityEngine.Rendering;

namespace Octoio.Fey.Data.Dto
{
    [Serializable]
    public class Model
    {
        public string Path { get; private set; }
        public Transform Transform { get; private set; }
        public ShadowCastingMode ShadowCastingMode { get; private set; }
    }
}
