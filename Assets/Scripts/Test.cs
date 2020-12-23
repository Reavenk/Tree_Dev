using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using PxPre.Tree;

public class Test : MonoBehaviour
{
    public PxPre.Tree.Tree tree;

    // Start is called before the first frame update
    void Start()
    {
        PxPre.Tree.Node firstEntry = tree.AddNode("First entry", null);
        PxPre.Tree.Node secondEntry = tree.AddNode("Second entry", null);
        PxPre.Tree.Node thirdEntry = tree.AddNode("Third entry", null);

        PxPre.Tree.Node firstChild1 = tree.AddNode("First child in first child", firstEntry);
        PxPre.Tree.Node firstChild2 = tree.AddNode("second one", firstEntry);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
