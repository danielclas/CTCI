using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CTCI
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void tIsUnique()
        {
            string test1 = "abcdefghjk";
            string test2 = "aaddndjqkeu";
            string test3 = "asdqwejk";
            string test4 = "iopqweruio";

            Assert.AreEqual(true, IsUnique.UniqueCharacters(test1));
            Assert.AreEqual(false, IsUnique.UniqueCharacters(test2));
            Assert.AreEqual(true, IsUnique.UniqueCharacters(test3));
            Assert.AreEqual(false, IsUnique.UniqueCharacters(test4));
        }

        [TestMethod]
        public void tCheckPermutation()
        {
            string test1 = "abcdefghijk";
            string test1s = "kjihgfedcba";

            string test2 = "This is a permutation";
            string test2s = "noitatumrep a si sihT";

            string test3 = "This should not work";
            string test3s = "should This works not";

            Assert.AreEqual(true, CheckPermutation.Check(test1, test1s));
            Assert.AreEqual(true, CheckPermutation.Check(test2, test2s));
            Assert.AreEqual(false, CheckPermutation.Check(test3, test3s));
        }

        [TestMethod]
        public void tURLify()
        {
            string test1 = "Mr John Smith     ";
            string success1 = "Mr%20John%20Smith";

            string test2 = "";
            string success2 = "";

            string test3 = "  This has been parsed";
            string success3 = "This%20has%20been%20parsed";

            Assert.AreEqual(success1, URLify.Parse(test1));
            Assert.AreEqual(success2, URLify.Parse(test2));
            Assert.AreEqual(success3, URLify.Parse(test3));
        }

        [TestMethod]
        public void tPalindrome()
        {
            string test1 = "Neuquen";
            string test2 = "aabbccddee";
            string test3 = "aaddbbeejjk";
            string test4 = "uiojkl";
            string test5 = "fffffff";
            string test6 = "yhujikojjhrtredsfr";
            string test7 = "Tact Coa";

            Assert.AreEqual(true, PalindromePermutation.IsPermutation(test1));
            Assert.AreEqual(true, PalindromePermutation.IsPermutation(test2));
            Assert.AreEqual(true, PalindromePermutation.IsPermutation(test3));
            Assert.AreEqual(false, PalindromePermutation.IsPermutation(test4));
            Assert.AreEqual(true, PalindromePermutation.IsPermutation(test5));
            Assert.AreEqual(false, PalindromePermutation.IsPermutation(test6));
            Assert.AreEqual(true, PalindromePermutation.IsPermutation(test7));
        }

        [TestMethod]
        public void tOneAway()
        {
            string[] test1 = new string[] { "pale", "ple" };
            string[] test2 = new string[] { "pales", "pale" };
            string[] test3 = new string[] { "pale", "bale" };
            string[] test4 = new string[] { "pale", "bake" };
            string[] test5 = new string[] { "first", "second" };
            string[] test6 = new string[] { "aabbcc", "aabbcck" };

            Assert.AreEqual(true, OneAway.Check(test1[0], test1[1]));
            Assert.AreEqual(true, OneAway.Check(test2[0], test2[1]));
            Assert.AreEqual(true, OneAway.Check(test3[0], test3[1]));
            Assert.AreEqual(false, OneAway.Check(test4[0], test4[1]));
            Assert.AreEqual(false, OneAway.Check(test5[0], test5[1]));
            Assert.AreEqual(true, OneAway.Check(test6[0], test6[1]));
        }

        [TestMethod]
        public void tCompression()
        {
            string test1 = "aabcccccaaa";
            string success1 = "a2b1c5a3";

            string test2 = "abcdefghi";
            string success2 = "abcdefghi";

            string test3 = "aaaaabbbbbaaaaajjjjj";
            string success3 = "a5b5a5j5";

            Assert.AreEqual(success1, StringCompression.Compress(test1));
            Assert.AreEqual(success2, StringCompression.Compress(test2));
            Assert.AreEqual(success3, StringCompression.Compress(test3));
        }

        [TestMethod]
        public void tRotateMatrix()
        {
            int[][] test1 = new int[4][];
            test1[0] = new int[] { 1, 2, 3, 4 };
            test1[1] = new int[] { 5, 6, 7, 8 };
            test1[2] = new int[] { 9, 10, 11, 12 };
            test1[3] = new int[] { 13, 14, 15, 16 };

            int[][] success1 = new int[4][];
            success1[0] = new int[] { 4, 8, 12, 16 };
            success1[1] = new int[] { 3, 7, 11, 15 };
            success1[2] = new int[] { 2, 6, 10, 14 };
            success1[3] = new int[] { 1, 5, 9, 13 };

            int[][] rotated1 = RotateMatrix.Rotate(test1);
            bool result1 = true;

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (rotated1[i][j] != success1[i][j])
                    {
                        result1 = false;
                        break;
                    }
                }
            }

            Assert.IsTrue(result1);
        }

        [TestMethod]
        public void tZeroMatrix()
        {

        }

        [TestMethod]
        public void tStringRotation()
        {
            string test1 = "waterbottle";
            string test2 = "wordsandstrings";
            string test3 = "automobile";

            Assert.IsTrue(StringRotation.IsRotation(test1, "erbottlewat"));
            Assert.IsFalse(StringRotation.IsRotation(test2, "asddd"));
            Assert.IsTrue(StringRotation.IsRotation(test3, "mobileauto"));
        }
    }
}
