using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class Test
    {
        // A Test behaves as an ordinary method
        [Test]
        public void TestSimplePasses()
        {
            string str = File.ReadAllText(Application.dataPath+"/Test.txt");
            Debug.Log(ArrayToString(SplitString(str)));
            string ArrayToString<T>(T[] array)
            {
                StringBuilder stringBuilder = new StringBuilder();
                string comma = ",";
                for (int i = 0; i < array.Length; i++)
                {
                    string separator = (i < array.Length - 1) ? comma : string.Empty;
                    stringBuilder.Append($"{array[i].ToString()} {separator} ");
                }

                return stringBuilder.ToString();
            }
        }
        public static string[] SplitString(string text)
        {
            if (text.Length<=2)
            {
                return new[] {text};
            }
            
            List<(int,int)> indexList = new List<(int, int)>();
            int start = 0;
            int index = 0;
            while (index < text.Length)
            {
                int end = text.IndexOf('"', index + 1);
                if (text[end-1] != '\\')
                {
                    indexList.Add((start+1,end-start-1));
                    if (end+1 < text.Length)
                    {
                        index = text.IndexOf('"', end+1);
                        start = index;
                    }
                    else
                    {
                        index = text.Length;
                        start = index;
                    }
                }
                else
                {
                    index = end;
                }
            }
            string[] array = new string[indexList.Count];
            for (var i = 0; i < indexList.Count; i++)
            {
                (int, int) value = indexList[i];
                array[i] = text.Substring(value.Item1, value.Item2);
            }

            return array;
        }
        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator TestWithEnumeratorPasses()
        {
            // Use the Assert class to test conditions.
            // Use yield to skip a frame.
            yield return null;
        }
    }
}
