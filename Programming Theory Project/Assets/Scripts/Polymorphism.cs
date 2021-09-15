using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// INHERITANCE (Polymorphism inherits from Pillar)
public class Polymorphism : Pillar
{
    private float polymorphismDisplayTime = 3f;

    // POLYMORPHISM
    public override IEnumerator DisplayText()
    {
        float fadeTime = 0;
        while (fadeTime < 1)
        {
            nameTag.color = Color.Lerp(Color.clear, Color.magenta, fadeTime);
            yield return null;
            fadeTime += Time.deltaTime / polymorphismDisplayTime;
        }
    }

    // POLYMORPHISM
    public override void SetPillarColor()
    {
        pillarColor = Color.magenta;
    }
}
