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
    }
}
