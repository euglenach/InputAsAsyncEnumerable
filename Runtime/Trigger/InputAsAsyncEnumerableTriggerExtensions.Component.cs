using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.Linq;
using InputAsAE.Utils;
using UnityEngine;

namespace InputAsAE.Trigger{
    public static class InputAsAsyncEnumerableTriggerExtensions{
        public static IUniTaskAsyncEnumerable<AsyncUnit> OnKeyAsAsyncEnumerable(this Component component, KeyCode keyCode){
            return KeyInputUtil.CreateAsyncEnumerable(KeyInputUtil.InputType.GetKey, keyCode)
                               .TakeUntilCanceled(component.GetCancellationTokenOnDestroy());
        }
        
        public static IUniTaskAsyncEnumerable<AsyncUnit> OnKeyDownAsAsyncEnumerable(this Component component, KeyCode keyCode){
            return KeyInputUtil.CreateAsyncEnumerable(KeyInputUtil.InputType.GetKeyDown, keyCode)
                               .TakeUntilCanceled(component.GetCancellationTokenOnDestroy());
        }
        
        public static IUniTaskAsyncEnumerable<AsyncUnit> GetKeyUp(this Component component, KeyCode keyCode){
            return KeyInputUtil.CreateAsyncEnumerable(KeyInputUtil.InputType.GetKeyUp, keyCode)
                               .TakeUntilCanceled(component.GetCancellationTokenOnDestroy());
        }
        
        public static IUniTaskAsyncEnumerable<AsyncUnit> OnAnyKeyAsAsyncEnumerable(this Component component){
            return KeyInputUtil.CreateAsyncEnumerable(KeyInputUtil.InputType.anyKey)
                               .TakeUntilCanceled(component.GetCancellationTokenOnDestroy());
        }
        
        public static IUniTaskAsyncEnumerable<AsyncUnit> OnAnyKeyDownAsAsyncEnumerable(this Component component){
            return KeyInputUtil.CreateAsyncEnumerable(KeyInputUtil.InputType.anyKeyDown)
                               .TakeUntilCanceled(component.GetCancellationTokenOnDestroy());
        }
        
        public static IUniTaskAsyncEnumerable<float> OnAxisAsAsyncEnumerable(this Component component, string axisName){
            return AxisInputUtil.CreateAsyncEnumerable(AxisInputUtil.InputType.Axis, axisName)
                                .TakeUntilCanceled(component.GetCancellationTokenOnDestroy());
        }
        
        public static IUniTaskAsyncEnumerable<float> OnAxisRawAsAsyncEnumerable(this Component component, string axisName){
            return AxisInputUtil.CreateAsyncEnumerable(AxisInputUtil.InputType.AxisRaw, axisName)
                                .TakeUntilCanceled(component.GetCancellationTokenOnDestroy());
        }
        
        public static IUniTaskAsyncEnumerable<AsyncUnit> OnMouseButtonAsAsyncEnumerable(this Component component, int button){
            return  MouseButtonInputUtil.CreateAsyncEnumerable(MouseButtonInputUtil.InputType.GetMouseButton, button)
                                        .TakeUntilCanceled(component.GetCancellationTokenOnDestroy());
        }
        
        public static IUniTaskAsyncEnumerable<AsyncUnit> OnMouseButtonDownAsAsyncEnumerable(this Component component, int button){
            return  MouseButtonInputUtil.CreateAsyncEnumerable(MouseButtonInputUtil.InputType.GetMouseButtonDown, button)
                                        .TakeUntilCanceled(component.GetCancellationTokenOnDestroy());
        }
        
        public static IUniTaskAsyncEnumerable<AsyncUnit> OnButtonUpAsAsyncEnumerable(this Component component, int button){
            return  MouseButtonInputUtil.CreateAsyncEnumerable(MouseButtonInputUtil.InputType.GetMouseButtonUp, button)
                                        .TakeUntilCanceled(component.GetCancellationTokenOnDestroy());
        }
        
        public static IUniTaskAsyncEnumerable<AsyncUnit> OnButtonAsAsyncEnumerable(this Component component, string buttonName){
            return ButtonInputUtil.CreateAsyncEnumerable(ButtonInputUtil.InputType.GetButton, buttonName)
                                  .TakeUntilCanceled(component.GetCancellationTokenOnDestroy());
        }
        
        public static IUniTaskAsyncEnumerable<AsyncUnit> OnButtonDownAsAsyncEnumerable(this Component component, string buttonName){
            return ButtonInputUtil.CreateAsyncEnumerable(ButtonInputUtil.InputType.GetButtonDown, buttonName)
                                  .TakeUntilCanceled(component.GetCancellationTokenOnDestroy());
        }
        
        public static IUniTaskAsyncEnumerable<AsyncUnit> OnButtonUpAsAsyncEnumerable(this Component component, string buttonName){
            return ButtonInputUtil.CreateAsyncEnumerable(ButtonInputUtil.InputType.GetButtonUp, buttonName)
                                  .TakeUntilCanceled(component.GetCancellationTokenOnDestroy());
        }
    }
}
