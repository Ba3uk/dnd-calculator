using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.MainLogic
{
    public class GenericProvider<TKey, TComponent>
    {
        protected Dictionary<TKey, TComponent> _values;

        public void Register(TKey key, TComponent value)
        {
            if (!_values.TryAdd(key, value))
            {
                Debug.LogError($"Value with id = {key} was added before");
            }
        }

        public void UnRegister(TKey key)
        {
            if (!_values.Remove(key))
            {
                Debug.LogError($"Value with id = {key} was  removed before");
            }
        }

        public bool TryGetValue(TKey key, out TComponent value)
        {
            return _values.TryGetValue(key, out value);
        }
    }
}
