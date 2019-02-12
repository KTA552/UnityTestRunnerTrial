﻿using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace kt
{
    // なんとなくGlobalな空間にAssert起きたくなかったのでnamespaceで囲んだ
    using Assert = UnityEngine.Assertions.Assert;

    namespace Tests
    {
        public class NewTestScript
        {
            // A Test behaves as an ordinary method
            [Test]
            public void NewTestScriptSimplePasses()
            {
                // Use the Assert class to test conditions
            }

            [Test]
            public void NewTestScriptSimpleRun()
            {
                Assert.IsTrue(false);
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
    }


}

