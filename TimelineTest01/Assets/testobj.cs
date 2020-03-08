using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testobj : MonoBehaviour
{
    public enum TestEnum
    {
        ONE, TWO, THREE
    }

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void Func01(int _arg)
    {
        Debug.Log($"int:{_arg}");
    }
    public void Func02(float _arg)
    {
        Debug.Log($"float:{_arg}");
    }
    public void Func03(string _arg)
    {
        Debug.Log($"string:{_arg}");
    }
    public void Func04(GameObject _arg)
    {
        Debug.Log($"GameObject:{_arg.name}");
    }
    public void Func05(TestEnum _arg)
    {
        Debug.Log($"Enum:{_arg}");
    }
    public void Func06(AnimationEvent _arg)
    {
        Debug.Log($"AnimationEvent float:{_arg}");
    }

    public void Func07(EventData _arg)
    {
        Debug.Log($"EventData Int:{_arg.Intdata}");
        Debug.Log($"EventData float:{_arg.Floatdata}");
    }

}
