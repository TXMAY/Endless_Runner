using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutineCache
{
    private class Compare : IEqualityComparer<float>
    {
        public bool Equals(float x, float y)
        {
            return x == y;
        }

        public int GetHashCode(float hash)
        {
            return hash.GetHashCode();
        }
    }

    private static Dictionary<float, WaitForSeconds> dictionary = new Dictionary<float, WaitForSeconds>(new Compare());

    public static WaitForSeconds WaitForSecond(float time)
    {
        WaitForSeconds waitForSeconds;
        if (!dictionary.TryGetValue(time, out waitForSeconds))
        {
            dictionary.Add(time, waitForSeconds = new WaitForSeconds(time));
        }

        return waitForSeconds;
    }
}
