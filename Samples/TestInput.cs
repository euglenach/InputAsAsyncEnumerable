using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.Linq;
using UnityEngine;

namespace InputAsAE{
    public class TestInput : MonoBehaviour{
        private void Start(){
            InputAsAsyncEnumerable
                .GetKey(KeyCode.Space)
                .ForEachAwaitWithCancellationAsync(async (_, ct) => {
                    Debug.Log("Space");
                    await UniTask.DelayFrame(100, cancellationToken : ct);
                }, this.GetCancellationTokenOnDestroy());
        }
    }
}
