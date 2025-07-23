using UnityEngine;
using UnityEditor;
using System;

public class MenuItemTest : MonoBehaviour {
    [ColorUsage(false, true)]
    [SerializeField] private Color testColor;
    [MenuItem("Astronautica/Do Something")]
    [MenuItem("Assets/There Was One/And then there was two/the third wasn't very happy/and the fourth is just confused/why are we still doing this?/Ok fine here you go")]
    public static void DoSomething() {
        Debug.Log("I did something");
    }

    [TextArea(10,20), SerializeField] private string essay;

    [ContextMenuItem("Change Text", "DoSomethingElse")]
    [SerializeField] private string thatSomething;
    private void DoSomethingElse() {
        thatSomething = "It worked!";
    }
}