using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// INHERITANCE (Abstraction inherits from Pillar)
public class Abstraction : Pillar
{
    private float abstractionDisplayTime = 1f;


    // POLYMORPHISM
    public override IEnumerator DisplayText()
    {
        float fadeTime = 0;
        while (fadeTime < 1)
        {
            nameTag.color = Color.Lerp(Color.clear, Color.blue, fadeTime);
            yield return null;
            fadeTime += Time.deltaTime / abstractionDisplayTime;
        }
    }

    // POLYMORPHISM
    public override void SetPillarColor()
    {
        pillarColor = Color.blue;
    }
}
