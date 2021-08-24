using Cysharp.Threading.Tasks;
using InputAsAE.Internal;
using UnityEngine;

namespace InputAsAE{
    public static class InputAsAsyncEnumerable{
        public static IUniTaskAsyncEnumerable<AsyncUnit> GetKey(KeyCode keyCode){
            return KeyInputUtil.CreateAsyncEnumerable(KeyInputUtil.InputType.GetKey, keyCode);
        }
        
        public static IUniTaskAsyncEnumerable<AsyncUnit> GetKeyDown(KeyCode keyCode){
            return KeyInputUtil.CreateAsyncEnumerable(KeyInputUtil.InputType.GetKeyDown, keyCode);
        }

        public static IUniTaskAsyncEnumerable<AsyncUnit> GetKeyUp(KeyCode keyCode){
            return KeyInputUtil.CreateAsyncEnumerable(KeyInputUtil.InputType.GetKeyUp, keyCode);
        }

        public static IUniTaskAsyncEnumerable<AsyncUnit> AnyKey => KeyInputUtil.CreateAsyncEnumerable(KeyInputUtil.InputType.anyKey);
        
        public static IUniTaskAsyncEnumerable<AsyncUnit> AnyKeyDown => KeyInputUtil.CreateAsyncEnumerable(KeyInputUtil.InputType.anyKeyDown);

        public static IUniTaskAsyncEnumerable<float> Axis(string axisName){
            return AxisInputUtil.CreateAsyncEnumerable(AxisInputUtil.InputType.Axis, axisName);
        }
        
        public static IUniTaskAsyncEnumerable<float> AxisRaw(string axisName){
            return AxisInputUtil.CreateAsyncEnumerable(AxisInputUtil.InputType.AxisRaw, axisName);
        }
        
        public static IUniTaskAsyncEnumerable<AsyncUnit> GetMouseButton(int button){
            return  MouseButtonInputUtil.CreateAsyncEnumerable(MouseButtonInputUtil.InputType.GetMouseButton, button);
        }
        
        public static IUniTaskAsyncEnumerable<AsyncUnit> GetMouseButtonDown(int button){
            return  MouseButtonInputUtil.CreateAsyncEnumerable(MouseButtonInputUtil.InputType.GetMouseButtonDown, button);
        }

        public static IUniTaskAsyncEnumerable<AsyncUnit> GetMouseButtonUp(int button){
            return MouseButtonInputUtil.CreateAsyncEnumerable(MouseButtonInputUtil.InputType.GetMouseButtonUp, button);
        }
        
        public static IUniTaskAsyncEnumerable<AsyncUnit> GetButton(string buttonName){
            return ButtonInputUtil.CreateAsyncEnumerable(ButtonInputUtil.InputType.GetButton, buttonName);
        }
        
        public static IUniTaskAsyncEnumerable<AsyncUnit> GetButtonDown(string buttonName){
            return ButtonInputUtil.CreateAsyncEnumerable(ButtonInputUtil.InputType.GetButtonDown, buttonName);
        }
        
        public static IUniTaskAsyncEnumerable<AsyncUnit> GetButtonUp(string buttonName){
            return ButtonInputUtil.CreateAsyncEnumerable(ButtonInputUtil.InputType.GetButtonUp, buttonName);
        }
    }
}