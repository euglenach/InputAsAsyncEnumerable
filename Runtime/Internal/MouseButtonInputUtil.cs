using System;
using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.Linq;
using UnityEngine;

namespace InputAsAE.Internal{
    internal static class MouseButtonInputUtil{
        internal enum InputType{
            GetMouseButton, GetMouseButtonDown, GetMouseButtonUp
        }

        private static readonly Dictionary<InputType, Func<int, bool>> inputTable = new Dictionary<InputType, Func<int, bool>>{
            {InputType.GetMouseButton, Input.GetMouseButton},
            {InputType.GetMouseButtonDown, Input.GetMouseButtonDown},
            {InputType.GetMouseButtonUp, Input.GetMouseButtonUp}
        };

        internal static IUniTaskAsyncEnumerable<AsyncUnit> CreateAsyncEnumerable(InputType inputType, int button) =>
            UniTaskAsyncEnumerable.EveryUpdate()
                                  .Where(_ => inputTable[inputType](button));
    }
}
