using System;
using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.Linq;
using UnityEngine;

namespace InputAsAE.Internal{
    internal static class KeyInputUtil{
        internal enum InputType{
            GetKey, GetKeyDown, GetKeyUp, anyKey, anyKeyDown
        }

        private static readonly Dictionary<InputType, Func<KeyCode, bool>> inputTable = new Dictionary<InputType, Func<KeyCode, bool>>{
            {InputType.GetKey, Input.GetKey},
            {InputType.GetKeyDown, Input.GetKeyDown},
            {InputType.GetKeyUp, Input.GetKeyUp},
            {InputType.anyKey, _ => Input.anyKey},
            {InputType.anyKeyDown, _ => Input.anyKeyDown}
        };
        
        internal static IUniTaskAsyncEnumerable<AsyncUnit> CreateAsyncEnumerable(InputType inputType, KeyCode keyCode = KeyCode.None) =>
            UniTaskAsyncEnumerable.EveryUpdate()
                                  .Where(_ => inputTable[inputType](keyCode));
    }
}
