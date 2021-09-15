using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// INHERITANCE (Encapsulation inherits from Pillar)
public class Encapsulation : Pillar
{
    private float encapsulationDisplayTime = 2f;

    // POLYMORPHISM
    public override IEnumerator DisplayText()
    {
        float fadeTime = 0;
        while (fadeTime < 1)
        {
            nameTag.color = Color.Lerp(Color.clear, Color.yellow, fadeTime);
            yield return null;
            fadeTime += Time.deltaTime / encapsulationDisplayTime;
        }
    }

    // POLYMORPHISM
    public override void SetPillarColor()
    {
        pillarColor = Color.yellow;
    }
}
