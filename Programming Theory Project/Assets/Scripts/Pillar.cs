using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Pillar : MonoBehaviour
{
    [SerializeField] protected GameObject textObject;
    [SerializeField] protected string nameTagText;

    protected TextMesh nameTag;

    // ENCAPSULATION
    protected Color pillarColor { get { return PillarColor; } set { PillarColor = value; } }
    private Color PillarColor;


    void Start()
    {
        // ABSTRACTION
        GetNameTag();
        SetNameTag();
        SetPillarColor();
        SetColorOfPillar(PillarColor);
    }


    abstract public void SetPillarColor();

    // ABSTRACTION
    private void GetNameTag()
    {
        nameTag = textObject.GetComponent<TextMesh>();
    }

    // ABSTRACTION
    private void SetColorOfPillar(Color color)
    {
        gameObject.GetComponent<Renderer>().material.color = color;
    }

    // ABSTRACTION
    private void SetNameTag()
    {
        nameTag.text = nameTagText;
    }

    abstract public IEnumerator DisplayText();
}
