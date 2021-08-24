using System;
using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.Linq;
using UnityEngine;

namespace InputAsAE.Internal{
    internal static class AxisInputUtil{
        internal enum InputType{
            Axis, AxisRaw
        }
        private static readonly Dictionary<InputType, Func<string, float>> inputTable = new Dictionary<InputType, Func<string, float>>{
            {InputType.Axis, Input.GetAxis},
            {InputType.AxisRaw, Input.GetAxisRaw}
        };

        internal static IUniTaskAsyncEnumerable<float> CreateAsyncEnumerable(InputType inputType, string axisName) =>
            UniTaskAsyncEnumerable.EveryUpdate()
                                  .Select(_ => inputTable[inputType](axisName));
    }
}
