using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.TestTools;

public class NewTestScript
{
    // A Test behaves as an ordinary method
    [Test]
    public void CreerObjetNonNull()
    {
        //ACT
        Transform[] points = new Transform[2];
        points[0].position = new Vector3(0,0,0);
        points[1].position = new Vector3(1,0,0);
        LogiquePatrouille logiqueTest = new LogiquePatrouille(points);

        //ARRANGE


        //ASSERT
        Assert.IsTrue(gameObject != null);
    }

    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator NewTestScriptWithEnumeratorPasses()
    {
        // Use the Assert class to test conditions.
        // Use yield to skip a frame.
        yield return null;
    }
}
