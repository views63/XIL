using System;
using UnityEngine;
using UnityEngine.UI;
using wxb;
#pragma warning disable 169
#pragma warning disable 649

namespace hot
{
    [ReplaceType(typeof(Tsc))]
    public class HotT
    {
        private static Transform _tr;

        [ReplaceFunction]
        static void Awake(Tsc world)
        {
            //__Hotfix_Start.Invoke(world); // 调回HelloWorld.Start自身接口

            RefType refType = new RefType((object)world);
            var btn = refType.GetField<Button>("btn");
            _tr = refType.GetProperty<Transform>("transform");
            btn.onClick.AddListener(Onclick);
        }

        private static void Onclick()
        {
            var a = new GameObject();
            a.name = "ButtonB";
            a.transform.SetParent(_tr);
            a.transform.localPosition = new Vector3(0, 200);
            a.AddComponent<Image>();
            var b = a.AddComponent<Button>();
            b.onClick.AddListener(OnclickB);

            Debug.LogError("Onclick");
        }

        private static void OnclickB()
        {
            Debug.LogError("OnclickB");
        }
    }

}