using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// INHERITANCE (Inheritance inherits from Pillar)
public class Inheritance : Pillar
{
    private float inheritanceDisplayTime = 4.0f;

    // POLYMORPHISM
    public override IEnumerator DisplayText()
    {
        float fadeTime = 0;
        while (fadeTime < 1)
        {
            nameTag.color = Color.Lerp(Color.clear, Color.cyan, fadeTime);
            yield return null;
            fadeTime += Time.deltaTime / inheritanceDisplayTime;
        }
    }

    // POLYMORPHISM
    public override void SetPillarColor()
    {
        pillarColor = Color.cyan;
    }
}
