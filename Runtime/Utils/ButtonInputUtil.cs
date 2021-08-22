using System;
using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.Linq;
using UnityEngine;

namespace InputAsAE.Utils{
    internal static class ButtonInputUtil{
        internal enum InputType{
            GetButton, GetButtonDown, GetButtonUp
        }

        private static readonly Dictionary<InputType, Func<string, bool>> inputTable = new Dictionary<InputType, Func<string, bool>>{
                {InputType.GetButton, Input.GetButton},
                {InputType.GetButtonDown, Input.GetButtonDown},
                {InputType.GetButtonUp, Input.GetButtonUp}
            };

        internal static IUniTaskAsyncEnumerable<AsyncUnit> CreateAsyncEnumerable(InputType inputType, string buttonName) =>
            UniTaskAsyncEnumerable.EveryUpdate()
                                  .Where(_ => inputTable[inputType](buttonName));
    }
}
