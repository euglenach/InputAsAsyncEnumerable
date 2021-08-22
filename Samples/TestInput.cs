using System;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.Linq;
using Cysharp.Threading.Tasks.Triggers;
using InputAsAE.Trigger;
using UnityEngine;

namespace InputAsAE{
    public class TestInput : MonoBehaviour{
        private void Start(){
            InputAsAsyncEnumerable.GetKey(KeyCode.Space)
                                  .ForEachAwaitWithCancellationAsync(async (_,ct) => {
                                      Debug.Log("Space");
                                      await UniTask.DelayFrame(100, cancellationToken : ct);
                                  },this.GetCancellationTokenOnDestroy());

            this.OnKeyAsAsyncEnumerable(KeyCode.A)
                .ForEachAwaitWithCancellationAsync(async (_,ct) => {
                    Debug.Log("A");
                    await UniTask.DelayFrame(100, cancellationToken : ct);
                },this.GetCancellationTokenOnDestroy());
            
        }
    }
}
